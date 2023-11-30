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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnNeworders = New Guna.UI2.WinForms.Guna2GradientButton()
        btnMore = New Guna.UI2.WinForms.Guna2GradientButton()
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvOrderMannagement = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        lblOrderID = New Label()
        lblShippingDate = New Label()
        DtpShipping = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcDateofOrdered = New DataGridViewTextBoxColumn()
        dgvcShippingdate = New DataGridViewTextBoxColumn()
        dgvcStatus = New DataGridViewTextBoxColumn()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvOrderMannagement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNeworders
        ' 
        btnNeworders.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNeworders.CustomizableEdges = CustomizableEdges1
        btnNeworders.DisabledState.BorderColor = Color.DarkGray
        btnNeworders.DisabledState.CustomBorderColor = Color.DarkGray
        btnNeworders.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNeworders.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNeworders.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNeworders.FillColor = Color.Transparent
        btnNeworders.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnNeworders.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNeworders.ForeColor = Color.White
        btnNeworders.Location = New Point(767, 43)
        btnNeworders.Margin = New Padding(3, 4, 3, 4)
        btnNeworders.Name = "btnNeworders"
        btnNeworders.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNeworders.Size = New Size(97, 45)
        btnNeworders.TabIndex = 1
        btnNeworders.Text = "New order"
        ' 
        ' btnMore
        ' 
        btnMore.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnMore.CustomizableEdges = CustomizableEdges3
        btnMore.DisabledState.BorderColor = Color.DarkGray
        btnMore.DisabledState.CustomBorderColor = Color.DarkGray
        btnMore.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMore.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMore.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnMore.FillColor = Color.Transparent
        btnMore.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnMore.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnMore.ForeColor = Color.White
        btnMore.Location = New Point(818, 493)
        btnMore.Margin = New Padding(3, 4, 3, 4)
        btnMore.Name = "btnMore"
        btnMore.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnMore.Size = New Size(46, 40)
        btnMore.TabIndex = 2
        btnMore.Text = "..."
        ' 
        ' btnDelete
        ' 
        btnDelete.CustomizableEdges = CustomizableEdges5
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.FillColor2 = Color.FromArgb(CByte(255), CByte(249), CByte(144))
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(399, 43)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnDelete.Size = New Size(77, 45)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete Order"
        ' 
        ' btnEdit
        ' 
        btnEdit.CustomizableEdges = CustomizableEdges7
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor2 = Color.Transparent
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(301, 43)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnEdit.Size = New Size(79, 45)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Order"
        ' 
        ' dgvOrderMannagement
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvOrderMannagement.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderMannagement.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvOrderMannagement.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrderMannagement.ColumnHeadersHeight = 20
        dgvOrderMannagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderMannagement.Columns.AddRange(New DataGridViewColumn() {dgvcCustomerName, dgvcProductName, dgvcQuantity, dgvcDateofOrdered, dgvcShippingdate, dgvcStatus})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrderMannagement.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrderMannagement.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.Location = New Point(73, 93)
        dgvOrderMannagement.Margin = New Padding(3, 4, 3, 4)
        dgvOrderMannagement.Name = "dgvOrderMannagement"
        dgvOrderMannagement.RowHeadersVisible = False
        dgvOrderMannagement.RowHeadersWidth = 51
        dgvOrderMannagement.RowTemplate.Height = 25
        dgvOrderMannagement.Size = New Size(791, 388)
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
        dgvOrderMannagement.ThemeStyle.HeaderStyle.Height = 20
        dgvOrderMannagement.ThemeStyle.ReadOnly = False
        dgvOrderMannagement.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvOrderMannagement.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderMannagement.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderMannagement.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvOrderMannagement.ThemeStyle.RowsStyle.Height = 25
        dgvOrderMannagement.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcCustomerName
        ' 
        dgvcCustomerName.HeaderText = "Customer Name"
        dgvcCustomerName.MinimumWidth = 6
        dgvcCustomerName.Name = "dgvcCustomerName"
        ' 
        ' lblOrderID
        ' 
        lblOrderID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblOrderID.AutoSize = True
        lblOrderID.ForeColor = SystemColors.ActiveCaption
        lblOrderID.Location = New Point(73, 493)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(66, 20)
        lblOrderID.TabIndex = 7
        lblOrderID.Text = "Order ID"
        ' 
        ' lblShippingDate
        ' 
        lblShippingDate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblShippingDate.AutoSize = True
        lblShippingDate.ForeColor = SystemColors.ActiveCaption
        lblShippingDate.Location = New Point(245, 493)
        lblShippingDate.Name = "lblShippingDate"
        lblShippingDate.Size = New Size(100, 20)
        lblShippingDate.TabIndex = 7
        lblShippingDate.Text = "ShippingDate"
        ' 
        ' DtpShipping
        ' 
        DtpShipping.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        DtpShipping.Checked = True
        DtpShipping.CustomizableEdges = CustomizableEdges9
        DtpShipping.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        DtpShipping.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DtpShipping.Format = DateTimePickerFormat.Long
        DtpShipping.Location = New Point(352, 493)
        DtpShipping.Margin = New Padding(3, 4, 3, 4)
        DtpShipping.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        DtpShipping.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        DtpShipping.Name = "DtpShipping"
        DtpShipping.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        DtpShipping.Size = New Size(229, 48)
        DtpShipping.TabIndex = 8
        DtpShipping.Value = New Date(2023, 11, 29, 18, 46, 23, 186)
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
        ' dgvcShippingdate
        ' 
        dgvcShippingdate.HeaderText = "Shipping Date"
        dgvcShippingdate.MinimumWidth = 6
        dgvcShippingdate.Name = "dgvcShippingdate"
        ' 
        ' dgvcStatus
        ' 
        dgvcStatus.HeaderText = "Status"
        dgvcStatus.MinimumWidth = 6
        dgvcStatus.Name = "dgvcStatus"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.Anchor = AnchorStyles.Left
        Guna2TextBox1.CustomizableEdges = CustomizableEdges11
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(73, 43)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2TextBox1.Size = New Size(222, 45)
        Guna2TextBox1.TabIndex = 9
        ' 
        ' frmOrderManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Guna2TextBox1)
        Controls.Add(DtpShipping)
        Controls.Add(lblShippingDate)
        Controls.Add(lblOrderID)
        Controls.Add(dgvOrderMannagement)
        Controls.Add(btnMore)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNeworders)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmOrderManagement"
        Text = "Order Mannage"
        CType(dgvOrderMannagement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNeworders As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMore As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvOrderMannagement As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblShippingDate As Label
    Friend WithEvents DtpShipping As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dgvcProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDateofOrdered As DataGridViewTextBoxColumn
    Friend WithEvents dgvcShippingdate As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStatus As DataGridViewTextBoxColumn
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
