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
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvOrderManagement = New Guna.UI2.WinForms.Guna2DataGridView()
        lblOrderID = New Label()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        tbCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        btnGenerateID = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        lblCustomerName = New Label()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        lblProduct = New Label()
        lblQuantity = New Label()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        bntSave = New Guna.UI2.WinForms.Guna2GradientButton()
        lblSearch = New Label()
        dgvcOrderID = New DataGridViewTextBoxColumn()
        dgvcCustomerID = New DataGridViewTextBoxColumn()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        dgvcProductID = New DataGridViewTextBoxColumn()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcDateOrdered = New DataGridViewTextBoxColumn()
        dgvcStatus = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
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
        dgvOrderManagement.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
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
        dgvOrderManagement.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
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
        ' lblOrderID
        ' 
        lblOrderID.Anchor = AnchorStyles.Left
        lblOrderID.AutoSize = True
        lblOrderID.ForeColor = SystemColors.ActiveCaption
        lblOrderID.Location = New Point(28, 57)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(57, 15)
        lblOrderID.TabIndex = 7
        lblOrderID.Text = "Order ID :"
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
        tbCustomerName.Location = New Point(28, 74)
        tbCustomerName.Margin = New Padding(3, 2, 3, 2)
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.PasswordChar = ChrW(0)
        tbCustomerName.PlaceholderText = ""
        tbCustomerName.SelectedText = ""
        tbCustomerName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        tbCustomerName.Size = New Size(128, 27)
        tbCustomerName.TabIndex = 10
        ' 
        ' btnGenerateID
        ' 
        btnGenerateID.Anchor = AnchorStyles.Left
        btnGenerateID.CustomizableEdges = CustomizableEdges9
        btnGenerateID.DisabledState.BorderColor = Color.DarkGray
        btnGenerateID.DisabledState.CustomBorderColor = Color.DarkGray
        btnGenerateID.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGenerateID.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGenerateID.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnGenerateID.FillColor = Color.Transparent
        btnGenerateID.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnGenerateID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGenerateID.ForeColor = Color.White
        btnGenerateID.Location = New Point(162, 74)
        btnGenerateID.Name = "btnGenerateID"
        btnGenerateID.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnGenerateID.Size = New Size(80, 27)
        btnGenerateID.TabIndex = 1
        btnGenerateID.Text = "Generate"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.Anchor = AnchorStyles.Left
        Guna2TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Guna2TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TextBox1.CustomizableEdges = CustomizableEdges11
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(28, 129)
        Guna2TextBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2TextBox1.Size = New Size(214, 27)
        Guna2TextBox1.TabIndex = 10
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.Anchor = AnchorStyles.Left
        lblCustomerName.AutoSize = True
        lblCustomerName.ForeColor = SystemColors.ActiveCaption
        lblCustomerName.Location = New Point(28, 112)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(97, 15)
        lblCustomerName.TabIndex = 7
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.Anchor = AnchorStyles.Left
        Guna2TextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Guna2TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TextBox2.CustomizableEdges = CustomizableEdges13
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(28, 187)
        Guna2TextBox2.Margin = New Padding(3, 2, 3, 2)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox2.Size = New Size(214, 27)
        Guna2TextBox2.TabIndex = 10
        ' 
        ' lblProduct
        ' 
        lblProduct.Anchor = AnchorStyles.Left
        lblProduct.AutoSize = True
        lblProduct.ForeColor = SystemColors.ActiveCaption
        lblProduct.Location = New Point(28, 170)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(52, 15)
        lblProduct.TabIndex = 7
        lblProduct.Text = "Product:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Left
        lblQuantity.AutoSize = True
        lblQuantity.ForeColor = SystemColors.ActiveCaption
        lblQuantity.Location = New Point(28, 230)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(56, 15)
        lblQuantity.TabIndex = 7
        lblQuantity.Text = "Quantity:"
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.Anchor = AnchorStyles.Left
        Guna2TextBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Guna2TextBox3.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TextBox3.CustomizableEdges = CustomizableEdges15
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(28, 247)
        Guna2TextBox3.Margin = New Padding(3, 2, 3, 2)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2TextBox3.Size = New Size(214, 27)
        Guna2TextBox3.TabIndex = 10
        ' 
        ' bntSave
        ' 
        bntSave.Anchor = AnchorStyles.Left
        bntSave.CustomizableEdges = CustomizableEdges17
        bntSave.DisabledState.BorderColor = Color.DarkGray
        bntSave.DisabledState.CustomBorderColor = Color.DarkGray
        bntSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bntSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bntSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bntSave.FillColor = Color.Transparent
        bntSave.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        bntSave.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bntSave.ForeColor = Color.White
        bntSave.GradientMode = Drawing2D.LinearGradientMode.Vertical
        bntSave.Location = New Point(61, 311)
        bntSave.Name = "bntSave"
        bntSave.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        bntSave.Size = New Size(149, 45)
        bntSave.TabIndex = 11
        bntSave.Text = "Add"
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
        ' frmOrderManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bntSave)
        Controls.Add(Guna2TextBox3)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        Controls.Add(tbCustomerName)
        Controls.Add(tbSearch)
        Controls.Add(lblQuantity)
        Controls.Add(lblProduct)
        Controls.Add(lblCustomerName)
        Controls.Add(lblSearch)
        Controls.Add(lblOrderID)
        Controls.Add(dgvOrderManagement)
        Controls.Add(btnGenerateID)
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
End Class
