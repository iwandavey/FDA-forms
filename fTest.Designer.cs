﻿namespace FOQA
{
    partial class fTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsLat = new System.Windows.Forms.TextBox();
            this.tsLong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teLat = new System.Windows.Forms.TextBox();
            this.teLong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lBearing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude";
            // 
            // lDistance
            // 
            this.lDistance.AutoSize = true;
            this.lDistance.Location = new System.Drawing.Point(176, 210);
            this.lDistance.Name = "lDistance";
            this.lDistance.Size = new System.Drawing.Size(13, 13);
            this.lDistance.TabIndex = 3;
            this.lDistance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance";
            // 
            // tsLat
            // 
            this.tsLat.Location = new System.Drawing.Point(188, 64);
            this.tsLat.Name = "tsLat";
            this.tsLat.Size = new System.Drawing.Size(100, 20);
            this.tsLat.TabIndex = 5;
            this.tsLat.Text = "-26.142427";
            // 
            // tsLong
            // 
            this.tsLong.Location = new System.Drawing.Point(188, 95);
            this.tsLong.Name = "tsLong";
            this.tsLong.Size = new System.Drawing.Size(100, 20);
            this.tsLong.TabIndex = 6;
            this.tsLong.Text = "28.235663";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Latitude To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Longitude To";
            // 
            // teLat
            // 
            this.teLat.Location = new System.Drawing.Point(437, 68);
            this.teLat.Name = "teLat";
            this.teLat.Size = new System.Drawing.Size(100, 20);
            this.teLat.TabIndex = 9;
            this.teLat.Text = "-26.115942";
            // 
            // teLong
            // 
            this.teLong.Location = new System.Drawing.Point(437, 98);
            this.teLong.Name = "teLong";
            this.teLong.Size = new System.Drawing.Size(100, 20);
            this.teLong.TabIndex = 10;
            this.teLong.Text = "28.243866";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bearing";
            // 
            // lBearing
            // 
            this.lBearing.AutoSize = true;
            this.lBearing.Location = new System.Drawing.Point(176, 237);
            this.lBearing.Name = "lBearing";
            this.lBearing.Size = new System.Drawing.Size(13, 13);
            this.lBearing.TabIndex = 12;
            this.lBearing.Text = "0";
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 401);
            this.Controls.Add(this.lBearing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teLong);
            this.Controls.Add(this.teLat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsLong);
            this.Controls.Add(this.tsLat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "fTest";
            this.Text = "fTest";
            this.Load += new System.EventHandler(this.fTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tsLat;
        private System.Windows.Forms.TextBox tsLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teLat;
        private System.Windows.Forms.TextBox teLong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lBearing;
    }
}