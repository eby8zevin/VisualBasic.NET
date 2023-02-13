Class Titik
  'properti statis  
  Public Shared Property X As Integer
  Public Shared Property Y As Integer
    
  Public Sub CetakData(ByVal s As String)
    'memanggil properti X dan Y dari dalam kelas Titik
    Console.WriteLine("{0}({1},{2})", s, X, Y)
  End Sub
End Class

Module Program
  Sub Main()
    'mengisi nilai properti melalui nama kelas
    Titik.X = 5
    Titik.Y = 4
    
    'membuat objek pertama dari kelas Titik
    Dim A As Titik = New Titik()
    
    'menampilkan nilai properti pada objek A
    A.CetakData("A")
    
    'membuat objek kedua dari kelas Titik
    Dim B As Titik = New Titik()
    
    'menampilkan nilai properti pada objek B
    B.CetakData("B")
    
    Console.ReadLine()
  End Sub
End Module
