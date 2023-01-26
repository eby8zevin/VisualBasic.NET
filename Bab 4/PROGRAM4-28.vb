Module Program    
  Sub Main()
    Dim x As Integer
    Dim y As Double
    Dim s As String
    
    While (True)
      Console.Write("Masukkan bilangan selain NOL: ")
      s = Console.ReadLine()
      x = Int32.Parse(s)
      
      If (x = 0) Then
        Continue While
      End If
      
      y = 1/x
      Console.WriteLine("1/{0} = {1}", x, y)
      Exit While
    End While      
    
    Console.ReadLine()
  End Sub
End Module
