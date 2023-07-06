Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim col1 As ColumnHeader = New ColumnHeader()
    col1.Text = "ISBN"
    col1.Width = 100
    Dim col2 As ColumnHeader = New ColumnHeader()
    col2.Text = "Judul"
    col2.Width = 210
    Dim col3 As ColumnHeader = New ColumnHeader()
    col3.Text = "Penulis"
    col3.Width = 100
    ListView1.Columns.Add(col1)
    ListView1.Columns.Add(col2)
    ListView1.Columns.Add(col3)
    Me.AcceptButton = btnTambah
  End Sub

  Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    Dim item As ListViewItem = New ListViewItem()
    item.Text = txtISBN.Text
    item.SubItems.Add(txtJudul.Text)
    item.SubItems.Add(txtPenulis.Text)
    ListView1.Items.Add(item)
    txtISBN.Clear()
    txtJudul.Clear()
    txtPenulis.Clear()
    txtISBN.Focus()
  End Sub

  Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    Dim koleksiIndeks As ListView.SelectedIndexCollection = _
      ListView1.SelectedIndices
    For Each indeks As Integer In koleksiIndeks
      ListView1.Items.RemoveAt(indeks)
    Next
  End Sub

  Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    Dim koleksiItem As ListView.SelectedListViewItemCollection = _
      ListView1.SelectedItems
    For Each item As ListViewItem In koleksiItem
      txtISBN.Text = item.Text
      txtJudul.Text = item.SubItems(1).Text
      txtPenulis.Text = item.SubItems(2).Text
    Next
  End Sub
End Class
