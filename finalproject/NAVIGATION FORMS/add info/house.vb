Imports System.Data.OleDb

Public Class house
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        GunaComboBox1.Items.Add("Apartment")

        GunaComboBox1.Items.Add("FarmHouse")
        GunaComboBox1.Items.Add("Villa")



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")


        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into rent values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & GunaComboBox1.Text & "' ,'" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Saved")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub house_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaGradientButton6_Click(sender As Object, e As EventArgs) Handles GunaGradientButton6.Click
        GunaComboBox1.Items.Add("Apartment")

        GunaComboBox1.Items.Add("FarmHouse")
        GunaComboBox1.Items.Add("Villa")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        GunaComboBox1.Text = " "
        TextBox5.Text = ""
        TextBox6.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub
End Class