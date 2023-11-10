Public Class USER
    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        common.Show()
        navigation.Hide()

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        navigation.Close()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        commonview.Show()
        navigation.Hide()
    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        Manage.Show()
        navigation.Hide()
    End Sub

    Private Sub USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class