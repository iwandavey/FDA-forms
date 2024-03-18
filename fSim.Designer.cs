namespace FOQA
{
    partial class fSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSim));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.EADI = new EADI.EADI733();
            this.EHSI = new EHSI.EHSI();
            this.GFlap = new B_737.AGauge();
            this.GE1N1 = new B_737.AGauge();
            this.lE1N1 = new System.Windows.Forms.Label();
            this.GE2N1 = new B_737.AGauge();
            this.lE2N1 = new System.Windows.Forms.Label();
            this.lGearNose = new System.Windows.Forms.Label();
            this.lGearLeft = new System.Windows.Forms.Label();
            this.lGearRight = new System.Windows.Forms.Label();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsButtonStopPause = new System.Windows.Forms.ToolStripButton();
            this.tsButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.tkBarPosition = new System.Windows.Forms.TrackBar();
            this.tkBarSpeed = new System.Windows.Forms.TrackBar();
            this.statBar.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // EADI
            // 
            this.EADI.ALT = 0;
            this.EADI.CAS = 0;
            this.EADI.CASfontsize = 12;
            this.EADI.FMAcmd = null;
            this.EADI.FMApitch = null;
            this.EADI.FMAroll = null;
            this.EADI.FMAthrottle = null;
            this.EADI.GroundSpeed = ((short)(0));
            this.EADI.ILS = true;
            this.EADI.ILSgs = 0F;
            this.EADI.ILSloc = 0F;
            this.EADI.LOC = 0;
            this.EADI.Location = new System.Drawing.Point(25, 56);
            this.EADI.MACHfontsize = 10;
            this.EADI.MachNo = "0";
            this.EADI.Name = "EADI";
            this.EADI.PitchValue = 0F;
            this.EADI.RA = 0;
            this.EADI.RollValue = 0F;
            this.EADI.Size = new System.Drawing.Size(386, 312);
            this.EADI.TabIndex = 3;
            this.EADI.Text = "eadI7331";
            this.EADI.VS = 0;
            // 
            // EHSI
            // 
            this.EHSI.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EHSI.HDG = 0;
            this.EHSI.Location = new System.Drawing.Point(25, 374);
            this.EHSI.Name = "EHSI";
            this.EHSI.Size = new System.Drawing.Size(386, 332);
            this.EHSI.TabIndex = 4;
            this.EHSI.Text = "ehsi1";
            this.EHSI.WindDirection = 0;
            this.EHSI.WindVelocity = 0;
            // 
            // GFlap
            // 
            this.GFlap.BackColor = System.Drawing.Color.Black;
            this.GFlap.BaseArcColor = System.Drawing.Color.White;
            this.GFlap.BaseArcRadius = 40;
            this.GFlap.BaseArcStart = 180;
            this.GFlap.BaseArcSweep = 270;
            this.GFlap.BaseArcWidth = 2;
            this.GFlap.Cap_Idx = ((byte)(1));
            this.GFlap.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.GFlap.CapPosition = new System.Drawing.Point(50, 50);
            this.GFlap.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(50, 50),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.GFlap.CapsText = new string[] {
        "",
        "Flap",
        "",
        "",
        ""};
            this.GFlap.CapText = "Flap";
            this.GFlap.Center = new System.Drawing.Point(72, 72);
            this.GFlap.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GFlap.Location = new System.Drawing.Point(417, 202);
            this.GFlap.MaxValue = 40F;
            this.GFlap.MinValue = 0F;
            this.GFlap.Name = "GFlap";
            this.GFlap.NeedleColor1 = B_737.AGauge.NeedleColorEnum.Yellow;
            this.GFlap.NeedleColor2 = System.Drawing.Color.Yellow;
            this.GFlap.NeedleRadius = 40;
            this.GFlap.NeedleType = 0;
            this.GFlap.NeedleWidth = 2;
            this.GFlap.Range_Idx = ((byte)(0));
            this.GFlap.RangeColor = System.Drawing.Color.Transparent;
            this.GFlap.RangeEnabled = true;
            this.GFlap.RangeEndValue = 40F;
            this.GFlap.RangeInnerRadius = 40;
            this.GFlap.RangeOuterRadius = 40;
            this.GFlap.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.GFlap.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.GFlap.RangesEndValue = new float[] {
        40F,
        400F,
        0F,
        0F,
        0F};
            this.GFlap.RangesInnerRadius = new int[] {
        40,
        70,
        70,
        70,
        70};
            this.GFlap.RangesOuterRadius = new int[] {
        40,
        80,
        80,
        80,
        80};
            this.GFlap.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.GFlap.RangeStartValue = -100F;
            this.GFlap.ScaleLinesInterColor = System.Drawing.Color.Transparent;
            this.GFlap.ScaleLinesInterInnerRadius = 40;
            this.GFlap.ScaleLinesInterOuterRadius = 40;
            this.GFlap.ScaleLinesInterWidth = 1;
            this.GFlap.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.GFlap.ScaleLinesMajorInnerRadius = 45;
            this.GFlap.ScaleLinesMajorOuterRadius = 40;
            this.GFlap.ScaleLinesMajorStepValue = 5F;
            this.GFlap.ScaleLinesMajorWidth = 2;
            this.GFlap.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.GFlap.ScaleLinesMinorInnerRadius = 40;
            this.GFlap.ScaleLinesMinorNumOf = 9;
            this.GFlap.ScaleLinesMinorOuterRadius = 40;
            this.GFlap.ScaleLinesMinorWidth = 1;
            this.GFlap.ScaleNumbersColor = System.Drawing.Color.White;
            this.GFlap.ScaleNumbersFormat = null;
            this.GFlap.ScaleNumbersRadius = 55;
            this.GFlap.ScaleNumbersRotation = 0;
            this.GFlap.ScaleNumbersStartScaleLine = 0;
            this.GFlap.ScaleNumbersStepScaleLines = 1;
            this.GFlap.Size = new System.Drawing.Size(145, 145);
            this.GFlap.TabIndex = 5;
            this.GFlap.Text = "aGauge1";
            this.GFlap.Value = 0F;
            // 
            // GE1N1
            // 
            this.GE1N1.BackColor = System.Drawing.Color.Black;
            this.GE1N1.BaseArcColor = System.Drawing.Color.White;
            this.GE1N1.BaseArcRadius = 50;
            this.GE1N1.BaseArcStart = 320;
            this.GE1N1.BaseArcSweep = 270;
            this.GE1N1.BaseArcWidth = 2;
            this.GE1N1.Cap_Idx = ((byte)(1));
            this.GE1N1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.GE1N1.CapPosition = new System.Drawing.Point(10, 10);
            this.GE1N1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.GE1N1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.GE1N1.CapText = "";
            this.GE1N1.Center = new System.Drawing.Point(70, 70);
            this.GE1N1.Location = new System.Drawing.Point(417, 56);
            this.GE1N1.MaxValue = 110F;
            this.GE1N1.MinValue = 0F;
            this.GE1N1.Name = "GE1N1";
            this.GE1N1.NeedleColor1 = B_737.AGauge.NeedleColorEnum.Yellow;
            this.GE1N1.NeedleColor2 = System.Drawing.Color.Olive;
            this.GE1N1.NeedleRadius = 50;
            this.GE1N1.NeedleType = 0;
            this.GE1N1.NeedleWidth = 2;
            this.GE1N1.Range_Idx = ((byte)(0));
            this.GE1N1.RangeColor = System.Drawing.Color.Lime;
            this.GE1N1.RangeEnabled = true;
            this.GE1N1.RangeEndValue = 102F;
            this.GE1N1.RangeInnerRadius = 45;
            this.GE1N1.RangeOuterRadius = 50;
            this.GE1N1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.GE1N1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.GE1N1.RangesEndValue = new float[] {
        102F,
        106F,
        0F,
        0F,
        0F};
            this.GE1N1.RangesInnerRadius = new int[] {
        45,
        45,
        70,
        70,
        70};
            this.GE1N1.RangesOuterRadius = new int[] {
        50,
        50,
        80,
        80,
        80};
            this.GE1N1.RangesStartValue = new float[] {
        22F,
        102F,
        0F,
        0F,
        0F};
            this.GE1N1.RangeStartValue = 22F;
            this.GE1N1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.GE1N1.ScaleLinesInterInnerRadius = 50;
            this.GE1N1.ScaleLinesInterOuterRadius = 55;
            this.GE1N1.ScaleLinesInterWidth = 1;
            this.GE1N1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.GE1N1.ScaleLinesMajorInnerRadius = 50;
            this.GE1N1.ScaleLinesMajorOuterRadius = 58;
            this.GE1N1.ScaleLinesMajorStepValue = 10F;
            this.GE1N1.ScaleLinesMajorWidth = 2;
            this.GE1N1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.GE1N1.ScaleLinesMinorInnerRadius = 50;
            this.GE1N1.ScaleLinesMinorNumOf = 9;
            this.GE1N1.ScaleLinesMinorOuterRadius = 52;
            this.GE1N1.ScaleLinesMinorWidth = 1;
            this.GE1N1.ScaleNumbersColor = System.Drawing.Color.White;
            this.GE1N1.ScaleNumbersFormat = null;
            this.GE1N1.ScaleNumbersRadius = 35;
            this.GE1N1.ScaleNumbersRotation = 0;
            this.GE1N1.ScaleNumbersStartScaleLine = 0;
            this.GE1N1.ScaleNumbersStepScaleLines = 1;
            this.GE1N1.Size = new System.Drawing.Size(141, 140);
            this.GE1N1.TabIndex = 6;
            this.GE1N1.Text = "aGauge1";
            this.GE1N1.Value = 0F;
            // 
            // lE1N1
            // 
            this.lE1N1.AutoSize = true;
            this.lE1N1.BackColor = System.Drawing.Color.Black;
            this.lE1N1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lE1N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lE1N1.ForeColor = System.Drawing.Color.LawnGreen;
            this.lE1N1.Location = new System.Drawing.Point(474, 71);
            this.lE1N1.Name = "lE1N1";
            this.lE1N1.Size = new System.Drawing.Size(37, 19);
            this.lE1N1.TabIndex = 7;
            this.lE1N1.Text = "100";
            this.lE1N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GE2N1
            // 
            this.GE2N1.BackColor = System.Drawing.Color.Black;
            this.GE2N1.BaseArcColor = System.Drawing.Color.White;
            this.GE2N1.BaseArcRadius = 50;
            this.GE2N1.BaseArcStart = 320;
            this.GE2N1.BaseArcSweep = 270;
            this.GE2N1.BaseArcWidth = 2;
            this.GE2N1.Cap_Idx = ((byte)(1));
            this.GE2N1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.GE2N1.CapPosition = new System.Drawing.Point(10, 10);
            this.GE2N1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.GE2N1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.GE2N1.CapText = "";
            this.GE2N1.Center = new System.Drawing.Point(70, 70);
            this.GE2N1.Location = new System.Drawing.Point(568, 56);
            this.GE2N1.MaxValue = 110F;
            this.GE2N1.MinValue = 0F;
            this.GE2N1.Name = "GE2N1";
            this.GE2N1.NeedleColor1 = B_737.AGauge.NeedleColorEnum.Yellow;
            this.GE2N1.NeedleColor2 = System.Drawing.Color.Olive;
            this.GE2N1.NeedleRadius = 50;
            this.GE2N1.NeedleType = 0;
            this.GE2N1.NeedleWidth = 2;
            this.GE2N1.Range_Idx = ((byte)(0));
            this.GE2N1.RangeColor = System.Drawing.Color.Lime;
            this.GE2N1.RangeEnabled = true;
            this.GE2N1.RangeEndValue = 102F;
            this.GE2N1.RangeInnerRadius = 45;
            this.GE2N1.RangeOuterRadius = 50;
            this.GE2N1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.GE2N1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.GE2N1.RangesEndValue = new float[] {
        102F,
        106F,
        0F,
        0F,
        0F};
            this.GE2N1.RangesInnerRadius = new int[] {
        45,
        45,
        70,
        70,
        70};
            this.GE2N1.RangesOuterRadius = new int[] {
        50,
        50,
        80,
        80,
        80};
            this.GE2N1.RangesStartValue = new float[] {
        22F,
        102F,
        0F,
        0F,
        0F};
            this.GE2N1.RangeStartValue = 22F;
            this.GE2N1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.GE2N1.ScaleLinesInterInnerRadius = 50;
            this.GE2N1.ScaleLinesInterOuterRadius = 55;
            this.GE2N1.ScaleLinesInterWidth = 1;
            this.GE2N1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.GE2N1.ScaleLinesMajorInnerRadius = 50;
            this.GE2N1.ScaleLinesMajorOuterRadius = 58;
            this.GE2N1.ScaleLinesMajorStepValue = 10F;
            this.GE2N1.ScaleLinesMajorWidth = 2;
            this.GE2N1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.GE2N1.ScaleLinesMinorInnerRadius = 50;
            this.GE2N1.ScaleLinesMinorNumOf = 9;
            this.GE2N1.ScaleLinesMinorOuterRadius = 52;
            this.GE2N1.ScaleLinesMinorWidth = 1;
            this.GE2N1.ScaleNumbersColor = System.Drawing.Color.White;
            this.GE2N1.ScaleNumbersFormat = null;
            this.GE2N1.ScaleNumbersRadius = 35;
            this.GE2N1.ScaleNumbersRotation = 0;
            this.GE2N1.ScaleNumbersStartScaleLine = 0;
            this.GE2N1.ScaleNumbersStepScaleLines = 1;
            this.GE2N1.Size = new System.Drawing.Size(141, 140);
            this.GE2N1.TabIndex = 8;
            this.GE2N1.Text = "aGauge1";
            this.GE2N1.Value = 0F;
            // 
            // lE2N1
            // 
            this.lE2N1.AutoSize = true;
            this.lE2N1.BackColor = System.Drawing.Color.Black;
            this.lE2N1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lE2N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lE2N1.ForeColor = System.Drawing.Color.LawnGreen;
            this.lE2N1.Location = new System.Drawing.Point(625, 71);
            this.lE2N1.Name = "lE2N1";
            this.lE2N1.Size = new System.Drawing.Size(37, 19);
            this.lE2N1.TabIndex = 9;
            this.lE2N1.Text = "100";
            this.lE2N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lGearNose
            // 
            this.lGearNose.BackColor = System.Drawing.Color.DimGray;
            this.lGearNose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lGearNose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGearNose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGearNose.Location = new System.Drawing.Point(615, 214);
            this.lGearNose.Name = "lGearNose";
            this.lGearNose.Size = new System.Drawing.Size(45, 23);
            this.lGearNose.TabIndex = 10;
            this.lGearNose.Text = "Nose";
            this.lGearNose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lGearLeft
            // 
            this.lGearLeft.BackColor = System.Drawing.Color.DimGray;
            this.lGearLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lGearLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGearLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGearLeft.Location = new System.Drawing.Point(591, 247);
            this.lGearLeft.Name = "lGearLeft";
            this.lGearLeft.Size = new System.Drawing.Size(45, 23);
            this.lGearLeft.TabIndex = 11;
            this.lGearLeft.Text = "Left";
            this.lGearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lGearRight
            // 
            this.lGearRight.BackColor = System.Drawing.Color.DimGray;
            this.lGearRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lGearRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGearRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGearRight.Location = new System.Drawing.Point(642, 247);
            this.lGearRight.Name = "lGearRight";
            this.lGearRight.Size = new System.Drawing.Size(45, 23);
            this.lGearRight.TabIndex = 12;
            this.lGearRight.Text = "Right";
            this.lGearRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statBar
            // 
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsCounter});
            this.statBar.Location = new System.Drawing.Point(0, 731);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(736, 22);
            this.statBar.TabIndex = 13;
            this.statBar.Text = "Sim";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            this.tsProgress.Value = 50;
            this.tsProgress.Visible = false;
            // 
            // tsCounter
            // 
            this.tsCounter.Name = "tsCounter";
            this.tsCounter.Size = new System.Drawing.Size(27, 17);
            this.tsCounter.Text = "Sim";
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonStopPause,
            this.tsButtonPlay});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(736, 53);
            this.tsMain.TabIndex = 14;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsButtonStopPause
            // 
            this.tsButtonStopPause.BackColor = System.Drawing.Color.Transparent;
            this.tsButtonStopPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonStopPause.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonStopPause.Image")));
            this.tsButtonStopPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonStopPause.Name = "tsButtonStopPause";
            this.tsButtonStopPause.Size = new System.Drawing.Size(36, 50);
            this.tsButtonStopPause.Text = "Stop";
            this.tsButtonStopPause.ToolTipText = "Stop, pause simulation.";
            this.tsButtonStopPause.Click += new System.EventHandler(this.tsButtonStopPause_Click);
            // 
            // tsButtonPlay
            // 
            this.tsButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.tsButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonPlay.Image")));
            this.tsButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonPlay.Name = "tsButtonPlay";
            this.tsButtonPlay.Size = new System.Drawing.Size(36, 36);
            this.tsButtonPlay.ToolTipText = "Start simulation.";
            this.tsButtonPlay.Click += new System.EventHandler(this.tsButtonPlay_Click);
            // 
            // tkBarPosition
            // 
            this.tkBarPosition.AutoSize = false;
            this.tkBarPosition.Location = new System.Drawing.Point(95, 0);
            this.tkBarPosition.Name = "tkBarPosition";
            this.tkBarPosition.Size = new System.Drawing.Size(416, 39);
            this.tkBarPosition.TabIndex = 15;
            this.tkBarPosition.TickFrequency = 50;
            this.tkBarPosition.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkBarPosition.Scroll += new System.EventHandler(this.tkBar_Scroll);
            // 
            // tkBarSpeed
            // 
            this.tkBarSpeed.AutoSize = false;
            this.tkBarSpeed.LargeChange = 100;
            this.tkBarSpeed.Location = new System.Drawing.Point(517, 0);
            this.tkBarSpeed.Maximum = 1000;
            this.tkBarSpeed.Minimum = 10;
            this.tkBarSpeed.Name = "tkBarSpeed";
            this.tkBarSpeed.Size = new System.Drawing.Size(192, 39);
            this.tkBarSpeed.SmallChange = 10;
            this.tkBarSpeed.TabIndex = 16;
            this.tkBarSpeed.TickFrequency = 100;
            this.tkBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkBarSpeed.Value = 10;
            // 
            // fSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 753);
            this.Controls.Add(this.tkBarSpeed);
            this.Controls.Add(this.tkBarPosition);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.lGearRight);
            this.Controls.Add(this.lGearLeft);
            this.Controls.Add(this.lGearNose);
            this.Controls.Add(this.lE2N1);
            this.Controls.Add(this.GE2N1);
            this.Controls.Add(this.lE1N1);
            this.Controls.Add(this.GE1N1);
            this.Controls.Add(this.GFlap);
            this.Controls.Add(this.EHSI);
            this.Controls.Add(this.EADI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSim";
            this.Text = "Sim";
            this.Load += new System.EventHandler(this.fSim_Load);
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private EADI.EADI733 EADI;
        private EHSI.EHSI EHSI;
        private B_737.AGauge GFlap;
        private B_737.AGauge GE1N1;
        private System.Windows.Forms.Label lE1N1;
        private B_737.AGauge GE2N1;
        private System.Windows.Forms.Label lE2N1;
        private System.Windows.Forms.Label lGearNose;
        private System.Windows.Forms.Label lGearLeft;
        private System.Windows.Forms.Label lGearRight;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsButtonPlay;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsCounter;
        private System.Windows.Forms.TrackBar tkBarPosition;
        private System.Windows.Forms.ToolStripButton tsButtonStopPause;
        private System.Windows.Forms.TrackBar tkBarSpeed;
    }
}