Module Program  
  Sub Main()
    Dim x As Integer = 0
    Dim y As Integer
    Dim A As Integer() = New Integer(4) {10,20,30,40,50}
    Try
      y = 10 \ x  'DivisionByZeroException
      Console.WriteLine("Hasil bagi = {0}", y)
      For i=0 To 5
        Console.Write("A({0}) = ", i)
        Console.WriteLine(A(i)) 'IndexOutOfRangeException
      Next
    Catch
      Console.WriteLine("ERROR")      
    End Try
    
    Console.ReadLine()
  End Sub
End Module
