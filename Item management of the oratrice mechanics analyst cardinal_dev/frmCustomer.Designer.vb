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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvCustomers = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcID = New DataGridViewTextBoxColumn()
        dgvcCustomerFirstName = New DataGridViewTextBoxColumn()
        dgvcCustomerLastName = New DataGridViewTextBoxColumn()
        dgvcCompanyName = New DataGridViewTextBoxColumn()
        btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblfirstname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblCompanyName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        tbCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        lblSearch = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnExport = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.CustomizableEdges = CustomizableEdges1
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor = Color.Transparent
        btnEdit.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(696, 40)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnEdit.Size = New Size(81, 26)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AllowUserToDeleteRows = False
        dgvCustomers.AllowUserToResizeColumns = False
        dgvCustomers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvCustomers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCustomers.ColumnHeadersHeight = 17
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {dgvcID, dgvcCustomerFirstName, dgvcCustomerLastName, dgvcCompanyName})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCustomers.DefaultCellStyle = DataGridViewCellStyle3
        dgvCustomers.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCustomers.Location = New Point(326, 71)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.RowHeadersWidth = 51
        dgvCustomers.RowTemplate.Height = 25
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvCustomers.ShowEditingIcon = False
        dgvCustomers.Size = New Size(451, 309)
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
        dgvCustomers.ThemeStyle.ReadOnly = True
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
        dgvcID.ReadOnly = True
        ' 
        ' dgvcCustomerFirstName
        ' 
        dgvcCustomerFirstName.HeaderText = "First Name"
        dgvcCustomerFirstName.MinimumWidth = 6
        dgvcCustomerFirstName.Name = "dgvcCustomerFirstName"
        dgvcCustomerFirstName.ReadOnly = True
        ' 
        ' dgvcCustomerLastName
        ' 
        dgvcCustomerLastName.HeaderText = "Last Name"
        dgvcCustomerLastName.MinimumWidth = 6
        dgvcCustomerLastName.Name = "dgvcCustomerLastName"
        dgvcCustomerLastName.ReadOnly = True
        ' 
        ' dgvcCompanyName
        ' 
        dgvcCompanyName.HeaderText = "Company Name"
        dgvcCompanyName.MinimumWidth = 6
        dgvcCompanyName.Name = "dgvcCompanyName"
        dgvcCompanyName.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Left
        btnAdd.CustomizableEdges = CustomizableEdges3
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
        btnAdd.Location = New Point(61, 368)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnAdd.Size = New Size(180, 45)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(50, 156)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(3, 2)
        Guna2HtmlLabel2.TabIndex = 9
        Guna2HtmlLabel2.Text = Nothing
        ' 
        ' lblLastName
        ' 
        lblLastName.Anchor = AnchorStyles.Left
        lblLastName.BackColor = Color.Transparent
        lblLastName.ForeColor = SystemColors.ActiveCaption
        lblLastName.Location = New Point(50, 114)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(59, 17)
        lblLastName.TabIndex = 10
        lblLastName.Text = "Last Name"
        ' 
        ' lblfirstname
        ' 
        lblfirstname.Anchor = AnchorStyles.Left
        lblfirstname.BackColor = Color.Transparent
        lblfirstname.ForeColor = SystemColors.ActiveCaption
        lblfirstname.Location = New Point(50, 166)
        lblfirstname.Name = "lblfirstname"
        lblfirstname.Size = New Size(60, 17)
        lblfirstname.TabIndex = 10
        lblfirstname.Text = "First Name"
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.Anchor = AnchorStyles.Left
        lblCompanyName.BackColor = Color.Transparent
        lblCompanyName.ForeColor = SystemColors.ActiveCaption
        lblCompanyName.Location = New Point(50, 218)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(90, 17)
        lblCompanyName.TabIndex = 10
        lblCompanyName.Text = "Company Name"
        ' 
        ' tbLastName
        ' 
        tbLastName.Anchor = AnchorStyles.Left
        tbLastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbLastName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbLastName.CustomizableEdges = CustomizableEdges5
        tbLastName.DefaultText = ""
        tbLastName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLastName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLastName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLastName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLastName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLastName.Location = New Point(50, 132)
        tbLastName.Margin = New Padding(3, 2, 3, 2)
        tbLastName.Name = "tbLastName"
        tbLastName.PasswordChar = ChrW(0)
        tbLastName.PlaceholderText = ""
        tbLastName.SelectedText = ""
        tbLastName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbLastName.Size = New Size(200, 27)
        tbLastName.TabIndex = 12
        ' 
        ' tbFirstName
        ' 
        tbFirstName.Anchor = AnchorStyles.Left
        tbFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbFirstName.CustomizableEdges = CustomizableEdges7
        tbFirstName.DefaultText = ""
        tbFirstName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbFirstName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbFirstName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbFirstName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbFirstName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbFirstName.Location = New Point(50, 184)
        tbFirstName.Margin = New Padding(3, 2, 3, 2)
        tbFirstName.Name = "tbFirstName"
        tbFirstName.PasswordChar = ChrW(0)
        tbFirstName.PlaceholderText = ""
        tbFirstName.SelectedText = ""
        tbFirstName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        tbFirstName.Size = New Size(200, 27)
        tbFirstName.TabIndex = 13
        ' 
        ' tbCompanyName
        ' 
        tbCompanyName.Anchor = AnchorStyles.Left
        tbCompanyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCompanyName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCompanyName.CustomizableEdges = CustomizableEdges9
        tbCompanyName.DefaultText = ""
        tbCompanyName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCompanyName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCompanyName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCompanyName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCompanyName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCompanyName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCompanyName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCompanyName.Location = New Point(50, 237)
        tbCompanyName.Margin = New Padding(3, 2, 3, 2)
        tbCompanyName.Name = "tbCompanyName"
        tbCompanyName.PasswordChar = ChrW(0)
        tbCompanyName.PlaceholderText = ""
        tbCompanyName.SelectedText = ""
        tbCompanyName.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        tbCompanyName.Size = New Size(200, 27)
        tbCompanyName.TabIndex = 14
        ' 
        ' tbSearch
        ' 
        tbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbSearch.CustomizableEdges = CustomizableEdges11
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Location = New Point(326, 39)
        tbSearch.Margin = New Padding(3, 2, 3, 2)
        tbSearch.Name = "tbSearch"
        tbSearch.PasswordChar = ChrW(0)
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        tbSearch.Size = New Size(172, 27)
        tbSearch.TabIndex = 15
        ' 
        ' lblID
        ' 
        lblID.Anchor = AnchorStyles.Left
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = SystemColors.ActiveCaption
        lblID.Location = New Point(50, 43)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 17)
        lblID.TabIndex = 10
        lblID.Text = "ID:"
        ' 
        ' tbCustomerID
        ' 
        tbCustomerID.Anchor = AnchorStyles.Left
        tbCustomerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCustomerID.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCustomerID.CustomizableEdges = CustomizableEdges13
        tbCustomerID.DefaultText = ""
        tbCustomerID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCustomerID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCustomerID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCustomerID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Location = New Point(50, 62)
        tbCustomerID.Margin = New Padding(3, 2, 3, 2)
        tbCustomerID.Name = "tbCustomerID"
        tbCustomerID.PasswordChar = ChrW(0)
        tbCustomerID.PlaceholderText = ""
        tbCustomerID.SelectedText = ""
        tbCustomerID.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        tbCustomerID.Size = New Size(200, 27)
        tbCustomerID.TabIndex = 12
        ' 
        ' lblSearch
        ' 
        lblSearch.BackColor = Color.Transparent
        lblSearch.ForeColor = SystemColors.ActiveCaption
        lblSearch.Location = New Point(326, 21)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(41, 17)
        lblSearch.TabIndex = 10
        lblSearch.Text = "Search:"
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
        btnExport.Location = New Point(326, 387)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnExport.Size = New Size(79, 26)
        btnExport.TabIndex = 16
        btnExport.Text = "Export"
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 458)
        Controls.Add(btnExport)
        Controls.Add(tbSearch)
        Controls.Add(tbCompanyName)
        Controls.Add(tbFirstName)
        Controls.Add(tbCustomerID)
        Controls.Add(tbLastName)
        Controls.Add(lblCompanyName)
        Controls.Add(lblSearch)
        Controls.Add(lblID)
        Controls.Add(lblfirstname)
        Controls.Add(lblLastName)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(btnAdd)
        Controls.Add(dgvCustomers)
        Controls.Add(btnEdit)
        Name = "frmCustomer"
        Text = "Customer"
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
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblfirstname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCompanyName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCustomerID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSearch As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
End Class
