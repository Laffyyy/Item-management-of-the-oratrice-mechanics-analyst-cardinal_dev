<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderManagement
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvOrderManagement = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcOrderID = New DataGridViewTextBoxColumn()
        dgvcCustomerID = New DataGridViewTextBoxColumn()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        dgvcProductID = New DataGridViewTextBoxColumn()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcDateOrdered = New DataGridViewTextBoxColumn()
        dgvcStatus = New DataGridViewTextBoxColumn()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        tbCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        lblCustomerName = New Label()
        tbProductName = New Guna.UI2.WinForms.Guna2TextBox()
        lblProductName = New Label()
        lblQuantity = New Label()
        tbQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        lblSearch = New Label()
        btnExport = New Guna.UI2.WinForms.Guna2GradientButton()
        lblCustomerID = New Label()
        lblProductID = New Label()
        lbOrderID = New Label()
        cmbProductID = New Guna.UI2.WinForms.Guna2ComboBox()
        cmbCustomerId = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(dgvOrderManagement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDelete.CustomizableEdges = CustomizableEdges1
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.FillColor2 = Color.FromArgb(CByte(255), CByte(249), CByte(144))
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(688, 386)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnDelete.Size = New Size(67, 34)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete Order"
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.CustomizableEdges = CustomizableEdges3
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor = Color.Transparent
        btnEdit.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(668, 53)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEdit.Size = New Size(87, 23)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Order"
        ' 
        ' dgvOrderManagement
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvOrderManagement.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderManagement.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvOrderManagement.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrderManagement.ColumnHeadersHeight = 40
        dgvOrderManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderManagement.Columns.AddRange(New DataGridViewColumn() {dgvcOrderID, dgvcCustomerID, dgvcCustomerName, dgvcProductID, dgvcProductName, dgvcQuantity, dgvcDateOrdered, dgvcStatus})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrderManagement.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrderManagement.GridColor = Color.White
        dgvOrderManagement.Location = New Point(276, 86)
        dgvOrderManagement.Name = "dgvOrderManagement"
        dgvOrderManagement.RowHeadersVisible = False
        dgvOrderManagement.RowHeadersWidth = 51
        dgvOrderManagement.RowTemplate.Height = 25
        dgvOrderManagement.Size = New Size(479, 291)
        dgvOrderManagement.TabIndex = 6
        dgvOrderManagement.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvOrderManagement.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvOrderManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvOrderManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvOrderManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvOrderManagement.ThemeStyle.BackColor = Color.White
        dgvOrderManagement.ThemeStyle.GridColor = Color.White
        dgvOrderManagement.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvOrderManagement.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrderManagement.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderManagement.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvOrderManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderManagement.ThemeStyle.HeaderStyle.Height = 40
        dgvOrderManagement.ThemeStyle.ReadOnly = False
        dgvOrderManagement.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvOrderManagement.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderManagement.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderManagement.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvOrderManagement.ThemeStyle.RowsStyle.Height = 25
        dgvOrderManagement.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderManagement.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcOrderID
        ' 
        dgvcOrderID.HeaderText = "Order ID"
        dgvcOrderID.Name = "dgvcOrderID"
        ' 
        ' dgvcCustomerID
        ' 
        dgvcCustomerID.HeaderText = "Customer ID"
        dgvcCustomerID.Name = "dgvcCustomerID"
        ' 
        ' dgvcCustomerName
        ' 
        dgvcCustomerName.HeaderText = "Customer Name"
        dgvcCustomerName.MinimumWidth = 6
        dgvcCustomerName.Name = "dgvcCustomerName"
        ' 
        ' dgvcProductID
        ' 
        dgvcProductID.HeaderText = "Product ID"
        dgvcProductID.Name = "dgvcProductID"
        ' 
        ' dgvcProductName
        ' 
        dgvcProductName.HeaderText = "Product Name"
        dgvcProductName.MinimumWidth = 6
        dgvcProductName.Name = "dgvcProductName"
        ' 
        ' dgvcQuantity
        ' 
        dgvcQuantity.HeaderText = "Quantity"
        dgvcQuantity.MinimumWidth = 6
        dgvcQuantity.Name = "dgvcQuantity"
        ' 
        ' dgvcDateOrdered
        ' 
        dgvcDateOrdered.HeaderText = "Date Ordered"
        dgvcDateOrdered.MinimumWidth = 6
        dgvcDateOrdered.Name = "dgvcDateOrdered"
        ' 
        ' dgvcStatus
        ' 
        dgvcStatus.HeaderText = "Status"
        dgvcStatus.MinimumWidth = 6
        dgvcStatus.Name = "dgvcStatus"
        ' 
        ' tbSearch
        ' 
        tbSearch.CustomizableEdges = CustomizableEdges5
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Location = New Point(276, 53)
        tbSearch.Margin = New Padding(3, 2, 3, 2)
        tbSearch.Name = "tbSearch"
        tbSearch.PasswordChar = ChrW(0)
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbSearch.Size = New Size(144, 28)
        tbSearch.TabIndex = 9
        ' 
        ' tbCustomerName
        ' 
        tbCustomerName.AcceptsTab = True
        tbCustomerName.Anchor = AnchorStyles.Left
        tbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbCustomerName.CustomizableEdges = CustomizableEdges7
        tbCustomerName.DefaultText = ""
        tbCustomerName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCustomerName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCustomerName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCustomerName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerName.Location = New Point(19, 100)
        tbCustomerName.Margin = New Padding(3, 2, 3, 2)
        tbCustomerName.MaxLength = 25
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.PasswordChar = ChrW(0)
        tbCustomerName.PlaceholderText = ""
        tbCustomerName.SelectedText = ""
        tbCustomerName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        tbCustomerName.Size = New Size(214, 27)
        tbCustomerName.TabIndex = 10
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.Anchor = AnchorStyles.Left
        lblCustomerName.AutoSize = True
        lblCustomerName.ForeColor = SystemColors.ActiveCaption
        lblCustomerName.Location = New Point(19, 83)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(97, 15)
        lblCustomerName.TabIndex = 7
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' tbProductName
        ' 
        tbProductName.AcceptsTab = True
        tbProductName.Anchor = AnchorStyles.Left
        tbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbProductName.CustomizableEdges = CustomizableEdges9
        tbProductName.DefaultText = ""
        tbProductName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductName.Location = New Point(19, 211)
        tbProductName.Margin = New Padding(3, 2, 3, 2)
        tbProductName.MaxLength = 10
        tbProductName.Name = "tbProductName"
        tbProductName.PasswordChar = ChrW(0)
        tbProductName.PlaceholderText = ""
        tbProductName.SelectedText = ""
        tbProductName.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        tbProductName.Size = New Size(214, 27)
        tbProductName.TabIndex = 10
        ' 
        ' lblProductName
        ' 
        lblProductName.Anchor = AnchorStyles.Left
        lblProductName.AutoSize = True
        lblProductName.ForeColor = SystemColors.ActiveCaption
        lblProductName.Location = New Point(19, 194)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(87, 15)
        lblProductName.TabIndex = 7
        lblProductName.Text = "Product Name:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Left
        lblQuantity.AutoSize = True
        lblQuantity.ForeColor = SystemColors.ActiveCaption
        lblQuantity.Location = New Point(19, 304)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(56, 15)
        lblQuantity.TabIndex = 7
        lblQuantity.Text = "Quantity:"
        ' 
        ' tbQuantity
        ' 
        tbQuantity.Anchor = AnchorStyles.Left
        tbQuantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbQuantity.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbQuantity.CustomizableEdges = CustomizableEdges11
        tbQuantity.DefaultText = ""
        tbQuantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbQuantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantity.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbQuantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantity.Location = New Point(19, 321)
        tbQuantity.Margin = New Padding(3, 2, 3, 2)
        tbQuantity.MaxLength = 10
        tbQuantity.Name = "tbQuantity"
        tbQuantity.PasswordChar = ChrW(0)
        tbQuantity.PlaceholderText = ""
        tbQuantity.SelectedText = ""
        tbQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        tbQuantity.Size = New Size(214, 27)
        tbQuantity.TabIndex = 10
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Left
        btnSave.CustomizableEdges = CustomizableEdges13
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Transparent
        btnSave.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.GradientMode = Drawing2D.LinearGradientMode.Vertical
        btnSave.Location = New Point(51, 364)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnSave.Size = New Size(149, 45)
        btnSave.TabIndex = 11
        btnSave.Text = "Add"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.ForeColor = SystemColors.ActiveCaption
        lblSearch.Location = New Point(276, 36)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(45, 15)
        lblSearch.TabIndex = 7
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
        btnExport.Location = New Point(276, 383)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnExport.Size = New Size(79, 26)
        btnExport.TabIndex = 11
        btnExport.Text = "Export"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.Anchor = AnchorStyles.Left
        lblCustomerID.AutoSize = True
        lblCustomerID.ForeColor = SystemColors.ActiveCaption
        lblCustomerID.Location = New Point(19, 135)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(76, 15)
        lblCustomerID.TabIndex = 12
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' lblProductID
        ' 
        lblProductID.Anchor = AnchorStyles.Left
        lblProductID.AutoSize = True
        lblProductID.ForeColor = SystemColors.ActiveCaption
        lblProductID.Location = New Point(19, 247)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(66, 15)
        lblProductID.TabIndex = 14
        lblProductID.Text = "Product ID:"
        ' 
        ' lbOrderID
        ' 
        lbOrderID.Anchor = AnchorStyles.Left
        lbOrderID.AutoSize = True
        lbOrderID.ForeColor = SystemColors.ActiveCaption
        lbOrderID.Location = New Point(19, 53)
        lbOrderID.Name = "lbOrderID"
        lbOrderID.Size = New Size(0, 15)
        lbOrderID.TabIndex = 16
        ' 
        ' cmbProductID
        ' 
        cmbProductID.Anchor = AnchorStyles.Left
        cmbProductID.BackColor = Color.Transparent
        cmbProductID.CustomizableEdges = CustomizableEdges17
        cmbProductID.DrawMode = DrawMode.OwnerDrawFixed
        cmbProductID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductID.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbProductID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbProductID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cmbProductID.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbProductID.ItemHeight = 30
        cmbProductID.Location = New Point(19, 265)
        cmbProductID.Name = "cmbProductID"
        cmbProductID.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        cmbProductID.Size = New Size(214, 36)
        cmbProductID.TabIndex = 17
        ' 
        ' cmbCustomerId
        ' 
        cmbCustomerId.Anchor = AnchorStyles.Left
        cmbCustomerId.BackColor = Color.Transparent
        cmbCustomerId.CustomizableEdges = CustomizableEdges19
        cmbCustomerId.DrawMode = DrawMode.OwnerDrawFixed
        cmbCustomerId.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCustomerId.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCustomerId.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCustomerId.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCustomerId.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbCustomerId.ItemHeight = 30
        cmbCustomerId.Location = New Point(19, 153)
        cmbCustomerId.Name = "cmbCustomerId"
        cmbCustomerId.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        cmbCustomerId.Size = New Size(214, 36)
        cmbCustomerId.TabIndex = 18
        ' 
        ' frmOrderManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmbCustomerId)
        Controls.Add(cmbProductID)
        Controls.Add(lbOrderID)
        Controls.Add(lblProductID)
        Controls.Add(lblCustomerID)
        Controls.Add(btnExport)
        Controls.Add(btnSave)
        Controls.Add(tbQuantity)
        Controls.Add(tbProductName)
        Controls.Add(tbCustomerName)
        Controls.Add(tbSearch)
        Controls.Add(lblQuantity)
        Controls.Add(lblProductName)
        Controls.Add(lblCustomerName)
        Controls.Add(lblSearch)
        Controls.Add(dgvOrderManagement)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Name = "frmOrderManagement"
        Text = "Order Management"
        CType(dgvOrderManagement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvOrderMannagement As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblOrderID As Label
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGenerateID As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bntSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvcOrderID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDateofOrdered As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStatus As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvcDateOrdered As DataGridViewTextBoxColumn
    Friend WithEvents dgvOrderManagement As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProductID As DataGridViewTextBoxColumn
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbOrderID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents tbProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbOrderID As Label
    Friend WithEvents cmbProductID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbCustomerId As Guna.UI2.WinForms.Guna2ComboBox
End Class
