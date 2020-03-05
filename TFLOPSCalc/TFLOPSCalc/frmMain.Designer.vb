<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpCalculator = New System.Windows.Forms.TabPage()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lbl5kMHz = New System.Windows.Forms.Label()
        Me.lbl1MHz = New System.Windows.Forms.Label()
        Me.tbClockSpeed = New System.Windows.Forms.TrackBar()
        Me.lblGFLOPS = New System.Windows.Forms.Label()
        Me.lblTFLOPS = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.nudComputeUnits = New System.Windows.Forms.NumericUpDown()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.cbUarch = New System.Windows.Forms.ComboBox()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.tpUnknownClock = New System.Windows.Forms.TabPage()
        Me.tpUnknownCU = New System.Windows.Forms.TabPage()
        Me.tpKnowCompute = New System.Windows.Forms.TabPage()
        Me.tpAbout = New System.Windows.Forms.TabPage()
        Me.llTFLOPSRepo = New System.Windows.Forms.LinkLabel()
        Me.llMyGithub = New System.Windows.Forms.LinkLabel()
        Me.pbLouise = New System.Windows.Forms.PictureBox()
        Me.llTwitter = New System.Windows.Forms.LinkLabel()
        Me.pcKirby = New System.Windows.Forms.PictureBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.nudComputeUnitsa = New System.Windows.Forms.NumericUpDown()
        Me.lblStep3a = New System.Windows.Forms.Label()
        Me.txtCompute = New System.Windows.Forms.TextBox()
        Me.lblReqClock = New System.Windows.Forms.Label()
        Me.lblResulta = New System.Windows.Forms.Label()
        Me.lblTFLOPSa = New System.Windows.Forms.Label()
        Me.lblStep1a = New System.Windows.Forms.Label()
        Me.cbUarcha = New System.Windows.Forms.ComboBox()
        Me.lblStep2a = New System.Windows.Forms.Label()
        Me.lblStep2b = New System.Windows.Forms.Label()
        Me.cbUarchb = New System.Windows.Forms.ComboBox()
        Me.lblStep1b = New System.Windows.Forms.Label()
        Me.lblClockb = New System.Windows.Forms.Label()
        Me.lbl5KMHzb = New System.Windows.Forms.Label()
        Me.lbl1MHzb = New System.Windows.Forms.Label()
        Me.tbClockSpeedb = New System.Windows.Forms.TrackBar()
        Me.lblTFLOPSb = New System.Windows.Forms.Label()
        Me.lblReqCU = New System.Windows.Forms.Label()
        Me.lblResultb = New System.Windows.Forms.Label()
        Me.txtComputeb = New System.Windows.Forms.TextBox()
        Me.lblStep3b = New System.Windows.Forms.Label()
        Me.tcMain.SuspendLayout()
        Me.tpCalculator.SuspendLayout()
        CType(Me.tbClockSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComputeUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpUnknownClock.SuspendLayout()
        Me.tpUnknownCU.SuspendLayout()
        Me.tpAbout.SuspendLayout()
        CType(Me.pbLouise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcKirby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComputeUnitsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbClockSpeedb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpCalculator)
        Me.tcMain.Controls.Add(Me.tpUnknownClock)
        Me.tcMain.Controls.Add(Me.tpUnknownCU)
        Me.tcMain.Controls.Add(Me.tpKnowCompute)
        Me.tcMain.Controls.Add(Me.tpAbout)
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(860, 472)
        Me.tcMain.TabIndex = 0
        '
        'tpCalculator
        '
        Me.tpCalculator.Controls.Add(Me.lblClock)
        Me.tpCalculator.Controls.Add(Me.lbl5kMHz)
        Me.tpCalculator.Controls.Add(Me.lbl1MHz)
        Me.tpCalculator.Controls.Add(Me.tbClockSpeed)
        Me.tpCalculator.Controls.Add(Me.lblGFLOPS)
        Me.tpCalculator.Controls.Add(Me.lblTFLOPS)
        Me.tpCalculator.Controls.Add(Me.lblResult)
        Me.tpCalculator.Controls.Add(Me.lblStep3)
        Me.tpCalculator.Controls.Add(Me.nudComputeUnits)
        Me.tpCalculator.Controls.Add(Me.lblStep2)
        Me.tpCalculator.Controls.Add(Me.cbUarch)
        Me.tpCalculator.Controls.Add(Me.lblStep1)
        Me.tpCalculator.Location = New System.Drawing.Point(4, 22)
        Me.tpCalculator.Name = "tpCalculator"
        Me.tpCalculator.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCalculator.Size = New System.Drawing.Size(852, 446)
        Me.tpCalculator.TabIndex = 0
        Me.tpCalculator.Text = "Calculator"
        Me.tpCalculator.UseVisualStyleBackColor = True
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(9, 265)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(105, 13)
        Me.lblClock.TabIndex = 12
        Me.lblClock.Text = "Clock Speed: 1 MHz"
        '
        'lbl5kMHz
        '
        Me.lbl5kMHz.AutoSize = True
        Me.lbl5kMHz.Location = New System.Drawing.Point(790, 225)
        Me.lbl5kMHz.Name = "lbl5kMHz"
        Me.lbl5kMHz.Size = New System.Drawing.Size(56, 13)
        Me.lbl5kMHz.TabIndex = 11
        Me.lbl5kMHz.Text = "5000 MHz"
        '
        'lbl1MHz
        '
        Me.lbl1MHz.AutoSize = True
        Me.lbl1MHz.Location = New System.Drawing.Point(9, 225)
        Me.lbl1MHz.Name = "lbl1MHz"
        Me.lbl1MHz.Size = New System.Drawing.Size(38, 13)
        Me.lbl1MHz.TabIndex = 10
        Me.lbl1MHz.Text = "1 MHz"
        '
        'tbClockSpeed
        '
        Me.tbClockSpeed.Location = New System.Drawing.Point(12, 177)
        Me.tbClockSpeed.Maximum = 5000
        Me.tbClockSpeed.Minimum = 1
        Me.tbClockSpeed.Name = "tbClockSpeed"
        Me.tbClockSpeed.Size = New System.Drawing.Size(834, 45)
        Me.tbClockSpeed.TabIndex = 9
        Me.tbClockSpeed.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbClockSpeed.Value = 1
        '
        'lblGFLOPS
        '
        Me.lblGFLOPS.AutoSize = True
        Me.lblGFLOPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGFLOPS.Location = New System.Drawing.Point(6, 396)
        Me.lblGFLOPS.Name = "lblGFLOPS"
        Me.lblGFLOPS.Size = New System.Drawing.Size(154, 31)
        Me.lblGFLOPS.TabIndex = 8
        Me.lblGFLOPS.Text = "0 GFLOPS"
        '
        'lblTFLOPS
        '
        Me.lblTFLOPS.AutoSize = True
        Me.lblTFLOPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTFLOPS.Location = New System.Drawing.Point(6, 356)
        Me.lblTFLOPS.Name = "lblTFLOPS"
        Me.lblTFLOPS.Size = New System.Drawing.Size(150, 31)
        Me.lblTFLOPS.TabIndex = 7
        Me.lblTFLOPS.Text = "0 TFLOPS"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(6, 322)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(79, 25)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Result:"
        '
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(6, 152)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(169, 13)
        Me.lblStep3.TabIndex = 4
        Me.lblStep3.Text = "Step 3:  Enter clock speed in MHz"
        '
        'nudComputeUnits
        '
        Me.nudComputeUnits.Location = New System.Drawing.Point(6, 114)
        Me.nudComputeUnits.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudComputeUnits.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudComputeUnits.Name = "nudComputeUnits"
        Me.nudComputeUnits.Size = New System.Drawing.Size(67, 20)
        Me.nudComputeUnits.TabIndex = 3
        Me.nudComputeUnits.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(6, 84)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(146, 13)
        Me.lblStep2.TabIndex = 2
        Me.lblStep2.Text = "Step 2:  Enter number of SMs"
        '
        'cbUarch
        '
        Me.cbUarch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUarch.FormattingEnabled = True
        Me.cbUarch.Items.AddRange(New Object() {"Nvidia Fermi", "Nvidia Kepler", "Nvidia Maxwell", "Nvidia Pascal", "Nvidia Turing", "AMD GCN 1.0", "AMD GCN 2.0", "AMD GCN 3.0", "AMD GCN 4.0", "AMD Vega", "AMD RDNA1", "AMD RDNA2", "Intel gen8", "Intel gen9", "Intel gen11"})
        Me.cbUarch.Location = New System.Drawing.Point(6, 41)
        Me.cbUarch.Name = "cbUarch"
        Me.cbUarch.Size = New System.Drawing.Size(121, 21)
        Me.cbUarch.TabIndex = 1
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(6, 15)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(203, 13)
        Me.lblStep1.TabIndex = 0
        Me.lblStep1.Text = "Step 1:  Choose microarchitecture (μarch)"
        '
        'tpUnknownClock
        '
        Me.tpUnknownClock.Controls.Add(Me.lblTFLOPSa)
        Me.tpUnknownClock.Controls.Add(Me.lblReqClock)
        Me.tpUnknownClock.Controls.Add(Me.lblResulta)
        Me.tpUnknownClock.Controls.Add(Me.txtCompute)
        Me.tpUnknownClock.Controls.Add(Me.lblStep3a)
        Me.tpUnknownClock.Controls.Add(Me.nudComputeUnitsa)
        Me.tpUnknownClock.Controls.Add(Me.lblStep2a)
        Me.tpUnknownClock.Controls.Add(Me.cbUarcha)
        Me.tpUnknownClock.Controls.Add(Me.lblStep1a)
        Me.tpUnknownClock.Location = New System.Drawing.Point(4, 22)
        Me.tpUnknownClock.Name = "tpUnknownClock"
        Me.tpUnknownClock.Size = New System.Drawing.Size(852, 446)
        Me.tpUnknownClock.TabIndex = 3
        Me.tpUnknownClock.Text = "Unknown Clock"
        Me.tpUnknownClock.UseVisualStyleBackColor = True
        '
        'tpUnknownCU
        '
        Me.tpUnknownCU.Controls.Add(Me.lblTFLOPSb)
        Me.tpUnknownCU.Controls.Add(Me.lblReqCU)
        Me.tpUnknownCU.Controls.Add(Me.lblResultb)
        Me.tpUnknownCU.Controls.Add(Me.txtComputeb)
        Me.tpUnknownCU.Controls.Add(Me.lblStep3b)
        Me.tpUnknownCU.Controls.Add(Me.lblClockb)
        Me.tpUnknownCU.Controls.Add(Me.lbl5KMHzb)
        Me.tpUnknownCU.Controls.Add(Me.lbl1MHzb)
        Me.tpUnknownCU.Controls.Add(Me.tbClockSpeedb)
        Me.tpUnknownCU.Controls.Add(Me.lblStep2b)
        Me.tpUnknownCU.Controls.Add(Me.cbUarchb)
        Me.tpUnknownCU.Controls.Add(Me.lblStep1b)
        Me.tpUnknownCU.Location = New System.Drawing.Point(4, 22)
        Me.tpUnknownCU.Name = "tpUnknownCU"
        Me.tpUnknownCU.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUnknownCU.Size = New System.Drawing.Size(852, 446)
        Me.tpUnknownCU.TabIndex = 1
        Me.tpUnknownCU.Text = "Unknown # of CU/SM/EU"
        Me.tpUnknownCU.UseVisualStyleBackColor = True
        '
        'tpKnowCompute
        '
        Me.tpKnowCompute.Location = New System.Drawing.Point(4, 22)
        Me.tpKnowCompute.Name = "tpKnowCompute"
        Me.tpKnowCompute.Size = New System.Drawing.Size(852, 446)
        Me.tpKnowCompute.TabIndex = 2
        Me.tpKnowCompute.Text = "Known Compute"
        Me.tpKnowCompute.UseVisualStyleBackColor = True
        '
        'tpAbout
        '
        Me.tpAbout.Controls.Add(Me.llTFLOPSRepo)
        Me.tpAbout.Controls.Add(Me.llMyGithub)
        Me.tpAbout.Controls.Add(Me.pbLouise)
        Me.tpAbout.Controls.Add(Me.llTwitter)
        Me.tpAbout.Controls.Add(Me.pcKirby)
        Me.tpAbout.Controls.Add(Me.lblAbout)
        Me.tpAbout.Location = New System.Drawing.Point(4, 22)
        Me.tpAbout.Name = "tpAbout"
        Me.tpAbout.Size = New System.Drawing.Size(852, 446)
        Me.tpAbout.TabIndex = 4
        Me.tpAbout.Text = "About"
        Me.tpAbout.UseVisualStyleBackColor = True
        '
        'llTFLOPSRepo
        '
        Me.llTFLOPSRepo.AutoSize = True
        Me.llTFLOPSRepo.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llTFLOPSRepo.Location = New System.Drawing.Point(281, 140)
        Me.llTFLOPSRepo.Name = "llTFLOPSRepo"
        Me.llTFLOPSRepo.Size = New System.Drawing.Size(118, 18)
        Me.llTFLOPSRepo.TabIndex = 5
        Me.llTFLOPSRepo.TabStop = True
        Me.llTFLOPSRepo.Text = "TFLOPSCalc Repo"
        '
        'llMyGithub
        '
        Me.llMyGithub.AutoSize = True
        Me.llMyGithub.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llMyGithub.Location = New System.Drawing.Point(200, 140)
        Me.llMyGithub.Name = "llMyGithub"
        Me.llMyGithub.Size = New System.Drawing.Size(75, 18)
        Me.llMyGithub.TabIndex = 4
        Me.llMyGithub.TabStop = True
        Me.llMyGithub.Text = "My GitHub"
        '
        'pbLouise
        '
        Me.pbLouise.Image = Global.TFLOPSCalc.My.Resources.Resources.louise
        Me.pbLouise.Location = New System.Drawing.Point(578, 187)
        Me.pbLouise.Name = "pbLouise"
        Me.pbLouise.Size = New System.Drawing.Size(256, 256)
        Me.pbLouise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLouise.TabIndex = 3
        Me.pbLouise.TabStop = False
        '
        'llTwitter
        '
        Me.llTwitter.AutoSize = True
        Me.llTwitter.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llTwitter.Location = New System.Drawing.Point(103, 140)
        Me.llTwitter.Name = "llTwitter"
        Me.llTwitter.Size = New System.Drawing.Size(91, 18)
        Me.llTwitter.TabIndex = 2
        Me.llTwitter.TabStop = True
        Me.llTwitter.Text = "Kirby0Louise"
        '
        'pcKirby
        '
        Me.pcKirby.Image = Global.TFLOPSCalc.My.Resources.Resources.kirby
        Me.pcKirby.Location = New System.Drawing.Point(16, 187)
        Me.pcKirby.Name = "pcKirby"
        Me.pcKirby.Size = New System.Drawing.Size(256, 256)
        Me.pcKirby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcKirby.TabIndex = 1
        Me.pcKirby.TabStop = False
        '
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(13, 32)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(836, 152)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'nudComputeUnitsa
        '
        Me.nudComputeUnitsa.Location = New System.Drawing.Point(6, 114)
        Me.nudComputeUnitsa.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudComputeUnitsa.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudComputeUnitsa.Name = "nudComputeUnitsa"
        Me.nudComputeUnitsa.Size = New System.Drawing.Size(67, 20)
        Me.nudComputeUnitsa.TabIndex = 7
        Me.nudComputeUnitsa.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStep3a
        '
        Me.lblStep3a.AutoSize = True
        Me.lblStep3a.Location = New System.Drawing.Point(6, 152)
        Me.lblStep3a.Name = "lblStep3a"
        Me.lblStep3a.Size = New System.Drawing.Size(117, 13)
        Me.lblStep3a.TabIndex = 8
        Me.lblStep3a.Text = "Step 3:  Enter Compute"
        '
        'txtCompute
        '
        Me.txtCompute.Location = New System.Drawing.Point(6, 195)
        Me.txtCompute.Name = "txtCompute"
        Me.txtCompute.Size = New System.Drawing.Size(100, 20)
        Me.txtCompute.TabIndex = 9
        Me.txtCompute.Text = "0.0"
        '
        'lblReqClock
        '
        Me.lblReqClock.AutoSize = True
        Me.lblReqClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqClock.Location = New System.Drawing.Point(4, 299)
        Me.lblReqClock.Name = "lblReqClock"
        Me.lblReqClock.Size = New System.Drawing.Size(97, 31)
        Me.lblReqClock.TabIndex = 11
        Me.lblReqClock.Text = "0 MHz"
        '
        'lblResulta
        '
        Me.lblResulta.AutoSize = True
        Me.lblResulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResulta.Location = New System.Drawing.Point(4, 265)
        Me.lblResulta.Name = "lblResulta"
        Me.lblResulta.Size = New System.Drawing.Size(79, 25)
        Me.lblResulta.TabIndex = 10
        Me.lblResulta.Text = "Result:"
        '
        'lblTFLOPSa
        '
        Me.lblTFLOPSa.AutoSize = True
        Me.lblTFLOPSa.Location = New System.Drawing.Point(119, 199)
        Me.lblTFLOPSa.Name = "lblTFLOPSa"
        Me.lblTFLOPSa.Size = New System.Drawing.Size(48, 13)
        Me.lblTFLOPSa.TabIndex = 12
        Me.lblTFLOPSa.Text = "TFLOPS"
        '
        'lblStep1a
        '
        Me.lblStep1a.AutoSize = True
        Me.lblStep1a.Location = New System.Drawing.Point(6, 15)
        Me.lblStep1a.Name = "lblStep1a"
        Me.lblStep1a.Size = New System.Drawing.Size(203, 13)
        Me.lblStep1a.TabIndex = 4
        Me.lblStep1a.Text = "Step 1:  Choose microarchitecture (μarch)"
        '
        'cbUarcha
        '
        Me.cbUarcha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUarcha.FormattingEnabled = True
        Me.cbUarcha.Items.AddRange(New Object() {"Nvidia Fermi", "Nvidia Kepler", "Nvidia Maxwell", "Nvidia Pascal", "Nvidia Turing", "AMD GCN 1.0", "AMD GCN 2.0", "AMD GCN 3.0", "AMD GCN 4.0", "AMD Vega", "AMD RDNA1", "AMD RDNA2", "Intel gen8", "Intel gen9", "Intel gen11"})
        Me.cbUarcha.Location = New System.Drawing.Point(6, 41)
        Me.cbUarcha.Name = "cbUarcha"
        Me.cbUarcha.Size = New System.Drawing.Size(121, 21)
        Me.cbUarcha.TabIndex = 5
        '
        'lblStep2a
        '
        Me.lblStep2a.AutoSize = True
        Me.lblStep2a.Location = New System.Drawing.Point(6, 84)
        Me.lblStep2a.Name = "lblStep2a"
        Me.lblStep2a.Size = New System.Drawing.Size(146, 13)
        Me.lblStep2a.TabIndex = 6
        Me.lblStep2a.Text = "Step 2:  Enter number of SMs"
        '
        'lblStep2b
        '
        Me.lblStep2b.AutoSize = True
        Me.lblStep2b.Location = New System.Drawing.Point(6, 84)
        Me.lblStep2b.Name = "lblStep2b"
        Me.lblStep2b.Size = New System.Drawing.Size(133, 13)
        Me.lblStep2b.TabIndex = 9
        Me.lblStep2b.Text = "Step 2:  Enter clock speed"
        '
        'cbUarchb
        '
        Me.cbUarchb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUarchb.FormattingEnabled = True
        Me.cbUarchb.Items.AddRange(New Object() {"Nvidia Fermi", "Nvidia Kepler", "Nvidia Maxwell", "Nvidia Pascal", "Nvidia Turing", "AMD GCN 1.0", "AMD GCN 2.0", "AMD GCN 3.0", "AMD GCN 4.0", "AMD Vega", "AMD RDNA1", "AMD RDNA2", "Intel gen8", "Intel gen9", "Intel gen11"})
        Me.cbUarchb.Location = New System.Drawing.Point(6, 41)
        Me.cbUarchb.Name = "cbUarchb"
        Me.cbUarchb.Size = New System.Drawing.Size(121, 21)
        Me.cbUarchb.TabIndex = 8
        '
        'lblStep1b
        '
        Me.lblStep1b.AutoSize = True
        Me.lblStep1b.Location = New System.Drawing.Point(6, 15)
        Me.lblStep1b.Name = "lblStep1b"
        Me.lblStep1b.Size = New System.Drawing.Size(203, 13)
        Me.lblStep1b.TabIndex = 7
        Me.lblStep1b.Text = "Step 1:  Choose microarchitecture (μarch)"
        '
        'lblClockb
        '
        Me.lblClockb.AutoSize = True
        Me.lblClockb.Location = New System.Drawing.Point(0, 198)
        Me.lblClockb.Name = "lblClockb"
        Me.lblClockb.Size = New System.Drawing.Size(105, 13)
        Me.lblClockb.TabIndex = 16
        Me.lblClockb.Text = "Clock Speed: 1 MHz"
        '
        'lbl5KMHzb
        '
        Me.lbl5KMHzb.AutoSize = True
        Me.lbl5KMHzb.Location = New System.Drawing.Point(781, 158)
        Me.lbl5KMHzb.Name = "lbl5KMHzb"
        Me.lbl5KMHzb.Size = New System.Drawing.Size(56, 13)
        Me.lbl5KMHzb.TabIndex = 15
        Me.lbl5KMHzb.Text = "5000 MHz"
        '
        'lbl1MHzb
        '
        Me.lbl1MHzb.AutoSize = True
        Me.lbl1MHzb.Location = New System.Drawing.Point(0, 158)
        Me.lbl1MHzb.Name = "lbl1MHzb"
        Me.lbl1MHzb.Size = New System.Drawing.Size(38, 13)
        Me.lbl1MHzb.TabIndex = 14
        Me.lbl1MHzb.Text = "1 MHz"
        '
        'tbClockSpeedb
        '
        Me.tbClockSpeedb.Location = New System.Drawing.Point(3, 110)
        Me.tbClockSpeedb.Maximum = 5000
        Me.tbClockSpeedb.Minimum = 1
        Me.tbClockSpeedb.Name = "tbClockSpeedb"
        Me.tbClockSpeedb.Size = New System.Drawing.Size(834, 45)
        Me.tbClockSpeedb.TabIndex = 13
        Me.tbClockSpeedb.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbClockSpeedb.Value = 1
        '
        'lblTFLOPSb
        '
        Me.lblTFLOPSb.AutoSize = True
        Me.lblTFLOPSb.Location = New System.Drawing.Point(116, 285)
        Me.lblTFLOPSb.Name = "lblTFLOPSb"
        Me.lblTFLOPSb.Size = New System.Drawing.Size(48, 13)
        Me.lblTFLOPSb.TabIndex = 21
        Me.lblTFLOPSb.Text = "TFLOPS"
        '
        'lblReqCU
        '
        Me.lblReqCU.AutoSize = True
        Me.lblReqCU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqCU.Location = New System.Drawing.Point(1, 385)
        Me.lblReqCU.Name = "lblReqCU"
        Me.lblReqCU.Size = New System.Drawing.Size(95, 31)
        Me.lblReqCU.TabIndex = 20
        Me.lblReqCU.Text = "0 SMs"
        '
        'lblResultb
        '
        Me.lblResultb.AutoSize = True
        Me.lblResultb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultb.Location = New System.Drawing.Point(1, 351)
        Me.lblResultb.Name = "lblResultb"
        Me.lblResultb.Size = New System.Drawing.Size(79, 25)
        Me.lblResultb.TabIndex = 19
        Me.lblResultb.Text = "Result:"
        '
        'txtComputeb
        '
        Me.txtComputeb.Location = New System.Drawing.Point(3, 281)
        Me.txtComputeb.Name = "txtComputeb"
        Me.txtComputeb.Size = New System.Drawing.Size(100, 20)
        Me.txtComputeb.TabIndex = 18
        Me.txtComputeb.Text = "0.0"
        '
        'lblStep3b
        '
        Me.lblStep3b.AutoSize = True
        Me.lblStep3b.Location = New System.Drawing.Point(3, 238)
        Me.lblStep3b.Name = "lblStep3b"
        Me.lblStep3b.Size = New System.Drawing.Size(117, 13)
        Me.lblStep3b.TabIndex = 17
        Me.lblStep3b.Text = "Step 3:  Enter Compute"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 496)
        Me.Controls.Add(Me.tcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Kirby0Louise's TFLOPS Calculator"
        Me.tcMain.ResumeLayout(False)
        Me.tpCalculator.ResumeLayout(False)
        Me.tpCalculator.PerformLayout()
        CType(Me.tbClockSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComputeUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpUnknownClock.ResumeLayout(False)
        Me.tpUnknownClock.PerformLayout()
        Me.tpUnknownCU.ResumeLayout(False)
        Me.tpUnknownCU.PerformLayout()
        Me.tpAbout.ResumeLayout(False)
        Me.tpAbout.PerformLayout()
        CType(Me.pbLouise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcKirby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComputeUnitsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbClockSpeedb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpCalculator As TabPage
    Friend WithEvents tpUnknownCU As TabPage
    Friend WithEvents tpKnowCompute As TabPage
    Friend WithEvents lblStep1 As Label
    Friend WithEvents cbUarch As ComboBox
    Friend WithEvents lblStep2 As Label
    Friend WithEvents nudComputeUnits As NumericUpDown
    Friend WithEvents lblStep3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblGFLOPS As Label
    Friend WithEvents lblTFLOPS As Label
    Friend WithEvents tbClockSpeed As TrackBar
    Friend WithEvents lbl5kMHz As Label
    Friend WithEvents lbl1MHz As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents tpUnknownClock As TabPage
    Friend WithEvents tpAbout As TabPage
    Friend WithEvents lblAbout As Label
    Friend WithEvents pcKirby As PictureBox
    Friend WithEvents llTwitter As LinkLabel
    Friend WithEvents pbLouise As PictureBox
    Friend WithEvents llTFLOPSRepo As LinkLabel
    Friend WithEvents llMyGithub As LinkLabel
    Friend WithEvents nudComputeUnitsa As NumericUpDown
    Friend WithEvents lblStep3a As Label
    Friend WithEvents txtCompute As TextBox
    Friend WithEvents lblReqClock As Label
    Friend WithEvents lblResulta As Label
    Friend WithEvents lblTFLOPSa As Label
    Friend WithEvents lblStep2a As Label
    Friend WithEvents cbUarcha As ComboBox
    Friend WithEvents lblStep1a As Label
    Friend WithEvents lblStep2b As Label
    Friend WithEvents cbUarchb As ComboBox
    Friend WithEvents lblStep1b As Label
    Friend WithEvents lblClockb As Label
    Friend WithEvents lbl5KMHzb As Label
    Friend WithEvents lbl1MHzb As Label
    Friend WithEvents tbClockSpeedb As TrackBar
    Friend WithEvents lblTFLOPSb As Label
    Friend WithEvents lblReqCU As Label
    Friend WithEvents lblResultb As Label
    Friend WithEvents txtComputeb As TextBox
    Friend WithEvents lblStep3b As Label
End Class
