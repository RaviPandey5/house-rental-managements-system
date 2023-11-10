Imports System.Data.OleDb

Public Class datastaff
    Private Sub datastaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()

    End Sub
    Sub view()

        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\staff data.mdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from staff", con)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        DataGridView1.DataSource = ds.Tables("dd")
        con.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)







    End Sub

    Private Sub notfound()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\staff data.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New OleDbCommand("select * from staff where id like '%" + TextBox1.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
'im a As Integer
' '= Convert.ToInt32(TextBox1.Text)
'r 'Cast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
'dring.Format("ID Like '%" & a & "%'")