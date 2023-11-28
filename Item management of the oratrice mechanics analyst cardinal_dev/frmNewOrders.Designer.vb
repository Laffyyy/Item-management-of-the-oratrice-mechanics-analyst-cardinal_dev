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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        cbCustomerName = New Guna.UI2.WinForms.Guna2ComboBox()
        tbQuantityOrdered = New Guna.UI2.WinForms.Guna2TextBox()
        btnSaveNewOrder = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvstockad = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcDateofRestock = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        cbProductName = New Guna.UI2.WinForms.Guna2ComboBox()
        tbProductID = New Guna.UI2.WinForms.Guna2TextBox()
        tbCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvstockad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbCustomerName
        ' 
        cbCustomerName.Anchor = AnchorStyles.Right
        cbCustomerName.BackColor = Color.Transparent
        cbCustomerName.CustomizableEdges = CustomizableEdges1
        cbCustomerName.DrawMode = DrawMode.OwnerDrawFixed
        cbCustomerName.DropDownStyle = ComboBoxStyle.DropDownList
        cbCustomerName.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbCustomerName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbCustomerName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbCustomerName.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbCustomerName.ItemHeight = 30
        cbCustomerName.Location = New Point(606, 21)
        cbCustomerName.Margin = New Padding(3, 2, 3, 2)
        cbCustomerName.Name = "cbCustomerName"
        cbCustomerName.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbCustomerName.Size = New Size(189, 36)
        cbCustomerName.TabIndex = 1
        ' 
        ' tbQuantityOrdered
        ' 
        tbQuantityOrdered.Anchor = AnchorStyles.Right
        tbQuantityOrdered.CustomizableEdges = CustomizableEdges3
        tbQuantityOrdered.DefaultText = ""
        tbQuantityOrdered.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbQuantityOrdered.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbQuantityOrdered.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantityOrdered.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbQuantityOrdered.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantityOrdered.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbQuantityOrdered.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbQuantityOrdered.Location = New Point(578, 215)
        tbQuantityOrdered.Margin = New Padding(3, 2, 3, 2)
        tbQuantityOrdered.Name = "tbQuantityOrdered"
        tbQuantityOrdered.PasswordChar = ChrW(0)
        tbQuantityOrdered.PlaceholderText = ""
        tbQuantityOrdered.SelectedText = ""
        tbQuantityOrdered.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbQuantityOrdered.Size = New Size(246, 28)
        tbQuantityOrdered.TabIndex = 2
        ' 
        ' btnSaveNewOrder
        ' 
        btnSaveNewOrder.Anchor = AnchorStyles.Right
        btnSaveNewOrder.CustomizableEdges = CustomizableEdges5
        btnSaveNewOrder.DisabledState.BorderColor = Color.DarkGray
        btnSaveNewOrder.DisabledState.CustomBorderColor = Color.DarkGray
        btnSaveNewOrder.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSaveNewOrder.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSaveNewOrder.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSaveNewOrder.FillColor = Color.Transparent
        btnSaveNewOrder.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnSaveNewOrder.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveNewOrder.ForeColor = Color.White
        btnSaveNewOrder.Location = New Point(598, 297)
        btnSaveNewOrder.Margin = New Padding(3, 2, 3, 2)
        btnSaveNewOrder.Name = "btnSaveNewOrder"
        btnSaveNewOrder.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSaveNewOrder.Size = New Size(197, 42)
        btnSaveNewOrder.TabIndex = 4
        btnSaveNewOrder.Text = "Save"
        ' 
        ' dgvstockad
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvstockad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvstockad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvstockad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvstockad.ColumnHeadersHeight = 17
        dgvstockad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvstockad.Columns.AddRange(New DataGridViewColumn() {dgvcProductName, dgvcDateofRestock, dgvcQuantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvstockad.DefaultCellStyle = DataGridViewCellStyle3
        dgvstockad.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.Location = New Point(0, -1)
        dgvstockad.Name = "dgvstockad"
        dgvstockad.RowHeadersVisible = False
        dgvstockad.RowTemplate.Height = 25
        dgvstockad.Size = New Size(513, 393)
        dgvstockad.TabIndex = 5
        dgvstockad.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvstockad.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvstockad.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvstockad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvstockad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvstockad.ThemeStyle.BackColor = Color.White
        dgvstockad.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvstockad.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvstockad.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvstockad.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvstockad.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvstockad.ThemeStyle.HeaderStyle.Height = 17
        dgvstockad.ThemeStyle.ReadOnly = False
        dgvstockad.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvstockad.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvstockad.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvstockad.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvstockad.ThemeStyle.RowsStyle.Height = 25
        dgvstockad.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcProductName
        ' 
        dgvcProductName.HeaderText = "Product Name"
        dgvcProductName.Name = "dgvcProductName"
        ' 
        ' dgvcDateofRestock
        ' 
        dgvcDateofRestock.HeaderText = "Date of Restock"
        dgvcDateofRestock.Name = "dgvcDateofRestock"
        ' 
        ' dgvcQuantity
        ' 
        dgvcQuantity.HeaderText = "Quantity"
        dgvcQuantity.Name = "dgvcQuantity"
        ' 
        ' cbProductName
        ' 
        cbProductName.Anchor = AnchorStyles.Right
        cbProductName.BackColor = Color.Transparent
        cbProductName.CustomizableEdges = CustomizableEdges7
        cbProductName.DrawMode = DrawMode.OwnerDrawFixed
        cbProductName.DropDownStyle = ComboBoxStyle.DropDownList
        cbProductName.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProductName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProductName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbProductName.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbProductName.ItemHeight = 30
        cbProductName.Location = New Point(606, 119)
        cbProductName.Margin = New Padding(3, 2, 3, 2)
        cbProductName.Name = "cbProductName"
        cbProductName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cbProductName.Size = New Size(189, 36)
        cbProductName.TabIndex = 6
        ' 
        ' tbProductID
        ' 
        tbProductID.Anchor = AnchorStyles.Right
        tbProductID.CustomizableEdges = CustomizableEdges9
        tbProductID.DefaultText = ""
        tbProductID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Location = New Point(578, 159)
        tbProductID.Margin = New Padding(3, 2, 3, 2)
        tbProductID.Name = "tbProductID"
        tbProductID.PasswordChar = ChrW(0)
        tbProductID.PlaceholderText = ""
        tbProductID.SelectedText = ""
        tbProductID.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        tbProductID.Size = New Size(246, 28)
        tbProductID.TabIndex = 7
        ' 
        ' tbCustomerID
        ' 
        tbCustomerID.Anchor = AnchorStyles.Right
        tbCustomerID.CustomizableEdges = CustomizableEdges11
        tbCustomerID.DefaultText = ""
        tbCustomerID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCustomerID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCustomerID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCustomerID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCustomerID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCustomerID.Location = New Point(578, 61)
        tbCustomerID.Margin = New Padding(3, 2, 3, 2)
        tbCustomerID.Name = "tbCustomerID"
        tbCustomerID.PasswordChar = ChrW(0)
        tbCustomerID.PlaceholderText = ""
        tbCustomerID.SelectedText = ""
        tbCustomerID.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        tbCustomerID.Size = New Size(246, 28)
        tbCustomerID.TabIndex = 8
        ' 
        ' frmNewOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 392)
        Controls.Add(tbCustomerID)
        Controls.Add(tbProductID)
        Controls.Add(cbProductName)
        Controls.Add(dgvstockad)
        Controls.Add(btnSaveNewOrder)
        Controls.Add(tbQuantityOrdered)
        Controls.Add(cbCustomerName)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmNewOrders"
        Text = "New Orders"
        CType(dgvstockad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbCustomerName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbQuantityOrdered As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents cQuantity As DataGridViewTextBoxColumn
    Friend WithEvents cProductName As DataGridViewTextBoxColumn
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvstockad As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDateofRestock As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents cbProductName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbProductID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCustomerID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveNewOrder As Guna.UI2.WinForms.Guna2GradientButton
End Class
