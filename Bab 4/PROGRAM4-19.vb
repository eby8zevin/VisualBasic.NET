Module Program    
  Sub Main()
    Console.WriteLine("Pengulangan ke-1:")
    For i As Integer = 10 To 1 Step -1
      Console.Write("{0} ", i)
    Next i
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Pengulangan ke-2:")
    For i As Integer = 10 To 1 Step -2
      Console.Write("{0} ", i)
    Next i        
    
    Console.ReadLine()
  End Sub
End Module
