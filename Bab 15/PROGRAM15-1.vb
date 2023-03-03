Module Program   
  Sub Main()    
    Dim A As Integer() = New Integer(4) { _
      10, 20, 30, 40, 50 }
    
      'baris di bawah ini akan menyebabkan eksepsi
      Dim x As Integer = A(5)
    
      Console.WriteLine("Nilai x = {0}", x)
    
      Console.ReadLine()
  End Sub
End Module
