Class Segiempat
  Private __panjang As Double
  Private __lebar As Double
  
  'konstruktor
  Public Sub New(ByVal p As Double, ByVal l As Double)
    __panjang = p
    __lebar = l
  End Sub
  
  'properti write-only (hanya dapat ditulis)
  Public WriteOnly Property Panjang() As Double
    Set
      __panjang = Value
    End Set    
  End Property
  
  'properti write-only
  Public WriteOnly Property Lebar() As Double
    Set
      __lebar = Value
    End Set    
  End Property
  
  'metode untuk menghitung luas
  Private Function HitungLuas() As Double
    Return __panjang * __lebar
  End Function
  
  'properti read-only (hanya dapat dibaca)
  Public ReadOnly Property Luas() As Double
    Get
      Return HitungLuas()
    End Get    
  End Property
  
  'metode untuk mencetak data
  Public Sub CetakData()
    Console.WriteLine("panjang {0}= {1}", vbTab, __panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, __lebar)
  End Sub
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Dim se As Segiempat = New Segiempat(8,6)
    
    'menampilkan data dan luas segiempat
    Console.WriteLine("Keadaan awal:")
    se.CetakData()
    'mengakses properti read-only
    Console.WriteLine("Luas {0}= {1}", vbTab, se.Luas)
    
    'mengubah data melalui properti
    se.Panjang = 10
    se.Lebar = 5
    
    'baris kode di bawah ini salah
    'karena Luas adalah properti read-only
    'se.Luas = 50   'salah
    
    'menampilkan kembali data dan luas segiempat
    Console.WriteLine("{0}Keadaan akhir:", vbNewLine)
    se.CetakData()    
    Console.WriteLine("Luas {0}= {1}", vbTab, se.Luas)
    
    'dua baris kode di bawah ini salah
    'karena Panjang dan Lebar merupakan properti write-only
    'Console.WriteLine("panjang {0}= {1}", vbTab, se.Panjang)
    'Console.WriteLine("lebar {0}= {1}", vbTab, se.Lebar)
    
    Console.ReadLine()
  End Sub
End Module
