Module Program  
  Sub Main()            
    Dim x As Integer
    Dim s As String
      
    Console.Write("Masukkan bilangan bulat: ")
    s = Console.ReadLine()
    
    x = Int32.Parse(s)
    
    Select x
      Case Is < 0: 
        Console.WriteLine("{0} adalah " _
          & "bilangan negatif", x)
      Case Is > 0: 
        Console.WriteLine("{0} adalah " _
          & "bilangan positif", x)
      Case Else
        Console.WriteLine("Anda memasukkan " _
          & "bilangan NOL")
    End Select
    
    Console.ReadLine()
  End Sub
End Module
