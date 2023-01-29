Module Program        
  Sub Main()
    Dim A As Array
    
    A = Array.CreateInstance(GetType(Integer), 5)
        
    A(0) = 10
    A(1) = 20
    A(2) = 30
    A(3) = 40
    A(4) = 50
    
    Console.WriteLine("Jumlah elemen: {0}", A.Length)
    Console.WriteLine("Isi array A:")
    For Each elemen In A
      Console.WriteLine(elemen)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
