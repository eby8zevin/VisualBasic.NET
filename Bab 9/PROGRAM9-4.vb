Class Titik
  'auto-implemented property
  Public Property X As Integer
  Public Property Y As Integer
    
  Public Sub CetakData(ByVal s As String)
    'memanggil properti X dan Y dari dalam kelas Titik
    Console.WriteLine("{0}({1},{2})", s, X, Y)
  End Sub
End Class

Module Program
  Sub Main()
    'membuat objek pertama dari kelas Titik
    Dim A As Titik = New Titik()
    'mengisi nilai properti
    A.X = 5
    A.Y = 4
    'menampilkan nilai properti
    A.CetakData("A")
    
    'membuat objek pertama dari kelas Titik
    Dim B As Titik = New Titik()
    'mengisi nilai properti
    B.X = 6
    B.Y = 10
    'menampilkan nilai properti
    B.CetakData("B")
    
    Console.ReadLine()
  End Sub
End Module
