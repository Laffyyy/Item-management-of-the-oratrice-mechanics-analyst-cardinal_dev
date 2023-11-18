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
        lblorder = New Label()
        SuspendLayout()
        ' 
        ' lblorder
        ' 
        lblorder.AutoSize = True
        lblorder.Location = New Point(140, 31)
        lblorder.Name = "lblorder"
        lblorder.Size = New Size(78, 15)
        lblorder.TabIndex = 0
        lblorder.Text = "ordermanage"
        ' 
        ' frm0rderMannage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblorder)
        Name = "frm0rderMannage"
        Text = "Order Mannage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblorder As Label
End Class
