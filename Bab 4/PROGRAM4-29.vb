Module Program    
  Sub Main()
    Dim i As Integer
    
    'mendefinisikan label
    mulai:
    
    If (i <=20) Then
      If (i Mod 2 <> 0) Then
        Console.Write("{0} ", i)
      End If
      'menaikkan nilai i
      i += 1
      
      'kembali ke atas
      GoTo mulai
    End If
    
    Console.ReadLine()
  End Sub
End Module
