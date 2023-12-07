<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges29 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges30 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges31 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges32 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvCustomers = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcID = New DataGridViewTextBoxColumn()
        dgvcCustomerFirstName = New DataGridViewTextBoxColumn()
        dgvcCustomerLastName = New DataGridViewTextBoxColumn()
        dgvcCompanyName = New DataGridViewTextBoxColumn()
        btnSearch = New Guna.UI2.WinForms.Guna2GradientButton()
        bnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblCompanyName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        tbCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.CustomizableEdges = CustomizableEdges17
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor = Color.Transparent
        btnEdit.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(774, 97)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnEdit.Size = New Size(106, 35)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        ' 
        ' dgvCustomers
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvCustomers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvCustomers.ColumnHeadersHeight = 17
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {dgvcID, dgvcCustomerFirstName, dgvcCustomerLastName, dgvcCompanyName})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvCustomers.DefaultCellStyle = DataGridViewCellStyle6
        dgvCustomers.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCustomers.Location = New Point(365, 139)
        dgvCustomers.Margin = New Padding(3, 4, 3, 4)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.RowHeadersWidth = 51
        dgvCustomers.RowTemplate.Height = 25
        dgvCustomers.Size = New Size(515, 420)
        dgvCustomers.TabIndex = 4
        dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvCustomers.ThemeStyle.BackColor = Color.White
        dgvCustomers.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCustomers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCustomers.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvCustomers.ThemeStyle.HeaderStyle.Height = 17
        dgvCustomers.ThemeStyle.ReadOnly = False
        dgvCustomers.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvCustomers.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvCustomers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvCustomers.ThemeStyle.RowsStyle.Height = 25
        dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcID
        ' 
        dgvcID.FillWeight = 20F
        dgvcID.HeaderText = "ID"
        dgvcID.MinimumWidth = 6
        dgvcID.Name = "dgvcID"
        ' 
        ' dgvcCustomerFirstName
        ' 
        dgvcCustomerFirstName.HeaderText = "First Name"
        dgvcCustomerFirstName.MinimumWidth = 6
        dgvcCustomerFirstName.Name = "dgvcCustomerFirstName"
        ' 
        ' dgvcCustomerLastName
        ' 
        dgvcCustomerLastName.HeaderText = "Last Name"
        dgvcCustomerLastName.MinimumWidth = 6
        dgvcCustomerLastName.Name = "dgvcCustomerLastName"
        ' 
        ' dgvcCompanyName
        ' 
        dgvcCompanyName.HeaderText = "Company Name"
        dgvcCompanyName.MinimumWidth = 6
        dgvcCompanyName.Name = "dgvcCompanyName"
        ' 
        ' btnSearch
        ' 
        btnSearch.CustomizableEdges = CustomizableEdges19
        btnSearch.DisabledState.BorderColor = Color.DarkGray
        btnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        btnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSearch.FillColor2 = Color.Transparent
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(568, 96)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnSearch.Size = New Size(75, 35)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        ' 
        ' bnAdd
        ' 
        bnAdd.Anchor = AnchorStyles.Left
        bnAdd.CustomizableEdges = CustomizableEdges21
        bnAdd.DisabledState.BorderColor = Color.DarkGray
        bnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        bnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bnAdd.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bnAdd.FillColor = Color.Transparent
        bnAdd.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        bnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bnAdd.ForeColor = Color.White
        bnAdd.GradientMode = Drawing2D.LinearGradientMode.Vertical
        bnAdd.Location = New Point(70, 485)
        bnAdd.Margin = New Padding(3, 4, 3, 4)
        bnAdd.Name = "bnAdd"
        bnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        bnAdd.Size = New Size(206, 60)
        bnAdd.TabIndex = 7
        bnAdd.Text = "Add"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(57, 208)
        Guna2HtmlLabel2.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(3, 2)
        Guna2HtmlLabel2.TabIndex = 9
        Guna2HtmlLabel2.Text = Nothing
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Anchor = AnchorStyles.Left
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.ForeColor = SystemColors.ActiveCaption
        lblFirstName.Location = New Point(57, 147)
        lblFirstName.Margin = New Padding(3, 4, 3, 4)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(73, 22)
        lblFirstName.TabIndex = 10
        lblFirstName.Text = "Last Name"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.Anchor = AnchorStyles.Left
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = SystemColors.ActiveCaption
        Guna2HtmlLabel1.Location = New Point(57, 216)
        Guna2HtmlLabel1.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(74, 22)
        Guna2HtmlLabel1.TabIndex = 10
        Guna2HtmlLabel1.Text = "First Name"
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.Anchor = AnchorStyles.Left
        lblCompanyName.BackColor = Color.Transparent
        lblCompanyName.ForeColor = SystemColors.ActiveCaption
        lblCompanyName.Location = New Point(57, 285)
        lblCompanyName.Margin = New Padding(3, 4, 3, 4)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(110, 22)
        lblCompanyName.TabIndex = 10
        lblCompanyName.Text = "Company Name"
        ' 
        ' tbFirstName
        ' 
        tbFirstName.Anchor = AnchorStyles.Left
        tbFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbFirstName.CustomizableEdges = CustomizableEdges23
        tbFirstName.DefaultText = ""
        tbFirstName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbFirstName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbFirstName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbFirstName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstName.Location = New Point(57, 170)
        tbFirstName.Name = "tbFirstName"
        tbFirstName.PasswordChar = ChrW(0)
        tbFirstName.PlaceholderText = ""
        tbFirstName.SelectedText = ""
        tbFirstName.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        tbFirstName.Size = New Size(229, 36)
        tbFirstName.TabIndex = 12
        ' 
        ' tbLastName
        ' 
        tbLastName.Anchor = AnchorStyles.Left
        tbLastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbLastName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbLastName.CustomizableEdges = CustomizableEdges25
        tbLastName.DefaultText = ""
        tbLastName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLastName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLastName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLastName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastName.Location = New Point(57, 240)
        tbLastName.Name = "tbLastName"
        tbLastName.PasswordChar = ChrW(0)
        tbLastName.PlaceholderText = ""
        tbLastName.SelectedText = ""
        tbLastName.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        tbLastName.Size = New Size(229, 36)
        tbLastName.TabIndex = 13
        ' 
        ' tbCompanyName
        ' 
        tbCompanyName.Anchor = AnchorStyles.Left
        tbCompanyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCompanyName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCompanyName.CustomizableEdges = CustomizableEdges27
        tbCompanyName.DefaultText = ""
        tbCompanyName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCompanyName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCompanyName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCompanyName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCompanyName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCompanyName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCompanyName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCompanyName.Location = New Point(57, 311)
        tbCompanyName.Name = "tbCompanyName"
        tbCompanyName.PasswordChar = ChrW(0)
        tbCompanyName.PlaceholderText = ""
        tbCompanyName.SelectedText = ""
        tbCompanyName.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        tbCompanyName.Size = New Size(229, 36)
        tbCompanyName.TabIndex = 14
        ' 
        ' tbSearch
        ' 
        tbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbSearch.CustomizableEdges = CustomizableEdges29
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Location = New Point(365, 96)
        tbSearch.Name = "tbSearch"
        tbSearch.PasswordChar = ChrW(0)
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges30
        tbSearch.Size = New Size(197, 36)
        tbSearch.TabIndex = 15
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.Left
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = SystemColors.ActiveCaption
        lblID.Location = New Point(57, 52)
        lblID.Margin = New Padding(3, 4, 3, 4)
        lblID.Name = "lblID"
        lblID.Size = New Size(21, 22)
        lblID.TabIndex = 10
        lblID.Text = "ID:"
        ' 
        ' tbCustomerID
        ' 
        tbCustomerID.Anchor = AnchorStyles.Left
        tbCustomerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCustomerID.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCustomerID.CustomizableEdges = CustomizableEdges31
        tbCustomerID.DefaultText = ""
        tbCustomerID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCustomerID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCustomerID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCustomerID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Location = New Point(57, 78)
        tbCustomerID.Name = "tbCustomerID"
        tbCustomerID.PasswordChar = ChrW(0)
        tbCustomerID.PlaceholderText = ""
        tbCustomerID.SelectedText = ""
        tbCustomerID.ShadowDecoration.CustomizableEdges = CustomizableEdges32
        tbCustomerID.Size = New Size(229, 36)
        tbCustomerID.TabIndex = 12
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(tbSearch)
        Controls.Add(tbCompanyName)
        Controls.Add(tbLastName)
        Controls.Add(tbCustomerID)
        Controls.Add(tbFirstName)
        Controls.Add(lblCompanyName)
        Controls.Add(lblID)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(lblFirstName)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(bnAdd)
        Controls.Add(dgvCustomers)
        Controls.Add(btnSearch)
        Controls.Add(btnEdit)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCustomer"
        Text = "frmCustomer"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvCustomers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents bnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvcID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCustomerFirstName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCustomerLastName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCompanyName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCustomerID As Guna.UI2.WinForms.Guna2TextBox
End Class
