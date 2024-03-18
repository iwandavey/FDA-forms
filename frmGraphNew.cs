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
using FDAClassLibrary;

namespace FOQA
{
    /// <summary>
    /// Summary description for frmGraph.
    /// </summary>
    public class frmGraphNew : System.Windows.Forms.Form
    {
        private System.Windows.Forms.StatusBar stbGraph;
        private System.Windows.Forms.StatusBarPanel stpCounter;
        private System.Windows.Forms.StatusBarPanel stpExc;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.HScrollBar schGraphPos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusBarPanel sbpNote;
        private ToolStripMenuItem approachMarkers;
        private StatusBarPanel FlightNumber;
        private StatusBarPanel Date;
        private ToolStripMenuItem createKMLFileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem setStartCounterToolStripMenuItem;
        private StatusBarPanel Message;
        private ToolStripMenuItem setEndCounterToolStripMenuItem;
        private ToolStripMenuItem positionToolStripMenuItem;
        private ToolStripMenuItem savePositionToolStripMenuItem;
        private ToolStripMenuItem touchdownToolStripMenuItem;
        private ToolStripMenuItem turnoffToolStripMenuItem;

        private System.Windows.Forms.TrackBar trkScaleH;
        private ToolStripMenuItem showAllTanksToolStripMenuItem;
        private ToolStripMenuItem heightAboveLiftOffToolStripMenuItem;
        private ToolStripMenuItem fFToolStripMenuItem;
        private ToolStripMenuItem n2ToolStripMenuItem;
        private ToolStripMenuItem egtToolStripMenuItem;
        private ToolStripMenuItem rpmToolStripMenuItem;
        private ToolStripMenuItem mPToolStripMenuItem;
        private ToolStripMenuItem fpToolStripMenuItem;
        private ToolStripMenuItem chtToolStripMenuItem;
        private ToolStripMenuItem chtTopToolStripMenuItem;
        private ToolStripMenuItem egtTopToolStripMenuItem;
        private ToolStripMenuItem ffTopToolStripMenuItem;
        private ToolStripMenuItem topN2ToolStripMenuItem;
        private ToolStripMenuItem rpmTopToolStripMenuItem;
        private ToolStripMenuItem mpTopToolStripMenuItem;
        private ToolStripMenuItem fpTopToolStripMenuItem;
        private ToolStripMenuItem oilPressureToolStripMenuItem;
        private ToolStripMenuItem oilTemperatureToolStripMenuItem;
        private ToolStripMenuItem oilPressureTopToolStripMenuItem;
        private ToolStripMenuItem topOilTempratureToolStripMenuItem;
        private ToolStripMenuItem pitchTopToolStripMenuItem;
        private ToolStripMenuItem rollTopToolStripMenuItem;
        private ToolStripMenuItem accLateralTopToolStripMenuItem;
        private ToolStripMenuItem LongitudinalTopToolStripMenuItem;
        private ToolStripMenuItem accVerticalTopToolStripMenuItem;
        private ToolStripMenuItem verticalTopToolStripMenuItem;
        private ToolStripMenuItem tASTopToolStripMenuItem;
        private ToolStripMenuItem cASTopToolStripMenuItem;
        private ToolStripMenuItem topFlapTePositionLeftToolStripMenuItem;
        private ToolStripMenuItem n1ToolStripMenuItem;
        private ToolStripMenuItem topN1ToolStripMenuItem;
        private ToolStripMenuItem topRadioAltitudeToolStripMenuItem;
        private ToolStripMenuItem topAirGroundToolStripMenuItem;
        private ToolStripMenuItem topIndividualGearAirGroundToolStripMenuItem;
        private ToolStripMenuItem topTouchDownLiftOffToolStripMenuItem;
        private ToolStripMenuItem topIndividualGearUpDownToolStripMenuItem;
        private ToolStripMenuItem topnavDevIlsToolStripMenuItem;
        private ToolStripMenuItem expandNavDevILSToolStripMenuItem;
        private ToolStripMenuItem placeTextToolStripMenuItem;
        private ToolStripTextBox placeTextToolStripTextBox;
        private ColorDialog colorDialog;
        private ToolStripMenuItem topToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        public Panel pnlGraph;
        private Label lblAP;
        private CDI.LineControl.Line line18;
        private CDI.LineControl.Line line19;
        private ToolStripMenuItem parameterName;
        private DataGridView Kolomme;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howToCalcFuelFlowToolStripMenuItem;
        private ToolStripMenuItem parametersToolStripMenuItem;
        private ToolStripMenuItem topHeadingToolStripMenuItem;

