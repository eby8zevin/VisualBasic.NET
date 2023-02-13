'mendefinisikan struktur
Structure Titik
  Private __x As Integer
  Private __y As Integer
  
  'salah, konstruktor default tidak dapat
  'didefinisikan di dalam struktur
  'Public Sub New()
  '  __x = 0
  '  __y = 0
  'End Sub
  
  'konstruktor dengan dua parameter
  Public Sub New(ByVal x As Integer, ByVal y As Integer)
    __x = x
    __y = y
  End Sub
  
  'properti X
  Public Property X() As Integer
    Set
      __x = Value
    End Set
    Get
      Return __x
    End Get
  End Property
  
  'properti Y
  Public Property Y() As Integer
    Set
      __y = Value
    End Set
    Get
      Return __y
    End Get
  End Property
  
  'metode untuk menampilkan nilai
  Public Sub CetakKoordinat(ByVal namaObjek As String)
    Console.WriteLine(namaObjek & "({0},{1})", __x, __y)
  End Sub
End Structure

Module Program
  Sub Main()    
    'membuat objek struktur dengan parameter
    Dim A As Titik = New Titik(5, 9)
    
    'menampilkan nilai awal
    Console.WriteLine("Sebelum diubah:")
    A.CetakKoordinat("A")
    
    'mengubah nilai A
    A.X = 10
    A.Y = 18
        
    'menampilkan nilai akhir
    Console.WriteLine("{0}Setelah diubah:", vbNewLine)
    A.CetakKoordinat("A")
    
    Console.ReadLine()
  End Sub
End Module
