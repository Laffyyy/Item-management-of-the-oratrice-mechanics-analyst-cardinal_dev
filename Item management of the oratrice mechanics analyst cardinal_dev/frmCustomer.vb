Public Class frmCustomer

    Public Shared Property frmcustomereditmode As Boolean = False

    Private Sub OnEdit()

        frmcustomereditmode = False
    End Sub

    Private Sub notOnEdit()

        frmcustomereditmode = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If frmcustomereditmode Then
            OnEdit()
        Else
            notOnEdit()
        End If
    End Sub
End Class