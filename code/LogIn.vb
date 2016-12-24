Imports System.Data.OleDb
Imports System.DateTime
Public Class LogIn


    Dim conn As OleDbConnection
        Dim cmmd As OleDbCommand
        Public staffID As String = ""


    Private Sub lblForgetPassword_Click(sender As Object, e As EventArgs) Handles lblForgetPassword.Click
        Me.Hide()
        ForgetPassword.Show()

    End Sub
    Private Sub lblForgetPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles lblForgetPassword.MouseDown

        Dim myFont2 As New Font(lblForgetPassword.Font.Name, 12, FontStyle.Underline)
        lblForgetPassword.Font = myFont2
        lblForgetPassword.ForeColor = Color.DarkRed

    End Sub

    Private Sub lblForgetPassword_MouseEnter(sender As Object, e As EventArgs) Handles lblForgetPassword.MouseEnter
        Dim myFont2 As New Font(lblForgetPassword.Font.Name, 12, FontStyle.Underline)
        lblForgetPassword.Font = myFont2
        lblForgetPassword.ForeColor = Color.OrangeRed
    End Sub

    Private Sub lblForgetPassword_MouseLeave(sender As Object, e As EventArgs) Handles lblForgetPassword.MouseLeave
        Dim myFont2 As New Font(lblForgetPassword.Font.Name, 12, FontStyle.Regular)
        lblForgetPassword.Font = myFont2
        lblForgetPassword.ForeColor = Color.Blue
    End Sub

    Private Sub lblForgetPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles lblForgetPassword.MouseUp
        Dim myFont2 As New Font(lblForgetPassword.Font.Name, 12, FontStyle.Underline)
        lblForgetPassword.Font = myFont2
        lblForgetPassword.ForeColor = Color.OrangeRed
    End Sub

    Private Sub lblChangePassword_Click(sender As Object, e As EventArgs) Handles lblChangePassword.Click
        Me.Hide()
        ChangePassword.Show()


    End Sub

    Private Sub lblChangePassword_MouseEnter(sender As Object, e As EventArgs) Handles lblChangePassword.MouseEnter
        Dim myFont2 As New Font(lblChangePassword.Font.Name, 12, FontStyle.Underline)
        lblChangePassword.Font = myFont2
        lblChangePassword.ForeColor = Color.OrangeRed


    End Sub

    Private Sub lblChangePassword_MouseUp(sender As Object, e As MouseEventArgs) Handles lblChangePassword.MouseUp
        Dim myFont2 As New Font(lblChangePassword.Font.Name, 12, FontStyle.Underline)
        lblChangePassword.Font = myFont2
        lblChangePassword.ForeColor = Color.OrangeRed
    End Sub

    Private Sub lblChangePassword_MouseLeave(sender As Object, e As EventArgs) Handles lblChangePassword.MouseLeave
        Dim myFont2 As New Font(lblChangePassword.Font.Name, 12, FontStyle.Regular)
        lblChangePassword.Font = myFont2
        lblChangePassword.ForeColor = Color.Blue
    End Sub

    Private Sub lblChangePassword_MouseDown(sender As Object, e As MouseEventArgs) Handles lblChangePassword.MouseDown
        Dim myFont2 As New Font(lblChangePassword.Font.Name, 12, FontStyle.Underline)
        lblChangePassword.Font = myFont2
        lblChangePassword.ForeColor = Color.DarkRed
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim ID As String = ""
        Dim Password As String = ""
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()
        Dim mycommand As New OleDbCommand("SELECT * FROM Staff", conn)

        Dim dr As OleDbDataReader = mycommand.ExecuteReader
        Dim com As New OleDbCommand("INSERT INTO StaffLogIn (LgID, StaffID, LogPeriod,LgType) VALUES (@loginID, @staffID, @login, @lgType)", conn)

        Dim logID As String = ""
        Dim cmd As New OleDbCommand("SELECT LgID FROM StaffLogIn WHERE LgType = 'LogIn'", conn)
        Dim rdlog As OleDbDataReader = cmd.ExecuteReader
        Dim intnum As String = 0
        Dim StrID As String = ""
        Dim StrNewID As String = ""
        Dim intLoginCount As Integer = 0

        While rdlog.Read
            'StrID = rdlog.GetString(0)
            intLoginCount += 1
        End While

        'intnum = StrID.Substring(2) + 1
        'StrNewID = "LI" + intnum
        StrNewID = "LI" & intLoginCount

        Dim x As Integer
            While dr.Read

                ID = dr.GetString(0)
                Password = dr.GetString(2)

                If txtStaffID.Text = ID And txtPassword.Text = Password Then
                    staffID = txtStaffID.Text
                    x = 1
                    Exit While
                Else
                    x = 0
                End If
            End While

            If x = 1 Then
                MessageBox.Show("Welcome")
                com.Parameters.AddWithValue("@loginID", StrNewID)
                com.Parameters.AddWithValue("@staffID", txtStaffID.Text)
                com.Parameters.AddWithValue("@login", Date.Now)
                com.Parameters.AddWithValue("@lgType", "LogIn")

                com.ExecuteNonQuery()
                Me.Hide()
                Form1.Show()

            ElseIf x = 0 Then
            MessageBox.Show("Invalid Staff ID input or Password input !!", "Invalid",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub



    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick




    End Sub

    Private Sub ctxtLogIn_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxtLogIn.Opening



    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If ctxtLogIn.SourceControl Is txtStaffID Then
            txtStaffID.Clear()
        ElseIf ctxtLogIn.SourceControl Is txtPassword Then
            txtPassword.Clear()
        End If

    End Sub

    Private Sub txtStaffID_TextChanged(sender As Object, e As EventArgs) Handles txtStaffID.TextChanged


    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub



    Private Sub lblCopyright_Click(sender As Object, e As EventArgs) Handles lblCopyright.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblStaffID_Click(sender As Object, e As EventArgs) Handles lblStaffID.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub mnMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Application.Exit()
    End Sub

    Private Sub PicClose_MouseEnter(sender As Object, e As EventArgs) Handles PicClose.MouseEnter
        PicClose.Image = My.Resources.exit2backhover
    End Sub

    Private Sub PicClose_MouseUp(sender As Object, e As MouseEventArgs) Handles PicClose.MouseUp
        PicClose.Image = My.Resources.exit2backhover
    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs) Handles PicClose.MouseLeave
        PicClose.Image = My.Resources.exit1
    End Sub

    Private Sub PicClose_MouseDown(sender As Object, e As MouseEventArgs) Handles PicClose.MouseDown
        PicClose.Image = My.Resources.exit2Backdown
    End Sub
End Class