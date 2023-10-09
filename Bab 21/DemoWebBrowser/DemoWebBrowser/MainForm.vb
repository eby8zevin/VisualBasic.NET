Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.AcceptButton = btnGo
  End Sub

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    WebBrowser1.GoBack()
  End Sub

  Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
    WebBrowser1.GoForward()
  End Sub

  Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
    Dim address As String = txtURL.Text
    'Dim URL As System.Uri = New System.Uri(address)
    'WebBrowser1.Navigate(URL)
    WebBrowser1.Navigate(address)
  End Sub

  Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    WebBrowser1.Stop()
  End Sub

  Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
    WebBrowser1.Refresh()
  End Sub
End Class
