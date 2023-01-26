Module Program    
  Sub Main()
    For i=1 To 5
      Console.WriteLine("Baris ke-{0}", i)
      Console.WriteLine("Tekan F5 (di Visual Studio) " _
        & "untuk melanjutkan eksekusi program")
      
      'menunda eksekusi program
      Stop
    Next
    
    Console.ReadLine()
  End Sub
End Module
