Module Program    
  Sub Main()
    For i=0 To 9
      Console.Write("{0}  ", i)
      
      'ketika i genap, proses pengulangan
      'akan melanjutkan ke i berikutnya
      If (i Mod 2 = 0) Then
        Continue For
      End If
      
      'ketika i genap, statemen ini
      'tidak akan dieksekusi
      Console.WriteLine()      
    Next
    
    Console.ReadLine()
  End Sub
End Module
