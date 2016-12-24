Imports System.Data.OleDb
Public Class ChangePassword
    Dim conn As OleDbConnection
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()
        Dim ID As String = ""
        Dim Password As String = ""
        Dim mycommand As New OleDbCommand("SELECT * FROM Staff", conn)
        Dim dr As OleDbDataReader = mycommand.ExecuteReader
        Dim mycmd As New OleDbCommand("UPDATE Staff SET StaffPassword = @staffpassword WHERE StaffID ='" & txtID.Text & "'", conn)

        While dr.Read
            ID = dr.GetString(0)
            Password = dr.GetString(2)

            If txtID.Text = ID And txtCurrentPassword.Text = Password Then
                mycmd.Parameters.AddWithValue("@staffpassword", txtNewPassword.Text)
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Confirm", "Change password", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Exit While



            Else

                MessageBox.Show("Invalid Staff ID input or Password input !!", "Invalid",
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit While
            End If
        End While
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LogIn.Show()

    End Sub

    Private Sub ctxtMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxtMenu.Opening

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If ctxtMenu.SourceControl Is txtCurrentPassword Then
            txtCurrentPassword.Clear()
        ElseIf ctxtMenu.SourceControl Is txtID Then
            txtID.Clear()
        ElseIf ctxtMenu.SourceControl Is txtNewPassword Then
            txtNewPassword.Clear()

        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged

    End Sub

    Private Sub txtCurrentPassword_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentPassword.TextChanged

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblCopyright_Click(sender As Object, e As EventArgs) Handles lblCopyright.Click

    End Sub

    Private Sub mnMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LogIn.Show()

    End Sub
End Class