Module Program  
  Function Bagi(ByVal a As Integer, _
                ByVal b As Integer) As Integer
    If b = 0 Then
      'melempar eksepsi
      Throw New DivideByZeroException()
    End If
    'jika b tidak sama dengan nol
    Return a \ b
  End Function
  
  Sub Main()
    Dim x As Integer = 9
    Dim y As Integer = 0
    Dim hasil As Integer = 0
    
    Try
      'memanggil metode Bagi()
      hasil = Bagi(x, y)
      
      Console.WriteLine("Hasil bagi = {0}", hasil)    
    Catch e1 As DivideByZeroException
      Console.WriteLine("ERROR: " _
        & "Terjadi pembagian dengan nol.")
    End Try
    
    Console.ReadLine()
  End Sub
End Module
