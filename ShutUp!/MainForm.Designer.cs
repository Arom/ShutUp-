namespace ShutUp_
{
    partial class MainForm
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
            this.btStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHrs = new System.Windows.Forms.TextBox();
            this.txtSecs = new System.Windows.Forms.TextBox();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(-3, 109);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 90);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(114, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 90);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds";
            // 
            // txtHrs
            // 
            this.txtHrs.Location = new System.Drawing.Point(48, 47);
            this.txtHrs.Name = "txtHrs";
            this.txtHrs.Size = new System.Drawing.Size(32, 20);
            this.txtHrs.TabIndex = 5;
            this.txtHrs.Text = "0";
            // 
            // txtSecs
            // 
            this.txtSecs.Location = new System.Drawing.Point(134, 47);
            this.txtSecs.Name = "txtSecs";
            this.txtSecs.Size = new System.Drawing.Size(32, 20);
            this.txtSecs.TabIndex = 6;
            this.txtSecs.Text = "0";
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(92, 47);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(36, 20);
            this.txtMins.TabIndex = 7;
            this.txtMins.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 195);
            this.Controls.Add(this.txtMins);
            this.Controls.Add(this.txtSecs);
            this.Controls.Add(this.txtHrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btStart);
            this.Name = "MainForm";
            this.Text = "ShutUp!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHrs;
        private System.Windows.Forms.TextBox txtSecs;
        private System.Windows.Forms.TextBox txtMins;
    }
}

