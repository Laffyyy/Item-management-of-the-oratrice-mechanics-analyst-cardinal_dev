<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAdjustment
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
        tbProductID = New Guna.UI2.WinForms.Guna2TextBox()
        tbProductQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        dgvstockad = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        cbProductName = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(dgvstockad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbProductID
        ' 
        tbProductID.Anchor = AnchorStyles.Right
        tbProductID.CustomizableEdges = CustomizableEdges1
        tbProductID.DefaultText = ""
        tbProductID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Location = New Point(472, 148)
        tbProductID.Name = "tbProductID"
        tbProductID.PasswordChar = ChrW(0)
        tbProductID.PlaceholderText = ""
        tbProductID.SelectedText = ""
        tbProductID.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        tbProductID.Size = New Size(200, 36)
        tbProductID.TabIndex = 1
        ' 
        ' tbProductQuantity
        ' 
        tbProductQuantity.Anchor = AnchorStyles.Right
        tbProductQuantity.CustomizableEdges = CustomizableEdges3
        tbProductQuantity.DefaultText = ""
        tbProductQuantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductQuantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductQuantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductQuantity.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductQuantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductQuantity.Location = New Point(472, 228)
        tbProductQuantity.Name = "tbProductQuantity"
        tbProductQuantity.PasswordChar = ChrW(0)
        tbProductQuantity.PlaceholderText = ""
        tbProductQuantity.SelectedText = ""
        tbProductQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbProductQuantity.Size = New Size(200, 36)
        tbProductQuantity.TabIndex = 1
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvstockad.DefaultCellStyle = DataGridViewCellStyle3
        dgvstockad.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.Location = New Point(42, 44)
        dgvstockad.Name = "dgvstockad"
        dgvstockad.RowHeadersVisible = False
        dgvstockad.RowTemplate.Height = 25
        dgvstockad.Size = New Size(317, 311)
        dgvstockad.TabIndex = 2
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
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges5
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.Transparent
        Guna2GradientButton1.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.GradientMode = Drawing2D.LinearGradientMode.Vertical
        Guna2GradientButton1.Location = New Point(482, 310)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientButton1.Size = New Size(180, 45)
        Guna2GradientButton1.TabIndex = 3
        Guna2GradientButton1.Text = "Save"
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
        cbProductName.Location = New Point(472, 65)
        cbProductName.Name = "cbProductName"
        cbProductName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cbProductName.Size = New Size(200, 36)
        cbProductName.TabIndex = 4
        ' 
        ' frmStockAdjustment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbProductName)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(dgvstockad)
        Controls.Add(tbProductQuantity)
        Controls.Add(tbProductID)
        Name = "frmStockAdjustment"
        Text = "Stock Adjustment"
        CType(dgvstockad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvstockad As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents DateofRestock As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbProductID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbProductQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbProductName As Guna.UI2.WinForms.Guna2ComboBox
End Class
