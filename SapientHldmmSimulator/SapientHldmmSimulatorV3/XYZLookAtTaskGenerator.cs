﻿// Project:           $Project: 00010855-Sapient$
// File:              $Workfile: XYZLookAtTaskGenerator.cs$
// Crown-Owned Copyright (c) supplied by QinetiQ. See Release/Supply Conditions

using System;
using System.Threading;
using log4net;
using SapientServices.Communication;
using SapientServices.Data;

namespace SapientHldmmSimulator
{
    /// <summary>
    /// Generate Look At Sensor Task messages
    /// </summary>
    public class XYZLookAtTaskGenerator : TaskGenerator
    {
        /// <summary>
        /// log4net logger
        /// </summary>
        private static ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="useZ">whether to include Z coordinate</param>
        /// <param name="comms_connection">IConnection messenger object used to send messages over</param>
        /// <param name="baseSensorID">base sensor Identifier</param>
        /// <param name="numSensors">Number of sensors</param>
        public void GenerateXYZLookAtTask(double x, double y, double z, bool useZ, object comms_connection, int baseSensorID, int numSensors)
        {
            IConnection messenger = (IConnection)comms_connection;
            do
            {
                SendTaskToMultipleSensors(x, y, z, useZ, comms_connection, baseSensorID, taskId, numSensors);

                if (ChangeTaskID)
                {
                    taskId++;
                }

                if (LoopMessages) Thread.Sleep(LoopTime);
            } while (LoopMessages);
        }

        /// <summary>
        /// Send XYZ Tasks for one or more sensors
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="useZ">whether to include Z coordinate</param>
        /// <param name="comms_connection">IConnection messenger object used to send messages over</param>
        /// <param name="baseSensorID">base sensor Identifier</param>
        /// <param name="taskId"task ID>task Identifier</param>
        /// <param name="numSensors">Number of sensors</param>
        private static void SendTaskToMultipleSensors(double x, double y, double z, bool useZ, object comms_connection, int baseSensorID, int taskId, int numSensors)
        {
            var messenger = (IConnection)comms_connection;

            int sensorNum;
            for (sensorNum = 0; sensorNum < numSensors; sensorNum++)
            {
                int sensorId = sensorNum + baseSensorID;
                SensorTask sensorTask = GenerateXYZTask(x, y, z, useZ, sensorId, taskId);

                string xmlstring = ConfigXMLParser.Serialize(sensorTask);

                Log.Debug(xmlstring);

                bool retval = MessageSender.Send(messenger, xmlstring);

                if (retval)
                {
                    Log.InfoFormat("Sent LookAtCommand:{0} to SensorID:{1}", taskId, sensorId);
                }
                else
                {
                    Log.InfoFormat("Sent LookAtCommand:{0} to SensorID:{1} FAILED", taskId, sensorId);
                }
            }
        }

        /// <summary>
        /// generate the XYZ lookAt task message
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="useZ">whether to include Z coordinate</param>
        /// <param name="sensorId">sensor identifier</param>
        /// <param name="taskId">task identifier</param>
        /// <returns>Populated SensorTask object</returns>
        private static SensorTask GenerateXYZTask(double x, double y, double z, bool useZ, int sensorId, int taskId)
        {
            var sensor_task = new SensorTask
            {
                sensorID = sensorId,
                taskID = taskId,
                timestamp = DateTime.UtcNow,
                control = "Start",
            };

            sensor_task.command = new SensorTaskCommand();

            if (SendToHldmm)
            {
                sensor_task.taskName = "Manual Task";
                sensor_task.sensorID = 0;
                sensor_task.command.sensorID = sensorId;
                sensor_task.command.sensorIDSpecified = true;
            }

            sensor_task.command.lookAt = new SensorTaskCommandLookAt
            {
                locationList = new locationList
                {
                    location = new[]
                    {
                        new location
                        {
                            X = x,
                            Y = y,
                            Z = z,
                            ZSpecified = useZ
                        }
                    }
                }
            };

            return sensor_task;
        }
    }
}
