Public Class MainForm

  Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
    Dim max As Integer = 100000
    Progress.Minimum = 0
    Progress.Maximum = max
    Progress.Step = 1

    lbGanjil.Items.Clear()
    lbGenap.Items.Clear()

    For i As Integer = 1 To max
      If (i Mod 2) <> 0 Then
        lbGanjil.Items.Add(i.ToString())
      Else
        lbGenap.Items.Add(i.ToString())
      End If
      Progress.Value = i
      'menjadikan dua proses dapat dijalankan 
      'secara simultan
      Application.DoEvents()
    Next
  End Sub
End Class
