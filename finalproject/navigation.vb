Public Class navigation


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        With HOME
            .TopLevel = False
            pnlcontent.Controls.Add(HOME)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        With USER
            .TopLevel = False
            pnlcontent.Controls.Add(USER)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Application.Exit()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        With ABOUT
            .TopLevel = False
            pnlcontent.Controls.Add(ABOUT)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click

    End Sub

    Private Sub pnlcontent_Paint(sender As Object, e As PaintEventArgs) Handles pnlcontent.Paint

    End Sub
End Class