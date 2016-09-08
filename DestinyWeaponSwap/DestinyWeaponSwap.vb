
Public Class frmDestinyWeaponSwap
    Dim picAllWeapons() As PictureBox
    Dim picWeapons() As PictureBox
    Dim lblWeapons() As Label
    Dim txtWeapons() As TextBox
    Dim txtLocations() As TextBox

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    Private Sub frmDestinyWeaponSwap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWeapons = New TextBox() {txtRandomGun1, txtRandomGun2, txtRandomGun3}
        txtLocations = New TextBox() {txtLocationW1, txtLocationW2, txtLocationW3, txtLocationW4, txtLocationW5, txtLocationW6, txtLocationW7, txtLocationW8, txtLocationW9, txtLocationW10, txtLocationW11, txtLocationW12, txtLocationW13, txtLocationW14, txtLocationW15, txtLocationW16, txtLocationW17, txtLocationW18, txtLocationW19}
        lblWeapons = New Label() {lblWeaponName1, lblWeaponName2, lblWeaponName3}
        picWeapons = New PictureBox() {picWeapon1, picWeapon2, picWeapon3}
        picAllWeapons = New PictureBox() {picW1, picW2, picW3, picW4, picW5, picW6, picW7, picW8, picW9, picW10, picW11, picW12, picW13, picW14, picW15, picW16, picW17, picW18, picW19}
        UpDown()
        RandomWeapons()
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
    Private Sub UpdateVotes()
        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub
    Private Sub Vote1()
        txtVote1.Text += 1
        txtTotalVotes.Text += 1
        UpdateVotes()
    End Sub
    Private Sub Vote2()
        txtVote2.Text += 1
        txtTotalVotes.Text += 1
        UpdateVotes()
    End Sub
    Private Sub Vote3()
        txtVote3.Text += 1
        txtTotalVotes.Text += 1
        UpdateVotes()
    End Sub
    Private Sub TakeOld()
        FocusDIM()
        MouseMover2(116, 311, 282, 272)

        tmrReticleCheck.Enabled = True 'start checking for death again
        FocusDIS()

        picActive.Image = picOnDeck.Image
        txtLocationWActive.Text = txtLocationOnDeck.Text
        picOnDeck.Image = picAllWeapons(18).Image
        txtLocationOnDeck.Text = "0"

        System.Threading.Thread.Sleep(200)
    End Sub
    Private Sub StartVote()
        TakeOld() 'take old weapon
        System.Threading.Thread.Sleep(200)
        FocusDIS()
        tmrVote.Enabled = True 'Vote only lasts during this duration
        RandomWeapons() 'Mix up all guns
        UpDown() 'Move up all voting options into visible field
        My.Computer.Audio.Play(My.Resources.Que03, AudioPlayMode.Background)
    End Sub
    Private Sub RandomWeapons()
        Dim looper As Boolean
        Dim i, j As Integer
        'Select 3 Ramdom Guns for a poll. Do not include the last used gun

        For i = 0 To 2
            txtWeapons(i).Text = Rand(1, 15)
        Next

        Do
            looper = False
            If txtRandomGun1.Text = txtRandomGun2.Text Or txtRandomGun2.Text = txtRandomGun3.Text Or txtRandomGun1.Text = txtRandomGun3.Text Then
                If txtRandomGun1.Text = txtRandomGun2.Text Then
                    txtRandomGun1.Text = Rand(1, 15)
                ElseIf txtRandomGun2.Text = txtRandomGun3.Text Then
                    txtRandomGun2.Text = Rand(1, 15)
                ElseIf txtRandomGun1.Text = txtRandomGun3.Text Then
                    txtRandomGun3.Text = Rand(1, 15)
                End If
                looper = True
            ElseIf txtRandomGun1.Text = txtLastGun.Text Or txtRandomGun2.Text = txtLastGun.Text Or txtRandomGun3.Text = txtLastGun.Text Then
                If txtRandomGun1.Text = txtLastGun.Text Then
                    txtRandomGun1.Text = Rand(1, 15)
                ElseIf txtRandomGun2.Text = txtLastGun.Text Then
                    txtRandomGun2.Text = Rand(1, 15)
                ElseIf txtRandomGun3.Text = txtLastGun.Text Then
                    txtRandomGun3.Text = Rand(1, 15)
                End If
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
        If lblWeaponName1.Text = weaponvote Then
            Vote1()
        ElseIf lblWeaponName2.Text = weaponvote Then
            Vote2()
        ElseIf lblWeaponName3.Text = weaponvote Then
            Vote3()
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                Voter(picW1.Tag)
            Case Keys.B
                Voter(picW2.Tag)
            Case Keys.C
                Voter(picW3.Tag)
            Case Keys.D
                Voter(picW4.Tag)
            Case Keys.E
                Voter(picW5.Tag)
            Case Keys.F
                Voter(picW6.Tag)
            Case Keys.G
                Voter(picW7.Tag)
            Case Keys.H
                Voter(picW8.Tag)
            Case Keys.I
                Voter(picW9.Tag)
            Case Keys.J
                Voter(picW10.Tag)
            Case Keys.K
                Voter(picW11.Tag)
            Case Keys.L
                Voter(picW12.Tag)
            Case Keys.M
                Voter(picW13.Tag)
            Case Keys.N
                Voter(picW14.Tag)
            Case Keys.O
                Voter(picW15.Tag)
        End Select
    End Sub
    Private Sub cmdVote1_Click(sender As Object, e As EventArgs) Handles cmdVote1.Click
        Vote1()
    End Sub
    Private Sub cmdVote2_Click(sender As Object, e As EventArgs) Handles cmdVote2.Click
        Vote2()
    End Sub
    Private Sub cmdVote3_Click(sender As Object, e As EventArgs) Handles cmdVote3.Click
        Vote3()
    End Sub
    Private Sub tmrUpDown_Tick(sender As Object, e As EventArgs) Handles tmrUpDown.Tick
        'Moving Vote options up (when starting vote) or down (when vote is over)
        Dim i As Integer
        If cmdUpDown.Text = "Up" Then
            'Reset everything for a blank vote
            cmdVote1.Enabled = True
            cmdVote2.Enabled = True
            cmdVote3.Enabled = True
            barVote1.Width = 0
            barVote2.Width = 0
            barVote3.Width = 0

            If txtUpDown.Text = 125 Then
                'All items are at the top, do not move them anymore. Ready everything to be pushed down.
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Down"
            Else
                'Move all items right by 2 pixels
                For i = 0 To 2
                    picWeapons(i).Left += 2
                    lblWeapons(i).Left += 2
                Next
                barVote1.Left += 2
                barVote2.Left += 2
                barVote3.Left += 2
                picSwapPlate.Left += 2
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text += 1
            End If

        ElseIf cmdUpDown.Text = "Down" Then
            'Vote is over, voting is disabled
            cmdVote1.Enabled = False
            cmdVote2.Enabled = False
            cmdVote3.Enabled = False

            If txtUpDown.Text = 125 Then
                'All items are at the bottom, do not move them anymore. Ready everything to be pushed up.
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Up"
                'Reset Vote
                txtVote1.Text = "0"
                txtVote2.Text = "0"
                txtVote3.Text = "0"
                txtTotalVotes.Text = "0"

            Else
                'Move all items left by 2 pixels
                For i = 0 To 2
                    picWeapons(i).Left -= 2
                    lblWeapons(i).Left -= 2
                Next
                barVote1.Left -= 2
                barVote2.Left -= 2
                barVote3.Left -= 2
                picSwapPlate.Left -= 2
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text += 1
            End If

        End If
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
        Dim randomValue As Integer

        If txtVoteCountdown.Text = 0 Then
            'Vote is over. Declare winner
            'Check who had the most votes. Move that to txtLastWeapon.text
            If txtVote1.Text > txtVote2.Text And txtVote1.Text > txtVote3.Text Then
                txtLastGun.Text = txtRandomGun1.Text
            ElseIf txtVote2.Text > txtVote1.Text And txtVote2.Text > txtVote3.Text Then
                txtLastGun.Text = txtRandomGun2.Text
            ElseIf txtVote3.Text > txtVote1.Text And txtVote3.Text > txtVote2.Text Then
                txtLastGun.Text = txtRandomGun3.Text
            ElseIf txtVote1.Text = txtVote2.Text And txtVote2.Text = txtVote3.Text Then 'Check for ties
                randomValue = Rand(0, 2)
                txtLastGun.Text = txtWeapons(randomValue).Text
            ElseIf txtVote1.Text = txtVote2.Text Then
                randomValue = Rand(0, 1)
                txtLastGun.Text = txtWeapons(randomValue).Text
            ElseIf txtVote1.Text = txtVote3.Text Then
                randomValue = Rand(1, 2)
                If randomValue = 1 Then
                    txtLastGun.Text = txtRandomGun1.Text
                Else
                    txtLastGun.Text = txtRandomGun3.Text
                End If
            ElseIf txtVote2.Text = txtVote3.Text Then
                randomValue = Rand(1, 2)
                txtLastGun.Text = txtWeapons(randomValue).Text
            End If

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
            tmrReticleCheck.Enabled = False
            tmrDeathCheck.Enabled = False
            tmrSpawnCheck.Enabled = False
            txtCheckNo.Text = 10
            txtCheckYes.Text = 0
        End If
    End Sub
    Private Sub tmrReticleCheck_Tick(sender As Object, e As EventArgs) Handles tmrReticleCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(1477, 446), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name
        txtReticleColor.Text = txtReticleColor.Text.Substring(0, txtReticleColor.Text.Length - 4)

        'All presumptions on the characters dead/alive status are founded on the presence or absence of the reticle being visible
        If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
            If txtPlayerStatus.Text <> "Dead" Then
                'Just died- Run spawn check
                tmrReticleCheck.Enabled = False
                tmrDeathCheck.Enabled = True
            End If
        Else
            If txtPlayerStatus.Text <> "Alive" Then
                'Just spawned- Run death check
                tmrReticleCheck.Enabled = False
                tmrSpawnCheck.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmdStartVote_Click(sender As Object, e As EventArgs) Handles cmdStartVote.Click
        StartVote()
    End Sub
    Private Sub tmrSpawnCheck_Tick(sender As Object, e As EventArgs) Handles tmrSpawnCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(1477, 446), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name
        txtReticleColor.Text = txtReticleColor.Text.Substring(0, txtReticleColor.Text.Length - 4)

        If txtCheckYes.Text = 10 Then
            'Player did respawn. Start the new vote & reset.

            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
            txtPlayerStatus.Text = "Alive"
            tmrSpawnCheck.Enabled = False
            tmrReticleCheck.Enabled = True

            If txt3Strikes.Text = 4 Then
                StartVote()
                txt3Strikes.Text = 0
            End If

        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Player did not respawn. Reset & Keep waiting.
            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
            tmrSpawnCheck.Enabled = False
            tmrReticleCheck.Enabled = True
        Else
            'expecting to see NO white. If we do, return No
            If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
                txtCheckNo.Text = txtCheckNo.Text - 1
            Else
                txtCheckYes.Text = txtCheckYes.Text + 1
            End If
        End If
    End Sub
    Private Sub tmrDeathCheck_Tick(sender As Object, e As EventArgs) Handles tmrDeathCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(1477, 446), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name
        txtReticleColor.Text = txtReticleColor.Text.Substring(0, txtReticleColor.Text.Length - 4)

        If txtCheckYes.Text = 10 Then
            'Hero did die. Switch Weapons

            tmrDeathCheck.Enabled = False
            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
            txtPlayerStatus.Text = "Dead"
            tmrReticleCheck.Enabled = True
            txt3Strikes.Text += 1

            If txt3Strikes.Text = 0 Then
                My.Computer.Audio.Play(My.Resources.Que01, AudioPlayMode.Background)
            ElseIf txt3Strikes.Text = 1 Then
                FocusDIM()
                MouseMover1(379, 123) 'reload DIM
                FocusDIS()
            End If
        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Player did not die. Reset & Keep waiting.
            tmrDeathCheck.Enabled = False
            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
            tmrReticleCheck.Enabled = True
        Else
            'expecting to see red. If we dont, return No
            If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
                txtCheckYes.Text += 1
            Else
                txtCheckNo.Text -= 1
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMouseLoc.Tick
        Dim MPx As Point = MousePosition()
        txtMouseLoc.Text = MPx.ToString
    End Sub
    Private Sub SendNew()
        'Send clicks to switch Weapons in game - to be used on death screen
        'Checks what Weapon was last voted for (txtLastWeapon.text)

        FocusDIM()

        My.Computer.Audio.Play(My.Resources.Que02, AudioPlayMode.Background)

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
End Class