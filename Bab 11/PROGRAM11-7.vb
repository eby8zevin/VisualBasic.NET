Structure Titik
  Private __x As Integer
  Private __y As Integer
  
  'konstruktor
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
  'metode di dalam modul yang menggunakan parameter
  'bertipe struktur
  Sub TukarTitik(t1 As Titik, t2 As Titik)
    Dim tempx As Integer = t1.X
    Dim tempy As Integer = t1.Y
    
    t1.X = t2.X
    t1.Y = t2.Y
    
    t2.X = tempx
    t2.Y = tempy
  End Sub
  
  Sub Main()    
    'membuat dua objek struktur Titik
    Dim A As Titik = New Titik(10, 5)
    Dim B As Titik = New Titik(20, 15)
    
    'menampilkan nilai
    Console.WriteLine("Keadaan awal:")
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
    
    'menukar struktur A dan B
    TukarTitik(A, B)
    
    'menampilkan nilai
    Console.WriteLine("{0}Keadaan akhir:", vbNewLine)
    A.CetakKoordinat("A")
    B.CetakKoordinat("B")
        
    Console.ReadLine()
  End Sub
End Module
