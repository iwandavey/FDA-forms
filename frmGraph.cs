using FOQAData;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using FDAClassLibrary;
using FOQAcalc;
using FOQA.ApplicationClasses;
using System.Reflection;

namespace FOQA
{
    /// <summary>
    /// Summary description for frmGraph.
    /// </summary>
    public class frmGraph : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ImageList imgListTB;
        private System.ComponentModel.IContainer components;
        private SaveFileDialog saveFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mFileSave;
        private ToolStrip toolStrip;
        private ToolStripMenuItem show;
        private System.Drawing.Bitmap bmGraph;
        private ToolStripMenuItem createKMLFileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem CalculateDistanceToolStripMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem setStartCounterToolStripMenuItem;
        private ToolStripMenuItem setEndCounterToolStripMenuItem;
        private ToolStripMenuItem createKMLToolStripMenuItem;
        private ToolStripMenuItem showDistanceResultsToolStripMenuItem;
        private ToolStripMenuItem CalculateFuelBurned;
        private ToolStripMenuItem positionToolStripMenuItem;
        private ToolStripMenuItem savePositionToolStripMenuItem;
        private ToolStripMenuItem touchdownToolStripMenuItem;
        private ToolStripMenuItem turnoffToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem gotoToolStripMenuItem;
        private ToolStripMenuItem nextLandingToolStripMenuItem;
        private ToolStripMenuItem placeTextToolStripMenuItem;
        private ToolStripTextBox placeTextToolStripTextBox;
        private ToolStripMenuItem noteCoulorToolStripMenuItem;
        private ToolStripTextBox noteTextToolStripTextBox;
        private ColorDialog colorDialog;
        private Panel pnlGraph;
        private TrackBar trkScaleH;
        private HScrollBar schGraphPos;
        private TextBox tLatAndLong;
        private Label lblAP;
        private Label lblTAT;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Datum;
        private ToolStripStatusLabel vlugNommer;
        private ToolStripStatusLabel Gebeurtenis;
        private ToolStripStatusLabel Merker;
        private ToolStripStatusLabel skermHoogte;
        private ToolStripStatusLabel skermAGMerker;
        private ToolStripStatusLabel distansieVanAG;
        private ToolStripMenuItem positionOnGoogle;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private ToolStripStatusLabel startCounter;
        private ToolStripStatusLabel endCounter;
        private CDI.LineControl.Line line19;
        private ToolStripMenuItem accelerationToolStripMenuItem;
        private ToolStripComboBox toolStripComboAccelerationSeconds;
        private ToolStripStatusLabel toolStripStatusLabelAcceleration;
        private ToolStripMenuItem graphParametersToolStripMenuItem;

