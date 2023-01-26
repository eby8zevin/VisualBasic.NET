Module Program    
  Sub Main()
    Console.WriteLine("Pengulangan ke-1:")
    For i As Integer = 1 To 10 Step 1
      Console.Write("{0} ", i)
    Next i
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Pengulangan ke-2:")
    For i As Integer = 1 To 10
      Console.Write("{0} ", i)
    Next i
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Pengulangan ke-3:")
    For i = 1 To 10
      Console.Write("{0} ", i)
    Next
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Pengulangan ke-4:")
    For i = 1 To 10 Step 2
      Console.Write("{0} ", i)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
