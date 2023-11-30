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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmLogin))
        pnlLogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        tbLogin = New Guna.UI2.WinForms.Guna2TextBox()
        pnldesignlogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        PictureBox1 = New PictureBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlLogin.SuspendLayout()
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
        lblHeader.Location = New Point(144, 65)
        lblHeader.Margin = New Padding(3, 4, 3, 4)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(103, 20)
        lblHeader.TabIndex = 2
        lblHeader.Text = "Project OMAC"
        lblHeader.TextAlignment = ContentAlignment.MiddleCenter
        lblHeader.UseGdiPlusTextRendering = True
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackgroundImageLayout = ImageLayout.None
        pnlLogin.Controls.Add(Guna2HtmlLabel2)
        pnlLogin.Controls.Add(lblHeader)
        pnlLogin.Controls.Add(Guna2HtmlLabel1)
        pnlLogin.Controls.Add(lblUser)
        pnlLogin.Controls.Add(Guna2GradientButton1)
        pnlLogin.Controls.Add(Guna2TextBox2)
        pnlLogin.Controls.Add(tbLogin)
        pnlLogin.CustomizableEdges = CustomizableEdges7
        pnlLogin.Dock = DockStyle.Right
        pnlLogin.FillColor = Color.Transparent
        pnlLogin.FillColor2 = Color.Transparent
        pnlLogin.FillColor3 = Color.Transparent
        pnlLogin.FillColor4 = Color.FromArgb(CByte(106), CByte(148), CByte(245))
        pnlLogin.Location = New Point(519, 0)
        pnlLogin.Margin = New Padding(3, 4, 3, 4)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Quality = 2
        pnlLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlLogin.Size = New Size(417, 613)
        pnlLogin.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        Guna2HtmlLabel1.Location = New Point(102, 235)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(72, 22)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "Password :"
        Guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.BackColor = Color.Transparent
        lblUser.ForeColor = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        lblUser.Location = New Point(102, 136)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(91, 22)
        lblUser.TabIndex = 3
        lblUser.Text = "Employee ID:"
        lblUser.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges1
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.Transparent
        Guna2GradientButton1.FillColor2 = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(127, 369)
        Guna2GradientButton1.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton1.Size = New Size(171, 60)
        Guna2GradientButton1.TabIndex = 1
        Guna2GradientButton1.Text = "Login"
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.CustomizableEdges = CustomizableEdges3
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(102, 264)
        Guna2TextBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox2.Size = New Size(229, 48)
        Guna2TextBox2.TabIndex = 0
        ' 
        ' tbLogin
        ' 
        tbLogin.CustomizableEdges = CustomizableEdges5
        tbLogin.DefaultText = ""
        tbLogin.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLogin.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLogin.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLogin.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLogin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLogin.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLogin.Location = New Point(102, 165)
        tbLogin.Margin = New Padding(3, 4, 3, 4)
        tbLogin.Name = "tbLogin"
        tbLogin.PasswordChar = ChrW(0)
        tbLogin.PlaceholderText = ""
        tbLogin.SelectedText = ""
        tbLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbLogin.Size = New Size(229, 48)
        tbLogin.TabIndex = 0
        ' 
        ' pnldesignlogin
        ' 
        pnldesignlogin.Controls.Add(PictureBox1)
        pnldesignlogin.CustomizableEdges = CustomizableEdges9
        pnldesignlogin.Dock = DockStyle.Fill
        pnldesignlogin.FillColor2 = Color.Transparent
        pnldesignlogin.FillColor3 = Color.Transparent
        pnldesignlogin.FillColor4 = Color.Transparent
        pnldesignlogin.Location = New Point(0, 0)
        pnldesignlogin.Margin = New Padding(3, 4, 3, 4)
        pnldesignlogin.Name = "pnldesignlogin"
        pnldesignlogin.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnldesignlogin.Size = New Size(519, 613)
        pnldesignlogin.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(519, 613)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(147, 106)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(122, 22)
        Guna2HtmlLabel2.TabIndex = 4
        Guna2HtmlLabel2.Text = "Guna2HtmlLabel2"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(44), CByte(79))
        ClientSize = New Size(936, 613)
        Controls.Add(pnldesignlogin)
        Controls.Add(pnlLogin)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        pnldesignlogin.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnldesignlogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
