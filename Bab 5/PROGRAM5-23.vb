Module Program        
  Sub Main()
    Dim A As Array
    
    A = Array.CreateInstance(GetType(Integer), 5)
        
    A.SetValue(10, 0)
    A.SetValue(20, 1)
    A.SetValue(30, 2)
    A.SetValue(40, 3)
    A.SetValue(50, 4)
    
    Console.WriteLine("Jumlah elemen: {0}", A.Length)
    Console.WriteLine("Isi array A:")
    For i=A.GetLowerBound(0) To A.GetUpperBound(0)
      Console.WriteLine(A.GetValue(i))
    Next
    
    Console.ReadLine()
  End Sub
End Module
