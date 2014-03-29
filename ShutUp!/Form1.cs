/*
        ShutUp! v .0.1 - Shuts down the PC using shutdown.exe provided with Windows.
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

namespace ShutUp_
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        Boolean processStarted = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int getSeconds()
        {

            if (isInteger(txtHrs) > 0)
            {
                seconds = seconds + isInteger(txtHrs) * 60 * 60;
            }
            if (isInteger(txtMins) > 0)
            {
                seconds = seconds + 60 * isInteger(txtMins);
            }
            if (isInteger(txtSecs) > 0)
            {
                seconds = seconds + isInteger(txtSecs);
            }
            return seconds;
        }

        private int isInteger(TextBox box)
        {

            int value = 0;
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
            seconds = getSeconds();
            if (processStarted)
            {
                MessageBox.Show("Shutdown already started. Stop first");
            }
            else if (seconds <= 0)
            {
                DialogResult dr = MessageBox.Show("This means immediate shutdown, go ahead?", "Message", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Process.Start("shutdown.exe", "-s -t " + seconds);

                    processStarted = true;
                    seconds = 0;
                }

            }
            else
            {
                Process.Start("shutdown.exe", "-s -t " + seconds);
                processStarted = true;
                seconds = 0;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!processStarted)
            {
                MessageBox.Show("No shutdown started to stop");
            }
            else
            {
                Process.Start("shutdown.exe ", "-a");
                processStarted = false;
            }

        }
    }
}
