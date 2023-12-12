<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim lblHeader As Guna.UI2.WinForms.Guna2HtmlLabel
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlLogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        imgLogomain = New PictureBox()
        btnClose = New Guna.UI2.WinForms.Guna2GradientButton()
        chkShowPass = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        lblForgotpassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        tbEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        pnldesignlogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        PictureBox1 = New PictureBox()
        Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        lblHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlLogin.SuspendLayout()
        CType(imgLogomain, ComponentModel.ISupportInitialize).BeginInit()
        pnldesignlogin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHeader.AvoidGeometryAntialias = True
        lblHeader.BackColor = Color.Transparent
        lblHeader.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        lblHeader.Location = New Point(149, 12)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(82, 17)
        lblHeader.TabIndex = 2
        lblHeader.Text = "Project OMAC"
        lblHeader.TextAlignment = ContentAlignment.MiddleCenter
        lblHeader.UseGdiPlusTextRendering = True
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackgroundImageLayout = ImageLayout.None
        pnlLogin.Controls.Add(imgLogomain)
        pnlLogin.Controls.Add(btnClose)
        pnlLogin.Controls.Add(chkShowPass)
        pnlLogin.Controls.Add(lblHeader)
        pnlLogin.Controls.Add(lblForgotpassword)
        pnlLogin.Controls.Add(Guna2HtmlLabel1)
        pnlLogin.Controls.Add(lblUser)
        pnlLogin.Controls.Add(btLogin)
        pnlLogin.Controls.Add(tbPassword)
        pnlLogin.Controls.Add(tbEmployeeID)
        pnlLogin.CustomizableEdges = CustomizableEdges10
        pnlLogin.Dock = DockStyle.Right
        pnlLogin.FillColor = Color.Transparent
        pnlLogin.FillColor2 = Color.Transparent
        pnlLogin.FillColor3 = Color.Transparent
        pnlLogin.FillColor4 = Color.FromArgb(CByte(106), CByte(148), CByte(245))
        pnlLogin.Location = New Point(454, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Quality = 2
        pnlLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        pnlLogin.Size = New Size(365, 460)
        pnlLogin.TabIndex = 0
        ' 
        ' imgLogomain
        ' 
        imgLogomain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        imgLogomain.BackColor = Color.Transparent
        imgLogomain.Image = CType(resources.GetObject("imgLogomain.Image"), Image)
        imgLogomain.Location = New Point(92, 35)
        imgLogomain.Name = "imgLogomain"
        imgLogomain.Size = New Size(187, 146)
        imgLogomain.SizeMode = PictureBoxSizeMode.Zoom
        imgLogomain.TabIndex = 8
        imgLogomain.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.BorderColor = Color.Transparent
        btnClose.CustomizableEdges = CustomizableEdges1
        btnClose.DisabledState.BorderColor = Color.DarkGray
        btnClose.DisabledState.CustomBorderColor = Color.DarkGray
        btnClose.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnClose.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnClose.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnClose.FillColor = Color.Transparent
        btnClose.FillColor2 = Color.Transparent
        btnClose.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.ForeColor = Color.White
        btnClose.GradientMode = Drawing2D.LinearGradientMode.Vertical
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(327, 0)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnClose.Size = New Size(38, 36)
        btnClose.TabIndex = 2
        ' 
        ' chkShowPass
        ' 
        chkShowPass.CheckedState.Image = My.Resources.Resources.visible
        chkShowPass.Image = My.Resources.Resources.hide
        chkShowPass.ImageOffset = New Point(0, 0)
        chkShowPass.ImageRotate = 0F
        chkShowPass.Location = New Point(285, 282)
        chkShowPass.Name = "chkShowPass"
        chkShowPass.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        chkShowPass.Size = New Size(25, 36)
        chkShowPass.TabIndex = 7
        ' 
        ' lblForgotpassword
        ' 
        lblForgotpassword.BackColor = Color.Transparent
        lblForgotpassword.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        lblForgotpassword.Location = New Point(79, 323)
        lblForgotpassword.Margin = New Padding(3, 2, 3, 2)
        lblForgotpassword.Name = "lblForgotpassword"
        lblForgotpassword.Size = New Size(91, 17)
        lblForgotpassword.TabIndex = 3
        lblForgotpassword.Text = "Forgot Password"
        lblForgotpassword.TextAlignment = ContentAlignment.MiddleCenter
        Guna2HtmlToolTip1.SetToolTip(lblForgotpassword, "Contact The Admin")
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        Guna2HtmlLabel1.Location = New Point(79, 260)
        Guna2HtmlLabel1.Margin = New Padding(3, 2, 3, 2)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(59, 17)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "Password :"
        Guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.BackColor = Color.Transparent
        lblUser.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        lblUser.Location = New Point(79, 186)
        lblUser.Margin = New Padding(3, 2, 3, 2)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(72, 17)
        lblUser.TabIndex = 3
        lblUser.Text = "Employee ID:"
        lblUser.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' btLogin
        ' 
        btLogin.CustomizableEdges = CustomizableEdges4
        btLogin.DisabledState.BorderColor = Color.DarkGray
        btLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btLogin.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btLogin.FillColor = Color.Transparent
        btLogin.FillColor2 = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        btLogin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btLogin.ForeColor = Color.White
        btLogin.Location = New Point(101, 361)
        btLogin.Name = "btLogin"
        btLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        btLogin.Size = New Size(150, 45)
        btLogin.TabIndex = 1
        btLogin.Text = "Login"
        ' 
        ' tbPassword
        ' 
        tbPassword.CustomizableEdges = CustomizableEdges6
        tbPassword.DefaultText = ""
        tbPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbPassword.Location = New Point(79, 282)
        tbPassword.Name = "tbPassword"
        tbPassword.PasswordChar = "*"c
        tbPassword.PlaceholderText = ""
        tbPassword.SelectedText = ""
        tbPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        tbPassword.Size = New Size(200, 36)
        tbPassword.TabIndex = 0
        ' 
        ' tbEmployeeID
        ' 
        tbEmployeeID.CustomizableEdges = CustomizableEdges8
        tbEmployeeID.DefaultText = ""
        tbEmployeeID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbEmployeeID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbEmployeeID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbEmployeeID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbEmployeeID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbEmployeeID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbEmployeeID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbEmployeeID.Location = New Point(79, 208)
        tbEmployeeID.Name = "tbEmployeeID"
        tbEmployeeID.PasswordChar = ChrW(0)
        tbEmployeeID.PlaceholderText = ""
        tbEmployeeID.SelectedText = ""
        tbEmployeeID.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        tbEmployeeID.Size = New Size(200, 36)
        tbEmployeeID.TabIndex = 0
        ' 
        ' pnldesignlogin
        ' 
        pnldesignlogin.Controls.Add(PictureBox1)
        pnldesignlogin.CustomizableEdges = CustomizableEdges12
        pnldesignlogin.Dock = DockStyle.Fill
        pnldesignlogin.FillColor2 = Color.Transparent
        pnldesignlogin.FillColor3 = Color.Transparent
        pnldesignlogin.FillColor4 = Color.Transparent
        pnldesignlogin.Location = New Point(0, 0)
        pnldesignlogin.Name = "pnldesignlogin"
        pnldesignlogin.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        pnldesignlogin.Size = New Size(454, 460)
        pnldesignlogin.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(454, 460)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2HtmlToolTip1
        ' 
        Guna2HtmlToolTip1.AllowLinksHandling = True
        Guna2HtmlToolTip1.BackColor = Color.FromArgb(CByte(20), CByte(49), CByte(105))
        Guna2HtmlToolTip1.BorderColor = Color.Transparent
        Guna2HtmlToolTip1.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2HtmlToolTip1.MaximumSize = New Size(0, 0)
        ' 
        ' FrmLogin
        ' 
        AcceptButton = btLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(44), CByte(79))
        ClientSize = New Size(819, 460)
        ControlBox = False
        Controls.Add(pnldesignlogin)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmLogin"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        CType(imgLogomain, ComponentModel.ISupportInitialize).EndInit()
        pnldesignlogin.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnldesignlogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chkShowPass As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents imgLogomain As PictureBox
    Friend WithEvents lblForgotpassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
