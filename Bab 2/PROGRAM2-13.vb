Module Program
  Sub Main()    
    Dim heksa1 As Integer = &H4B
    Dim heksa2 As Integer = &HFF
    Dim oktal As Integer = &O377
    
    Console.WriteLine("&H4B {0}= {1}", Chr(9), heksa1)
    Console.WriteLine("&HFF {0}= {1}", Chr(9), heksa2)
    Console.WriteLine("&O377 {0}= {1}", Chr(9), oktal)    
        
    Console.ReadLine()
  End Sub
End Module
