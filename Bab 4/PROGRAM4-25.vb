Module Program    
  Sub Main()
    Dim data() As Integer = {10,20,30,40,50,60,70,80,90,100}
    Dim j As Integer
    
    'demonstrasi Exit For ke-1
    Console.Write("Pengulangan pertama{0}: ", Chr(9))
    For Each elemen In data      
      If (elemen > 30) Then
        Exit For
      End If
      Console.Write("{0} ", elemen)
    Next
    
    Console.WriteLine()
    
    'demonstrasi Exit For ke-1
    Console.Write("Pengulangan kedua{0}: ", Chr(9))
    For i=0 To data.Length-1      
      If (i = 4) Then
        Exit For
      End If
      Console.Write("{0} ", data(i))
    Next
    
    Console.WriteLine()
    
    'demonstrasi Exit While
    Console.Write("Pengulangan ketiga{0}: ", Chr(9))
    j = 0
    While (j < data.Length-1)      
      If (j = 5) Then
        Exit While
      End If
      Console.Write("{0} ", data(j))
      j += 1
    End While
    
    Console.WriteLine()
    
    'demonstrasi Exit Do
    Console.Write("Pengulangan keempat{0}: ", Chr(9))
    j = 0
    Do Until (j = data.Length)      
      If (j = 6) Then
        Exit Do
      End If
      Console.Write("{0} ", data(j))
      j += 1
    Loop    
    
    Console.ReadLine()
  End Sub
End Module
