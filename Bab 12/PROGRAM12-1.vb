Module Program  
  Sub Main()    
    Dim s As String = "Pemrograman Visual Basic .NET"
    
    'mengakses properti Length
    Dim n As Integer = s.Length
    Console.WriteLine(n)

    'memanggil metode
    Console.WriteLine(s.ToUpper())
    Console.WriteLine(s.Substring(12,17))
            
    Console.ReadLine()
  End Sub
End Module
