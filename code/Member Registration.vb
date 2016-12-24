Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Member_Registration



    Dim conn As OleDbConnection
    Dim cmmd As OleDbCommand
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtContaxtNumber.Clear()
        txtMemberAddress.Clear()
        txtMemberEmail.Clear()
        txtMemberIC.Clear()
        txtMemberName.Clear()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strID As String = ""
        Dim intNum As String = 0
        Dim strNewID As String = ""

        If txtMemberName.Text = "" Then
            MessageBox.Show("Member Name Cannot be blank", "Erroro Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMemberName.Clear()
            txtMemberName.Focus()
            Exit Sub
        ElseIf txtMemberIC.Text = ""
            MessageBox.Show("Member IC Cannot be blank", "Erroro Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMemberIC.Focus()
            Exit Sub
        ElseIf txtMemberEmail.Text = ""
            MessageBox.Show("Member IC Cannot be blank", "Erroro Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMemberEmail.Focus()
            Exit Sub
        ElseIf txtContaxtNumber.Text = ""
            MessageBox.Show("Member IC Cannot be blank", "Erroro Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContaxtNumber.Focus()
            Exit Sub
        ElseIf txtMemberAddress.Text = ""
            MessageBox.Show("Member IC Cannot be blank", "Erroro Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMemberAddress.Focus()
            Exit Sub
        Else

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
            conn.Open()

            Dim cmd As New OleDbCommand("SELECT * FROM Member", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim intMemberCount As Integer = 1

            While dr.Read
                'strID = dr.GetString(0) & vbCrLf
                intMemberCount += 1
            End While

            'intNum = strID.Substring(3) + 1
            strNewID = "MID" & intMemberCount

            Dim cmd2 As New OleDbCommand("INSERT INTO Member (MemberID, MemberName, MemberIC, MemberGender, MemberEmail, MemberContactNumber, MemberAddress) VALUES (@memberID, @memberName, @memberIC, @memberGender, @memberEmail, @memberContactNumber, @memberAddress)", conn)

            cmd2.Parameters.AddWithValue("@memberID", strNewID)
            cmd2.Parameters.AddWithValue("@memberName", txtMemberName.Text)
            cmd2.Parameters.AddWithValue("@memberIC", txtMemberIC.Text)
            If radMale.Checked Then
                cmd2.Parameters.AddWithValue("@memberGender", "Male")
            End If

            If radFemale.Checked Then
                cmd2.Parameters.AddWithValue("@memberGender", "Female")
            End If

            cmd2.Parameters.AddWithValue("@memberEmail", txtMemberEmail.Text)
            cmd2.Parameters.AddWithValue("@memberContactNumber", txtContaxtNumber.Text)
            cmd2.Parameters.AddWithValue("@memberAddress", txtMemberAddress.Text)
            MessageBox.Show("Registration Successful", "", MessageBoxButtons.OK)

            cmd2.ExecuteNonQuery()
            conn.Close()
        End If

    End Sub


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMemberName_Enter(sender As Object, e As EventArgs) Handles txtMemberName.Enter

    End Sub

    Private Sub txtMemberName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberName.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtMemberIC_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub



    Private Sub txtMemberIC_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMemberEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberEmail.KeyPress

    End Sub

    Private Sub txtMemberEmail_TextChanged(sender As Object, e As EventArgs) Handles txtMemberEmail.TextChanged



    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ctxtMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxtMenu.Opening

    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        If ctxtMenu.SourceControl Is txtContaxtNumber Then
            txtContaxtNumber.Clear()
        ElseIf ctxtMenu.SourceControl Is txtMemberAddress Then
            txtMemberAddress.Clear()
        ElseIf ctxtMenu.SourceControl Is txtMemberEmail Then
            txtMemberEmail.Clear()
        ElseIf ctxtMenu.SourceControl Is txtMemberIC Then
            txtMemberIC.Clear()
        ElseIf ctxtMenu.SourceControl Is txtMemberName Then
            txtMemberName.Clear()
        End If
        



    End Sub



    Private Sub txtContaxtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContaxtNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContaxtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContaxtNumber.TextChanged

    End Sub

    Private Sub txtMemberName_TextChanged(sender As Object, e As EventArgs) Handles txtMemberName.TextChanged

    End Sub



    Private Sub txtMemberIC_TextChanged_1(sender As Object, e As EventArgs) Handles txtMemberIC.TextChanged

    End Sub


    Private Sub txtMemberAddress_TextChanged(sender As Object, e As EventArgs) Handles txtMemberAddress.TextChanged

    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)



        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub mnMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class

