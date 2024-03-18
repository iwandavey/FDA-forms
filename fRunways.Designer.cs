namespace FOQA
{
    partial class fRunways
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
            this.cfkAirport = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgRunways = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.cRunwayID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cRunwayDesignator = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cRunwayTrack = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cElevation = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUseRunway = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cRunwayLatitude = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cRunwayLongitude = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cTouchDownMarkersMaxLength = new System.Windows.Forms.DataGridTextBoxColumn();
            this.bAply = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tRunway = new System.Windows.Forms.TextBox();
            this.tTrack = new System.Windows.Forms.TextBox();
            this.tElevation = new System.Windows.Forms.TextBox();
            this.chbUseRunway = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tLatitude = new System.Windows.Forms.TextBox();
            this.tLongitude = new System.Windows.Forms.TextBox();
            this.lTouchDownZoneLength = new System.Windows.Forms.Label();
            this.tTouchDownZoneLength = new System.Windows.Forms.TextBox();
            this.bShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRunways)).BeginInit();
            this.SuspendLayout();
            // 
            // cfkAirport
            // 
            this.cfkAirport.Format = "";
            this.cfkAirport.FormatInfo = null;
            this.cfkAirport.HeaderText = "fkAirport";
            this.cfkAirport.MappingName = "fkAirport";
            this.cfkAirport.ReadOnly = true;
            this.cfkAirport.Width = 75;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dgRunways, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bAply, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.bEdit, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.bNew, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tRunway, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tTrack, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tElevation, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chbUseRunway, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tLatitude, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tLongitude, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lTouchDownZoneLength, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tTouchDownZoneLength, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bShow, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgRunways
            // 
            this.dgRunways.CaptionVisible = false;
            this.tableLayoutPanel1.SetColumnSpan(this.dgRunways, 4);
            this.dgRunways.DataMember = "tRunways";
            this.dgRunways.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRunways.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgRunways.Location = new System.Drawing.Point(3, 3);
            this.dgRunways.Name = "dgRunways";
            this.dgRunways.ReadOnly = true;
            this.dgRunways.Size = new System.Drawing.Size(599, 428);
            this.dgRunways.TabIndex = 8;
            this.dgRunways.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.dgRunways.CurrentCellChanged += new System.EventHandler(this.dgRunways_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.dgRunways;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.cRunwayID,
            this.cRunwayDesignator,
            this.cRunwayTrack,
            this.cElevation,
            this.cUseRunway,
            this.cRunwayLatitude,
            this.cRunwayLongitude,
            this.cTouchDownMarkersMaxLength,
            this.cfkAirport});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "tRunways";
            this.dataGridTableStyle1.ReadOnly = true;
            // 
            // cRunwayID
            // 
            this.cRunwayID.Format = "";
            this.cRunwayID.FormatInfo = null;
            this.cRunwayID.HeaderText = "Runway ID";
            this.cRunwayID.MappingName = "RWYID";
            this.cRunwayID.ReadOnly = true;
            this.cRunwayID.Width = 50;
            // 
            // cRunwayDesignator
            // 
            this.cRunwayDesignator.Format = "";
            this.cRunwayDesignator.FormatInfo = null;
            this.cRunwayDesignator.HeaderText = "Runway";
            this.cRunwayDesignator.MappingName = "RunwayDesignator";
            this.cRunwayDesignator.ReadOnly = true;
            this.cRunwayDesignator.Width = 85;
            // 
            // cRunwayTrack
            // 
            this.cRunwayTrack.Format = "";
            this.cRunwayTrack.FormatInfo = null;
            this.cRunwayTrack.HeaderText = "Track";
            this.cRunwayTrack.MappingName = "Runwaytrack";
            this.cRunwayTrack.ReadOnly = true;
            this.cRunwayTrack.Width = 85;
            // 
            // cElevation
            // 
            this.cElevation.Format = "";
            this.cElevation.FormatInfo = null;
            this.cElevation.HeaderText = "Elevation";
            this.cElevation.MappingName = "RunwayElevation";
            this.cElevation.Width = 75;
            // 
            // cUseRunway
            // 
            this.cUseRunway.Format = "";
            this.cUseRunway.FormatInfo = null;
            this.cUseRunway.HeaderText = "Use";
            this.cUseRunway.MappingName = "UseRunway";
            this.cUseRunway.ReadOnly = true;
            this.cUseRunway.Width = 75;
            // 
            // cRunwayLatitude
            // 
            this.cRunwayLatitude.Format = "";
            this.cRunwayLatitude.FormatInfo = null;
            this.cRunwayLatitude.HeaderText = "Latitude";
            this.cRunwayLatitude.MappingName = "RunwayLatitude";
            this.cRunwayLatitude.Width = 75;
            // 
            // cRunwayLongitude
            // 
            this.cRunwayLongitude.Format = "";
            this.cRunwayLongitude.FormatInfo = null;
            this.cRunwayLongitude.HeaderText = "Longitude";
            this.cRunwayLongitude.MappingName = "RunwayLongitude";
            this.cRunwayLongitude.Width = 75;
            // 
            // cTouchDownMarkersMaxLength
            // 
            this.cTouchDownMarkersMaxLength.Format = "";
            this.cTouchDownMarkersMaxLength.FormatInfo = null;
            this.cTouchDownMarkersMaxLength.HeaderText = "Touch Down Zone";
            this.cTouchDownMarkersMaxLength.MappingName = "TouchDownMarkersMaxLength";
            this.cTouchDownMarkersMaxLength.Width = 75;
            // 
            // bAply
            // 
            this.bAply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAply.Enabled = false;
            this.bAply.Location = new System.Drawing.Point(456, 533);
            this.bAply.Name = "bAply";
            this.bAply.Size = new System.Drawing.Size(146, 30);
            this.bAply.TabIndex = 7;
            this.bAply.Text = "Apply";
            this.bAply.UseVisualStyleBackColor = true;
            this.bAply.Click += new System.EventHandler(this.bAply_Click);
            // 
            // bEdit
            // 
            this.bEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEdit.Location = new System.Drawing.Point(305, 533);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(145, 30);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bNew
            // 
            this.bNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNew.Location = new System.Drawing.Point(154, 533);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(145, 30);
            this.bNew.TabIndex = 5;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Runway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Track";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Elevation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Use";
            // 
            // tRunway
            // 
            this.tRunway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRunway.Enabled = false;
            this.tRunway.Location = new System.Drawing.Point(3, 461);
            this.tRunway.Name = "tRunway";
            this.tRunway.Size = new System.Drawing.Size(145, 20);
            this.tRunway.TabIndex = 10;
            // 
            // tTrack
            // 
            this.tTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tTrack.Enabled = false;
            this.tTrack.Location = new System.Drawing.Point(154, 461);
            this.tTrack.Name = "tTrack";
            this.tTrack.Size = new System.Drawing.Size(145, 20);
            this.tTrack.TabIndex = 2;
            // 
            // tElevation
            // 
            this.tElevation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tElevation.Enabled = false;
            this.tElevation.Location = new System.Drawing.Point(305, 461);
            this.tElevation.Name = "tElevation";
            this.tElevation.Size = new System.Drawing.Size(145, 20);
            this.tElevation.TabIndex = 3;
            // 
            // chbUseRunway
            // 
            this.chbUseRunway.AutoSize = true;
            this.chbUseRunway.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbUseRunway.Enabled = false;
            this.chbUseRunway.Location = new System.Drawing.Point(456, 461);
            this.chbUseRunway.Name = "chbUseRunway";
            this.chbUseRunway.Size = new System.Drawing.Size(15, 14);
            this.chbUseRunway.TabIndex = 4;
            this.chbUseRunway.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Touch Down Latitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(154, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Touchdown Longitude";
            // 
            // tLatitude
            // 
            this.tLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLatitude.Enabled = false;
            this.tLatitude.Location = new System.Drawing.Point(3, 509);
            this.tLatitude.Name = "tLatitude";
            this.tLatitude.Size = new System.Drawing.Size(145, 20);
            this.tLatitude.TabIndex = 16;
            // 
            // tLongitude
            // 
            this.tLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLongitude.Enabled = false;
            this.tLongitude.Location = new System.Drawing.Point(154, 509);
            this.tLongitude.Name = "tLongitude";
            this.tLongitude.Size = new System.Drawing.Size(145, 20);
            this.tLongitude.TabIndex = 17;
            // 
            // lTouchDownZoneLength
            // 
            this.lTouchDownZoneLength.AutoSize = true;
            this.lTouchDownZoneLength.Location = new System.Drawing.Point(305, 482);
            this.lTouchDownZoneLength.Name = "lTouchDownZoneLength";
            this.lTouchDownZoneLength.Size = new System.Drawing.Size(133, 13);
            this.lTouchDownZoneLength.TabIndex = 18;
            this.lTouchDownZoneLength.Text = "Touch Down Zone Length";
            // 
            // tTouchDownZoneLength
            // 
            this.tTouchDownZoneLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tTouchDownZoneLength.Enabled = false;
            this.tTouchDownZoneLength.Location = new System.Drawing.Point(305, 509);
            this.tTouchDownZoneLength.Name = "tTouchDownZoneLength";
            this.tTouchDownZoneLength.Size = new System.Drawing.Size(145, 20);
            this.tTouchDownZoneLength.TabIndex = 19;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(456, 509);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(75, 18);
            this.bShow.TabIndex = 20;
            this.bShow.Text = "Show position";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // fRunways
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fRunways";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runways";
            this.Load += new System.EventHandler(this.fRunways_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRunways)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGrid dgRunways;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn cRunwayID;
        private System.Windows.Forms.DataGridTextBoxColumn cRunwayDesignator;
        private System.Windows.Forms.DataGridTextBoxColumn cRunwayTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbUseRunway;
        private System.Windows.Forms.TextBox tTrack;
        private System.Windows.Forms.TextBox tRunway;
        private System.Windows.Forms.Button bAply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tElevation;
        private System.Windows.Forms.DataGridTextBoxColumn cElevation;
        private System.Windows.Forms.DataGridTextBoxColumn cUseRunway;
        private System.Windows.Forms.DataGridTextBoxColumn cfkAirport;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridTextBoxColumn cRunwayLatitude;
        private System.Windows.Forms.DataGridTextBoxColumn cRunwayLongitude;
        private System.Windows.Forms.TextBox tLatitude;
        private System.Windows.Forms.TextBox tLongitude;
        private System.Windows.Forms.Label lTouchDownZoneLength;
        private System.Windows.Forms.TextBox tTouchDownZoneLength;
        private System.Windows.Forms.DataGridTextBoxColumn cTouchDownMarkersMaxLength;
        private System.Windows.Forms.Button bShow;
    }
}