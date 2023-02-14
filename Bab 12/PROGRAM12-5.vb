Module Program  
  Sub Main()    
    Dim s As String = "VB.NET"
    
    For i=0 To s.Length-1
      'mengakses karakter di dalam string melalui indeks
      Console.WriteLine(s(i))
    Next
            
    Console.ReadLine()
  End Sub
End Module
