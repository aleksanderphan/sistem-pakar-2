Public Class Soal3

    Dim b1, b2, b3, ab1, ab2, ab3, a As Double

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        b1 = txtB1.Text
        b2 = txtB2.Text
        b3 = txtB3.Text
        ab1 = txtab1.Text
        ab2 = txtab2.Text
        ab3 = txtab3.Text

        a = (ab1 * b1) + (ab2 * b2) + (b3 * ab3)
        txtHasilA.Text = a
        txtHasilB.Text = (ab3 * b3) / a
    End Sub
End Class