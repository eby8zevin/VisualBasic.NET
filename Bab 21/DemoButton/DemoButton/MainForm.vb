Public Class MainForm

  Private Enum JenisOperasi
    tambah
    kurang
    kali
    bagi
  End Enum

  Private Function Hitung(op As JenisOperasi) As Double
    Dim a As Double = _
      Double.Parse(txtBilangan1.Text)
    Dim b As Double = _
      Double.Parse(txtBilangan2.Text)
    Dim c As Double = 0
    Select Case op
      Case JenisOperasi.tambah
        c = a + b
      Case JenisOperasi.kurang
        c = a - b
      Case JenisOperasi.kali
        c = a * b
      Case JenisOperasi.bagi
        c = a / b
    End Select
    Return c
  End Function

  Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    txtHasil.Text = Hitung(JenisOperasi.tambah).ToString()
  End Sub

  Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
    txtHasil.Text = Hitung(JenisOperasi.kurang).ToString()
  End Sub

  Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
    txtHasil.Text = Hitung(JenisOperasi.kali).ToString()
  End Sub

  Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
    txtHasil.Text = Hitung(JenisOperasi.bagi).ToString()
  End Sub
End Class
