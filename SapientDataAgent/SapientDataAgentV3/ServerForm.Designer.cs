﻿// Project:           $Project: 00010855-Sapient$
// File:              $Workfile: ServerForm.Designer.cs$
// Crown-Owned Copyright (c) supplied by QinetiQ. See Release/Supply Conditions
// $NoKeywords$

namespace SapientMiddleware
{
    /// <summary>
    /// Class for form displaying dynamic message counts
    /// </summary>
    public partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SensorRegistration = new System.Windows.Forms.TextBox();
            this.StatusReport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SensorTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DetectionReport = new System.Windows.Forms.TextBox();
            this.SensorTaskAck = new System.Windows.Forms.TextBox();
            this.ErrorOnId = new System.Windows.Forms.TextBox();
            this.UnknownClient = new System.Windows.Forms.TextBox();
            this.UnknownTask = new System.Windows.Forms.TextBox();
            this.Unrecognised = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TaskManagerConnected = new System.Windows.Forms.CheckBox();
            this.ClientsConnected = new System.Windows.Forms.TextBox();
            this.AlertResponse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Alert = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GUIclientsConnected = new System.Windows.Forms.TextBox();
            this.guiClientsLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.InternalError = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RegistrationTime = new System.Windows.Forms.TextBox();
            this.statusReportTime = new System.Windows.Forms.TextBox();
            this.detectionReportTime = new System.Windows.Forms.TextBox();
            this.sensorTaskTime = new System.Windows.Forms.TextBox();
            this.taskAckTime = new System.Windows.Forms.TextBox();
            this.alertTime = new System.Windows.Forms.TextBox();
            this.alertResponseTime = new System.Windows.Forms.TextBox();
            this.idErrorTime = new System.Windows.Forms.TextBox();
            this.invalidClientTime = new System.Windows.Forms.TextBox();
            this.invalidTaskTime = new System.Windows.Forms.TextBox();
            this.unrecognisedTime = new System.Windows.Forms.TextBox();
            this.internalErrorTime = new System.Windows.Forms.TextBox();
            this.databaseLatencyTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.commsLatencyTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clientInfoTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.recentMsgStatusIndicator = new SapientMiddleware.StatusIndicator();
            this.databaseLatencyStatusIndicator = new SapientMiddleware.StatusIndicator();
            this.commsLatencyStatusIndicator = new SapientMiddleware.StatusIndicator();
            this.clientStatusIndicator = new SapientMiddleware.StatusIndicator();
            this.taskConnectionStatusIndicator = new SapientMiddleware.StatusIndicator();
            this.btnOffsets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // SensorRegistration
            // 
            this.SensorRegistration.Enabled = false;
            this.SensorRegistration.Location = new System.Drawing.Point(93, 235);
            this.SensorRegistration.Name = "SensorRegistration";
            this.SensorRegistration.ReadOnly = true;
            this.SensorRegistration.Size = new System.Drawing.Size(50, 20);
            this.SensorRegistration.TabIndex = 1;
            this.SensorRegistration.Text = "0";
            // 
            // StatusReport
            // 
            this.StatusReport.Enabled = false;
            this.StatusReport.Location = new System.Drawing.Point(93, 261);
            this.StatusReport.Name = "StatusReport";
            this.StatusReport.ReadOnly = true;
            this.StatusReport.Size = new System.Drawing.Size(50, 20);
            this.StatusReport.TabIndex = 3;
            this.StatusReport.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status Report";
            // 
            // SensorTask
            // 
            this.SensorTask.Enabled = false;
            this.SensorTask.Location = new System.Drawing.Point(93, 313);
            this.SensorTask.Name = "SensorTask";
            this.SensorTask.ReadOnly = true;
            this.SensorTask.Size = new System.Drawing.Size(50, 20);
            this.SensorTask.TabIndex = 5;
            this.SensorTask.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sensor Task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sensor Task Ack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detection Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Error On Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Invalid Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Invalid Tasking";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Unrecognised";
            // 
            // DetectionReport
            // 
            this.DetectionReport.Enabled = false;
            this.DetectionReport.Location = new System.Drawing.Point(93, 287);
            this.DetectionReport.Name = "DetectionReport";
            this.DetectionReport.ReadOnly = true;
            this.DetectionReport.Size = new System.Drawing.Size(50, 20);
            this.DetectionReport.TabIndex = 12;
            this.DetectionReport.Text = "0";
            // 
            // SensorTaskAck
            // 
            this.SensorTaskAck.Enabled = false;
            this.SensorTaskAck.Location = new System.Drawing.Point(93, 339);
            this.SensorTaskAck.Name = "SensorTaskAck";
            this.SensorTaskAck.ReadOnly = true;
            this.SensorTaskAck.Size = new System.Drawing.Size(50, 20);
            this.SensorTaskAck.TabIndex = 13;
            this.SensorTaskAck.Text = "0";
            // 
            // ErrorOnId
            // 
            this.ErrorOnId.Enabled = false;
            this.ErrorOnId.Location = new System.Drawing.Point(93, 417);
            this.ErrorOnId.Name = "ErrorOnId";
            this.ErrorOnId.ReadOnly = true;
            this.ErrorOnId.Size = new System.Drawing.Size(50, 20);
            this.ErrorOnId.TabIndex = 14;
            this.ErrorOnId.Text = "0";
            // 
            // UnknownClient
            // 
            this.UnknownClient.Enabled = false;
            this.UnknownClient.Location = new System.Drawing.Point(93, 443);
            this.UnknownClient.Name = "UnknownClient";
            this.UnknownClient.ReadOnly = true;
            this.UnknownClient.Size = new System.Drawing.Size(50, 20);
            this.UnknownClient.TabIndex = 15;
            this.UnknownClient.Text = "0";
            // 
            // UnknownTask
            // 
            this.UnknownTask.Enabled = false;
            this.UnknownTask.Location = new System.Drawing.Point(93, 469);
            this.UnknownTask.Name = "UnknownTask";
            this.UnknownTask.ReadOnly = true;
            this.UnknownTask.Size = new System.Drawing.Size(50, 20);
            this.UnknownTask.TabIndex = 16;
            this.UnknownTask.Text = "0";
            // 
            // Unrecognised
            // 
            this.Unrecognised.Enabled = false;
            this.Unrecognised.Location = new System.Drawing.Point(93, 495);
            this.Unrecognised.Name = "Unrecognised";
            this.Unrecognised.ReadOnly = true;
            this.Unrecognised.Size = new System.Drawing.Size(50, 20);
            this.Unrecognised.TabIndex = 17;
            this.Unrecognised.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Clients Connected";
            // 
            // TaskManagerConnected
            // 
            this.TaskManagerConnected.AutoSize = true;
            this.TaskManagerConnected.Enabled = false;
            this.TaskManagerConnected.Location = new System.Drawing.Point(12, 36);
            this.TaskManagerConnected.Name = "TaskManagerConnected";
            this.TaskManagerConnected.Size = new System.Drawing.Size(119, 17);
            this.TaskManagerConnected.TabIndex = 19;
            this.TaskManagerConnected.Text = "Tasking Connected";
            this.TaskManagerConnected.UseVisualStyleBackColor = true;
            // 
            // ClientsConnected
            // 
            this.ClientsConnected.Enabled = false;
            this.ClientsConnected.Location = new System.Drawing.Point(101, 6);
            this.ClientsConnected.Name = "ClientsConnected";
            this.ClientsConnected.ReadOnly = true;
            this.ClientsConnected.Size = new System.Drawing.Size(50, 20);
            this.ClientsConnected.TabIndex = 20;
            this.ClientsConnected.Text = "0";
            // 
            // AlertResponse
            // 
            this.AlertResponse.Enabled = false;
            this.AlertResponse.Location = new System.Drawing.Point(93, 391);
            this.AlertResponse.Name = "AlertResponse";
            this.AlertResponse.ReadOnly = true;
            this.AlertResponse.Size = new System.Drawing.Size(50, 20);
            this.AlertResponse.TabIndex = 24;
            this.AlertResponse.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Alert Response";
            // 
            // Alert
            // 
            this.Alert.Enabled = false;
            this.Alert.Location = new System.Drawing.Point(93, 365);
            this.Alert.Name = "Alert";
            this.Alert.ReadOnly = true;
            this.Alert.Size = new System.Drawing.Size(50, 20);
            this.Alert.TabIndex = 22;
            this.Alert.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Alert";
            // 
            // GUIclientsConnected
            // 
            this.GUIclientsConnected.Enabled = false;
            this.GUIclientsConnected.Location = new System.Drawing.Point(93, 541);
            this.GUIclientsConnected.Name = "GUIclientsConnected";
            this.GUIclientsConnected.ReadOnly = true;
            this.GUIclientsConnected.Size = new System.Drawing.Size(50, 20);
            this.GUIclientsConnected.TabIndex = 26;
            this.GUIclientsConnected.Text = "0";
            // 
            // guiClientsLabel
            // 
            this.guiClientsLabel.AutoSize = true;
            this.guiClientsLabel.Location = new System.Drawing.Point(7, 544);
            this.guiClientsLabel.Name = "guiClientsLabel";
            this.guiClientsLabel.Size = new System.Drawing.Size(86, 13);
            this.guiClientsLabel.TabIndex = 25;
            this.guiClientsLabel.Text = "GUIs Connected";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(127, 36);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(50, 23);
            this.resetBtn.TabIndex = 27;
            this.resetBtn.Text = "Resize";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InternalError
            // 
            this.InternalError.Enabled = false;
            this.InternalError.Location = new System.Drawing.Point(93, 518);
            this.InternalError.Name = "InternalError";
            this.InternalError.ReadOnly = true;
            this.InternalError.Size = new System.Drawing.Size(50, 20);
            this.InternalError.TabIndex = 31;
            this.InternalError.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Middleware Error";
            // 
            // RegistrationTime
            // 
            this.RegistrationTime.Enabled = false;
            this.RegistrationTime.Location = new System.Drawing.Point(149, 235);
            this.RegistrationTime.Name = "RegistrationTime";
            this.RegistrationTime.ReadOnly = true;
            this.RegistrationTime.Size = new System.Drawing.Size(65, 20);
            this.RegistrationTime.TabIndex = 32;
            // 
            // statusReportTime
            // 
            this.statusReportTime.Enabled = false;
            this.statusReportTime.Location = new System.Drawing.Point(149, 261);
            this.statusReportTime.Name = "statusReportTime";
            this.statusReportTime.ReadOnly = true;
            this.statusReportTime.Size = new System.Drawing.Size(65, 20);
            this.statusReportTime.TabIndex = 33;
            // 
            // detectionReportTime
            // 
            this.detectionReportTime.Enabled = false;
            this.detectionReportTime.Location = new System.Drawing.Point(149, 287);
            this.detectionReportTime.Name = "detectionReportTime";
            this.detectionReportTime.ReadOnly = true;
            this.detectionReportTime.Size = new System.Drawing.Size(65, 20);
            this.detectionReportTime.TabIndex = 34;
            // 
            // sensorTaskTime
            // 
            this.sensorTaskTime.Enabled = false;
            this.sensorTaskTime.Location = new System.Drawing.Point(149, 313);
            this.sensorTaskTime.Name = "sensorTaskTime";
            this.sensorTaskTime.ReadOnly = true;
            this.sensorTaskTime.Size = new System.Drawing.Size(65, 20);
            this.sensorTaskTime.TabIndex = 35;
            // 
            // taskAckTime
            // 
            this.taskAckTime.Enabled = false;
            this.taskAckTime.Location = new System.Drawing.Point(149, 339);
            this.taskAckTime.Name = "taskAckTime";
            this.taskAckTime.ReadOnly = true;
            this.taskAckTime.Size = new System.Drawing.Size(65, 20);
            this.taskAckTime.TabIndex = 36;
            // 
            // alertTime
            // 
            this.alertTime.Enabled = false;
            this.alertTime.Location = new System.Drawing.Point(149, 365);
            this.alertTime.Name = "alertTime";
            this.alertTime.ReadOnly = true;
            this.alertTime.Size = new System.Drawing.Size(65, 20);
            this.alertTime.TabIndex = 37;
            // 
            // alertResponseTime
            // 
            this.alertResponseTime.Enabled = false;
            this.alertResponseTime.Location = new System.Drawing.Point(149, 391);
            this.alertResponseTime.Name = "alertResponseTime";
            this.alertResponseTime.ReadOnly = true;
            this.alertResponseTime.Size = new System.Drawing.Size(65, 20);
            this.alertResponseTime.TabIndex = 38;
            // 
            // idErrorTime
            // 
            this.idErrorTime.Enabled = false;
            this.idErrorTime.Location = new System.Drawing.Point(149, 417);
            this.idErrorTime.Name = "idErrorTime";
            this.idErrorTime.ReadOnly = true;
            this.idErrorTime.Size = new System.Drawing.Size(65, 20);
            this.idErrorTime.TabIndex = 39;
            // 
            // invalidClientTime
            // 
            this.invalidClientTime.Enabled = false;
            this.invalidClientTime.Location = new System.Drawing.Point(149, 443);
            this.invalidClientTime.Name = "invalidClientTime";
            this.invalidClientTime.ReadOnly = true;
            this.invalidClientTime.Size = new System.Drawing.Size(65, 20);
            this.invalidClientTime.TabIndex = 40;
            // 
            // invalidTaskTime
            // 
            this.invalidTaskTime.Enabled = false;
            this.invalidTaskTime.Location = new System.Drawing.Point(149, 469);
            this.invalidTaskTime.Name = "invalidTaskTime";
            this.invalidTaskTime.ReadOnly = true;
            this.invalidTaskTime.Size = new System.Drawing.Size(65, 20);
            this.invalidTaskTime.TabIndex = 41;
            // 
            // unrecognisedTime
            // 
            this.unrecognisedTime.Enabled = false;
            this.unrecognisedTime.Location = new System.Drawing.Point(149, 495);
            this.unrecognisedTime.Name = "unrecognisedTime";
            this.unrecognisedTime.ReadOnly = true;
            this.unrecognisedTime.Size = new System.Drawing.Size(65, 20);
            this.unrecognisedTime.TabIndex = 42;
            // 
            // internalErrorTime
            // 
            this.internalErrorTime.Enabled = false;
            this.internalErrorTime.Location = new System.Drawing.Point(149, 518);
            this.internalErrorTime.Name = "internalErrorTime";
            this.internalErrorTime.ReadOnly = true;
            this.internalErrorTime.Size = new System.Drawing.Size(65, 20);
            this.internalErrorTime.TabIndex = 43;
            // 
            // databaseLatencyTextBox
            // 
            this.databaseLatencyTextBox.Enabled = false;
            this.databaseLatencyTextBox.Location = new System.Drawing.Point(101, 159);
            this.databaseLatencyTextBox.Name = "databaseLatencyTextBox";
            this.databaseLatencyTextBox.ReadOnly = true;
            this.databaseLatencyTextBox.Size = new System.Drawing.Size(65, 20);
            this.databaseLatencyTextBox.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Database Latency";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Comms Latency";
            // 
            // commsLatencyTextBox
            // 
            this.commsLatencyTextBox.Enabled = false;
            this.commsLatencyTextBox.Location = new System.Drawing.Point(101, 121);
            this.commsLatencyTextBox.Name = "commsLatencyTextBox";
            this.commsLatencyTextBox.ReadOnly = true;
            this.commsLatencyTextBox.Size = new System.Drawing.Size(65, 20);
            this.commsLatencyTextBox.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Client:";
            // 
            // clientInfoTextBox
            // 
            this.clientInfoTextBox.Enabled = false;
            this.clientInfoTextBox.Location = new System.Drawing.Point(86, 72);
            this.clientInfoTextBox.Name = "clientInfoTextBox";
            this.clientInfoTextBox.ReadOnly = true;
            this.clientInfoTextBox.Size = new System.Drawing.Size(136, 20);
            this.clientInfoTextBox.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(86, 98);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(136, 20);
            this.statusTextBox.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(90, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Recent Messages";
            // 
            // recentMsgStatusIndicator
            // 
            this.recentMsgStatusIndicator.BackgroundImage = global::SapientMiddleware.Properties.Resources.redLight;
            this.recentMsgStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recentMsgStatusIndicator.Location = new System.Drawing.Point(190, 197);
            this.recentMsgStatusIndicator.Name = "recentMsgStatusIndicator";
            this.recentMsgStatusIndicator.Size = new System.Drawing.Size(32, 32);
            this.recentMsgStatusIndicator.TabIndex = 54;
            // 
            // databaseLatencyStatusIndicator
            // 
            this.databaseLatencyStatusIndicator.BackgroundImage = global::SapientMiddleware.Properties.Resources.redLight;
            this.databaseLatencyStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseLatencyStatusIndicator.Location = new System.Drawing.Point(190, 159);
            this.databaseLatencyStatusIndicator.Name = "databaseLatencyStatusIndicator";
            this.databaseLatencyStatusIndicator.Size = new System.Drawing.Size(32, 32);
            this.databaseLatencyStatusIndicator.TabIndex = 53;
            // 
            // commsLatencyStatusIndicator
            // 
            this.commsLatencyStatusIndicator.BackgroundImage = global::SapientMiddleware.Properties.Resources.redLight;
            this.commsLatencyStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commsLatencyStatusIndicator.Location = new System.Drawing.Point(190, 121);
            this.commsLatencyStatusIndicator.Name = "commsLatencyStatusIndicator";
            this.commsLatencyStatusIndicator.Size = new System.Drawing.Size(32, 32);
            this.commsLatencyStatusIndicator.TabIndex = 52;
            // 
            // clientStatusIndicator
            // 
            this.clientStatusIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientStatusIndicator.BackgroundImage")));
            this.clientStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientStatusIndicator.Location = new System.Drawing.Point(190, 2);
            this.clientStatusIndicator.Name = "clientStatusIndicator";
            this.clientStatusIndicator.Size = new System.Drawing.Size(32, 32);
            this.clientStatusIndicator.TabIndex = 29;
            // 
            // taskConnectionStatusIndicator
            // 
            this.taskConnectionStatusIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskConnectionStatusIndicator.BackgroundImage")));
            this.taskConnectionStatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskConnectionStatusIndicator.Location = new System.Drawing.Point(190, 36);
            this.taskConnectionStatusIndicator.Name = "taskConnectionStatusIndicator";
            this.taskConnectionStatusIndicator.Size = new System.Drawing.Size(32, 32);
            this.taskConnectionStatusIndicator.TabIndex = 28;
            // 
            // btnOffsets
            // 
            this.btnOffsets.Location = new System.Drawing.Point(149, 542);
            this.btnOffsets.Name = "btnOffsets";
            this.btnOffsets.Size = new System.Drawing.Size(64, 18);
            this.btnOffsets.TabIndex = 56;
            this.btnOffsets.Text = "Offsets";
            this.btnOffsets.UseVisualStyleBackColor = true;
            this.btnOffsets.Click += new System.EventHandler(this.btnOffsets_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 569);
            this.Controls.Add(this.btnOffsets);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.recentMsgStatusIndicator);
            this.Controls.Add(this.databaseLatencyStatusIndicator);
            this.Controls.Add(this.commsLatencyStatusIndicator);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.clientInfoTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.commsLatencyTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.databaseLatencyTextBox);
            this.Controls.Add(this.internalErrorTime);
            this.Controls.Add(this.unrecognisedTime);
            this.Controls.Add(this.invalidTaskTime);
            this.Controls.Add(this.invalidClientTime);
            this.Controls.Add(this.idErrorTime);
            this.Controls.Add(this.alertResponseTime);
            this.Controls.Add(this.alertTime);
            this.Controls.Add(this.taskAckTime);
            this.Controls.Add(this.sensorTaskTime);
            this.Controls.Add(this.detectionReportTime);
            this.Controls.Add(this.statusReportTime);
            this.Controls.Add(this.RegistrationTime);
            this.Controls.Add(this.InternalError);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clientStatusIndicator);
            this.Controls.Add(this.taskConnectionStatusIndicator);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.GUIclientsConnected);
            this.Controls.Add(this.guiClientsLabel);
            this.Controls.Add(this.AlertResponse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ClientsConnected);
            this.Controls.Add(this.TaskManagerConnected);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Unrecognised);
            this.Controls.Add(this.UnknownTask);
            this.Controls.Add(this.UnknownClient);
            this.Controls.Add(this.ErrorOnId);
            this.Controls.Add(this.SensorTaskAck);
            this.Controls.Add(this.DetectionReport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SensorTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SensorRegistration);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ServerForm";
            this.Text = "Sapient Data Agent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.Load += new System.EventHandler(this.ServerFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox SensorRegistration;
        internal System.Windows.Forms.TextBox StatusReport;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox SensorTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox DetectionReport;
        internal System.Windows.Forms.TextBox SensorTaskAck;
        internal System.Windows.Forms.TextBox ErrorOnId;
        internal System.Windows.Forms.TextBox UnknownClient;
        internal System.Windows.Forms.TextBox UnknownTask;
        internal System.Windows.Forms.TextBox Unrecognised;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox TaskManagerConnected;
        private System.Windows.Forms.TextBox ClientsConnected;
        internal System.Windows.Forms.TextBox AlertResponse;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox Alert;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox GUIclientsConnected;
        public System.Windows.Forms.Label guiClientsLabel;
        private System.Windows.Forms.Button resetBtn;
        internal StatusIndicator taskConnectionStatusIndicator;
        internal StatusIndicator clientStatusIndicator;
        internal System.Windows.Forms.TextBox InternalError;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox RegistrationTime;
        internal System.Windows.Forms.TextBox statusReportTime;
        internal System.Windows.Forms.TextBox detectionReportTime;
        internal System.Windows.Forms.TextBox sensorTaskTime;
        internal System.Windows.Forms.TextBox taskAckTime;
        internal System.Windows.Forms.TextBox alertTime;
        internal System.Windows.Forms.TextBox alertResponseTime;
        internal System.Windows.Forms.TextBox idErrorTime;
        internal System.Windows.Forms.TextBox invalidClientTime;
        internal System.Windows.Forms.TextBox invalidTaskTime;
        internal System.Windows.Forms.TextBox unrecognisedTime;
        internal System.Windows.Forms.TextBox internalErrorTime;
        internal System.Windows.Forms.TextBox databaseLatencyTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox commsLatencyTextBox;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox clientInfoTextBox;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox statusTextBox;
        internal StatusIndicator commsLatencyStatusIndicator;
        internal StatusIndicator databaseLatencyStatusIndicator;
        internal StatusIndicator recentMsgStatusIndicator;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnOffsets;
    }
}