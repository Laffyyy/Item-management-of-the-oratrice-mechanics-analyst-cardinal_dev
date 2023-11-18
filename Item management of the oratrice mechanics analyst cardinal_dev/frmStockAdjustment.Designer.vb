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
        lblstock = New Label()
        SuspendLayout()
        ' 
        ' lblstock
        ' 
        lblstock.AutoSize = True
        lblstock.Location = New Point(67, 33)
        lblstock.Name = "lblstock"
        lblstock.Size = New Size(56, 15)
        lblstock.TabIndex = 0
        lblstock.Text = "stock ads"
        ' 
        ' frmStockAdjustment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblstock)
        Name = "frmStockAdjustment"
        Text = "Stock Adjustment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblstock As Label
End Class
