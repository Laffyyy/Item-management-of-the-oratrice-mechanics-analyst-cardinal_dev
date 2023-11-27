Public Class frmOrderManagement

    Public Shared Property odermanagementstateEdit As Boolean = False





    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        'remove left
        btnEdit.Text = "EDIT MODE"
        dgvOrderMannage.DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209)
        btnDelete.Hide()
        'if on edit mode its ok to go to other form but not log out and close program
        odermanagementstateEdit = True
    End Sub

    Private Sub NotEdit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        dgvOrderMannage.DefaultCellStyle.BackColor = Color.FromArgb(90, 163, 216)
        btnEdit.Text = "Edit Order"
        btnDelete.Show()
        odermanagementstateEdit = False

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not odermanagementstateEdit Then
            Onedit()


        Else
            NotEdit()


        End If



    End Sub


    Private Sub btnNeworders_Click(sender As Object, e As EventArgs) Handles btnNeworders.Click
        If Not frmOrderManagement.odermanagementstateEdit Then


            frmMain.OpenChildrenform(New frmNewOrders)
            frmMain.pubreset()

        Else

            MessageBox.Show("Exit edit mode")
        End If

    End Sub


End Class