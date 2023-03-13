Class MyArray (Of T)
  'data bertipe array dari tipe generik
  Private __data As T()
  Private __length As Integer
  
  'konstruktor
  Public Sub New (data As T())
    __data = data
    __length = __data.Length
  End Sub
  
  'properti Length (bersifat read-only)
  'untuk mengetahui jumlah elemen array
  Public ReadOnly Property Length() As Integer
    Get
      Return __length
    End Get
  End Property
  
  'metode untuk mencari indeks array
  'berdasarkan nilai yang dimasukkan
  Public Function IndexOf(val As T) As Integer
    Dim index As Integer = -1 'jika tidak ditemukan
    For i As Integer = 0 To __length-1
      'Hati-hati! Operator relasional sama dengan (=)
      'tidak dapat diterapkan ke tipe generik.
      'If __data(i) = val Then  ' SALAH
      If __data(i).Equals(val) Then
        index = i
        'jika sudah ditemukan, pengulangan dihentikan
        Exit For
      End If
    Next
    Return index
  End Function
  
  'metode untuk mencari nilai elemen array
  'berdasarkan indeks yang dimasukkan
  Public Function ValueOf(ByVal index As Integer) As T
    Return __data(index)
  End Function
  
  'mengubah nilai elemen array
  'pada indeks tertentu
  Public Sub SetValue(ByVal index As Integer, val As T)
    __data(index) = val
  End Sub
  
  'metode untuk menyalin isi array
  'ke array lain
  Public Sub CopyTo(ByRef array As T())
    For i As Integer = 0 To __length-1    
      array(i) = __data(i)
    Next
  End Sub
  
  'metode untuk menampilkan isi array
  Public Sub PrintArray()
    Dim s As System.Text.StringBuilder = _
      New System.Text.StringBuilder()
    For Each val As T in __data
      s.Append(val.ToString() & ",")
    Next
    'menghilangkan karakter koma terakhir
    s.Remove(s.Length-1, 1)
    Console.WriteLine(s)
  End Sub
End Class

Module Program  
  Sub Main()
    'array dari tipe Integer
    Dim A As Integer() = New Integer (4) _
      {100, 200, 300, 400, 500}
    
    'membuat objek dari kelas MyArray
    'dengan data bertipe Integer
    Dim obj1 As MyArray(Of Integer) = _
      New MyArray(Of Integer)(A)
    
    'menampikan isi array A
    Console.WriteLine("Array A: ")
    obj1.PrintArray()
    Console.WriteLine()
    
    'menampilkan informasi tentang array A
    Console.WriteLine("obj1.IndexOf(400) {0}: {1}", _ 
       vbTab, obj1.IndexOf(400))
    Console.WriteLine("obj1.ValueOf(2) {0}: {1}", _ 
       vbTab, obj1.ValueOf(2))

    'mengubah nilai array pada indeks ke-2
    obj1.SetValue(2,700)
    Console.WriteLine("{0}Setelah array A diubah: ", _
      vbNewLine)
    obj1.PrintArray()
    
    'array dari tipe Char
    Dim B As Char() = New Char(4) _
      {"a"c,"i"c,"u"c,"e"c,"o"c}
    
    'membuat objek dari kelas MyArray
    'dengan data bertipe Char
    Dim obj2 As MyArray(Of Char) = _
      New MyArray(Of Char)(B)
    
    'menampilkan isi array B
    Console.WriteLine("{0}Array B: ", _
      vbNewLine)
    obj2.PrintArray()
    
    'array dari tipe String
    Dim C As String() = New String(5) _
      {"C","C++","Java","C#","Python","Ruby"}
    
    'membuat objek dari kelas MyArray
    'dengan data bertipe String
    Dim obj3 As MyArray(Of String) = _
      New MyArray(Of String)(C)
    
    'menampilkan isi array C
    Console.WriteLine("{0}Array C: ", _
      vbNewLine)
    obj3.PrintArray()
    
    'menyalin array C ke D
    Dim D As String() = New String(5) {}
    obj3.CopyTo(D)
    
    'membuat objek dari kelas MyArray
    'dengan melewatkan D sebagai parameternya
    Dim obj4 As MyArray(Of String) = _
      New MyArray(Of String)(D)
    
    'menampilkan isi array D
    Console.WriteLine("{0}Array D: ", _
      vbNewLine)
    obj3.PrintArray()
    
    Console.ReadLine()
  End Sub
End Module
