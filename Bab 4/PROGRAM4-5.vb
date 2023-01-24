Module Program  
  Sub Main()            
    Dim nobulan As Integer
    Dim s As String
    Dim bulan As String = ""
      
    Console.Write("Masukkan nomor bulan: ")
    s = Console.ReadLine()
    
    nobulan = Int32.Parse(s)
    
    Select nobulan
      Case 1: bulan = "Januari"
      Case 2: bulan = "Februari"
      Case 3: bulan = "Maret"
      Case 4: bulan = "April"
      Case 5: bulan = "Mei"
      Case 6: bulan = "Juni"
      Case 7: bulan = "Juli"
      Case 8: bulan = "Agustus"
      Case 9: bulan = "September"
      Case 10: bulan = "Oktober"
      Case 11: bulan = "November"
      Case 12: bulan = "Desember"
      Case Else
        Exit Select 'keluar dari blok pemilihan
    End Select
    
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
