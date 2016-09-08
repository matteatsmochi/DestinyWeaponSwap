<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIRC
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
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtChan = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblChan = New System.Windows.Forms.Label()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(57, 6)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(66, 20)
        Me.txtNick.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(185, 6)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(69, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtChan
        '
        Me.txtChan.Location = New System.Drawing.Point(314, 6)
        Me.txtChan.Name = "txtChan"
        Me.txtChan.Size = New System.Drawing.Size(74, 20)
        Me.txtChan.TabIndex = 2
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Location = New System.Drawing.Point(12, 9)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(32, 13)
        Me.lblNick.TabIndex = 4
        Me.lblNick.Text = "Nick:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(129, 9)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "Password:"
        '
        'lblChan
        '
        Me.lblChan.AutoSize = True
        Me.lblChan.Location = New System.Drawing.Point(260, 9)
        Me.lblChan.Name = "lblChan"
        Me.lblChan.Size = New System.Drawing.Size(52, 13)
        Me.lblChan.TabIndex = 6
        Me.lblChan.Text = "Channel: "
        '
        'txtChat
        '
        Me.txtChat.Enabled = False
        Me.txtChat.Location = New System.Drawing.Point(15, 43)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(827, 281)
        Me.txtChat.TabIndex = 8
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(477, 9)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnect.TabIndex = 9
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'frmIRC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 336)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.lblChan)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblNick)
        Me.Controls.Add(Me.txtChan)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIRC"
        Me.Text = "IRC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNick As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtChan As TextBox
    Friend WithEvents lblNick As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblChan As Label
    Friend WithEvents txtChat As TextBox
    Friend WithEvents cmdConnect As Button
End Class
