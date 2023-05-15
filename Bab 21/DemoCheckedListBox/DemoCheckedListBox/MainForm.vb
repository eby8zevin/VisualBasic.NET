Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'mengisi elemen ke dalam CheckedListBox
    clbBahasa.Items.Add("C")
    clbBahasa.Items.Add("C++")
    clbBahasa.Items.Add("C#")
    clbBahasa.Items.Add("D")
    clbBahasa.Items.Add("Java")
    clbBahasa.Items.Add("Scala")
    clbBahasa.Items.Add("Ruby")
    clbBahasa.Items.Add("Perl")
    clbBahasa.Items.Add("PHP")
    clbBahasa.Items.Add("Python")
  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    Dim str As String = Nothing
    'memperoleh daftar item yang dipilih oleh user
    For Each indeks As Integer In clbBahasa.CheckedIndices
      Dim item As String = clbBahasa.Items(indeks).ToString()
      str &= vbNewLine & item
    Next
    MessageBox.Show("Anda memilih bahasa:" & str)

    'Dim str As String = Nothing
    'memperoleh daftar item yang dipilih oleh user
    'For Each item As String In clbBahasa.CheckedItems
    'Str &= vbNewLine & item
    'Next
    'MessageBox.Show("Anda memilih bahasa:" & Str)
  End Sub
End Class
