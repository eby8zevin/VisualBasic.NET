Module Program  
  Sub Main()            
    Dim a, b As Integer
    
    a = 12
    b = 10
    
    Console.WriteLine("a {0}= {1}", Chr(9), a)
    Console.WriteLine("b {0}= {1}", Chr(9), b)
    
    Console.WriteLine()
    
    Console.WriteLine("a And b {0}= {1}", Chr(9), a And b)
    Console.WriteLine("a Or b {0}= {1}", Chr(9), a Or b)
    Console.WriteLine("a Xor b {0}= {1}", Chr(9), a Xor b)
    Console.WriteLine("Not a {0}= {1}", Chr(9), (Not a))
    Console.WriteLine("Not b {0}= {1}", Chr(9), (Not b))
        
    Console.ReadLine()
  End Sub
End Module
