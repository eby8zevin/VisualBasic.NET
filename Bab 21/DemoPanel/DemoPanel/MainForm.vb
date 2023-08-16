Public Class MainForm

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    WebBrowser1.Navigate(txtURL.Text)
  End Sub

  Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
    Application.DoEvents()
    ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress)
    If e.CurrentProgress > 0 And _
        e.CurrentProgress < e.MaximumProgress Then
      ProgressBar1.Value = Convert.ToInt32(e.CurrentProgress)
    Else
      ProgressBar1.Value = ProgressBar1.Minimum
    End If
  End Sub
End Class
