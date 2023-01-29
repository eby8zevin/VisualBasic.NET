Module Program        
  Sub Main()
    Dim A As Array = {10,20,30,40,50}
    
    'menampilkan array sebelum dibalik
    Console.Write("Sebelum dibalik: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
    
    'membalik urutan array
    Array.Reverse(A)
    
    'menampilkan array setelah dibalik
    Console.Write("Setelah dibalik: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
