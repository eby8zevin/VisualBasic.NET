Module Program  
  Sub Main()
    'e dideklarasikan di luar (tidak setelah Catch)
    Dim e As IndexOutOfRangeException
    
    Dim A As Integer() = New Integer(4) {10,20,30,40,50}
    Try
      For i=0 To 5
        Console.Write("A({0}) = ", i)
        Console.WriteLine(A(i)) 'IndexOutOfRangeException
      Next
    Catch e
      Console.Write("ERROR: ")
      Console.WriteLine(e.Message)
    End Try
    
    Console.ReadLine()
  End Sub
End Module
