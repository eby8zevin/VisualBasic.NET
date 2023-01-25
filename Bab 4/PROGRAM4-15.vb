Module Program    
  Sub Main()    
    Dim i As Integer
    
    Console.WriteLine("Do While...Loop:")
    i = 1    
    Do While (i <= 5)
      Console.Write("{0} ", i * 100)
      i += 1
    Loop
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Do Until...Loop:")
    i = 1    
    Do Until (i > 5)
      Console.Write("{0} ", i * 100)
      i += 1
    Loop
    
    Console.ReadLine()
  End Sub
End Module
