Public Class MainForm
  Private warnaStandar As System.Drawing.Color

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    warnaStandar = Me.BackColor
  End Sub

  Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbStandar.CheckedChanged, rbMerah.CheckedChanged, rbHijau.CheckedChanged, rbBiru.CheckedChanged
    Dim rbAktif As RadioButton = CType(sender, RadioButton)
    If rbAktif Is rbStandar Then
      Me.BackColor = warnaStandar
    ElseIf rbAktif Is rbMerah Then
      Me.BackColor = System.Drawing.Color.Red
    ElseIf rbAktif Is rbHijau Then
      Me.BackColor = System.Drawing.Color.Green
    Else
      Me.BackColor = System.Drawing.Color.Blue
    End If
  End Sub

End Class
