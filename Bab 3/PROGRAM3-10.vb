Module Program  
  Sub Main()            
    Dim a As Integer = -11
    Dim b As Integer = 99
    Dim maksimum, abs As Integer
    
    'mencari nilai terbesar
    If (a > b) Then
      maksimum = a  
    Else
      maksimum = b  
    End If
    
    'mencari harga mutlak
    If (a >= 0) Then
      abs = a  
    Else
      abs = -a  
    End If
    
    Console.WriteLine("maksimum {0}= {1}", Chr(9), maksimum)
    Console.WriteLine("abs {0}= {1}", Chr(9), abs)
        
    Console.ReadLine()
  End Sub
End Module
