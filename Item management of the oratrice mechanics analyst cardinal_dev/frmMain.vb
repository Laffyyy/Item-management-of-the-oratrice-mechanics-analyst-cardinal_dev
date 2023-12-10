Imports System.Runtime.InteropServices
Imports Guna.UI2.WinForms

Public Class frmMain

    Private currentbtn As Guna.UI2.WinForms.Guna2GradientButton
    Private leftBorderbtn As Panel
    Private currentChildform As Form

    Private accesspont As Integer = frmLogin.UUserAccessLevel



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderbtn = New Panel()
        leftBorderbtn.Size = New Size()
        pnlMainPanel.Controls.Add(leftBorderbtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        dissableaccesspoint()



    End Sub



    Private Sub dissableaccesspoint()

        If frmLogin.UUserAccessLevel <> 1 Then
            btnAccountAdj.TextAlign = HorizontalAlignment.Left
            btnAccountAdj.ForeColor = Color.FromArgb(128, 153, 180, 209)
            btnAccountAdj.Enabled = False


        End If
        If frmLogin.UUserAccessLevel = 1 Then
            btnAccountAdj.Enabled = True

            btnAccountAdj.ForeColor = Color.FromArgb(153, 180, 209)
            btnAccountAdj.TextAlign = HorizontalAlignment.Center

        End If


    End Sub

    Private Sub Activebutton(senderbtn As Object)
        'costomizing the button here
        If senderbtn IsNot Nothing Then
            DisableButton()
            'button ctype is just converting the object button to the ative button its mean like senderbtn = object button
            currentbtn = CType(senderbtn, Guna2GradientButton)
            currentbtn.FillColor = Color.FromArgb(23, 30, 53)
            currentbtn.ForeColor = Color.FromArgb(255, 249, 144)
            currentbtn.TextAlign = HorizontalAlignment.Left





        End If
    End Sub

    Private Sub DisableButton()
        If currentbtn IsNot Nothing Then
            currentbtn.FillColor = Color.Transparent
            currentbtn.ForeColor = Color.FromArgb(153, 180, 209)
            currentbtn.TextAlign = HorizontalAlignment.Center
        End If
    End Sub
    '153,180,209 active cap


    Public Sub OpenChildrenform(childform As Form)
        'open 1 only form
        If currentChildform IsNot Nothing Then
            currentChildform.Close()
        End If
        currentChildform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnlDesktop.Controls.Add(childform)
        pnlDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblHeader.Text = childform.Text
        childform.BackColor = Color.FromArgb(34, 44, 79)
        'default setting for child form settings 
    End Sub

    'form draggy
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub Reset()
        DisableButton()
        leftBorderbtn.Visible = False
        lblHeader.Text = "Home"

    End Sub

    Public Sub pubreset()
        DisableButton()
        leftBorderbtn.Visible = False
    End Sub



    Private Sub btnProductEntry_Click(sender As Object, e As EventArgs) Handles btnProductEntry.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
            Not frmProductEntry.productentryEditmode Then


            Activebutton(sender)
            OpenChildrenform(New frmProductEntry)

        Else

            MessageBox.Show("Exit edit mode")
        End If
    End Sub

    Private Sub btnOrderMannage_Click(sender As Object, e As EventArgs) Handles btnOrderMannage.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
            Not frmProductEntry.productentryEditmode Then
            Activebutton(sender)
            OpenChildrenform(New frmOrderManagement)

        Else

            MessageBox.Show("Exit edit mode")
        End If

    End Sub

    Private Sub btnStockAdjustment_Click(sender As Object, e As EventArgs) Handles btnStockAdjustment.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
            Not frmProductEntry.productentryEditmode Then


            Activebutton(sender)
            OpenChildrenform(New frmStockAdjustment)

        Else

            MessageBox.Show("Exit edit mode")
        End If

    End Sub

    Private Sub btnAccountAdj_Click(sender As Object, e As EventArgs) Handles btnAccountAdj.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
           Not frmProductEntry.productentryEditmode Then


            Activebutton(sender)
            OpenChildrenform(New frmAccountAdjustment)

        Else

            MessageBox.Show("Exit edit mode")
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
           Not frmProductEntry.productentryEditmode Then


            Activebutton(sender)
            OpenChildrenform(New frmCustomer)

        Else

            MessageBox.Show("Exit edit mode")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgLogo.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
            Not frmProductEntry.productentryEditmode Then

            If currentChildform IsNot Nothing Then
                currentChildform.Close()
            End If
            Reset()

        Else

            MessageBox.Show("Exit edit mode")
        End If

    End Sub




    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If Not frmOrderManagement.ordermanagementstateEdit AndAlso
            Not frmProductEntry.productentryEditmode Then


            Application.Exit()

        Else

            MessageBox.Show("Exit edit mode")
        End If

    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If currentChildform IsNot Nothing Then
                currentChildform.Close()
            End If
            Reset()



        Me.Hide()
        frmLogin.Show()
        WindowState = FormWindowState.Normal
        frmLogin.UserIDusing = ""
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized

    End Sub



    Private Sub active(sender As Object, e As EventArgs) Handles MyBase.Activated
        dissableaccesspoint()

    End Sub
End Class
