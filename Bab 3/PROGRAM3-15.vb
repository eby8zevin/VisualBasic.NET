Module Program  
  Sub Main()            
    Dim s1, s2, s3 As String
    
    s1 = "Visual Basic "        
    s2 = ".NET"      
    
    'menyambung String dengan String
    s3 = s1 & s2
    Console.WriteLine(s3)
    
    'menyambung String dengan numerik
    Console.WriteLine(s3 & " " & 2012)
        
    Console.ReadLine()
  End Sub
End Module
