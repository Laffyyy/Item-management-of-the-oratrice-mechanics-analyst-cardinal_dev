Public Class frmAccountAdjustment

    Public Shared Property frmaccountadjustmentedit As Boolean = False


    Private Sub Onedit()
        frmaccountadjustmentedit = True
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"

        btnAdd.Text = "Save"
        btnAdd.ForeColor = Color.FromArgb(255, 249, 144)
        btnAdd.FillColor2 = Color.FromArgb(153, 180, 209)

        lblID.ForeColor = Color.FromArgb(255, 249, 144)
        lblPassword.ForeColor = Color.FromArgb(255, 249, 144)
        lblLastName.ForeColor = Color.FromArgb(255, 249, 144)
        lblFirstName.ForeColor = Color.FromArgb(255, 249, 144)
        lblrole.ForeColor = Color.FromArgb(255, 249, 144)

    End Sub

    Private Sub notEdit()
        frmaccountadjustmentedit = False
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        btnEdit.Text = "Edit Account"

        btnAdd.Text = "Add"
        btnAdd.ForeColor = Color.White
        btnAdd.FillColor2 = Color.FromArgb(94, 148, 255)

        lblID.ForeColor = Color.FromArgb(153, 180, 209)
        lblPassword.ForeColor = Color.FromArgb(153, 180, 209)
        lblLastName.ForeColor = Color.FromArgb(153, 180, 209)
        lblFirstName.ForeColor = Color.FromArgb(153, 180, 209)
        lblrole.ForeColor = Color.FromArgb(153, 180, 209)


    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not frmaccountadjustmentedit Then
            Onedit()


        Else
            notEdit()


        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged, Guna2TextBox3.TextChanged

    End Sub

    Private Sub frmAccountAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged, tbID.TextChanged

    End Sub
End Class