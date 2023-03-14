Interface IBisaDihitung
  Function Tambah(ByVal nilai As Double) _
    As Double
  Function Kurang(ByVal nilai As Double) _
    As Double
  Function Kali(ByVal nilai As Double) _
    As Double
  Function Bagi(ByVal nilai As Double) _
    As Double  
End Interface

Class BilanganBulat: Implements IBisaDihitung
  Private data As Integer
  
  'konstruktor
  Public Sub New(ByVal data As Integer)
    Me.data = data
  End Sub
  
  'mengimplementasikan metode Tambah()
  Public Function Tambah(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Tambah
    Return CType(data + nilai, Double)
  End Function
  
  'mengimplementasikan metode Kurang()
  Public Function Kurang(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Kurang
    Return CType(data - nilai, Double)
  End Function
  
  'mengimplementasikan metode Kali()
  Public Function Kali(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Kali
    Return CType(data * nilai, Double)
  End Function
  
  'mengimplementasikan metode Bagi()
  Public Function Bagi(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Bagi
    Return CType(data / nilai, Double)
  End Function  
End Class

Class BilanganRiil: Implements IBisaDihitung
  Private data As Double
  
  'konstruktor
  Public Sub New(ByVal data As Double)
    Me.data = data
  End Sub
  
  'mengimplementasikan metode Tambah()
  Public Function Tambah(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Tambah
    Return data + nilai
  End Function
  
  'mengimplementasikan metode Kurang()
  Public Function Kurang(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Kurang
    Return data - nilai
  End Function
  
  'mengimplementasikan metode Kali()
  Public Function Kali(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Kali
    Return data * nilai
  End Function
  
  'mengimplementasikan metode Bagi()
  Public Function Bagi(ByVal nilai As Double) _
    As Double _
    Implements IBisaDihitung.Bagi
    Return data / nilai
  End Function  
End Class

'kelas Karakter tidak mengimplementasikan
'interface IBisaDihitung
Class Karakter
  Private data As Char
  
  'konstruktor
  Public Sub New(ByVal data As Char)
    Me.data = data
  End Sub    
End Class

'kelas generik
Class DaftarBilangan (Of T As IBisaDihitung)
  Private daftar As T()
  Private ukuran As Integer
  
  'konstruktor
  Public Sub New(ByVal ukuran As Integer)    
    daftar = New T(ukuran-1) {}
    Me.ukuran = ukuran
  End Sub
  
  Public Sub IsiBilangan(ByVal indeks As Integer, _
                         ByVal nilai As T)
    If indeks >= ukuran Then
      Console.WriteLine("Indeks terlalu besar")
      End
    ElseIf indeks < 0 Then
      Console.WriteLine("Indeks tidak boleh negatif")
      End
    End If
    daftar(indeks) = nilai
  End Sub
  
  Public Function AmbilBilangan( _
    ByVal indeks As Integer) As T
    If indeks < 0 Or indeks >= ukuran Then
      Console.WriteLine("Indeks di luar rentang")
      End
    End If
    Return daftar(indeks)
  End Function  
End Class

Module Program  
  Sub Main()
    'membuat daftar bilangan bulat
    'dengan ukuran 5 elemen
    Dim daftar As DaftarBilangan(Of BilanganBulat) = _
      New DaftarBilangan(Of BilanganBulat)(5)
    
    'mengisi 5 nilai ke dalam daftar
    daftar.IsiBilangan(0, new BilanganBulat(10))
    daftar.IsiBilangan(1, new BilanganBulat(20))
    daftar.IsiBilangan(2, new BilanganBulat(30))
    daftar.IsiBilangan(3, new BilanganBulat(40))
    daftar.IsiBilangan(4, new BilanganBulat(50))
    
    'mengalikan setiap elemen di dalam daftar
    'dengan nilai 10 dan menampilkannya ke layar
    For i As Integer = 0 To 4    
      Console.WriteLine( _
        daftar.AmbilBilangan(i).Kali(10))
    Next
    
    Console.ReadLine()
  End Sub
End Module
