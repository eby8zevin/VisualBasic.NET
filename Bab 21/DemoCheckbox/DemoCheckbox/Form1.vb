Public Class Form1

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    Dim hobi As String = "Hobi:"

    If cbxOlahraga.Checked Then
      hobi += vbNewLine + cbxOlahraga.Text
    End If
    If cbxMembaca.Checked Then
      hobi += vbNewLine + cbxMembaca.Text
    End If
    If cbxTamasya.Checked Then
      hobi += vbNewLine + cbxTamasya.Text
    End If
    If cbxLain.Checked Then
      hobi += vbNewLine + cbxLain.Text
    End If

    MessageBox.Show(hobi)
  End Sub
End Class
