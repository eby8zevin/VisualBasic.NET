Module Program  
  Sub Main()            
    Dim a As Integer = -11
    Dim b As Integer = 99
    Dim maksimum, abs As Integer
    
    'mencari nilai terbesar
    maksimum = If(a > b, a, b)
    
    'mencari harga mutlak
    abs = If(a >= 0, a, -a)
    
    Console.WriteLine("maksimum {0}= {1}", Chr(9), maksimum)
    Console.WriteLine("abs {0}= {1}", Chr(9), abs)
        
    Console.ReadLine()
  End Sub
End Module
