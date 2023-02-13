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
    'membuat objek dari struktur Titik menggunakan New
    Dim A As Titik = New Titik()
    Dim B As Titik = New Titik()
    
    'mengisi nilai ke dalam A melalui properti
    A.X = 0
    A.Y = 0
    
    'mengisi nilai ke dalam B melalui properti
    B.X = 3
    B.Y = 5
        
    'menampilkan nilai    
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
    
    Console.ReadLine()
  End Sub
End Module
