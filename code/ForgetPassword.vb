
Imports System.Data.OleDb
Public Class ForgetPassword

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()
        Dim Id As String = ""
        Dim hobi As String = ""
        Dim x As Integer = 0
        Dim pw As String = ""
        Dim cmd As New OleDbCommand("SELECT * FROM Staff", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Id = dr.GetString(0)
            hobi = dr.GetString(6)
            pw = dr.GetString(2)
            If txtStaffID.Text = Id And txtAnswer.Text = hobi Then
                x = 1
                Exit While
            Else
                x = 0
            End If
        End While
        If x = 1 Then
            txtYourPassword.Text = pw
        ElseIf x = 0 Then
            MessageBox.Show("Wrong ID or Answer")
        End If

        conn.Close()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtYourPassword.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        LogIn.Show()

    End Sub

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStaffID.Focus()
    End Sub


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If ctxtMenu.SourceControl Is txtAnswer Then
            txtAnswer.Clear()
        ElseIf ctxtMenu.SourceControl Is txtStaffID Then
            txtStaffID.Clear()
        ElseIf ctxtMenu.SourceControl Is txtYourPassword Then
            txtYourPassword.Clear()

        End If
    End Sub

    Private Sub txtStaffID_TextChanged(sender As Object, e As EventArgs) Handles txtStaffID.TextChanged

    End Sub

    Private Sub ctxtMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxtMenu.Opening

    End Sub

    Private Sub mnMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblCopyright_Click(sender As Object, e As EventArgs) Handles lblCopyright.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtYourPassword_TextChanged(sender As Object, e As EventArgs) Handles txtYourPassword.TextChanged

    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LogIn.Show()

    End Sub
End Class