'mendefinisikan struktur dengan nama Titik
Structure Titik
  Private __x As Integer
  Private __y As Integer
  
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
    'mendeklarasikan variabel bertipe struktur
    Dim A, B As Titik
    
    'membuat objek dari struktur
    A = New Titik()
    
    'mengisi nilai ke dalam A.X dan A.Y
    A.X = 4
    A.Y = 4
    
    'mengisi nilai A ke dalam B
    B = A
    
    'menampilkan nilai awal
    Console.WriteLine("Sebelum diubah:")
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
    
    'mengubah nilai A
    A.X = 8
    A.Y = 8
    
    'menampilkan nilai akhir
    Console.WriteLine("{0}Setelah diubah:", vbNewLine)
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
    
    Console.ReadLine()
  End Sub
End Module
