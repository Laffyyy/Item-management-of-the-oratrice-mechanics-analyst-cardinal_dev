﻿Public Class frmOrderManagement

    Public Shared Property odermanagementstateEdit As Boolean = False






    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        'remove left
        btnEdit.Text = "EDIT MODE"
        dgvOrderMannagement.DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209)
        btnDelete.Hide()
        'if on edit mode its ok to go to other form but not log out and close program
        odermanagementstateEdit = True

        lblOrderID.ForeColor = Color.FromArgb(255, 249, 144)
        lblCustomerName.ForeColor = Color.FromArgb(255, 249, 144)
        lblProduct.ForeColor = Color.FromArgb(255, 249, 144)
        lblQuantity.ForeColor = Color.FromArgb(255, 249, 144)
        bntSave.Text = "Save"
    End Sub

    Private Sub NotEdit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        dgvOrderMannagement.DefaultCellStyle.BackColor = Color.FromArgb(90, 163, 216)
        btnEdit.Text = "Edit Order"

        btnDelete.Show()

        odermanagementstateEdit = False

        lblOrderID.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerName.ForeColor = Color.FromArgb(153, 180, 209)
        lblProduct.ForeColor = Color.FromArgb(153, 180, 209)
        lblQuantity.ForeColor = Color.FromArgb(153, 180, 209)
        bntSave.Text = "Add"


    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not odermanagementstateEdit Then

            Onedit()
        Else

            NotEdit()
        End If



    End Sub


    'Private Sub btnNeworders_Click(sender As Object, e As EventArgs) Handles btnNeworders.Click
    '    If Not frmOrderManagement.odermanagementstateEdit Then


    '        frmMain.OpenChildrenform(New frmNewOrders)
    '        frmMain.pubreset()

    '    Else

    '        MessageBox.Show("Exit edit mode")
    '    End If

    'End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click, lblProduct.Click, lblQuantity.Click

    End Sub

    Private Sub frmOrderManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class