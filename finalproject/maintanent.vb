Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class maintanent






    Sub view()

        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from student", con)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        'DataGridView1.DataSource = ds.Tables("dd")
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into student values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Saved")
        view()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim a As Integer
        a = Convert.ToInt32(TextBox1.Text)


        Dim qer As String = "update student set Name=@Name, Address=@add, Rent=@rent,Email=@mail,Phone_no=@no where Enrollment=@enrol"


        Dim s As String = "update student set Name= ?, Address=?, Rent=?,Email= ? ,Phone_no= ? where Enrollment= ?"


        Dim n As Integer
        Dim cmd1 As New OleDbCommand(qer, con)

        cmd1.Parameters.AddWithValue("Name", TextBox2.Text)
        cmd1.Parameters.AddWithValue("Address", TextBox3.Text)
        cmd1.Parameters.AddWithValue("Rent", TextBox4.Text)
        cmd1.Parameters.AddWithValue("Email", TextBox5.Text)
        cmd1.Parameters.AddWithValue("Phone no", TextBox6.Text)
        cmd1.Parameters.AddWithValue("Enrollment", TextBox1.Text)
        Try

            cmd1.ExecuteNonQuery()

            n = cmd1.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
        MsgBox("record updated")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from student where Enrollment=" & TextBox1.Text & " "

        cmd.ExecuteNonQuery()

            con.Close()
        MessageBox.Show("Record Deleted")
        view()

    End Sub


    Dim index As Integer = 0
    Dim table As New DataTable()
    Public Sub showdata(ByVal position As Integer)
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
        con.Open()
        Dim cmd As New OleDbCommand("select * from student", con)
        Dim ad As New OleDbDataAdapter(cmd)
        ad.Fill(table)
        TextBox1.Text = table.Rows(position)(0).ToString()
        TextBox2.Text = table.Rows(position)(1).ToString()
        TextBox3.Text = table.Rows(position)(2).ToString()
        TextBox4.Text = table.Rows(position)(3).ToString()
        TextBox5.Text = table.Rows(position)(4).ToString()
        TextBox6.Text = table.Rows(position)(5).ToString()

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

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
'Dim command As New SqlCommand(sqlQuery, connection)

'command.Parameters.AddWithValue("@NewToyName", modname.Text)
'command.Parameters.AddWithValue("@NewToyPrice", Convert.ToInt32(modpr.Text))
'command.Parameters.AddWithValue("@ToyID", toyID)
'command.Parameters.AddWithValue("@newtoycategory", modcat.Text)
'command.Parameters.AddWithValue("@newtoyquantity", Convert.ToInt32(modquan.Text))'''



'Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\collage.mdb")
'con.Open()
'Dim cmd As New OleDbCommand()
'cmd.Connection = con
'cmd.CommandType = CommandType.Text
'cmd.CommandText = "update student set Name='" & TextBox2.Text & "', Address='" & TextBox3.Text & "', Rent='" & TextBox4.Text & "',Email='" & TextBox5.Text & "',Phone no='" & TextBox6.Text & "' where Enrollment=" & TextBox1.Text & ""
'cmd.ExecuteNonQuery()
'con.Close()
'view()