Module Program    
  Sub Main()
    Dim nohari As Integer
    Dim s As String
    Dim namahari As String = ""
    Dim temp As Object
    
    Console.Write("Masukkan nomor hari: ")
    s = Console.ReadLine()
    
    nohari = Int32.Parse(s)
    
    temp = Switch (
             nohari = 1, "Minggu",
             nohari = 2, "Senin",
             nohari = 3, "Selasa",
             nohari = 4, "Rabu",
             nohari = 5, "Kamis",
             nohari = 6, "Jumat",
             nohari = 7, "Sabtu"
           )
    
    namahari = CStr(temp)
    
    If (Len(namahari) <> 0) Then
      Console.WriteLine("Hari ke-{0} " _
        & "adalah {1}", nohari, namahari)
    Else
      Console.WriteLine("Tidak ada " _
        & "hari ke-{0}", nohari)
    End If    
    
    Console.ReadLine()
  End Sub
End Module
