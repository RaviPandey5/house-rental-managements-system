Imports System.Data.OleDb

Public Class staff
    Private collageConnectionString As String

    Private Sub GunaComboBox1_click(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        If GunaComboBox1.Text = "Worker" Then TextBox5.Text = " 7000 "
        If GunaComboBox1.Text = "Executive" Then TextBox5.Text = " 12000 "
        If GunaComboBox1.Text = "Manager" Then TextBox5.Text = " 25000 "
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub staff_load()

    End Sub

    Private Sub GunaGradientButton6_Click(sender As Object, e As EventArgs) Handles GunaGradientButton6.Click
        GunaComboBox1.Items.Add("Worker")
        GunaComboBox1.Items.Add("Executive")
        GunaComboBox1.Items.Add("Manager")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_DOB.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\staff data.mdb")


        con.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into staff values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & GunaComboBox1.Text & "' ,'" & TextBox5.Text & "', '" & DateTimePicker_DOB.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Record Saved")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        GunaComboBox1.Text = " "
        TextBox5.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    Private Sub DateTimePicker_DOB_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker_DOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub
End Class
