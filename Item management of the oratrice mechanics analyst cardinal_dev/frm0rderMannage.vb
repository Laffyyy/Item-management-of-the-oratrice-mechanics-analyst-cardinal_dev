Public Class frm0rderMannage
    Private stateEdit As Boolean = False

    Private Sub formresize(sender As Object, e As EventArgs) Handles MyBase.Resize
        UpdateSizeINF()
    End Sub

    Private Sub UpdateSizeINF()
        Dim withsize As Double = Me.Width
    End Sub


    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        'remove left
        dgvOrderMannage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
    End Sub

    Private Sub NotEdit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)

        dgvOrderMannage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left
    End Sub
    Private Sub btnNeworders_Click(sender As Object, e As EventArgs) Handles btnNeworders.Click
        frmMain.OpenChildrenform(New frmNewOrders)
        frmMain.pubreset()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If stateEdit Then
            Onedit()
        Else
            NotEdit()
        End If

        stateEdit = Not stateEdit
    End Sub


End Class