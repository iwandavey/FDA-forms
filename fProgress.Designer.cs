namespace FOQA
{
    partial class fProgress
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProgress));
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pProsess = new System.Windows.Forms.ProgressBar();
            this.lProsess = new System.Windows.Forms.Label();
            this.lProgress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBar.Location = new System.Drawing.Point(3, 90);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(864, 24);
            this.pBar.Step = 1;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pProsess, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lProsess, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lProgress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pBar, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 117);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pProsess
            // 
            this.pProsess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProsess.Location = new System.Drawing.Point(3, 32);
            this.pProsess.Name = "pProsess";
            this.pProsess.Size = new System.Drawing.Size(864, 23);
            this.pProsess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pProsess.TabIndex = 3;
            // 
            // lProsess
            // 
            this.lProsess.AutoSize = true;
            this.lProsess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProsess.Location = new System.Drawing.Point(3, 0);
            this.lProsess.Name = "lProsess";
            this.lProsess.Size = new System.Drawing.Size(864, 29);
            this.lProsess.TabIndex = 2;
            this.lProsess.Text = " ";
            this.lProsess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProgress.Location = new System.Drawing.Point(3, 58);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(864, 29);
            this.lProgress.TabIndex = 1;
            this.lProgress.Text = " ";
            this.lProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 117);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fProgress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.fProgress_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.Label lProsess;
        private System.Windows.Forms.ProgressBar pProsess;
    }
}