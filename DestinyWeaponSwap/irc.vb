Public Class frmIRC
    Dim WithEvents Client As New IrcDotNet.TwitchIrcClient
    Dim OAuth As String
    Dim Username As String
    Dim Server As String = "irc.twitch.tv"
    Dim Info As New IrcDotNet.IrcUserRegistrationInfo
    Private Sub frmDestinyWeaponSwap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Client.FloodPreventer = New IrcDotNet.IrcStandardFloodPreventer(4, 2000)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If txtPass.Text <> "" Or txtNick.Text <> "" Then
            OAuth = txtPass.Text
            Username = txtNick.Text
            Info.NickName = Username
            Info.Password = OAuth
            Info.UserName = Username
            Client.Connect(Server, False, Info)
        Else
            txtChat.Text += "Nick or password is blank." & vbCrLf
        End If
    End Sub
End Class