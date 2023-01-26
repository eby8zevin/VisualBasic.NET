Module Program    
  Sub Main()
    Dim A() As Integer = {10,20,30,40,50}
    Dim B As String() = New String(2) {"satu","dua","tiga"}      
    
    'menampilkan elemen array A
    Console.WriteLine("Isi array A:")
    For Each elemen In A
      Console.WriteLine(elemen)      
    Next    
    
    Console.WriteLine()
    
    'menampilkan elemen array B
    Console.WriteLine("Isi array B:")
    For Each elemen In B
      Console.WriteLine(elemen)      
    Next
    
    Console.ReadLine()
  End Sub
End Module
