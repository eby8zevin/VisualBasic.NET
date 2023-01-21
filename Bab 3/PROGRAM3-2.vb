Module Program  
  Sub Main()            
    Console.WriteLine("10 = 20 {0}= {1}", _
      Chr(9), (10 = 20))
    Console.WriteLine("10 <> 20 {0}= {1}", _
      Chr(9), (10 <> 3))
    Console.WriteLine("10 < 20 {0}= {1}", _
      Chr(9), (10 < 20))
    Console.WriteLine("10 <= 20 {0}= {1}", _
      Chr(9), (10 <= 20))
    Console.WriteLine("10 > 20 {0}= {1}", _
      Chr(9), (10 > 20))
    Console.WriteLine("10 >= 20 {0}= {1}", _
      Chr(9), (10 >= 20))
    
    Console.WriteLine()
    
    'operator relasional di dalam pemilihan
    Console.WriteLine("Operator relasional " _
      & "dalam pemilihan:")
    Dim a As Integer = 10
    Dim b As Integer = 20    
    If (a < b) Then
      Console.WriteLine("a lebih kecil dari b")
    End If
    
    Console.WriteLine()
    
    'operator relasional di dalam pengulangan
    Console.WriteLine("Operator relasional " _
      & "dalam pengulangan:")
    Dim i As Integer = 1
    While (i <= 5)
      Console.WriteLine("Baris ke-{0}", i)
      i += 1
    End While    
    
    Console.ReadLine()
  End Sub
End Module
