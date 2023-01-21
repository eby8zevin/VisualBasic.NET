Module Program  
  Sub Main()            
    Console.Write("a")
    Console.Write("{0}b", Chr(9))
    Console.Write("{0}a And b", Chr(9))
    Console.Write("{0}a AndAlso b", Chr(9))
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), True And True)
    Console.Write("{0}{1}", Chr(9), True AndAlso True)
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), True And False)
    Console.Write("{0}{1}", Chr(9), True AndAlso False)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), False And True)
    Console.Write("{0}{1}", Chr(9), False AndAlso True)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), False And False)
    Console.Write("{0}{1}", Chr(9), False AndAlso False)
    Console.WriteLine()      
    
    Console.ReadLine()
  End Sub
End Module
