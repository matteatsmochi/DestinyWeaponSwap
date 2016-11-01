Imports System.Runtime.InteropServices

Public Class frmDestinyWeaponSwap
    ' Set up Arrays for Weapons
    Dim picAllWeapons() As PictureBox
    Dim picWeapons() As PictureBox
    Dim barVotes() As PictureBox
    Dim lblWeapons() As Label
    Dim txtWeapons() As TextBox
    Dim txtLocations() As TextBox
    Dim txtVotes() As TextBox
    Dim PoolCap As Integer
    Dim PointX As Integer
    Dim PointY As Integer
    Dim RandomOrNo As Integer
    ' IRC Variables
    Dim WithEvents Client As New IrcDotNet.TwitchIrcClient
    Dim OAuth As String
    Dim Username As String
    Dim Server As String = "irc.twitch.tv"
    Dim Info As New IrcDotNet.IrcUserRegistrationInfo
    'One-Line Sub Declarations
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)


    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312
    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function
    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    Vote(1)

                Case "200"
                    Vote(2)

                Case "300"
                    Vote(3)

            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub frmDestinyWeaponSwap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = "570"
        barVotes = New PictureBox() {barVote1, barVote2, barVote3}
        txtVotes = New TextBox() {txtVote1, txtVote2, txtVote3}
        txtWeapons = New TextBox() {txtRandomGun1, txtRandomGun2, txtRandomGun3}
        txtLocations = New TextBox() {txtLocationW1, txtLocationW2, txtLocationW3, txtLocationW4, txtLocationW5, txtLocationW6, txtLocationW7, txtLocationW8, txtLocationW9, txtLocationW10, txtLocationW11, txtLocationW12, txtLocationW13, txtLocationW14, txtLocationW15}
        lblWeapons = New Label() {lblWeaponName1, lblWeaponName2, lblWeaponName3}
        picWeapons = New PictureBox() {picWeapon1, picWeapon2, picWeapon3}
        picAllWeapons = New PictureBox() {picW1, picW2, picW3, picW4, picW5, picW6, picW7, picW8, picW9, picW10, picW11, picW12, picW13, picW14, picW15}
        Client.FloodPreventer = New IrcDotNet.IrcStandardFloodPreventer(4, 2000)
        Down()
        RandomWeapons()
        LoadSettings()

        'Loading the Form and putting all image boxes in the correct place
        RegisterHotKey(Me.Handle, 100, 0, Keys.F6)
        RegisterHotKey(Me.Handle, 200, 0, Keys.F7)
        RegisterHotKey(Me.Handle, 300, 0, Keys.F8)
    End Sub
    Private Sub frmDestinyWeaponSwap_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Save settings when closing nick pass channel auto
        My.Settings.Nick = txtNick.Text
        My.Settings.Pass = txtPass.Text
        My.Settings.Channel = txtChan.Text
        My.Settings.AutoJoin = chkAutoJoin.Checked

        My.Settings.Random = chkRandom.Checked
        My.Settings.RandomOrNo = RandomOrNo
        My.Settings.LocW2 = txtLocationW2.Text
        My.Settings.LocW3 = txtLocationW3.Text
        My.Settings.LocW4 = txtLocationW4.Text
        My.Settings.LocW5 = txtLocationW5.Text
        My.Settings.LocW6 = txtLocationW6.Text
        My.Settings.LocW7 = txtLocationW7.Text
        My.Settings.LocW8 = txtLocationW8.Text
        My.Settings.LocW9 = txtLocationW9.Text
        My.Settings.LocW10 = txtLocationW10.Text
        My.Settings.LocW11 = txtLocationW11.Text
        My.Settings.LocW12 = txtLocationW12.Text
        My.Settings.LocW13 = txtLocationW13.Text
        My.Settings.LocW14 = txtLocationW14.Text
        My.Settings.LocW15 = txtLocationW15.Text


        My.Settings.Weapon2 = picW2.Tag
        My.Settings.Weapon3 = picW3.Tag
        My.Settings.Weapon4 = picW4.Tag
        My.Settings.Weapon5 = picW5.Tag
        My.Settings.Weapon6 = picW6.Tag
        My.Settings.Weapon7 = picW7.Tag
        My.Settings.Weapon8 = picW8.Tag
        My.Settings.Weapon9 = picW9.Tag
        My.Settings.Weapon10 = picW10.Tag
        My.Settings.Weapon11 = picW11.Tag
        My.Settings.Weapon12 = picW12.Tag
        My.Settings.Weapon13 = picW13.Tag
        My.Settings.Weapon14 = picW14.Tag
        My.Settings.Weapon15 = picW15.Tag

        My.Settings.PoolCap = PoolCap

        My.Settings.PointX = PointX
        My.Settings.PointY = PointY
    End Sub
    Private Sub LoadSettings()
        'Load user settings
        txtNick.Text = My.Settings.Nick
        txtPass.Text = My.Settings.Pass
        txtChan.Text = My.Settings.Channel
        chkAutoJoin.Checked = My.Settings.AutoJoin

        chkRandom.Checked = My.Settings.Random
        RandomOrNo = My.Settings.RandomOrNo
        txtLocationW2.Text = My.Settings.LocW2
        txtLocationW3.Text = My.Settings.LocW3
        txtLocationW4.Text = My.Settings.LocW4
        txtLocationW5.Text = My.Settings.LocW5
        txtLocationW6.Text = My.Settings.LocW6
        txtLocationW7.Text = My.Settings.LocW7
        txtLocationW8.Text = My.Settings.LocW8
        txtLocationW9.Text = My.Settings.LocW9
        txtLocationW10.Text = My.Settings.LocW10
        txtLocationW11.Text = My.Settings.LocW11
        txtLocationW12.Text = My.Settings.LocW12
        txtLocationW13.Text = My.Settings.LocW13
        txtLocationW14.Text = My.Settings.LocW14


        picW2.Tag = My.Settings.Weapon2
        picW3.Tag = My.Settings.Weapon3
        picW4.Tag = My.Settings.Weapon4
        picW5.Tag = My.Settings.Weapon5
        picW6.Tag = My.Settings.Weapon6
        picW7.Tag = My.Settings.Weapon7
        picW8.Tag = My.Settings.Weapon8
        picW9.Tag = My.Settings.Weapon9
        picW10.Tag = My.Settings.Weapon10
        picW11.Tag = My.Settings.Weapon11
        picW12.Tag = My.Settings.Weapon12
        picW13.Tag = My.Settings.Weapon13
        picW14.Tag = My.Settings.Weapon14

        'load weapons images into slots based on tag info. any new guns added must be added to this list
        For i = 1 To 14
            Select Case picAllWeapons(i).Tag
                Case "Hawksaw"
                    picAllWeapons(i).Image = My.Resources.Hawksaw
                Case "Hawkmoon"
                    picAllWeapons(i).Image = My.Resources.Hawkmoon
                Case "LastWord"
                    picAllWeapons(i).Image = My.Resources.LastWord
                Case "MIDA"
                    picAllWeapons(i).Image = My.Resources.MIDA
                Case "MonteCarlo"
                    picAllWeapons(i).Image = My.Resources.MonteCarlo
                Case "Palindrome"
                    picAllWeapons(i).Image = My.Resources.Palindrome
                Case "NTTE"
                    picAllWeapons(i).Image = My.Resources.NTTE
                Case "SurosRegime"
                    picAllWeapons(i).Image = My.Resources.SurosRegime
                Case "Thorn"
                    picAllWeapons(i).Image = My.Resources.Thorn
                Case "PDX45"
                    picAllWeapons(i).Image = My.Resources.PDX45
                Case "UniversalRemote"
                    picAllWeapons(i).Image = My.Resources.UniversalRemote
                Case "Vex"
                    picAllWeapons(i).Image = My.Resources.Vex
                Case "Zhalo"
                    picAllWeapons(i).Image = My.Resources.Zhalo
            End Select
        Next

        PoolCap = My.Settings.PoolCap
        'SetPool()

        PointX = My.Settings.PointX
        PointY = My.Settings.PointY
    End Sub
    Private Sub Down()
        cmdVote1.Enabled = Not cmdVote1.Enabled
        cmdVote2.Enabled = Not cmdVote2.Enabled
        cmdVote3.Enabled = Not cmdVote3.Enabled
        tmrUpDown.Enabled = False
        cmdUpDown.Text = "Up"
        txtUpDown.Text = "0"
        For i = 0 To 2
            picWeapons(i).Left = -248
            lblWeapons(i).Left = -248
            barVotes(i).Left = -250
        Next
        picSwapPlate.Left = -250
    End Sub
    Private Sub ReloadDIM()
        FocusDIM()
        MouseMover1(379, 123)
    End Sub
    Private Sub FocusDIM()
        MouseMover1(451, 13)
    End Sub
    Private Sub FocusDIS()
        MouseMover1(1124, 107)
    End Sub
    Private Sub UpDown()
        tmrUpDown.Enabled = True
    End Sub
    Private Sub UpdateTotalVotes()
        txtTotalVotes.Text = 0
        For i = 0 To 2
            txtTotalVotes.Text += Int(txtVotes(i).Text)
        Next
    End Sub
    Private Sub UpdateVoteBars()
        For i = 0 To 2
            barVotes(i).Width = (txtVotes(i).Text / txtTotalVotes.Text) * 200
        Next
    End Sub
    Private Sub UpdateVotes()
        UpdateTotalVotes()
        UpdateVoteBars()
    End Sub
    Private Sub Vote(i As Integer) 'Send as 1,2,3 not zero
        txtVotes(i - 1).Text += 1
        UpdateVotes()
    End Sub
    Private Sub TakeOld()
        FocusDIM()
        MouseMover2(116, 311, 282, 272)

        tmrReticleCheck.Enabled = True 'start checking for death again
        FocusDIS()

        picActive.Image = picOnDeck.Image
        txtLocationWActive.Text = txtLocationOnDeck.Text
        picOnDeck.Image = My.Resources.Null
        txtLocationOnDeck.Text = "0"

        System.Threading.Thread.Sleep(200)
    End Sub
    Private Sub StartVote()
        cmdStartVote.Enabled = False
        TakeOld() 'take old weapon
        System.Threading.Thread.Sleep(200)
        FocusDIS()
        tmrVote.Enabled = True 'Vote only lasts during this duration
        RandomWeapons() 'Mix up all guns
        If cmdUpDown.Text <> "Down" Then
            UpDown() 'Move up all voting options into visible field
        End If
        My.Computer.Audio.Play(My.Resources.VoteStart, AudioPlayMode.Background)
    End Sub
    Private Sub RandomWeapons()
        Dim looper As Boolean
        Dim i, j As Integer
        'Select 3 Ramdom Guns for a poll. Do not include the last used gun

        For i = 0 To 2
            txtWeapons(i).Text = Rand(RandomOrNo, 15)
        Next

        Do
            looper = False
            If txtRandomGun1.Text = txtRandomGun2.Text Or txtRandomGun2.Text = txtRandomGun3.Text Or txtRandomGun1.Text = txtRandomGun3.Text Then
                If txtRandomGun1.Text = txtRandomGun2.Text Then
                    txtRandomGun1.Text = Rand(RandomOrNo, 15)
                ElseIf txtRandomGun2.Text = txtRandomGun3.Text Then
                    txtRandomGun2.Text = Rand(RandomOrNo, 15)
                ElseIf txtRandomGun1.Text = txtRandomGun3.Text Then
                    txtRandomGun3.Text = Rand(RandomOrNo, 15)
                End If
                looper = True
            ElseIf txtRandomGun1.Text = txtLastGun.Text Or txtRandomGun2.Text = txtLastGun.Text Or txtRandomGun3.Text = txtLastGun.Text Then
                If txtRandomGun1.Text = txtLastGun.Text Then
                    txtRandomGun1.Text = Rand(RandomOrNo, 15)
                ElseIf txtRandomGun2.Text = txtLastGun.Text Then
                    txtRandomGun2.Text = Rand(RandomOrNo, 15)
                ElseIf txtRandomGun3.Text = txtLastGun.Text Then
                    txtRandomGun3.Text = Rand(RandomOrNo, 15)
                End If
                looper = True


                looper = True
            End If
        Loop While looper

        'Based on number, place Weapon Image and Name into picWeapon and lblWeaponName for all 3 Weapons
        For i = 0 To 2
            j = Int(txtWeapons(i).Text) - 1
            picWeapons(i).Image = picAllWeapons(j).Image
            lblWeapons(i).Text = picAllWeapons(j).Tag
        Next

    End Sub
    Private Sub Voter(weaponvote As String)
        For i = 0 To 2
            If lblWeapons(i).Text = weaponvote Then
                SetChanChat(lblWeapons(i).Text & " " & weaponvote & " " & i)
                Vote(i + 1)
            End If
        Next
    End Sub



    Private Sub cmdVote1_Click(sender As Object, e As EventArgs) Handles cmdVote1.Click
        Vote(1)
    End Sub
    Private Sub cmdVote2_Click(sender As Object, e As EventArgs) Handles cmdVote2.Click
        Vote(2)
    End Sub
    Private Sub cmdVote3_Click(sender As Object, e As EventArgs) Handles cmdVote3.Click
        Vote(3)
    End Sub
    Private Sub tmrUpDown_Tick(sender As Object, e As EventArgs) Handles tmrUpDown.Tick
        'Moving Vote options up (when starting vote) or down (when vote is over)
        If txtUpDown.Text = 125 Then
            tmrUpDown.Enabled = False
            txtUpDown.Text = "0"
            txtTotalVotes.Text = "0"
            If cmdUpDown.Text = "Up" Then
                cmdUpDown.Text = "Down"
            Else
                cmdUpDown.Text = "Up"
            End If
        ElseIf cmdUpDown.Text = "Up" Then
            Mover(2)
        ElseIf cmdUpDown.Text = "Down" Then
            Mover(-2)
        End If
    End Sub
    Private Sub Mover(x As Integer) '-2 for left, 2 for right
        For i = 0 To 2
            picWeapons(i).Left += x
            lblWeapons(i).Left += x
            barVotes(i).Left += x
        Next
        picSwapPlate.Left += x
        'Mark the timer up by 1 (until it reaches 125)
        txtUpDown.Text += 1
    End Sub
    Private Sub cmdUpDown_Click(sender As Object, e As EventArgs) Handles cmdUpDown.Click
        UpDown()
    End Sub
    Private Sub cmdRandomHeroes_Click(sender As Object, e As EventArgs) Handles cmdRandomWeapons.Click
        RandomWeapons()
    End Sub
    Private Sub cmdTakeOld_Click(sender As Object, e As EventArgs) Handles cmdTakeOld.Click
        TakeOld()
    End Sub
    Private Sub SlotToLocation()
        txtWinnerLocation.Text = txtLocations(Int(txtLastGun.Text) - 1).Text
    End Sub
    Private Function Rand(lowerbound As Integer, upperbound As Integer) As Integer
        Randomize()
        Return CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function
    Private Sub tmrVote_Tick(sender As Object, e As EventArgs) Handles tmrVote.Tick
        If txtVoteCountdown.Text = 0 Then
            'Vote is over. Declare winner
            'Check who had the most votes. Move that to txtLastWeapon.text
            CheckForWin()
            CheckForTies()
            If txtLastGun.Text = 15 Then 'selects random gun if random option wins
                txtLastGun.Text = Rand(1, 14)
            End If
            UpDown() 'send all voting options down
            SlotToLocation() 'set up location for slot of gun to send
            SendNew() 'send over the new gun
            txtVoteCountdown.Text = "45" 'reset voting countdown timer
            tmrVote.Enabled = False 'stop counting down
            tmrReticleCheck.Enabled = True 'start watching again
        Else
            txtVoteCountdown.Text = txtVoteCountdown.Text - 1 'countdown from timer by 1
            YesNoReticleDeathSpawnStatus(False, False, False)
        End If
    End Sub
    Private Sub CheckForWin()
        If txtVote1.Text > txtVote2.Text And txtVote1.Text > txtVote3.Text Then
            txtLastGun.Text = txtRandomGun1.Text
        ElseIf txtVote2.Text > txtVote1.Text And txtVote2.Text > txtVote3.Text Then
            txtLastGun.Text = txtRandomGun2.Text
        ElseIf txtVote3.Text > txtVote1.Text And txtVote3.Text > txtVote2.Text Then
            txtLastGun.Text = txtRandomGun3.Text
        End If
    End Sub
    Private Sub CheckForTies()
        Dim randomValue As Integer
        If txtVote1.Text = txtVote2.Text And txtVote2.Text = txtVote3.Text Then 'Check for ties
            randomValue = Rand(0, 2)
            txtLastGun.Text = txtWeapons(randomValue).Text
        ElseIf txtVote1.Text = txtVote2.Text And txtVote3.Text < txtVote1.Text Then
            randomValue = Rand(0, 1)
            txtLastGun.Text = txtWeapons(randomValue).Text
        ElseIf txtVote1.Text = txtVote3.Text And txtVote2.Text < txtVote1.Text Then
            randomValue = Rand(1, 2)
            If randomValue = 1 Then
                txtLastGun.Text = txtRandomGun1.Text
            Else
                txtLastGun.Text = txtRandomGun3.Text
            End If
        ElseIf txtVote2.Text = txtVote3.Text And txtVote1.Text < txtVote3.Text Then
            randomValue = Rand(1, 2)
            txtLastGun.Text = txtWeapons(randomValue).Text
        End If
    End Sub
    Private Sub tmrReticleCheck_Tick(sender As Object, e As EventArgs) Handles tmrReticleCheck.Tick
        CheckPixels()
        'All presumptions on the characters dead/alive status are founded on the presence or absence of the reticle being visible
        If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
            If txtPlayerStatus.Text <> "Dead" Then 'Just died- Run spawn check
                tmrReticleCheck.Enabled = False
                tmrDeathCheck.Enabled = True
            End If
        Else
            If txtPlayerStatus.Text <> "Alive" Then 'Just spawned- Run death check
                tmrReticleCheck.Enabled = False
                tmrSpawnCheck.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmdStartVote_Click(sender As Object, e As EventArgs) Handles cmdStartVote.Click
        cmdVote1.Enabled = True
        cmdVote2.Enabled = True
        cmdVote3.Enabled = True
        For i = 0 To 2
            txtVotes(i).Text = "0"
            barVotes(i).Width = 0
        Next
        StartVote()
    End Sub
    Private Sub tmrSpawnCheck_Tick(sender As Object, e As EventArgs) Handles tmrSpawnCheck.Tick
        CheckPixels()
        If txtCheckYes.Text = 10 Then 'Player did respawn. Start the new vote & reset.
            YesNoReticleDeathSpawnStatus(True, tmrDeathCheck.Enabled, False, "Alive")
            If txt3Strikes.Text = 4 Then
                StartVote()
                txt3Strikes.Text = 0
            End If
        ElseIf txtCheckNo.Text = 0 Then 'false positive. Player did not respawn. Reset & Keep waiting.
            YesNoReticleDeathSpawnStatus(True, tmrDeathCheck.Enabled, False)
        Else 'expecting to see NO white. If we do, return No
            If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
                txtCheckNo.Text = txtCheckNo.Text - 1
            Else
                txtCheckYes.Text = txtCheckYes.Text + 1
            End If
        End If
    End Sub
    Private Sub tmrDeathCheck_Tick(sender As Object, e As EventArgs) Handles tmrDeathCheck.Tick
        CheckPixels()
        If txtCheckYes.Text = 10 Then 'Guardian did die. Switch Weapons
            YesNoReticleDeathSpawnStatus(True, False, tmrSpawnCheck.Enabled, "Dead")
            txt3Strikes.Text += 1
            If txt3Strikes.Text = 0 Then
                My.Computer.Audio.Play(My.Resources.SwitchGun, AudioPlayMode.Background)
            ElseIf txt3Strikes.Text = 1 Then
                ReloadDIM()
                FocusDIS()
            End If
        ElseIf txtCheckNo.Text = 0 Then 'false positive. Player did not die. Reset & Keep waiting.
            YesNoReticleDeathSpawnStatus(True, False, tmrSpawnCheck.Enabled)
        Else 'expecting to see red. If we dont, return No
            If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
                txtCheckYes.Text += 1
            Else
                txtCheckNo.Text -= 1
            End If
        End If
    End Sub
    Private Sub YesNoReticleDeathSpawnStatus(reticle As Boolean, death As Boolean, spawn As Boolean, Optional ByVal status As String = "")
        If status <> "" Then
            txtPlayerStatus.Text = status
        End If
        txtCheckYes.Text = "0"
        txtCheckNo.Text = "10"
        tmrReticleCheck.Enabled = reticle
        tmrDeathCheck.Enabled = death
        tmrSpawnCheck.Enabled = spawn
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMouseLoc.Tick
        Dim MPx As Point = MousePosition()
        txtMouseLoc.Text = MPx.ToString

    End Sub
    Private Sub SendNew()
        'Send clicks to switch Weapons in game - to be used on death screen
        'Checks what Weapon was last voted for (txtLastWeapon.text)
        FocusDIM()
        My.Computer.Audio.Play(My.Resources.VoteEnd, AudioPlayMode.Background)
        cmdStartVote.Enabled = True
        cmdVote1.Enabled = False
        cmdVote2.Enabled = False
        cmdVote3.Enabled = False
        SendSlot(txtWinnerLocation.Text)
        txtLocationOnDeck.Text = txtWinnerLocation.Text
        picOnDeck.Image = picAllWeapons(Int(txtLastGun.Text) - 1).Image
    End Sub
    Private Sub cmdSendNew_Click(sender As Object, e As EventArgs) Handles cmdSendNew.Click
        SendNew()
    End Sub
    Private Sub SendSlot(i As Integer)
        MouseMover2(216, 172, 145, 230 + (i * 30) - 30)
    End Sub
    Private Sub MouseMover1(x1 As Integer, y1 As Integer)
        Me.Cursor = New Cursor(Cursor.Current.Handle)

        Cursor.Position = New Point(x1, y1)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub
    Private Sub MouseMover2(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Me.Cursor = New Cursor(Cursor.Current.Handle)

        Cursor.Position = New Point(x1, y1)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)

        Cursor.Position = New Point(x2, y2)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub
    Private Sub CheckPixels()
        'Checking 1 pixel at the bottom center of Destiny in capture app
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(PointX, PointY), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name
        If txtReticleColor.Text.Length > 4 Then
            txtReticleColor.Text = txtReticleColor.Text.Substring(0, txtReticleColor.Text.Length - 4)
        End If
    End Sub
    Private Sub cmdManualAuto_Click(sender As Object, e As EventArgs) Handles cmdManualAuto.Click
        If cmdManualAuto.Text = "Manual" Then
            txt3Strikes.Text = "15"
            cmdManualAuto.Text = "Auto"
        Else
            txt3Strikes.Text = "0"
            cmdManualAuto.Text = "Manual"
        End If
    End Sub
    Private Sub cmdIRC_Click(sender As Object, e As EventArgs) Handles cmdIRC.Click
        If cmdIRC.Text = "Show IRC" Then
            Me.Width = 875
            cmdIRC.Text = "Hide IRC"
        Else
            Me.Width = 570
            cmdIRC.Text = "Show IRC"
        End If
    End Sub
    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If cmdConnect.Text = "Connect" Then
            If txtPass.Text <> "" Or txtNick.Text <> "" Then
                OAuth = txtPass.Text
                Username = txtNick.Text
                Info.NickName = Username
                Info.Password = OAuth
                Info.UserName = Username
                SetServerInfo("Starting to connect to twitch as " + Username + ".")
                Client.Connect(Server, False, Info)
                cmdConnect.Text = "Join"
                cmdDisconnect.Enabled = True
                If chkAutoJoin.Checked And txtChan.Text <> "" Then
                    cmdConnect.Enabled = False
                    JoinChannel()
                Else
                    SetServerInfo("Channel not set.")
                End If
            Else
                SetServerInfo("Nick or password is blank.")
            End If
        Else
            cmdConnect.Enabled = False
            JoinChannel()
        End If
    End Sub
    Private Sub cmdDisconnect_Click(sender As Object, e As EventArgs) Handles cmdDisconnect.Click
        Client.Disconnect()
        cmdDisconnect.Enabled = False
        cmdConnect.Enabled = True
        cmdConnect.Text = "Connect"
    End Sub
    Private Sub ConnectFailed(sender As Object, e As EventArgs) Handles Client.ConnectFailed
        SetServerInfo("Failed to connect to twitch.")
    End Sub
    Private Sub Disconnected(sender As Object, e As EventArgs) Handles Client.Disconnected
        SetServerInfo("Disconnected from twitch.")
    End Sub
    Private Sub Connected(sender As Object, e As EventArgs) Handles Client.Connected
        SetServerInfo("Connected to twitch.")
    End Sub
    Private Sub JoinChannel()
        Client.SendRawMessage("JOIN :" + txtChan.Text)
        SetServerInfo("Joined Channel: " + txtChan.Text)
    End Sub
    Private Sub SetServerInfo(ByVal [text] As String)
        If Me.txtServerInfo.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetServerInfo)
            Me.Invoke(d, New Object() {[text] & vbCrLf}) 'Thread Safe Call
        Else
            Me.txtServerInfo.Text += [text] & vbCrLf
        End If
    End Sub
    Private Sub SetChanChat(ByVal [text] As String)
        If Me.txtServerInfo.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetChanChat)
            Me.Invoke(d, New Object() {[text] & vbCrLf}) 'Thread Safe Call
        Else
            Me.txtChanChat.Text += [text] & vbCrLf
        End If
    End Sub
    Private Sub cmdSendWeaponToSlot_Click(sender As Object, e As EventArgs) Handles cmdSendWeaponToSlot.Click
        'each new weapon added must be added to this list
        Dim l As Integer
        l = listWeaponSlot.SelectedItem
        Select Case listWeaponName.SelectedItem
            Case "Hawksaw"
                picAllWeapons(l).Image = My.Resources.Hawksaw
                picAllWeapons(l).Tag = "Hawksaw"
            Case "Hawkmoon"
                picAllWeapons(l).Image = My.Resources.Hawkmoon
                picAllWeapons(l).Tag = "Hawkmoon"
            Case "LastWord"
                picAllWeapons(l).Image = My.Resources.LastWord
                picAllWeapons(l).Tag = "LastWord"
            Case "MIDA"
                picAllWeapons(l).Image = My.Resources.MIDA
                picAllWeapons(l).Tag = "MIDA"
            Case "MonteCarlo"
                picAllWeapons(l).Image = My.Resources.MonteCarlo
                picAllWeapons(l).Tag = "MonteCarlo"
            Case "Palindrome"
                picAllWeapons(l).Image = My.Resources.Palindrome
                picAllWeapons(l).Tag = "Palindrome"
            Case "NTTE"
                picAllWeapons(l).Image = My.Resources.NTTE
                picAllWeapons(l).Tag = "NTTE"
            Case "SurosRegime"
                picAllWeapons(l).Image = My.Resources.SurosRegime
                picAllWeapons(l).Tag = "SurosRegime"
            Case "Thorn"
                picAllWeapons(l).Image = My.Resources.Thorn
                picAllWeapons(l).Tag = "Thorn"
            Case "PDX45"
                picAllWeapons(l).Image = My.Resources.PDX45
                picAllWeapons(l).Tag = "PDX45"
            Case "UniversalRemote"
                picAllWeapons(l).Image = My.Resources.UniversalRemote
                picAllWeapons(l).Tag = "UniversalRemote"
            Case "Vex"
                picAllWeapons(l).Image = My.Resources.Vex
                picAllWeapons(l).Tag = "Vex"
            Case "Zhalo"
                picAllWeapons(l).Image = My.Resources.Zhalo
                picAllWeapons(l).Tag = "Zhalo"
            Case "Random"
                picAllWeapons(l).Image = My.Resources.Random
                picAllWeapons(l).Tag = "Random"
        End Select
    End Sub

    Private Sub listTotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTotal.SelectedIndexChanged
        'PoolCap = Int(listTotal.SelectedItem)
        'SetPool()
    End Sub
    Private Sub SetPool()
        Select Case PoolCap
            Case 3
                For i = 3 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                    My.Settings.PoolCap = 3
                Next i
            Case 4
                picAllWeapons(3).Visible = True
                txtLocations(3).Visible = True
                For i = 4 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 4
            Case 5
                For i = 3 To 4
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 5 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 5
            Case 6
                For i = 3 To 5
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 6 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 6
            Case 7
                For i = 3 To 6
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 7 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 7
            Case 8
                For i = 3 To 7
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 8 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 8
            Case 9
                For i = 3 To 8
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 9 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 9
            Case 10
                For i = 3 To 9
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 10 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 10
            Case 11
                For i = 3 To 10
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 11 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 11
            Case 12
                For i = 3 To 11
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 12 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 12
            Case 13
                For i = 3 To 12
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                For i = 13 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 13
            Case 14
                For i = 3 To 13
                    picAllWeapons(i).Visible = False
                    txtLocations(i).Visible = False
                Next i
                My.Settings.PoolCap = 14
        End Select
    End Sub

    Private Sub cmdCalibrate_Click(sender As Object, e As EventArgs) Handles cmdCalibrate.Click
        tmrMouseLoc.Enabled = True
        txtPlayerStatus.Text = "Calibrating"
    End Sub

    Private Sub chkRandom_CheckedChanged(sender As Object, e As EventArgs) Handles chkRandom.CheckedChanged
        If chkRandom.Checked = True Then
            RandomOrNo = 1
        Else
            RandomOrNo = 2
        End If
    End Sub

    Private Sub frmDestinyWeaponSwap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 100)
        UnregisterHotKey(Me.Handle, 200)
        UnregisterHotKey(Me.Handle, 300)
    End Sub
End Class