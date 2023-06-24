Public Class MainForm

  Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    If txtItem.Text.Length > 0 Then
      lbKiri.Items.Add(txtItem.Text)
      txtItem.Clear()
      txtItem.Focus()
    Else
      MessageBox.Show("Elemen baru tidak boleh kosong", _
                      "Kesalahan", _
                      MessageBoxButtons.OK, _
                      MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnPindahKeKanan_Click(sender As Object, e As EventArgs) Handles btnPindahKeKanan.Click
    Dim indeksAktif As Integer = lbKiri.SelectedIndex
    If indeksAktif >= 0 Then
      lbKanan.Items.Add(CType(lbKiri.SelectedItem, String))
      lbKiri.Items.RemoveAt(indeksAktif)
    End If
  End Sub

  Private Sub btnPindahSemuaKeKanan_Click(sender As Object, e As EventArgs) Handles btnPindahSemuaKeKanan.Click
    For Each elemen As String In lbKiri.Items
      lbKanan.Items.Add(elemen)
    Next
    lbKiri.Items.Clear()
  End Sub

  Private Sub btnPindahKeKiri_Click(sender As Object, e As EventArgs) Handles btnPindahKeKiri.Click
    Dim indeksAktif As Integer = lbKanan.SelectedIndex
    If indeksAktif >= 0 Then
      lbKiri.Items.Add(CType(lbKanan.SelectedItem, String))
      lbKanan.Items.RemoveAt(indeksAktif)
    End If
  End Sub

  Private Sub btnPindahSemuaKeKiri_Click(sender As Object, e As EventArgs) Handles btnPindahSemuaKeKiri.Click
    For Each elemen As String In lbKanan.Items
      lbKiri.Items.Add(elemen)
    Next
    lbKanan.Items.Clear()
  End Sub
End Class
