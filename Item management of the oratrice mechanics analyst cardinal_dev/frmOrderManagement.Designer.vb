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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnNeworders = New Guna.UI2.WinForms.Guna2GradientButton()
        btnMore = New Guna.UI2.WinForms.Guna2GradientButton()
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvstockad = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcDateofRestock = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        CType(dgvstockad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNeworders
        ' 
        btnNeworders.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNeworders.CustomizableEdges = CustomizableEdges17
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
        btnNeworders.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnNeworders.Size = New Size(85, 34)
        btnNeworders.TabIndex = 1
        btnNeworders.Text = "New order"
        ' 
        ' btnMore
        ' 
        btnMore.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnMore.CustomizableEdges = CustomizableEdges19
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
        btnMore.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnMore.Size = New Size(40, 30)
        btnMore.TabIndex = 2
        btnMore.Text = "..."
        ' 
        ' btnDelete
        ' 
        btnDelete.CustomizableEdges = CustomizableEdges21
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
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnDelete.Size = New Size(67, 34)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete Order"
        ' 
        ' btnEdit
        ' 
        btnEdit.CustomizableEdges = CustomizableEdges23
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
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        btnEdit.Size = New Size(69, 34)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Order"
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
        dgvstockad.Location = New Point(64, 72)
        dgvstockad.Name = "dgvstockad"
        dgvstockad.RowHeadersVisible = False
        dgvstockad.RowTemplate.Height = 25
        dgvstockad.Size = New Size(646, 311)
        dgvstockad.TabIndex = 3
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
        ' frmOrderManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvstockad)
        Controls.Add(btnMore)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNeworders)
        Name = "frmOrderManagement"
        Text = "Order Management"
        CType(dgvstockad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnNeworders As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMore As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvOrderMannage As DataGridView
    Friend WithEvents cProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvstockad As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDateofRestock As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
End Class
