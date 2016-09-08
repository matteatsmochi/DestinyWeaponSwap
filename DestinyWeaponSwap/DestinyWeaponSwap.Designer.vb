<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDestinyWeaponSwap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDestinyWeaponSwap))
        Me.picWeapon1 = New System.Windows.Forms.PictureBox()
        Me.picWeapon2 = New System.Windows.Forms.PictureBox()
        Me.picWeapon3 = New System.Windows.Forms.PictureBox()
        Me.picSwapPlate = New System.Windows.Forms.PictureBox()
        Me.barVote3 = New System.Windows.Forms.PictureBox()
        Me.barVote2 = New System.Windows.Forms.PictureBox()
        Me.barVote1 = New System.Windows.Forms.PictureBox()
        Me.lblWeaponName1 = New System.Windows.Forms.Label()
        Me.lblWeaponName2 = New System.Windows.Forms.Label()
        Me.lblWeaponName3 = New System.Windows.Forms.Label()
        Me.cmdVote1 = New System.Windows.Forms.Button()
        Me.txtVote1 = New System.Windows.Forms.TextBox()
        Me.txtVote2 = New System.Windows.Forms.TextBox()
        Me.cmdVote2 = New System.Windows.Forms.Button()
        Me.txtVote3 = New System.Windows.Forms.TextBox()
        Me.cmdVote3 = New System.Windows.Forms.Button()
        Me.txtTotalVotes = New System.Windows.Forms.TextBox()
        Me.cmdUpDown = New System.Windows.Forms.Button()
        Me.tmrUpDown = New System.Windows.Forms.Timer(Me.components)
        Me.txtUpDown = New System.Windows.Forms.TextBox()
        Me.picW1 = New System.Windows.Forms.PictureBox()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.txtCheckYes = New System.Windows.Forms.TextBox()
        Me.txtPlayerStatus = New System.Windows.Forms.TextBox()
        Me.picReticleColor = New System.Windows.Forms.PictureBox()
        Me.txtReticleColor = New System.Windows.Forms.TextBox()
        Me.txtLocationW1 = New System.Windows.Forms.TextBox()
        Me.txtLocationW2 = New System.Windows.Forms.TextBox()
        Me.txtLocationW3 = New System.Windows.Forms.TextBox()
        Me.txtLocationW4 = New System.Windows.Forms.TextBox()
        Me.txtLocationW5 = New System.Windows.Forms.TextBox()
        Me.txtLocationW6 = New System.Windows.Forms.TextBox()
        Me.txtLocationW7 = New System.Windows.Forms.TextBox()
        Me.txtLocationW8 = New System.Windows.Forms.TextBox()
        Me.txtLocationW9 = New System.Windows.Forms.TextBox()
        Me.txtLocationW10 = New System.Windows.Forms.TextBox()
        Me.txtLocationW11 = New System.Windows.Forms.TextBox()
        Me.txtLocationW12 = New System.Windows.Forms.TextBox()
        Me.txtLocationW13 = New System.Windows.Forms.TextBox()
        Me.txtLocationW14 = New System.Windows.Forms.TextBox()
        Me.txtLocationW15 = New System.Windows.Forms.TextBox()
        Me.txtLocationW16 = New System.Windows.Forms.TextBox()
        Me.txtLocationW17 = New System.Windows.Forms.TextBox()
        Me.txtLocationW18 = New System.Windows.Forms.TextBox()
        Me.txtLocationW19 = New System.Windows.Forms.TextBox()
        Me.cmdSendNew = New System.Windows.Forms.Button()
        Me.txtVoteCountdown = New System.Windows.Forms.TextBox()
        Me.cmdStartVote = New System.Windows.Forms.Button()
        Me.txtLastGun = New System.Windows.Forms.TextBox()
        Me.txtRandomGun3 = New System.Windows.Forms.TextBox()
        Me.txtRandomGun2 = New System.Windows.Forms.TextBox()
        Me.txtRandomGun1 = New System.Windows.Forms.TextBox()
        Me.cmdRandomWeapons = New System.Windows.Forms.Button()
        Me.tmrVote = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReticleCheck = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTakeOld = New System.Windows.Forms.Button()
        Me.tmrSpawnCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDeathCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTakeWeaponWait = New System.Windows.Forms.Timer(Me.components)
        Me.txtTakeWeaponWait = New System.Windows.Forms.TextBox()
        Me.picActive = New System.Windows.Forms.PictureBox()
        Me.picOnDeck = New System.Windows.Forms.PictureBox()
        Me.txtLocationWActive = New System.Windows.Forms.TextBox()
        Me.txtLocationOnDeck = New System.Windows.Forms.TextBox()
        Me.txtMouseLoc = New System.Windows.Forms.TextBox()
        Me.tmrMouseLoc = New System.Windows.Forms.Timer(Me.components)
        Me.txt3Strikes = New System.Windows.Forms.TextBox()
        Me.txtExcess = New System.Windows.Forms.TextBox()
        Me.AlertPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.txtWinnerLocation = New System.Windows.Forms.TextBox()
        Me.picW3 = New System.Windows.Forms.PictureBox()
        Me.picW4 = New System.Windows.Forms.PictureBox()
        Me.picW5 = New System.Windows.Forms.PictureBox()
        Me.picW6 = New System.Windows.Forms.PictureBox()
        Me.picW7 = New System.Windows.Forms.PictureBox()
        Me.picW8 = New System.Windows.Forms.PictureBox()
        Me.picW9 = New System.Windows.Forms.PictureBox()
        Me.picW10 = New System.Windows.Forms.PictureBox()
        Me.picW11 = New System.Windows.Forms.PictureBox()
        Me.picW12 = New System.Windows.Forms.PictureBox()
        Me.picW13 = New System.Windows.Forms.PictureBox()
        Me.picW14 = New System.Windows.Forms.PictureBox()
        Me.picW15 = New System.Windows.Forms.PictureBox()
        Me.picW16 = New System.Windows.Forms.PictureBox()
        Me.picW17 = New System.Windows.Forms.PictureBox()
        Me.picW18 = New System.Windows.Forms.PictureBox()
        Me.picW19 = New System.Windows.Forms.PictureBox()
        Me.picW2 = New System.Windows.Forms.PictureBox()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtChan = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        CType(Me.picWeapon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeapon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeapon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSwapPlate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReticleColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOnDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlertPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picW2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWeapon1
        '
        Me.picWeapon1.BackColor = System.Drawing.Color.Yellow
        Me.picWeapon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWeapon1.Image = CType(resources.GetObject("picWeapon1.Image"), System.Drawing.Image)
        Me.picWeapon1.Location = New System.Drawing.Point(2, 89)
        Me.picWeapon1.Name = "picWeapon1"
        Me.picWeapon1.Size = New System.Drawing.Size(100, 100)
        Me.picWeapon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeapon1.TabIndex = 0
        Me.picWeapon1.TabStop = False
        '
        'picWeapon2
        '
        Me.picWeapon2.BackColor = System.Drawing.Color.Yellow
        Me.picWeapon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWeapon2.Image = CType(resources.GetObject("picWeapon2.Image"), System.Drawing.Image)
        Me.picWeapon2.Location = New System.Drawing.Point(2, 275)
        Me.picWeapon2.Name = "picWeapon2"
        Me.picWeapon2.Size = New System.Drawing.Size(100, 100)
        Me.picWeapon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeapon2.TabIndex = 1
        Me.picWeapon2.TabStop = False
        '
        'picWeapon3
        '
        Me.picWeapon3.BackColor = System.Drawing.Color.Yellow
        Me.picWeapon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWeapon3.Image = CType(resources.GetObject("picWeapon3.Image"), System.Drawing.Image)
        Me.picWeapon3.Location = New System.Drawing.Point(2, 463)
        Me.picWeapon3.Name = "picWeapon3"
        Me.picWeapon3.Size = New System.Drawing.Size(100, 100)
        Me.picWeapon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeapon3.TabIndex = 2
        Me.picWeapon3.TabStop = False
        '
        'picSwapPlate
        '
        Me.picSwapPlate.Image = CType(resources.GetObject("picSwapPlate.Image"), System.Drawing.Image)
        Me.picSwapPlate.Location = New System.Drawing.Point(0, 0)
        Me.picSwapPlate.Name = "picSwapPlate"
        Me.picSwapPlate.Size = New System.Drawing.Size(215, 680)
        Me.picSwapPlate.TabIndex = 3
        Me.picSwapPlate.TabStop = False
        '
        'barVote3
        '
        Me.barVote3.BackColor = System.Drawing.Color.Red
        Me.barVote3.Location = New System.Drawing.Point(0, 611)
        Me.barVote3.Name = "barVote3"
        Me.barVote3.Size = New System.Drawing.Size(200, 10)
        Me.barVote3.TabIndex = 4
        Me.barVote3.TabStop = False
        '
        'barVote2
        '
        Me.barVote2.BackColor = System.Drawing.Color.Red
        Me.barVote2.Location = New System.Drawing.Point(0, 423)
        Me.barVote2.Name = "barVote2"
        Me.barVote2.Size = New System.Drawing.Size(200, 10)
        Me.barVote2.TabIndex = 5
        Me.barVote2.TabStop = False
        '
        'barVote1
        '
        Me.barVote1.BackColor = System.Drawing.Color.Red
        Me.barVote1.Location = New System.Drawing.Point(0, 237)
        Me.barVote1.Name = "barVote1"
        Me.barVote1.Size = New System.Drawing.Size(200, 10)
        Me.barVote1.TabIndex = 6
        Me.barVote1.TabStop = False
        '
        'lblWeaponName1
        '
        Me.lblWeaponName1.BackColor = System.Drawing.Color.Black
        Me.lblWeaponName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeaponName1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName1.Location = New System.Drawing.Point(2, 191)
        Me.lblWeaponName1.Name = "lblWeaponName1"
        Me.lblWeaponName1.Size = New System.Drawing.Size(195, 35)
        Me.lblWeaponName1.TabIndex = 7
        Me.lblWeaponName1.Text = "!THORN"
        Me.lblWeaponName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeaponName2
        '
        Me.lblWeaponName2.BackColor = System.Drawing.Color.Black
        Me.lblWeaponName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeaponName2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName2.Location = New System.Drawing.Point(2, 377)
        Me.lblWeaponName2.Name = "lblWeaponName2"
        Me.lblWeaponName2.Size = New System.Drawing.Size(195, 35)
        Me.lblWeaponName2.TabIndex = 8
        Me.lblWeaponName2.Text = "!THORN"
        Me.lblWeaponName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeaponName3
        '
        Me.lblWeaponName3.BackColor = System.Drawing.Color.Black
        Me.lblWeaponName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeaponName3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName3.Location = New System.Drawing.Point(2, 565)
        Me.lblWeaponName3.Name = "lblWeaponName3"
        Me.lblWeaponName3.Size = New System.Drawing.Size(195, 35)
        Me.lblWeaponName3.TabIndex = 9
        Me.lblWeaponName3.Text = "!THORN"
        Me.lblWeaponName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdVote1
        '
        Me.cmdVote1.Location = New System.Drawing.Point(221, 12)
        Me.cmdVote1.Name = "cmdVote1"
        Me.cmdVote1.Size = New System.Drawing.Size(75, 23)
        Me.cmdVote1.TabIndex = 10
        Me.cmdVote1.Text = "Vote 1"
        Me.cmdVote1.UseVisualStyleBackColor = True
        '
        'txtVote1
        '
        Me.txtVote1.Location = New System.Drawing.Point(302, 12)
        Me.txtVote1.Name = "txtVote1"
        Me.txtVote1.Size = New System.Drawing.Size(100, 20)
        Me.txtVote1.TabIndex = 11
        Me.txtVote1.Text = "0"
        '
        'txtVote2
        '
        Me.txtVote2.Location = New System.Drawing.Point(302, 38)
        Me.txtVote2.Name = "txtVote2"
        Me.txtVote2.Size = New System.Drawing.Size(100, 20)
        Me.txtVote2.TabIndex = 13
        Me.txtVote2.Text = "0"
        '
        'cmdVote2
        '
        Me.cmdVote2.Location = New System.Drawing.Point(221, 36)
        Me.cmdVote2.Name = "cmdVote2"
        Me.cmdVote2.Size = New System.Drawing.Size(75, 23)
        Me.cmdVote2.TabIndex = 12
        Me.cmdVote2.Text = "Vote 2"
        Me.cmdVote2.UseVisualStyleBackColor = True
        '
        'txtVote3
        '
        Me.txtVote3.Location = New System.Drawing.Point(302, 64)
        Me.txtVote3.Name = "txtVote3"
        Me.txtVote3.Size = New System.Drawing.Size(100, 20)
        Me.txtVote3.TabIndex = 15
        Me.txtVote3.Text = "0"
        '
        'cmdVote3
        '
        Me.cmdVote3.Location = New System.Drawing.Point(221, 62)
        Me.cmdVote3.Name = "cmdVote3"
        Me.cmdVote3.Size = New System.Drawing.Size(75, 23)
        Me.cmdVote3.TabIndex = 14
        Me.cmdVote3.Text = "Vote 3"
        Me.cmdVote3.UseVisualStyleBackColor = True
        '
        'txtTotalVotes
        '
        Me.txtTotalVotes.Location = New System.Drawing.Point(302, 90)
        Me.txtTotalVotes.Name = "txtTotalVotes"
        Me.txtTotalVotes.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalVotes.TabIndex = 16
        Me.txtTotalVotes.Text = "0"
        '
        'cmdUpDown
        '
        Me.cmdUpDown.Location = New System.Drawing.Point(421, 12)
        Me.cmdUpDown.Name = "cmdUpDown"
        Me.cmdUpDown.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpDown.TabIndex = 17
        Me.cmdUpDown.Text = "Down"
        Me.cmdUpDown.UseVisualStyleBackColor = True
        '
        'tmrUpDown
        '
        Me.tmrUpDown.Interval = 30
        '
        'txtUpDown
        '
        Me.txtUpDown.Location = New System.Drawing.Point(421, 40)
        Me.txtUpDown.Name = "txtUpDown"
        Me.txtUpDown.Size = New System.Drawing.Size(75, 20)
        Me.txtUpDown.TabIndex = 18
        Me.txtUpDown.Text = "0"
        '
        'picW1
        '
        Me.picW1.Image = CType(resources.GetObject("picW1.Image"), System.Drawing.Image)
        Me.picW1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW1.Location = New System.Drawing.Point(221, 133)
        Me.picW1.Name = "picW1"
        Me.picW1.Size = New System.Drawing.Size(25, 25)
        Me.picW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW1.TabIndex = 43
        Me.picW1.TabStop = False
        Me.picW1.Tag = "Hawksaw"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Enabled = False
        Me.txtCheckNo.Location = New System.Drawing.Point(422, 162)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(75, 20)
        Me.txtCheckNo.TabIndex = 68
        Me.txtCheckNo.Text = "10"
        '
        'txtCheckYes
        '
        Me.txtCheckYes.Enabled = False
        Me.txtCheckYes.Location = New System.Drawing.Point(422, 137)
        Me.txtCheckYes.Name = "txtCheckYes"
        Me.txtCheckYes.Size = New System.Drawing.Size(75, 20)
        Me.txtCheckYes.TabIndex = 67
        Me.txtCheckYes.Text = "0"
        '
        'txtPlayerStatus
        '
        Me.txtPlayerStatus.Enabled = False
        Me.txtPlayerStatus.Location = New System.Drawing.Point(422, 186)
        Me.txtPlayerStatus.Name = "txtPlayerStatus"
        Me.txtPlayerStatus.Size = New System.Drawing.Size(75, 20)
        Me.txtPlayerStatus.TabIndex = 66
        Me.txtPlayerStatus.Text = "Alive"
        '
        'picReticleColor
        '
        Me.picReticleColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picReticleColor.Location = New System.Drawing.Point(317, 164)
        Me.picReticleColor.Name = "picReticleColor"
        Me.picReticleColor.Size = New System.Drawing.Size(85, 50)
        Me.picReticleColor.TabIndex = 65
        Me.picReticleColor.TabStop = False
        '
        'txtReticleColor
        '
        Me.txtReticleColor.Location = New System.Drawing.Point(317, 138)
        Me.txtReticleColor.Name = "txtReticleColor"
        Me.txtReticleColor.Size = New System.Drawing.Size(85, 20)
        Me.txtReticleColor.TabIndex = 64
        '
        'txtLocationW1
        '
        Me.txtLocationW1.Location = New System.Drawing.Point(252, 138)
        Me.txtLocationW1.Name = "txtLocationW1"
        Me.txtLocationW1.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW1.TabIndex = 69
        Me.txtLocationW1.Text = "2"
        '
        'txtLocationW2
        '
        Me.txtLocationW2.Location = New System.Drawing.Point(252, 164)
        Me.txtLocationW2.Name = "txtLocationW2"
        Me.txtLocationW2.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW2.TabIndex = 70
        Me.txtLocationW2.Text = "1"
        '
        'txtLocationW3
        '
        Me.txtLocationW3.Location = New System.Drawing.Point(252, 190)
        Me.txtLocationW3.Name = "txtLocationW3"
        Me.txtLocationW3.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW3.TabIndex = 71
        Me.txtLocationW3.Text = "11"
        '
        'txtLocationW4
        '
        Me.txtLocationW4.Location = New System.Drawing.Point(252, 216)
        Me.txtLocationW4.Name = "txtLocationW4"
        Me.txtLocationW4.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW4.TabIndex = 72
        Me.txtLocationW4.Text = "3"
        '
        'txtLocationW5
        '
        Me.txtLocationW5.Location = New System.Drawing.Point(252, 246)
        Me.txtLocationW5.Name = "txtLocationW5"
        Me.txtLocationW5.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW5.TabIndex = 73
        Me.txtLocationW5.Text = "16"
        '
        'txtLocationW6
        '
        Me.txtLocationW6.Location = New System.Drawing.Point(252, 272)
        Me.txtLocationW6.Name = "txtLocationW6"
        Me.txtLocationW6.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW6.TabIndex = 74
        Me.txtLocationW6.Text = "4"
        '
        'txtLocationW7
        '
        Me.txtLocationW7.Location = New System.Drawing.Point(252, 300)
        Me.txtLocationW7.Name = "txtLocationW7"
        Me.txtLocationW7.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW7.TabIndex = 75
        Me.txtLocationW7.Text = "17"
        '
        'txtLocationW8
        '
        Me.txtLocationW8.Location = New System.Drawing.Point(252, 327)
        Me.txtLocationW8.Name = "txtLocationW8"
        Me.txtLocationW8.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW8.TabIndex = 76
        Me.txtLocationW8.Text = "13"
        '
        'txtLocationW9
        '
        Me.txtLocationW9.Location = New System.Drawing.Point(252, 353)
        Me.txtLocationW9.Name = "txtLocationW9"
        Me.txtLocationW9.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW9.TabIndex = 77
        Me.txtLocationW9.Text = "24"
        '
        'txtLocationW10
        '
        Me.txtLocationW10.Location = New System.Drawing.Point(252, 381)
        Me.txtLocationW10.Name = "txtLocationW10"
        Me.txtLocationW10.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW10.TabIndex = 78
        Me.txtLocationW10.Text = "28"
        '
        'txtLocationW11
        '
        Me.txtLocationW11.Location = New System.Drawing.Point(252, 407)
        Me.txtLocationW11.Name = "txtLocationW11"
        Me.txtLocationW11.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW11.TabIndex = 79
        Me.txtLocationW11.Text = "5"
        '
        'txtLocationW12
        '
        Me.txtLocationW12.Location = New System.Drawing.Point(252, 435)
        Me.txtLocationW12.Name = "txtLocationW12"
        Me.txtLocationW12.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW12.TabIndex = 80
        Me.txtLocationW12.Text = "12"
        '
        'txtLocationW13
        '
        Me.txtLocationW13.Location = New System.Drawing.Point(252, 461)
        Me.txtLocationW13.Name = "txtLocationW13"
        Me.txtLocationW13.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW13.TabIndex = 81
        Me.txtLocationW13.Text = "25"
        '
        'txtLocationW14
        '
        Me.txtLocationW14.Location = New System.Drawing.Point(252, 489)
        Me.txtLocationW14.Name = "txtLocationW14"
        Me.txtLocationW14.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW14.TabIndex = 82
        Me.txtLocationW14.Text = "9"
        '
        'txtLocationW15
        '
        Me.txtLocationW15.Location = New System.Drawing.Point(252, 515)
        Me.txtLocationW15.Name = "txtLocationW15"
        Me.txtLocationW15.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW15.TabIndex = 83
        Me.txtLocationW15.Text = "31"
        '
        'txtLocationW16
        '
        Me.txtLocationW16.Location = New System.Drawing.Point(252, 541)
        Me.txtLocationW16.Name = "txtLocationW16"
        Me.txtLocationW16.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW16.TabIndex = 84
        '
        'txtLocationW17
        '
        Me.txtLocationW17.Location = New System.Drawing.Point(252, 567)
        Me.txtLocationW17.Name = "txtLocationW17"
        Me.txtLocationW17.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW17.TabIndex = 85
        '
        'txtLocationW18
        '
        Me.txtLocationW18.Location = New System.Drawing.Point(252, 597)
        Me.txtLocationW18.Name = "txtLocationW18"
        Me.txtLocationW18.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW18.TabIndex = 86
        '
        'txtLocationW19
        '
        Me.txtLocationW19.Location = New System.Drawing.Point(252, 623)
        Me.txtLocationW19.Name = "txtLocationW19"
        Me.txtLocationW19.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationW19.TabIndex = 87
        '
        'cmdSendNew
        '
        Me.cmdSendNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSendNew.Location = New System.Drawing.Point(421, 246)
        Me.cmdSendNew.Name = "cmdSendNew"
        Me.cmdSendNew.Size = New System.Drawing.Size(106, 29)
        Me.cmdSendNew.TabIndex = 97
        Me.cmdSendNew.Text = "Send New Gun"
        Me.cmdSendNew.UseVisualStyleBackColor = True
        '
        'txtVoteCountdown
        '
        Me.txtVoteCountdown.Enabled = False
        Me.txtVoteCountdown.Location = New System.Drawing.Point(502, 331)
        Me.txtVoteCountdown.Name = "txtVoteCountdown"
        Me.txtVoteCountdown.Size = New System.Drawing.Size(25, 20)
        Me.txtVoteCountdown.TabIndex = 96
        Me.txtVoteCountdown.Text = "45"
        '
        'cmdStartVote
        '
        Me.cmdStartVote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStartVote.Location = New System.Drawing.Point(421, 331)
        Me.cmdStartVote.Name = "cmdStartVote"
        Me.cmdStartVote.Size = New System.Drawing.Size(75, 44)
        Me.cmdStartVote.TabIndex = 95
        Me.cmdStartVote.Text = "Start Vote"
        Me.cmdStartVote.UseVisualStyleBackColor = True
        '
        'txtLastGun
        '
        Me.txtLastGun.Location = New System.Drawing.Point(491, 471)
        Me.txtLastGun.Name = "txtLastGun"
        Me.txtLastGun.Size = New System.Drawing.Size(25, 20)
        Me.txtLastGun.TabIndex = 94
        Me.txtLastGun.Text = "2"
        '
        'txtRandomGun3
        '
        Me.txtRandomGun3.Enabled = False
        Me.txtRandomGun3.Location = New System.Drawing.Point(505, 445)
        Me.txtRandomGun3.Name = "txtRandomGun3"
        Me.txtRandomGun3.Size = New System.Drawing.Size(25, 20)
        Me.txtRandomGun3.TabIndex = 93
        Me.txtRandomGun3.Text = "0"
        '
        'txtRandomGun2
        '
        Me.txtRandomGun2.Enabled = False
        Me.txtRandomGun2.Location = New System.Drawing.Point(505, 423)
        Me.txtRandomGun2.Name = "txtRandomGun2"
        Me.txtRandomGun2.Size = New System.Drawing.Size(25, 20)
        Me.txtRandomGun2.TabIndex = 92
        Me.txtRandomGun2.Text = "0"
        '
        'txtRandomGun1
        '
        Me.txtRandomGun1.Enabled = False
        Me.txtRandomGun1.Location = New System.Drawing.Point(505, 401)
        Me.txtRandomGun1.Name = "txtRandomGun1"
        Me.txtRandomGun1.Size = New System.Drawing.Size(25, 20)
        Me.txtRandomGun1.TabIndex = 91
        Me.txtRandomGun1.Text = "0"
        '
        'cmdRandomWeapons
        '
        Me.cmdRandomWeapons.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRandomWeapons.Location = New System.Drawing.Point(422, 408)
        Me.cmdRandomWeapons.Name = "cmdRandomWeapons"
        Me.cmdRandomWeapons.Size = New System.Drawing.Size(75, 47)
        Me.cmdRandomWeapons.TabIndex = 90
        Me.cmdRandomWeapons.Text = "Random Weapons"
        Me.cmdRandomWeapons.UseVisualStyleBackColor = True
        '
        'tmrVote
        '
        Me.tmrVote.Interval = 1000
        '
        'tmrReticleCheck
        '
        Me.tmrReticleCheck.Enabled = True
        '
        'cmdTakeOld
        '
        Me.cmdTakeOld.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTakeOld.Location = New System.Drawing.Point(421, 281)
        Me.cmdTakeOld.Name = "cmdTakeOld"
        Me.cmdTakeOld.Size = New System.Drawing.Size(106, 28)
        Me.cmdTakeOld.TabIndex = 98
        Me.cmdTakeOld.Text = "Take Old Gun"
        Me.cmdTakeOld.UseVisualStyleBackColor = True
        '
        'tmrSpawnCheck
        '
        '
        'tmrDeathCheck
        '
        '
        'tmrTakeWeaponWait
        '
        Me.tmrTakeWeaponWait.Interval = 1000
        '
        'txtTakeWeaponWait
        '
        Me.txtTakeWeaponWait.Enabled = False
        Me.txtTakeWeaponWait.Location = New System.Drawing.Point(502, 357)
        Me.txtTakeWeaponWait.Name = "txtTakeWeaponWait"
        Me.txtTakeWeaponWait.Size = New System.Drawing.Size(25, 20)
        Me.txtTakeWeaponWait.TabIndex = 99
        Me.txtTakeWeaponWait.Text = "15"
        '
        'picActive
        '
        Me.picActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picActive.Image = CType(resources.GetObject("picActive.Image"), System.Drawing.Image)
        Me.picActive.Location = New System.Drawing.Point(317, 511)
        Me.picActive.Name = "picActive"
        Me.picActive.Size = New System.Drawing.Size(115, 115)
        Me.picActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picActive.TabIndex = 100
        Me.picActive.TabStop = False
        '
        'picOnDeck
        '
        Me.picOnDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOnDeck.Image = CType(resources.GetObject("picOnDeck.Image"), System.Drawing.Image)
        Me.picOnDeck.Location = New System.Drawing.Point(438, 576)
        Me.picOnDeck.Name = "picOnDeck"
        Me.picOnDeck.Size = New System.Drawing.Size(50, 50)
        Me.picOnDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOnDeck.TabIndex = 101
        Me.picOnDeck.TabStop = False
        '
        'txtLocationWActive
        '
        Me.txtLocationWActive.Location = New System.Drawing.Point(405, 632)
        Me.txtLocationWActive.Name = "txtLocationWActive"
        Me.txtLocationWActive.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationWActive.TabIndex = 102
        Me.txtLocationWActive.Text = "1"
        '
        'txtLocationOnDeck
        '
        Me.txtLocationOnDeck.Location = New System.Drawing.Point(461, 632)
        Me.txtLocationOnDeck.Name = "txtLocationOnDeck"
        Me.txtLocationOnDeck.Size = New System.Drawing.Size(27, 20)
        Me.txtLocationOnDeck.TabIndex = 103
        Me.txtLocationOnDeck.Text = "1"
        '
        'txtMouseLoc
        '
        Me.txtMouseLoc.Location = New System.Drawing.Point(317, 484)
        Me.txtMouseLoc.Name = "txtMouseLoc"
        Me.txtMouseLoc.Size = New System.Drawing.Size(115, 20)
        Me.txtMouseLoc.TabIndex = 104
        '
        'tmrMouseLoc
        '
        Me.tmrMouseLoc.Enabled = True
        '
        'txt3Strikes
        '
        Me.txt3Strikes.Location = New System.Drawing.Point(502, 186)
        Me.txt3Strikes.Name = "txt3Strikes"
        Me.txt3Strikes.Size = New System.Drawing.Size(27, 20)
        Me.txt3Strikes.TabIndex = 105
        Me.txt3Strikes.Text = "0"
        '
        'txtExcess
        '
        Me.txtExcess.Location = New System.Drawing.Point(502, 66)
        Me.txtExcess.Name = "txtExcess"
        Me.txtExcess.Size = New System.Drawing.Size(48, 20)
        Me.txtExcess.TabIndex = 106
        Me.txtExcess.Text = "excess"
        '
        'AlertPlayer
        '
        Me.AlertPlayer.Enabled = True
        Me.AlertPlayer.Location = New System.Drawing.Point(502, 90)
        Me.AlertPlayer.Name = "AlertPlayer"
        Me.AlertPlayer.OcxState = CType(resources.GetObject("AlertPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AlertPlayer.Size = New System.Drawing.Size(48, 20)
        Me.AlertPlayer.TabIndex = 107
        '
        'txtWinnerLocation
        '
        Me.txtWinnerLocation.Location = New System.Drawing.Point(522, 471)
        Me.txtWinnerLocation.Name = "txtWinnerLocation"
        Me.txtWinnerLocation.Size = New System.Drawing.Size(25, 20)
        Me.txtWinnerLocation.TabIndex = 108
        Me.txtWinnerLocation.Text = "2"
        '
        'picW3
        '
        Me.picW3.Image = CType(resources.GetObject("picW3.Image"), System.Drawing.Image)
        Me.picW3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW3.Location = New System.Drawing.Point(221, 187)
        Me.picW3.Name = "picW3"
        Me.picW3.Size = New System.Drawing.Size(25, 25)
        Me.picW3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW3.TabIndex = 59
        Me.picW3.TabStop = False
        Me.picW3.Tag = "LastWord"
        '
        'picW4
        '
        Me.picW4.Image = CType(resources.GetObject("picW4.Image"), System.Drawing.Image)
        Me.picW4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW4.Location = New System.Drawing.Point(221, 214)
        Me.picW4.Name = "picW4"
        Me.picW4.Size = New System.Drawing.Size(25, 25)
        Me.picW4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW4.TabIndex = 44
        Me.picW4.TabStop = False
        Me.picW4.Tag = "MIDA"
        '
        'picW5
        '
        Me.picW5.Image = CType(resources.GetObject("picW5.Image"), System.Drawing.Image)
        Me.picW5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW5.Location = New System.Drawing.Point(221, 241)
        Me.picW5.Name = "picW5"
        Me.picW5.Size = New System.Drawing.Size(25, 25)
        Me.picW5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW5.TabIndex = 52
        Me.picW5.TabStop = False
        Me.picW5.Tag = "Carlo"
        '
        'picW6
        '
        Me.picW6.Image = CType(resources.GetObject("picW6.Image"), System.Drawing.Image)
        Me.picW6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW6.Location = New System.Drawing.Point(221, 268)
        Me.picW6.Name = "picW6"
        Me.picW6.Size = New System.Drawing.Size(25, 25)
        Me.picW6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW6.TabIndex = 60
        Me.picW6.TabStop = False
        Me.picW6.Tag = "NLB"
        '
        'picW7
        '
        Me.picW7.Image = CType(resources.GetObject("picW7.Image"), System.Drawing.Image)
        Me.picW7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW7.Location = New System.Drawing.Point(221, 295)
        Me.picW7.Name = "picW7"
        Me.picW7.Size = New System.Drawing.Size(25, 25)
        Me.picW7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW7.TabIndex = 45
        Me.picW7.TabStop = False
        Me.picW7.Tag = "NTtE"
        '
        'picW8
        '
        Me.picW8.Image = CType(resources.GetObject("picW8.Image"), System.Drawing.Image)
        Me.picW8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW8.Location = New System.Drawing.Point(221, 322)
        Me.picW8.Name = "picW8"
        Me.picW8.Size = New System.Drawing.Size(25, 25)
        Me.picW8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW8.TabIndex = 53
        Me.picW8.TabStop = False
        Me.picW8.Tag = "RedDeath"
        '
        'picW9
        '
        Me.picW9.Image = CType(resources.GetObject("picW9.Image"), System.Drawing.Image)
        Me.picW9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW9.Location = New System.Drawing.Point(221, 349)
        Me.picW9.Name = "picW9"
        Me.picW9.Size = New System.Drawing.Size(25, 25)
        Me.picW9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW9.TabIndex = 61
        Me.picW9.TabStop = False
        Me.picW9.Tag = "Regime"
        '
        'picW10
        '
        Me.picW10.Image = CType(resources.GetObject("picW10.Image"), System.Drawing.Image)
        Me.picW10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW10.Location = New System.Drawing.Point(221, 376)
        Me.picW10.Name = "picW10"
        Me.picW10.Size = New System.Drawing.Size(25, 25)
        Me.picW10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW10.TabIndex = 46
        Me.picW10.TabStop = False
        Me.picW10.Tag = "Thorn"
        '
        'picW11
        '
        Me.picW11.Image = CType(resources.GetObject("picW11.Image"), System.Drawing.Image)
        Me.picW11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW11.Location = New System.Drawing.Point(221, 403)
        Me.picW11.Name = "picW11"
        Me.picW11.Size = New System.Drawing.Size(25, 25)
        Me.picW11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW11.TabIndex = 57
        Me.picW11.TabStop = False
        Me.picW11.Tag = "PDX45"
        '
        'picW12
        '
        Me.picW12.Image = CType(resources.GetObject("picW12.Image"), System.Drawing.Image)
        Me.picW12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW12.Location = New System.Drawing.Point(221, 430)
        Me.picW12.Name = "picW12"
        Me.picW12.Size = New System.Drawing.Size(25, 25)
        Me.picW12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW12.TabIndex = 54
        Me.picW12.TabStop = False
        Me.picW12.Tag = "Remote"
        '
        'picW13
        '
        Me.picW13.Image = CType(resources.GetObject("picW13.Image"), System.Drawing.Image)
        Me.picW13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW13.Location = New System.Drawing.Point(221, 457)
        Me.picW13.Name = "picW13"
        Me.picW13.Size = New System.Drawing.Size(25, 25)
        Me.picW13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW13.TabIndex = 62
        Me.picW13.TabStop = False
        Me.picW13.Tag = "Vex"
        '
        'picW14
        '
        Me.picW14.Image = CType(resources.GetObject("picW14.Image"), System.Drawing.Image)
        Me.picW14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW14.Location = New System.Drawing.Point(221, 484)
        Me.picW14.Name = "picW14"
        Me.picW14.Size = New System.Drawing.Size(25, 25)
        Me.picW14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW14.TabIndex = 47
        Me.picW14.TabStop = False
        Me.picW14.Tag = "Zhalo"
        '
        'picW15
        '
        Me.picW15.BackColor = System.Drawing.Color.Yellow
        Me.picW15.Image = CType(resources.GetObject("picW15.Image"), System.Drawing.Image)
        Me.picW15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW15.Location = New System.Drawing.Point(221, 511)
        Me.picW15.Name = "picW15"
        Me.picW15.Size = New System.Drawing.Size(25, 25)
        Me.picW15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW15.TabIndex = 55
        Me.picW15.TabStop = False
        Me.picW15.Tag = "Random"
        '
        'picW16
        '
        Me.picW16.Image = CType(resources.GetObject("picW16.Image"), System.Drawing.Image)
        Me.picW16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW16.Location = New System.Drawing.Point(221, 538)
        Me.picW16.Name = "picW16"
        Me.picW16.Size = New System.Drawing.Size(25, 25)
        Me.picW16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW16.TabIndex = 63
        Me.picW16.TabStop = False
        '
        'picW17
        '
        Me.picW17.Image = CType(resources.GetObject("picW17.Image"), System.Drawing.Image)
        Me.picW17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW17.Location = New System.Drawing.Point(221, 565)
        Me.picW17.Name = "picW17"
        Me.picW17.Size = New System.Drawing.Size(25, 25)
        Me.picW17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW17.TabIndex = 48
        Me.picW17.TabStop = False
        '
        'picW18
        '
        Me.picW18.Image = CType(resources.GetObject("picW18.Image"), System.Drawing.Image)
        Me.picW18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW18.Location = New System.Drawing.Point(221, 592)
        Me.picW18.Name = "picW18"
        Me.picW18.Size = New System.Drawing.Size(25, 25)
        Me.picW18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW18.TabIndex = 56
        Me.picW18.TabStop = False
        '
        'picW19
        '
        Me.picW19.Image = CType(resources.GetObject("picW19.Image"), System.Drawing.Image)
        Me.picW19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW19.Location = New System.Drawing.Point(221, 619)
        Me.picW19.Name = "picW19"
        Me.picW19.Size = New System.Drawing.Size(25, 25)
        Me.picW19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW19.TabIndex = 49
        Me.picW19.TabStop = False
        '
        'picW2
        '
        Me.picW2.Image = CType(resources.GetObject("picW2.Image"), System.Drawing.Image)
        Me.picW2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picW2.Location = New System.Drawing.Point(221, 160)
        Me.picW2.Name = "picW2"
        Me.picW2.Size = New System.Drawing.Size(25, 25)
        Me.picW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picW2.TabIndex = 51
        Me.picW2.TabStop = False
        Me.picW2.Tag = "Hawkmoon"
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(302, 260)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(100, 20)
        Me.txtNick.TabIndex = 109
        Me.txtNick.Text = "Nick"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(302, 286)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 110
        Me.txtPass.Text = "Pass"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(302, 312)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 111
        Me.txtServer.Text = "Server"
        '
        'txtChan
        '
        Me.txtChan.Location = New System.Drawing.Point(302, 338)
        Me.txtChan.Name = "txtChan"
        Me.txtChan.Size = New System.Drawing.Size(100, 20)
        Me.txtChan.TabIndex = 112
        Me.txtChan.Text = "Chan"
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(302, 388)
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(100, 20)
        Me.txtChat.TabIndex = 113
        '
        'frmDestinyWeaponSwap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(553, 681)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtChan)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNick)
        Me.Controls.Add(Me.txtWinnerLocation)
        Me.Controls.Add(Me.AlertPlayer)
        Me.Controls.Add(Me.txtExcess)
        Me.Controls.Add(Me.txt3Strikes)
        Me.Controls.Add(Me.txtMouseLoc)
        Me.Controls.Add(Me.txtLocationOnDeck)
        Me.Controls.Add(Me.txtLocationWActive)
        Me.Controls.Add(Me.picOnDeck)
        Me.Controls.Add(Me.picActive)
        Me.Controls.Add(Me.txtTakeWeaponWait)
        Me.Controls.Add(Me.cmdTakeOld)
        Me.Controls.Add(Me.cmdSendNew)
        Me.Controls.Add(Me.txtVoteCountdown)
        Me.Controls.Add(Me.cmdStartVote)
        Me.Controls.Add(Me.txtLastGun)
        Me.Controls.Add(Me.txtRandomGun3)
        Me.Controls.Add(Me.txtRandomGun2)
        Me.Controls.Add(Me.txtRandomGun1)
        Me.Controls.Add(Me.cmdRandomWeapons)
        Me.Controls.Add(Me.txtLocationW19)
        Me.Controls.Add(Me.txtLocationW18)
        Me.Controls.Add(Me.txtLocationW17)
        Me.Controls.Add(Me.txtLocationW16)
        Me.Controls.Add(Me.txtLocationW15)
        Me.Controls.Add(Me.txtLocationW14)
        Me.Controls.Add(Me.txtLocationW13)
        Me.Controls.Add(Me.txtLocationW12)
        Me.Controls.Add(Me.txtLocationW11)
        Me.Controls.Add(Me.txtLocationW10)
        Me.Controls.Add(Me.txtLocationW9)
        Me.Controls.Add(Me.txtLocationW8)
        Me.Controls.Add(Me.txtLocationW7)
        Me.Controls.Add(Me.txtLocationW6)
        Me.Controls.Add(Me.txtLocationW5)
        Me.Controls.Add(Me.txtLocationW4)
        Me.Controls.Add(Me.txtLocationW3)
        Me.Controls.Add(Me.txtLocationW2)
        Me.Controls.Add(Me.txtLocationW1)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.txtCheckYes)
        Me.Controls.Add(Me.txtPlayerStatus)
        Me.Controls.Add(Me.picReticleColor)
        Me.Controls.Add(Me.txtReticleColor)
        Me.Controls.Add(Me.picW16)
        Me.Controls.Add(Me.picW13)
        Me.Controls.Add(Me.picW9)
        Me.Controls.Add(Me.picW6)
        Me.Controls.Add(Me.picW3)
        Me.Controls.Add(Me.picW11)
        Me.Controls.Add(Me.picW18)
        Me.Controls.Add(Me.picW15)
        Me.Controls.Add(Me.picW12)
        Me.Controls.Add(Me.picW8)
        Me.Controls.Add(Me.picW5)
        Me.Controls.Add(Me.picW2)
        Me.Controls.Add(Me.picW19)
        Me.Controls.Add(Me.picW17)
        Me.Controls.Add(Me.picW14)
        Me.Controls.Add(Me.picW10)
        Me.Controls.Add(Me.picW7)
        Me.Controls.Add(Me.picW4)
        Me.Controls.Add(Me.picW1)
        Me.Controls.Add(Me.txtUpDown)
        Me.Controls.Add(Me.cmdUpDown)
        Me.Controls.Add(Me.txtTotalVotes)
        Me.Controls.Add(Me.txtVote3)
        Me.Controls.Add(Me.cmdVote3)
        Me.Controls.Add(Me.txtVote2)
        Me.Controls.Add(Me.cmdVote2)
        Me.Controls.Add(Me.txtVote1)
        Me.Controls.Add(Me.cmdVote1)
        Me.Controls.Add(Me.lblWeaponName3)
        Me.Controls.Add(Me.lblWeaponName2)
        Me.Controls.Add(Me.lblWeaponName1)
        Me.Controls.Add(Me.barVote1)
        Me.Controls.Add(Me.barVote2)
        Me.Controls.Add(Me.barVote3)
        Me.Controls.Add(Me.picWeapon3)
        Me.Controls.Add(Me.picWeapon2)
        Me.Controls.Add(Me.picWeapon1)
        Me.Controls.Add(Me.picSwapPlate)
        Me.KeyPreview = True
        Me.Name = "frmDestinyWeaponSwap"
        Me.Text = "Destiny Weapon Swap"
        CType(Me.picWeapon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeapon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeapon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSwapPlate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReticleColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOnDeck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlertPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picW2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picWeapon1 As PictureBox
    Friend WithEvents picWeapon2 As PictureBox
    Friend WithEvents picWeapon3 As PictureBox
    Friend WithEvents picSwapPlate As PictureBox
    Friend WithEvents barVote3 As PictureBox
    Friend WithEvents barVote2 As PictureBox
    Friend WithEvents barVote1 As PictureBox
    Friend WithEvents lblWeaponName1 As Label
    Friend WithEvents lblWeaponName2 As Label
    Friend WithEvents lblWeaponName3 As Label
    Friend WithEvents cmdVote1 As Button
    Friend WithEvents txtVote1 As TextBox
    Friend WithEvents txtVote2 As TextBox
    Friend WithEvents cmdVote2 As Button
    Friend WithEvents txtVote3 As TextBox
    Friend WithEvents cmdVote3 As Button
    Friend WithEvents txtTotalVotes As TextBox
    Friend WithEvents cmdUpDown As Button
    Friend WithEvents tmrUpDown As Timer
    Friend WithEvents txtUpDown As TextBox
    Friend WithEvents picW1 As PictureBox
    Friend WithEvents txtCheckNo As TextBox
    Friend WithEvents txtCheckYes As TextBox
    Friend WithEvents txtPlayerStatus As TextBox
    Friend WithEvents picReticleColor As PictureBox
    Friend WithEvents txtReticleColor As TextBox
    Friend WithEvents txtLocationW1 As TextBox
    Friend WithEvents txtLocationW2 As TextBox
    Friend WithEvents txtLocationW3 As TextBox
    Friend WithEvents txtLocationW4 As TextBox
    Friend WithEvents txtLocationW5 As TextBox
    Friend WithEvents txtLocationW6 As TextBox
    Friend WithEvents txtLocationW7 As TextBox
    Friend WithEvents txtLocationW8 As TextBox
    Friend WithEvents txtLocationW9 As TextBox
    Friend WithEvents txtLocationW10 As TextBox
    Friend WithEvents txtLocationW11 As TextBox
    Friend WithEvents txtLocationW12 As TextBox
    Friend WithEvents txtLocationW13 As TextBox
    Friend WithEvents txtLocationW14 As TextBox
    Friend WithEvents txtLocationW15 As TextBox
    Friend WithEvents txtLocationW16 As TextBox
    Friend WithEvents txtLocationW17 As TextBox
    Friend WithEvents txtLocationW18 As TextBox
    Friend WithEvents txtLocationW19 As TextBox
    Friend WithEvents cmdSendNew As Button
    Friend WithEvents txtVoteCountdown As TextBox
    Friend WithEvents cmdStartVote As Button
    Friend WithEvents txtLastGun As TextBox
    Friend WithEvents txtRandomGun3 As TextBox
    Friend WithEvents txtRandomGun2 As TextBox
    Friend WithEvents txtRandomGun1 As TextBox
    Friend WithEvents cmdRandomWeapons As Button
    Friend WithEvents tmrVote As Timer
    Friend WithEvents tmrReticleCheck As Timer
    Friend WithEvents cmdTakeOld As Button
    Friend WithEvents tmrSpawnCheck As Timer
    Friend WithEvents tmrDeathCheck As Timer
    Friend WithEvents tmrTakeWeaponWait As Timer
    Friend WithEvents txtTakeWeaponWait As TextBox
    Friend WithEvents picActive As PictureBox
    Friend WithEvents picOnDeck As PictureBox
    Friend WithEvents txtLocationWActive As TextBox
    Friend WithEvents txtLocationOnDeck As TextBox
    Friend WithEvents txtMouseLoc As TextBox
    Friend WithEvents tmrMouseLoc As Timer
    Friend WithEvents txt3Strikes As TextBox
    Friend WithEvents txtExcess As TextBox
    Friend WithEvents AlertPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txtWinnerLocation As TextBox
    Friend WithEvents picW3 As PictureBox
    Friend WithEvents picW4 As PictureBox
    Friend WithEvents picW5 As PictureBox
    Friend WithEvents picW6 As PictureBox
    Friend WithEvents picW7 As PictureBox
    Friend WithEvents picW8 As PictureBox
    Friend WithEvents picW9 As PictureBox
    Friend WithEvents picW10 As PictureBox
    Friend WithEvents picW11 As PictureBox
    Friend WithEvents picW12 As PictureBox
    Friend WithEvents picW13 As PictureBox
    Friend WithEvents picW14 As PictureBox
    Friend WithEvents picW15 As PictureBox
    Friend WithEvents picW16 As PictureBox
    Friend WithEvents picW17 As PictureBox
    Friend WithEvents picW18 As PictureBox
    Friend WithEvents picW19 As PictureBox
    Friend WithEvents picW2 As PictureBox
    Friend WithEvents txtNick As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtChan As TextBox
    Friend WithEvents txtChat As TextBox
End Class
