using FDAClassLibrary;
using FOQA.ApplicationClasses;
using FOQA.TestForms;
using FOQAData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FOQA
{
    public class frmMainFOQA : System.Windows.Forms.Form
    {

        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuOCSV;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Data.OleDb.OleDbConnection cnDB1;
        private System.Windows.Forms.MenuItem mnuExit;

        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem view;
        private System.Windows.Forms.MenuItem mnuViewSim;
        private System.Windows.Forms.MenuItem viewGraph;
        private System.Windows.Forms.ImageList imgListTB;
        private System.Windows.Forms.MenuItem mnuShowClosed;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mmnuAirports;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem mnuFindExceedances;
        private System.Windows.Forms.MenuItem mnuCloseCSV;
        private ToolStrip tsMain;
        private ToolStripButton OpenCSV;
        private ToolStripButton closeCSV;
        private ToolStripDropDownButton Aircraft;
        private ToolStripButton showGrphButton;
        private ToolStripDropDownButton tsEvents;
        private ToolStripMenuItem tsDdClosed;
        private ToolStripMenuItem tsDdOpen;
        private ToolStripButton tsbAnalyze;
        private ToolStripButton ShowFlightsForm;
        private DateTimePicker StartDate;
        private DateTimePicker EndDate;
        private ToolStripButton tsButtonSim;
        private MenuItem mnuAircraft;
        private MenuItem menuItem5;
        private ToolStripButton tsUseDate;
        private MenuItem menuItem6;
        private MenuItem mnuDate;
        private MenuItem mnuAnalyzeParameters;
        private SaveFileDialog sfdFile;
        private FolderBrowserDialog fbdMain;
        private MenuItem mnuSettings;
        private MenuItem mnuAnalyze_All;
        private MenuItem openCsvSpecial;
        private System.ComponentModel.IContainer components;

        private DataGridView dgM;

        public static DataTable CSV = new DataTable();
        //public static OleDbDataAdapter _daLog = new OleDbDataAdapter();
        //public static OleDbDataAdapter _daPilots = new OleDbDataAdapter();
        public static OleDbConnection pcnDB = new OleDbConnection();
        //public static int ipGCounter;
        public static string csvFile, selectedcounter, spExcDescription, spExeCounter;
        //public static bool bPilotEdit = false;
        public static bool reloadDataGridNeeded = false;
        public static bool eersteGebeurtenisLaaiKla = false;
        private int currentRow;

        string csvPath;

        private MenuItem fileNameMenuItem;
        private ToolStripButton newGraph;
        private ToolStripDropDownButton FDMscope;
        private MenuItem technicalCause;
        private MenuItem graphDynamic;
        private DataGridView dataGridView2;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel fileLoaded;
        private ToolStripProgressBar Vordering;
        private ToolStripStatusLabel records;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel FLights;
        private MenuItem Edit;
        private MenuItem deleteFile;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuItem SaveSingleAnalysesResult;
        private DataGridViewTextBoxColumn TODate;
        private DataGridViewTextBoxColumn vlugNommer;
        private DataGridViewTextBoxColumn opstygLghawe;
        private DataGridViewTextBoxColumn Landing;
        private DataGridViewTextBoxColumn opstygMerker;
        private DataGridViewTextBoxColumn landingMerker;
        private DataGridViewTextBoxColumn opstygTyd;
        private DataGridViewTextBoxColumn landingTyd;
        private MenuItem dataRecovery;
        private MenuItem dataRecoveryLTMI;
        private MenuItem dataRecoverySAAT;
        private MenuItem dataRecoveryBoth;
        private MenuItem menuItem10;
        private MenuItem flightsFlown;
        private ToolStripStatusLabel toolStripStatusDataPath;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel databasePath;
        private MenuItem ReportingMenu;
        private MenuItem PrepareReportN;
        private MenuItem ShowReportCenter;
        private MenuItem PrepareFlightsAnalyzedReport;
        private DataGridViewTextBoxColumn cExcID;
        private DataGridViewTextBoxColumn Registration;
        private DataGridViewCheckBoxColumn cSelected;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn cFlightNo;
        private DataGridViewTextBoxColumn cfkAirport;
        private DataGridViewTextBoxColumn Exceedance;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn cfkRunway;
        private DataGridViewTextBoxColumn scope;
        private DataGridViewTextBoxColumn FlightPhase;
        private DataGridViewTextBoxColumn Severity;
        private DataGridViewTextBoxColumn cfkCause;
        private DataGridViewTextBoxColumn cFcounter;
        private DataGridViewTextBoxColumn cTimeOfExc;
        private DataGridViewCheckBoxColumn cExcClosed;
        private DataGridViewTextBoxColumn FileId;
        private DataGridViewTextBoxColumn FileName;
        private MenuItem prepareNotesReport;
        private MenuItem viewFlightsLog;
        private ToolStripButton toolStripButton1;
        private ComboBox company;
        private MenuItem menuItem4;
        List<string> filesNotAnelysed = new List<string>();

        public frmMainFOQA()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.BringToFront();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainFOQA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuOCSV = new System.Windows.Forms.MenuItem();
            this.mnuAnalyze_All = new System.Windows.Forms.MenuItem();
            this.openCsvSpecial = new System.Windows.Forms.MenuItem();
            this.SaveSingleAnalysesResult = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mmnuAirports = new System.Windows.Forms.MenuItem();
            this.mnuAircraft = new System.Windows.Forms.MenuItem();
            this.mnuSettings = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuCloseCSV = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.Edit = new System.Windows.Forms.MenuItem();
            this.deleteFile = new System.Windows.Forms.MenuItem();
            this.dataRecovery = new System.Windows.Forms.MenuItem();
            this.dataRecoveryLTMI = new System.Windows.Forms.MenuItem();
            this.dataRecoverySAAT = new System.Windows.Forms.MenuItem();
            this.dataRecoveryBoth = new System.Windows.Forms.MenuItem();
            this.flightsFlown = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuFindExceedances = new System.Windows.Forms.MenuItem();
            this.mnuAnalyzeParameters = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuShowClosed = new System.Windows.Forms.MenuItem();
            this.view = new System.Windows.Forms.MenuItem();
            this.mnuViewSim = new System.Windows.Forms.MenuItem();
            this.viewGraph = new System.Windows.Forms.MenuItem();
            this.graphDynamic = new System.Windows.Forms.MenuItem();
            this.viewFlightsLog = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuDate = new System.Windows.Forms.MenuItem();
            this.fileNameMenuItem = new System.Windows.Forms.MenuItem();
            this.technicalCause = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.ReportingMenu = new System.Windows.Forms.MenuItem();
            this.PrepareReportN = new System.Windows.Forms.MenuItem();
            this.PrepareFlightsAnalyzedReport = new System.Windows.Forms.MenuItem();
            this.prepareNotesReport = new System.Windows.Forms.MenuItem();
            this.ShowReportCenter = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.cnDB1 = new System.Data.OleDb.OleDbConnection();
            this.imgListTB = new System.Windows.Forms.ImageList(this.components);
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.OpenCSV = new System.Windows.Forms.ToolStripButton();
            this.closeCSV = new System.Windows.Forms.ToolStripButton();
            this.showGrphButton = new System.Windows.Forms.ToolStripButton();
            this.ShowFlightsForm = new System.Windows.Forms.ToolStripButton();
            this.tsbAnalyze = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSim = new System.Windows.Forms.ToolStripButton();
            this.newGraph = new System.Windows.Forms.ToolStripButton();
            this.Aircraft = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsEvents = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsDdClosed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDdOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUseDate = new System.Windows.Forms.ToolStripButton();
            this.FDMscope = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.dgM = new System.Windows.Forms.DataGridView();
            this.cExcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfkAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exceedance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfkRunway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightPhase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfkCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFcounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTimeOfExc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExcClosed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlugNommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstygLghawe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstygMerker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landingMerker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstygTyd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landingTyd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.records = new System.Windows.Forms.ToolStripStatusLabel();
            this.Vordering = new System.Windows.Forms.ToolStripProgressBar();
            this.FLights = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.databasePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.company = new System.Windows.Forms.ComboBox();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "csv Files|*.csv|FOQA File|FOQA.mdb|All|*.*";
            this.ofdMain.InitialDirectory = "E:\\RV FDA";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.Edit,
            this.menuItem1,
            this.menuItem2,
            this.view,
            this.ReportingMenu,
            this.mnuAbout});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen,
            this.SaveSingleAnalysesResult,
            this.menuItem9,
            this.mmnuAirports,
            this.mnuAircraft,
            this.mnuSettings,
            this.menuItem3,
            this.mnuCloseCSV,
            this.mnuExit,
            this.menuItem4});
            this.mnuFile.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOCSV,
            this.mnuAnalyze_All,
            this.openCsvSpecial});
            this.mnuOpen.Text = "&Open";
            // 
            // mnuOCSV
            // 
            this.mnuOCSV.Index = 0;
            this.mnuOCSV.Text = "&CSV (File from Aircraft)";
            this.mnuOCSV.Click += new System.EventHandler(this.mnuOCSV_Click);
            // 
            // mnuAnalyze_All
            // 
            this.mnuAnalyze_All.Index = 1;
            this.mnuAnalyze_All.Text = "Analyze All";
            this.mnuAnalyze_All.Click += new System.EventHandler(this.mnuAnalyze_All_Click);
            // 
            // openCsvSpecial
            // 
            this.openCsvSpecial.Index = 2;
            this.openCsvSpecial.Text = "Open CSV Special";
            this.openCsvSpecial.Visible = false;
            // 
            // SaveSingleAnalysesResult
            // 
            this.SaveSingleAnalysesResult.Enabled = false;
            this.SaveSingleAnalysesResult.Index = 1;
            this.SaveSingleAnalysesResult.Text = "Save";
            this.SaveSingleAnalysesResult.Click += new System.EventHandler(this.SaveSingleAnalysesResult_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "-";
            // 
            // mmnuAirports
            // 
            this.mmnuAirports.Index = 3;
            this.mmnuAirports.Text = "Airports";
            this.mmnuAirports.Visible = false;
            this.mmnuAirports.Click += new System.EventHandler(this.mmnuAirports_Click);
            // 
            // mnuAircraft
            // 
            this.mnuAircraft.Index = 4;
            this.mnuAircraft.Text = "Aircraft";
            this.mnuAircraft.Visible = false;
            this.mnuAircraft.Click += new System.EventHandler(this.mnuAircraft_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Index = 5;
            this.mnuSettings.Text = "Settings";
            this.mnuSettings.Visible = false;
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 6;
            this.menuItem3.Text = "-";
            // 
            // mnuCloseCSV
            // 
            this.mnuCloseCSV.Index = 7;
            this.mnuCloseCSV.Text = "Close CSV";
            this.mnuCloseCSV.Click += new System.EventHandler(this.mnuCloseCSV_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 8;
            this.mnuExit.Text = "Exit FOQA";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 9;
            this.menuItem4.Text = "Toets stadige message";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // Edit
            // 
            this.Edit.Index = 1;
            this.Edit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.deleteFile,
            this.dataRecovery,
            this.flightsFlown});
            this.Edit.Text = "Edit";
            // 
            // deleteFile
            // 
            this.deleteFile.Index = 0;
            this.deleteFile.Text = "Delete File";
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // dataRecovery
            // 
            this.dataRecovery.Index = 1;
            this.dataRecovery.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.dataRecoveryLTMI,
            this.dataRecoverySAAT,
            this.dataRecoveryBoth});
            this.dataRecovery.Text = "Data recovery";
            this.dataRecovery.Click += new System.EventHandler(this.dataRecovery_Click);
            // 
            // dataRecoveryLTMI
            // 
            this.dataRecoveryLTMI.Index = 0;
            this.dataRecoveryLTMI.Text = "Data Recovery LTMI";
            this.dataRecoveryLTMI.Click += new System.EventHandler(this.dataRecoveryLTMI_Click);
            // 
            // dataRecoverySAAT
            // 
            this.dataRecoverySAAT.Index = 1;
            this.dataRecoverySAAT.Text = "Data Recovery SAAT";
            this.dataRecoverySAAT.Click += new System.EventHandler(this.dataRecoverySAAT_Click);
            // 
            // dataRecoveryBoth
            // 
            this.dataRecoveryBoth.Index = 2;
            this.dataRecoveryBoth.Text = "Data Recovery Both";
            this.dataRecoveryBoth.Click += new System.EventHandler(this.dataRecovery_Click);
            // 
            // flightsFlown
            // 
            this.flightsFlown.Index = 2;
            this.flightsFlown.Text = "Flights Flown";
            this.flightsFlown.Click += new System.EventHandler(this.flightsFlown_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFindExceedances,
            this.mnuAnalyzeParameters});
            this.menuItem1.Text = "Analyze";
            this.menuItem1.Visible = false;
            // 
            // mnuFindExceedances
            // 
            this.mnuFindExceedances.Index = 0;
            this.mnuFindExceedances.Text = "";
            // 
            // mnuAnalyzeParameters
            // 
            this.mnuAnalyzeParameters.Index = 1;
            this.mnuAnalyzeParameters.Text = "";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuShowClosed});
            this.menuItem2.Text = "Exceedances";
            this.menuItem2.Visible = false;
            // 
            // mnuShowClosed
            // 
            this.mnuShowClosed.Index = 0;
            this.mnuShowClosed.Text = "Show Closed";
            this.mnuShowClosed.Visible = false;
            // 
            // view
            // 
            this.view.Index = 4;
            this.view.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuViewSim,
            this.viewGraph,
            this.graphDynamic,
            this.viewFlightsLog,
            this.menuItem5,
            this.menuItem6,
            this.menuItem10});
            this.view.Text = "View";
            // 
            // mnuViewSim
            // 
            this.mnuViewSim.Enabled = false;
            this.mnuViewSim.Index = 0;
            this.mnuViewSim.Text = "View Simulation";
            this.mnuViewSim.Visible = false;
            this.mnuViewSim.Click += new System.EventHandler(this.mnuViewSim_Click);
            // 
            // viewGraph
            // 
            this.viewGraph.Index = 1;
            this.viewGraph.Text = "View Graph";
            // 
            // graphDynamic
            // 
            this.graphDynamic.Index = 2;
            this.graphDynamic.Text = "Graph Dynamic";
            this.graphDynamic.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // viewFlightsLog
            // 
            this.viewFlightsLog.Index = 3;
            this.viewFlightsLog.Text = "Flights Log";
            this.viewFlightsLog.Click += new System.EventHandler(this.tsbFlightTracker_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDate,
            this.fileNameMenuItem,
            this.technicalCause});
            this.menuItem6.Text = "Show";
            // 
            // mnuDate
            // 
            this.mnuDate.Checked = true;
            this.mnuDate.Index = 0;
            this.mnuDate.Text = "Date ";
            this.mnuDate.Click += new System.EventHandler(this.mnuDate_Click);
            // 
            // fileNameMenuItem
            // 
            this.fileNameMenuItem.Index = 1;
            this.fileNameMenuItem.Text = "File name";
            this.fileNameMenuItem.Click += new System.EventHandler(this.fileNameMenuItem_Click);
            // 
            // technicalCause
            // 
            this.technicalCause.Index = 2;
            this.technicalCause.Text = "Include Technical (Cause)";
            this.technicalCause.Click += new System.EventHandler(this.technicalCause_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 6;
            this.menuItem10.Text = "View Exceedance grid";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // ReportingMenu
            // 
            this.ReportingMenu.Index = 5;
            this.ReportingMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.PrepareReportN,
            this.PrepareFlightsAnalyzedReport,
            this.prepareNotesReport,
            this.ShowReportCenter});
            this.ReportingMenu.Text = "Reporting";
            // 
            // PrepareReportN
            // 
            this.PrepareReportN.Index = 0;
            this.PrepareReportN.Text = "Prepare FDM report";
            this.PrepareReportN.Click += new System.EventHandler(this.PrepareReportN_Click);
            // 
            // PrepareFlightsAnalyzedReport
            // 
            this.PrepareFlightsAnalyzedReport.Index = 1;
            this.PrepareFlightsAnalyzedReport.Text = "Prepare Flights Analyzed Report";
            this.PrepareFlightsAnalyzedReport.Click += new System.EventHandler(this.PrepareFlightsAnalyzedReport_Click);
            // 
            // prepareNotesReport
            // 
            this.prepareNotesReport.Index = 2;
            this.prepareNotesReport.Text = "Prepare Notes report";
            this.prepareNotesReport.Click += new System.EventHandler(this.prepareNotesReport_Click);
            // 
            // ShowReportCenter
            // 
            this.ShowReportCenter.Index = 3;
            this.ShowReportCenter.Text = "Show Report Reports";
            this.ShowReportCenter.Click += new System.EventHandler(this.ShowReportCenter_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 6;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // cnDB1
            // 
            this.cnDB1.ConnectionString = resources.GetString("cnDB1.ConnectionString");
            // 
            // imgListTB
            // 
            this.imgListTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTB.ImageStream")));
            this.imgListTB.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTB.Images.SetKeyName(0, "folder_green.ico");
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
            this.imgListTB.Images.SetKeyName(11, "trashcan_full.ico");
            this.imgListTB.Images.SetKeyName(12, "3floppy_unmount.ico");
            this.imgListTB.Images.SetKeyName(13, "");
            this.imgListTB.Images.SetKeyName(14, "");
            this.imgListTB.Images.SetKeyName(15, "");
            this.imgListTB.Images.SetKeyName(16, "");
            this.imgListTB.Images.SetKeyName(17, "");
            this.imgListTB.Images.SetKeyName(18, "");
            this.imgListTB.Images.SetKeyName(19, "");
            this.imgListTB.Images.SetKeyName(20, "remote.png");
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCSV,
            this.closeCSV,
            this.showGrphButton,
            this.ShowFlightsForm,
            this.tsbAnalyze,
            this.tsButtonSim,
            this.newGraph,
            this.Aircraft,
            this.tsEvents,
            this.tsUseDate,
            this.FDMscope,
            this.toolStripButton1});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMain.Size = new System.Drawing.Size(1712, 41);
            this.tsMain.TabIndex = 74;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMain_ItemClicked);
            // 
            // OpenCSV
            // 
            this.OpenCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenCSV.Image = ((System.Drawing.Image)(resources.GetObject("OpenCSV.Image")));
            this.OpenCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenCSV.Name = "OpenCSV";
            this.OpenCSV.Size = new System.Drawing.Size(36, 36);
            this.OpenCSV.Text = "toolStripButton1";
            this.OpenCSV.ToolTipText = "Open csv file.";
            this.OpenCSV.Click += new System.EventHandler(this.tsOpenCSV_Click);
            // 
            // closeCSV
            // 
            this.closeCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeCSV.Enabled = false;
            this.closeCSV.Image = ((System.Drawing.Image)(resources.GetObject("closeCSV.Image")));
            this.closeCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeCSV.Name = "closeCSV";
            this.closeCSV.Size = new System.Drawing.Size(36, 36);
            this.closeCSV.Text = "closeCsv";
            this.closeCSV.ToolTipText = "Close CSV";
            this.closeCSV.Click += new System.EventHandler(this.mnuCloseCSV_Click);
            // 
            // showGrphButton
            // 
            this.showGrphButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showGrphButton.Enabled = false;
            this.showGrphButton.Image = ((System.Drawing.Image)(resources.GetObject("showGrphButton.Image")));
            this.showGrphButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showGrphButton.Name = "showGrphButton";
            this.showGrphButton.Size = new System.Drawing.Size(36, 36);
            this.showGrphButton.Text = "toolStripButton2";
            this.showGrphButton.ToolTipText = "Show Graph of the exceedance.";
            this.showGrphButton.Click += new System.EventHandler(this.tsbGraph_Click);
            // 
            // ShowFlightsForm
            // 
            this.ShowFlightsForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowFlightsForm.Image = ((System.Drawing.Image)(resources.GetObject("ShowFlightsForm.Image")));
            this.ShowFlightsForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFlightsForm.Name = "ShowFlightsForm";
            this.ShowFlightsForm.Size = new System.Drawing.Size(36, 36);
            this.ShowFlightsForm.Text = "Flights";
            this.ShowFlightsForm.ToolTipText = "Show log of flights analyzed.";
            this.ShowFlightsForm.Click += new System.EventHandler(this.tsbFlightTracker_Click);
            // 
            // tsbAnalyze
            // 
            this.tsbAnalyze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnalyze.Enabled = false;
            this.tsbAnalyze.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnalyze.Image")));
            this.tsbAnalyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnalyze.Name = "tsbAnalyze";
            this.tsbAnalyze.Size = new System.Drawing.Size(36, 36);
            this.tsbAnalyze.Text = "toolStripButton1";
            this.tsbAnalyze.ToolTipText = "Seek events.";
            this.tsbAnalyze.Visible = false;
            this.tsbAnalyze.Click += new System.EventHandler(this.tsBAnalyze_Click);
            // 
            // tsButtonSim
            // 
            this.tsButtonSim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSim.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonSim.Image")));
            this.tsButtonSim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonSim.Name = "tsButtonSim";
            this.tsButtonSim.Size = new System.Drawing.Size(36, 36);
            this.tsButtonSim.Text = "Show simulation screen";
            this.tsButtonSim.Click += new System.EventHandler(this.tsButtonSim_Click);
            // 
            // newGraph
            // 
            this.newGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newGraph.Image = ((System.Drawing.Image)(resources.GetObject("newGraph.Image")));
            this.newGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGraph.Name = "newGraph";
            this.newGraph.Size = new System.Drawing.Size(36, 36);
            this.newGraph.Text = "newGraph";
            this.newGraph.Visible = false;
            this.newGraph.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Aircraft
            // 
            this.Aircraft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Aircraft.Image = ((System.Drawing.Image)(resources.GetObject("Aircraft.Image")));
            this.Aircraft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.Size = new System.Drawing.Size(50, 36);
            this.Aircraft.Text = "toolStripDropDownButton1";
            this.Aircraft.ToolTipText = "Select aircraft tyoe to show.";
            // 
            // tsEvents
            // 
            this.tsEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEvents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDdClosed,
            this.tsDdOpen});
            this.tsEvents.Image = ((System.Drawing.Image)(resources.GetObject("tsEvents.Image")));
            this.tsEvents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEvents.Name = "tsEvents";
            this.tsEvents.Size = new System.Drawing.Size(50, 36);
            this.tsEvents.Text = "toolStripDropDownButton2";
            this.tsEvents.ToolTipText = "Records to show.";
            // 
            // tsDdClosed
            // 
            this.tsDdClosed.Checked = true;
            this.tsDdClosed.CheckOnClick = true;
            this.tsDdClosed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsDdClosed.Name = "tsDdClosed";
            this.tsDdClosed.Size = new System.Drawing.Size(168, 34);
            this.tsDdClosed.Text = "Closed";
            this.tsDdClosed.Click += new System.EventHandler(this.tsDdClosed_Click);
            // 
            // tsDdOpen
            // 
            this.tsDdOpen.Checked = true;
            this.tsDdOpen.CheckOnClick = true;
            this.tsDdOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsDdOpen.Name = "tsDdOpen";
            this.tsDdOpen.Size = new System.Drawing.Size(168, 34);
            this.tsDdOpen.Text = "Open";
            this.tsDdOpen.Click += new System.EventHandler(this.tsDdOpen_Click);
            // 
            // tsUseDate
            // 
            this.tsUseDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsUseDate.Checked = true;
            this.tsUseDate.CheckOnClick = true;
            this.tsUseDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsUseDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUseDate.Image = ((System.Drawing.Image)(resources.GetObject("tsUseDate.Image")));
            this.tsUseDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUseDate.Name = "tsUseDate";
            this.tsUseDate.Size = new System.Drawing.Size(36, 36);
            this.tsUseDate.Text = "Date";
            this.tsUseDate.ToolTipText = "Deselect to exclude date selction from you query.";
            this.tsUseDate.Click += new System.EventHandler(this.tsUseDate_Click);
            // 
            // FDMscope
            // 
            this.FDMscope.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FDMscope.Image = ((System.Drawing.Image)(resources.GetObject("FDMscope.Image")));
            this.FDMscope.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FDMscope.Name = "FDMscope";
            this.FDMscope.Size = new System.Drawing.Size(79, 36);
            this.FDMscope.Text = "Scope";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 36);
            // 
            // StartDate
            // 
            this.StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(845, 8);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(178, 26);
            this.StartDate.TabIndex = 75;
            this.StartDate.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.StartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // EndDate
            // 
            this.EndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(1105, 8);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(178, 26);
            this.EndDate.TabIndex = 76;
            this.EndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dgM
            // 
            this.dgM.AllowUserToAddRows = false;
            this.dgM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgM.ColumnHeadersHeight = 25;
            this.dgM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cExcID,
            this.Registration,
            this.cSelected,
            this.Date,
            this.cFlightNo,
            this.cfkAirport,
            this.Exceedance,
            this.Note,
            this.cfkRunway,
            this.scope,
            this.FlightPhase,
            this.Severity,
            this.cfkCause,
            this.cFcounter,
            this.cTimeOfExc,
            this.cExcClosed,
            this.FileId,
            this.FileName});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgM.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgM.Location = new System.Drawing.Point(4, 4);
            this.dgM.Margin = new System.Windows.Forms.Padding(4);
            this.dgM.Name = "dgM";
            this.dgM.RowHeadersWidth = 25;
            this.dgM.RowTemplate.Height = 20;
            this.dgM.Size = new System.Drawing.Size(1704, 935);
            this.dgM.TabIndex = 132;
            this.dgM.CurrentCellChanged += new System.EventHandler(this.dgM_CurrentCellChanged);
            this.dgM.DoubleClick += new System.EventHandler(this.dgM_DoubleClick);
            // 
            // cExcID
            // 
            this.cExcID.DataPropertyName = "Id";
            this.cExcID.HeaderText = "ExcID";
            this.cExcID.MinimumWidth = 6;
            this.cExcID.Name = "cExcID";
            this.cExcID.Width = 109;
            // 
            // Registration
            // 
            this.Registration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Registration.DataPropertyName = "Registration";
            this.Registration.HeaderText = "Reg";
            this.Registration.MinimumWidth = 6;
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            this.Registration.Width = 90;
            // 
            // cSelected
            // 
            this.cSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cSelected.HeaderText = "Sel";
            this.cSelected.MinimumWidth = 6;
            this.cSelected.Name = "cSelected";
            this.cSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cSelected.Visible = false;
            this.cSelected.Width = 82;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            dataGridViewCellStyle9.Format = "dd-MMM-yyyy";
            this.Date.DefaultCellStyle = dataGridViewCellStyle9;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 97;
            // 
            // cFlightNo
            // 
            this.cFlightNo.DataPropertyName = "FlighNumber";
            this.cFlightNo.HeaderText = "Flt No";
            this.cFlightNo.MinimumWidth = 6;
            this.cFlightNo.Name = "cFlightNo";
            this.cFlightNo.ToolTipText = "Flight No";
            this.cFlightNo.Width = 111;
            // 
            // cfkAirport
            // 
            this.cfkAirport.DataPropertyName = "fkAirport";
            this.cfkAirport.HeaderText = "fkAirport";
            this.cfkAirport.MinimumWidth = 6;
            this.cfkAirport.Name = "cfkAirport";
            this.cfkAirport.Visible = false;
            this.cfkAirport.Width = 137;
            // 
            // Exceedance
            // 
            this.Exceedance.DataPropertyName = "Description";
            this.Exceedance.HeaderText = "Exceedance";
            this.Exceedance.MinimumWidth = 6;
            this.Exceedance.Name = "Exceedance";
            this.Exceedance.Width = 177;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "ENote";
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 97;
            // 
            // cfkRunway
            // 
            this.cfkRunway.DataPropertyName = "fkRunway";
            this.cfkRunway.HeaderText = "Runway";
            this.cfkRunway.MinimumWidth = 6;
            this.cfkRunway.Name = "cfkRunway";
            this.cfkRunway.Visible = false;
            this.cfkRunway.Width = 131;
            // 
            // scope
            // 
            this.scope.DataPropertyName = "scope";
            this.scope.HeaderText = "scope";
            this.scope.MinimumWidth = 6;
            this.scope.Name = "scope";
            this.scope.Width = 111;
            // 
            // FlightPhase
            // 
            this.FlightPhase.DataPropertyName = "Phase";
            this.FlightPhase.HeaderText = "FlightPhase";
            this.FlightPhase.MinimumWidth = 6;
            this.FlightPhase.Name = "FlightPhase";
            this.FlightPhase.Width = 173;
            // 
            // Severity
            // 
            this.Severity.DataPropertyName = "Severity";
            this.Severity.HeaderText = "Severity";
            this.Severity.MinimumWidth = 6;
            this.Severity.Name = "Severity";
            this.Severity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Severity.Width = 134;
            // 
            // cfkCause
            // 
            this.cfkCause.DataPropertyName = "Cause";
            this.cfkCause.HeaderText = "Cause";
            this.cfkCause.MinimumWidth = 6;
            this.cfkCause.Name = "cfkCause";
            this.cfkCause.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cfkCause.Width = 115;
            // 
            // cFcounter
            // 
            this.cFcounter.DataPropertyName = "FileCounter";
            this.cFcounter.HeaderText = "Counter";
            this.cFcounter.MinimumWidth = 6;
            this.cFcounter.Name = "cFcounter";
            this.cFcounter.Width = 131;
            // 
            // cTimeOfExc
            // 
            this.cTimeOfExc.DataPropertyName = "TimeOfExc";
            this.cTimeOfExc.HeaderText = "Time";
            this.cTimeOfExc.MinimumWidth = 6;
            this.cTimeOfExc.Name = "cTimeOfExc";
            this.cTimeOfExc.Visible = false;
            this.cTimeOfExc.Width = 99;
            // 
            // cExcClosed
            // 
            this.cExcClosed.DataPropertyName = "ExcClosed";
            this.cExcClosed.HeaderText = "Closed";
            this.cExcClosed.MinimumWidth = 6;
            this.cExcClosed.Name = "cExcClosed";
            this.cExcClosed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cExcClosed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cExcClosed.Visible = false;
            this.cExcClosed.Width = 121;
            // 
            // FileId
            // 
            this.FileId.DataPropertyName = "FileId";
            this.FileId.HeaderText = "FileId";
            this.FileId.MinimumWidth = 6;
            this.FileId.Name = "FileId";
            this.FileId.Visible = false;
            this.FileId.Width = 106;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.Width = 87;
            // 
            // TODate
            // 
            this.TODate.DataPropertyName = "opstygDatum";
            this.TODate.HeaderText = "TO Date";
            this.TODate.MinimumWidth = 6;
            this.TODate.Name = "TODate";
            this.TODate.Width = 125;
            // 
            // vlugNommer
            // 
            this.vlugNommer.DataPropertyName = "vlugNommer";
            this.vlugNommer.HeaderText = "F#";
            this.vlugNommer.MinimumWidth = 6;
            this.vlugNommer.Name = "vlugNommer";
            this.vlugNommer.Width = 125;
            // 
            // opstygLghawe
            // 
            this.opstygLghawe.DataPropertyName = "opstygLughawe";
            this.opstygLghawe.HeaderText = "TakeOff";
            this.opstygLghawe.MinimumWidth = 6;
            this.opstygLghawe.Name = "opstygLghawe";
            this.opstygLghawe.Width = 125;
            // 
            // Landing
            // 
            this.Landing.DataPropertyName = "landingsLughawe";
            this.Landing.HeaderText = "Arival";
            this.Landing.MinimumWidth = 6;
            this.Landing.Name = "Landing";
            this.Landing.Width = 125;
            // 
            // opstygMerker
            // 
            this.opstygMerker.DataPropertyName = "opStygMerker";
            this.opstygMerker.HeaderText = "Dep Counter";
            this.opstygMerker.MinimumWidth = 6;
            this.opstygMerker.Name = "opstygMerker";
            this.opstygMerker.Width = 125;
            // 
            // landingMerker
            // 
            this.landingMerker.DataPropertyName = "landingMerker";
            this.landingMerker.HeaderText = "Arival Counter";
            this.landingMerker.MinimumWidth = 6;
            this.landingMerker.Name = "landingMerker";
            this.landingMerker.Width = 125;
            // 
            // opstygTyd
            // 
            this.opstygTyd.DataPropertyName = "opStygTyd";
            this.opstygTyd.HeaderText = "DEP Time";
            this.opstygTyd.MinimumWidth = 6;
            this.opstygTyd.Name = "opstygTyd";
            this.opstygTyd.ToolTipText = "Departure Time.";
            this.opstygTyd.Width = 125;
            // 
            // landingTyd
            // 
            this.landingTyd.DataPropertyName = "landingTyd";
            this.landingTyd.HeaderText = "Land Time";
            this.landingTyd.MinimumWidth = 6;
            this.landingTyd.Name = "landingTyd";
            this.landingTyd.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 947);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1704, 1);
            this.dataGridView2.TabIndex = 134;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLoaded,
            this.records,
            this.Vordering,
            this.FLights,
            this.toolStripStatusDataPath,
            this.toolStripStatusLabel1,
            this.databasePath});
            this.statusStrip.Location = new System.Drawing.Point(0, 984);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(1712, 64);
            this.statusStrip.TabIndex = 135;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fileLoaded
            // 
            this.fileLoaded.AutoSize = false;
            this.fileLoaded.Name = "fileLoaded";
            this.fileLoaded.Size = new System.Drawing.Size(200, 57);
            this.fileLoaded.Text = "No file loaded.";
            // 
            // records
            // 
            this.records.AutoSize = false;
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(100, 57);
            this.records.Text = "0 of 0";
            // 
            // Vordering
            // 
            this.Vordering.Name = "Vordering";
            this.Vordering.Size = new System.Drawing.Size(150, 56);
            this.Vordering.Visible = false;
            // 
            // FLights
            // 
            this.FLights.Name = "FLights";
            this.FLights.Size = new System.Drawing.Size(0, 57);
            // 
            // toolStripStatusDataPath
            // 
            this.toolStripStatusDataPath.Name = "toolStripStatusDataPath";
            this.toolStripStatusDataPath.Size = new System.Drawing.Size(0, 57);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 57);
            // 
            // databasePath
            // 
            this.databasePath.Name = "databasePath";
            this.databasePath.Size = new System.Drawing.Size(179, 57);
            this.databasePath.Text = "toolStripStatusLabel2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgM, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1712, 943);
            this.tableLayoutPanel1.TabIndex = 137;
            // 
            // company
            // 
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(1310, 8);
            this.company.Margin = new System.Windows.Forms.Padding(4);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(282, 30);
            this.company.TabIndex = 138;
            this.company.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmMainFOQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1712, 1048);
            this.Controls.Add(this.company);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.tsMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Menu = this.mnuMain;
            this.Name = "frmMainFOQA";
            this.Text = "Flight view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainFOQA_FormClosed);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (Environment.OSVersion.Version.Major >= 6)
            //{
            //    SetProcessDPIAware();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainFOQA());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// If the flight information file (csv) has been loaded, set the toolbar as needed.
        /// </summary>
        /// <param name="value">Set true or false.</param>
        private void SetTools(bool value)
        {
            if (FDAfile.appUserRights is null)
            {
                return;
            }
            if (FDAfile.appUserRights.ToLower() == "dev")
            {
                newGraph.Visible = true;
                tsButtonSim.Enabled = true;
                ReportingMenu.Visible = true;
                dataRecovery.Visible = true;
                tsbAnalyze.Visible = true;
                tsButtonSim.Visible = true;
                tsUseDate.Visible = true;
                fileLoaded.Visible = true;
                ShowReportCenter.Visible = true;
                company.Visible = true;
            }
            else if (FDAfile.appUserRights.ToLower() == "demo".ToLower())
            {
                Date.Visible = false;
                Registration.Visible = false;
                FileName.Visible = false;
                cFlightNo.Visible = false;
                newGraph.Visible = false;
                tsbAnalyze.Visible = false;
                tsButtonSim.Visible = true;
                tsButtonSim.Enabled = true;
                tsUseDate.Visible = false;
                fileLoaded.Visible = false;
                company.Visible = false;
            }
            else if (FDAfile.appUserRights.ToLower() == "user")
            {
                //newGraph.Visible = false;
                ReportingMenu.Visible = false;
                deleteFile.Visible = false;
                mnuAnalyze_All.Visible = false;
                dataRecovery.Visible = false;
                tsbAnalyze.Visible = false;
                tsButtonSim.Visible = false;
                tsUseDate.Visible = false;
                fileLoaded.Visible = true;
                ShowReportCenter.Visible = false;
                company.Visible = false;

            }
            else if (appSettings.Mode == "reporting")
            {
                mnuAnalyze_All.Visible = false;
                ReportingMenu.Visible = true;
                dataRecovery.Visible = true;
                tsUseDate.Visible = false;
                fileLoaded.Visible = true;
                ShowReportCenter.Visible = true;
                company.Visible = true;
            }


            showGrphButton.Enabled = value;
            tsButtonSim.Enabled = value;
            viewGraph.Enabled = value;
            mnuViewSim.Enabled = value;
            closeCSV.Enabled = value;
            graphDynamic.Enabled = value;

            ShowFlightsForm.Enabled = !value;
            Aircraft.Enabled = !value;
            FDMscope.Enabled = !value;
            viewFlightsLog.Enabled = !value;
            tsEvents.Enabled = !value;
            tsUseDate.Enabled = !value;
            OpenCSV.Enabled = !value;
            ShowFlightsForm.Enabled = !value;
            StartDate.Enabled = !value;
            EndDate.Enabled = !value;
        }

        private void Continues_Anelise()
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime startTime = DateTime.UtcNow;
            string fileNameWithoutExtension = "";

            filesNotAnelysed.Clear();
            FlightAnalysis.ParametersNotAnaliseds.Clear();

            string[] sFilePaths = Directory.GetFiles(FDAfile.filesPath, "*.csv", SearchOption.AllDirectories);

            Vordering.Visible = true;
            Vordering.Value = 0;
            Vordering.Maximum = sFilePaths.Length;

            for (int i = 0; i < sFilePaths.Length; i++)
            {
                Vordering.Value = i + 1;

                records.Text = Vordering.Value + " of " + sFilePaths.Length;

                Application.DoEvents();

                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sFilePaths[i]);

                FDAfile.csvFileName = fileNameWithoutExtension;

                FDAfile.fileId = FDAfile.GetFileId(FDAfile.csvFileName);
                bool loaded = false;

                if (FDAfile.fileId == 0)
                {
                    fileLoaded.Text = fileNameWithoutExtension;
                    FDAfile.LoadCSV(FDAfile.csvFileName, out loaded);
                    ExceedanceFindMain(false);

                }
            }

            FDAfile.SetCsvFileNotLoaded();
            

            StatusBar(FDAfile.csvFileName);

            StringBuilder sb = new StringBuilder();

            if (filesNotAnelysed.Count > 0)
            {
                sb.AppendLine("Files not analysed.");

                foreach (string s in filesNotAnelysed)
                {
                    sb.AppendLine(s);
                }
            }
            else
            {
                sb.AppendLine($"All files in {FDAfile.csvPath} has been analysed! \n");
            }


            StringBuilder sr2 = new StringBuilder();

            if (FlightAnalysis.ParametersNotAnaliseds.Count > 0)
            {
                sr2.AppendLine($"{FlightAnalysis.ParametersNotAnaliseds.Count} events not analysed for.");
                for (int i = 0; i < FlightAnalysis.ParametersNotAnaliseds.Count; i++)
                {
                    sr2.AppendLine(FlightAnalysis.ParametersNotAnaliseds[i].fileName +
                        " | " + FlightAnalysis.ParametersNotAnaliseds[i].parameter +
                        " | " + FlightAnalysis.ParametersNotAnaliseds[i].reason);
                }
            }
            else
            {
                sr2.AppendLine("All event parameters analysed. \n");
            }

            DateTime endTime = DateTime.UtcNow;
            TimeSpan timeTook = endTime.Subtract(startTime);
            string logFileName = "fda log "
               + FDAfile.company + " "
               + endTime.ToString("yyyyMMddHHmm")
               + ".txt";
            string logPath = FDAfile.analysesLogsPath + "\\" + logFileName;
            if (Directory.Exists(FDAfile.analysesLogsPath))
            {
                StreamWriter ss = new StreamWriter(logPath);
                ss.Write(sb);
                ss.Write(sr2 + "\n");
                ss.Write($"It took us {timeTook.ToString(@"hh\:mm\:ss")} to ananlyse the files in {FDAfile.filesPath}. \n");
                ss.Write("Thanks for trusting Iviation with your data. " + endTime.ToString());
                ss.Close();
            }
            else
            { // TODO let the user select a folder to save the file to.
                MessageBox.Show(this, $"We could not find a path { FDAfile.analysesLogsPath }. Check setupfile for the applicable company.");
            }
            
            if (filesNotAnelysed.Count > 0
                || FlightAnalysis.ParametersNotAnaliseds.Count > 0)
            {
                if (MessageBox.Show(this, $"{filesNotAnelysed.Count} files and {FlightAnalysis.ParametersNotAnaliseds.Count} could not " +
                    $"be analysed. \n Do you want to view the log file."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    // add code to open files.
                    Process.Start(logPath);
                }

            }

            SkepVliegtuigTipeKiesLys();
            Application.DoEvents();
            LoadExceedances();

            CSV = null;
            GC.Collect(2);
            Cursor.Current = Cursors.Default;
            Vordering.Value = 0;
            Vordering.Visible = false;
        }

        private void csvClose(bool clearLogDataGridView)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                

                CSV = null;
                csv.bCSVloaded = false;

                FDAfile.LogsMaakSkoon(clearLogDataGridView);
                FDAfile.csvFileName = null;
               
                LoadExceedances();
                SetTools(false);
                StatusBar(FDAfile.csvFileName);
                
                Cursor.Current = Cursors.Default;
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString() + MethodInfo.GetCurrentMethod().ToString(), FormAppMessages.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadExceedances();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //Stel kooppies aktief of nie. 
        private void csvCommands()
        {
            showGrphButton.Enabled = csv.bCSVloaded;
            viewGraph.Enabled = csv.bCSVloaded;
            closeCSV.Enabled = csv.bCSVloaded;
            graphDynamic.Enabled = csv.bCSVloaded;

            OpenCSV.Enabled = !csv.bCSVloaded;
        }

        private void csvOpen()
        {
            string filename;

            FDAfile.fileId = 0;

            try
            {
                if (ofdMain.ShowDialog(this) == DialogResult.OK)
                {
                    Application.DoEvents();
                    filename = ofdMain.FileName;

                    csvPath = Path.GetDirectoryName(filename);
                    csvFile = Path.GetFileNameWithoutExtension(filename);

                    FDAfile.csvFileName = Path.GetFileNameWithoutExtension(filename);
                    //use the new 
                    bool loaded = false;
                    FDAfile.LoadCSV(csvFile, out loaded);

                    StatusBar(FDAfile.csvFileName);

                    Application.DoEvents();

                    Cursor.Current = Cursors.WaitCursor;

                    Application.DoEvents();

                    csv.bCSVloaded = true;
                    SetTools(true);
                    LoadExceedances();
                    Cursor.Current = Cursors.Default;

                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                tsbAnalyze.Enabled = false;
                MessageBox.Show($"An Error occured trying to open file " + csvFile + " Description : " +
                    e.ToString(), FormAppMessages.ApplicationName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Analyse for eventws.
        /// </summary>
        /// <param name="singleAnalyses">If set to true, the analyses wil be done, and not saved.</param>
        private void ExceedanceFindMain(bool singleAnalyses)
        {

            //TODO : As die gebruiker die ler oop maak van die kaart af moet hy nog die kan kom doen.

            if (FDAClassLibrary.Aircraft.Id == 0 || DataToAnalyse.fdaDataTable.Rows.Count < 1)
            {
                filesNotAnelysed.Add(FDAfile.csvFileName + " Aircraft not found. ExceedanceFindMain");
                return;
            }

            if (singleAnalyses)
            {
                Cursor.Current = Cursors.WaitCursor;

                VlugLogAnaliese.kryVlugte();

                Application.DoEvents();

                FlightAnalysis.Analysis(FDAClassLibrary.Aircraft.aircraftRegistration);

                Cursor.Current = Cursors.Default;

                testForm tf = new testForm();
                tf.Text = "Flight analysed";
                tf.Show(this);

            }
            else // analiseer al die lers in die omslag
            {
                Cursor.Current = Cursors.WaitCursor;

                VlugLogAnaliese.kryVlugte();
                Application.DoEvents();
                // hierdie is nuwe kode om die probleem op te loas waar die vorige ler se data nog in die log gebruik word vir vlogende ler.
                if (VlugLogAnaliese.Log.Count < 1)
                {// sit file wat nie gelaai analyse is nie se naam hier, dan kan ek sien watter.
                    filesNotAnelysed.Add("No flights " + FDAfile.csvFileName);
                    return;

                }

                FlightAnalysis.Analysis(FDAClassLibrary.Aircraft.aircraftRegistration);

                SaveNuweAnelieses();

                FDAfile.LogsMaakSkoon(true);
               

                Cursor.Current = Cursors.Default;

            }

        }

        private void mnuOCSV_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog() { Title = "Select csv file to open."};
            string fileName = null;
            of.InitialDirectory = FDAfile.filesPath;
            
            
            if (of.ShowDialog() == DialogResult.OK)
            {
                fileName = of.FileName;
                Cursor.Current = Cursors.WaitCursor;
                LoadCsv(fileName);
                tsbAnalyze.Visible = true;
                tsbAnalyze.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            
            

            
        }
        private void mnuAbout_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(this, "This program was written by Iwan Davey and my not be copied in any way." +
            " Version 2.0.0.2 2006. For help please mail iwan@iviation.co.za", FormAppMessages.ApplicationName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Do you really wish to exit?",
                "Closeing " + FormAppMessages.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (EndDate.Value < StartDate.Value)
            {
                StartDate.Value = EndDate.Value;
            }
            SkepVliegtuigTipeKiesLys();
            Application.DoEvents();
            LoadExceedances();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (EndDate.Value < StartDate.Value)
            {
                EndDate.Value = StartDate.Value;
            }
            SkepVliegtuigTipeKiesLys();
            LoadExceedances();
        }

        private void fMain_Load(object sender, System.EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
     
            try
            {
                // check which db to laod
                FDAfile.applicationPath = Path.GetDirectoryName(Application.ExecutablePath);

                string[] files = Directory.GetFiles(FDAfile.applicationPath, "stp*");

                if (files.Length == 0)
                {
                    MessageBox.Show(this, "No configuration found", FormAppMessages.ApplicationName
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Hand);
                    Application.Exit();
                }
                else if (files.Length == 1)
                {
                    try
                    {
                        FDAfile.GetCompanyDetail(files[0]);
                        company.Text = FDAfile.company;
                        company.Enabled = false;
                    }
                    catch (ApplicationException ax)
                    {
                        MessageBox.Show(this,  ax.Message, "Iviation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                }
                else if (files.Length > 1)
                {
                    XmlDocument doc = new XmlDocument();

                    foreach (string file in files)
                    {
                        doc.Load(file);
                        setupFiles.Add(new setups() { setupFileName = file, companyName = doc.DocumentElement.SelectSingleNode("/setup/Company").InnerText });
                    }

                    company.DataSource = setupFiles;
                    company.DisplayMember = "companyName";
                    company.ValueMember = "setupFileName";

                    FDAfile.GetCompanyDetail(company.SelectedValue.ToString());

                }

                this.Text += " " + FDAfile.company;
                SetTools(false);
                Application.DoEvents();

                FdmDataConnections.StelKonneksie();

                databasePath.Text = FDAfile.databasePath;

                DateTime x;
                x = DateTime.Today.AddDays(-45);

                StartDate.Value = x;

                SkepScopeKiesLys();
                SkepVliegtuigTipeKiesLys();
                LoadExceedances();

            }

            catch (Exception ee)
            {
                cnDB1.Close();
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ee.Message, FormAppMessages.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                cnDB1.Close();
                this.Show();
                Cursor.Current = Cursors.Default;
            }
        }
        private void LoadExceedances()
        {

            #region csv loaded

            dgM.AutoGenerateColumns = false;

            if (FDAfile.fileId != 0)
            {
                dgM.DataSource = DataProsedures.laaiGebeurtenise();
                RecordCount();

                OpenCSV.Enabled = false;

                return;
            }

            #endregion

            if (FDMscope.DropDownItems.Count == 0 || Aircraft.DropDownItems.Count == 0 || !eersteGebeurtenisLaaiKla)
            {
                dgM.DataSource = null;
                //MessageBox.Show("No scope or aircraft selected. No records to show", "Flight Watch", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string vliegtuigTipes = "";
            int i = 0;

            foreach (ToolStripMenuItem menui in Aircraft.DropDownItems)
            {

                if (menui.Checked)
                {
                    if (i == 0)
                    {
                        vliegtuigTipes += "'" + menui.Text + "'";
                    }
                    else
                    {
                        vliegtuigTipes += ",";
                        vliegtuigTipes += "'" + menui.Text + "'";
                    }
                    i++;
                }


            }
            if (i == 0)
            {
                // this prevent trying to run an quary that will return zero records.
                MessageBox.Show(new Form { TopLevel = true }
                , "Please selcet an aircraft type."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                dgM.DataSource = null;
                return;
            }

            string scope = "";
            i = 0;

            
            foreach (ToolStripMenuItem menui in FDMscope.DropDownItems)
            {
                if (menui.Checked)
                {
                    if (i == 0)
                    {
                        scope += "'" + menui.Text + "'";
                    }
                    else
                    {
                        scope += ",";
                        scope += "'" + menui.Text + "'";
                    }
                    i++;
                }

            }

            if (scope == "")
            {
                dgM.DataSource = null;
                MessageBox.Show("Please select a 'Scope' to return records."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataTable dt = new DataTable();

                dgM.DataSource = DataProsedures.GetEvents(scope, vliegtuigTipes, StartDate.Value.Date.ToString("yyyy-MM-dd"), EndDate.Value.Date.ToString("yyyy-MM-dd"), tsDdOpen.Checked
                    , tsDdClosed.Checked, tsUseDate.Checked, true);

                RecordCount();

                if (dgM.Rows.Count > 0)
                {
                    OpenCSV.Enabled = true;
                }
                else
                {
                    OpenCSV.Enabled = false;
                }

                if (dgM.Rows.Count > currentRow)
                {
                    dgM.Rows[currentRow].Selected = true;
                }


            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message
                                , FormAppMessages.ApplicationName
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }

        }

        private void RecordCount()
        {
            try
            {
                if (dgM.CurrentRow != null)
                {
                    records.Text = "Rec " + (dgM.CurrentRow.Index + 1) + " of " + dgM.Rows.Count;
                }
            }
            catch (IndexOutOfRangeException ee)
            {
                MessageBox.Show(ee.Message
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

        }

        private void ShowGraph()
        {
            frmGraph g = new frmGraph();
            g.beginMerkerPosiesie = int.Parse(csv.sEXCcounter);
            g.tekenBeginMerkerLyn = csv.tekenMerkerLynGrafiek;
            g.Show(this);
        }

        private void StatusBar(string sPFile)
        {
            fileLoaded.Text = sPFile;
        }

        private void ViewSim()
        {

            fSim Sim = new fSim();
            Sim.counter = Convert.ToInt32(dgM[dgM.Columns["cFcounter"].Index, dgM.CurrentRow.Index].Value);
            Sim.Show();
            return;
            //if (csv.bCSVloaded)
            //{

            //    fSim Sim = new fSim();
            //    Sim.counter = Convert.ToInt32(dgM[dgM.Columns["cFcounter"].Index, dgM.CurrentRow.Index].Value);
            //    Sim.Show();
            //}
            //else
            //{
            //    MessageBox.Show("There is no CSV file loaded."
            //        , FormAppMessages.ApplicationName
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Information);
            //}
        }

        private void mmnuAirports_Click(object sender, System.EventArgs e)
        {
            frmAirports frmA = new frmAirports();
            frmA.ShowDialog();
        }

        private void mnuCloseCSV_Click(object sender, System.EventArgs e)
        {
            csvClose(true);
            FDAfile.SetCsvFileNotLoaded();
          
        }

        private void tsOpenCSV_Click(object sender, EventArgs e)
        {
           
            string fileName = "";
            Cursor.Current = Cursors.WaitCursor;
            if (dgM.Rows.Count != 0 && sender.GetType().Name != "MenuItem")
            {
                FDAfile.csvFileName = Convert.ToString(dgM[dgM.Columns["fileName"].Index, dgM.CurrentRow.Index].Value);
                fileName = FDAfile.filesPath + "\\" + FDAfile.csvFileName + ".csv";
            }

            if (!File.Exists(fileName))
            {
                if (MessageBox.Show($"File {fileName} could not be found in {FDAfile.filesPath} , do you want to navigate to it?"
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    OpenFileDialog o = new OpenFileDialog();
                    o.Title = "Select the file to open.";
                    o.InitialDirectory = FDAfile.filesPath;
                    if (o.ShowDialog(this) == DialogResult.OK)
                    {
                        fileName = o.FileName;

                    }
                }
                else
                {
                    return;
                }

            }

            LoadCsv(fileName);
            
            Cursor.Current = Cursors.Default;
            
        }

        private void LoadCsv(string fileName)
        {
            bool loaded;

            try
            {
                FDAfile.LoadCSV(fileName, out loaded);

                if (loaded)
                {
                    fileLoaded.Text = FDAfile.csvFileName;
                    LoadExceedances();
                }
                else
                {
                    FDAfile.SetCsvFileNotLoaded();
                }
                SetTools(loaded);
            }
            catch (Exception ex)
            {
                loaded = false;
                MessageBox.Show(ex.Message, FormAppMessages.ApplicationName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            Cursor.Current = Cursors.Default;
        }

        private void tsbFlightTracker_Click(object sender, EventArgs e)
        {
            Flights frmR = new Flights();
            frmR.Text = "Flight Log";
            frmR.ShowDialog(this);

            if (FDAfile.csvFileName != null)
            {
                fileLoaded.Text = FDAfile.csvFileName;
                LoadExceedances();
                SetTools(true);
            }
            else
            {
                fileLoaded.Text = FDAfile.csvFileName;
            }
            
            
            
        }

        private void tsBAnalyze_Click(object sender, EventArgs e)
        {
            if (VlugLogAnaliese.Log.Count > 0)
            {
                MessageBox.Show("It seems that you have analysed data already, you can't analyse a file twice."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }

            ExceedanceFindMain(true);

            if (filesNotAnelysed.Count == 0)
            {
                MessageBox.Show(new Form { TopMost = true }, "Done."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Activate();
            }
            else if (filesNotAnelysed.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in filesNotAnelysed)
                {
                    sb.AppendLine(s);
                }
                MessageBox.Show("Could not analise : " + sb.ToString()
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }

            tsbAnalyze.Enabled = false;
        }

        private void tsbGraph_Click(object sender, EventArgs e)
        {

            try
            {
                setEventParameters();
                ShowGraph();
            }
            catch (Exception xx)
            {
                MessageBox.Show("Error message " + xx.Message.ToString()
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void tsDdClosed_Click(object sender, EventArgs e)
        {
            if (checkClosed(tsDdClosed.Checked, tsDdOpen.Checked))
                LoadExceedances();
            else
                tsDdClosed.Checked = true;
        }

        private void tsDdOpen_Click(object sender, EventArgs e)
        {

            if (checkClosed(tsDdClosed.Checked, tsDdOpen.Checked))
                LoadExceedances();
            else
                tsDdOpen.Checked = true;
        }

        private bool checkClosed(bool closed, bool open)
        {
            bool b = true;

            if (!open && !closed)
            {
                MessageBox.Show("Select atleast one option for open/closed."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                b = false;
                return b;
            }
            return b;
        }

        private void tsButtonSim_Click(object sender, EventArgs e)
        {
            ViewSim();
        }

        private void mnuViewSim_Click(object sender, EventArgs e)
        {
            ViewSim();
        }

        private void mnuAircraft_Click(object sender, EventArgs e)
        {
            Form f = new fAircraft();
            f.ShowDialog();
        }

        private void fileNameMenuItem_Click(object sender, EventArgs e)
        {
            fileNameMenuItem.Checked = !fileNameMenuItem.Checked;
            dgM.Columns["FileName"].Visible = fileNameMenuItem.Checked;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {
                frmGraphNew g = new frmGraphNew();
                g.Show();

            }
            catch (Exception xx)
            {
                MessageBox.Show(this, $"Error message {xx}.", sMessages.sMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            Form fSettings = new fSettings();
            fSettings.ShowDialog();
        }

        private void mnuAnalyze_All_Click(object sender, EventArgs e)
        {
            Continues_Anelise();
        }
        private void technicalCause_Click(object sender, EventArgs e)
        {
            if (technicalCause.Checked) technicalCause.Checked = false; else technicalCause.Checked = true;

            LoadExceedances();
        }

        private void dgM_DoubleClick(object sender, EventArgs e)
        {
            currentRow = dgM.CurrentRow.Index;
            int id = Convert.ToInt32(dgM[dgM.Columns["cExcID"].Index, currentRow].Value);

            DataTable dt = DataProsedures.LoadEvent(id);

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show(this, dt.Rows.Count + " record returned. id " + id + " could not be displayed."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;

            }
            

            int ipos = dgM.RowCount;
            
            //FormCollection fc = Application.OpenForms;

            //if (fc.Count > 1)
            //{
            //    for (int i = (fc.Count); i > 1; i--)
            //    {
            //        Form selectedForm = Application.OpenForms[i - 1];
            //        selectedForm.Close();
            //    }
            //}

            if (ipos > 0)
            {
                eventView i = new eventView();
                i.eventViewID = Convert.ToInt32(dgM[dgM.Columns["cExcID"].Index, dgM.CurrentRow.Index].Value);
                i.FileId = Convert.ToInt32(dgM["FileId", dgM.CurrentRow.Index].Value);
                i.ShowDialog(this);
                LoadExceedances();
                reloadDataGridNeeded = true;
            }
        }

        private void dgM_CurrentCellChanged(object sender, EventArgs e)
        {
            RecordCount();
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            if (dgM.Rows.Count < 1)
            {
                return;
            }
            if (MessageBox.Show("Do you want to delete the file that contain this event and all its associated data? You Will need" +
                " to re-analyse the file."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int fileId = Convert.ToInt32(dgM["FileId", dgM.CurrentRow.Index].Value);
                FDAfile.LerEnAlleVerwysing_UitVee(fileId);
                LoadExceedances();
            }

        }

        private void SaveSingleAnalysesResult_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (VlugLogAnaliese.Log.Count < 1)
            {
                MessageBox.Show("There is no data to save, make sure you have hit that analyse button."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }

            SaveNuweAnelieses();

            Cursor.Current = Cursors.Default;
            SaveSingleAnalysesResult.Enabled = false;
            MessageBox.Show("Data has been saved."
                            , FormAppMessages.ApplicationName
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
        }

        private void SaveNuweAnelieses()
        {
            //Die nuwe ler word bygevoeg as deel van die procedure.
            for (int i = 0; i < VlugLogAnaliese.Log.Count; i++)
            {
                VlugLogAnaliese.VoegLog(VlugLogAnaliese.Log[i].vlugNommer,
                                        VlugLogAnaliese.Log[i].opStygDatum,
                                        VlugLogAnaliese.Log[i].opStygTyd,
                                        VlugLogAnaliese.Log[i].opStygLughawe,
                                        VlugLogAnaliese.Log[i].opStygAanlobaan,
                                        VlugLogAnaliese.Log[i].opStygMerker,
                                        VlugLogAnaliese.Log[i].landingsDatum,
                                        VlugLogAnaliese.Log[i].landingTyd,
                                        VlugLogAnaliese.Log[i].landingsLughawe,
                                        VlugLogAnaliese.Log[i].landingsAanlobaan,
                                        VlugLogAnaliese.Log[i].landingMerker,
                                        0);

            }

            for (int i = 0; i < FlightAnalysis.eventLog.Count; i++)
            {
                //string d = VeiligheidsAneliese.eventLog[i].datum;

                VlugLogAnaliese.voegGebeurtenis(FlightAnalysis.eventLog[i].vlugNommer
                                               , FlightAnalysis.eventLog[i].gebeurtenis
                                               , int.Parse(FlightAnalysis.eventLog[i].merker.ToString())
                                               , FlightAnalysis.eventLog[i].flightPhase
                                               , FlightAnalysis.eventLog[i].klas
                                               , FlightAnalysis.eventLog[i].cause
                                               , FlightAnalysis.eventLog[i].datum
                                               , FlightAnalysis.eventLog[i].tyd
                                               , FlightAnalysis.eventLog[i].nota
                                               , FlightAnalysis.eventLog[i].scopeId);
            }
        }

        private void dataRecovery_Click(object sender, EventArgs e)
        {
            dgM.AutoGenerateColumns = true;
            DataTable t = DataProsedures.LaaiDataHerwinVerigting(StartDate.Value, EndDate.Value, "SAAT", "LTMI");
            dgM.DataSource = t;
            FDAClassLibrary.Reporting.BereiTabelDataHerwin(t);
            MessageBox.Show("The table has been prepared."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void dataRecoveryLTMI_Click(object sender, EventArgs e)
        {
            dgM.AutoGenerateColumns = true;
            DataTable t = DataProsedures.LaaiDataHerwinVerigting(StartDate.Value, EndDate.Value, "", "LTMI");
            dgM.DataSource = t;
            FDAClassLibrary.Reporting.BereiTabelDataHerwin(t);
            MessageBox.Show("The table has been prepared."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void dataRecoverySAAT_Click(object sender, EventArgs e)
        {
            dgM.AutoGenerateColumns = true;
            DataTable t = DataProsedures.LaaiDataHerwinVerigting(StartDate.Value, EndDate.Value, "SAAT", "");
            dgM.DataSource = t;
            FDAClassLibrary.Reporting.BereiTabelDataHerwin(t);
            MessageBox.Show("The table has been prepared."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {

            SkepVliegtuigTipeKiesLys();
            LoadExceedances();

            dgM.AutoGenerateColumns = false;

            var dgc = new DataGridViewTextBoxColumn();
            dgc.HeaderText = "Exc";
            dgc.DataPropertyName = "Description";

            dgM.Columns.AddRange(new DataGridViewColumn[] { dgc });

        }

        private void flightsFlown_Click(object sender, EventArgs e)
        {
            FlightsFlown flightsFlown = new FlightsFlown();
            flightsFlown.Show();
        }

        private void tsUseDate_Click(object sender, EventArgs e)
        {
            StartDate.Value = DateTime.Today.AddYears(-1);
            SkepVliegtuigTipeKiesLys();
            LoadExceedances();
        }

        private void mnuDate_Click(object sender, EventArgs e)
        {
            mnuDate.Checked = !mnuDate.Checked;
            dgM.Columns["cDateOfExc"].Visible = mnuDate.Checked;

        }

        private void SkepScopeKiesLys()
        {
            DataTable dt = DataProsedures.LaaiScope();

            ToolStripMenuItem[] mi = new ToolStripMenuItem[dt.Rows.Count];
            FDMscope.DropDown.Items.Clear();
            for (int i = 0; i < mi.Length; i++)
            {
                mi[i] = new ToolStripMenuItem();
                mi[i].Name = dt.Rows[i][1].ToString();
                mi[i].CheckOnClick = true;
                if (i == 0)
                {
                    mi[0].Checked = true;
                }

                mi[i].Text = dt.Rows[i][1].ToString();
                mi[i].Click += new EventHandler(scopeMenuItem_Click);
            }

            FDMscope.DropDownItems.AddRange(mi);

        }

        private void PrepareReportN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int checkedCount = 0;
            string checkedMenuItem = "";

            foreach (ToolStripMenuItem menui in FDMscope.DropDownItems)
            {
                if (menui.Checked)
                {
                    checkedMenuItem = menui.Text;
                    checkedCount++;
                }

            }

            if (checkedCount > 1 || checkedMenuItem == "")
            {
                MessageBox.Show("You have no or more than one scope selected. A report can only be prepared for one scope item. " +
                    "Please select / deselect the one scope item and try again."
                    , FormAppMessages.ApplicationName
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }

            SetDates.GetStartEndDateYear(EndDate.Value.Date, out DateTime yearStartDate, out DateTime yearEndDate);

            MenuItem s = sender as MenuItem;

            DialogResult dr = MessageBox.Show($"Use {yearStartDate.ToString("dd MMM yy")} to {yearEndDate.ToString("dd MMM yy")} ? " +
                $"Select No to use selected dates.", FormAppMessages.ApplicationName + $" {s.Text}"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Reporting.PrepareSMSReport(yearStartDate.Date, yearEndDate.Date, checkedMenuItem, out string foutBoodskap);

            }
            else if (dr == DialogResult.No)
            {
                Reporting.PrepareSMSReport(StartDate.Value.Date, EndDate.Value.Date, checkedMenuItem, out string foutBoodskap);
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }

            MessageBox.Show(this, "Report has been prepared"
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);

            Cursor.Current = Cursors.Default;


        }
        private void ShowReportCenter_Click(object sender, EventArgs e)
        {
            Process.Start(FDAfile.reportPath);
        }

        private void PrepareFlightsAnalyzedReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SetDates.GetStartEndDateMonth(EndDate.Value.Date, out DateTime monthStartDate, out DateTime monthEndDate);

            DialogResult dr = MessageBox.Show($"Use {monthStartDate.ToString("dd MMM yy")} to {monthEndDate.ToString("dd MMM yy")} ? " +
                $"Select No to use selected dates.", FormAppMessages.ApplicationName
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Reporting.PrepareFlightsAnalyzedReport(monthStartDate.Date, monthEndDate.Date);
            }
            else if (dr == DialogResult.No)
            {
                Reporting.PrepareFlightsAnalyzedReport(StartDate.Value.Date, EndDate.Value.Date);
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }

            Cursor.Current = Cursors.Default;
            MessageBox.Show(this
                , "Report prepared."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void prepareNotesReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SetDates.GetStartEndDateMonth(EndDate.Value.Date, out DateTime monthStartDate, out DateTime monthEndDate);

            DialogResult dr = MessageBox.Show($"Use {monthStartDate.ToString("dd MMM yy")} to {monthEndDate.ToString("dd MMM yy")} ? " +
                $"Select No to use selected dates.", FormAppMessages.ApplicationName
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Reporting.PrepareNoteReport(monthStartDate, monthEndDate, "safety");

            }
            else if (dr == DialogResult.No)
            {
                Reporting.PrepareNoteReport(StartDate.Value.Date, EndDate.Value, "safety");
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }

            Cursor.Current = Cursors.Default;

            MessageBox.Show(this
                , "Report prepared."
                , FormAppMessages.ApplicationName
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        /// <summary>
        /// Sit die vliegtuig tipe by die kieslys gebaseer op data van tipes in die gespesiseerde tyd.
        /// </summary>
        private void SkepVliegtuigTipeKiesLys()
        {
            Aircraft.DropDownItems.Clear();
            DataTable dt = DataProsedures.LoadAircraftType(StartDate.Value.ToString("yyyy-MM-dd"), EndDate.Value.ToString("yyyy-MM-dd"));

            ToolStripMenuItem[] mi = new ToolStripMenuItem[dt.Rows.Count];

            for (int i = 0; i < mi.Length; i++)
            {
                mi[i] = new ToolStripMenuItem();
                mi[i].Name = dt.Rows[i][0].ToString();
                mi[i].CheckOnClick = true;
                mi[i].Checked = true;
                mi[i].Text = dt.Rows[i][0].ToString();
                mi[i].Click += new EventHandler(scopeMenuItem_Click);
            }

            Aircraft.DropDownItems.AddRange(mi);
            eersteGebeurtenisLaaiKla = true;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FDAfile.company is null)
            {
                return;
            }
            
            FDAfile.GetCompanyDetail(company.SelectedValue.ToString());
            this.Text = FDAfile.company;

            SetTools(false);
            Application.DoEvents();

            FdmDataConnections.StelKonneksie();

            databasePath.Text = FDAfile.databasePath;

            DateTime x;
            x = DateTime.Today.AddDays(-45);

            StartDate.Value = x;

            SkepScopeKiesLys();
            SkepVliegtuigTipeKiesLys();
            LoadExceedances();


        }

        private void frmMainFOQA_FormClosed(object sender, FormClosedEventArgs e)
        {

            FdmDataConnections.CloseAllConnections();
            
        }

        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("was dit erg");
        }

        /// <summary>
        /// Sit die scope by kieslys gebaseer op beskibare scope.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scopeMenuItem_Click(object sender, EventArgs e)
        {

            LoadExceedances();

        }

        /// <summary>
        /// This will distinguis whether the files is opend as a single file, or opend from the main screen. If no counter position is available, a set counter position of 250 will be set.
        /// </summary>
        private void setEventParameters()
        {

            if (dgM.Rows.Count > 0)
            {
                string FileName = Convert.ToString(dgM["cExcId", dgM.CurrentRow.Index].Value); // laai die excId
                csv.sExcID = Convert.ToString(dgM["cExcId", dgM.CurrentRow.Index].Value);
                csv.sEXCcounter = dgM[dgM.Columns["cFcounter"].Index, dgM.CurrentRow.Index].Value.ToString();
                csv.sExceedance = Convert.ToString(dgM["Exceedance", dgM.CurrentRow.Index].Value);
                csv.sEXCnote = Convert.ToString(dgM["Note", dgM.CurrentRow.Index].Value);
                csv.dtEXCDate = Convert.ToDateTime(dgM["Date", dgM.CurrentRow.Index].Value);
                csv.tekenMerkerLynGrafiek = true;

            }
            else
            {
                csv.sExcID = "";
                csv.sEXCcounter = "250";
                csv.sExceedance = "No Exceedance";
                csv.sEXCnote = "";
                csv.dtEXCDate = DateTime.Now;
            }
        }

        private IList<setups> setupFiles = new List<setups>();
    }

    public class setups
    {
        public string setupFileName { get; set; }
        public string companyName { get; set; }
    }
}

