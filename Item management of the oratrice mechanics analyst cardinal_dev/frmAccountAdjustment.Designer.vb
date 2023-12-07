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
        dgvUserInfo = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcID = New DataGridViewTextBoxColumn()
        dgvcName = New DataGridViewTextBoxColumn()
        dgvcPassword = New DataGridViewTextBoxColumn()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        comboxAccesslevel = New Guna.UI2.WinForms.Guna2ComboBox()
        btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        lblrole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvUserInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUserInfo
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvUserInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvUserInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        dgvUserInfo.Columns.AddRange(New DataGridViewColumn() {dgvcID, dgvcName, dgvcPassword})
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
        dgvUserInfo.RowHeadersVisible = False
        dgvUserInfo.RowTemplate.Height = 25
        dgvUserInfo.Size = New Size(489, 334)
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
        dgvUserInfo.ThemeStyle.ReadOnly = False
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
        ' 
        ' dgvcName
        ' 
        dgvcName.HeaderText = "Name"
        dgvcName.Name = "dgvcName"
        ' 
        ' dgvcPassword
        ' 
        dgvcPassword.HeaderText = "Password"
        dgvcPassword.Name = "dgvcPassword"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.Anchor = AnchorStyles.Left
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(23, 180)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(200, 27)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.Anchor = AnchorStyles.Left
        Guna2TextBox2.CustomizableEdges = CustomizableEdges3
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(23, 126)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox2.Size = New Size(200, 27)
        Guna2TextBox2.TabIndex = 2
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.Anchor = AnchorStyles.Left
        Guna2TextBox3.CustomizableEdges = CustomizableEdges5
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(23, 233)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox3.Size = New Size(200, 26)
        Guna2TextBox3.TabIndex = 2
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
        ' comboxAccesslevel
        ' 
        comboxAccesslevel.Anchor = AnchorStyles.Left
        comboxAccesslevel.BackColor = Color.Transparent
        comboxAccesslevel.CustomizableEdges = CustomizableEdges7
        comboxAccesslevel.DrawMode = DrawMode.OwnerDrawFixed
        comboxAccesslevel.DropDownStyle = ComboBoxStyle.DropDownList
        comboxAccesslevel.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        comboxAccesslevel.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        comboxAccesslevel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        comboxAccesslevel.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        comboxAccesslevel.ItemHeight = 30
        comboxAccesslevel.Location = New Point(23, 312)
        comboxAccesslevel.Name = "comboxAccesslevel"
        comboxAccesslevel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        comboxAccesslevel.Size = New Size(200, 36)
        comboxAccesslevel.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.CustomizableEdges = CustomizableEdges9
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
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges10
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
        btnEdit.CustomizableEdges = CustomizableEdges11
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
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges12
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
        tbID.CustomizableEdges = CustomizableEdges13
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
        tbID.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        tbID.Size = New Size(200, 27)
        tbID.TabIndex = 1
        ' 
        ' frmAccountAdjustment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEdit)
        Controls.Add(lblPassword)
        Controls.Add(lblLastName)
        Controls.Add(lblrole)
        Controls.Add(lblFirstName)
        Controls.Add(btnAdd)
        Controls.Add(comboxAccesslevel)
        Controls.Add(lblID)
        Controls.Add(Guna2TextBox3)
        Controls.Add(Guna2TextBox2)
        Controls.Add(tbID)
        Controls.Add(Guna2TextBox1)
        Controls.Add(dgvUserInfo)
        Name = "frmAccountAdjustment"
        Text = "Account Adjustment"
        CType(dgvUserInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUserInfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcPassword As DataGridViewTextBoxColumn
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents comboxAccesslevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblrole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbID As Guna.UI2.WinForms.Guna2TextBox
End Class
