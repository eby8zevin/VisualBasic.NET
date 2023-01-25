Module Program    
  Sub Main()    
    Dim n, i As Integer
    Dim faktorial As Long = 1
    Dim s As String
    
    Console.Write("Masukkan bilangan bulat positif: ")
    s = Console.ReadLine()
    n = Int32.Parse(s)
    
    Console.Write("{0}! = ", n)
    
    If (n > 1) Then    
      i = n
      While (i >= 1)
        If (i <> 1) Then
          Console.Write("{0} x ", i)  
        Else
          Console.Write("{0} = ", i)
        End If
        faktorial = faktorial * i
        i -= 1
      End While
    End If      
    
    Console.WriteLine(faktorial)
    
    Console.ReadLine()
  End Sub
End Module
