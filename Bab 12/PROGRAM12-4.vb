Module Program  
  Sub Main()    
    
    Dim s1 As String = _
      New String(CType("Microsoft", Char()))
    Dim s2 As String = _
      New String(CType("Visual Basic .NET", Char()))
    
    Console.WriteLine(s1 & " " & s2)
            
    Console.ReadLine()
  End Sub
End Module
