Module Program  
  Sub Main()
    Dim nilai As Integer = 0
    Dim hasil As Integer = 0
    Dim s As String = Nothing
    
    Console.Write("Masukkan bilangan bulat: ")
    s = Console.ReadLine()
    
    Try
      nilai = Integer.Parse(s)
      hasil = 100 \ nilai
      Console.WriteLine("Hasil bagi = {0}", hasil)    
    Catch e1 As DivideByZeroException
      Console.WriteLine("ERROR: " _
        & "Terjadi pembagian dengan nol.")
    Catch e2 As FormatException
      Console.WriteLine("ERROR: " _
        & "Anda tidak memasukkan bilangan bulat.")
    End Try
    
    Console.ReadLine()
  End Sub
End Module
