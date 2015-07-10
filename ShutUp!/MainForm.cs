/*
        ShutUp! v .0.2 - Shuts down the PC using shutdown.exe provided with Windows.
        Developed becasue I was too lazy to get up in the middle of the night to shut down
        my computer when I'm finished watching movies.
 
        Copyright (C) 2014 Christopher Ilkow

        This program is free software: you can redistribute it and/or modify
        it under the terms of the GNU General Public License as published by
        the Free Software Foundation, either version 3 of the License, or
        (at your option) any later version.

        This program is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        GNU General Public License for more details.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ShutUp_
{
    public partial class MainForm : Form
    {
        ShutUp ShutUp;
        Thread ShutUpThread;
        int ms = 0;
        int value;
        public MainForm()
        {
            InitializeComponent();
            ShutUp = new ShutUp();
        }
        private int GetMs()
        {
            ms = 0;
            if (isInteger(txtHrs) > 0)
            {
                ms = ms + isInteger(txtHrs) * 60 * 60;
            }
            if (isInteger(txtMins) > 0)
            {
                ms = ms + 60 * isInteger(txtMins);
            }
            if (isInteger(txtSecs) > 0)
            {
                ms = ms + isInteger(txtSecs);
            }
            return ms * 1000;
        }

        private int isInteger(TextBox box)
        {

            value = 0;
            try
            {
                value = Convert.ToInt32(box.Text);
            }
            catch (FormatException)
            {

            }
            return value;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            ms = GetMs();
            if (ShutUpThread == null)
            {
                ShutUpThread = new Thread(() => ShutUp.StartShutdown(ms));
                ShutUpThread.Start();
            }
            else if (ShutUpThread.IsAlive)
            {
                MessageBox.Show("Shutdown already started. Stop first");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (ShutUpThread == null)
            {
                MessageBox.Show("No shutdown started to stop");
            }
            else
            {
                try
                {
                    ShutUpThread.Abort();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ShutUpThread = null;
            }

        }
    }
}
