Module Program  
  Sub Main()    
    
    Dim s1 As String = "Microsoft"
    Dim s2 As Char() = New Char(4) {}
    Dim s3 As Char() = New Char(3) {}
    
    s1.CopyTo(0, s2, 0, 5)
    s1.CopyTo(5, s3, 0, 4)
    
    'menampilkan string
    Console.WriteLine("s1 : ""{0}""", s1)
    Console.WriteLine("s2 : ""{0}""", New String(s2))   
    Console.WriteLine("s3 : ""{0}""", New String(s3))
    
    Console.ReadLine()
  End Sub
End Module
