Module Program  
  Sub Main()            
    Dim s1, s2 As String
    
    's1 menunjuk ke alamat memori tertentu
    s1 = "Visual Basic"
    
    's2 menunjuk ke alamat memori
    'yang lain
    s2 = ".NET Framework"
        
    If (s2 IsNot s1) Then
      Console.WriteLine("s2 dan s1 tidak menunjuk " _
        & "ke objek yang sama")
    Else
      Console.WriteLine("s2 dan s1 menunjuk " _
        & "ke objek yang sama")
    End If
            
    Console.ReadLine()
  End Sub
End Module
