using FOQAData;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOQA
{
    /// <summary>
    /// Summary description for frmGraph.
    /// </summary>
    public class graphDedicated : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ImageList imgListTB;
        private System.Windows.Forms.StatusBar stbGraph;
        private System.Windows.Forms.StatusBarPanel stpCounter;
        private System.Windows.Forms.StatusBarPanel stpExc;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.HScrollBar schGraphPos;
        private SaveFileDialog saveFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mFileSave;
        private StatusBarPanel sbpNote;
        private ToolStrip tsMain;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem approachMarkers;
        private Bitmap bitmapPlot;
        private Bitmap sketsSkaal;
        private StatusBarPanel FlightNumber;
        private StatusBarPanel Date;
        private ToolStripMenuItem createKMLFileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem CalculateDistanceToolStripMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem setStartCounterToolStripMenuItem;
        private StatusBarPanel Message;
        private ToolStripMenuItem setEndCounterToolStripMenuItem;
        private ToolStripMenuItem createKMLToolStripMenuItem;
        private ToolStripMenuItem showDistanceResultsToolStripMenuItem;
        private ToolStripMenuItem CalculateFuelBurned;
        private ToolStripMenuItem positionToolStripMenuItem;
        private ToolStripMenuItem savePositionToolStripMenuItem;
        private ToolStripMenuItem touchdownToolStripMenuItem;
        private ToolStripMenuItem turnoffToolStripMenuItem;

        private System.Windows.Forms.TrackBar trkScaleH;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem gotoToolStripMenuItem;
        private ToolStripMenuItem nextLandingToolStripMenuItem;
        private ToolStripMenuItem verticalTopToolStripMenuItem;
        private ToolStripMenuItem topFlapTePositionLeftToolStripMenuItem;
        private ToolStripMenuItem topN1ToolStripMenuItem;
        private ToolStripMenuItem topRadioAltitudeToolStripMenuItem;
        private ToolStripMenuItem topAirGroundToolStripMenuItem;
        private ToolStripMenuItem topIndividualGearAirGroundToolStripMenuItem;
        private ToolStripMenuItem topTouchDownLiftOffToolStripMenuItem;
        private ToolStripMenuItem placeTextToolStripMenuItem;
        private ToolStripTextBox placeTextToolStripTextBox;
        private ToolStripMenuItem noteCoulorToolStripMenuItem;
        private ToolStripTextBox noteTextToolStripTextBox;
        private ColorDialog colorDialog;
        private Panel pnlGraph;
        private TextBox tLatAndLong;
        private Label lblAP;
        private Label lblTAT;
        private Label lblWeightVal;
        private CDI.LineControl.Line line18;
        private CDI.LineControl.Line line19;

        public graphDedicated()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graphDedicated));
            this.trkScaleH = new System.Windows.Forms.TrackBar();
            this.imgListTB = new System.Windows.Forms.ImageList(this.components);
            this.stbGraph = new System.Windows.Forms.StatusBar();
            this.stpCounter = new System.Windows.Forms.StatusBarPanel();
            this.stpExc = new System.Windows.Forms.StatusBarPanel();
            this.sbpNote = new System.Windows.Forms.StatusBarPanel();
            this.FlightNumber = new System.Windows.Forms.StatusBarPanel();
            this.Date = new System.Windows.Forms.StatusBarPanel();
            this.Message = new System.Windows.Forms.StatusBarPanel();
            this.schGraphPos = new System.Windows.Forms.HScrollBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.createKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approachMarkers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateDistanceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createKMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDistanceResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateFuelBurned = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteCoulorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.topAirGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topIndividualGearAirGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTouchDownLiftOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRadioAltitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topN1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topFlapTePositionLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setStartCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEndCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touchdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.tLatAndLong = new System.Windows.Forms.TextBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblTAT = new System.Windows.Forms.Label();
            this.lblWeightVal = new System.Windows.Forms.Label();
            this.line18 = new CDI.LineControl.Line();
            this.line19 = new CDI.LineControl.Line();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpExc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Message)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkScaleH
            // 
            this.trkScaleH.AutoSize = false;
            this.trkScaleH.BackColor = System.Drawing.SystemColors.Control;
            this.trkScaleH.LargeChange = 2;
            this.trkScaleH.Location = new System.Drawing.Point(1001, 27);
            this.trkScaleH.Maximum = 80;
            this.trkScaleH.Minimum = 1;
            this.trkScaleH.Name = "trkScaleH";
            this.trkScaleH.Size = new System.Drawing.Size(128, 27);
            this.trkScaleH.SmallChange = 2;
            this.trkScaleH.TabIndex = 90;
            this.trkScaleH.TickFrequency = 2;
            this.trkScaleH.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkScaleH.Value = 50;
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
            // stbGraph
            // 
            this.stbGraph.Location = new System.Drawing.Point(0, 728);
            this.stbGraph.Name = "stbGraph";
            this.stbGraph.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.stpCounter,
            this.stpExc,
            this.sbpNote,
            this.FlightNumber,
            this.Date,
            this.Message});
            this.stbGraph.ShowPanels = true;
            this.stbGraph.Size = new System.Drawing.Size(1495, 25);
            this.stbGraph.TabIndex = 74;
            // 
            // stpCounter
            // 
            this.stpCounter.Name = "stpCounter";
            this.stpCounter.Text = "Counter";
            // 
            // stpExc
            // 
            this.stpExc.Name = "stpExc";
            this.stpExc.Text = "Exc";
            this.stpExc.Width = 300;
            // 
            // sbpNote
            // 
            this.sbpNote.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbpNote.Name = "sbpNote";
            this.sbpNote.Text = "Desc";
            this.sbpNote.Width = 40;
            // 
            // FlightNumber
            // 
            this.FlightNumber.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.FlightNumber.MinWidth = 1;
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Text = "FlightNumber";
            this.FlightNumber.Width = 82;
            // 
            // Date
            // 
            this.Date.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.Date.MinWidth = 1;
            this.Date.Name = "Date";
            this.Date.Text = "No Date";
            this.Date.Width = 56;
            // 
            // Message
            // 
            this.Message.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Message.Name = "Message";
            this.Message.ToolTipText = "The selected counter positions.";
            this.Message.Width = 900;
            // 
            // schGraphPos
            // 
            this.schGraphPos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.schGraphPos.LargeChange = 101;
            this.schGraphPos.Location = new System.Drawing.Point(729, 27);
            this.schGraphPos.Name = "schGraphPos";
            this.schGraphPos.Size = new System.Drawing.Size(269, 20);
            this.schGraphPos.SmallChange = 101;
            this.schGraphPos.TabIndex = 1;
            this.schGraphPos.TabStop = true;
            this.schGraphPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.schGraphPos_Scroll);
            this.schGraphPos.ValueChanged += new System.EventHandler(this.schGraphPos_ValueChanged);
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
            this.approachMarkers,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 24);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileSave,
            this.createKMLFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mFileSave
            // 
            this.mFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mFileSave.Image")));
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.Size = new System.Drawing.Size(154, 22);
            this.mFileSave.Text = "&Save";
            this.mFileSave.ToolTipText = "Save an image of the graph.";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // createKMLFileToolStripMenuItem
            // 
            this.createKMLFileToolStripMenuItem.Name = "createKMLFileToolStripMenuItem";
            this.createKMLFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createKMLFileToolStripMenuItem.Text = "Create KML file";
            this.createKMLFileToolStripMenuItem.ToolTipText = "Create a file you can view in google earth.";
            this.createKMLFileToolStripMenuItem.Click += new System.EventHandler(this.createKMLFileToolStripMenuItem_Click);
            // 
            // approachMarkers
            // 
            this.approachMarkers.Name = "approachMarkers";
            this.approachMarkers.Size = new System.Drawing.Size(48, 20);
            this.approachMarkers.Text = "Show";
            this.approachMarkers.ToolTipText = "Shown after the alt value in [] brackets.";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateDistanceToolStripMenu,
            this.createKMLToolStripMenuItem,
            this.showDistanceResultsToolStripMenuItem,
            this.CalculateFuelBurned,
            this.gotoToolStripMenuItem,
            this.noteCoulorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.ToolTipText = "Calculate distance between two caounter positions.";
            // 
            // CalculateDistanceToolStripMenu
            // 
            this.CalculateDistanceToolStripMenu.Name = "CalculateDistanceToolStripMenu";
            this.CalculateDistanceToolStripMenu.Size = new System.Drawing.Size(191, 22);
            this.CalculateDistanceToolStripMenu.Text = "Calculate Distance";
            this.CalculateDistanceToolStripMenu.Click += new System.EventHandler(this.CalculateDistanceToolStripMenu_Click);
            // 
            // createKMLToolStripMenuItem
            // 
            this.createKMLToolStripMenuItem.Name = "createKMLToolStripMenuItem";
            this.createKMLToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.createKMLToolStripMenuItem.Text = "Create KML";
            this.createKMLToolStripMenuItem.ToolTipText = "Create a file to view in Google Earth.";
            this.createKMLToolStripMenuItem.Click += new System.EventHandler(this.createKMLToolStripMenuItem_Click);
            // 
            // showDistanceResultsToolStripMenuItem
            // 
            this.showDistanceResultsToolStripMenuItem.Name = "showDistanceResultsToolStripMenuItem";
            this.showDistanceResultsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showDistanceResultsToolStripMenuItem.Text = "Show Distance results.";
            this.showDistanceResultsToolStripMenuItem.Click += new System.EventHandler(this.showDistanceResultsToolStripMenuItem_Click);
            // 
            // CalculateFuelBurned
            // 
            this.CalculateFuelBurned.Name = "CalculateFuelBurned";
            this.CalculateFuelBurned.Size = new System.Drawing.Size(191, 22);
            this.CalculateFuelBurned.Text = "Calculate Fuel";
            this.CalculateFuelBurned.ToolTipText = "Calculate the fuel burned between selected points.";
            this.CalculateFuelBurned.Click += new System.EventHandler(this.CalculateFuelBurned_Click);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextLandingToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // nextLandingToolStripMenuItem
            // 
            this.nextLandingToolStripMenuItem.Name = "nextLandingToolStripMenuItem";
            this.nextLandingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.nextLandingToolStripMenuItem.Text = "Next &Landing";
            this.nextLandingToolStripMenuItem.Click += new System.EventHandler(this.nextLandingToolStripMenuItem_Click);
            // 
            // noteCoulorToolStripMenuItem
            // 
            this.noteCoulorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteTextToolStripTextBox});
            this.noteCoulorToolStripMenuItem.Name = "noteCoulorToolStripMenuItem";
            this.noteCoulorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.noteCoulorToolStripMenuItem.Text = "Note Color";
            this.noteCoulorToolStripMenuItem.Click += new System.EventHandler(this.noteCoulorToolStripMenuItem_Click);
            // 
            // noteTextToolStripTextBox
            // 
            this.noteTextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noteTextToolStripTextBox.Name = "noteTextToolStripTextBox";
            this.noteTextToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // topAirGroundToolStripMenuItem
            // 
            this.topAirGroundToolStripMenuItem.Name = "topAirGroundToolStripMenuItem";
            this.topAirGroundToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topIndividualGearAirGroundToolStripMenuItem
            // 
            this.topIndividualGearAirGroundToolStripMenuItem.Name = "topIndividualGearAirGroundToolStripMenuItem";
            this.topIndividualGearAirGroundToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topTouchDownLiftOffToolStripMenuItem
            // 
            this.topTouchDownLiftOffToolStripMenuItem.Name = "topTouchDownLiftOffToolStripMenuItem";
            this.topTouchDownLiftOffToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topRadioAltitudeToolStripMenuItem
            // 
            this.topRadioAltitudeToolStripMenuItem.Name = "topRadioAltitudeToolStripMenuItem";
            this.topRadioAltitudeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topN1ToolStripMenuItem
            // 
            this.topN1ToolStripMenuItem.Name = "topN1ToolStripMenuItem";
            this.topN1ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topFlapTePositionLeftToolStripMenuItem
            // 
            this.topFlapTePositionLeftToolStripMenuItem.CheckOnClick = true;
            this.topFlapTePositionLeftToolStripMenuItem.Name = "topFlapTePositionLeftToolStripMenuItem";
            this.topFlapTePositionLeftToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.topFlapTePositionLeftToolStripMenuItem.Text = "Top";
            this.topFlapTePositionLeftToolStripMenuItem.Click += new System.EventHandler(this.chtTopToolStripMenuItem_Click);
            // 
            // verticalTopToolStripMenuItem
            // 
            this.verticalTopToolStripMenuItem.CheckOnClick = true;
            this.verticalTopToolStripMenuItem.Name = "verticalTopToolStripMenuItem";
            this.verticalTopToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.verticalTopToolStripMenuItem.Text = "Top";
            this.verticalTopToolStripMenuItem.Click += new System.EventHandler(this.chtTopToolStripMenuItem_Click);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 92);
            // 
            // setStartCounterToolStripMenuItem
            // 
            this.setStartCounterToolStripMenuItem.Name = "setStartCounterToolStripMenuItem";
            this.setStartCounterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.setStartCounterToolStripMenuItem.Text = "Set Start Counter";
            this.setStartCounterToolStripMenuItem.Click += new System.EventHandler(this.setStartCounterToolStripMenuItem_Click);
            // 
            // setEndCounterToolStripMenuItem
            // 
            this.setEndCounterToolStripMenuItem.Name = "setEndCounterToolStripMenuItem";
            this.setEndCounterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
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
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.positionToolStripMenuItem.Text = "Touchdown";
            // 
            // savePositionToolStripMenuItem
            // 
            this.savePositionToolStripMenuItem.Name = "savePositionToolStripMenuItem";
            this.savePositionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.savePositionToolStripMenuItem.Text = "Flare";
            this.savePositionToolStripMenuItem.Click += new System.EventHandler(this.savePositionToolStripMenuItem_Click);
            // 
            // touchdownToolStripMenuItem
            // 
            this.touchdownToolStripMenuItem.Name = "touchdownToolStripMenuItem";
            this.touchdownToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.touchdownToolStripMenuItem.Text = "Touchdown";
            // 
            // turnoffToolStripMenuItem
            // 
            this.turnoffToolStripMenuItem.Name = "turnoffToolStripMenuItem";
            this.turnoffToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.turnoffToolStripMenuItem.Text = "Turnoff";
            // 
            // placeTextToolStripMenuItem
            // 
            this.placeTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeTextToolStripTextBox});
            this.placeTextToolStripMenuItem.Name = "placeTextToolStripMenuItem";
            this.placeTextToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.placeTextToolStripMenuItem.Text = "Place Text";
            // 
            // placeTextToolStripTextBox
            // 
            this.placeTextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.placeTextToolStripTextBox.Name = "placeTextToolStripTextBox";
            this.placeTextToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1495, 30);
            this.tsMain.TabIndex = 12454;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlGraph, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1495, 668);
            this.tableLayoutPanel1.TabIndex = 12455;
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlGraph.Controls.Add(this.tLatAndLong);
            this.pnlGraph.Controls.Add(this.lblAP);
            this.pnlGraph.Controls.Add(this.lblTAT);
            this.pnlGraph.Controls.Add(this.lblWeightVal);
            this.pnlGraph.Controls.Add(this.line18);
            this.pnlGraph.Controls.Add(this.line19);
            this.pnlGraph.ForeColor = System.Drawing.Color.Black;
            this.pnlGraph.Location = new System.Drawing.Point(3, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1489, 662);
            this.pnlGraph.TabIndex = 62;
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            // 
            // tLatAndLong
            // 
            this.tLatAndLong.Location = new System.Drawing.Point(72, 7);
            this.tLatAndLong.Name = "tLatAndLong";
            this.tLatAndLong.Size = new System.Drawing.Size(306, 20);
            this.tLatAndLong.TabIndex = 12456;
            this.tLatAndLong.Visible = false;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(8, 280);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(0, 14);
            this.lblAP.TabIndex = 12452;
            // 
            // lblTAT
            // 
            this.lblTAT.AutoSize = true;
            this.lblTAT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAT.Location = new System.Drawing.Point(6, 10);
            this.lblTAT.Name = "lblTAT";
            this.lblTAT.Size = new System.Drawing.Size(51, 14);
            this.lblTAT.TabIndex = 12450;
            this.lblTAT.Text = "TAT 39.9";
            this.lblTAT.Visible = false;
            // 
            // lblWeightVal
            // 
            this.lblWeightVal.AutoSize = true;
            this.lblWeightVal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightVal.Location = new System.Drawing.Point(6, 28);
            this.lblWeightVal.Name = "lblWeightVal";
            this.lblWeightVal.Size = new System.Drawing.Size(58, 14);
            this.lblWeightVal.TabIndex = 12449;
            this.lblWeightVal.Text = "GW 60000";
            this.lblWeightVal.Visible = false;
            // 
            // line18
            // 
            this.line18.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.line18.LineColor1 = System.Drawing.Color.Black;
            this.line18.LineColor2 = System.Drawing.Color.Black;
            this.line18.Location = new System.Drawing.Point(0, 671);
            this.line18.Name = "line18";
            this.line18.Size = new System.Drawing.Size(3000, 1);
            this.line18.TabIndex = 36;
            this.line18.Visible = false;
            // 
            // line19
            // 
            this.line19.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.line19.LineColor1 = System.Drawing.Color.Black;
            this.line19.LineColor2 = System.Drawing.Color.Black;
            this.line19.LineDirection = CDI.LineControl.LineDirections.Vertical;
            this.line19.Location = new System.Drawing.Point(41, 0);
            this.line19.Name = "line19";
            this.line19.Size = new System.Drawing.Size(1, 1000);
            this.line19.TabIndex = 65;
            // 
            // graphDedicated
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1495, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.trkScaleH);
            this.Controls.Add(this.schGraphPos);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stbGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "graphDedicated";
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraph_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.graphDedicated_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGraph_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpExc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Message)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public int excCounterPosition = 0;
        public int eventCounter;
        public DataTable CSV = new DataTable();

        public static int ExcPosition, drawStartPos, iCount = 0;

        public double startPos;
        //private static double dFrac = 0;
        private static int CSVRowCount = 0;
        private static float bottomVal = 0;
        private static float topVal = 0;
        private static float constant = 0;
        private static Color noteColor = Color.Black;
        private bool kiesLysGeStel = false;
        private Grafiek[] grafiek = new Grafiek[5];
        private TekenWaardes[] tekenWaardes = new TekenWaardes[10];

        private void pnlGraph_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            line19.Location = new Point(MousePosition.X - (ActiveForm.Left + 11), 0);
           
            pnlGraph.CreateGraphics().DrawImage(bitmapPlot, 0, 0, pnlGraph.Width, pnlGraph.Height);
        }
        private void addWarningsToolDropDownItems()
        {// die is geerf en gaan nie meer gebruik word nie.
            ToolStripMenuItem[] mi = new ToolStripMenuItem[csv.Warnings.Count];

            for (int i = 0; i < mi.Length; i++)
            {
                mi[i] = new ToolStripMenuItem();
                mi[i].Name = csv.Warnings[i];
                mi[i].CheckOnClick = true;
                mi[i].Text = csv.Warnings[i]; ;
                //mi[i].Click += new EventHandler(warningMenuItem_Click);
            }

            if (!kiesLysGeStel)
            {
                kiesLysGeStel = true;
            }

        }
        private void addedMenuItemsClickEventHandler(object sender, EventArgs e)
        {

        }
        private class secondValues
        {
            public static double DME = 0;
            public static double[] windspeed = new double[] { 0, 0 };
            public static double radioAlt = 0;
        }
        private void pnlGraph_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WriteVal();
                pnlGraph.CreateGraphics().DrawImage(bitmapPlot, 0, 0, pnlGraph.Width, pnlGraph.Height);
                
            }
        }
        private void WriteVal()
        {
       
            float fHeight = pnlGraph.Height;

            Point p = this.PointToClient(Cursor.Position);

            line19.Location = new Point(p.X - 3, 0); // x was minus 3

        }
       
        private void frmGraph_Load(object sender, EventArgs e)
        {

            Bitmap temp = new Bitmap(pnlGraph.Width, pnlGraph.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bitmapPlot = temp;
            sketsSkaal = temp;
            
            line19.Height = ClientSize.Height;

            stelTekenWaardes();
            stelAanskuifSpasie();
            tekenSkaal();
            plaasKnopies();
            sketsWaardes();
            ShowBM();

        }
        private void gotoCounter(int counter)
        {
            //double exPos = 0;

            for (int i = 0; i < CSVRowCount; i++)
            {
                double.TryParse(CSV.Rows[i][csv.counter].ToString(), out double exPos);

                if (exPos == counter)
                {
                    schGraphPos.Value = i;
                    break;
                }
                else if (exPos > counter)
                {
                    break;
                }
            }
        }
        private void sketsWaardes()
        {
           
            double[,] wind = new double[2, 2];
            double[] radioAlt = new double[2];
            double[] DME = new double[2];

            int[] iAP = new int[] { 0, 0, 0, 0 };

            float[] glideSlope = new float[2];


            Graphics g;
            bitmapPlot = sketsSkaal;
            
            g = Graphics.FromImage(bitmapPlot);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            
            float.TryParse("1.5", out float f);

            for (int t = 0; t < tekenWaardes.Length - 1; t++)
            {
                if (tekenWaardes[t] != null && tekenWaardes[t].teken)
                {
                    Pen lpen = new Pen(tekenWaardes[t].kleur,f);
                    SolidBrush borsel = new SolidBrush(tekenWaardes[t].kleur);

                    if (CSV.Rows.Count > 0)
                    {// teken die grafiek, as daar nie CSV gelaai is nie teken net lyne vir toets.
                        // kry die onder punt van die grafiek en die skaal
                        kryDieOnderPuntMinW(t, tekenWaardes[t].grafiekOmOpTePlot, out float onderPunt, out double waardeVermenigvuldig);

                        int gr = tekenWaardes[t].grafiekOmOpTePlot - 1;
                        double[] w = new double[2];
                        double[] y = new double[2];
                        float[] yToT = new float[2];
                        int begin = 100;
                        double z = ((bitmapPlot.Width - (GrafiekKonstantes.beginBietjie + 20)) / GrafiekKonstantes.aanSkuifSpasie);

                        int.TryParse(z.ToString(), out int spasies);
                        // teken die waardes van die veskillende grafieke op hulle skaal lyne hier
                        double d = (tekenWaardes[t].maxW - tekenWaardes[t].minW) / (grafiek[gr].lyne - 1);
                        double skryfW = 0;

                        for (int i = 0; i < grafiek[gr].lyne; i ++)
                        {
                            if (i == 0)
                            {
                                y[0] = onderPunt;// + ((tekenWaardes[t].minW) * waardeVermenigvuldig);
                                skryfW = tekenWaardes[t].minW;
                            }
                            else
                            {
                                y[0] = onderPunt + (((i * d) - tekenWaardes[t].minW) * waardeVermenigvuldig);
                                skryfW = Math.Round((d * i),2);
                            }
                            float.TryParse((bitmapPlot.Height - (y[0] + 5)).ToString(), out yToT[0]);
                            g.DrawString(skryfW.ToString(), SystemFonts.DefaultFont, borsel, 5, yToT[0]);

                        }

                        //hier teken ons die waarde plots.
                        for (int i = begin; i < CSV.Rows.Count -10 ; i++) // om by te sit, off as ons by die einde kom.
                        {
                            if (i - begin > z)
                            {
                                break; ;
                            }

                            double.TryParse(CSV.Rows[i][tekenWaardes[t].parameterKomaNaam].ToString(), out w[0]);
                            double.TryParse(CSV.Rows[i + 1][tekenWaardes[t].parameterKomaNaam].ToString(), out w[1]);
                            
                            //y[0] = onderPunt + ((w[0] - grafiek[gr].minW) * waardeVermenigvuldig);
                            //y[1] = onderPunt + ((w[1] - grafiek[gr].minW) * waardeVermenigvuldig);

                            y[0] = onderPunt + ((w[0] - tekenWaardes[t].minW) * waardeVermenigvuldig);
                            y[1] = onderPunt + ((w[1] - tekenWaardes[t].minW) * waardeVermenigvuldig);

                            double b = bitmapPlot.Height;

                            float.TryParse((b - y[0]).ToString(), out  yToT[0]);
                            float.TryParse((b - y[1]).ToString(), out  yToT[1]);

                            g.DrawLine(lpen, GrafiekKonstantes.beginBietjie + (GrafiekKonstantes.aanSkuifSpasie * (i - begin)), yToT[0]
                                , GrafiekKonstantes.beginBietjie + (GrafiekKonstantes.aanSkuifSpasie * ((i - begin) + 1)), yToT[1]);

                        }
                    }
                    else
                    {
                        kryDieOnderPuntMinW(t,tekenWaardes[t].grafiekOmOpTePlot, out float onderPunt, out double y);
                        if (t == 0)
                        {
                            

                        }
                        if (t == 1)
                        {
                            int gr = tekenWaardes[t].grafiekOmOpTePlot - 1;
                            double h = 500;
                            //double p = onderPunt + ((h - grafiek[gr].minW) * y);// die een het gewerk met die vorige plot skaal min max waardes.
                            double p = onderPunt + ((h - tekenWaardes[t].minW) * y);
                            double b = bitmapPlot.Height;
                            float.TryParse((b - p).ToString(), out float ft);

                            g.DrawLine(lpen, GrafiekKonstantes.beginBietjie, ft, bitmapPlot.Width, bitmapPlot.Height);

                        }
                        else if (t > 1)
                        {
                            g.DrawLine(lpen, GrafiekKonstantes.beginBietjie, bitmapPlot.Height - onderPunt, bitmapPlot.Width, bitmapPlot.Height);
                        }

                    }
                }
            }
        }
        private void tekenSkaal()
        {
            int h1 = 0, h2;
            float fy;
            string sValue = "0";

            Cursor.Current = Cursors.WaitCursor;

            Graphics g;
            g = Graphics.FromImage(sketsSkaal);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            float.TryParse(((pnlGraph.Height - GrafiekKonstantes.ondersteBietjie) * 0.03).ToString(), out GrafiekKonstantes.spasie);

            grafiek[0] = new Grafiek()
            {
                kerW = 1000,
                minW = -1000,
                maksW = 10000,
                lyne = 13
            };

            grafiek[1] = new Grafiek()
            {
                kerW = 50,
                minW = 0,
                maksW = 500,
                lyne = 11
            };
            
            grafiek[2] = new Grafiek()
            {
                kerW = 1,
                minW = -2,
                maksW = 2,
                lyne = 5
            };

            grafiek[3] = new Grafiek()
            {
                kerW = 50,
                minW = 0,
                maksW = 100,
                lyne = 3
            };

            grafiek[4] = new Grafiek()
            {
                kerW = 1,
                minW = 0,
                maksW = 1,
                lyne = 2
            };

            try
            {
                Pen lpen = new Pen(Color.LightGray, 1);
                g.Clear(Color.White);

                h1 = 35;
                h2 = pnlGraph.Width - 35;
                fy = pnlGraph.Height - GrafiekKonstantes.ondersteBietjie;

                for (int y = 0; y < grafiek.Length ; y++)
                {
                    double tekenW = grafiek[y].minW;
                    
                    for (int i = 0; i < grafiek[y].lyne; i++)
                    {
                        sValue = tekenW.ToString();
                        g.DrawLine(lpen, h1, fy, h2, fy);
                        //g.DrawString(sValue, SystemFonts.DefaultFont, new SolidBrush(Color.Black), 0, fy - 7); uit gehaal, gaan dit liewer by die grfiek waardes teken.
                        fy -= GrafiekKonstantes.spasie;
                        tekenW += grafiek[y].kerW;
                    }
                    fy -= GrafiekKonstantes.spasie / 2;
                }

                //pnlGraph.CreateGraphics().DrawImage(bitmapPlot, 0, 0, pnlGraph.Width, pnlGraph.Height); Hoef hom nie hier te teken nie, gaan onder teken gewys word.

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), " Paint Line", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Arrow;
            }
            finally
            {
                g.Dispose();
            }
            Cursor.Current = Cursors.Arrow;

        }

        private void stelAanskuifSpasie()
        {
            double d = (bitmapPlot.Width - GrafiekKonstantes.beginBietjie) / GrafiekKonstantes.skaal;
            float.TryParse(d.ToString(), out GrafiekKonstantes.aanSkuifSpasie);
        }
        private void kryDieOnderPuntMinW(int t, int grafiekNo, out float onderPlotPunt, out double waardeVermeenigvuldig)
        {
            double onderWaarde = 0;
            waardeVermeenigvuldig = 0;
            onderPlotPunt = 0;
            //aanBeweeg = 0;

            if (grafiekNo < grafiek.Length)
            {
                if (grafiekNo == 1)
                {
                    onderWaarde = GrafiekKonstantes.ondersteBietjie;
                }
                else
                {
                    int lyne = 0;
                    for (int i = 0; i < grafiekNo - 1; i++)
                    {
                        lyne += grafiek[i].lyne;
                    }
                    onderWaarde = GrafiekKonstantes.ondersteBietjie + ((grafiekNo - 1) * (GrafiekKonstantes.spasie * 0.5) + (lyne * GrafiekKonstantes.spasie));
                }
                float.TryParse(onderWaarde.ToString(), out onderPlotPunt);

               // waardeVermeenigvuldig = GrafiekKonstantes.spasie / grafiek[grafiekNo - 1].kerW; //die een werk as ek met die grafiek miax waardes werk.
                waardeVermeenigvuldig = GrafiekKonstantes.spasie / ((tekenWaardes[t].maxW - tekenWaardes[t].minW) / (grafiek[grafiekNo - 1].lyne - 1));
            }
        }
        private void drawLubberLine()
        {// Draw the lubbe line for printing
         //float fY = 0, fX = 0;
         //int iPos = 0,iValue = 0;
         //double dValue = 0;

            //fX = (float)(line19.Location.X);
            //fY = (float)(pnlGraph.ClientSize.Height);

            //Graphics g;
            //g = Graphics.FromImage(bmGraph);

            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            //Pen gPen = new Pen(Color.Black);
            //gPen.Width = 1;
            //SolidBrush sBrush = new SolidBrush(Color.Black);
            //Font fnt = new Font("Arial", 8);

            ////line19.Location = new System.Drawing.Point(MousePosition.X, 0);
            //iPos = ((int)fX / trkScaleH.Value) + iStartPos;

            //try
            //{
            //    g.DrawLine(gPen,fX, 0, fX, fY);

            //    iValue = (int)(CSV.Rows[iPos][csv.altitudeP]);
            //    sBrush.Color = Color.Blue;
            //    //Code inserted to draw the alt above referance
            //    g.DrawString(iValue.ToString() + " [" + (iValue - Tools.touchDownAltitude) + "]" , fnt, sBrush, fX, (int)(fY - ((fY * 0.044f)+((fY * 0.036f) * (iValue / 500)))));

            //    if (tsbVerticalSpeed.Checked)
            //    {
            //    iValue = (int)(((int)(CSV.Rows[iPos][csv.altitudeP]) - (int)(CSV.Rows[iPos-6][csv.altitudeP]))*10);
            //    sBrush.Color= Color.Green;
            //    g.DrawString(iValue.ToString() ,fnt,sBrush,fX,
            //        (int)(fY - (((fY * 0.032f) * 8) +((fY * 0.036f) * (iValue / 500)))));
            //    }

            //    if (tsbFlap.Checked)
            //    {
            //        dValue = Convert.ToDouble(CSV.Rows[iPos][csv.flapTE]);
            //        sBrush.Color = Color.DeepSkyBlue;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX, (int)(fY - ((fY * 0.036f) + ((fY * 0.036f) * ((float)(dValue) / 5)))));
            //    }

            //    if (tsbRadioAlt.Checked)
            //    {

            //        iValue = (int)(CSV.Rows[iPos][csv.altitudeR]);
            //        sBrush.Color = Color.Purple;
            //        g.DrawString(iValue.ToString(), fnt, sBrush, fX - 30,
            //            (int)(fY - ((fY * 0.044f) + ((fY * 0.036f) * (iValue / 500)))));
            //    }

            //    if (tsbHDG.Checked)
            //    {
            //        //dValue = (double)(CSV.Rows[iPos][csv.heading]);
            //        double.TryParse(CSV.Rows[iPos][csv.heading].ToString(), out dValue);
            //        sBrush.Color = Color.DeepPink;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(dValue) / 50)))));
            //    }

            //    if (tsbCAS.Checked)
            //    {
            //        int.TryParse(CSV.Rows[iPos][csv.speedCAS].ToString(), out iValue);
            //        sBrush.Color = Color.DarkViolet;
            //        g.DrawString(iValue.ToString(), fnt, sBrush, fX, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(iValue) / 50)))));
            //    }

            //    //if (groundSpeedToolStripMenuItem.Checked)
            //    //{
            //    //    iValue = (int)(CSV.Rows[iPos][csv.speedGround]);
            //    //    sBrush.Color = Color.Black;
            //    //    g.DrawString(iValue.ToString(), fnt, sBrush, fX, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(iValue) / 50))))-25);
            //    //}

            //    if (tsbN1.Checked)
            //    {
            //        if (CSV.Columns.Contains(csv.eng1N1))
            //        {
            //            dValue = (double)(CSV.Rows[iPos][csv.eng1N1]);
            //            sBrush.Color = Color.Brown;
            //            g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(dValue) / 50)))));

            //            dValue = (double)(CSV.Rows[iPos][csv.eng2N1]);
            //            sBrush.Color = Color.Chocolate;
            //            g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + 15 + ((fY * 0.036f) * ((float)(dValue) / 50)))));
            //        }
            //        else if (CSV.Columns.Contains("ENG1torque"))
            //        {
            //            dValue = (double)(CSV.Rows[iPos]["ENG1torque"]);
            //            sBrush.Color = Color.Brown;
            //            g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(dValue) / 50)))));

            //            dValue = (double)(CSV.Rows[iPos]["ENG1torque"]);
            //            sBrush.Color = Color.Chocolate;
            //            g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + 15 + ((fY * 0.036f) * ((float)(dValue) / 50)))));
            //        }
            //    }

            //    if (n2ToolStripMenuItem.Checked)
            //    {

            //        dValue = (double)(CSV.Rows[iPos][csv.eng1N2]);
            //        sBrush.Color = Color.Green;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(dValue) / 50)))));

            //        dValue = (double)(CSV.Rows[iPos][csv.eng2N2]);
            //        sBrush.Color = Color.LightGreen;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + 15 + ((fY * 0.036f) * ((float)(dValue) / 50)))));

            //    }

            //    if (tsbDME.Checked)
            //    {
            //        double.TryParse(CSV.Rows[iPos][csv.DMEleft].ToString(),out dValue);
            //        sBrush.Color = Color.Black;
            //        g.DrawString(iValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - ((fY * 0.67f) + ((fY * 0.036f) * ((float)(iValue) / 5)))));

            //    }

            //    if (tsbACC.Checked)
            //    {
            //        dValue = (double)(CSV.Rows[iPos]["ACCvert"]);
            //        sBrush.Color = Color.LimeGreen;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - (((fY * 0.67f) + (fY * 0.036f) * 5) + ((fY * 0.036f) * ((float)(dValue) / 50)))));
            //    }

            //    if (tsbPitch.Checked)
            //    {
            //        dValue = (double)(CSV.Rows[iPos][csv.attitudePitch]);
            //        sBrush.Color = Color.Red;
            //        g.DrawString(dValue.ToString(), fnt, sBrush, fX - 30, (int)(fY - (((fY * 0.67f) + (fY * 0.036f) * 5) + ((fY * 0.036f) * ((float)(dValue) / 50)))));
            //    }

            //    string sInfo = "";

            //    if (tsbWind.Checked)
            //    {
            //        sInfo += " [Wind " + System.Convert.ToString(CSV.Rows[iPos][csv.windDir]) + "/" +
            //            System.Convert.ToString(CSV.Rows[iPos][csv.windVel]) + "] ";
            //    }

            //    if (tsbWeight.Checked)
            //    {
            //       sInfo  += " [GW " + System.Convert.ToString(CSV.Rows[iPos][csv.grossWeight]) + "] ";
            //    }

            //    if (tsbTat.Checked)
            //    {
            //        sInfo  += " [TAT " + System.Convert.ToString(CSV.Rows[iPos][csv.TAT])+ "] ";
            //    }
            //    sBrush.Color = Color.Black;
            //    g.DrawString(sInfo, fnt, sBrush, 100, fY * 0.055f);

            //    if (tsDate.Checked)
            //    {
            //        sInfo = "File " + FOQAData.csv.csvFileName +
            //          " | ExcID " + FOQAData.csv.sExcID +
            //          " | Exc " + FOQAData.csv.sExceedance + 
            //          " | Date " + FOQAData.csv.dtEXCDate.ToString("dd MMM yyyy");
            //        g.DrawString(sInfo, fnt, sBrush, 100, 5);

            //        sInfo = "Count : " + FOQAData.csv.sEXCcounter +
            //            " | Note : " + FOQAData.csv.sEXCnote;
            //        g.DrawString(sInfo, fnt, sBrush, 100, 15);
            //    }
            //    else
            //    {

            //        sInfo = "File " + FOQAData.csv.csvFileName +
            //          " | ExcID " + FOQAData.csv.sExcID +
            //          " | Exc " + FOQAData.csv.sExceedance;
            //        g.DrawString(sInfo, fnt, sBrush, 100, 5);

            //        sInfo = "Count : " + FOQAData.csv.sEXCcounter +
            //            " | Note : " + FOQAData.csv.sEXCnote;
            //        g.DrawString(sInfo, fnt, sBrush, 100, 15);
            //    }

            //}
            //catch 
            //{ }
            //finally
            //{
            //    g.Dispose();
            //}

        }
        private void Save_Graph()
        {
            Cursor.Current = Cursors.WaitCursor;
            string sPath = Application.StartupPath;

            try
            {
                if (bitmapPlot != null)
                {
                    drawLubberLine();

                    saveFileDialog.InitialDirectory = "C:\\";
                    saveFileDialog.FileName = FOQAData.csv.csvFileName + "-" + FOQAData.csv.sExcID;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bitmapPlot.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Done saving file.", FOQAData.sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File not saved!", FOQAData.sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There is noting to save.", FOQAData.sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.ToString(), FOQAData.sMessages.sMessageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sketsWaardes();
                Cursor.Current = Cursors.Default;
            }
        }
        private void schGraphPos_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                StatusBar();
                sketsWaardes();
                ShowBM();
            }
        }
        private void schGraphPos_ValueChanged(object sender, System.EventArgs e)
        {

            StatusBar();
            sketsWaardes();
            ShowBM();

        }
        private void setScale()
        {
            bottomVal = pnlGraph.Height * 0.036f;
            topVal = pnlGraph.Height * 0.67f;
            constant = bottomVal;
        }
        private void ShowBM()
        {
            pnlGraph.CreateGraphics().DrawImage(bitmapPlot, 0, 0, bitmapPlot.Width, bitmapPlot.Height);
        }
        private void StatusBar()
        {
            stbGraph.Panels[0].Text = "Counter " + csv.sEXCcounter;
            stbGraph.Panels[1].Text = "Exc " + csv.sExceedance;
            stbGraph.Panels[2].Text = "Note " + csv.sEXCnote;

            if (Tools.StartCounter != 0 || Tools.EndCounter != 0)
            {
                stbGraph.Panels["Message"].Text = "Selected start counter " + Tools.StartCounter.ToString() +
                    " End " + Tools.EndCounter.ToString() +
                    " Distance " + Math.Round(Tools.Distance, 3) +
                    " km.";
            }

        }
        private void stelTekenWaardes()
        {
            tekenWaardes[0] = new TekenWaardes()
            {
                naam = "AltP",
                grafiekOmOpTePlot = 1,
                parameterKomaNaam = csv.altitudeP,
                kleur = Color.Blue,
                teken = true,
                minW = -1000,
                maxW = 41000
            };

            tekenWaardes[1] = new TekenWaardes()
            {
                naam = "AltR",
                grafiekOmOpTePlot = 1,
                parameterKomaNaam = csv.altitudeR,
                kleur = Color.DarkGoldenrod,
                teken = true,
                minW = 0,
                maxW = 4000
            };
            tekenWaardes[2] = new TekenWaardes()
            {
                naam = "CAS",
                grafiekOmOpTePlot = 2,
                parameterKomaNaam = csv.speedCAS,
                kleur = Color.SeaGreen,
                teken = true,
                minW = 0,
                maxW = 550
            };
            tekenWaardes[3] = new TekenWaardes()
            {
                naam = "GS",
                grafiekOmOpTePlot = 2,
                parameterKomaNaam = csv.speedGround,
                kleur = Color.Black,
                teken = true,
                minW = 0,
                maxW = 550
            };
        }
        private void stelToepModus()
        {
            if (appSettings.Mode == "demo")
            {

                Date.AutoSize = StatusBarPanelAutoSize.None;
                Date.Width = 2;
                FlightNumber.AutoSize = StatusBarPanelAutoSize.None;
                FlightNumber.Width = 2;
            }
            else if (appSettings.Mode == "dev")
            {
                Date.AutoSize = StatusBarPanelAutoSize.Contents;
                FlightNumber.AutoSize = StatusBarPanelAutoSize.Contents;
            }

        }
        private void plaasKnopies()
        {
            int count = tekenWaardes.Count(x => x != null);

            ToolStripButton[] mi = new ToolStripButton[count];

            for (int i = 0; i < mi.Length; i++)
            //for (int i = 0; i < 3; i++)
                {
                mi[i] = new ToolStripButton();
                mi[i].Name = tekenWaardes[i].naam;
                mi[i].CheckOnClick = true;
                mi[i].Text = tekenWaardes[i].naam;
                mi[i].Checked = tekenWaardes[i].teken;
                mi[i].Click += new EventHandler(CAS_Click);
            }

            if (!kiesLysGeStel)
            {
                tsMain.Items.AddRange(mi);
                kiesLysGeStel = true;
            }

        }
        private void mFileSave_Click(object sender, EventArgs e)
        {
            Save_Graph();
        }

        private void tsbVerticalSpeed_Click(object sender, EventArgs e)
        {
            //verticalSpeedToolStripMenuItem.Checked = tsbVerticalSpeed.Checked;
            sketsWaardes();
            ShowBM();
        }

        private void tsButtonClose_Click_1(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.Close();
            return;
        }

        private void tsbSaveJPG_Click(object sender, EventArgs e)
        {
            Save_Graph();
        }

        private void mnuWindVector_Click(object sender, EventArgs e)
        {
            tekenSkaal();
            sketsWaardes();
            ShowBM();
        }
        private void createKMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createKML m = new createKML();
            m.KMLEventCounter = Convert.ToInt32(FOQAData.csv.sEXCcounter);
            m.Show();
        }
        private void setStartCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Tools.StartCounter = Convert.ToDouble(lblCounter.Text);
                Tools.Distance = 0; //That the user will always have the correct distance.
                StatusBar();
            }
            catch (Exception xx)
            {
                MessageBox.Show("An error occurred in set start counter. " + xx, "Graph error.");
            }

        }
        private void setEndCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Tools.EndCounter = Convert.ToDouble(lblCounter.Text);
                Tools.Distance = 0;
                StatusBar();
            }
            catch (Exception xx)
            {
                MessageBox.Show("An error occurred in set start counter. " + xx, "Graph error.");
            }
        }
        private void CalculateDistanceToolStripMenu_Click(object sender, EventArgs e)
        {
            Tools.CalculateDistance(CSV);
            StatusBar();

            MessageBox.Show("Distance " + Math.Round(Tools.Distance, 3) + " Km / " + " NM " + Math.Round(Tools.Distance * 3280 / 6080, 3) + " Burn " + Tools.FU + " kg.", "Distance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void createKMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double EventCounter = 0;
            createKML m = new createKML();
            double.TryParse(csv.sEXCcounter, out EventCounter);
            m.KMLEventCounter = Convert.ToInt32(EventCounter);

            if (Tools.StartCounter != 0)
            {
                m.StartCounter = Convert.ToInt32(Tools.StartCounter);
            }

            if (Tools.EndCounter != 0)
            {
                m.EndCounter = Convert.ToInt32(Tools.EndCounter);
            }

            m.Show();
        }

        private void showDistanceResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Distance " + Math.Round(FOQAData.Tools.Distance, 3) + " Km " + " Burn " + FOQAData.Tools.FU + " kg.", "Distance", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result;
            userInput tes = new userInput();

            tes.ShowDialog();
            result = tes.resultText;


            tes.Dispose();

            MessageBox.Show(result, "Me input box waarde.");
        }

        private void approacMarkersToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            sketsWaardes();
            ShowBM();
        }
       
        private void HeightAboveTouchDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawLubberLine();
            sketsWaardes();
            ShowBM();
        }

        private void nextLandingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);

            int iPos = (p.X / trkScaleH.Value) + drawStartPos;

            for (int i = iPos + 100; i < CSV.Rows.Count - 200; i++)
            {
                if (Convert.ToInt32(CSV.Rows[i][csv.airGnd]) == 1 && Convert.ToInt32(CSV.Rows[i + 1][csv.airGnd]) == 0)
                {
                    schGraphPos.Value = i - 225;
                    break;
                }
            }

            StatusBar();
            Application.DoEvents();

            sketsWaardes();
            ShowBM();
            WriteVal();
        }

        private void frmGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L && csv.airGnd != "")
            {

                int a = (int)(line19.Location.X / GrafiekKonstantes.skaal) + GrafiekKonstantes.beginBietjie;

                for (int i = a; i < CSVRowCount - 1; i++)
                {
                    int[] y = new int[2];

                    int.TryParse(CSV.Rows[i][csv.airGnd].ToString(), out y[0]);
                    int.TryParse(CSV.Rows[i + 1][csv.airGnd].ToString(), out y[1]);

                    if (y[0] == 1 && y[1] == 0)
                    {
                        schGraphPos.Value = i;
                        break;
                    }
                }

                StatusBar();
                Application.DoEvents();


            }
            if (e.Control && e.KeyCode == Keys.T && csv.airGnd != "")
            {
                int a = (int)(line19.Location.X / GrafiekKonstantes.skaal) + drawStartPos;

                for (int i = a; i > 10; i--)
                {
                    int[] y = new int[2];

                    int.TryParse(CSV.Rows[i][csv.airGnd].ToString(), out y[0]);
                    int.TryParse(CSV.Rows[i + 1][csv.airGnd].ToString(), out y[1]);

                    if (y[0] == 0 && y[1] == 1)
                    {
                        schGraphPos.Value = i;
                        break;
                    }
                }

                StatusBar();
                Application.DoEvents();

            }
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                Pen lpen = new Pen(noteColor);
                lpen.Width = 2f;
                Font fnt = new Font("Tahoma", 8, FontStyle.Bold);
                SolidBrush b = new SolidBrush(noteColor);
                Graphics g;

                g = Graphics.FromImage(bitmapPlot);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                Point een = pnlGraph.PointToClient(Cursor.Position);
                Point twee = new Point(een.X, een.Y + 20);

                g.DrawEllipse(lpen, een.X - 10, een.Y - 10, 20, 20);
                g.DrawString(noteTextToolStripTextBox.Text, fnt, b, een.X + 15, een.Y);

            }
        }

        private void tsbFlap_CheckedChanged(object sender, EventArgs e)
        {
           // flapTePositionLeftToolStripMenuItem.Checked = tsbFlap.Checked;
        }

        private void headingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // tsbHDG.Checked = headingToolStripMenuItem.Checked;
            sketsWaardes();
            WriteVal();
            ShowBM();
        }

        private void topHeadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void chtTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void egtTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void fFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void rpmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawLubberLine();
            sketsWaardes();
            ShowBM();
            WriteVal();

        }

        private void mPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void fpTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();

        }

        private void positionCounterToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void CAS_Click(object sender, EventArgs e)
        {
            
            foreach (ToolStripButton item in ((ToolStripButton)sender).GetCurrentParent().Items)
            {

                for (int y = 0; y < tekenWaardes.Length - 1; y++)
                {
                    if (tekenWaardes[y] != null && item.Text.ToLower() == tekenWaardes[y].naam.ToLower())
                    {
                        tekenWaardes[y].teken = item.Checked;
                    }
                }
                
            }

            tekenSkaal();
            sketsWaardes();
            ShowBM();
            
        }

        private void tASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();

        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void navDevIlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteVal();
            sketsWaardes();
            ShowBM();
        }

        private void noteCoulorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                noteColor = colorDialog.Color;
            }
        }

        private void graphDedicated_Paint(object sender, PaintEventArgs e)
        {
            //bitmapPlot = new Bitmap(pnlGraph.Width, pnlGraph.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //tekenSkaal();
            //sketsWaardes();
        }

        private static class cValue
        {
            public static double dExceednaceLatitude = 0;
            public static double dExceedanceLongitude = 0;
        }

        private void tsbShowGMaps_Click(object sender, EventArgs e)
        {
            StringBuilder sGoogleViewLatLong = new StringBuilder();
            sGoogleViewLatLong.Append("http://maps.google.com/maps?q=");
            //sGoogleViewLatLong.Append(cValue.dExceednaceLatitude.ToString() + ", " + "+" + cValue.dExceedanceLongitude.ToString());
            sGoogleViewLatLong.Append(cValue.dExceednaceLatitude.ToString() + "," + cValue.dExceedanceLongitude.ToString());
            System.Diagnostics.Process.Start(sGoogleViewLatLong.ToString());

        }

        
        private static class GrafiekKonstantes
        {
            public static int beginBietjie = 50;
            public static int ondersteBietjie = 10;
            public static float spasie = 0;
            public static double skaal = 1000;
            public static float aanSkuifSpasie = 0;
        }
        private class Grafiek
        {
            public int lyne = 0;
            public double minW = 0;
            public double maksW = 0;
            public double kerW = 0;
        }
        private class TekenWaardes
        {
            public string naam;
            public string parameterKomaNaam;
            public int grafiekOmOpTePlot;
            public Color kleur;
            public bool teken = false;
            public double minW;
            public double maxW;
        }
    }
     
}

