Public Class Soal2

    Dim wok, wot, wk, wt, hasil As Double

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        wok = txtWOK.Text
        wot = txtWOT.Text
        wk = txtWK.Text
        wt = txtWT.Text

        txtHasilW.Text = (wok * wk) / (wk + wt)
        txtHasilWO.Text = (wot * wt) / (wk + wt)
    End Sub
End Class