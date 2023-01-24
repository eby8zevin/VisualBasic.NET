Module Program  
  Sub Main()            
    Dim x As Integer
    Dim s As String
    
    Console.Write("Masukkan bilangan bulat: ")
    s = Console.ReadLine()
    
    x = Int32.Parse(s)
    
    If (x < 0) Then
      Console.WriteLine("{0} " _
        & "adalah bilangan negatif", x)
    ElseIf (x = 0) Then
      Console.WriteLine("Anda memasukkan nilai NOL")
    Else
      Console.WriteLine("{0} " _
        & "adalah bilangan positif", x)
    End If        
    
    Console.ReadLine()
  End Sub
End Module
