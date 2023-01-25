Module Program    
  Sub Main()    
    Dim n, i As Integer
    Dim faktorial As Long = 1
    Dim s As String
    
    Console.Write("Masukkan bilangan bulat positif: ")
    s = Console.ReadLine()
    n = Int32.Parse(s)
    
    If (n > 1) Then    
      i = n
      While (i >= 1)
        faktorial = faktorial * i
        i -= 1
      End While
    End If      
    
    Console.WriteLine("{0}! = {1}", n, faktorial)
    
    Console.ReadLine()
  End Sub
End Module
