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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tbProductQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        dgvstockad = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvcOrigin = New DataGridViewTextBoxColumn()
        dgvcStockID = New DataGridViewTextBoxColumn()
        dgvcProductName = New DataGridViewTextBoxColumn()
        dgvcProductID = New DataGridViewTextBoxColumn()
        dgvcDateOfChange = New DataGridViewTextBoxColumn()
        dgvcQuantity = New DataGridViewTextBoxColumn()
        dgvcChange = New DataGridViewTextBoxColumn()
        dgvcFinalQuantity = New DataGridViewTextBoxColumn()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        cbProductName = New Guna.UI2.WinForms.Guna2ComboBox()
        lblProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblProductID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Amountmodification = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        btnReplenish = New Guna.UI2.WinForms.Guna2GradientButton()
        tbProductID = New Guna.UI2.WinForms.Guna2TextBox()
        btnExport = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(dgvstockad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbProductQuantity
        ' 
        tbProductQuantity.Anchor = AnchorStyles.Left
        tbProductQuantity.CustomizableEdges = CustomizableEdges1
        tbProductQuantity.DefaultText = ""
        tbProductQuantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductQuantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductQuantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductQuantity.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductQuantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductQuantity.Location = New Point(32, 270)
        tbProductQuantity.Name = "tbProductQuantity"
        tbProductQuantity.PasswordChar = ChrW(0)
        tbProductQuantity.PlaceholderText = ""
        tbProductQuantity.SelectedText = ""
        tbProductQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        tbProductQuantity.Size = New Size(200, 28)
        tbProductQuantity.TabIndex = 1
        Amountmodification.SetToolTip(tbProductQuantity, "adding amount use a possitive Value" & vbCrLf & "removing amount use a (-)Negative Value")
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
        dgvstockad.ColumnHeadersHeight = 20
        dgvstockad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvstockad.Columns.AddRange(New DataGridViewColumn() {dgvcOrigin, dgvcStockID, dgvcProductName, dgvcProductID, dgvcDateOfChange, dgvcQuantity, dgvcChange, dgvcFinalQuantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvstockad.DefaultCellStyle = DataGridViewCellStyle3
        dgvstockad.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.Location = New Point(274, 44)
        dgvstockad.Name = "dgvstockad"
        dgvstockad.RowHeadersVisible = False
        dgvstockad.RowTemplate.Height = 25
        dgvstockad.Size = New Size(514, 311)
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
        dgvstockad.ThemeStyle.HeaderStyle.Height = 20
        dgvstockad.ThemeStyle.ReadOnly = False
        dgvstockad.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvstockad.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvstockad.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvstockad.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvstockad.ThemeStyle.RowsStyle.Height = 25
        dgvstockad.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvstockad.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvcOrigin
        ' 
        dgvcOrigin.HeaderText = "Origin"
        dgvcOrigin.Name = "dgvcOrigin"
        ' 
        ' dgvcStockID
        ' 
        dgvcStockID.HeaderText = "Stock ID"
        dgvcStockID.Name = "dgvcStockID"
        ' 
        ' dgvcProductName
        ' 
        dgvcProductName.HeaderText = "Product Name"
        dgvcProductName.Name = "dgvcProductName"
        ' 
        ' dgvcProductID
        ' 
        dgvcProductID.HeaderText = "Product ID"
        dgvcProductID.Name = "dgvcProductID"
        ' 
        ' dgvcDateOfChange
        ' 
        dgvcDateOfChange.HeaderText = "Date Of Change"
        dgvcDateOfChange.Name = "dgvcDateOfChange"
        ' 
        ' dgvcQuantity
        ' 
        dgvcQuantity.HeaderText = "Quantity"
        dgvcQuantity.Name = "dgvcQuantity"
        ' 
        ' dgvcChange
        ' 
        dgvcChange.HeaderText = "Change"
        dgvcChange.Name = "dgvcChange"
        ' 
        ' dgvcFinalQuantity
        ' 
        dgvcFinalQuantity.HeaderText = "Final Quantity"
        dgvcFinalQuantity.Name = "dgvcFinalQuantity"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Anchor = AnchorStyles.Left
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
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
        Guna2GradientButton1.Location = New Point(41, 352)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.Size = New Size(180, 45)
        Guna2GradientButton1.TabIndex = 3
        Guna2GradientButton1.Text = "Save"
        ' 
        ' cbProductName
        ' 
        cbProductName.Anchor = AnchorStyles.Left
        cbProductName.BackColor = Color.Transparent
        cbProductName.CustomizableEdges = CustomizableEdges5
        cbProductName.DrawMode = DrawMode.OwnerDrawFixed
        cbProductName.DropDownStyle = ComboBoxStyle.DropDownList
        cbProductName.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProductName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbProductName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbProductName.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbProductName.ItemHeight = 30
        cbProductName.Location = New Point(32, 65)
        cbProductName.Name = "cbProductName"
        cbProductName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        cbProductName.Size = New Size(200, 36)
        cbProductName.TabIndex = 4
        ' 
        ' lblProductName
        ' 
        lblProductName.Anchor = AnchorStyles.Left
        lblProductName.BackColor = Color.Transparent
        lblProductName.ForeColor = SystemColors.ActiveCaption
        lblProductName.Location = New Point(32, 44)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(83, 17)
        lblProductName.TabIndex = 5
        lblProductName.Text = "Product Name:"
        ' 
        ' lblProductID
        ' 
        lblProductID.Anchor = AnchorStyles.Left
        lblProductID.BackColor = Color.Transparent
        lblProductID.ForeColor = SystemColors.ActiveCaption
        lblProductID.Location = New Point(32, 125)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(62, 17)
        lblProductID.TabIndex = 5
        lblProductID.Text = "Product ID:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Left
        lblQuantity.BackColor = Color.Transparent
        lblQuantity.ForeColor = SystemColors.ActiveCaption
        lblQuantity.Location = New Point(31, 247)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(52, 17)
        lblQuantity.TabIndex = 5
        lblQuantity.Text = "Quantity: "
        ' 
        ' Amountmodification
        ' 
        Amountmodification.AllowLinksHandling = True
        Amountmodification.BackColor = SystemColors.ActiveCaption
        Amountmodification.ForeColor = Color.FromArgb(CByte(34), CByte(44), CByte(79))
        Amountmodification.MaximumSize = New Size(0, 0)
        Amountmodification.ToolTipTitle = "adding or removing"
        ' 
        ' btnReplenish
        ' 
        btnReplenish.Anchor = AnchorStyles.Left
        btnReplenish.CustomizableEdges = CustomizableEdges7
        btnReplenish.DisabledState.BorderColor = Color.DarkGray
        btnReplenish.DisabledState.CustomBorderColor = Color.DarkGray
        btnReplenish.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReplenish.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReplenish.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReplenish.FillColor2 = Color.Transparent
        btnReplenish.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReplenish.ForeColor = Color.White
        btnReplenish.GradientMode = Drawing2D.LinearGradientMode.Vertical
        btnReplenish.Location = New Point(90, 247)
        btnReplenish.Name = "btnReplenish"
        btnReplenish.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnReplenish.Size = New Size(142, 17)
        btnReplenish.TabIndex = 6
        btnReplenish.Text = "Replenish"
        ' 
        ' tbProductID
        ' 
        tbProductID.Anchor = AnchorStyles.Left
        tbProductID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbProductID.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbProductID.CustomizableEdges = CustomizableEdges9
        tbProductID.DefaultText = ""
        tbProductID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductID.Location = New Point(32, 147)
        tbProductID.Margin = New Padding(3, 2, 3, 2)
        tbProductID.Name = "tbProductID"
        tbProductID.PasswordChar = ChrW(0)
        tbProductID.PlaceholderText = ""
        tbProductID.SelectedText = ""
        tbProductID.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        tbProductID.Size = New Size(200, 27)
        tbProductID.TabIndex = 13
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExport.CustomizableEdges = CustomizableEdges11
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor2 = Color.Empty
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(274, 371)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnExport.Size = New Size(79, 26)
        btnExport.TabIndex = 14
        btnExport.Text = "Export"
        ' 
        ' frmStockAdjustment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExport)
        Controls.Add(tbProductID)
        Controls.Add(btnReplenish)
        Controls.Add(lblQuantity)
        Controls.Add(lblProductID)
        Controls.Add(lblProductName)
        Controls.Add(cbProductName)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(dgvstockad)
        Controls.Add(tbProductQuantity)
        Name = "frmStockAdjustment"
        Text = "Stock Adjustment"
        CType(dgvstockad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvstockad As Guna.UI2.WinForms.Guna2DataGridView
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents DateofRestock As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents tbProductQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbProductName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProductID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Amountmodification As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents btnReplenish As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvcModification As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProductName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDateOfChange As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvcChange As DataGridViewTextBoxColumn
    Friend WithEvents dgvcFinalQuantity As DataGridViewTextBoxColumn
    Friend WithEvents tbProductID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvcOrigin As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStockID As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProductID As DataGridViewTextBoxColumn
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2GradientButton
End Class
