Public Class Form1

  Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
    'tanggal sekarang
    Dim now As DateTime = DateTime.Now

    'menghitung usia
    Dim usia As TimeSpan = now.Subtract(DateTimePicker1.Value)

    Dim s As String = Nothing
    s &= String.Format("Tanggal lahir{0}: ", vbTab) _
      & DateTimePicker1.Value.ToShortDateString()
    s &= String.Format("{0}Tanggal sekarang{1}: ", _
      vbNewLine, vbTab) _
      & now.ToShortDateString()
    s &= String.Format("{0}Umur Anda{1}: ", _
                       vbNewLine, vbTab) _
      & CType((usia.TotalDays) / 365, Integer).ToString()
    s &= " tahun"
    MessageBox.Show(s, "Informasi")

  End Sub
End Class
