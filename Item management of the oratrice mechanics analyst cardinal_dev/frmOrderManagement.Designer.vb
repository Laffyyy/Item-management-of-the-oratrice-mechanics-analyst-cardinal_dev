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
        btnNeworders = New Guna.UI2.WinForms.Guna2GradientButton()
        btnMore = New Guna.UI2.WinForms.Guna2GradientButton()
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvOrderMannagement = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcCustomerName = New DataGridViewTextBoxColumn()
        lblOrderID = New Label()
        lblShippingDate = New Label()
        DtpShipping = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        btnNeworders.Location = New Point(671, 32)
        btnNeworders.Name = "btnNeworders"
        btnNeworders.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNeworders.Size = New Size(85, 34)
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
        btnMore.Location = New Point(716, 370)
        btnMore.Name = "btnMore"
        btnMore.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnMore.Size = New Size(40, 30)
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
        btnDelete.Location = New Point(150, 32)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnDelete.Size = New Size(67, 34)
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
        btnEdit.Location = New Point(64, 32)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnEdit.Size = New Size(69, 34)
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
        dgvOrderMannagement.Columns.AddRange(New DataGridViewColumn() {dgvcCustomerName})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrderMannagement.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrderMannagement.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannagement.Location = New Point(64, 70)
        dgvOrderMannagement.Name = "dgvOrderMannagement"
        dgvOrderMannagement.RowHeadersVisible = False
        dgvOrderMannagement.RowTemplate.Height = 25
        dgvOrderMannagement.Size = New Size(692, 291)
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
        dgvcCustomerName.Name = "dgvcCustomerName"
        ' 
        ' lblOrderID
        ' 
        lblOrderID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblOrderID.AutoSize = True
        lblOrderID.ForeColor = SystemColors.ActiveCaption
        lblOrderID.Location = New Point(64, 370)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(51, 15)
        lblOrderID.TabIndex = 7
        lblOrderID.Text = "Order ID"
        ' 
        ' lblShippingDate
        ' 
        lblShippingDate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblShippingDate.AutoSize = True
        lblShippingDate.ForeColor = SystemColors.ActiveCaption
        lblShippingDate.Location = New Point(214, 370)
        lblShippingDate.Name = "lblShippingDate"
        lblShippingDate.Size = New Size(78, 15)
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
        DtpShipping.Location = New Point(308, 370)
        DtpShipping.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        DtpShipping.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        DtpShipping.Name = "DtpShipping"
        DtpShipping.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        DtpShipping.Size = New Size(200, 36)
        DtpShipping.TabIndex = 8
        DtpShipping.Value = New Date(2023, 11, 29, 18, 46, 23, 186)
        ' 
        ' frmOrderManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DtpShipping)
        Controls.Add(lblShippingDate)
        Controls.Add(lblOrderID)
        Controls.Add(dgvOrderMannagement)
        Controls.Add(btnMore)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNeworders)
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
End Class
