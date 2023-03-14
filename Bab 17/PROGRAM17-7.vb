Class BilanganBulat
  Private data As Integer
  
  'konstruktor tanpa parameter
  'harus ada (meskipun tidak diimplementasi)
  Public Sub New()    
    'tidak ada implementasi
  End Sub
  
  'properti Nilai
  Public Property Nilai() As Integer
    Set
      data = Value
    End Set
    Get
      Return data
    End Get
  End Property
End Class

'kelas generik (contoh: Item Factory)
Class PembuatObjek (Of T As New)
  Public Shared Function BuatObjek() As T
    'New T() bisa bekerja karena
    'kita menyertakan constructor constraint
    Return New T()  'membuat objek dari T
  End Function
End Class

Module Program  
  Sub Main()
    'array dari tipe BilanganBulat sebanyak 5 elemen
    Dim daftar As BilanganBulat() = _
      New BilanganBulat(4) {}
    
    'membuat objek BilanganBulat dan
    'diisikan ke dalam array
    For i As Integer = 0 To daftar.Length-1    
      Dim obj As BilanganBulat
      obj = PembuatObjek(Of BilanganBulat).BuatObjek()
      obj.Nilai = (i+1) * 100
      'mengisi ke dalam array
      daftar(i) = obj
    Next
    
    'menampilkan nilai dari setiap objek BilanganBulat
    'yang tersimpan di dalam array
    Dim j As Integer = 0
    Console.WriteLine("Isi daftar: ")
    For Each obj As BilanganBulat in daftar
      Console.Write("Objek ke-{0} : ", j+1)
      Console.WriteLine(obj.Nilai)
      j += 1
    Next
    
    Console.ReadLine()
  End Sub
End Module
