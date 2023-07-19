Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    mtbNIP.Mask = "LLL-000"
    mtbNama.Mask = "?????????????????????????"
    mtbTglLahir.Mask = "00/00/0000"
    mtbJenisKelamin.Mask = "&"
    mtbTinggiBadan.Mask = "000"
    mtbNoTelepon.Mask = "(9999) 000-0000"
  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    Dim s As String = ""
    s &= String.Format("NIP{0}{1}: ", vbTab, vbTab) _
      & mtbNIP.Text
    s &= String.Format("{0}Nama{1}{2}: ", vbNewLine, vbTab, vbTab) _
      & mtbNama.Text
    s &= String.Format("{0}Tgl. Lahir{1}{2}: ", vbNewLine, vbTab, vbTab) _
      & mtbTglLahir.Text
    s &= String.Format("{0}Jenis Kelamin{1}: ", vbNewLine, vbTab) _
      & mtbJenisKelamin.Text
    s &= String.Format("{0}Tinggi Badan{1}: ", vbNewLine, vbTab) _
      & mtbTinggiBadan.Text
    s &= String.Format("{0}No. Telepon{1}: ", vbNewLine, vbTab) _
      & mtbNoTelepon.Text
    MessageBox.Show(s, "Informasi")
  End Sub

End Class
