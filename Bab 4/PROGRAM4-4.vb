Module Program  
  Sub Main()            
    Dim nobulan As Integer
    Dim s As String
    Dim bulan As String = ""
    
    Console.Write("Masukkan nomor bulan: ")
    s = Console.ReadLine()
    
    nobulan = Int32.Parse(s)
    
    If (nobulan = 1) Then
      bulan = "Januari"  
    ElseIf (nobulan = 2) Then
      bulan = "Februari"
    ElseIf (nobulan = 3) Then
      bulan = "Maret"  
    ElseIf (nobulan = 4) Then
      bulan = "April"  
    ElseIf (nobulan = 5) Then
      bulan = "Mei"  
    ElseIf (nobulan = 6) Then
      bulan = "Juni"  
    ElseIf (nobulan = 7) Then
      bulan = "Juli"  
    ElseIf (nobulan = 8) Then
      bulan = "Agustus"  
    ElseIf (nobulan = 9) Then
      bulan = "September"  
    ElseIf (nobulan = 10) Then
      bulan = "Oktober"  
    ElseIf (nobulan = 11) Then
      bulan = "November"  
    ElseIf (nobulan = 12) Then
      bulan = "Desember"  
    Else
      'tidak melakukan apa-apa
    End If
    
    'menampilkan nama bulan
    If (Len(bulan) <> 0) Then
      Console.WriteLine("Bulan ke-{0} " _
        & "adalah {1}", nobulan, bulan)
    Else
      Console.WriteLine("Tidak ada bulan ke-{0}", nobulan)
    End If
    
    Console.ReadLine()
  End Sub
End Module
