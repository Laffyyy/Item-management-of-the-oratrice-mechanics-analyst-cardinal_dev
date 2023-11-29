<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        cbColum = New Guna.UI2.WinForms.Guna2ComboBox()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        btnSearch = New Guna.UI2.WinForms.Guna2GradientButton()
        dgvcCustomerFirstName = New DataGridViewTextBoxColumn()
        dgvcCustomerLastName = New DataGridViewTextBoxColumn()
        dgvcCompanyName = New DataGridViewTextBoxColumn()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbColum
        ' 
        cbColum.BackColor = Color.Transparent
        cbColum.CustomizableEdges = CustomizableEdges1
        cbColum.DrawMode = DrawMode.OwnerDrawFixed
        cbColum.DropDownStyle = ComboBoxStyle.DropDownList
        cbColum.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbColum.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbColum.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cbColum.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbColum.ItemHeight = 30
        cbColum.Location = New Point(34, 85)
        cbColum.Name = "cbColum"
        cbColum.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbColum.Size = New Size(140, 36)
        cbColum.TabIndex = 0
        ' 
        ' tbSearch
        ' 
        tbSearch.CustomizableEdges = CustomizableEdges3
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Location = New Point(191, 85)
        tbSearch.Name = "tbSearch"
        tbSearch.PasswordChar = ChrW(0)
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbSearch.Size = New Size(200, 36)
        tbSearch.TabIndex = 1
        ' 
        ' btnEdit
        ' 
        btnEdit.CustomizableEdges = CustomizableEdges5
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.FillColor = Color.Transparent
        btnEdit.FillColor2 = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(714, 85)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnEdit.Size = New Size(56, 36)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView1.Columns.AddRange(New DataGridViewColumn() {dgvcCustomerFirstName, dgvcCustomerLastName, dgvcCompanyName})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(34, 137)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowTemplate.Height = 25
        Guna2DataGridView1.Size = New Size(736, 282)
        Guna2DataGridView1.TabIndex = 4
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnSearch
        ' 
        btnSearch.CustomizableEdges = CustomizableEdges7
        btnSearch.DisabledState.BorderColor = Color.DarkGray
        btnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        btnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSearch.FillColor2 = Color.Transparent
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(409, 85)
        btnSearch.Name = "btnSearch"
        btnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnSearch.Size = New Size(66, 36)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        ' 
        ' dgvcCustomerFirstName
        ' 
        dgvcCustomerFirstName.HeaderText = "First Name"
        dgvcCustomerFirstName.Name = "dgvcCustomerFirstName"
        ' 
        ' dgvcCustomerLastName
        ' 
        dgvcCustomerLastName.HeaderText = "Last Name"
        dgvcCustomerLastName.Name = "dgvcCustomerLastName"
        ' 
        ' dgvcCompanyName
        ' 
        dgvcCompanyName.HeaderText = "Company Name"
        dgvcCompanyName.Name = "dgvcCompanyName"
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(btnSearch)
        Controls.Add(btnEdit)
        Controls.Add(tbSearch)
        Controls.Add(cbColum)
        Name = "frmCustomer"
        Text = "frmCustomer"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbColum As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvcCustomerFirstName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCustomerLastName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2GradientButton
End Class
