Module Program  
  Sub Main()            
    Console.Write("a")
    Console.Write("{0}b", Chr(9))
    Console.Write("{0}a Or b", Chr(9))
    Console.Write("{0}a OrElse b", Chr(9))
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), True Or True)
    Console.Write("{0}{1}", Chr(9), True OrElse True)
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), True Or False)
    Console.Write("{0}{1}", Chr(9), True OrElse False)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), False Or True)
    Console.Write("{0}{1}", Chr(9), False OrElse True)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), False Or False)
    Console.Write("{0}{1}", Chr(9), False OrElse False)
    Console.WriteLine()      
    
    Console.ReadLine()
  End Sub
End Module
