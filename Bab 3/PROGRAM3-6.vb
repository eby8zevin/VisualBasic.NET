Module Program  
  Sub Main()            
    Dim x As Integer = 7
    Dim genap As Boolean
    
    genap = (x Mod 2 = 0)
    
    If Not genap Then
      Console.WriteLine("{0} adalah bilangan ganjil", x)
    Else
      Console.WriteLine("{0} adalah bilangan genap", x)
    End If
    
    Console.ReadLine()
  End Sub
End Module
