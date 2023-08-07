Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cbOperasi.Items.Add("Tambah")
    cbOperasi.Items.Add("Kurang")
    cbOperasi.Items.Add("Kali")
    cbOperasi.Items.Add("Bagi")
    cbOperasi.SelectedIndex = 0
  End Sub

  Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
    Dim a As Decimal = NumericUpDown1.Value
    Dim b As Decimal = NumericUpDown2.Value
    Dim c As Decimal = 0

    Select Case cbOperasi.SelectedIndex
      Case 0
        c = a + b
      Case 1
        c = a - b
      Case 2
        c = a * b
      Case 3
        c = a / b
    End Select

    txtHasil.Text = c.ToString()

  End Sub
End Class
