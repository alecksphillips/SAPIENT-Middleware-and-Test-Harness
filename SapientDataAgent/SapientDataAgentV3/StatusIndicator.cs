﻿// Project:           $Project: 00010855-Sapient$
// File:              $Workfile: StatusIndicator.cs$
// Crown-Owned Copyright (c) supplied by QinetiQ. See Release/Supply Conditions
// $NoKeywords$

namespace SapientMiddleware
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// User control to provide a red/green indicator.
    /// </summary>
    public partial class StatusIndicator : UserControl
    {
        /// <summary>
        /// Current indicator state
        /// </summary>
        private bool currentState = false;

        private bool warning = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusIndicator" /> class.
        /// </summary>
        public StatusIndicator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set Indicator state.
        /// </summary>
        /// <param name="state">indicator state.</param>
        public void SetStatus(bool state)
        {
            if ((currentState != state) || warning)
            {
                currentState = state;
                warning = false;

                if (state)
                {
                    this.BackgroundImage = Properties.Resources.greenLight;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.redLight;
                }
            }
        }

        /// <summary>
        /// Set Indicator to warning - yellow.
        /// </summary>
        public void SetStatusWarning()
        {
            this.BackgroundImage = Properties.Resources.yellowLight;
            warning = true;
        }
    }
}
