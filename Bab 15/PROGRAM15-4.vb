Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(4) {10,20,30,40,50}
    Try
      For i=0 To 5
        Console.Write("A({0}) = ", i)
        Console.WriteLine(A(i))
      Next
    Catch
      Console.WriteLine("ERROR: Indeks di luar rentang.")      
    End Try
    
    Console.ReadLine()
  End Sub
End Module
