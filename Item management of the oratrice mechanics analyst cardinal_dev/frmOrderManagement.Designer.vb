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
        dgvOrderMannagement = New Guna.UI2.WinForms.Guna2DataGridView()
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
        ComboBox1 = New ComboBox()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvcOrderID = New DataGridViewTextBoxColumn()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcDateofOrdered = New DataGridViewTextBoxColumn()
        dgvcStatus = New DataGridViewTextBoxColumn()
        CType(dgvOrderMannagement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Right
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
        btnEdit.Anchor = AnchorStyles.Right
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
        btnEdit.Location = New Point(668, 59)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEdit.Size = New Size(87, 23)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Order"
        ' 
        ' dgvOrderMannagement
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvOrderMannagement.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderMannagement.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvOrderMannagement.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrderMannagement.ColumnHeadersHeight = 40
        dgvOrderMannagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderMannagement.Columns.AddRange(New DataGridViewColumn() {dgvcOrderID, dgvcCustomerName, dgvcProductName, dgvcQuantity, dgvcDateofOrdered, dgvcStatus})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrderMannagement.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrderMannagement.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.Location = New Point(276, 86)
        dgvOrderMannagement.Name = "dgvOrderMannagement"
        dgvOrderMannagement.RowHeadersVisible = False
        dgvOrderMannagement.RowHeadersWidth = 51
        dgvOrderMannagement.RowTemplate.Height = 25
        dgvOrderMannagement.Size = New Size(479, 291)
        dgvOrderMannagement.TabIndex = 6
        dgvOrderMannagement.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvOrderMannagement.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvOrderMannagement.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvOrderMannagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvOrderMannagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvOrderMannagement.ThemeStyle.BackColor = Color.White
        dgvOrderMannagement.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvOrderMannagement.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrderMannagement.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderMannagement.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvOrderMannagement.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderMannagement.ThemeStyle.HeaderStyle.Height = 40
        dgvOrderMannagement.ThemeStyle.ReadOnly = False
        dgvOrderMannagement.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvOrderMannagement.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderMannagement.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderMannagement.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvOrderMannagement.ThemeStyle.RowsStyle.Height = 25
        dgvOrderMannagement.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblOrderID
        ' 
        lblOrderID.Anchor = AnchorStyles.Left
        lblOrderID.AutoSize = True
        lblOrderID.ForeColor = SystemColors.ActiveCaption
        lblOrderID.Location = New Point(24, 32)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(51, 15)
        lblOrderID.TabIndex = 7
        lblOrderID.Text = "Order ID"
        ' 
        ' tbSearch
        ' 
        tbSearch.Anchor = AnchorStyles.Right
        tbSearch.CustomizableEdges = CustomizableEdges5
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Location = New Point(276, 59)
        tbSearch.Margin = New Padding(3, 2, 3, 2)
        tbSearch.Name = "tbSearch"
        tbSearch.PasswordChar = ChrW(0)
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbSearch.Size = New Size(129, 23)
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
        tbCustomerName.Location = New Point(24, 49)
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
        btnGenerateID.Location = New Point(158, 49)
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
        Guna2TextBox1.Location = New Point(24, 104)
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
        lblCustomerName.Location = New Point(24, 87)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(94, 15)
        lblCustomerName.TabIndex = 7
        lblCustomerName.Text = "Customer Name"
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
        Guna2TextBox2.Location = New Point(24, 162)
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
        lblProduct.Location = New Point(24, 145)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(49, 15)
        lblProduct.TabIndex = 7
        lblProduct.Text = "Product"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Left
        lblQuantity.AutoSize = True
        lblQuantity.ForeColor = SystemColors.ActiveCaption
        lblQuantity.Location = New Point(24, 205)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 7
        lblQuantity.Text = "Quantity"
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
        Guna2TextBox3.Location = New Point(24, 222)
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
        bntSave.Location = New Point(57, 286)
        bntSave.Name = "bntSave"
        bntSave.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        bntSave.Size = New Size(149, 45)
        bntSave.TabIndex = 11
        bntSave.Text = "Save"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(411, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(92, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Anchor = AnchorStyles.Left
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges19
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor2 = Color.Empty
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(509, 59)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2GradientButton1.Size = New Size(80, 23)
        Guna2GradientButton1.TabIndex = 1
        Guna2GradientButton1.Text = "Generate"
        ' 
        ' dgvcOrderID
        ' 
        dgvcOrderID.HeaderText = "Order ID"
        dgvcOrderID.Name = "dgvcOrderID"
        ' 
        ' dgvcCustomerName
        ' 
        dgvcCustomerName.HeaderText = "Customer Name"
        dgvcCustomerName.MinimumWidth = 6
        dgvcCustomerName.Name = "dgvcCustomerName"
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
        ' dgvcDateofOrdered
        ' 
        dgvcDateofOrdered.HeaderText = "Date of Ordered"
        dgvcDateofOrdered.MinimumWidth = 6
        dgvcDateofOrdered.Name = "dgvcDateofOrdered"
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
        Controls.Add(ComboBox1)
        Controls.Add(bntSave)
        Controls.Add(Guna2TextBox3)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        Controls.Add(tbCustomerName)
        Controls.Add(tbSearch)
        Controls.Add(lblQuantity)
        Controls.Add(lblProduct)
        Controls.Add(lblCustomerName)
        Controls.Add(lblOrderID)
        Controls.Add(dgvOrderMannagement)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(btnGenerateID)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Name = "frmOrderManagement"
        Text = "Order Mannage"
        CType(dgvOrderMannagement, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
