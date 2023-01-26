Module Program    
  Sub Main()
    Dim n, jumlah As Integer
    Dim s As String
    
    Console.Write("Masukkan jumlah data: ")
    s = Console.ReadLine()
    n = Int32.Parse(s)
    
    jumlah = 0
    For i As Integer = 1 To n
      Console.Write("Data ke-{0}: ", i)
      s = Console.ReadLine()
      Dim data As Integer = Int32.Parse(s)
      jumlah += data
    Next
    
    Console.WriteLine()
    Console.WriteLine("Rata-rata = {0}", jumlah/n)
    
    Console.ReadLine()
  End Sub
End Module
