Module Program        
  Sub Main()
    Dim A As Array = {30,10,50,40,20}
    
    'menampilkan array sebelum diurutkan
    Console.Write("Sebelum diurutkan: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
    
    'mengurutkan array
    Array.Sort(A)
    
    'menampilkan array setelah diurutkan
    Console.Write("Setelah diurutkan: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
