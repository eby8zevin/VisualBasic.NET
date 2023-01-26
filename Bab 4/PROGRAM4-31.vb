Module Program    
  Sub Main()
    Dim x As Integer
    Dim s As String
    
    Console.Write("Masukkan bilangan selain NOL: ")
    s = Console.ReadLine()
    x = Int32.Parse(s)
    
    If (x = 0) Then
      Console.WriteLine("ERROR: " _
        & "bilangan tidak boleh NOL")
      'keluar dari program
      End     'bisa ditulis: Environment.Exit(1)
    End If
    
    Console.WriteLine("1/{0} = {1}", _
      x, (1/x))
    
    Console.ReadLine()
  End Sub
End Module
