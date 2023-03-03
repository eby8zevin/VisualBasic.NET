Module Program  
  Sub Main()
    Dim a = 0
    
    Try
      Dim b = 10 \ a    
      Console.WriteLine("Hasil bagi = {0}", b)
    Catch e As DivideByZeroException
      Console.WriteLine("ERROR: Terjadi pembagian dengan nol.")
      Console.WriteLine("PESAN: {0}", e.Message)        
    End Try
    
    Console.ReadLine()
  End Sub
End Module
