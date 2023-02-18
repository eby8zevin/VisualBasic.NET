Module Program  
  Sub Main()    
    
    Dim s1 As String = "Microsoft"
    Dim s2 As String = s1.Substring(0, 5)
    Dim s3 As String = s1.Substring(5, 4)
    
    'menampilkan string
    Console.WriteLine("s1 : ""{0}""", s1)
    Console.WriteLine("s2 : ""{0}""", s2)   
    Console.WriteLine("s3 : ""{0}""", s3)
    
    Console.ReadLine()
  End Sub
End Module
