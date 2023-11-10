<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.txtpass = New Guna.UI.WinForms.GunaTextBox()
        Me.txtuser = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackgroundImage = Global.finalproject.My.Resources.Resources.hill_bg_1
        Me.GunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(422, 252)
        Me.GunaPanel2.TabIndex = 0
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaCircleButton3)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaCircleButton2)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaShadowPanel1.Controls.Add(Me.txtpass)
        Me.GunaShadowPanel1.Controls.Add(Me.txtuser)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(328, 47)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(422, 469)
        Me.GunaShadowPanel1.TabIndex = 1
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(134, 399)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 20
        Me.GunaGradientButton1.Size = New System.Drawing.Size(145, 44)
        Me.GunaGradientButton1.TabIndex = 4
        Me.GunaGradientButton1.Text = "LOGIN"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel1.Location = New System.Drawing.Point(157, 259)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(102, 25)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "User Login"
        '
        'GunaCircleButton3
        '
        Me.GunaCircleButton3.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton3.AnimationSpeed = 0.03!
        Me.GunaCircleButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton3.FocusedColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton3.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.Image = Global.finalproject.My.Resources.Resources.icons8_user_64
        Me.GunaCircleButton3.ImageSize = New System.Drawing.Size(50, 50)
        Me.GunaCircleButton3.Location = New System.Drawing.Point(182, 206)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.Size = New System.Drawing.Size(50, 50)
        Me.GunaCircleButton3.TabIndex = 6
        Me.GunaCircleButton3.UseTransfarantBackground = True
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Image = Global.finalproject.My.Resources.Resources.icons8_password_26
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(66, 356)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(32, 30)
        Me.GunaCircleButton2.TabIndex = 8
        Me.GunaCircleButton2.UseTransfarantBackground = True
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Image = Global.finalproject.My.Resources.Resources.icons8_user_100
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(33, 33)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(66, 297)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(32, 30)
        Me.GunaCircleButton1.TabIndex = 7
        Me.GunaCircleButton1.UseTransfarantBackground = True
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtpass.BorderColor = System.Drawing.Color.Silver
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtpass.Location = New System.Drawing.Point(104, 356)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpass.Radius = 10
        Me.txtpass.SelectedText = ""
        Me.txtpass.Size = New System.Drawing.Size(217, 32)
        Me.txtpass.TabIndex = 2
        Me.txtpass.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Transparent
        Me.txtuser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtuser.BorderColor = System.Drawing.Color.Silver
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtuser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtuser.Location = New System.Drawing.Point(104, 297)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.Radius = 10
        Me.txtuser.SelectedText = ""
        Me.txtuser.Size = New System.Drawing.Size(217, 32)
        Me.txtuser.TabIndex = 1
        Me.txtuser.Text = "Username"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.finalproject.My.Resources.Resources.hill_bg_3_blur
        Me.ClientSize = New System.Drawing.Size(1042, 571)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Name = "Form1"
        Me.Text = "0"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents txtuser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txtpass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
End Class
