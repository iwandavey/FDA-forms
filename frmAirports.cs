using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace FOQA
{
	/// <summary>
	/// Summary description for frmAirport1.
	/// </summary>
	public class frmAirports : System.Windows.Forms.Form
	{
		
		private System.Windows.Forms.DataGrid dgAirports;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridTableStyle dataGridTableStyle1;
        private DataGridTextBoxColumn cAirportID;
        private DataGridTextBoxColumn cICAO;
        private DataGridTextBoxColumn cAirportName;
        private DataGridTextBoxColumn cIATA;
        private DataGridTextBoxColumn cUse;
        private Label lAirportID;
        private TextBox tICAO;
        private TextBox tName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bApply;
        private Button bNew;
        private Button bEdit;
        private Label label4;
        private TextBox tIata;
        private CheckBox chkUse;
        private Button bRunways;
        private Label lLatitude;
        private Label label7;
        private TextBox tLongitude;
        private TextBox tLatitude;
        private DataGridTextBoxColumn cLatitude;
        private DataGridTextBoxColumn cLongitude;
        private Button bDelete;
        private Label label6;
        private TextBox tVariation;
        private DataGridTextBoxColumn cVariation;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmAirports()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAirports));
            this.dgAirports = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.cAirportID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cICAO = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cIATA = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cAirportName = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLatitude = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cLongitude = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cVariation = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cUse = new System.Windows.Forms.DataGridTextBoxColumn();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tICAO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lAirportID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tIata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUse = new System.Windows.Forms.CheckBox();
            this.lLatitude = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.tLatitude = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bRunways = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tLongitude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tVariation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAirports)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAirports
            // 
            this.dgAirports.CaptionVisible = false;
            this.tableLayoutPanel1.SetColumnSpan(this.dgAirports, 6);
            this.dgAirports.DataMember = "tAirports";
            this.dgAirports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAirports.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAirports.Location = new System.Drawing.Point(3, 3);
            this.dgAirports.Name = "dgAirports";
            this.dgAirports.ReadOnly = true;
            this.dgAirports.Size = new System.Drawing.Size(502, 400);
            this.dgAirports.TabIndex = 0;
            this.dgAirports.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.dgAirports.CurrentCellChanged += new System.EventHandler(this.dgAirports_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.dgAirports;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.cAirportID,
            this.cICAO,
            this.cIATA,
            this.cAirportName,
            this.cLatitude,
            this.cLongitude,
            this.cVariation,
            this.cUse});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "tAirports";
            this.dataGridTableStyle1.ReadOnly = true;
            this.dataGridTableStyle1.RowHeadersVisible = false;
            // 
            // cAirportID
            // 
            this.cAirportID.Format = "";
            this.cAirportID.FormatInfo = null;
            this.cAirportID.HeaderText = "ID";
            this.cAirportID.MappingName = "AirportID";
            this.cAirportID.ReadOnly = true;
            this.cAirportID.Width = 50;
            // 
            // cICAO
            // 
            this.cICAO.Format = "";
            this.cICAO.FormatInfo = null;
            this.cICAO.HeaderText = "IQAO RWY";
            this.cICAO.MappingName = "ICAOdes";
            this.cICAO.ReadOnly = true;
            this.cICAO.Width = 75;
            // 
            // cIATA
            // 
            this.cIATA.Format = "";
            this.cIATA.FormatInfo = null;
            this.cIATA.HeaderText = "IATA";
            this.cIATA.MappingName = "IATA";
            this.cIATA.ReadOnly = true;
            this.cIATA.Width = 75;
            // 
            // cAirportName
            // 
            this.cAirportName.Format = "";
            this.cAirportName.FormatInfo = null;
            this.cAirportName.HeaderText = "Name";
            this.cAirportName.MappingName = "AirportName";
            this.cAirportName.ReadOnly = true;
            this.cAirportName.Width = 75;
            // 
            // cLatitude
            // 
            this.cLatitude.Format = "";
            this.cLatitude.FormatInfo = null;
            this.cLatitude.HeaderText = "Latitude";
            this.cLatitude.MappingName = "Latitude";
            this.cLatitude.NullText = "";
            this.cLatitude.ReadOnly = true;
            this.cLatitude.Width = 75;
            // 
            // cLongitude
            // 
            this.cLongitude.Format = "";
            this.cLongitude.FormatInfo = null;
            this.cLongitude.HeaderText = "Longitude";
            this.cLongitude.MappingName = "Longitude";
            this.cLongitude.NullText = " ";
            this.cLongitude.ReadOnly = true;
            this.cLongitude.Width = 75;
            // 
            // cVariation
            // 
            this.cVariation.Format = "";
            this.cVariation.FormatInfo = null;
            this.cVariation.HeaderText = "Variation";
            this.cVariation.MappingName = "Variation";
            this.cVariation.Width = 75;
            // 
            // cUse
            // 
            this.cUse.Format = "True, False";
            this.cUse.FormatInfo = null;
            this.cUse.HeaderText = "Use";
            this.cUse.MappingName = "Use";
            this.cUse.ReadOnly = true;
            this.cUse.Width = 75;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT AirportID, AirportName, ICAOdes, Runway FROM tblAirport";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO tblAirport(AirportName, ICAOdes, Runway) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("AirportName", System.Data.OleDb.OleDbType.VarWChar, 50, "AirportName"),
            new System.Data.OleDb.OleDbParameter("ICAOdes", System.Data.OleDb.OleDbType.VarWChar, 10, "ICAOdes"),
            new System.Data.OleDb.OleDbParameter("Runway", System.Data.OleDb.OleDbType.Integer, 0, "Runway")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("AirportName", System.Data.OleDb.OleDbType.VarWChar, 50, "AirportName"),
            new System.Data.OleDb.OleDbParameter("ICAOdes", System.Data.OleDb.OleDbType.VarWChar, 10, "ICAOdes"),
            new System.Data.OleDb.OleDbParameter("Runway", System.Data.OleDb.OleDbType.Integer, 0, "Runway"),
            new System.Data.OleDb.OleDbParameter("Original_AirportID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_AirportName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_AirportName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ICAOdes", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ICAOdes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ICAOdes1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ICAOdes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Runway", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Runway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Runway1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Runway", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_AirportID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_AirportName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_AirportName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AirportName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ICAOdes", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ICAOdes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ICAOdes1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ICAOdes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Runway", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Runway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Runway1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Runway", System.Data.DataRowVersion.Original, null)});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.82629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.17371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.dgAirports, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tICAO, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lAirportID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tIata, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkUse, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lLatitude, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bApply, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.tLatitude, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bNew, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.bEdit, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.bDelete, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.bRunways, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tLongitude, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tVariation, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 575);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tICAO
            // 
            this.tICAO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tICAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tICAO.Enabled = false;
            this.tICAO.Location = new System.Drawing.Point(90, 439);
            this.tICAO.Name = "tICAO";
            this.tICAO.Size = new System.Drawing.Size(86, 20);
            this.tICAO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Airport ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAirportID
            // 
            this.lAirportID.AutoSize = true;
            this.lAirportID.Location = new System.Drawing.Point(90, 406);
            this.lAirportID.Name = "lAirportID";
            this.lAirportID.Size = new System.Drawing.Size(51, 13);
            this.lAirportID.TabIndex = 4;
            this.lAirportID.Text = "Airport ID";
            this.lAirportID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ICAO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "IATA Designator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tIata
            // 
            this.tIata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tIata.Enabled = false;
            this.tIata.Location = new System.Drawing.Point(90, 469);
            this.tIata.Name = "tIata";
            this.tIata.Size = new System.Drawing.Size(86, 20);
            this.tIata.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Airport Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tName
            // 
            this.tName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tName.Enabled = false;
            this.tName.Location = new System.Drawing.Point(90, 498);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(86, 20);
            this.tName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Use";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkUse
            // 
            this.chkUse.AutoSize = true;
            this.chkUse.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUse.Enabled = false;
            this.chkUse.Location = new System.Drawing.Point(90, 525);
            this.chkUse.Name = "chkUse";
            this.chkUse.Size = new System.Drawing.Size(15, 14);
            this.chkUse.TabIndex = 4;
            this.chkUse.UseVisualStyleBackColor = true;
            // 
            // lLatitude
            // 
            this.lLatitude.AutoSize = true;
            this.lLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLatitude.Location = new System.Drawing.Point(182, 436);
            this.lLatitude.Name = "lLatitude";
            this.lLatitude.Size = new System.Drawing.Size(143, 30);
            this.lLatitude.TabIndex = 21;
            this.lLatitude.Text = "Latitude";
            this.lLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bApply
            // 
            this.bApply.Enabled = false;
            this.bApply.Location = new System.Drawing.Point(691, 545);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(52, 24);
            this.bApply.TabIndex = 16;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // tLatitude
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tLatitude, 2);
            this.tLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLatitude.Enabled = false;
            this.tLatitude.Location = new System.Drawing.Point(331, 439);
            this.tLatitude.Name = "tLatitude";
            this.tLatitude.Size = new System.Drawing.Size(114, 20);
            this.tLatitude.TabIndex = 5;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(511, 545);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(54, 24);
            this.bNew.TabIndex = 14;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(571, 545);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(54, 24);
            this.bEdit.TabIndex = 15;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(631, 545);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(54, 24);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRunways
            // 
            this.bRunways.Location = new System.Drawing.Point(511, 3);
            this.bRunways.Name = "bRunways";
            this.bRunways.Size = new System.Drawing.Size(54, 23);
            this.bRunways.TabIndex = 17;
            this.bRunways.Text = "Runways";
            this.bRunways.UseVisualStyleBackColor = true;
            this.bRunways.Click += new System.EventHandler(this.bRunways_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(451, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Longitude";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tLongitude
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tLongitude, 2);
            this.tLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLongitude.Enabled = false;
            this.tLongitude.Location = new System.Drawing.Point(511, 439);
            this.tLongitude.Name = "tLongitude";
            this.tLongitude.Size = new System.Drawing.Size(114, 20);
            this.tLongitude.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(182, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Variation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tVariation
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tVariation, 2);
            this.tVariation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVariation.Enabled = false;
            this.tVariation.Location = new System.Drawing.Point(331, 469);
            this.tVariation.Name = "tVariation";
            this.tVariation.Size = new System.Drawing.Size(114, 20);
            this.tVariation.TabIndex = 24;
            this.tVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmAirports
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(885, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAirports";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airports";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAirports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAirports)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private bool bAirportEdit = false;

        private void frmAirports_Load(object sender, EventArgs e)
        {
            Load_Data();
            Populate();
        }

        private void dgAirports_CurrentCellChanged(object sender, EventArgs e)
        {
            Populate();

        }

        private void Load_Data()
        {
            dgAirports.DataSource = FOQAData.fData.DataProc.loadAirports();
        }

        private void Populate()
        {

            double dLatitude = 0;
            double dLongitude = 0;

            try
            {
                dLatitude = Convert.ToDouble(dgAirports[dgAirports.CurrentRowIndex, 4]);
                dLongitude = Convert.ToDouble(dgAirports[dgAirports.CurrentRowIndex, 5]);
                //FOQAcalc.cCalc.LatLongDtoL(dLatitude, dLongitude, out iLatD, out iLatM, out dLatS, out sLatitude_H,out iLongD,out iLongM,out dLongS, out sLongitude_D);
            }
            catch
            {
            }

            FOQAData.fData.DataAirports.iAirportID = Convert.ToInt32(dgAirports[dgAirports.CurrentRowIndex, 0]);
            lAirportID.Text = FOQAData.fData.DataAirports.iAirportID.ToString();
            tICAO.Text = dgAirports[dgAirports.CurrentRowIndex, 1].ToString();
            tIata.Text = dgAirports[dgAirports.CurrentRowIndex, 2].ToString();
            tName.Text = dgAirports[dgAirports.CurrentRowIndex, 3].ToString();
            tLatitude.Text = dLatitude.ToString();
            tLongitude.Text = dLongitude.ToString();
            tVariation.Text = dgAirports[dgAirports.CurrentRowIndex, 6].ToString();
            chkUse.Checked = Convert.ToBoolean(dgAirports[dgAirports.CurrentRowIndex, 7]);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            bAirportEdit = true;
            EnableFields();
            bNew.Enabled = false;
            bEdit.Enabled = false;
            bApply.Enabled = true;

        }

        private void bApply_Click(object sender, EventArgs e)
        {
            int iPosition;

            iPosition = dgAirports.CurrentRowIndex;

            double dLatitude = Convert.ToDouble(tLatitude.Text);
            double dLongitude = Convert.ToDouble(tLongitude.Text);
            int iVariation = Convert.ToInt16(tVariation.Text);

            try
            {
                if (bAirportEdit)
                {// Update
                    FOQAData.fData.DataAirports.Update_tAirport(Convert.ToInt32(lAirportID.Text),
                        tICAO.Text,
                        tIata.Text,
                        tName.Text,
                        dLatitude,
                        dLongitude,
                        iVariation,
                        chkUse.Checked);

                }
                else
                {// Insert
                    FOQAData.fData.DataAirports.Insert_tAirport(tICAO.Text,
                        tIata.Text,
                        tName.Text,
                        dLatitude,
                        dLongitude,
                        iVariation,
                        chkUse.Checked);
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), FOQAData.sMessages.sMessageError);
            }

            Load_Data();

            dgAirports.CurrentRowIndex = iPosition;

            EnableFields();
            bEdit.Enabled = true;
            bNew.Enabled = true;
            bAirportEdit = false;
            bApply.Enabled = false;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableFields();
            bEdit.Enabled = false;
            bApply.Enabled = true;
        }

        private void EnableFields()
        {
            bool bTemp = false;

            if (tICAO.Enabled)
            {
                bTemp = false;
            }
            else
            {
                bTemp = true;
            }

            tICAO.Enabled = bTemp;
            tIata.Enabled = bTemp;
            tName.Enabled = bTemp;
            chkUse.Enabled = bTemp;

            tLatitude.Enabled = bTemp;
            //tLatitude_M.Enabled = bTemp;
            //tLatitude_S.Enabled = bTemp;
            //tLatitude_Hem.Enabled = bTemp;
           
            tLongitude.Enabled = bTemp;
            //tLongitude_M.Enabled = bTemp;
            //tLongitude_S.Enabled = bTemp;
            //tLongitude_Dir.Enabled = bTemp;

            tVariation.Enabled = bTemp;
        }

        private void ClearFields()
        {
            tICAO.Text = "";
            tIata.Text = "";
            tName.Text = "";
            tLatitude.Text = "";
            tLongitude.Text = "";
            tVariation.Text = "";


        }

        private void bRunways_Click(object sender, EventArgs e)
        {
            Form f = new fRunways();
            f.Text = "My Runways";
            f.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will delete the selected airport and its runways. Do you want to proceed?", "Airport Delete.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                FOQAData.fData.DataAirports.Delete_tAirport(FOQAData.fData.DataAirports.iAirportID);
                Load_Data();
                Populate();

                Cursor.Current = Cursors.Default;
            }

            
        }

      
	}
}
