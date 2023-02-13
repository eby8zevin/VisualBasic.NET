Class Segiempat
  Private __panjang As Double
  Private __lebar As Double
  
  'konstruktor
  Public Sub New(ByVal p As Double, ByVal l As Double)
    __panjang = p
    __lebar = l
  End Sub
  
  'mendefinisikan properti Panjang
  Public Property Panjang() As Double
    Set
      __panjang = Value
    End Set
    Get
      Return __panjang
    End Get
  End Property
  
  'mendefinisikan properti Lebar
  Public Property Lebar() As Double
    Set
      __lebar = Value
    End Set
    Get
      Return __lebar
    End Get
  End Property
  
  'metode untuk menghitung luas
  Private Function HitungLuas() As Double
    Return __panjang * __lebar
  End Function
  
  'metode untuk mencetak data
  Public Sub CetakData()
    Console.WriteLine("panjang {0}= {1}", vbTab, __panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, __lebar)
  End Sub
  
  'metode untuk mencetak luas
  Public Sub CetakLuas()
    Console.WriteLine("Luas {0}= {1}", vbTab, HitungLuas())
  End Sub
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Dim se As Segiempat = New Segiempat(8,6)
    
    'menampilkan data dan luas segiempat
    Console.WriteLine("Keadaan awal:")
    se.CetakData()
    se.CetakLuas()
    
    'mengubah data melalui properti
    se.Panjang = 10
    se.Lebar = 5
    
    'menampilkan kembali data dan luas segiempat
    Console.WriteLine("{0}Keadaan akhir:", vbNewLine)
    Console.WriteLine("panjang {0}= {1}", vbTab, se.Panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, se.Lebar)
    Console.WriteLine("Luas {0}= {1}", vbTab, _
      se.Panjang * se.Lebar)
    
    Console.ReadLine()
  End Sub
End Module
