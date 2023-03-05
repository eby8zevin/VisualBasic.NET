Module Program  
  Sub Main()
    Console.WriteLine("Ketika terjadi eksepsi:")
    Dim a As Integer = 0
    Dim b As Integer
    Try
      b = 10 \ a                                    	'A
      Console.WriteLine(b)                       	'B
    Catch e As DivideByZeroException
      Console.WriteLine(e.Message)               	'C
    End Try
    Console.WriteLine("Setelah blok Try-Catch")    	'D

    Console.WriteLine("{0}Ketika tidak terjadi eksepsi:", _
      vbNewLine)
    
    a = 3  'mengubah nilai y
    Try
      b = 10 \ a                                    	'A
      Console.WriteLine(b)                        	'B
    Catch e As DivideByZeroException
      Console.WriteLine(e.Message)                	'C
    End Try
    Console.WriteLine("Setelah blok Try-Catch")    	'D
    
    Console.ReadLine()
  End Sub
End Module
