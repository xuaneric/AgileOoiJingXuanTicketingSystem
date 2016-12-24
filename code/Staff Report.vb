Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Staff_Report
    Dim conn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private Sub Staff_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Me.Close()
        Report.Show()


    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = conn
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from StaffLogIn", MyConn) 'Change items to your database name
        da.Fill(ds, "StaffLogIn") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView2.DataSource = view

    End Sub
End Class