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
        lbltestentry = New Label()
        SuspendLayout()
        ' 
        ' lbltestentry
        ' 
        lbltestentry.AutoSize = True
        lbltestentry.Location = New Point(25, 29)
        lbltestentry.Name = "lbltestentry"
        lbltestentry.Size = New Size(79, 15)
        lbltestentry.TabIndex = 0
        lbltestentry.Text = "product entry"
        ' 
        ' frmProductEntry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbltestentry)
        Name = "frmProductEntry"
        Text = "Product Entry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbltestentry As Label
End Class
