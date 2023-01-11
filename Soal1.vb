Public Class Soal1

    Dim jlh, pm1, pm2, pm3, pam1, pam2, pam3, hasil, a As Double

    Private Sub Txt_Validated(sender As Object, e As EventArgs) Handles txtJlh.Validated, txtPM1.Validated, txtPM2.Validated, txtPM3.Validated, txtPAM1.Validated, txtPAM2.Validated, txtPAM3.Validated
        If sender.Text = String.Empty Then
            sender.Text = 0
        Else
            Try
                sender.Text = New DataTable().Compute(sender.Text, vbNull)
            Catch ex As Exception
                MsgBox("Masukkan Angka Yang valid!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Input Tidak Valid")
            End Try
        End If
    End Sub

    Private Sub Txt_Enter(sender As Object, e As EventArgs) Handles txtJlh.Enter, txtPM1.Enter, txtPM2.Enter, txtPM3.Enter, txtPAM1.Enter, txtPAM2.Enter, txtPAM3.Enter
        Dim edit = (DirectCast(sender, TextBox))
        BeginInvoke(New MethodInvoker(Sub()
                                          edit.SelectionStart = 0
                                          edit.SelectionLength = edit.Text.Length
                                      End Sub))
    End Sub

    Private Sub Soal1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtJlh.Select()
        rtxtSoal.Text = "Suatu mata kuliah teori probabilitas diikuti oleh 50 mahasiswa tahun ke 1,
15 mahasiswa tahun ke 2 dan 10 mahasiswa tahun ke 3.
Diketahui mahasiswa yang mendapatkan nilai A adalah 10 orang dari mahasiswa tahun ke 1,
8 orang dari mahasiswa tahun ke 2 dan 5 orang mahasiswa tahun ke 3.
Bila seorang mahasiswa dipilih secara acak, berapakah peluang dia:
a. Mendapatkan nilai A
b. Mahasiswa tahun ke 1 bila diketahui dia mendapatkan A

Diketahui :
1. Jumlah mahasiswa yang mengikuti mata kuliah teori proababilitas adalah 75 orang
2. P(M1) atau peluang mahasiswa adalah mahasiswa tahun ke-1 yaitu 50/75
3. P(M2) atau peluang mahasiswa adalah mahasiswa tahun ke-2 yaitu 15/75
4. P(M3) atau peluang mahasiswa adalah mahasiswa tahun ke-3 yaitu 10/75
5. P(A|M1) atau peluang mahasiswa tahun ke-1 yang mendapatkan nilai A yaitu 10/50
6. P(A|M2) atau peluang mahasiswa tahun ke-2 yang mendapatkan nulai A yaitu 8/15
7. P(A|M3) atau peluang mahasiswa tahun ke-3 yang mendapatkan nulai A yaitu 5/10

a. Mendapatkan nilai A
P(A)= ∑ P(Mi)xP(A|Mi)
= (P(M1)xP(A|M1) + P(M2)xP(A|M2) + P(M3)xP(A|M3))
= (50/75X10/50 + 15/75X8/15 + 10/75X5/10)
= 23/75
= 0.3066666666666667

b. Mahasiswa tahun ke 1 bila diketauhi dia mendapatkan A
 P(M1|A) = (P(M1) x P(A|M1))/P(A)
= (50/75 x 10/50)/(23/75)
= 10/23
= 0.4347826086956522
"
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJlh.KeyPress, txtPM1.KeyPress, txtPM2.KeyPress, txtPM3.KeyPress, txtPAM1.KeyPress, txtPAM2.KeyPress, txtPAM3.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse e.KeyChar = "+" OrElse e.KeyChar = "-" OrElse e.KeyChar = "*" OrElse e.KeyChar = "/" OrElse e.KeyChar = Chr(8) Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If txtPM1.Text.Contains("/") Or txtPM2.Text.Contains("/") Or txtPM3.Text.Contains("/") Or txtPAM1.Text.Contains("/") Or txtPAM2.Text.Contains("/") Or txtPAM3.Text.Contains("/") Then
            MsgBox("Validasi Dahulu Nilai Di Textbox!")
        Else
            Hitung()
        End If
    End Sub

    Public Sub Hitung()
        jlh = txtJlh.Text
        pm1 = txtPM1.Text : pam1 = txtPAM1.Text
        pm2 = txtPM2.Text : pam2 = txtPAM2.Text
        pm3 = txtPM3.Text : pam3 = txtPAM3.Text
        txtHasilA.Text = (pm1 * pam1) + (pm2 * pam2) + (pm3 * pam3)
        a = txtHasilA.Text
        txtHasilB.Text = (pm1 * pam1) / a
    End Sub

End Class