'struktur generik
Structure Titik (Of T)
  Private _x As T
  private _y As T
  
  'properti X
  Public Property X() As T
    Set
      _x = Value
    End Set
    Get
      Return _x
    End Get
  End Property
  
  Public Property Y() As T
    Set
      _y = Value
    End Set
    Get
      Return _y
    End Get
  End Property
  
  'metode untuk menampilkan nilai _x dan _y
  Public Sub CetakTitik()
    Console.WriteLine("({0},{1})", _x, _y)
  End Sub  
End Structure

Module Program  
  Sub Main()
    'membuat struktur dengan anggota
    'bertipe Integer
    Dim A As Titik(Of Integer) = _
      New Titik(Of Integer)()
    
    'membuat struktur dengan anggota
    'bertipe Double
    Dim B As Titik(Of Double) = _
      New Titik(Of Double)()
    
    'mengisi nilai ke dalam titik A
    A.X = 2
    A.Y = 3
    
    'mengisi nilai ke dalam titik B
    B.X = 4.0
    B.Y = 5.0
    
    'menampilkan nilai di dalam titik A dan B
    Console.Write("A")
    A.CetakTitik()
    Console.Write("B")
    B.CetakTitik()
    
    Console.ReadLine()
  End Sub
End Module
