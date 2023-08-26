Public Class Form1

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PictureBox1.ImageLocation = "D:\images\Penguins.jpg"
    PictureBox1.Load()
  End Sub

  Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    If CheckBox1.Checked Then
      PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    Else
      PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    End If
  End Sub
End Class
