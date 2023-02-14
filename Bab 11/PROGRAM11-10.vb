'bagian struktur pertama
Partial Structure Titik
  Private __x As Integer
  Private __y As Integer
  
  'konstruktor
  Public Sub New(ByVal x As Integer, ByVal y As Integer)
    __x = x
    __y = y
  End Sub
End Structure

'bagian struktur kedua
Partial Structure Titik
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
  
  'metode yang mengembalikan nilai bertipe struktur
  Public Function Duplikat() As Titik
    Dim temp As Titik = New Titik(__x, __y)
    Return temp
  End Function  
End Structure

Module Program  
  Sub Main()    
    'membuat struktur Titik
    Dim A As Titik = New Titik(10, 5)
    
    'membuat salinan dari struktur A
    Dim B As Titik = A.Duplikat()
    
    'membuat struktur Titik
    Dim C As Titik = New Titik(20, 15)
        
    'menampilkan nilai
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
    C.CetakKoordinat("C")
        
    Console.ReadLine()
  End Sub
End Module
