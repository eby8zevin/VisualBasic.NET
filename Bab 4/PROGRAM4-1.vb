Module Program  
  Sub Main()            
    Dim x As Integer
    Dim s As String
    
    Console.Write("Masukkan bilangan bulat positif: ")
    s = Console.ReadLine()
    
    x = Int32.Parse(s)
    
    If (x <= 0) Then
      Console.WriteLine("ERROR: " _
        & "Bilangan tidak boleh NOL atau negatif")
      End 'keluar program
    End If
    
    Console.WriteLine("Anda memasukkan bilangan {0}", x)    
    
    Console.ReadLine()
  End Sub
End Module
