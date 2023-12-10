<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountAdjustment
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvUserInfo = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcID = New DataGridViewTextBoxColumn()
        dgvcFirstName = New DataGridViewTextBoxColumn()
        dgvcLastName = New DataGridViewTextBoxColumn()
        dgvcPassword = New DataGridViewTextBoxColumn()
        dgvcAccesslvl = New DataGridViewTextBoxColumn()
        tbFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        tbLastname = New Guna.UI2.WinForms.Guna2TextBox()
        tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        lblrole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbID = New Guna.UI2.WinForms.Guna2TextBox()
        cmbAccessLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        btnExport = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(dgvUserInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUserInfo
        ' 
        dgvUserInfo.AllowUserToAddRows = False
        dgvUserInfo.AllowUserToDeleteRows = False
        dgvUserInfo.AllowUserToResizeColumns = False
        dgvUserInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvUserInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvUserInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUserInfo.CausesValidation = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvUserInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvUserInfo.ColumnHeadersHeight = 17
        dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvUserInfo.Columns.AddRange(New DataGridViewColumn() {dgvcID, dgvcFirstName, dgvcLastName, dgvcPassword, dgvcAccesslvl})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvUserInfo.DefaultCellStyle = DataGridViewCellStyle3
        dgvUserInfo.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserInfo.Location = New Point(275, 92)
        dgvUserInfo.Name = "dgvUserInfo"
        dgvUserInfo.ReadOnly = True
        dgvUserInfo.RowHeadersVisible = False
        dgvUserInfo.RowTemplate.Height = 25
        dgvUserInfo.Size = New Size(488, 314)
        dgvUserInfo.TabIndex = 0
        dgvUserInfo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvUserInfo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvUserInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvUserInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvUserInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvUserInfo.ThemeStyle.BackColor = Color.White
        dgvUserInfo.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserInfo.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvUserInfo.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvUserInfo.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvUserInfo.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvUserInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvUserInfo.ThemeStyle.HeaderStyle.Height = 17
        dgvUserInfo.ThemeStyle.ReadOnly = True
        dgvUserInfo.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvUserInfo.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUserInfo.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvUserInfo.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvUserInfo.ThemeStyle.RowsStyle.Height = 25
        dgvUserInfo.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserInfo.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcID
        ' 
        dgvcID.HeaderText = "ID"
        dgvcID.Name = "dgvcID"
        dgvcID.ReadOnly = True
        ' 
        ' dgvcFirstName
        ' 
        dgvcFirstName.HeaderText = "FirstName"
        dgvcFirstName.Name = "dgvcFirstName"
        dgvcFirstName.ReadOnly = True
        ' 
        ' dgvcLastName
        ' 
        dgvcLastName.HeaderText = "LastName"
        dgvcLastName.Name = "dgvcLastName"
        dgvcLastName.ReadOnly = True
        ' 
        ' dgvcPassword
        ' 
        dgvcPassword.HeaderText = "Password"
        dgvcPassword.Name = "dgvcPassword"
        dgvcPassword.ReadOnly = True
        ' 
        ' dgvcAccesslvl
        ' 
        dgvcAccesslvl.HeaderText = "Accesslvl"
        dgvcAccesslvl.Name = "dgvcAccesslvl"
        dgvcAccesslvl.ReadOnly = True
        ' 
        ' tbFirstname
        ' 
        tbFirstname.Anchor = AnchorStyles.Left
        tbFirstname.CustomizableEdges = CustomizableEdges1
        tbFirstname.DefaultText = ""
        tbFirstname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbFirstname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbFirstname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbFirstname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstname.Location = New Point(23, 180)
        tbFirstname.Name = "tbFirstname"
        tbFirstname.PasswordChar = ChrW(0)
        tbFirstname.PlaceholderText = ""
        tbFirstname.SelectedText = ""
        tbFirstname.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        tbFirstname.Size = New Size(200, 27)
        tbFirstname.TabIndex = 1
        ' 
        ' tbLastname
        ' 
        tbLastname.Anchor = AnchorStyles.Left
        tbLastname.CustomizableEdges = CustomizableEdges3
        tbLastname.DefaultText = ""
        tbLastname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLastname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLastname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLastname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastname.Location = New Point(23, 126)
        tbLastname.Name = "tbLastname"
        tbLastname.PasswordChar = ChrW(0)
        tbLastname.PlaceholderText = ""
        tbLastname.SelectedText = ""
        tbLastname.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbLastname.Size = New Size(200, 27)
        tbLastname.TabIndex = 2
        ' 
        ' tbPassword
        ' 
        tbPassword.Anchor = AnchorStyles.Left
        tbPassword.CustomizableEdges = CustomizableEdges5
        tbPassword.DefaultText = ""
        tbPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbPassword.Location = New Point(23, 233)
        tbPassword.Name = "tbPassword"
        tbPassword.PasswordChar = ChrW(0)
        tbPassword.PlaceholderText = ""
        tbPassword.SelectedText = ""
        tbPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbPassword.Size = New Size(200, 26)
        tbPassword.TabIndex = 2
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.Left
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = SystemColors.ActiveCaption
        lblID.Location = New Point(23, 52)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 17)
        lblID.TabIndex = 3
        lblID.Text = "ID:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.CustomizableEdges = CustomizableEdges7
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.Transparent
        btnAdd.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.White
        btnAdd.GradientMode = Drawing2D.LinearGradientMode.Vertical
        btnAdd.Location = New Point(33, 361)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAdd.Size = New Size(180, 45)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Anchor = AnchorStyles.Left
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.ForeColor = SystemColors.ActiveCaption
        lblFirstName.Location = New Point(23, 157)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(66, 17)
        lblFirstName.TabIndex = 6
        lblFirstName.Text = "First Name :"
        ' 
        ' lblLastName
        ' 
        lblLastName.Anchor = AnchorStyles.Left
        lblLastName.BackColor = Color.Transparent
        lblLastName.ForeColor = SystemColors.ActiveCaption
        lblLastName.Location = New Point(23, 103)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(65, 17)
        lblLastName.TabIndex = 6
        lblLastName.Text = "Last Name :"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Left
        lblPassword.BackColor = Color.Transparent
        lblPassword.ForeColor = SystemColors.ActiveCaption
        lblPassword.Location = New Point(23, 210)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(59, 17)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password :"
        ' 
        ' btnEdit
        ' 
        btnEdit.CustomizableEdges = CustomizableEdges9
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor2 = Color.Transparent
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(275, 48)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnEdit.Size = New Size(73, 38)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit Account"
        ' 
        ' lblrole
        ' 
        lblrole.Anchor = AnchorStyles.Left
        lblrole.BackColor = Color.Transparent
        lblrole.ForeColor = SystemColors.ActiveCaption
        lblrole.Location = New Point(23, 291)
        lblrole.Name = "lblrole"
        lblrole.Size = New Size(32, 17)
        lblrole.TabIndex = 6
        lblrole.Text = "Role :"
        ' 
        ' tbID
        ' 
        tbID.Anchor = AnchorStyles.Left
        tbID.CustomizableEdges = CustomizableEdges11
        tbID.DefaultText = ""
        tbID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbID.Location = New Point(23, 70)
        tbID.Name = "tbID"
        tbID.PasswordChar = ChrW(0)
        tbID.PlaceholderText = ""
        tbID.SelectedText = ""
        tbID.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        tbID.Size = New Size(200, 27)
        tbID.TabIndex = 1
        ' 
        ' cmbAccessLevel
        ' 
        cmbAccessLevel.Anchor = AnchorStyles.Left
        cmbAccessLevel.BackColor = Color.Transparent
        cmbAccessLevel.CustomizableEdges = CustomizableEdges13
        cmbAccessLevel.DrawMode = DrawMode.OwnerDrawFixed
        cmbAccessLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAccessLevel.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbAccessLevel.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbAccessLevel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cmbAccessLevel.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbAccessLevel.ItemHeight = 30
        cmbAccessLevel.Items.AddRange(New Object() {"Admin", "Manager", "Employee"})
        cmbAccessLevel.Location = New Point(23, 314)
        cmbAccessLevel.Name = "cmbAccessLevel"
        cmbAccessLevel.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        cmbAccessLevel.Size = New Size(200, 36)
        cmbAccessLevel.TabIndex = 8
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExport.CustomizableEdges = CustomizableEdges15
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor2 = Color.Empty
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(275, 423)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnExport.Size = New Size(79, 26)
        btnExport.TabIndex = 12
        btnExport.Text = "Export"
        ' 
        ' frmAccountAdjustment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExport)
        Controls.Add(cmbAccessLevel)
        Controls.Add(btnEdit)
        Controls.Add(lblPassword)
        Controls.Add(lblLastName)
        Controls.Add(lblrole)
        Controls.Add(lblFirstName)
        Controls.Add(btnAdd)
        Controls.Add(lblID)
        Controls.Add(tbPassword)
        Controls.Add(tbLastname)
        Controls.Add(tbID)
        Controls.Add(tbFirstname)
        Controls.Add(dgvUserInfo)
        Name = "frmAccountAdjustment"
        Text = "Account Adjustment"
        CType(dgvUserInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUserInfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblrole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvcID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcFirstName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcLastName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcPassword As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAccesslvl As DataGridViewTextBoxColumn
    Friend WithEvents cmbAccessLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2GradientButton
End Class
