Imports System.Data.OleDb
Imports System.Reflection
Imports Guna.UI.WinForms

Public Class mainhouse
    Private Sub mainhouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")


        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into rent values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & TextBox5.Text & "' ,'" & TextBox6.Text & "', '" & TextBox7.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Saved")
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub
    Dim index As Integer = 0
    Dim table As New DataTable()
    Public Sub showdata(ByVal position As Integer)
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")
        con.Open()
        Dim cmd As New OleDbCommand("select * from rent", con)
        Dim ad As New OleDbDataAdapter(cmd)
        ad.Fill(table)
        TextBox1.Text = table.Rows(position)(0).ToString()
        TextBox2.Text = table.Rows(position)(1).ToString()
        TextBox3.Text = table.Rows(position)(2).ToString()
        TextBox4.Text = table.Rows(position)(3).ToString()
        TextBox5.Text = table.Rows(position)(4).ToString()
        TextBox6.Text = table.Rows(position)(5).ToString()
        TextBox7.Text = table.Rows(position)(6).ToString()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        index = 0
        showdata(index)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        index -= 1
        showdata(index)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        index += 1
        showdata(index)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        index = table.Rows.Count() - 1
        showdata(index)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")
        con.Open()
        Dim a As Integer
        a = Convert.ToInt32(TextBox1.Text)


        Dim qer As String = "update rent set owner=@owner, contact=@cont, rate=@rate,type=@rank,cost=@sal,area=@join where ID=@id"


        Dim s As String = "update rent set owner = ?,contact = ?,rate = ?,type = ?,cost = ?,area = ? where ID = ?"


        Dim n As Integer
        Dim cmd1 As New OleDbCommand(qer, con)

        cmd1.Parameters.AddWithValue("owner", TextBox2.Text)
        cmd1.Parameters.AddWithValue("cont", TextBox3.Text)
        cmd1.Parameters.AddWithValue("rate", TextBox4.Text)
        cmd1.Parameters.AddWithValue("rank", TextBox5.Text)
        cmd1.Parameters.AddWithValue("sal", TextBox6.Text)
        cmd1.Parameters.AddWithValue("join", TextBox7.Text)
        cmd1.Parameters.AddWithValue("id", TextBox1.Text)
        MsgBox("record updated")
        Try

            cmd1.ExecuteNonQuery()

            n = cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")
        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from rent where ID=" & TextBox1.Text & " "

        cmd.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Record Deleted")

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()

    End Sub
End Class