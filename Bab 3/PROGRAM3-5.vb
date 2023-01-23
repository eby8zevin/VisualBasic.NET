Module Program  
  Sub Main()            
    Console.Write("a")
    Console.Write("{0}b", Chr(9))
    Console.Write("{0}a Xor b", Chr(9))    
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), True Xor True)
    Console.WriteLine()
    
    Console.Write("True")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), True Xor False)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}True", Chr(9))
    Console.Write("{0}{1}", Chr(9), False Xor True)
    Console.WriteLine()
    
    Console.Write("False")
    Console.Write("{0}False", Chr(9))
    Console.Write("{0}{1}", Chr(9), False Xor False)
    Console.WriteLine()      
    
    Console.ReadLine()
  End Sub
End Module
