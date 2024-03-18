namespace FOQA
{
    partial class fAircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAircraft));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAircraft = new System.Windows.Forms.DataGridView();
            this.cAircraftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.bAddAircraft = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tRegistration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cAircraftType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircraft)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAircraft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.50617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvAircraft
            // 
            this.dgvAircraft.AllowUserToAddRows = false;
            this.dgvAircraft.AllowUserToDeleteRows = false;
            this.dgvAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAircraft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAircraftID,
            this.cRegistration,
            this.cType});
            this.dgvAircraft.DataMember = "tAircraft";
            this.dgvAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAircraft.Location = new System.Drawing.Point(3, 3);
            this.dgvAircraft.Name = "dgvAircraft";
            this.dgvAircraft.Size = new System.Drawing.Size(450, 315);
            this.dgvAircraft.TabIndex = 0;
            // 
            // cAircraftID
            // 
            this.cAircraftID.DataPropertyName = "AircraftID";
            this.cAircraftID.HeaderText = "AircraftID";
            this.cAircraftID.Name = "cAircraftID";
            // 
            // cRegistration
            // 
            this.cRegistration.DataPropertyName = "Registration";
            this.cRegistration.HeaderText = "Registration";
            this.cRegistration.Name = "cRegistration";
            // 
            // cType
            // 
            this.cType.DataPropertyName = "Type";
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bAddAircraft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bDelete, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tRegistration, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cAircraftType, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 78);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(228, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAddAircraft
            // 
            this.bAddAircraft.Location = new System.Drawing.Point(3, 55);
            this.bAddAircraft.Name = "bAddAircraft";
            this.bAddAircraft.Size = new System.Drawing.Size(75, 20);
            this.bAddAircraft.TabIndex = 0;
            this.bAddAircraft.Text = "Add";
            this.bAddAircraft.UseVisualStyleBackColor = true;
            this.bAddAircraft.Click += new System.EventHandler(this.bAddAircraft_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(228, 55);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 20);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tRegistration
            // 
            this.tRegistration.Location = new System.Drawing.Point(3, 29);
            this.tRegistration.Name = "tRegistration";
            this.tRegistration.Size = new System.Drawing.Size(216, 20);
            this.tRegistration.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cAircraftType
            // 
            this.cAircraftType.FormattingEnabled = true;
            this.cAircraftType.Location = new System.Drawing.Point(228, 29);
            this.cAircraftType.Name = "cAircraftType";
            this.cAircraftType.Size = new System.Drawing.Size(213, 21);
            this.cAircraftType.TabIndex = 6;
            // 
            // fAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aircraft";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fAircraft_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircraft)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAircraft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bAddAircraft;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAircraftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cAircraftType;
    }
}