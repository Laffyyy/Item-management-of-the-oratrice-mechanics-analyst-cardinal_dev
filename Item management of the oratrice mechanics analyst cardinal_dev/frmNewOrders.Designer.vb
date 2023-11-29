<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrders
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
        bttnOrder = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvNewOrders = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        dgvcProduct = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcShippingDate = New DataGridViewTextBoxColumn()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        tbCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        checkbunknow = New Guna.UI2.WinForms.Guna2CheckBox()
        tbQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        lblCustomerName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblProduct = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cbProduct = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(dgvNewOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bttnOrder
        ' 
        bttnOrder.Anchor = AnchorStyles.Right
        bttnOrder.CustomizableEdges = CustomizableEdges1
        bttnOrder.DisabledState.BorderColor = Color.DarkGray
        bttnOrder.DisabledState.CustomBorderColor = Color.DarkGray
        bttnOrder.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bttnOrder.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bttnOrder.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bttnOrder.FillColor = Color.Transparent
        bttnOrder.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        bttnOrder.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bttnOrder.ForeColor = Color.White
        bttnOrder.GradientMode = Drawing2D.LinearGradientMode.Vertical
        bttnOrder.Location = New Point(598, 313)
        bttnOrder.Margin = New Padding(3, 2, 3, 2)
        bttnOrder.Name = "bttnOrder"
        bttnOrder.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        bttnOrder.Size = New Size(197, 42)
        bttnOrder.TabIndex = 4
        bttnOrder.Text = "Order"
        bttnOrder.TextFormatNoPrefix = True
        ' 
        ' dgvNewOrders
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvNewOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvNewOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvNewOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvNewOrders.ColumnHeadersHeight = 20
        dgvNewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvNewOrders.Columns.AddRange(New DataGridViewColumn() {dgvcCustomerName, dgvcProduct, dgvcQuantity, dgvcShippingDate})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvNewOrders.DefaultCellStyle = DataGridViewCellStyle3
        dgvNewOrders.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvNewOrders.Location = New Point(12, 12)
        dgvNewOrders.Name = "dgvNewOrders"
        dgvNewOrders.RowHeadersVisible = False
        dgvNewOrders.RowTemplate.Height = 25
        dgvNewOrders.Size = New Size(537, 368)
        dgvNewOrders.TabIndex = 5
        dgvNewOrders.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvNewOrders.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvNewOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvNewOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvNewOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvNewOrders.ThemeStyle.BackColor = Color.White
        dgvNewOrders.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvNewOrders.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvNewOrders.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvNewOrders.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvNewOrders.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvNewOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvNewOrders.ThemeStyle.HeaderStyle.Height = 20
        dgvNewOrders.ThemeStyle.ReadOnly = False
        dgvNewOrders.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvNewOrders.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvNewOrders.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvNewOrders.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvNewOrders.ThemeStyle.RowsStyle.Height = 25
        dgvNewOrders.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvNewOrders.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcCustomerName
        ' 
        dgvcCustomerName.HeaderText = "Customer Name"
        dgvcCustomerName.Name = "dgvcCustomerName"
        ' 
        ' dgvcProduct
        ' 
        dgvcProduct.HeaderText = "Product"
        dgvcProduct.Name = "dgvcProduct"
        ' 
        ' dgvcQuantity
        ' 
        dgvcQuantity.HeaderText = "Quantity"
        dgvcQuantity.Name = "dgvcQuantity"
        ' 
        ' dgvcShippingDate
        ' 
        dgvcShippingDate.HeaderText = "Shipping Date"
        dgvcShippingDate.Name = "dgvcShippingDate"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.Anchor = AnchorStyles.Right
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges3
        Guna2DateTimePicker1.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(598, 258)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2DateTimePicker1.Size = New Size(200, 36)
        Guna2DateTimePicker1.TabIndex = 6
        Guna2DateTimePicker1.Value = New Date(2023, 11, 29, 19, 35, 1, 299)
        ' 
        ' tbCustomerName
        ' 
        tbCustomerName.Anchor = AnchorStyles.Right
        tbCustomerName.CustomizableEdges = CustomizableEdges5
        tbCustomerName.DefaultText = ""
        tbCustomerName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCustomerName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCustomerName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCustomerName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerName.Location = New Point(598, 43)
        tbCustomerName.Margin = New Padding(3, 2, 3, 2)
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.PasswordChar = ChrW(0)
        tbCustomerName.PlaceholderText = ""
        tbCustomerName.SelectedText = ""
        tbCustomerName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbCustomerName.Size = New Size(200, 32)
        tbCustomerName.TabIndex = 2
        ' 
        ' checkbunknow
        ' 
        checkbunknow.Anchor = AnchorStyles.Right
        checkbunknow.AutoSize = True
        checkbunknow.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        checkbunknow.CheckedState.BorderRadius = 0
        checkbunknow.CheckedState.BorderThickness = 0
        checkbunknow.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        checkbunknow.ForeColor = SystemColors.ActiveCaption
        checkbunknow.Location = New Point(598, 233)
        checkbunknow.Name = "checkbunknow"
        checkbunknow.Size = New Size(89, 19)
        checkbunknow.TabIndex = 7
        checkbunknow.Text = "i dont know"
        checkbunknow.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        checkbunknow.UncheckedState.BorderRadius = 0
        checkbunknow.UncheckedState.BorderThickness = 0
        checkbunknow.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' tbQuantity
        ' 
        tbQuantity.Anchor = AnchorStyles.Right
        tbQuantity.CustomizableEdges = CustomizableEdges7
        tbQuantity.DefaultText = ""
        tbQuantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbQuantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantity.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbQuantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantity.Location = New Point(598, 163)
        tbQuantity.Margin = New Padding(3, 2, 3, 2)
        tbQuantity.Name = "tbQuantity"
        tbQuantity.PasswordChar = ChrW(0)
        tbQuantity.PlaceholderText = ""
        tbQuantity.SelectedText = ""
        tbQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        tbQuantity.Size = New Size(200, 32)
        tbQuantity.TabIndex = 2
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.Anchor = AnchorStyles.Right
        lblCustomerName.BackColor = Color.Transparent
        lblCustomerName.ForeColor = SystemColors.ActiveCaption
        lblCustomerName.Location = New Point(598, 21)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(90, 17)
        lblCustomerName.TabIndex = 8
        lblCustomerName.Text = "Customer Name"
        ' 
        ' lblProduct
        ' 
        lblProduct.Anchor = AnchorStyles.Right
        lblProduct.BackColor = Color.Transparent
        lblProduct.ForeColor = SystemColors.ActiveCaption
        lblProduct.Location = New Point(598, 82)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(45, 17)
        lblProduct.TabIndex = 8
        lblProduct.Text = "Product"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Right
        lblQuantity.BackColor = Color.Transparent
        lblQuantity.ForeColor = SystemColors.ActiveCaption
        lblQuantity.Location = New Point(595, 141)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(49, 17)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "Quantity"
        ' 
        ' cbProduct
        ' 
        cbProduct.Anchor = AnchorStyles.Right
        cbProduct.BackColor = Color.Transparent
        cbProduct.CustomizableEdges = CustomizableEdges9
        cbProduct.DrawMode = DrawMode.OwnerDrawFixed
        cbProduct.DropDownStyle = ComboBoxStyle.DropDownList
        cbProduct.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProduct.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProduct.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbProduct.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbProduct.ItemHeight = 30
        cbProduct.Location = New Point(598, 105)
        cbProduct.Name = "cbProduct"
        cbProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        cbProduct.Size = New Size(200, 36)
        cbProduct.TabIndex = 9
        ' 
        ' frmNewOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 392)
        Controls.Add(cbProduct)
        Controls.Add(lblQuantity)
        Controls.Add(lblProduct)
        Controls.Add(lblCustomerName)
        Controls.Add(checkbunknow)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(dgvNewOrders)
        Controls.Add(bttnOrder)
        Controls.Add(tbQuantity)
        Controls.Add(tbCustomerName)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmNewOrders"
        Text = "New Orders"
        CType(dgvNewOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents bttnOrder As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvNewOrders As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProduct As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvcShippingDate As DataGridViewTextBoxColumn
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tbCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents checkbunknow As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents tbQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCustomerName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProduct As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbProduct As Guna.UI2.WinForms.Guna2ComboBox
End Class
