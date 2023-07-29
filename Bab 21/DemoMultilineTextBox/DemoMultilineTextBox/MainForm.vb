Public Class MainForm

  Private Sub KosongkanTeks()
    txtID.Clear()
    txtNama.Clear()
    txtHarga.Clear()
    txtKeterangan.Clear()
  End Sub

  Private Sub MatikanKontrol()
    KosongkanTeks()
    txtID.Enabled = False
    txtNama.Enabled = False
    txtHarga.Enabled = False
    txtKeterangan.Enabled = False
  End Sub

  Private Sub HidupkanKontrol()
    KosongkanTeks()
    txtID.Enabled = True
    txtNama.Enabled = True
    txtHarga.Enabled = True
    txtKeterangan.Enabled = True
    txtID.Focus()
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'saat pertama tampil, semua kontrol TextBox tidak aktif
    MatikanKontrol()
  End Sub

  Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    btnTambah.Enabled = False
    HidupkanKontrol()
    btnSimpan.Enabled = True
  End Sub

  Private Sub SimpanKeFile(namaFile As String)
    'parameter kedua bernilai True (append)
    Dim file As System.IO.StreamWriter = _
      New System.IO.StreamWriter(namaFile, True)
    file.WriteLine("{0};{1};{2};{3}", _
                   txtID.Text, _
                   txtNama.Text, _
                   txtHarga.Text, _
                   txtKeterangan.Text)
    file.Close()
  End Sub

  Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    btnSimpan.Enabled = False
    'misalnya disimpan ke file produk.txt
    'yang berada satu direktori dengan program
    SimpanKeFile("produk.txt")
    MatikanKontrol()
    btnTambah.Enabled = True
  End Sub

End Class