        public frmGraph()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraph));
            this.imgListTB = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.createKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.positionOnGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.graphParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateDistanceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createKMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDistanceResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateFuelBurned = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteCoulorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.accelerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboAccelerationSeconds = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setStartCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEndCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touchdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.tLatAndLong = new System.Windows.Forms.TextBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblTAT = new System.Windows.Forms.Label();
            this.line19 = new CDI.LineControl.Line();
            this.trkScaleH = new System.Windows.Forms.TrackBar();
            this.schGraphPos = new System.Windows.Forms.HScrollBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Datum = new System.Windows.Forms.ToolStripStatusLabel();
            this.vlugNommer = new System.Windows.Forms.ToolStripStatusLabel();
            this.Gebeurtenis = new System.Windows.Forms.ToolStripStatusLabel();
            this.Merker = new System.Windows.Forms.ToolStripStatusLabel();
            this.skermHoogte = new System.Windows.Forms.ToolStripStatusLabel();
            this.skermAGMerker = new System.Windows.Forms.ToolStripStatusLabel();
            this.distansieVanAG = new System.Windows.Forms.ToolStripStatusLabel();
            this.startCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.endCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAcceleration = new System.Windows.Forms.ToolStripStatusLabel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleH)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgListTB
            // 
            this.imgListTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTB.ImageStream")));
            this.imgListTB.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTB.Images.SetKeyName(0, "");
            this.imgListTB.Images.SetKeyName(1, "");
            this.imgListTB.Images.SetKeyName(2, "");
            this.imgListTB.Images.SetKeyName(3, "");
            this.imgListTB.Images.SetKeyName(4, "");
            this.imgListTB.Images.SetKeyName(5, "");
            this.imgListTB.Images.SetKeyName(6, "");
            this.imgListTB.Images.SetKeyName(7, "");
            this.imgListTB.Images.SetKeyName(8, "");
            this.imgListTB.Images.SetKeyName(9, "");
            this.imgListTB.Images.SetKeyName(10, "");
            this.imgListTB.Images.SetKeyName(11, "");
            this.imgListTB.Images.SetKeyName(12, "");
            this.imgListTB.Images.SetKeyName(13, "");
            this.imgListTB.Images.SetKeyName(14, "");
            this.imgListTB.Images.SetKeyName(15, "");
            this.imgListTB.Images.SetKeyName(16, "");
            this.imgListTB.Images.SetKeyName(17, "");
            this.imgListTB.Images.SetKeyName(18, "");
            this.imgListTB.Images.SetKeyName(19, "");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "jpg Files |* .jpg";
            this.saveFileDialog.Title = "Save jpg image of the graph.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.show,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1838, 28);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileSave,
            this.createKMLFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mFileSave
            // 
            this.mFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mFileSave.Image")));
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.Size = new System.Drawing.Size(193, 26);
            this.mFileSave.Text = "&Save";
            this.mFileSave.ToolTipText = "Save an image of the graph.";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // createKMLFileToolStripMenuItem
            // 
            this.createKMLFileToolStripMenuItem.Name = "createKMLFileToolStripMenuItem";
            this.createKMLFileToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.createKMLFileToolStripMenuItem.Text = "Create KML file";
            this.createKMLFileToolStripMenuItem.ToolTipText = "Create a file you can view in google earth.";
            this.createKMLFileToolStripMenuItem.Click += new System.EventHandler(this.createKMLFileToolStripMenuItem_Click);
            // 
            // show
            // 
            this.show.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionOnGoogle,
            this.graphParametersToolStripMenuItem});
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(59, 24);
            this.show.Text = "Show";
            this.show.ToolTipText = "Shown after the alt value in [] brackets.";
            // 
            // positionOnGoogle
            // 
            this.positionOnGoogle.Name = "positionOnGoogle";
            this.positionOnGoogle.Size = new System.Drawing.Size(218, 26);
            this.positionOnGoogle.Text = "Position on Google";
            this.positionOnGoogle.Click += new System.EventHandler(this.positionOnGoogle_Click);
            // 
            // graphParametersToolStripMenuItem
            // 
            this.graphParametersToolStripMenuItem.Name = "graphParametersToolStripMenuItem";
            this.graphParametersToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.graphParametersToolStripMenuItem.Text = "Graph Parameters";
            this.graphParametersToolStripMenuItem.Click += new System.EventHandler(this.graphParametersToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateDistanceToolStripMenu,
            this.createKMLToolStripMenuItem,
            this.showDistanceResultsToolStripMenuItem,
            this.CalculateFuelBurned,
            this.gotoToolStripMenuItem,
            this.noteCoulorToolStripMenuItem,
            this.accelerationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.ToolTipText = "Calculate distance between two caounter positions.";
            // 
            // CalculateDistanceToolStripMenu
            // 
            this.CalculateDistanceToolStripMenu.Name = "CalculateDistanceToolStripMenu";
            this.CalculateDistanceToolStripMenu.Size = new System.Drawing.Size(238, 26);
            this.CalculateDistanceToolStripMenu.Text = "Calculate Distance";
            this.CalculateDistanceToolStripMenu.Click += new System.EventHandler(this.CalculateDistanceToolStripMenu_Click);
            // 
            // createKMLToolStripMenuItem
            // 
            this.createKMLToolStripMenuItem.Name = "createKMLToolStripMenuItem";
            this.createKMLToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.createKMLToolStripMenuItem.Text = "Create KML";
            this.createKMLToolStripMenuItem.ToolTipText = "Create a file to view in Google Earth.";
            this.createKMLToolStripMenuItem.Click += new System.EventHandler(this.createKMLToolStripMenuItem_Click);
            // 
            // showDistanceResultsToolStripMenuItem
            // 
            this.showDistanceResultsToolStripMenuItem.Name = "showDistanceResultsToolStripMenuItem";
            this.showDistanceResultsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.showDistanceResultsToolStripMenuItem.Text = "Show Distance results.";
            this.showDistanceResultsToolStripMenuItem.Click += new System.EventHandler(this.showDistanceResultsToolStripMenuItem_Click);
            // 
            // CalculateFuelBurned
            // 
            this.CalculateFuelBurned.Name = "CalculateFuelBurned";
            this.CalculateFuelBurned.Size = new System.Drawing.Size(238, 26);
            this.CalculateFuelBurned.Text = "Calculate Fuel";
            this.CalculateFuelBurned.ToolTipText = "Calculate the fuel burned between selected points.";
            this.CalculateFuelBurned.Click += new System.EventHandler(this.CalculateFuelBurned_Click);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextLandingToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // nextLandingToolStripMenuItem
            // 
            this.nextLandingToolStripMenuItem.Name = "nextLandingToolStripMenuItem";
            this.nextLandingToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            // 
            // noteCoulorToolStripMenuItem
            // 
            this.noteCoulorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteTextToolStripTextBox});
            this.noteCoulorToolStripMenuItem.Name = "noteCoulorToolStripMenuItem";
            this.noteCoulorToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.noteCoulorToolStripMenuItem.Text = "Note Color";
            this.noteCoulorToolStripMenuItem.Click += new System.EventHandler(this.noteCoulorToolStripMenuItem_Click);
            // 
            // noteTextToolStripTextBox
            // 
            this.noteTextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noteTextToolStripTextBox.Name = "noteTextToolStripTextBox";
            this.noteTextToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // accelerationToolStripMenuItem
            // 
            this.accelerationToolStripMenuItem.CheckOnClick = true;
            this.accelerationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboAccelerationSeconds});
            this.accelerationToolStripMenuItem.Name = "accelerationToolStripMenuItem";
            this.accelerationToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.accelerationToolStripMenuItem.Text = "Acceleration";
            // 
            // toolStripComboAccelerationSeconds
            // 
            this.toolStripComboAccelerationSeconds.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.toolStripComboAccelerationSeconds.Name = "toolStripComboAccelerationSeconds";
            this.toolStripComboAccelerationSeconds.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboAccelerationSeconds.Text = "5";
            this.toolStripComboAccelerationSeconds.ToolTipText = "Time in second acceleration will be calculated over.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStartCounterToolStripMenuItem,
            this.setEndCounterToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.placeTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 100);
            // 
            // setStartCounterToolStripMenuItem
            // 
            this.setStartCounterToolStripMenuItem.Name = "setStartCounterToolStripMenuItem";
            this.setStartCounterToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.setStartCounterToolStripMenuItem.Text = "Set Start Counter";
            this.setStartCounterToolStripMenuItem.Click += new System.EventHandler(this.setStartCounterToolStripMenuItem_Click);
            // 
            // setEndCounterToolStripMenuItem
            // 
            this.setEndCounterToolStripMenuItem.Name = "setEndCounterToolStripMenuItem";
            this.setEndCounterToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.setEndCounterToolStripMenuItem.Text = "Set End Counter";
            this.setEndCounterToolStripMenuItem.Click += new System.EventHandler(this.setEndCounterToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePositionToolStripMenuItem,
            this.touchdownToolStripMenuItem,
            this.turnoffToolStripMenuItem});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.positionToolStripMenuItem.Text = "Touchdown";
            // 
            // savePositionToolStripMenuItem
            // 
            this.savePositionToolStripMenuItem.Name = "savePositionToolStripMenuItem";
            this.savePositionToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.savePositionToolStripMenuItem.Text = "Flare";
            this.savePositionToolStripMenuItem.Click += new System.EventHandler(this.savePositionToolStripMenuItem_Click);
            // 
            // touchdownToolStripMenuItem
            // 
            this.touchdownToolStripMenuItem.Name = "touchdownToolStripMenuItem";
            this.touchdownToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.touchdownToolStripMenuItem.Text = "Touchdown";
            // 
            // turnoffToolStripMenuItem
            // 
            this.turnoffToolStripMenuItem.Name = "turnoffToolStripMenuItem";
            this.turnoffToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.turnoffToolStripMenuItem.Text = "Turnoff";
            // 
            // placeTextToolStripMenuItem
            // 
            this.placeTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeTextToolStripTextBox});
            this.placeTextToolStripMenuItem.Name = "placeTextToolStripMenuItem";
            this.placeTextToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.placeTextToolStripMenuItem.Text = "Place Text";
            // 
            // placeTextToolStripTextBox
            // 
            this.placeTextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.placeTextToolStripTextBox.Name = "placeTextToolStripTextBox";
            this.placeTextToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1838, 25);
            this.toolStrip.TabIndex = 12454;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlGraph, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1838, 700);
            this.tableLayoutPanel1.TabIndex = 12455;
            // 
            // pnlGraph
            // 
            this.pnlGraph.AutoSize = true;
            this.pnlGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlGraph.Controls.Add(this.tLatAndLong);
            this.pnlGraph.Controls.Add(this.lblAP);
            this.pnlGraph.Controls.Add(this.lblTAT);
            this.pnlGraph.Controls.Add(this.line19);
            this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraph.ForeColor = System.Drawing.Color.Black;
            this.pnlGraph.Location = new System.Drawing.Point(3, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1832, 694);
            this.pnlGraph.TabIndex = 62;
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            // 
            // tLatAndLong
            // 
            this.tLatAndLong.Location = new System.Drawing.Point(86, 8);
            this.tLatAndLong.Name = "tLatAndLong";
            this.tLatAndLong.Size = new System.Drawing.Size(368, 22);
            this.tLatAndLong.TabIndex = 12456;
            this.tLatAndLong.Visible = false;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(10, 323);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(0, 16);
            this.lblAP.TabIndex = 12452;
            // 
            // lblTAT
            // 
            this.lblTAT.AutoSize = true;
            this.lblTAT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAT.Location = new System.Drawing.Point(7, 12);
            this.lblTAT.Name = "lblTAT";
            this.lblTAT.Size = new System.Drawing.Size(62, 16);
            this.lblTAT.TabIndex = 12450;
            this.lblTAT.Text = "TAT 39.9";
            this.lblTAT.Visible = false;
            // 
            // line19
            // 
            this.line19.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.line19.LineColor1 = System.Drawing.Color.Black;
            this.line19.LineColor2 = System.Drawing.Color.Black;
            this.line19.LineDirection = CDI.LineControl.LineDirections.Vertical;
            this.line19.Location = new System.Drawing.Point(49, 0);
            this.line19.Name = "line19";
            this.line19.Size = new System.Drawing.Size(1, 1154);
            this.line19.TabIndex = 65;
            // 
            // trkScaleH
            // 
            this.trkScaleH.AutoSize = false;
            this.trkScaleH.BackColor = System.Drawing.SystemColors.Control;
            this.trkScaleH.LargeChange = 2;
            this.trkScaleH.Location = new System.Drawing.Point(1175, -3);
            this.trkScaleH.Maximum = 80;
            this.trkScaleH.Minimum = 1;
            this.trkScaleH.Name = "trkScaleH";
            this.trkScaleH.Size = new System.Drawing.Size(153, 31);
            this.trkScaleH.SmallChange = 2;
            this.trkScaleH.TabIndex = 90;
            this.trkScaleH.TickFrequency = 2;
            this.trkScaleH.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkScaleH.Value = 50;
            this.trkScaleH.ValueChanged += new System.EventHandler(this.trkScaleH_ValueChanged);
            // 
            // schGraphPos
            // 
            this.schGraphPos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.schGraphPos.LargeChange = 101;
            this.schGraphPos.Location = new System.Drawing.Point(817, 0);
            this.schGraphPos.Name = "schGraphPos";
            this.schGraphPos.Size = new System.Drawing.Size(323, 23);
            this.schGraphPos.SmallChange = 101;
            this.schGraphPos.TabIndex = 1;
            this.schGraphPos.TabStop = true;
            this.schGraphPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.schGraphPos_Scroll);
            this.schGraphPos.ValueChanged += new System.EventHandler(this.schGraphPos_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datum,
            this.vlugNommer,
            this.Gebeurtenis,
            this.Merker,
            this.skermHoogte,
            this.skermAGMerker,
            this.distansieVanAG,
            this.startCounter,
            this.endCounter,
            this.toolStripStatusLabelAcceleration});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1838, 26);
            this.statusStrip1.TabIndex = 12456;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Datum
            // 
            this.Datum.AutoSize = false;
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(110, 20);
            this.Datum.Text = "---";
            // 
            // vlugNommer
            // 
            this.vlugNommer.AutoSize = false;
            this.vlugNommer.Name = "vlugNommer";
            this.vlugNommer.Size = new System.Drawing.Size(40, 20);
            this.vlugNommer.Text = "---";
            // 
            // Gebeurtenis
            // 
            this.Gebeurtenis.AutoSize = false;
            this.Gebeurtenis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gebeurtenis.Name = "Gebeurtenis";
            this.Gebeurtenis.Size = new System.Drawing.Size(200, 20);
            this.Gebeurtenis.Text = "Low N1 on final approach.";
            this.Gebeurtenis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Merker
            // 
            this.Merker.AutoSize = false;
            this.Merker.Name = "Merker";
            this.Merker.Size = new System.Drawing.Size(40, 20);
            // 
            // skermHoogte
            // 
            this.skermHoogte.AutoSize = false;
            this.skermHoogte.Name = "skermHoogte";
            this.skermHoogte.Size = new System.Drawing.Size(60, 20);
            this.skermHoogte.Text = "10500";
            // 
            // skermAGMerker
            // 
            this.skermAGMerker.AutoSize = false;
            this.skermAGMerker.Name = "skermAGMerker";
            this.skermAGMerker.Size = new System.Drawing.Size(70, 20);
            this.skermAGMerker.Text = "983145";
            // 
            // distansieVanAG
            // 
            this.distansieVanAG.AutoSize = false;
            this.distansieVanAG.Name = "distansieVanAG";
            this.distansieVanAG.Size = new System.Drawing.Size(140, 20);
            this.distansieVanAG.Text = "10 km";
            this.distansieVanAG.ToolTipText = "Distance from the last touchdown / airborn point that was on screen.";
            // 
            // startCounter
            // 
            this.startCounter.Name = "startCounter";
            this.startCounter.Size = new System.Drawing.Size(21, 20);
            this.startCounter.Text = "--";
            // 
            // endCounter
            // 
            this.endCounter.Name = "endCounter";
            this.endCounter.Size = new System.Drawing.Size(21, 20);
            this.endCounter.Text = "--";
            // 
            // toolStripStatusLabelAcceleration
            // 
            this.toolStripStatusLabelAcceleration.Name = "toolStripStatusLabelAcceleration";
            this.toolStripStatusLabelAcceleration.Size = new System.Drawing.Size(0, 20);
            this.toolStripStatusLabelAcceleration.ToolTipText = "+ Acceleraion - Deceleration";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmGraph
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1838, 753);
            this.Controls.Add(this.trkScaleH);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.schGraphPos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGraph";
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGraph_FormClosed);
            this.Load += new System.EventHandler(this.frmGraph_Load);
            this.Shown += new System.EventHandler(this.frmGraph_Load);
            this.ResizeEnd += new System.EventHandler(this.frmGraph_Load);
            this.SizeChanged += new System.EventHandler(this.frmGraph_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGraph_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleH)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region veranderlikes
        public bool tekenBeginMerkerLyn { get; set; }
        private static DataTable CSV = new DataTable();
        public int beginMerkerPosiesie
                  , drawStartPos
                  , iCount = 0;

        private double huidigeCounter = 0;

        public int opSkermHoogte = -5000;
        public double opSkermLandOpstuigMerker;

        public double startPos;
        private int iPos = 0;

        private static int CSVRowCount = 0;
        private static float bottomVal = 0;
        private static float topVal = 0;
        private static float constant = 0;
        private static double scale;
        private static Color noteColor = Color.Black;
        //private bool kiesLysGeStel = false;
        public bool vinnigeKnoppiesGestel = false;
        public bool plotWaardesGestel { get; set; } = false;
        #endregion
        /// <summary>
        /// Used when the aplication is in demo mode.
        /// </summary>
        private void aplicationMode()
        {
            if (appSettings.Mode.ToLower() == "demo")
            {

                Datum.Visible = false;
                vlugNommer.Visible = false;
            }
            else if (appSettings.Mode.ToLower() == "dev")
            {
                Datum.Visible = true;
                vlugNommer.Visible = true;
            }

        }
        private void pnlGraph_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            line19.Location = new Point(MousePosition.X - (ActiveForm.Left + 15), 0); // was 11
            ShowBM();
        }
        private void addWarningsToolDropDownItems()
        {
            //ToolStripMenuItem[] mi = new ToolStripMenuItem[csv.Warnings.Count];

            //for (int i = 0; i < mi.Length; i++)
            //{
            //    mi[i] = new ToolStripMenuItem();
            //    mi[i].Name = csv.Warnings[i];
            //    mi[i].CheckOnClick = true;
            //    mi[i].Text = csv.Warnings[i]; ;
            //    mi[i].Click += new EventHandler(warningMenuItem_Click);
            //}

            //if (!kiesLysGeStel)
            //{
            //    warningsToolStripMenuItem.DropDownItems.AddRange(mi);
            //    kiesLysGeStel = true;
            //}

        }
        private void CalculateDistanceToolStripMenu_Click(object sender, EventArgs e)
        {
            Tools.CalculateDistance(CSV);
            StatusBar();

            MessageBox.Show("Distance " + Math.Round(Tools.Distance, 3) + " Km / " + " NM " + Math.Round(Tools.Distance * 3280 / 6080, 3) + " Burn " + Tools.FU + " kg.", FormAppMessages.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CalculateFuelBurned_Click(object sender, EventArgs e)
        {
            double FuelBurn = 0;
            double FuelBurnGW = 0;

            try
            {
                FOQAData.Tools.CalculateFuelBurnedBetweenPoints(CSV, out FuelBurn, out FuelBurnGW);
                FuelBurn = csv.setFuelUnit(FuelBurn); // TODO : check this for lbs fuel units

                MessageBox.Show("The Fuel burn calculated per second using fuel flow " + Math.Round(FuelBurn, 1).ToString() + " kg, fuel burn calculated difference between GW " + FuelBurnGW + " kg.",
                    "Fuel burn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception xx)
            {
                MessageBox.Show("Error " + xx, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void createKMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createKML m = new createKML
            {
                KMLEventCounter = Convert.ToInt32(csv.sEXCcounter)
            };
            m.Show();
        }
        private void BerekenAfstandPerSekMetode(double merker, int pos)
        {

            int tel;

            if (opSkermLandOpstuigMerker < merker)
            {
                tel = -1;
            }
            else
            {
                tel = 1;
            }

            if (opSkermLandOpstuigMerker == merker)
            {
                distansieVanAG.Text = "0 km | 0 NM";
                return;
            }

            double TotalDistance = 0;

            for (int i = 0; i < CSV.Rows.Count && i > (pos * -1); i += tel)
            {
                double.TryParse(CSV.Rows[pos + i][FlightParameters.rowCounter].ToString(), out double x);

                double GroundSpeed = Convert.ToDouble(CSV.Rows[pos + i][FlightParameters.speedGround]);
                //FU += ((Convert.ToDouble(dt.Rows[i][csv.eng1FuelFlow])) + (Convert.ToDouble(dt.Rows[i][csv.eng2FuelFlow]))) / 3600;
                double DistanceTraveledInMPS = (((GroundSpeed * 6076.12) / 3280) / 3600);
                TotalDistance += DistanceTraveledInMPS;

                //todo hierdie gaan nie werk as ek later met desimale counter posies werk nie.

                if (opSkermLandOpstuigMerker == x)
                {

                    distansieVanAG.Text = Math.Round(TotalDistance, 2) + " km | " + Math.Round(TotalDistance * 0.53947368421052631578947368421, 2) + " NM";
                    return;
                }

            }

        }
        /// <summary>
        /// Draw the graf lines. The scale is drawn under DrawScale.
        /// </summary>
        private void DrawBM()
        {
            int iy1,
                iy2,
                Height,
                iCCount;

            //double linePos;
            float h1;
            float h2;
            double[,] wind = new double[2, 2];
            double[] radioAlt = new double[2];
            double[] DME = new double[2];

            int[] iAP = new int[] { 0, 0, 0, 0 };

            float[] glideSlope = new float[2];

            string sLabel;

            Cursor.Current = Cursors.WaitCursor;

            Graphics objGraphics;
            objGraphics = Graphics.FromImage(bmGraph);

            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            // This is to check the counter count that will = time.
            try
            {
                Pen lpen = new Pen(Color.Blue, 1);
                Pen fpen = new Pen(Color.Green, 2);
                Font fnt = new Font("Tahoma", 8, FontStyle.Bold);
                SolidBrush sbLedger = new SolidBrush(Color.Black);
                objGraphics.Clear(Color.White);

                DrawScale();

                IList<string> Para = new List<string>();
                IList<Color> colors = new List<Color>();

                //top shift 4
                //bottom shift 7

                #region hide
                Para.Clear();
                colors.Clear();

                Height = pnlGraph.Height;
                scale = trkScaleH.Value * 0.05;

                drawStartPos = schGraphPos.Value;

                double widthCount = pnlGraph.Width / scale;
                int count = 0;

                KryOpstygLandWaardes(widthCount, schGraphPos.Value);

                float.TryParse(scale.ToString(), out float res1);

                //todo garmin frames
                #region teken message garnim
                //if (messagesToolStripMenuItem.Checked || csv.messageText != "")
                //{
                //    count = 0;
                //    h1 = 0;

                //    Para.Add("Messages");
                //    lpen.Color = Color.Orange;
                //    colors.Add(lpen.Color);

                //    iy1 = (int)(Height - (Height * 0.64f));

                //    for (int i = drawStartPos; i < CSVRowCount && count < widthCount; i++)
                //    {
                //        iCCount++;
                //        string s = CSV.Rows[i][csv.messageText].ToString();
                //        if (s != "")
                //        {
                //            objGraphics.DrawEllipse(lpen, h1, iy1 - 3, 5, 5);
                //        }

                //        h1 += res1;

                //    } // counter values
                //}
                #endregion
                #endregion

                #region Teken die waardes.
                int waardeWatGeplotMoetWordTel = 0;

                for (int t = 0; t < PlotList.Parameters.Count; t++)
                {
                    count = 0;
                    h1 = 0;
                    h2 = res1;

                    drawStartPos = schGraphPos.Value;

                    if (PlotList.Parameters[t].teken == true && PlotList.Parameters[t].tekenTipe.ToLower() == "grafiek")
                    {
                        Para.Add(PlotList.Parameters[t].waardeOmTePlot);
                        lpen.Color = PlotList.Parameters[t].kleur;
                        colors.Add(lpen.Color);

                        for (int i = drawStartPos; i < CSVRowCount - 10 && count < widthCount; i++) // AltitudeP
                        {
                            count++;
                            double a;
                            double b;
                            // teken merker lyn.

                            if (PlotList.Parameters[t].waardeOmTePlot.ToLower() == "daalspoed")//berekende waardes
                            {
                                if (i < 3)
                                {
                                    a = 0;
                                    b = 0;
                                }
                                else
                                {
                                    double.TryParse(CSV.Rows[i - 3][FlightParameters.altitudePressure].ToString(), out double een);//die twee is nuut
                                    double.TryParse(CSV.Rows[i + 3][FlightParameters.altitudePressure].ToString(), out double twee);
                                    double.TryParse(CSV.Rows[i - 2][FlightParameters.altitudePressure].ToString(), out double drie);
                                    double.TryParse(CSV.Rows[i + 4][FlightParameters.altitudePressure].ToString(), out double vier);
                                    a = (twee - een) * 10;
                                    b = (vier - drie) * 10;
                                }
                            }
                            else
                            {
                                double.TryParse(CSV.Rows[i][PlotList.Parameters[t].waardeOmTePlot].ToString(), out a);
                                double.TryParse(CSV.Rows[i + 1][PlotList.Parameters[t].waardeOmTePlot].ToString(), out b);
                            }

                            iy1 = (int)(Height - ((PlotList.Parameters[t].posisie + (bottomVal * PlotList.Parameters[t].skuif)) + (constant * ((float)(a / PlotList.Parameters[t].faktor)))));
                            iy2 = (int)(Height - ((PlotList.Parameters[t].posisie + (bottomVal * PlotList.Parameters[t].skuif)) + (constant * ((float)(b / PlotList.Parameters[t].faktor)))));

                            objGraphics.DrawLine(lpen, h1, iy1, h2, iy2);

                            h1 += res1;
                            h2 += res1;
                        }
                    }

                    if (PlotList.Parameters[t].teken == true && PlotList.Parameters[t].tekenTipe.ToLower() == "waarde")
                    {

                        int interval = (int)widthCount / 10;

                        iCCount = 0;

                        for (int i = drawStartPos; i < CSVRowCount && count < widthCount; i++)
                        {
                            iy1 = (int)(Height - (Height * 0.64f));

                            iCCount++;

                            double.TryParse(CSV.Rows[i][FlightParameters.rowCounter].ToString(), out double ryMerker);
                            double.TryParse(CSV.Rows[i][PlotList.Parameters[t].waardeOmTePlot].ToString(), out double counter);

                            if (iCCount == interval)
                            {
                                iy1 -= waardeWatGeplotMoetWordTel * 13;
                                //sLabel = Math.Round(counter, 1).ToString();
                                sLabel = CSV.Rows[i][PlotList.Parameters[t].waardeOmTePlot].ToString();
                                lpen.Color = Color.Black;
                                if (waardeWatGeplotMoetWordTel == 0)
                                {
                                    objGraphics.DrawLine(lpen, h1 - 2, iy1, h1 - 2, iy1 + 15);
                                }

                                objGraphics.DrawString(sLabel, fnt, new SolidBrush(Color.Black), h1 + 2, iy1 + 10);
                                iCCount = 0;
                            }
                            if (ryMerker == beginMerkerPosiesie && tekenBeginMerkerLyn)
                            {// todo maak dat die lyn getrek word vir al die exceedances....

                                lpen.Color = Color.Magenta;
                                objGraphics.DrawLine(lpen
                                                    , h1 - 2
                                                    , (float)30
                                                    , h1 - 2
                                                    , pnlGraph.Height - 30);
                            }

                            h1 += res1;
                        } // counter values

                        waardeWatGeplotMoetWordTel += 1;
                    }
                }

                #endregion

                #region check if warning was checked
                //int yi = 0;

                //foreach (ToolStripMenuItem item in warningsToolStripMenuItem.DropDownItems)
                //{

                //    if (item.Checked)
                //    {
                //        count = 0;
                //        h1 = 0;

                //        Para.Add(item.Name);

                //        if (yi == 0)
                //        {
                //            lpen.Color = Color.DarkRed;
                //        }
                //        else if (yi == 10)
                //        {
                //            lpen.Color = Color.DarkOrange;
                //        }
                //        else if (yi == 20)
                //        {
                //            lpen.Color = Color.Red;
                //        }
                //        else if (yi == 30)
                //        {
                //            lpen.Color = Color.Orange;
                //        }
                //        else if (yi == 40)
                //        {
                //            lpen.Color = Color.Gold;
                //        }
                //        else
                //        {
                //            lpen.Color = Color.Black;
                //        }


                //        lpen.Width = 3;

                //        colors.Add(lpen.Color);

                //        iy1 = (int)((Height - (Height * 0.64f)) + 20 + yi);

                //        for (int i = drawStartPos; i < CSVRowCount && count < widthCount; i++)
                //        {
                //            iCCount++;
                //            string s = CSV.Rows[i][item.Name].ToString();

                //            if (s == "1")
                //            {
                //                objGraphics.DrawLine(lpen, h1 - 2, iy1, h1 - 2, iy1 + 8);
                //            }

                //            h1 += res1;

                //        } // counter values
                //        yi += 10;
                //    }

                //}

                #endregion

                #region ledger
                // hier skyf ek die ledger
             
                //int LedgerWidth = 50;
                //int LedgerCount = 1;
                //int LedgerHeight = 5;
                //for (int i = 0; i < Para.Count; i++)
                //{
                //    sbLedger.Color = colors[i];
                //    objGraphics.DrawString(Para[i], fnt, sbLedger, LedgerWidth, LedgerHeight);
                //    LedgerHeight += 10;
                //    LedgerCount += 1;
                //    if (LedgerCount % 5 == 0)
                //    {
                //        LedgerWidth += 100;
                //        LedgerCount = 1;
                //        LedgerHeight = 5;

                //    }
                //}
                #endregion
            }
            catch (IndexOutOfRangeException)
            { }
            catch (Exception ee)
            {
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show(this
                    , ee.Message.ToString()
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                objGraphics.Dispose();
            }

            Cursor.Current = Cursors.Arrow;

        }
        /// <summary>
        /// Draw the horisontal scale values.
        /// </summary>
        private void DrawScale()
        {
            //int iAlt = 0, h1, h2;
            //float fy;
            setScale();
            string sValue = "0";

            Cursor.Current = Cursors.WaitCursor;

            Graphics objGraphics;
            objGraphics = Graphics.FromImage(bmGraph);

            // scale is set as 


            try
            {
                Pen lpen = new Pen(Color.LightGray, 1);
                objGraphics.Clear(Color.White);

                int h1 = 35;
                int h2 = pnlGraph.Width - 35;
                float fy = pnlGraph.Height - constant;
                int iAlt = -500;
                int iVSI = -4000;
                //draw the bottom part of the grapf
                for (int i = 0; i < 17; i++)
                {
                    sValue = iAlt.ToString();
                    objGraphics.DrawLine(lpen, h1, fy, h2, fy);
                    objGraphics.DrawString(sValue, new Font("Aerial", 10), new SolidBrush(Color.Black), 0, fy - 7);
                    objGraphics.DrawString(iVSI.ToString(), new Font("Aerial", 10), new SolidBrush(Color.Black), pnlGraph.Width - 35, fy - 7);
                    fy -= constant;
                    iVSI += 500;
                    iAlt += 500;
                }
                // Teken die grafiek labels (onderste)

                fy -= (constant * 2);

                iAlt = 0; 
                iVSI = 4;
                for (int i = 0; i < 8; i++)
                {
                    sValue = iAlt.ToString();
                    objGraphics.DrawLine(lpen, h1, fy, h2, fy);
                    objGraphics.DrawString(sValue, new Font("Tahoma", 10), new SolidBrush(Color.Black), 0, fy - 7);
                    objGraphics.DrawString(iVSI.ToString(), new Font("Aerial", 10), new SolidBrush(Color.Black), pnlGraph.Width - 35, fy - 7);
                    iVSI -= 1;
                    fy -= (constant);
                    iAlt += 50;
                }



                objGraphics.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.ToString(), FormAppMessages.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Arrow;
            }
            Cursor.Current = Cursors.Arrow;

        }

        double initialSpeed = 0;
        double finalSpeed = 0;
        //double initialCount = 0;
        //double finalCount = 0;
        

        private void frmGraph_KeyDown(object sender, KeyEventArgs e)
        {
            int pw = (int)((pnlGraph.Width / scale) / 2);
            int a = (int)(line19.Location.X / scale) + drawStartPos;

            #region old code // not needed due to the new small file size
            if (e.Control && e.KeyCode == Keys.L && csv.airGnd != "")
            {
                 pw = (int)((pnlGraph.Width / scale) / 2);
                 a = (int)(line19.Location.X / scale) + drawStartPos;
                for (int i = a; i < CSVRowCount - 1; i++)
                {
                    int[] y = new int[2];

                    int.TryParse(CSV.Rows[i][csv.airGnd].ToString(), out y[0]);
                    int.TryParse(CSV.Rows[i + 1][csv.airGnd].ToString(), out y[1]);

                    if (y[0] == 1 && y[1] == 0)
                    {
                        schGraphPos.Value = i - pw;
                        break;
                    }
                }

                StatusBar();
                Application.DoEvents();

                DrawBM();
                ShowBM();
                WriteVal();
            }
            if (e.Control && e.KeyCode == Keys.Left && csv.airGnd != "")
            {
                for (int i = a; i > 10; i--)
                {
                    int[] y = new int[2];

                    int.TryParse(CSV.Rows[i][csv.airGnd].ToString(), out y[0]);
                    int.TryParse(CSV.Rows[i + 1][csv.airGnd].ToString(), out y[1]);

                    if (y[0] == 0 && y[1] == 1)
                    {
                        schGraphPos.Value = i - pw;
                        break;
                    }
                }

                StatusBar();
                Application.DoEvents();

                DrawBM();
                ShowBM();
                WriteVal();
            }
            #endregion
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                Pen lpen = new Pen(noteColor);
                lpen.Width = 2f;
                Font fnt = new Font("Tahoma", 8, FontStyle.Bold);
                SolidBrush b = new SolidBrush(noteColor);
                Graphics g;

                g = Graphics.FromImage(bmGraph);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                Point een = pnlGraph.PointToClient(Cursor.Position);
                Point twee = new Point(een.X, een.Y + 20);

                g.DrawEllipse(lpen, een.X - 10, een.Y - 10, 20, 20);
                g.DrawString(noteTextToolStripTextBox.Text, fnt, b, een.X + 15, een.Y);

                ShowBM();

            }
           
            if (e.Control && e.KeyCode == Keys.S)
            {
                initialSpeed = lubberLineValueToReturn(FlightParameters.speedGround);
                //initialCount = lubberLineValueToReturn(FlightParameters.rowCounter);
                Tools.StartCounter = lubberLineValueToReturn(FlightParameters.rowCounter);
                startCounter.Text = Tools.StartCounter.ToString();

            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                finalSpeed = lubberLineValueToReturn(FlightParameters.speedGround);
                Tools.EndCounter = lubberLineValueToReturn(FlightParameters.rowCounter);
                endCounter.Text = Tools.EndCounter.ToString();
                toolStripStatusLabelAcceleration.Text = cCalc.Acceleration(initialSpeed, finalSpeed, Tools.EndCounter - Tools.StartCounter).ToString() + " fps^2"; 
            }
        }
        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WriteVal();
                int pos = getCsvPosition();

                int.TryParse(toolStripComboAccelerationSeconds.Text.ToString(), out int seconds);

                if (seconds > 0 && accelerationToolStripMenuItem.Checked)
                {
                    double.TryParse(CSV.Rows[pos][FlightParameters.speedGround].ToString(), out double initialSpeed);
                    double.TryParse(CSV.Rows[pos + seconds][FlightParameters.speedGround].ToString(), out double finalSpeed);
                    toolStripStatusLabelAcceleration.Text = Math.Round(cCalc.Acceleration(initialSpeed, finalSpeed, seconds), 3).ToString() +
                        " over " + seconds.ToString() + " s : fps^2";
                }
                else if (!accelerationToolStripMenuItem.Checked)
                {
                    toolStripStatusLabelAcceleration.Text = "";
                }
                else
                {
                    toolStripStatusLabelAcceleration.Text = "error";
                }
                

            }
            
            
        }
        private void frmGraph_Load(object sender, System.EventArgs e)
        {
            line19.Height = ClientSize.Height;
            bmGraph = new Bitmap(pnlGraph.Width, pnlGraph.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            try
            {

                if (schGraphPos.Value == 0)
                {

                    CSV = DataToAnalyse.fdaDataTable;
                    CSVRowCount = CSV.Rows.Count;
                    schGraphPos.Maximum = CSVRowCount;
                    beginMerkerPosiesie = int.Parse(csv.sEXCcounter);
                    gotoCounter(beginMerkerPosiesie);

                }

                StatusBar();
                Application.DoEvents();
                aplicationMode();
                //addWarningsToolDropDownItems();
                setScale();
                setPlotList(); // this should be set when the graph is called to enable then graph to open displaying certain settings.
                stelVinnigeKnopies();

                DrawBM();
                ShowBM();
                schGraphPos.SmallChange = (int)((pnlGraph.Width / scale) * 0.25);
                schGraphPos.LargeChange = (int)((pnlGraph.Width / scale) * 0.5);

                line19.Location = new Point(ActiveForm.Left + (ActiveForm.Width / 2), 0);
                WriteVal();

            }
            catch
            { }
        }
        private void gotoCounter(int counter)
        {
            scale = trkScaleH.Value * 0.05;

            int derde = int.Parse(Math.Round(((pnlGraph.Width / scale) / 3), 0).ToString());


            for (int i = 0; i < CSVRowCount; i++)
            {
                double.TryParse(CSV.Rows[i][FlightParameters.rowCounter].ToString(), out double exPos);

                if (exPos == counter && i > derde)
                {
                    schGraphPos.Value = i - derde;
                    break;
                }
                else if (exPos > counter)
                {
                    break;
                }

            }
        }
        private void KryOpstygLandWaardes(double merkies, int tekenBegin)
        {
            int count = 0;

            if (!CSV.Columns.Contains(FlightParameters.airGround)
                && !CSV.Columns.Contains(FlightParameters.altitudePressure))
            {
                return;
            }

            int[] alt = new int[2];
            int[] ag = new int[2];

            for (int i = tekenBegin; i < CSVRowCount - 1 && count < merkies; i++)
            {
                count++;
                int.TryParse(CSV.Rows[i][FlightParameters.airGround].ToString(), out ag[0]);

                int.TryParse(CSV.Rows[i + 1][FlightParameters.airGround].ToString(), out ag[1]);

                if (ag[0] != ag[1])
                {
                    if (int.TryParse(CSV.Rows[i][FlightParameters.altitudePressure].ToString(), out opSkermHoogte))
                    { }
                    else
                    {
                        opSkermHoogte = -5000;
                    }
                    if (double.TryParse(CSV.Rows[i][FlightParameters.rowCounter].ToString(), out opSkermLandOpstuigMerker))
                    { }
                    else
                    {
                        opSkermLandOpstuigMerker = 0;
                    }
                }
            }

            skermHoogte.Text = opSkermHoogte.ToString() + " alt";
            skermAGMerker.Text = opSkermLandOpstuigMerker.ToString();

        }
        private void warningMenuItem_Click(object sender, System.EventArgs e)
        {
            DrawScale();
            DrawBM();
            ShowBM();
        }
        void b_Click(object sender, EventArgs e)
        {
            var knop = sender as ToolStripButton;

            for (int y = 0; y < PlotList.Parameters.Count; y++)
            {
                if (knop.Name.ToLower() == PlotList.Parameters[y].waardeOmTePlot.ToLower())
                {
                    PlotList.Parameters[y].teken = knop.Checked;
                    DrawBM();
                    ShowBM();
                   
                   // dataGridView1.DataSource = PlotList.Parameters;
                    
                    return;
                }
            }
            //dataGridView1.DataSource = PlotList.Parameters;

            //MessageBox.Show(button.Text + " " + button.Name, "die knoppie se text.");
        }
        private void mFileSave_Click(object sender, EventArgs e)
        {
            Save_Graph();
        }
        private void setStartCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Tools.StartCounter = lubberLineValueToReturn(FlightParameters.rowCounter);
                startCounter.Text = Tools.StartCounter.ToString();

            }
            catch (Exception xx)
            {
                MessageBox.Show(this
                    ,"An error occurred in set start counter. " + xx.Message
                    , FormAppMessages.ApplicationName
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

        }
        private void setEndCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.EndCounter = lubberLineValueToReturn(FlightParameters.rowCounter);
                endCounter.Text = Tools.EndCounter.ToString();

            }
            catch (Exception xx)
            {
                MessageBox.Show(this
                    , "An error occurred in set start counter. " + xx.Message
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }
        }
        private void createKMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EventCounter;
            int.TryParse(csv.sEXCcounter, out EventCounter);
            createKML m = new createKML() 
            { StartCounter = Convert.ToInt32(Tools.StartCounter)
            , EndCounter = Convert.ToInt32(Tools.EndCounter)
            , KMLEventCounter = EventCounter};
                   
            m.Show(this);
        }
        private void showDistanceResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this
                ,"Distance " + Math.Round(Tools.Distance, 3) + " Km " + " Burn " + Tools.FU + " kg."
                ,FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result;
            userInput tes = new userInput();

            tes.ShowDialog();
            result = tes.resultText;


            tes.Dispose();

            MessageBox.Show(result, "Me input box waarde.");
        }
        private void Save_Graph()
        {
            Cursor.Current = Cursors.WaitCursor;
            string sPath = Application.StartupPath;

            try
            {
                if (bmGraph != null)
                {

                    saveFileDialog.InitialDirectory = "C:\\";
                    saveFileDialog.FileName = FOQAData.csv.csvFileName + "-" + FOQAData.csv.sExcID;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bmGraph.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Done saving file.", sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File not saved!", sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There is noting to save.", sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), sMessages.sMessageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DrawBM();
                Cursor.Current = Cursors.Default;
            }
        }
        private void schGraphPos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                StatusBar();
                DrawBM();
                ShowBM();
            }
        }
        private void schGraphPos_ValueChanged(object sender, System.EventArgs e)
        {

            StatusBar();
            DrawBM();
            ShowBM();

        }
        private void setScale()
        {
            bottomVal = pnlGraph.Height * 0.036f;
            topVal = pnlGraph.Height * 0.666666f;
            constant = bottomVal;
        }
        private void ShowBM()
        {
            Graphics objGraphics;
            objGraphics = pnlGraph.CreateGraphics();
            objGraphics.DrawImage(bmGraph, 0, 0, bmGraph.Width, bmGraph.Height);
            objGraphics.Dispose();
        }
        private void StatusBar()
        {
            Merker.Text = "- " + csv.sEXCcounter;
            Gebeurtenis.Text = "Exc " + csv.sExceedance;
            Gebeurtenis.ToolTipText = csv.sEXCnote;
        }
        private void setPlotList()
        {
            if (PlotList.Parameters.Count > 0) //removed this as these properties need to be set every time the new event is viewed.
            {
            return;
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationLongitudinalMax))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.accelerationLongitudinalMax,
                    kleur = Color.DarkBlue,
                    knopieNaam = "Acceleration Longitudenal max",
                    knopieNaamKort = "Aclx",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationLongitudinalMin))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.accelerationLongitudinalMin,
                    kleur = Color.Red,
                    knopieNaam = "Acceleration Longitudenal min",
                    knopieNaamKort = "Aclm",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }
            if (FlightParameters.accelerationVerticalMin != null)
            {
                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationVerticalMin))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.accelerationVerticalMin,
                        kleur = Color.Red,
                        knopieNaam = "Acceleration vertical min",
                        knopieNaamKort = "Acvm",
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 23,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = false,
                        faktor = 1,
                        vinnigeKnopie = true
                    });
                }
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.accelerationVerticalMax))
            {
                bool teken = false;

                if (csv.sExceedance.ToLower().Contains("landing g"))
                {
                    teken = true;
                }
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.accelerationVerticalMax,
                    kleur = Color.DarkGreen,
                    knopieNaam = "Acceleration vertical max",
                    knopieNaamKort = "AcvX",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = teken,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.airGround))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.airGround,
                    kleur = Color.Brown,
                    knopieNaam = "airGround",
                    knopieNaamKort = "AG",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }


            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.attitudeRollLeft))
            {
                bool teken = false;

                if (csv.sExceedance.ToLower().Contains("bank"))
                {
                    teken = true;
                }
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.attitudeRollLeft,
                    kleur = Color.Brown,
                    knopieNaam = "Attitude Roll",
                    knopieNaamKort = "ARl",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = teken,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 10,
                    vinnigeKnopie = true
                });
            }

            PlotList.Parameters.Add(new PlotParameters
            {
                waardeOmTePlot = FlightParameters.altitudePressure,
                kleur = Color.Blue,
                knopieNaam = "Altitude Pressure",
                knopieNaamKort = "AltP",
                breedte = 1,
                posisie = bottomVal,
                skuif = 1,
                teken = true,
                tekenTipe = "grafiek",
                //tekenAanvanklik = true,
                faktor = 500,
                vinnigeKnopie = true
            });

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.attitudePitchLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.attitudePitchLeft,
                    kleur = Color.Brown,
                    knopieNaam = "Attitude Pith",
                    knopieNaamKort = "APi",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 10,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.altitudeRadioLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.altitudeRadioLeft,
                    kleur = Color.BlueViolet,
                    knopieNaam = "Altitude Radio",
                    knopieNaamKort = "AltR",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 500,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.autoPilotA))
            {
                bool teken = false;

                if (csv.sExceedance.ToLower().Contains("auto"))
                {
                    teken = true;
                }
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.autoPilotA,
                    kleur = Color.Brown,
                    knopieNaam = "Auto Pilot A",
                    knopieNaamKort = "APA",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 10,
                    teken = teken,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.autoPilotB))
            {
                bool teken = false;

                if (csv.sExceedance.ToLower().Contains("auto"))
                {
                    teken = true;
                }
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.autoPilotB,
                    kleur = Color.Brown,
                    knopieNaam = "Auto Pilot B",
                    knopieNaamKort = "APB",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 10,
                    teken = teken,
                    tekenTipe = "grafiek",
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.flapHandlePosition))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.flapHandlePosition,
                    kleur = Color.DarkMagenta,
                    knopieNaam = "Flap handle position",
                    knopieNaamKort = "fHDL",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    faktor = 5,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.flapTeLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.flapTeLeft,
                    kleur = Color.DarkCyan,
                    knopieNaam = "Flap TE Left",
                    knopieNaamKort = "fTE",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = true,
                    tekenTipe = "grafiek",
                    faktor = 5,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankLeftQuantity))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.fuelTankLeftQuantity,
                    kleur = Color.Black,
                    knopieNaam = "fuel left tank",
                    knopieNaamKort = "fLt",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 5000,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankCenterQuantity))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.fuelTankCenterQuantity,
                    kleur = Color.Black,
                    knopieNaam = "fuel centre tank",
                    knopieNaamKort = "fCt",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 5000,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTankRightQuantity))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.fuelTankRightQuantity,
                    kleur = Color.Black,
                    knopieNaam = "fuel right tank",
                    knopieNaamKort = "fRt",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 5000,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.fuelTotalQuantity))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.fuelTotalQuantity,
                    kleur = Color.Black,
                    knopieNaam = "Fuel Quantity Total",
                    knopieNaamKort = "Fuel",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 5000,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.grossWeight))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.grossWeight,
                    kleur = Color.Brown,
                    knopieNaam = "GrossWeight",
                    knopieNaamKort = "GW",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 50000,
                    vinnigeKnopie = true
                });
            }


            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.rowCounter))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.rowCounter,
                    kleur = Color.Black,
                    knopieNaam = "Counter",
                    knopieNaamKort = "co",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 0,
                    teken = true,
                    tekenTipe = "waarde",
                    //tekenAanvanklik = true,
                    faktor = 500,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navDevGSLeft))
            {
                bool teken = true;

                if (csv.sExceedance.ToLower().Contains("ils"))
                {
                    teken = true;
                }
                else
                {
                    teken = graphUserSettings.ilsGS;
                }

                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.navDevGSLeft,
                    kleur = Color.DarkBlue,
                    knopieNaam = "Glide Slope Dev",
                    knopieNaamKort = "GSd",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = teken,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = -0.1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navDevLocLeft))
            {
                bool teken = true;

                if (csv.sExceedance.ToLower().Contains("ils"))
                {
                    teken = true;
                }
                else
                {
                    teken = graphUserSettings.ilsLoc;
                }

                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.navDevLocLeft,
                    kleur = Color.SlateBlue,
                    knopieNaam = "Localiser Dev",
                    knopieNaamKort = "LOCd",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 23,
                    teken = teken,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = -0.1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.navFreqLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.navFreqLeft,
                    kleur = Color.DarkCyan,
                    knopieNaam = "Nav Freq Left",
                    knopieNaamKort = "fqL",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 0,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }
            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.magneticHeadingLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.magneticHeadingLeft,
                    kleur = Color.DeepPink,
                    knopieNaam = "Magnetic Heading",
                    knopieNaamKort = "HDG",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = true,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }
            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedCAS))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedCAS,
                    kleur = Color.DarkCyan,
                    knopieNaam = "CAS",
                    knopieNaamKort = "CAS",
                    breedte = 0,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = true,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedBrakeHandle))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedBrakeHandle,
                    kleur = Color.SteelBlue,
                    knopieNaam = "SpeedBrake",
                    knopieNaamKort = "SB",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = -50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedGround))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedGround,
                    kleur = Color.Black,
                    knopieNaam = "GS",
                    knopieNaamKort = "GS",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedMach))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedMach,
                    kleur = Color.Red,
                    knopieNaam = "mach",
                    knopieNaamKort = "mach",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = false,
                    faktor = 0.5,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedV2))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedV2,
                    kleur = Color.DarkMagenta,
                    knopieNaam = "V2",
                    knopieNaamKort = "V2",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.speedVref))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.speedVref,
                    kleur = Color.DarkMagenta,
                    knopieNaam = "Vref | TakeOff Vref",
                    knopieNaamKort = "Vref",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            bool tekenVs = true;

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.TAT))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.TAT,
                    kleur = Color.DarkGray,
                    knopieNaam = "TAT",
                    knopieNaamKort = "TAT",
                    breedte = 0,
                    posisie = bottomVal,
                    skuif = 19,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (csv.sExceedance.ToLower().Contains("rate"))
            {
                tekenVs = true;
            }
            PlotList.Parameters.Add(new PlotParameters
            {
                waardeOmTePlot = "DaalSpoed",
                kleur = Color.LimeGreen,
                knopieNaam = "Vertical speed calculated",
                knopieNaamKort = "VS",
                posisie = bottomVal,
                skuif = 8,
                teken = tekenVs,
                tekenTipe = "grafiek",
                //tekenAanvanklik = true,
                faktor = 500,
                vinnigeKnopie = true
            });

            Type t = typeof(JetEngineParameters);
            PropertyInfo[] pi = typeof(JetEngineParameters).GetProperties();
            Color[] colors = { Color.Brown, Color.Chocolate, Color.DarkGreen
                              ,Color.DarkKhaki, Color.IndianRed, Color.DarkSalmon
                              ,Color.DarkSlateGray, Color.DarkGray, Color.Black
                              ,Color.DarkMagenta, Color.DarkSlateBlue, Color.Blue};
            int count = 0;

            for (int i = 0; i < FlightParameters.JetEngineParameters.Count; i++)
            {
                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].bleed))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].bleed,
                        kleur = Color.Black,
                        knopieNaam = "bleed " + (i + 1),
                        knopieNaamKort = "b " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 50,
                        vinnigeKnopie = true
                    });
                    count++;
                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].egt))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].egt,
                        kleur = colors[count],
                        knopieNaam = "EGT " + FlightParameters.JetEngineParameters[i].egt,
                        knopieNaamKort = "EGT " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 500,
                        vinnigeKnopie = true
                    });
                    count++;
                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].N1))
                {
                    bool teken = true;

                    if (csv.sExceedance.ToLower().Contains("low n"))
                    {
                        teken = true;  
                    }

                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].N1,
                        kleur = colors[count],
                        knopieNaam = "N1 " + FlightParameters.JetEngineParameters[i].N1,
                        knopieNaamKort = "N1 " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = teken,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 50,
                        vinnigeKnopie = true
                    });
                    count++;
                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].N2))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].N2,
                        kleur = colors[count],
                        knopieNaam = "N2 " + FlightParameters.JetEngineParameters[i].N2,
                        knopieNaamKort = "N2 " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 50,
                        vinnigeKnopie = true
                    });
                    count++;
                }
                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].oilPressure))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].oilPressure,
                        kleur = colors[count],
                        knopieNaam = "OP " + FlightParameters.JetEngineParameters[i].oilPressure,
                        knopieNaamKort = "OP " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 10,
                        vinnigeKnopie = true
                    });
                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].oilTemp))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].oilTemp,
                        kleur = colors[count],
                        knopieNaam = "OT " + FlightParameters.JetEngineParameters[i].oilTemp,
                        knopieNaamKort = "OT " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 10,
                        vinnigeKnopie = true
                    });
                }

                if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.JetEngineParameters[i].fuelLever))
                {
                    PlotList.Parameters.Add(new PlotParameters
                    {
                        waardeOmTePlot = FlightParameters.JetEngineParameters[i].fuelLever,
                        kleur = colors[count],
                        knopieNaam = "FL " + FlightParameters.JetEngineParameters[i].fuelLever,
                        knopieNaamKort = "EFL " + (i + 1),
                        breedte = 1,
                        posisie = bottomVal,
                        skuif = 19,
                        teken = false,
                        tekenTipe = "grafiek",
                        //tekenAanvanklik = true,
                        faktor = 1,
                        vinnigeKnopie = true
                    });
                }
                count++;

            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.gearLeverDown))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.gearLeverDown,
                    kleur = Color.Black,
                    knopieNaam = "Gear lever Down",
                    knopieNaamKort = "GLD",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 2,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }
            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.gearUpLeft))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.gearUpLeft,
                    kleur = Color.DarkBlue,
                    knopieNaam = "Gear up left",
                    knopieNaamKort = "GUL",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 3,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.windDirection))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.windDirection,
                    kleur = Color.DarkBlue,
                    knopieNaam = "Wind direction",
                    knopieNaamKort = "WD",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.windVelocity))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.windVelocity,
                    kleur = Color.DarkMagenta,
                    knopieNaam = "Wind velocity",
                    knopieNaamKort = "WS",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 1,
                    teken = false,
                    tekenTipe = "grafiek",
                    //tekenAanvanklik = true,
                    faktor = 50,
                    vinnigeKnopie = true
                });
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.GMTtime))
            {
                PlotList.Parameters.Add(new PlotParameters
                {
                    waardeOmTePlot = FlightParameters.GMTtime,
                    kleur = Color.Black,
                    knopieNaam = "GMT",
                    knopieNaamKort = "GMT",
                    breedte = 1,
                    posisie = bottomVal,
                    skuif = 2,
                    teken = false,
                    tekenTipe = "waarde",
                    //tekenAanvanklik = ,
                    faktor = 1,
                    vinnigeKnopie = true
                });
            }

            plotWaardesGestel = true;
        }
        private void stelVinnigeKnopies()
        {
            if (vinnigeKnoppiesGestel)
            {
                return;
            }
            for (int i = 0; i < PlotList.Parameters.Count; i++)
            {
                if (PlotList.Parameters[i].vinnigeKnopie == true)
                {
                    ToolStripButton b = new ToolStripButton();
                    b.Name = PlotList.Parameters[i].waardeOmTePlot;
                    b.Text = PlotList.Parameters[i].knopieNaamKort;
                    b.Checked = PlotList.Parameters[i].teken;
                    b.CheckOnClick = true;
                    b.Click += b_Click;
                    b.ToolTipText = PlotList.Parameters[i].knopieNaam;
                    toolStrip.Items.Add(b);
                }
            }

            positionOnGoogle.Enabled = CSV.Columns.Contains(FlightParameters.latitude);
            vinnigeKnoppiesGestel = true;
        }
        private void trkScaleH_ValueChanged(object sender, System.EventArgs e)
        {
            schGraphPos.SmallChange = (int)((pnlGraph.Width / scale) * 0.15);
            schGraphPos.LargeChange = (int)((pnlGraph.Width / scale) * 0.5);
            DrawBM();
            ShowBM();
        }
        private void noteCoulorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                noteColor = colorDialog.Color;
            }
        }
        private void positionOnGoogle_Click(object sender, EventArgs e)
        {
            GoogleWysPosisie(Convert.ToDouble(CSV.Rows[iPos][FlightParameters.latitude]), Convert.ToDouble(CSV.Rows[iPos][FlightParameters.longitude]));
        }
        private void GoogleWysPosisie(double latitude, double longitude)
        {
            if (iPos == 0)
            {
                MessageBox.Show("No position to draw.", "Flight View", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            StringBuilder sGoogleViewLatLong = new StringBuilder();
            sGoogleViewLatLong.Append("http://maps.google.com/maps?q=");
            sGoogleViewLatLong.Append(latitude.ToString() + "," + longitude.ToString());
            System.Diagnostics.Process.Start(sGoogleViewLatLong.ToString());

        }

        private void graphParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form g = new graphParameters();
            g.Show();
        }

        private void frmGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlotList.Parameters.Clear();
        }

        /// <summary>
        /// Write the values next to the lubbeline.
        /// </summary>
        private void WriteVal()
        {
            float fHeight = pnlGraph.Height;

            Point po = this.PointToClient(Cursor.Position);

            //line19.Location = new Point(po.X - 3, 0); // x was minus 3
            line19.Location = new Point(po.X, 0);

            iPos = getCsvPosition();

            if (iPos > CSV.Rows.Count - 10 || iPos < 10)
            {
                return;
            }
            #region werk nie nou met die nie
            #region Flight details

            if (CSV.Columns.Contains(FlightParameters.flightNumber))
            {
                vlugNommer.Text = "# " + Convert.ToString(CSV.Rows[iPos][FlightParameters.flightNumber]);
            }
            else
            {
                vlugNommer.Text = "---";
            }

            if (DataToAnalyse.fdaDataTable.Columns.Contains(FlightParameters.GMTdate))
            {
               
                Datum.Text = CSV.Rows[iPos][FlightParameters.GMTdate].ToString();

            }
            else
            {
                Datum.Text = "No date";
            }
            #endregion


            #endregion

            if (CSV.Columns.Contains(FlightParameters.rowCounter) && double.TryParse(CSV.Rows[iPos][FlightParameters.rowCounter].ToString(), out double counter))
            {
                BerekenAfstandPerSekMetode(counter, iPos);
            }

            

            Font fnt = new Font("Calibri", 10, FontStyle.Bold);
            SolidBrush bsl = new SolidBrush(Color.Red);
            Point point = new Point();
            float spasie = (float)(fHeight * 0.036);
            float tweede = (pnlGraph.Height * 0.66666f);
            int waardeWatGeplotMoetWordTel = 0;

            int tekenParameters = 0;
            
            for (int i = 0; i < PlotList.Parameters.Count; i++)
            {
                if (PlotList.Parameters[i].teken)
                {
                    tekenParameters++;
                }
            }
            
            List <TekenWaardes> tw = new List<TekenWaardes>();

            tekenParameters = 0;

            for (int i = 0; i < PlotList.Parameters.Count; i++)
            {
                if (PlotList.Parameters[i].teken && PlotList.Parameters[i].tekenTipe == "grafiek")
                {
                    string tekenWaarde = "";
                    double x;

                    if (PlotList.Parameters[i].waardeOmTePlot.ToLower() == "daalspoed")
                    {
                        double.TryParse(CSV.Rows[iPos - 3][FlightParameters.altitudePressure].ToString(), out double een);//die twee is nuut
                        double.TryParse(CSV.Rows[iPos + 3][FlightParameters.altitudePressure].ToString(), out double twee);
                        x = (twee - een) * 10;
                        tekenWaarde = x.ToString();

                    }
                    else if (PlotList.Parameters[i].waardeOmTePlot.ToLower() == FlightParameters.altitudePressure.ToLower())
                    {
                        if (double.TryParse(CSV.Rows[iPos][PlotList.Parameters[i].waardeOmTePlot].ToString(), out x))
                        {

                            tekenWaarde = x.ToString() + " [" + (x - opSkermHoogte).ToString() + "]";
                        }
                        else
                        {
                            //x = 0;
                            tekenWaarde = "|";
                        }
                    }
                    else
                    {
                        if (double.TryParse(CSV.Rows[iPos][PlotList.Parameters[i].waardeOmTePlot].ToString(), out x))
                        {
                            tekenWaarde = x.ToString();
                        }
                        else
                        {
                            tekenWaarde = "|";
                        }

                    }

                    point.X = po.X + 2;

                    point.Y = (int)(fHeight - (PlotList.Parameters[i].posisie + (constant * (x / PlotList.Parameters[i].faktor)))) - 15;

                    point.Y -= (int)(PlotList.Parameters[i].skuif * constant);

                    tw.Add(new TekenWaardes() {
                         waardeKleur = PlotList.Parameters[i].kleur
                        ,waardeNaam = PlotList.Parameters[i].knopieNaamKort
                        ,waardeOmTeKsryf = tekenWaarde
                        ,tekenPosiesie = point.Y});
                 
                    tekenParameters++;
                    
                }

                if (PlotList.Parameters[i].teken && PlotList.Parameters[i].tekenTipe == "waarde")
                {
                    //bsl.Color = p[i].kleur;

                    if (PlotList.Parameters[i].waardeOmTePlot.ToLower() == FlightParameters.rowCounter.ToLower())
                    {
                        huidigeCounter = double.Parse(CSV.Rows[iPos][PlotList.Parameters[i].waardeOmTePlot].ToString());
                    }

                    string s = CSV.Rows[iPos][PlotList.Parameters[i].waardeOmTePlot].ToString();
                    point.X = po.X + 2;
                    point.Y = (int)(fHeight - (fHeight * 0.64f));
                    point.Y -= waardeWatGeplotMoetWordTel * 13;

                    tw.Add(new TekenWaardes()
                    {
                         waardeKleur = PlotList.Parameters[i].kleur
                        ,waardeNaam = PlotList.Parameters[i].knopieNaamKort
                        ,waardeOmTeKsryf = s
                        ,tekenPosiesie = point.Y
                    });

                    waardeWatGeplotMoetWordTel += 1;
                    tekenParameters++;
                }

            }

            // sprei waardes wat geteken word.
            SpryTekenWaardes(tw, 11);

            //skryf die waardes
            //todo sit die x waarde by wat geplot moet word en dan kan hulle hier geteken word.

            for (int w = 0; w < tw.Count; w++)
            {
                point.Y = tw[w].tekenPosiesie;
                bsl.Color = tw[w].waardeKleur;

                pnlGraph.CreateGraphics().DrawString(tw[w].waardeOmTeKsryf + " " + tw[w].waardeNaam, fnt, bsl, point);
            }

            iCount += 1;

            if (iCount == 3)
            {
                ShowBM();
                iCount = 0;
            }
        }
       
        private static List<TekenWaardes> SpryTekenWaardes(List<TekenWaardes> tw, int spasie)
        {
  
            tw.Sort();

            for (int i = 0; i < tw.Count - 1; i++)
            {

                if (Math.Abs(tw[i].tekenPosiesie - tw[i + 1].tekenPosiesie) <= spasie)

                {
                    int z = 0;
                    do
                    {
                        if (tw[i + 1].tekenPosiesie - tw[i].tekenPosiesie <= 0)
                        {
                            tw[i + 1].tekenPosiesie = tw[i].tekenPosiesie + spasie;
                            z++;
                        }
                        else if (tw[i + 1].tekenPosiesie == tw[i].tekenPosiesie)// maak seker as die waardes verskillend is dat die waardes gesprei word
                        {
                            tw[i + 1].tekenPosiesie += spasie;
                            z++;
                        }
                        else
                        {
                            tw[i + 1].tekenPosiesie += (spasie - Math.Abs(tw[i + 1].tekenPosiesie - tw[i].tekenPosiesie));
                            z++;
                        }

                    } while (tw[i + 1].tekenPosiesie - tw[i].tekenPosiesie < spasie && i < tw.Count && i > 0 && z < tw.Count);
                }
            }

            return tw;
        }
        /// <summary>
        /// Get the value under the lubberline and return it as a string.
        /// </summary>
        /// <param name="valueToreturn"></param>
        /// <returns>Parameter value to return</returns>
        private double lubberLineValueToReturn(string valueToreturn)
        {
            double val = 0;
            Point po = this.PointToClient(Cursor.Position);

            iPos = getCsvPosition();

            if (iPos > CSV.Rows.Count - 10 || iPos < 10)
            {
                return val;
            }

            if (CSV.Columns.Contains(valueToreturn))
            {
                double.TryParse(CSV.Rows[iPos][valueToreturn].ToString(), out val);
                return val;
            }

            return val;
        }
        /// <summary>
        /// Return the value of the representing the row position of the underlying csv database to the cursor on the graph.
        /// </summary>
        /// <returns>Int relating to the csv data row position relating to the graph cursor position.</returns>
        private int getCsvPosition()
        {
            int pos = 0;

            pos = Convert.ToInt32((Cursor.Position.X / scale) + drawStartPos);

            return pos;
        }
        
    }

    public class TekenWaardes : IComparable<TekenWaardes>
    {
        public Color waardeKleur { get; set; }
        public string waardeNaam { get; set; }
        public int tekenPosiesie { get; set; }
        public string waardeOmTeKsryf { get; set; }

        public int CompareTo(TekenWaardes other)
        {
            return this.tekenPosiesie.CompareTo(other.tekenPosiesie);
        }
    }

}