        public frmGraphNew()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraphNew));
            this.trkScaleH = new System.Windows.Forms.TrackBar();
            this.stbGraph = new System.Windows.Forms.StatusBar();
            this.stpCounter = new System.Windows.Forms.StatusBarPanel();
            this.stpExc = new System.Windows.Forms.StatusBarPanel();
            this.sbpNote = new System.Windows.Forms.StatusBarPanel();
            this.FlightNumber = new System.Windows.Forms.StatusBarPanel();
            this.Date = new System.Windows.Forms.StatusBarPanel();
            this.Message = new System.Windows.Forms.StatusBarPanel();
            this.schGraphPos = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approachMarkers = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterName = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToCalcFuelFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightAboveLiftOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cASTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accLateralTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LongitudinalTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accVerticalTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitchTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAirGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topIndividualGearAirGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTouchDownLiftOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRadioAltitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tASTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egtTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.n1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topN1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.n2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topN2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpmTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mpTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPressureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPressureTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilTemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topOilTempratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topFlapTePositionLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHeadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topIndividualGearUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topnavDevIlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandNavDevILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setStartCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEndCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touchdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lblAP = new System.Windows.Forms.Label();
            this.line18 = new CDI.LineControl.Line();
            this.line19 = new CDI.LineControl.Line();
            this.Kolomme = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpExc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Message)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kolomme)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkScaleH
            // 
            this.trkScaleH.AutoSize = false;
            this.trkScaleH.BackColor = System.Drawing.SystemColors.Control;
            this.trkScaleH.LargeChange = 1000;
            this.trkScaleH.Location = new System.Drawing.Point(389, 6);
            this.trkScaleH.Maximum = 5000;
            this.trkScaleH.Minimum = 100;
            this.trkScaleH.Name = "trkScaleH";
            this.trkScaleH.Size = new System.Drawing.Size(153, 19);
            this.trkScaleH.SmallChange = 100;
            this.trkScaleH.TabIndex = 90;
            this.trkScaleH.TickFrequency = 100;
            this.trkScaleH.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkScaleH.Value = 1000;
            this.trkScaleH.ValueChanged += new System.EventHandler(this.trkScaleH_ValueChanged);
            // 
            // stbGraph
            // 
            this.stbGraph.Location = new System.Drawing.Point(0, 566);
            this.stbGraph.Name = "stbGraph";
            this.stbGraph.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.stpCounter,
            this.stpExc,
            this.sbpNote,
            this.FlightNumber,
            this.Date,
            this.Message});
            this.stbGraph.ShowPanels = true;
            this.stbGraph.Size = new System.Drawing.Size(1346, 30);
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
            this.sbpNote.Width = 45;
            // 
            // FlightNumber
            // 
            this.FlightNumber.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.FlightNumber.MinWidth = 1;
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Text = "FlightNumber";
            this.FlightNumber.Width = 95;
            // 
            // Date
            // 
            this.Date.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.Date.MinWidth = 1;
            this.Date.Name = "Date";
            this.Date.Text = "No Date";
            this.Date.Width = 64;
            // 
            // Message
            // 
            this.Message.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Message.Name = "Message";
            this.Message.ToolTipText = "The selected counter positions.";
            this.Message.Width = 721;
            // 
            // schGraphPos
            // 
            this.schGraphPos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.schGraphPos.LargeChange = 1000;
            this.schGraphPos.Location = new System.Drawing.Point(906, 5);
            this.schGraphPos.Maximum = 1000000;
            this.schGraphPos.Name = "schGraphPos";
            this.schGraphPos.Size = new System.Drawing.Size(322, 23);
            this.schGraphPos.SmallChange = 500;
            this.schGraphPos.TabIndex = 1;
            this.schGraphPos.TabStop = true;
            this.schGraphPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.schGraphPos_Scroll);
            this.schGraphPos.ValueChanged += new System.EventHandler(this.schGraphPos_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.approachMarkers,
            this.toolsToolStripMenuItem,
            this.addToolStripMenuItem,
            this.toolStripTextBox1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 31);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createKMLFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // createKMLFileToolStripMenuItem
            // 
            this.createKMLFileToolStripMenuItem.Name = "createKMLFileToolStripMenuItem";
            this.createKMLFileToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.createKMLFileToolStripMenuItem.Text = "Create KML file";
            this.createKMLFileToolStripMenuItem.ToolTipText = "Create a file you can view in google earth.";
            this.createKMLFileToolStripMenuItem.Click += new System.EventHandler(this.createKMLFileToolStripMenuItem_Click);
            // 
            // approachMarkers
            // 
            this.approachMarkers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterName,
            this.parametersToolStripMenuItem});
            this.approachMarkers.Name = "approachMarkers";
            this.approachMarkers.Size = new System.Drawing.Size(59, 27);
            this.approachMarkers.Text = "Show";
            this.approachMarkers.ToolTipText = "Shown after the alt value in [] brackets.";
            // 
            // parameterName
            // 
            this.parameterName.Checked = true;
            this.parameterName.CheckOnClick = true;
            this.parameterName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parameterName.Name = "parameterName";
            this.parameterName.Size = new System.Drawing.Size(203, 26);
            this.parameterName.Text = "Parameter Name";
            this.parameterName.ToolTipText = "Display the parameter name next to the value on the plot area.";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.parametersToolStripMenuItem.Text = "Parameters Hide";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.ToolTipText = "Calculate distance between two caounter positions.";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "1";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToCalcFuelFlowToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToCalcFuelFlowToolStripMenuItem
            // 
            this.howToCalcFuelFlowToolStripMenuItem.Name = "howToCalcFuelFlowToolStripMenuItem";
            this.howToCalcFuelFlowToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.howToCalcFuelFlowToolStripMenuItem.Text = "How to calc fuel flow";
            this.howToCalcFuelFlowToolStripMenuItem.Click += new System.EventHandler(this.howToCalcFuelFlowToolStripMenuItem_Click);
            // 
            // heightAboveLiftOffToolStripMenuItem
            // 
            this.heightAboveLiftOffToolStripMenuItem.Name = "heightAboveLiftOffToolStripMenuItem";
            this.heightAboveLiftOffToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Visible = false;
            // 
            // cASTopToolStripMenuItem
            // 
            this.cASTopToolStripMenuItem.Checked = true;
            this.cASTopToolStripMenuItem.CheckOnClick = true;
            this.cASTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cASTopToolStripMenuItem.Name = "cASTopToolStripMenuItem";
            this.cASTopToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.cASTopToolStripMenuItem.Text = "Top";
            // 
            // showAllTanksToolStripMenuItem
            // 
            this.showAllTanksToolStripMenuItem.Name = "showAllTanksToolStripMenuItem";
            this.showAllTanksToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // accLateralTopToolStripMenuItem
            // 
            this.accLateralTopToolStripMenuItem.Name = "accLateralTopToolStripMenuItem";
            this.accLateralTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // LongitudinalTopToolStripMenuItem
            // 
            this.LongitudinalTopToolStripMenuItem.Name = "LongitudinalTopToolStripMenuItem";
            this.LongitudinalTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // accVerticalTopToolStripMenuItem
            // 
            this.accVerticalTopToolStripMenuItem.Name = "accVerticalTopToolStripMenuItem";
            this.accVerticalTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pitchTopToolStripMenuItem
            // 
            this.pitchTopToolStripMenuItem.Name = "pitchTopToolStripMenuItem";
            this.pitchTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rollTopToolStripMenuItem
            // 
            this.rollTopToolStripMenuItem.Name = "rollTopToolStripMenuItem";
            this.rollTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
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
            // tASTopToolStripMenuItem
            // 
            this.tASTopToolStripMenuItem.Name = "tASTopToolStripMenuItem";
            this.tASTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // chtToolStripMenuItem
            // 
            this.chtToolStripMenuItem.Name = "chtToolStripMenuItem";
            this.chtToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // chtTopToolStripMenuItem
            // 
            this.chtTopToolStripMenuItem.Name = "chtTopToolStripMenuItem";
            this.chtTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // egtToolStripMenuItem
            // 
            this.egtToolStripMenuItem.Name = "egtToolStripMenuItem";
            this.egtToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // egtTopToolStripMenuItem
            // 
            this.egtTopToolStripMenuItem.Name = "egtTopToolStripMenuItem";
            this.egtTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fFToolStripMenuItem
            // 
            this.fFToolStripMenuItem.Name = "fFToolStripMenuItem";
            this.fFToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ffTopToolStripMenuItem
            // 
            this.ffTopToolStripMenuItem.Name = "ffTopToolStripMenuItem";
            this.ffTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // n1ToolStripMenuItem
            // 
            this.n1ToolStripMenuItem.Name = "n1ToolStripMenuItem";
            this.n1ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topN1ToolStripMenuItem
            // 
            this.topN1ToolStripMenuItem.Name = "topN1ToolStripMenuItem";
            this.topN1ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // n2ToolStripMenuItem
            // 
            this.n2ToolStripMenuItem.Name = "n2ToolStripMenuItem";
            this.n2ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topN2ToolStripMenuItem
            // 
            this.topN2ToolStripMenuItem.Name = "topN2ToolStripMenuItem";
            this.topN2ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rpmToolStripMenuItem
            // 
            this.rpmToolStripMenuItem.Name = "rpmToolStripMenuItem";
            this.rpmToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rpmTopToolStripMenuItem
            // 
            this.rpmTopToolStripMenuItem.Name = "rpmTopToolStripMenuItem";
            this.rpmTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mPToolStripMenuItem
            // 
            this.mPToolStripMenuItem.Name = "mPToolStripMenuItem";
            this.mPToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mpTopToolStripMenuItem
            // 
            this.mpTopToolStripMenuItem.Name = "mpTopToolStripMenuItem";
            this.mpTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fpToolStripMenuItem
            // 
            this.fpToolStripMenuItem.Name = "fpToolStripMenuItem";
            this.fpToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fpTopToolStripMenuItem
            // 
            this.fpTopToolStripMenuItem.Name = "fpTopToolStripMenuItem";
            this.fpTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // oilPressureToolStripMenuItem
            // 
            this.oilPressureToolStripMenuItem.Name = "oilPressureToolStripMenuItem";
            this.oilPressureToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // oilPressureTopToolStripMenuItem
            // 
            this.oilPressureTopToolStripMenuItem.Name = "oilPressureTopToolStripMenuItem";
            this.oilPressureTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // oilTemperatureToolStripMenuItem
            // 
            this.oilTemperatureToolStripMenuItem.Name = "oilTemperatureToolStripMenuItem";
            this.oilTemperatureToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topOilTempratureToolStripMenuItem
            // 
            this.topOilTempratureToolStripMenuItem.Name = "topOilTempratureToolStripMenuItem";
            this.topOilTempratureToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topFlapTePositionLeftToolStripMenuItem
            // 
            this.topFlapTePositionLeftToolStripMenuItem.Name = "topFlapTePositionLeftToolStripMenuItem";
            this.topFlapTePositionLeftToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topHeadingToolStripMenuItem
            // 
            this.topHeadingToolStripMenuItem.Name = "topHeadingToolStripMenuItem";
            this.topHeadingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // verticalTopToolStripMenuItem
            // 
            this.verticalTopToolStripMenuItem.Name = "verticalTopToolStripMenuItem";
            this.verticalTopToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // topIndividualGearUpDownToolStripMenuItem
            // 
            this.topIndividualGearUpDownToolStripMenuItem.CheckOnClick = true;
            this.topIndividualGearUpDownToolStripMenuItem.Name = "topIndividualGearUpDownToolStripMenuItem";
            this.topIndividualGearUpDownToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.topIndividualGearUpDownToolStripMenuItem.Text = "Top";
            // 
            // topnavDevIlsToolStripMenuItem
            // 
            this.topnavDevIlsToolStripMenuItem.Name = "topnavDevIlsToolStripMenuItem";
            this.topnavDevIlsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // expandNavDevILSToolStripMenuItem
            // 
            this.expandNavDevILSToolStripMenuItem.Name = "expandNavDevILSToolStripMenuItem";
            this.expandNavDevILSToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 100);
            // 
            // setStartCounterToolStripMenuItem
            // 
            this.setStartCounterToolStripMenuItem.Name = "setStartCounterToolStripMenuItem";
            this.setStartCounterToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            // 
            // setEndCounterToolStripMenuItem
            // 
            this.setEndCounterToolStripMenuItem.Name = "setEndCounterToolStripMenuItem";
            this.setEndCounterToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePositionToolStripMenuItem,
            this.touchdownToolStripMenuItem,
            this.turnoffToolStripMenuItem});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
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
            this.placeTextToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.placeTextToolStripMenuItem.Text = "Place Text";
            // 
            // placeTextToolStripTextBox
            // 
            this.placeTextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.placeTextToolStripTextBox.Name = "placeTextToolStripTextBox";
            this.placeTextToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // pnlGraph
            // 
            this.pnlGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.CausesValidation = false;
            this.pnlGraph.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlGraph.Controls.Add(this.lblAP);
            this.pnlGraph.Controls.Add(this.line18);
            this.pnlGraph.Controls.Add(this.line19);
            this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraph.ForeColor = System.Drawing.Color.Black;
            this.pnlGraph.Location = new System.Drawing.Point(303, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1040, 529);
            this.pnlGraph.TabIndex = 12455;
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
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
            // line18
            // 
            this.line18.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.line18.LineColor1 = System.Drawing.Color.Black;
            this.line18.LineColor2 = System.Drawing.Color.Black;
            this.line18.Location = new System.Drawing.Point(0, 774);
            this.line18.Name = "line18";
            this.line18.Size = new System.Drawing.Size(3600, 1);
            this.line18.TabIndex = 36;
            this.line18.Visible = false;
            // 
            // line19
            // 
            this.line19.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.line19.LineColor1 = System.Drawing.Color.Black;
            this.line19.LineColor2 = System.Drawing.Color.Black;
            this.line19.LineDirection = CDI.LineControl.LineDirections.Vertical;
            this.line19.Location = new System.Drawing.Point(208, 0);
            this.line19.Name = "line19";
            this.line19.Size = new System.Drawing.Size(1, 1154);
            this.line19.TabIndex = 65;
            // 
            // Kolomme
            // 
            this.Kolomme.AllowUserToAddRows = false;
            this.Kolomme.AllowUserToDeleteRows = false;
            this.Kolomme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kolomme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kolomme.Location = new System.Drawing.Point(3, 3);
            this.Kolomme.Name = "Kolomme";
            this.Kolomme.RowHeadersVisible = false;
            this.Kolomme.RowHeadersWidth = 51;
            this.Kolomme.Size = new System.Drawing.Size(294, 529);
            this.Kolomme.TabIndex = 12489;
            this.Kolomme.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kolomme_CellEndEdit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Kolomme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlGraph, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 535F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1346, 535);
            this.tableLayoutPanel1.TabIndex = 12490;
            // 
            // frmGraphNew
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1346, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.trkScaleH);
            this.Controls.Add(this.schGraphPos);
            this.Controls.Add(this.stbGraph);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGraphNew";
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraph_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGraphNew_Paint);
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
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kolomme)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private static DataTable CSV = new DataTable();
        public static int   ExcPosition,
                            drawStartPos,
                            iCount = 0;

        public int rowValue { get; set; }
        public int startValue { get; set; } = -1;

        private static Color[] randomColor = new Color[16];

        public double startPos;
        //private static double dFrac = 0;
        private static int CSVRowCount { get; set; } = 0;
        private static float bottomVal = 0;
        private static float topVal = 0;
        private static float constant = 0;
        private double skaal { get; set; } = 1000;

        private static Color noteColor = Color.Black;

        private static int lynePerGrafiek;
        private static double lynSpasie;

        private Bitmap bmGraph;
        private Bitmap bmScale;

        private int beginBietjie { get; set; } = 20;
        private int eindBietjie { get; set; } = 35;
        public class secondValues
        {
            public static double DME = 0;
            public static double[] windspeed = new double[] { 0, 0 };
            public static double radioAlt = 0;
        }
        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawValues();
            }
        }
        private void trkScaleH_ValueChanged(object sender, System.EventArgs e)
        {
            if (int.TryParse(trkScaleH.Value.ToString(), out int x))
            {
                skaal = x;
            }
            else
            {
                MessageBox.Show("The scale value is not valid. Please enter a valid value.", "DrawScale", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                toolStripTextBox1.Text = "1";
            }
            tekenGrafiek();
        }
        private void frmGraph_Load(object sender, EventArgs e)
        {

            string sACreg;
            
            line19.Height = ClientSize.Height;

            if (pnlGraph.Width < 100)
            {
                return;
            }

            stelGrote();

            randomColor[0] = Color.Black;
            randomColor[1] = Color.Blue;   
            randomColor[2] = Color.Magenta;
            randomColor[3] = Color.Black;
            randomColor[4] = Color.Chocolate;
            randomColor[5] = Color.DarkOrange;
            randomColor[6] = Color.Orange;
            randomColor[7] = Color.HotPink;
            randomColor[8] = Color.DarkOliveGreen;
            randomColor[9] = Color.Green;
            randomColor[10] = Color.MediumVioletRed;
            randomColor[11] = Color.DodgerBlue;
            randomColor[12] = Color.DeepSkyBlue;
            randomColor[13] = Color.DeepSkyBlue;
            randomColor[14] = Color.DarkCyan;
            randomColor[15] = Color.DarkCyan;

            try
            {

                if (schGraphPos.Value == 0)
                {
                    if (csv.csvFileName.Length > 2)
                    {
                        sACreg = csv.csvFileName.Substring(0, 3);
                    }

                    CSV = DataToAnalyse.fdaDataTable;

                    CSVRowCount = CSV.Rows.Count;

                    schGraphPos.Maximum = CSVRowCount;

                }

                StatusBar();
                Application.DoEvents();
                stelToepModus();
                kryKolomme();

                //List<string> comboSource = new List<string> { "Double", "Date" };
                //var dataTypeCombo = new DataGridViewComboBoxColumn();

                //dataTypeCombo.Name = "Dtype";
                //Kolomme.Columns.Add(dataTypeCombo);

                //kolommeComboVaarde(); //2908
                //addWarningsToolDropDownItems();
                //setScale();
                //SetToolbar();

                //DrawScale();

                // DrawBM();
                // ShowBM();
                //schGraphPos.SmallChange = (int)((pnlGraph.Width / skaal) * 0.25);
                // schGraphPos.LargeChange = (int)((pnlGraph.Width / skaal) * 0.5);
            }
            catch
            { }
        }
        private void stelGrote()
        {
            bmGraph = new Bitmap(pnlGraph.Width, pnlGraph.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bmScale = new Bitmap(pnlGraph.Size.Width, pnlGraph.Size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        }

        private void SetHorizontalScale()
        {
            //if (int.TryParse(toolStripTextBox1.Text, out int x))
            //{
            //    skaal = x;
            //}
            //else
            //{
            //    skaal = 1000;
            //    toolStripTextBox1.Text = skaal.ToString();
            //}

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
        private void DrawScale(string[,] paraOmTeTeken, double[,] miax, int[] grafiekNommer,int width, int height, int bottom, int top)
        {
            int h1, h2;
            float fy;

            Graphics g;
            g = Graphics.FromImage(bmScale);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
           
            try
            {
                Pen lpen = new Pen(Color.LightGray, 1);
                Font f = new Font("Aerial", 10);
                Font fKlein = new Font("Calibre", 8);
                     
                SolidBrush borsel = new SolidBrush(randomColor[0]);

                g.Clear(Color.White);

                if (miax.GetLength(0) < 1)
                {
                    return;
                }

                double plotOppervlakHoogte = (int)(height - (miax.GetLength(0) * bottom));

                lynePerGrafiek = 10;

                int numberUnique = grafiekNommer.Distinct().Count();

                lynSpasie = plotOppervlakHoogte / (lynePerGrafiek * numberUnique); // * die lyne wat geplot moet word.
                
                fy = height;

                h1 = beginBietjie;
                h2 = width - eindBietjie;

                // trek die lyne hier.
                for (int i = 0; i < numberUnique; i++)
                {
                    fy -= bottom;
                    
                    for (int y = 0; y < lynePerGrafiek; y++)
                    {
                        g.DrawLine(lpen, h1, fy, h2, fy);
                        fy -= (float)(lynSpasie);
                    }

                }
                // teken die lyne hier.

                float[] yP = new float[2];

                double skaalFrak = (width - (beginBietjie + eindBietjie)) / skaal;

                for (int i = 0; i < paraOmTeTeken.GetLength(0); i++)
                {
                    // werk die waardes van die spesifieke parameter uit.
                    #region stel waardes

                    borsel.Color = randomColor[i];
                    lpen.Color = randomColor[i];

                    miaxTekenWaardes(miax[i,0], miax[i,1], out double min, out double max, out double plotScale);

                    yP[0] = beginBietjie;
                    yP[1] = beginBietjie + (float)skaalFrak;

                    /* trek al die lyne.
                     * Die lyne word van onder na bo getel.
                    */
                    double eenheidPerSpasie = (lynSpasie * lynePerGrafiek) / (max - min); //spasie per voet
                    int ryOmTeteken = schGraphPos.Value;
                    double onderpuntVanDiePlot = ((miax[i, 2]) * bottom) + ((lynePerGrafiek * lynSpasie) * (miax[i, 2] - 1));
                    #endregion

                    fy = (float)(height - onderpuntVanDiePlot - 10);

                    int steKeer = 0;
                    #region teken skaal

                    for (int h = 0; h < i; h++)
                    {
                        if (miax[i, 2] == miax[h, 2])
                        {
                            steKeer++;
                        }
                    }

                    for (int y = 0; y < lynePerGrafiek; y++)
                    {

                        // skryf grafiek lyn skaal waarde.
                        if (paraOmTeTeken[i, 0].Contains("Date") || paraOmTeTeken[i, 0].Contains("Time"))
                        {

                        }
                        else
                        {
                            g.DrawString(((y * ((max - min) / lynePerGrafiek)) + min).ToString(), fKlein, borsel, (float)(h1 + (steKeer * 30)), fy);
                        }
                        

                        fy -= (float)(lynSpasie);

                    }
                    #endregion

                    // todo nuwe grafiek. lig waardes met knopie druk
                   
                    // hier teken ek die gewone lyne
                    
                    for (; ryOmTeteken < CSV.Rows.Count - 3; ryOmTeteken += 1)
                    {
                        if (paraOmTeTeken[i, 1] == "DateTime")
                        {
                            //g.DrawString("Sit tyd lyn hier.",this.Font,Brushes.Black,10,100);
                            break;
                        }
                        //teken die lyn
                        if (double.TryParse(CSV.Rows[ryOmTeteken][paraOmTeTeken[i,0]].ToString(), out double x1))
                        {

                        }
                        else
                        {

                            x1 = 0;
                        }
                        double.TryParse(CSV.Rows[ryOmTeteken + 1][paraOmTeTeken[i,0]].ToString(), out double x2);
                        /* As die plot se opnderkant negatief is moet die plot gelig word. i.e die 0 punt moet gedefinieer raak.
                         */
                            x1 += (min * -1);
                            x2 += (min * -1);
                            x1 *= eenheidPerSpasie;
                            x2 *= eenheidPerSpasie;
                            x1 = height - (x1 + onderpuntVanDiePlot);
                            x2 = height - (x2 + onderpuntVanDiePlot);

                        try
                        {

                            g.DrawLine(lpen, yP[0], (float)x1, yP[1], (float)x2);
                         
                        }
                        catch (OverflowException)
                        {
                            // todo Teken error op screen.
                            return;
                        }

                        yP[0] += (float)skaalFrak;
                        yP[1] += (float)skaalFrak;

                        if (yP[1] > (width - (beginBietjie + eindBietjie)))
                        {
                            //MessageBox.Show("w = " + yP[1].ToString() + " meet " + (width - (beginBietjie + eindeBietjie)).ToString()," heafinhgb" );
                            break;
                        }
                    }                    
                }

                pnlGraph.CreateGraphics().DrawImage(bmScale, 0, 0, width, height);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), " Paint Line", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Arrow;
            }
            Cursor.Current = Cursors.Arrow;

        }
        /// <summary>
        /// get the csv row to use for value retrieval.
        /// </summary>
        private int GetRowPosition()
        {
            double tekenStukkies = (pnlGraph.Width - (beginBietjie + eindBietjie)) / skaal;
           
            int.TryParse(Math.Round(((line19.Location.X)  - beginBietjie) / tekenStukkies, 0).ToString(), out int y);
           
            return y += schGraphPos.Value;

            //Message.Text = line19.Location.X.ToString() + " " + pnlGraph.Location.X + " " +
            //    y;

            //return y;

        }
        private void DrawValues()
        {
            int relativeMouseXPosition = MousePosition.X - (this.Location.Y + pnlGraph.Location.X + 8);
            GetRowPosition();
            calculateSum(1);
            
            
            line19.Location = new Point(relativeMouseXPosition, 0);

            pnlGraph.CreateGraphics().DrawImage(bmScale, 0, 0, pnlGraph.Width, pnlGraph.Height);

            Font fnt = new Font("Calibri", 8, FontStyle.Bold);
            SolidBrush b = new SolidBrush(Color.Red);

            rowValue = GetRowPosition();
           

            if (rowValue < 1 || rowValue > CSVRowCount - 1)
            {
                return;
            }

            kryTekenParameters(out string[,] pNaam, out double[,] miaxPos, out int[] grafTel);
            
            double[] tekenWaardePosiesie = new double[pNaam.GetLength(0)];
            string d = "";

            for (int i = 0; i < pNaam.GetLength(0); i++)
            {
                string pN = pNaam[i,0];

                if (pNaam[i, 1].ToLower() == "double" || pNaam[i,1].ToLower() == "sum") // Die keer dat die sum waarde nie geplot word nie.
                {
                    if (double.TryParse(CSV.Rows[rowValue][pN].ToString(), out double val))
                    {

                        miaxTekenWaardes(miaxPos[i, 0], miaxPos[i, 1], out double min, out double max, out double plotScale);
                        //BEGIN

                        double y1 = val + (min * -1);

                        double eenheidPerSpasie = (lynSpasie * lynePerGrafiek) / (max - min);

                        y1 *= eenheidPerSpasie;

                        double onderpuntVanDiePlot = ((miaxPos[i, 2]) * 10) + ((lynePerGrafiek * lynSpasie) * (miaxPos[i, 2] - 1));

                        y1 = pnlGraph.Height - (y1 + onderpuntVanDiePlot);

                        tekenWaardePosiesie[i] = y1;

                        // kyk hier of die plot posisie verander moet word.

                    }
                }
                else if (DateTime.TryParse(CSV.Rows[rowValue][pNaam[i, 0]].ToString(), out DateTime ts))
                {// this selotion work for garmin files(G3x)
                    b.Color = randomColor[i];
                    
                    if (pNaam[i, 0].Contains("Date"))
                    {
                        d = ts.ToString("dd/MM/yyyy");
                        pnlGraph.CreateGraphics().DrawString(ts.ToString("dd/MM/yyyy"), fnt, b, relativeMouseXPosition, pnlGraph.Location.Y + 15);
                    }

                    if (pNaam[i, 0].Contains("Time"))
                    {
                        d += " " + ts.ToString("HH:mm:ss");
                    }

                    pnlGraph.CreateGraphics().DrawString(d, fnt, b, relativeMouseXPosition, pnlGraph.Location.Y + 15);

                }

            }

            spryWaardesOmTeTeken(tekenWaardePosiesie, out double[] t);

            for (int i = 0; i < t.Length; i++)
            {
                double y1 = t[i];
                b.Color = randomColor[i];
                string pN = pNaam[i, 0];

                double.TryParse(CSV.Rows[rowValue][pN].ToString(), out double val);

                // lig x as hy van die prentjie af is

                do
                {
                    y1 -= 10;
                } while (y1 > pnlGraph.Height);

                if (parameterName.Checked)
                {
                    pnlGraph.CreateGraphics().DrawString(val.ToString() + " " + pN, fnt, b, relativeMouseXPosition, (float)y1);
                }
                else
                {
                    pnlGraph.CreateGraphics().DrawString(val.ToString(), fnt, b, relativeMouseXPosition, (float)y1);
                }
            }
        }
        private void spryWaardesOmTeTeken(double [] dA, out double [] gesprydeWaardes)
        {
            double[] nA = new double[dA.Length];
            int spasie = 9;

            if (dA.Length == 2)
            {
                if (Math.Abs(dA[0] - dA[1]) < 10)
                {
                    if (dA[0] > dA[1])
                    {
                        nA[0] = dA[0];
                        nA[1] = dA[0] - spasie;
                    }
                    else
                    {
                        nA[0] = dA[1];
                        nA[1] = dA[1] - spasie;
                    }
                }
                else
                {
                    nA = dA;
                }

                gesprydeWaardes = nA;
                return;
            }
            
            #region meer as 2 waardes

            int i, c = dA.Length;
            
            var keys = new int[c];
            
            
            if (c > 1)
            {
                for (i = 0; i < c; i++)
                {
                    keys[i] = i;
                }

                Array.Sort(dA, keys /*, ... */);
            }

            // dan kan ek die vaardes werk hier doen.
            int count = 0;
            int addCount = 0;
            double val = 0;
            for (i = 0; i < c -1; i++)
            {
                do
                {// tel die waardes wat verander moet word
                    count++;
                    val = dA[i] - dA[i + count];

                } while (Math.Abs(val) < (count * 10) && i + count < c -1); // todo nou hier besig

                addCount = count;

                if (count > 1)
                {
                    do
                    {
                        dA[i + count - 2] = dA[i + count - 1] - spasie;
                        count--;
                    } while (count > 1);
                }
                count = 0;
                i += addCount - 1;
            }

            // hier is almal gefix

            // was hier

            for (i = 0; i < dA.Length; i++)
            {
                nA[keys[i]] = dA[i];
            }

            gesprydeWaardes =  nA;
            #endregion


        }
        private void miaxTekenWaardes(double dataMin, double dataMax, out double plotMin,out double plotMax, out double plotScale)
        {
            plotMax = 0;
            plotMin = 0;

            plotScale = 0;

            
            double delta = dataMax - dataMin;
            int multiplier = 0;



            if (delta > 1)
            {
                for (int i = 1; multiplier < 100000; i *= 10)
                {
                    if (delta < i)
                    {
                        multiplier = i / 10;
                        break;
                    }
                }
            }
            else if (delta < 1)
            {
                plotMin = Math.Floor(dataMin);
                plotMax = Math.Ceiling(dataMax);
                return;
            }


            //double[] data = { dataMax, dataMin };


            //for(int y = 0; y < 2; y++)
            //{
            //    double val = data[y];

            //    for (int i = 1; i < 100000; i *= 10)
            //    {
            //        if ((val / i) > -10 && val < 0 ||
            //            (val / i) < 10 && val > 0)
            //        {
            //            multiplier = i;
            //            if (y == 0)
            //            {
            //                plotMax = Math.Ceiling(dataMax / multiplier);
            //                plotMax *= multiplier;
            //            }
            //            if (y == 1)
            //            {
            //                plotMin = Math.Floor(dataMin / multiplier);
            //                plotMin *= multiplier;
            //            }
            //            break;
            //        }

            //    }
            //}


            plotMax = Math.Ceiling(dataMax / multiplier);
            plotMax *= multiplier;

            plotMin = Math.Floor(dataMin / multiplier);
            plotMin *= multiplier;
            // vervang die 10 met die hoeveelheid plotlyne.
            //plotScale = (plotMax + plotMin) / 10;

                       
        }
        private void Kolomme_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (!int.TryParse(Kolomme.Rows[e.RowIndex].Cells["Pos"].Value.ToString(), out int i))
            {
                Kolomme.Rows[e.RowIndex].Cells["Pos"].Value = 0;
            }            

           // Application.DoEvents();
          
            tekenGrafiek();

        }
        private void kolommeComboVaarde()
        {

            foreach (DataGridViewRow r in Kolomme.Rows)
            {
                DataGridViewComboBoxCell comCel = (r.Cells[4] as DataGridViewComboBoxCell);
                
                comCel.Items.Add("Double");
                comCel.Items.Add("Date");

                if (r.Cells[0].Value.ToString().ToLower().Contains("date"))
                {
                    comCel.Value = "Date";
                }
                else
                {
                    comCel.Value = "Double";
                }
            }

            Kolomme.Columns[4].Width = 63;
        }
        private void kryKolomme()
        {

            //List<string> comboSource = new List<string> { "Double", "Date" };
            //var dataTypeCombo = new DataGridViewComboBoxColumn();

            //dataTypeCombo.Name = "Dtype";
            //Kolomme.Columns.Add(dataTypeCombo);

            if (Kolomme.RowCount == CSV.Columns.Count)
            {
                return;
            }
            DataTable dt = new DataTable("velde");

            dt.Clear();

            dt.Columns.Add("Data", typeof(string));
            //dt.Columns.Add("Plot", typeof(bool));
            dt.Columns.Add("Pos", typeof(int));
            dt.Columns.Add("Min", typeof(double));
            dt.Columns.Add("Max", typeof(double));
            dt.Columns.Add("Type", typeof(string));

            foreach (DataColumn x in CSV.Columns)
            {
                DataRow r = dt.NewRow();

                r[0] = x.ColumnName;
                r[1] = false;

                
               if(x.DataType.Name.Contains("Date"))
               {
                   r[4] = "DateTime";
               }
               else
               {
                   r[4] = "Double";
               }
                dt.Rows.Add(r);

            }

            Kolomme.DataSource = dt;
            Kolomme.Columns[0].Width = 55;
            Kolomme.Columns[1].Width = 35;
            Kolomme.Columns[2].Width = 40;
            Kolomme.Columns[3].Width = 40;

            double   min = 0
                   , max = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                max = 0;
                min = 0;
                
                for (int h = 0; h < dt.Rows.Count; h++)
                {
                    string s = dt.Rows[r][0].ToString();

                    if (double.TryParse(CSV.Rows[h][s].ToString(), out double w))
                    {// kry die waarde van al 
                        if (h == 0)
                        {
                            min = w;
                            max = w;
                        }
                        else if (w < min)
                        {
                            min = w;
                        }
                        else if (w > max)
                        {
                            max = w;
                        }
                    }
                }

                dt.Rows[r]["min"] = min;
                dt.Rows[r]["max"] = max;

                Application.DoEvents();

            }


        }
        private void schGraphPos_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                tekenGrafiek();
            }
            
        }
        private void tekenGrafiek()
        {
            kryTekenParameters(out string[,] paramNaam,out double[,] miaxPos, out int[] grafiekTel);
            DrawScale(paramNaam, miaxPos, grafiekTel, pnlGraph.Size.Width, pnlGraph.Size.Height, 10, 10);
        }
        private void kryTekenParameters(out string[,] paramNaam, out double[,] miaxPos, out int[] grafiekNommer)
        {
            int toPlot = 0;
            double grafiekNo = 0;

            foreach (DataGridViewRow row in Kolomme.Rows)
            {
                if (double.TryParse(row.Cells["Pos"].Value.ToString(), out grafiekNo))
                {
                    if (grafiekNo > 0)
                    toPlot++;
                }

            }

            paramNaam = new string[toPlot,2];
            miaxPos = new double[toPlot, 3];
            grafiekNommer = new int[toPlot];

            if (toPlot > 0)
            {
                int aRC = 0;

                for (int i = 0; i < Kolomme.Rows.Count; i++)
                {
                    if (double.TryParse(Kolomme.Rows[i].Cells["Pos"].Value.ToString(), out grafiekNo))
                    {
                        if (grafiekNo > 0)
                        {
                            paramNaam[aRC, 0] = Kolomme.Rows[i].Cells["Data"].Value.ToString();
                            //paramNaam[aRC, 1] = Kolomme.Rows[i].Cells["Dtype"].Value.ToString();
                            paramNaam[aRC, 1] = Kolomme.Rows[i].Cells["Type"].Value.ToString();
                            double.TryParse(Kolomme.Rows[i].Cells["Min"].Value.ToString(), out double min);
                            miaxPos[aRC, 0] = min;
                            double.TryParse(Kolomme.Rows[i].Cells["Max"].Value.ToString(), out double max);
                            miaxPos[aRC, 1] = max;

                            miaxPos[aRC, 2] = grafiekNo;
                            grafiekNommer[aRC] = (int)grafiekNo;
                            aRC++;
                        }
                        
                    }
                }
            }
        }
        private void schGraphPos_ValueChanged(object sender, System.EventArgs e)
        {
            tekenGrafiek();
   
        }
        private void setScale()
        {
            bottomVal = pnlGraph.Height * 0.036f;
            topVal = pnlGraph.Height * 0.67f;
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
        private void tsButtonClose_Click_1(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.Close();
            return;
        }
        private void createKMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createKML m = new createKML();
            m.KMLEventCounter = Convert.ToInt32(FOQAData.csv.sEXCcounter);
            m.Show();
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
        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result;
            userInput tes = new userInput();

            tes.ShowDialog();
            result = tes.resultText;


            tes.Dispose();

            MessageBox.Show(result, "Me input box waarde.");
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

          
            
        }
        private void frmGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L && csv.airGnd != "")
            {
                
                int a = (int)(line19.Location.X / skaal) + drawStartPos;

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

                g.DrawEllipse(lpen,een.X -10, een.Y - 10, 20 , 20);
                //g.DrawString(noteTextToolStripTextBox.Text, fnt, b, een.X + 15, een.Y);

                ShowBM();

                                
            }
            
            if (e.Control && e.KeyCode == Keys.S)
            {

                startValue = GetRowPosition();
                Message.Text = startValue.ToString();
                
                //MessageBox.Show("ctrl s button to set start point.");
            }
        }
        private void calculateSum(int startingPosition)
        {

            if (startValue <= 0 || startValue > CSVRowCount)
                //Message.Text = "Return";
                return;

            int EndPosition  = GetRowPosition();
            double sumVal = 0;
            foreach (DataGridViewRow dataRow in Kolomme.Rows)
            {
                if (dataRow.Cells["type"].Value.ToString().ToLower() == "sum")
                {
                   for (int i = startValue; i < EndPosition; i++)
                    {
                        double.TryParse(CSV.Rows[i][dataRow.Cells["Data"].Value.ToString()].ToString(), out double val);
                        val /= 3600;
                        sumVal += val;
                        
                    }
                    Message.Text = sumVal.ToString() + "*";
                    sumVal = 0;  
                }
                
            }
            

        }
        private void noteCoulorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                noteColor = colorDialog.Color;
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryKolomme();
        }
        private void frmGraphNew_Paint(object sender, PaintEventArgs e)
        {
            stelGrote();
            tekenGrafiek();
        }
        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            //if (double.TryParse(toolStripTextBox1.Text.ToString(), out skaal))
            //{
            //}
            //else
            //{
            //    MessageBox.Show("The scale value is not valid. Please enter a valid value.", "DrawScale", MessageBoxButtons.OK
            //        , MessageBoxIcon.Error);
            //    toolStripTextBox1.Text = "1";
            //}
            //tekenGrafiek();
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            setScale();
        }

        private void howToCalcFuelFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To", "cntrl S set the start position. Sum will sum. Show in message");
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(parametersToolStripMenuItem.Text.ToLower() == "parameters hide")
            { 
                parametersToolStripMenuItem.Text = "Parameters Show";
                tableLayoutPanel1.ColumnStyles[0].Width = 0;
                stelGrote();
                tekenGrafiek();
            }
            else
            {
                parametersToolStripMenuItem.Text = "Parameters Hide";
                tableLayoutPanel1.ColumnStyles[0].Width = 300;
                stelGrote();
                tekenGrafiek();
            }

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
    }

}

