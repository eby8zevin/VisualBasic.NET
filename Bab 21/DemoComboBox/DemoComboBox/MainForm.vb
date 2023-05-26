Public Class MainForm

  Private Sub SetFont(nama As String, ukuran As Integer)
    labelContoh.Font = New Font(nama, ukuran)
  End Sub

  Private Sub ChangeFont()
    Dim nama As String = CType(cbJenis.SelectedItem, String)
    Dim ukuran As Integer = _
      Convert.ToInt32(CType(cbUkuran.SelectedItem, String))
    If ukuran <> 0 Then
      SetFont(nama, ukuran)
    End If
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'memperoleh semua font yang ter-install
    'dan menempatkannya ke dalam ComboBox pertama
    Dim fonts As System.Drawing.Text.InstalledFontCollection = _
      New System.Drawing.Text.InstalledFontCollection()
    For Each family As System.Drawing.FontFamily _
      In fonts.Families
      cbJenis.Items.Add(family.Name)
    Next
    'memasukkan elemen-elemen ke dalam ComboBox kedua
    For i As Integer = 8 To 30 Step 2
      cbUkuran.Items.Add(i.ToString())
    Next
    'mengaktifkan elemen/item ketiga
    cbJenis.SelectedIndex = 2
    cbUkuran.SelectedIndex = 2
    'mengubah font
    ChangeFont()
  End Sub

  Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
    ChangeFont()
  End Sub

  Private Sub cbUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUkuran.SelectedIndexChanged
    ChangeFont()
  End Sub
End Class
