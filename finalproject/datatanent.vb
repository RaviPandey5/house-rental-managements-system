Imports System.Data.OleDb

Public Class datatanent
    Sub view()

        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from student", con)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        DataGridView1.DataSource = ds.Tables("dd")
        con.Close()
    End Sub

    Private Sub Datatanent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New OleDbCommand("select * from student where Enrollment like '%" + TextBox1.Text + "%'", conn)


        Dim da As New OleDbDataAdapter

        Dim dt As New DataTable

        da.SelectCommand = cmd

        dt.Clear()
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
End Class

