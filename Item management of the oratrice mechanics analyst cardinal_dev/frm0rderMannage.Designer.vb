<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm0rderMannage
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvOrderMannage = New Guna.UI2.WinForms.Guna2DataGridView()
        ProductID = New DataGridViewTextBoxColumn()
        ProductName = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        btnNeworders = New Guna.UI2.WinForms.Guna2GradientButton()
        btnMore = New Guna.UI2.WinForms.Guna2GradientButton()
        Label1 = New Label()
        btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        pnlEditOrder = New Panel()
        CType(dgvOrderMannage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvOrderMannage
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvOrderMannage.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderMannage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvOrderMannage.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrderMannage.ColumnHeadersHeight = 17
        dgvOrderMannage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderMannage.Columns.AddRange(New DataGridViewColumn() {ProductID, ProductName, Price, Quantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrderMannage.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrderMannage.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannage.Location = New Point(192, 96)
        dgvOrderMannage.Margin = New Padding(3, 4, 3, 4)
        dgvOrderMannage.Name = "dgvOrderMannage"
        dgvOrderMannage.RowHeadersVisible = False
        dgvOrderMannage.RowHeadersWidth = 51
        dgvOrderMannage.RowTemplate.Height = 25
        dgvOrderMannage.Size = New Size(536, 377)
        dgvOrderMannage.TabIndex = 0
        dgvOrderMannage.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvOrderMannage.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvOrderMannage.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvOrderMannage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvOrderMannage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvOrderMannage.ThemeStyle.BackColor = Color.White
        dgvOrderMannage.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannage.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvOrderMannage.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrderMannage.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderMannage.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvOrderMannage.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvOrderMannage.ThemeStyle.HeaderStyle.Height = 17
        dgvOrderMannage.ThemeStyle.ReadOnly = False
        dgvOrderMannage.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvOrderMannage.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderMannage.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvOrderMannage.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvOrderMannage.ThemeStyle.RowsStyle.Height = 25
        dgvOrderMannage.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvOrderMannage.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ProductID
        ' 
        ProductID.HeaderText = "Product ID"
        ProductID.MinimumWidth = 6
        ProductID.Name = "ProductID"
        ' 
        ' ProductName
        ' 
        ProductName.HeaderText = "Product Name"
        ProductName.MinimumWidth = 6
        ProductName.Name = "ProductName"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.MinimumWidth = 6
        Quantity.Name = "Quantity"
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
        btnNeworders.Location = New Point(631, 43)
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
        btnMore.Location = New Point(682, 493)
        btnMore.Margin = New Padding(3, 4, 3, 4)
        btnMore.Name = "btnMore"
        btnMore.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnMore.Size = New Size(46, 40)
        btnMore.TabIndex = 2
        btnMore.Text = "..."
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(194, 568)
        Label1.Name = "Label1"
        Label1.Size = New Size(585, 20)
        Label1.TabIndex = 3
        Label1.Text = "probably ill just make new form for the new order buuttt how would the menu bar acts "
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
        btnDelete.Location = New Point(293, 43)
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
        btnEdit.Location = New Point(194, 43)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnEdit.Size = New Size(79, 45)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Order"
        ' 
        ' pnlEditOrder
        ' 
        pnlEditOrder.Dock = DockStyle.Left
        pnlEditOrder.Location = New Point(0, 0)
        pnlEditOrder.Name = "pnlEditOrder"
        pnlEditOrder.Size = New Size(186, 600)
        pnlEditOrder.TabIndex = 4
        ' 
        ' frm0rderMannage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(pnlEditOrder)
        Controls.Add(Label1)
        Controls.Add(btnMore)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNeworders)
        Controls.Add(dgvOrderMannage)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frm0rderMannage"
        Text = "Order Mannage"
        CType(dgvOrderMannage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvOrderMannage As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents btnNeworders As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMore As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlEditOrder As Panel
End Class
