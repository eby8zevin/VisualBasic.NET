Module Program    
  Sub Main()
    'array dengan elemen bertipe objek
    'dari kelas String
    Dim produk() As String = {"VB.NET","C#","C++/CLI","F#"}
    
    Console.WriteLine("Produk Microsoft:")
    For Each elemen In produk
      Console.WriteLine(elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
