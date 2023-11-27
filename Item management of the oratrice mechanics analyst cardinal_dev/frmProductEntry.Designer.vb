<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductEntry
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
        lbltestentry = New Label()
        lblProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblProductPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lnlPanel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tbProductNameEntry = New Guna.UI2.WinForms.Guna2TextBox()
        tbProductPriceEntry = New Guna.UI2.WinForms.Guna2TextBox()
        tbProductDescriptionEntry = New Guna.UI2.WinForms.Guna2TextBox()
        btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        SuspendLayout()
        ' 
        ' lbltestentry
        ' 
        lbltestentry.AutoSize = True
        lbltestentry.Location = New Point(25, 29)
        lbltestentry.Name = "lbltestentry"
        lbltestentry.Size = New Size(0, 15)
        lbltestentry.TabIndex = 0
        ' 
        ' lblProductName
        ' 
        lblProductName.Anchor = AnchorStyles.Left
        lblProductName.BackColor = Color.Transparent
        lblProductName.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        lblProductName.Location = New Point(17, 85)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(80, 17)
        lblProductName.TabIndex = 1
        lblProductName.Text = "Product Name"
        ' 
        ' lblProductPrice
        ' 
        lblProductPrice.Anchor = AnchorStyles.Left
        lblProductPrice.BackColor = Color.Transparent
        lblProductPrice.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        lblProductPrice.Location = New Point(17, 167)
        lblProductPrice.Name = "lblProductPrice"
        lblProductPrice.Size = New Size(74, 17)
        lblProductPrice.TabIndex = 1
        lblProductPrice.Text = "Product Price"
        ' 
        ' lnlPanel
        ' 
        lnlPanel.Anchor = AnchorStyles.Left
        lnlPanel.BackColor = Color.Transparent
        lnlPanel.ForeColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        lnlPanel.Location = New Point(17, 255)
        lnlPanel.Name = "lnlPanel"
        lnlPanel.Size = New Size(108, 17)
        lnlPanel.TabIndex = 1
        lnlPanel.Text = "Product Description"
        ' 
        ' tbProductNameEntry
        ' 
        tbProductNameEntry.Anchor = AnchorStyles.Left
        tbProductNameEntry.CustomizableEdges = CustomizableEdges1
        tbProductNameEntry.DefaultText = ""
        tbProductNameEntry.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductNameEntry.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductNameEntry.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductNameEntry.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductNameEntry.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductNameEntry.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductNameEntry.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductNameEntry.Location = New Point(234, 75)
        tbProductNameEntry.Name = "tbProductNameEntry"
        tbProductNameEntry.PasswordChar = ChrW(0)
        tbProductNameEntry.PlaceholderText = ""
        tbProductNameEntry.SelectedText = ""
        tbProductNameEntry.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        tbProductNameEntry.Size = New Size(248, 27)
        tbProductNameEntry.TabIndex = 2
        ' 
        ' tbProductPriceEntry
        ' 
        tbProductPriceEntry.Anchor = AnchorStyles.Left
        tbProductPriceEntry.CustomizableEdges = CustomizableEdges3
        tbProductPriceEntry.DefaultText = ""
        tbProductPriceEntry.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductPriceEntry.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductPriceEntry.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductPriceEntry.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductPriceEntry.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductPriceEntry.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductPriceEntry.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductPriceEntry.Location = New Point(234, 157)
        tbProductPriceEntry.Name = "tbProductPriceEntry"
        tbProductPriceEntry.PasswordChar = ChrW(0)
        tbProductPriceEntry.PlaceholderText = ""
        tbProductPriceEntry.SelectedText = ""
        tbProductPriceEntry.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbProductPriceEntry.Size = New Size(248, 27)
        tbProductPriceEntry.TabIndex = 2
        ' 
        ' tbProductDescriptionEntry
        ' 
        tbProductDescriptionEntry.Anchor = AnchorStyles.Left
        tbProductDescriptionEntry.CustomizableEdges = CustomizableEdges5
        tbProductDescriptionEntry.DefaultText = ""
        tbProductDescriptionEntry.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbProductDescriptionEntry.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbProductDescriptionEntry.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductDescriptionEntry.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbProductDescriptionEntry.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductDescriptionEntry.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbProductDescriptionEntry.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbProductDescriptionEntry.Location = New Point(234, 255)
        tbProductDescriptionEntry.Name = "tbProductDescriptionEntry"
        tbProductDescriptionEntry.PasswordChar = ChrW(0)
        tbProductDescriptionEntry.PlaceholderText = ""
        tbProductDescriptionEntry.SelectedText = ""
        tbProductDescriptionEntry.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbProductDescriptionEntry.Size = New Size(248, 73)
        tbProductDescriptionEntry.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.CustomizableEdges = CustomizableEdges7
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Transparent
        btnSave.FillColor2 = Color.FromArgb(CByte(70), CByte(162), CByte(227))
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(642, 384)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnSave.Size = New Size(134, 45)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        ' 
        ' frmProductEntry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(tbProductDescriptionEntry)
        Controls.Add(tbProductPriceEntry)
        Controls.Add(tbProductNameEntry)
        Controls.Add(lnlPanel)
        Controls.Add(lblProductPrice)
        Controls.Add(lblProductName)
        Controls.Add(lbltestentry)
        Name = "frmProductEntry"
        Text = "Product Entry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbltestentry As Label
    Friend WithEvents lblProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProductPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lnlPanel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnProductNameEntry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnProductPriceEntry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnProductDescriptionEntry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbProductNameEntry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbProductPriceEntry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbProductDescriptionEntry As Guna.UI2.WinForms.Guna2TextBox
End Class
