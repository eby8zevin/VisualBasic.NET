'mendefinisikan struktur Segiempat
Structure Segiempat
  Private __panjang As Double
  Private __lebar As Double
  
  'konstruktor dengan satu parameter
  Public Sub New(ByVal s As Double)
    __panjang = s
    __lebar = s
  End Sub
  
  'konstruktor dengan dua parameter
  Public Sub New(ByVal p As Double, ByVal l As Double)
    __panjang = p
    __lebar = l
  End Sub
  
  'properti Panjang
  Public Property Panjang() As Double
    Set
      __panjang = Value
    End Set
    Get
      Return __panjang
    End Get
  End Property
  
  'properti Lebar
  Public Property Lebar() As Double
    Set
      __lebar = Value
    End Set
    Get
      Return __lebar
    End Get
  End Property
  
  Private Function HitungLuas() As Double
    Return __panjang * __lebar
  End Function
  
  Public Sub CetakLuas()
    Console.WriteLine("Luas {0}= {1}", vbTab, HitungLuas())
  End Sub
    
  Public Sub CetakData(ByVal namaObjek As String)
    Console.WriteLine("Data {0}:", namaObjek)
    Console.WriteLine("panjang {0}= {1}", vbTab, __panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, __lebar)
  End Sub
End Structure

Module Program
  Sub Main()    
    'membuat objek struktur dengan satu parameter
    Dim A As Segiempat = New Segiempat(4)
    
    'membuat objek struktur dengan satu parameter
    Dim B As Segiempat = New Segiempat(10, 5)
    
    'menampilkan nilai
    A.CetakData("A")
    A.CetakLuas()
    Console.WriteLine()
    B.CetakData("B")
    B.CetakLuas()
        
    Console.ReadLine()
  End Sub
End Module
