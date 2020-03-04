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
        Me.tpKnowClock = New System.Windows.Forms.TabPage()
        Me.tpKnowCompute = New System.Windows.Forms.TabPage()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.cbUarch = New System.Windows.Forms.ComboBox()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.nudComputeUnits = New System.Windows.Forms.NumericUpDown()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTFLOPS = New System.Windows.Forms.Label()
        Me.lblGFLOPS = New System.Windows.Forms.Label()
        Me.tbClockSpeed = New System.Windows.Forms.TrackBar()
        Me.lbl1MHz = New System.Windows.Forms.Label()
        Me.lbl5kMHz = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.tpKnowCU = New System.Windows.Forms.TabPage()
        Me.tpAbout = New System.Windows.Forms.TabPage()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.pcKirby = New System.Windows.Forms.PictureBox()
        Me.llTwitter = New System.Windows.Forms.LinkLabel()
        Me.pbLouise = New System.Windows.Forms.PictureBox()
        Me.llMyGithub = New System.Windows.Forms.LinkLabel()
        Me.llTFLOPSRepo = New System.Windows.Forms.LinkLabel()
        Me.tcMain.SuspendLayout()
        Me.tpCalculator.SuspendLayout()
        CType(Me.nudComputeUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbClockSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAbout.SuspendLayout()
        CType(Me.pcKirby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLouise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpCalculator)
        Me.tcMain.Controls.Add(Me.tpKnowCU)
        Me.tcMain.Controls.Add(Me.tpKnowClock)
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
        'tpKnowClock
        '
        Me.tpKnowClock.Location = New System.Drawing.Point(4, 22)
        Me.tpKnowClock.Name = "tpKnowClock"
        Me.tpKnowClock.Padding = New System.Windows.Forms.Padding(3)
        Me.tpKnowClock.Size = New System.Drawing.Size(852, 446)
        Me.tpKnowClock.TabIndex = 1
        Me.tpKnowClock.Text = "Known Clock Speed"
        Me.tpKnowClock.UseVisualStyleBackColor = True
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
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(6, 15)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(203, 13)
        Me.lblStep1.TabIndex = 0
        Me.lblStep1.Text = "Step 1:  Choose microarchitecture (μarch)"
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
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(6, 84)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(146, 13)
        Me.lblStep2.TabIndex = 2
        Me.lblStep2.Text = "Step 2:  Enter number of SMs"
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
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(6, 152)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(169, 13)
        Me.lblStep3.TabIndex = 4
        Me.lblStep3.Text = "Step 3:  Enter clock speed in MHz"
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
        'lbl1MHz
        '
        Me.lbl1MHz.AutoSize = True
        Me.lbl1MHz.Location = New System.Drawing.Point(9, 225)
        Me.lbl1MHz.Name = "lbl1MHz"
        Me.lbl1MHz.Size = New System.Drawing.Size(38, 13)
        Me.lbl1MHz.TabIndex = 10
        Me.lbl1MHz.Text = "1 MHz"
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
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(9, 265)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(105, 13)
        Me.lblClock.TabIndex = 12
        Me.lblClock.Text = "Clock Speed: 1 MHz"
        '
        'tpKnowCU
        '
        Me.tpKnowCU.Location = New System.Drawing.Point(4, 22)
        Me.tpKnowCU.Name = "tpKnowCU"
        Me.tpKnowCU.Size = New System.Drawing.Size(852, 446)
        Me.tpKnowCU.TabIndex = 3
        Me.tpKnowCU.Text = "Known # of CU/SM/EU"
        Me.tpKnowCU.UseVisualStyleBackColor = True
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
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(13, 32)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(836, 152)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
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
        CType(Me.nudComputeUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbClockSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAbout.ResumeLayout(False)
        Me.tpAbout.PerformLayout()
        CType(Me.pcKirby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLouise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpCalculator As TabPage
    Friend WithEvents tpKnowClock As TabPage
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
    Friend WithEvents tpKnowCU As TabPage
    Friend WithEvents tpAbout As TabPage
    Friend WithEvents lblAbout As Label
    Friend WithEvents pcKirby As PictureBox
    Friend WithEvents llTwitter As LinkLabel
    Friend WithEvents pbLouise As PictureBox
    Friend WithEvents llTFLOPSRepo As LinkLabel
    Friend WithEvents llMyGithub As LinkLabel
End Class
