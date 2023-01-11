Public Class Master

    Private score As Integer = 0

    Private Sub BtnSoal1_Click(sender As Object, e As EventArgs) Handles btnSoal1.Click
        Soal1.MdiParent = Me
        Soal1.Show()
    End Sub

    Private Sub BtnSoal2_Click(sender As Object, e As EventArgs) Handles btnSoal2.Click
        Soal2.MdiParent = Me
        Soal2.Show()
    End Sub

    Private Sub BtnSoal3_Click(sender As Object, e As EventArgs) Handles btnSoal3.Click
        Soal3.MdiParent = Me
        Soal3.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        score += 1
        Me.Text = "Teorama Bayes - Score: " & score

        Me.SuspendLayout()

        Dim rnd As New Random()
        btnSP.Location = New Point(rnd.Next(0, Me.Width - btnSP.Width), rnd.Next(0, Me.Height - btnSP.Height))

        Me.ResumeLayout()

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.SuspendLayout()

        btnSP.Top += 15

        If btnSP.Bottom >= Me.Height Then
            Timer1.Stop()
            btnSP.Top = 0
            Timer1.Start()
        End If

        Me.ResumeLayout()
    End Sub
End Class
