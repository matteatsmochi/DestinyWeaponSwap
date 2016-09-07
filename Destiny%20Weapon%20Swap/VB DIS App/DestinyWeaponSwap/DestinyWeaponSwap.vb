Public Class frmDestinyWeaponSwap

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)

    Private Sub frmDestinyWeaponSwap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picSwapPlate.Top = 0
        picSwapPlate.Left = 0
        picWeapon1.Left = 2
        picWeapon1.Top = 89
        picWeapon2.Left = 2
        picWeapon2.Top = 275
        UpDown()
    End Sub

    Private Sub FocusDIM()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(451, 13)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
    End Sub


    Private Sub FocusDIS()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(1124, 107)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub UpDown()
        tmrUpDown.Enabled = True
    End Sub

    Private Sub Vote1()
        txtVote1.Text = txtVote1.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub Vote2()
        txtVote2.Text = txtVote2.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub Vote3()
        txtVote3.Text = txtVote3.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub TakeOld()

        FocusDIM()


        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(116, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(282, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)


        tmrReticleCheck.Enabled = True 'start checking for death again
        FocusDIS()


        picActive.Image = picOnDeck.Image
        txtLocationWActive.Text = txtLocationOnDeck.Text
        picOnDeck.Image = picW19.Image
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
        AlertPlayer.URL = "C:\Users\Matthew\Desktop\Destiny Weapon Swap\Audio Queues\Que03.wav"
        AlertPlayer.Ctlcontrols.play()
    End Sub

    Private Sub RandomWeapons()

        'Select 3 Ramdom Guns for a poll. Do not include the last used gun
Start:
        Randomize()
        txtRandomGun1.Text = Int((15 * Rnd()) + 1)
        txtRandomGun2.Text = Int((15 * Rnd()) + 1)
        txtRandomGun3.Text = Int((15 * Rnd()) + 1)
        If txtRandomGun1.Text = txtRandomGun2.Text Then
            GoTo Start
        ElseIf txtRandomGun1.Text = txtRandomGun3.Text Then
            GoTo Start
        ElseIf txtRandomGun2.Text = txtRandomGun3.Text Then
            GoTo Start
        ElseIf txtRandomGun1.Text = txtLastGun.Text Then
            GoTo Start
        ElseIf txtRandomGun2.Text = txtLastGun.Text Then
            GoTo Start
        ElseIf txtRandomGun3.Text = txtLastGun.Text Then
            GoTo Start
        End If

        'Based on number, place Hero Image and Name into picHero and lblHeroName for all 3 Heroes
        Select Case txtRandomGun1.Text
            Case 1
                picWeapon1.Image = picW1.Image
                lblWeaponName1.Text = "Hawksaw"
            Case 2
                picWeapon1.Image = picW2.Image
                lblWeaponName1.Text = "Hawkmoon"
            Case 3
                picWeapon1.Image = picW3.Image
                lblWeaponName1.Text = "LastWord"
            Case 4
                picWeapon1.Image = picW4.Image
                lblWeaponName1.Text = "MIDA"
            Case 5
                picWeapon1.Image = picW5.Image
                lblWeaponName1.Text = "Carlo"
            Case 6
                picWeapon1.Image = picW6.Image
                lblWeaponName1.Text = "NLB"
            Case 7
                picWeapon1.Image = picW7.Image
                lblWeaponName1.Text = "NTtE"
            Case 8
                picWeapon1.Image = picW8.Image
                lblWeaponName1.Text = "RedDeath"
            Case 9
                picWeapon1.Image = picW9.Image
                lblWeaponName1.Text = "Regime"
            Case 10
                picWeapon1.Image = picW10.Image
                lblWeaponName1.Text = "Thorn"
            Case 11
                picWeapon1.Image = picW11.Image
                lblWeaponName1.Text = "PDX45"
            Case 12
                picWeapon1.Image = picW12.Image
                lblWeaponName1.Text = "Remote"
            Case 13
                picWeapon1.Image = picW13.Image
                lblWeaponName1.Text = "Vex"
            Case 14
                picWeapon1.Image = picW14.Image
                lblWeaponName1.Text = "Zhalo"
            Case 15
                picWeapon1.Image = picW15.Image
                lblWeaponName1.Text = "Random"
        End Select

        Select Case txtRandomGun2.Text
            Case 1
                picWeapon2.Image = picW1.Image
                lblWeaponName2.Text = "Hawksaw"
            Case 2
                picWeapon2.Image = picW2.Image
                lblWeaponName2.Text = "Hawkmoon"
            Case 3
                picWeapon2.Image = picW3.Image
                lblWeaponName1.Text = "LastWord"
            Case 4
                picWeapon2.Image = picW4.Image
                lblWeaponName2.Text = "MIDA"
            Case 5
                picWeapon2.Image = picW5.Image
                lblWeaponName2.Text = "Carlo"
            Case 6
                picWeapon2.Image = picW6.Image
                lblWeaponName2.Text = "NLB"
            Case 7
                picWeapon2.Image = picW7.Image
                lblWeaponName2.Text = "NTtE"
            Case 8
                picWeapon2.Image = picW8.Image
                lblWeaponName2.Text = "RedDeath"
            Case 9
                picWeapon2.Image = picW9.Image
                lblWeaponName2.Text = "Regime"
            Case 10
                picWeapon2.Image = picW10.Image
                lblWeaponName2.Text = "Thorn"
            Case 11
                picWeapon2.Image = picW11.Image
                lblWeaponName2.Text = "PDX45"
            Case 12
                picWeapon2.Image = picW12.Image
                lblWeaponName2.Text = "Remote"
            Case 13
                picWeapon2.Image = picW13.Image
                lblWeaponName2.Text = "Vex"
            Case 14
                picWeapon2.Image = picW14.Image
                lblWeaponName2.Text = "Zhalo"
            Case 15
                picWeapon2.Image = picW15.Image
                lblWeaponName2.Text = "Random"

        End Select

        Select Case txtRandomGun3.Text
            Case 1
                picWeapon3.Image = picW1.Image
                lblWeaponName3.Text = "Hawksaw"
            Case 2
                picWeapon3.Image = picW2.Image
                lblWeaponName3.Text = "Hawkmoon"
            Case 3
                picWeapon3.Image = picW3.Image
                lblWeaponName3.Text = "LastWord"
            Case 4
                picWeapon3.Image = picW4.Image
                lblWeaponName3.Text = "MIDA"
            Case 5
                picWeapon3.Image = picW5.Image
                lblWeaponName3.Text = "Carlo"
            Case 6
                picWeapon3.Image = picW6.Image
                lblWeaponName3.Text = "NLB"
            Case 7
                picWeapon3.Image = picW7.Image
                lblWeaponName3.Text = "NTtE"
            Case 8
                picWeapon3.Image = picW8.Image
                lblWeaponName3.Text = "RedDeath"
            Case 9
                picWeapon3.Image = picW9.Image
                lblWeaponName3.Text = "Regime"
            Case 10
                picWeapon3.Image = picW10.Image
                lblWeaponName3.Text = "Thorn"
            Case 11
                picWeapon3.Image = picW11.Image
                lblWeaponName3.Text = "PDX45"
            Case 12
                picWeapon3.Image = picW12.Image
                lblWeaponName3.Text = "Remote"
            Case 13
                picWeapon3.Image = picW13.Image
                lblWeaponName3.Text = "Vex"
            Case 14
                picWeapon3.Image = picW14.Image
                lblWeaponName3.Text = "Zhalo"
            Case 15
                picWeapon3.Image = picW15.Image
                lblWeaponName3.Text = "Random"
        End Select
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                If lblWeaponName1.Text = "Hawksaw" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Hawksaw" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Hawksaw" Then
                    Vote3()
                End If
            Case Keys.B
                If lblWeaponName1.Text = "Hawkmoon" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Hawkmoon" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Hawkmoon" Then
                    Vote3()
                End If
            Case Keys.C
                If lblWeaponName1.Text = "LastWord" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "LastWord" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "LastWord" Then
                    Vote3()
                End If
            Case Keys.D
                If lblWeaponName1.Text = "MIDA" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "MIDA" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "MIDA" Then
                    Vote3()
                End If
            Case Keys.E
                If lblWeaponName1.Text = "Carlo" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Carlo" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Carlo" Then
                    Vote3()
                End If
            Case Keys.F
                If lblWeaponName1.Text = "NLB" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "NLB" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "NLB" Then
                    Vote3()
                End If
            Case Keys.G
                If lblWeaponName1.Text = "NTtE" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "NTtE" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "NTtE" Then
                    Vote3()
                End If
            Case Keys.H
                If lblWeaponName1.Text = "RedDeath" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "RedDeath" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "RedDeath" Then
                    Vote3()
                End If
            Case Keys.I
                If lblWeaponName1.Text = "Regime" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Regime" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Regime" Then
                    Vote3()
                End If
            Case Keys.J
                If lblWeaponName1.Text = "Thorn" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Thorn" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Thorn" Then
                    Vote3()
                End If
            Case Keys.K
                If lblWeaponName1.Text = "Remote" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Remote" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Remote" Then
                    Vote3()
                End If
            Case Keys.L
                If lblWeaponName1.Text = "Vex" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Vex" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Vex" Then
                    Vote3()
                End If
            Case Keys.M
                If lblWeaponName1.Text = "Zhalo" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Zhalo" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Zhalo" Then
                    Vote3()
                End If
            Case Keys.N
                If lblWeaponName1.Text = "PDX45" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "PDX45" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "PDX45" Then
                    Vote3()
                End If
            Case Keys.O
                If lblWeaponName1.Text = "Random" Then
                    Vote1()
                ElseIf lblWeaponName2.Text = "Random" Then
                    Vote2()
                ElseIf lblWeaponName3.Text = "Random" Then
                    Vote3()
                End If

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
                picWeapon3.Left = picWeapon3.Left - 2
            Else
                'Move all items right by 2 pixels
                picWeapon1.Left = picWeapon1.Left + 2
                picWeapon2.Left = picWeapon2.Left + 2
                picWeapon3.Left = picWeapon2.Left + 2
                lblWeaponName1.Left = lblWeaponName1.Left + 2
                lblWeaponName2.Left = lblWeaponName2.Left + 2
                lblWeaponName3.Left = lblWeaponName3.Left + 2
                barVote1.Left = barVote1.Left + 2
                barVote2.Left = barVote2.Left + 2
                barVote3.Left = barVote3.Left + 2
                picSwapPlate.Left = picSwapPlate.Left + 2
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text = txtUpDown.Text + 1
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
                picWeapon1.Left = picWeapon1.Left - 2
                picWeapon2.Left = picWeapon2.Left - 2
                picWeapon3.Left = picWeapon2.Left - 2
                lblWeaponName1.Left = lblWeaponName1.Left - 2
                lblWeaponName2.Left = lblWeaponName2.Left - 2
                lblWeaponName3.Left = lblWeaponName3.Left - 2
                barVote1.Left = barVote1.Left - 2
                barVote2.Left = barVote2.Left - 2
                barVote3.Left = barVote3.Left - 2
                picSwapPlate.Left = picSwapPlate.Left - 2
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text = txtUpDown.Text + 1
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
        Select Case txtLastGun.Text
            Case 1
                txtWinnerLocation.Text = txtLocationW1.Text
            Case 2
                txtWinnerLocation.Text = txtLocationW2.Text
            Case 3
                txtWinnerLocation.Text = txtLocationW3.Text
            Case 4
                txtWinnerLocation.Text = txtLocationW4.Text
            Case 5
                txtWinnerLocation.Text = txtLocationW5.Text
            Case 6
                txtWinnerLocation.Text = txtLocationW6.Text
            Case 7
                txtWinnerLocation.Text = txtLocationW7.Text
            Case 8
                txtWinnerLocation.Text = txtLocationW8.Text
            Case 9
                txtWinnerLocation.Text = txtLocationW9.Text
            Case 10
                txtWinnerLocation.Text = txtLocationW10.Text
            Case 11
                txtWinnerLocation.Text = txtLocationW11.Text
            Case 12
                txtWinnerLocation.Text = txtLocationW12.Text
            Case 13
                txtWinnerLocation.Text = txtLocationW13.Text
            Case 14
                txtWinnerLocation.Text = txtLocationW14.Text
            Case 15
                txtWinnerLocation.Text = txtLocationW15.Text
            Case 16
                txtWinnerLocation.Text = txtLocationW16.Text
            Case 17
                txtWinnerLocation.Text = txtLocationW17.Text
            Case 18
                txtWinnerLocation.Text = txtLocationW18.Text
            Case 19
                txtWinnerLocation.Text = txtLocationW19.Text
        End Select

    End Sub

    Private Function Rand(lowerbound As Integer, upperbound As Integer)
        Randomize()
        Rand = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function
    Private Sub tmrVote_Tick(sender As Object, e As EventArgs) Handles tmrVote.Tick
        Dim randomValue As Integer

        If txtVoteCountdown.Text = 0 Then
            'Vote is over. Declair winner
            'Check who had the most votes. Move that to txtLastHero.text
            If txtVote1.Text > txtVote2.Text And txtVote1.Text > txtVote3.Text Then
                txtLastGun.Text = txtRandomGun1.Text
            ElseIf txtVote2.Text > txtVote1.Text And txtVote2.Text > txtVote3.Text Then
                txtLastGun.Text = txtRandomGun2.Text
            ElseIf txtVote3.Text > txtVote1.Text And txtVote3.Text > txtVote2.Text Then
                txtLastGun.Text = txtRandomGun3.Text
            ElseIf txtVote1.Text = txtVote2.Text And txtVote2.Text = txtVote3.Text Then
                randomValue = Rand(1, 3)
                If randomValue = 1 Then
                    txtLastGun.Text = txtRandomGun1.Text
                ElseIf randomValue = 2 Then
                    txtLastGun.Text = txtRandomGun2.Text
                Else
                    txtLastGun.Text = txtRandomGun3.Text
                End If

            ElseIf txtVote1.Text = txtVote2.Text Then 'Check for ties
                randomValue = Rand(1, 2)
                If randomValue = 1 Then
                    txtLastGun.Text = txtRandomGun1.Text
                Else
                    txtLastGun.Text = txtRandomGun2.Text
                End If
            ElseIf txtVote1.Text = txtVote3.Text Then
                randomValue = Rand(1, 2)
                If randomValue = 1 Then
                    txtLastGun.Text = txtRandomGun1.Text
                Else
                    txtLastGun.Text = txtRandomGun3.Text
                End If
            ElseIf txtVote2.Text = txtVote3.Text Then
                randomValue = Rand(1, 2)
                If randomValue = 1 Then
                    txtLastGun.Text = txtRandomGun2.Text
                Else
                    txtLastGun.Text = txtRandomGun3.Text
                End If
            End If

            If txtLastGun.Text = 15 Then 'selects random gun if random option wins
                txtLastGun.Text = Rand(0, 14)

                UpDown() 'send all voting options down
                SlotToLocation() 'set up location for slot of gun to send
                SendNew() 'send over the new gun
                txtVoteCountdown.Text = "45" 'reset voting countdown timer
                tmrVote.Enabled = False 'stop counting down
                tmrReticleCheck.Enabled = True 'start watching again

            Else
                UpDown() 'send all voting options down
                SlotToLocation() 'set up location for slot of gun to send
                SendNew() 'send over the new gun
                txtVoteCountdown.Text = "45" 'reset voting countdown timer
                tmrVote.Enabled = False 'stop counting down
                tmrReticleCheck.Enabled = True 'start watching again
            End If


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
            If txtPlayerStatus.Text = "Dead" Then
                'NOTHING
            Else
                'Just died- Run spawn check
                tmrReticleCheck.Enabled = False
                tmrDeathCheck.Enabled = True
            End If
        Else
            If txtPlayerStatus.Text = "Alive" Then
                'NOTHING
            Else
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
            'Hero did respawn. Start the new vote & reset.
            If txt3Strikes.Text = 4 Then

                StartVote()
                tmrSpawnCheck.Enabled = False
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Alive"
                tmrReticleCheck.Enabled = True
                txt3Strikes.Text = 0

            Else
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Alive"
                tmrSpawnCheck.Enabled = False
                tmrReticleCheck.Enabled = True
            End If

        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Hero did not respawn. Reset & Keep waiting.
            tmrSpawnCheck.Enabled = False
            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
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
            If txt3Strikes.Text = 4 Then
                tmrDeathCheck.Enabled = False
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Dead"




            ElseIf txt3Strikes.Text = 0 Then
                txt3Strikes.Text = txt3Strikes.Text + 1
                tmrDeathCheck.Enabled = False
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Dead"

                AlertPlayer.URL = "C:\Users\Matthew\Desktop\Destiny Weapon Swap\Audio Queues\Que01.wav"
                AlertPlayer.Ctlcontrols.play()


                tmrReticleCheck.Enabled = True

            ElseIf txt3Strikes.Text = 1 Then
                txt3Strikes.Text = txt3Strikes.Text + 1
                FocusDIM()

                'reload DIM
                System.Threading.Thread.Sleep(200)
                Cursor.Position = New Point(379, 123)
                Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
                mouse_event(&H2, 0, 0, 0, 1)
                mouse_event(&H4, 0, 0, 0, 1)

                FocusDIS()


                tmrDeathCheck.Enabled = False
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Dead"

                tmrReticleCheck.Enabled = True

            Else
                txt3Strikes.Text = txt3Strikes.Text + 1
                tmrDeathCheck.Enabled = False
                txtCheckNo.Text = "10"
                txtCheckYes.Text = "0"
                txtPlayerStatus.Text = "Dead"

                tmrReticleCheck.Enabled = True
            End If



        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Hero did not die. Reset & Keep waiting.
            tmrDeathCheck.Enabled = False
            txtCheckNo.Text = "10"
            txtCheckYes.Text = "0"
            tmrReticleCheck.Enabled = True
        Else
            'expecting to see red. If we dont, return No
            If txtReticleColor.Text = "fff0" Or txtReticleColor.Text = "fff1" Or txtReticleColor.Text = "fff2" Or txtReticleColor.Text = "fff3" Or txtReticleColor.Text = "fff4" Or txtReticleColor.Text = "fff5" Or txtReticleColor.Text = "fff6" Or txtReticleColor.Text = "fff7" Or txtReticleColor.Text = "fff8" Or txtReticleColor.Text = "fff9" Then
                txtCheckYes.Text = txtCheckYes.Text + 1
            Else
                txtCheckNo.Text = txtCheckNo.Text - 1
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMouseLoc.Tick
        Dim MPx As Point = MousePosition()
        txtMouseLoc.Text = MPx.ToString
    End Sub


    Private Sub SendNew()
        'AutoHotKey Macros to switch heros in game - to be used on death screen
        'Checks what Hero was last voted for (txtLastHero.text)


        FocusDIM()


        AlertPlayer.URL = "C:\Users\Matthew\Desktop\Destiny Weapon Swap\Audio Queues\Que02.wav"
        AlertPlayer.Ctlcontrols.play()

        Select Case txtWinnerLocation.Text
            Case 1
                SendSlot1()
            Case 2
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot1()
                Else
                    SendSlot2()
                End If
            Case 3
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot2()
                Else
                    SendSlot3()
                End If
            Case 4
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot3()
                Else
                    SendSlot4()
                End If
            Case 5
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot4()
                Else
                    SendSlot5()
                End If
            Case 6
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot5()
                Else
                    SendSlot6()
                End If
            Case 7
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot6()
                Else
                    SendSlot7()
                End If
            Case 8
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot7()
                Else
                    SendSlot8()
                End If
            Case 9
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot8()
                Else
                    SendSlot9()
                End If
            Case 10
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot9()
                Else
                    SendSlot10()
                End If
            Case 11
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot10()
                Else
                    SendSlot11()
                End If
            Case 12
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot11()
                Else
                    SendSlot12()
                End If
            Case 13
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot12()
                Else
                    SendSlot13()
                End If
            Case 14
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot13()
                Else
                    SendSlot14()
                End If
            Case 15
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot14()
                Else
                    SendSlot15()
                End If
            Case 16
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot15()
                Else
                    SendSlot16()
                End If
            Case 17
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot16()
                Else
                    SendSlot17()
                End If
            Case 18
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot17()
                Else
                    SendSlot18()
                End If
            Case 19
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot18()
                Else
                    SendSlot19()
                End If
            Case 20
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot19()
                Else
                    SendSlot20()
                End If
            Case 21
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot20()
                Else
                    SendSlot21()
                End If
            Case 22
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot21()
                Else
                    SendSlot22()
                End If
            Case 23
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot22()
                Else
                    SendSlot23()
                End If
            Case 24
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot23()
                Else
                    SendSlot24()
                End If
            Case 25
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot24()
                Else
                    SendSlot25()
                End If
            Case 26
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot25()
                Else
                    SendSlot26()
                End If
            Case 27
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot26()
                Else
                    SendSlot27()
                End If
            Case 28
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot27()
                Else
                    SendSlot28()
                End If
            Case 29
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot28()
                Else
                    SendSlot29()
                End If
            Case 30
                If txtLocationWActive.Text < txtWinnerLocation.Text Then
                    SendSlot29()
                Else
                    SendSlot30()
                End If
        End Select

        txtLocationOnDeck.Text = txtWinnerLocation.Text

        Select Case txtLastGun.Text
            Case 1
                picOnDeck.Image = picW1.Image
            Case 2
                picOnDeck.Image = picW2.Image
            Case 3
                picOnDeck.Image = picW3.Image
            Case 4
                picOnDeck.Image = picW4.Image
            Case 5
                picOnDeck.Image = picW5.Image
            Case 6
                picOnDeck.Image = picW6.Image
            Case 7
                picOnDeck.Image = picW7.Image
            Case 8
                picOnDeck.Image = picW8.Image
            Case 9
                picOnDeck.Image = picW9.Image
            Case 10
                picOnDeck.Image = picW10.Image
            Case 11
                picOnDeck.Image = picW11.Image
            Case 12
                picOnDeck.Image = picW12.Image
            Case 13
                picOnDeck.Image = picW13.Image
            Case 14
                picOnDeck.Image = picW14.Image
            Case 15
                picOnDeck.Image = picW15.Image
            Case 16
                picOnDeck.Image = picW16.Image
            Case 17
                picOnDeck.Image = picW17.Image
            Case 18
                picOnDeck.Image = picW18.Image
            Case 19
                picOnDeck.Image = picW19.Image
        End Select

    End Sub


    Private Sub cmdSendNew_Click(sender As Object, e As EventArgs) Handles cmdSendNew.Click
        SendNew()

    End Sub

    Private Sub SendSlot1()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot2()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(637, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot3()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot4()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(573, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot5()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(611, 272)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot6()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot7()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(673, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot8()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot9()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(537, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot10()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 311)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot11()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot12()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(673, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot13()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot14()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(573, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot15()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(611, 351)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot16()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot17()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(673, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot18()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot19()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(573, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot20()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(611, 388)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot21()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot22()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(673, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot23()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot24()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(573, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot25()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(611, 425)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot26()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(635, 499)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(459, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot27()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(673, 499)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(498, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot28()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(711, 499)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(535, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot29()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(747, 499)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(573, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub SendSlot30()
        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(787, 499)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)

        System.Threading.Thread.Sleep(200)
        Cursor.Position = New Point(611, 464)
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        mouse_event(&H4, 0, 0, 0, 1)
        System.Threading.Thread.Sleep(200)
    End Sub



End Class
