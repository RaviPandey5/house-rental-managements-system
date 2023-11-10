Imports System.Data.OleDb
Imports System.IO

Public Class viewhouse


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Filter = "jpg(*jpg)|*.jpg|jpeg(*jpeg)|*.jpg|png(*png)|*.png"
        open.Title = "Open  File"
        open.FilterIndex = 1
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image.Save("C:\Users\hyara\Pictures\Saved Pictures\" & ComboBox1.Text & ".jpg")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = ComboBox2.Text
        Dim folder As String = "C:\Users\hyara\Pictures\Saved Pictures\"
        Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
        Try
            Using fs As New System.IO.FileStream(filename, IO.FileMode.Open)
                PictureBox1.Image = New Bitmap(Image.FromStream(fs))

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub viewhouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loaddata2()
    End Sub
    Sub loaddata()
        Try
            relode("select * from rent", ComboBox1)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "ID"
            ComboBox1.ValueMember = ""
        Catch ex As Exception

        End Try
    End Sub
    Sub loaddata2()
        Try
            relode("select * from rent", ComboBox2)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "ID"
            ComboBox2.ValueMember = ""
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        loaddata()
        loaddata2()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class