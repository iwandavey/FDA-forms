using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using FDAClassLibrary;
using FOQA.ApplicationClasses;

namespace FOQA
{
	/// <summary>
	/// Summary description for frmFlightTracker.
	/// </summary>
	public class Flights : System.Windows.Forms.Form
	{

        private MenuItem mAircraftFiles;
        private ToolStripButton tsbOpenTracking;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStrip toolStrip1;
        private DataGridView flightsData;
        private IContainer components;

		public Flights()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.mAircraftFiles = new System.Windows.Forms.MenuItem();
            this.tsbOpenTracking = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flightsData = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsData)).BeginInit();
            this.SuspendLayout();
            // 
            // mAircraftFiles
            // 
            this.mAircraftFiles.Index = -1;
            this.mAircraftFiles.Text = "Aircraft Files";
            // 
            // tsbOpenTracking
            // 
            this.tsbOpenTracking.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenTracking.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenTracking.Image")));
            this.tsbOpenTracking.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenTracking.Name = "tsbOpenTracking";
            this.tsbOpenTracking.Size = new System.Drawing.Size(36, 36);
            this.tsbOpenTracking.Text = "toolStripButton1";
            this.tsbOpenTracking.ToolTipText = "Open CSV File.";
            this.tsbOpenTracking.Click += new System.EventHandler(this.tsbOpenTracking_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenTracking,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1468, 39);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // flightsData
            // 
            this.flightsData.AllowUserToAddRows = false;
            this.flightsData.AllowUserToDeleteRows = false;
            this.flightsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightsData.Location = new System.Drawing.Point(0, 39);
            this.flightsData.Name = "flightsData";
            this.flightsData.RowHeadersWidth = 51;
            this.flightsData.RowTemplate.Height = 24;
            this.flightsData.Size = new System.Drawing.Size(1468, 635);
            this.flightsData.TabIndex = 21;
            // 
            // Flights
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1468, 674);
            this.Controls.Add(this.flightsData);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Flights";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Traker";
            this.Load += new System.EventHandler(this.frmFlightTracker_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		private void frmFlightTracker_Load(object sender, System.EventArgs e)
		{
            Form_Load();
			
		}
        private void Form_Load()
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime startDate;
            DateTime endDate;
            
            DateTime.TryParse("1986/01/01", out startDate);
            endDate = DateTime.Today;

            flightsData.DataSource = DataProsedures.GetFlights(startDate, endDate);

        }

        private void tsbOpenTracking_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = flightsData.CurrentRow as DataGridViewRow;

                FDAfile.csvFileName = row.Cells["FileName"].Value.ToString();

                bool loaded;

                FDAfile.LoadCSV(FDAfile.csvFileName, out loaded);

                if (loaded)
                {
                    frmMainFOQA.reloadDataGridNeeded = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, FormAppMessages.ApplicationName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
                
    }
}
