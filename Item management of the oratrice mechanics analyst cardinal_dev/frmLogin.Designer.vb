<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        pnlLogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.Anchor = AnchorStyles.Right
        pnlLogin.CustomizableEdges = CustomizableEdges1
        pnlLogin.FillColor = Color.Transparent
        pnlLogin.FillColor2 = Color.Transparent
        pnlLogin.FillColor3 = Color.Transparent
        pnlLogin.FillColor4 = Color.FromArgb(CByte(106), CByte(148), CByte(245))
        pnlLogin.Location = New Point(489, 55)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlLogin.Size = New Size(272, 336)
        pnlLogin.TabIndex = 0
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(44), CByte(79))
        ClientSize = New Size(800, 450)
        Controls.Add(pnlLogin)
        Name = "frmLogin"
        Text = "frmLogin"
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
