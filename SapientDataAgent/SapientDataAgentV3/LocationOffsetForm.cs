﻿// Project:           $Project: 00010855-Sapient$
// File:              $Workfile: LocationOffsetForm.cs$
// Crown-Owned Copyright (c) supplied by QinetiQ. See Release/Supply Conditions
// $NoKeywords$

namespace SapientMiddleware
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using SapientDatabase;
 
    /// <summary>
    /// Class for a form setting sensor location offsets.
    /// </summary>
    public partial class LocationOffsetForm : Form
    {
        private Database sapientDatabase;
        private Dictionary<long, Dictionary<string, double>> sensorLocationOffsets;
        private string databaseServer = Properties.Settings.Default.DatabaseServer;
        private string databasePort = Properties.Settings.Default.DatabasePort;
        private string databaseName = Properties.Settings.Default.DatabaseName;
        private string databaseUser = Properties.Settings.Default.DatabaseUser;
        private string databasePassword = Properties.Settings.Default.DatabasePassword;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationOffsetForm" /> class.
        /// load offset form, get sensor offset data from database.
        /// </summary>
        public LocationOffsetForm()
        {
            this.sapientDatabase = new Database(databaseServer, databasePort, databaseUser, databasePassword, databaseName);
            sensorLocationOffsets = sapientDatabase.GetSensorOffsetFromDB();
            InitializeComponent();
            if (sensorLocationOffsets.Count > 0)
            {
                this.cboxSensorID.DataSource = new BindingSource(sensorLocationOffsets, null);
                this.cboxSensorID.DisplayMember = "Key";
                this.cboxSensorID.ValueMember = "Key";
            }

            PopulateFields();
        }

        /// <summary>
        /// update sensor offset data in database and update dictionary.
        /// </summary>
        /// <param name="sender">sending object.</param>
        /// <param name="e">not used.</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            long sensorID;
            double x_offset, y_offset, z_offset, az_offset, ele_offset;
            if (long.TryParse(this.cboxSensorID.Text, out sensorID) && double.TryParse(this.xOffset.Text, out x_offset) && double.TryParse(this.yOffset.Text, out y_offset) && double.TryParse(this.zOffset.Text, out z_offset) && double.TryParse(this.azOffset.Text, out az_offset) && double.TryParse(this.eleOffset.Text, out ele_offset))
            {
                sapientDatabase.UpdateSensorOffsetInDB(sensorID, x_offset, y_offset, z_offset, az_offset, ele_offset);
                if (sensorLocationOffsets.ContainsKey(sensorID))
                {
                    sensorLocationOffsets[sensorID]["x_offset"] = x_offset;
                    sensorLocationOffsets[sensorID]["y_offset"] = y_offset;
                    sensorLocationOffsets[sensorID]["z_offset"] = z_offset;
                    sensorLocationOffsets[sensorID]["az_offset"] = az_offset;
                    sensorLocationOffsets[sensorID]["ele_offset"] = ele_offset;
                }
                else
                {
                    sensorLocationOffsets.Add(sensorID, new Dictionary<string, double>()
                    {
                    { "x_offset", x_offset },
                    { "y_offset", y_offset },
                    { "z_offset", z_offset },
                    { "az_offset", az_offset },
                    { "ele_offset", ele_offset },
                    });
                }

                if (this.cboxSensorID.DataSource == null)
                {
                    this.cboxSensorID.DataSource = new BindingSource(sensorLocationOffsets, null);
                    this.cboxSensorID.DisplayMember = "Key";
                    this.cboxSensorID.ValueMember = "Key";
                }
            }
        }

        /// <summary>
        /// update UI fields for ID selection.
        /// </summary>
        /// <param name="sender">sending object.</param>
        /// <param name="e">not used.</param>
        private void cboxSensorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            long sensorID;
            if (long.TryParse(this.cboxSensorID.Text, out sensorID) && sensorLocationOffsets.ContainsKey(sensorID))
            {
                this.xOffset.Text = sensorLocationOffsets[sensorID]["x_offset"].ToString();
                this.yOffset.Text = sensorLocationOffsets[sensorID]["y_offset"].ToString();
                this.zOffset.Text = sensorLocationOffsets[sensorID]["z_offset"].ToString();
                this.azOffset.Text = sensorLocationOffsets[sensorID]["az_offset"].ToString();
                this.eleOffset.Text = sensorLocationOffsets[sensorID]["ele_offset"].ToString();
            }
            else
            {
                this.xOffset.Text = string.Empty;
                this.yOffset.Text = string.Empty;
                this.zOffset.Text = string.Empty;
                this.azOffset.Text = string.Empty;
                this.eleOffset.Text = string.Empty;
            }
        }

        /// <summary>
        /// populate the offset fields on initialisation.
        /// </summary>
        private void PopulateFields()
        {
            if (sensorLocationOffsets.Count > 0)
            {
                long sensorID = sensorLocationOffsets.First().Key;
                this.xOffset.Text = sensorLocationOffsets[sensorID]["x_offset"].ToString();
                this.yOffset.Text = sensorLocationOffsets[sensorID]["y_offset"].ToString();
                this.zOffset.Text = sensorLocationOffsets[sensorID]["z_offset"].ToString();
                this.azOffset.Text = sensorLocationOffsets[sensorID]["az_offset"].ToString();
                this.eleOffset.Text = sensorLocationOffsets[sensorID]["ele_offset"].ToString();
            }
        }

        /// <summary>
        /// dismiss window.
        /// </summary>
        /// <param name="sender">sending object.</param>
        /// <param name="e">not used.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
