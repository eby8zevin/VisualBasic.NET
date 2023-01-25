Module Program    
  Sub Main()
    Dim nohari As Integer
    Dim s, namahari As String
    
    Console.Write("Masukkan nomor hari: ")
    s = Console.ReadLine()
    
    nohari = Int32.Parse(s)
    
    namahari = CStr(Choose(nohari, "Minggu", _
      "Senin","Selasa","Rabu", _
      "Kamis","Jumat","Sabtu"))
    
    Console.WriteLine("Hari ke-{0} " _
      & "adalah {1}", nohari, namahari)
    
    Console.ReadLine()
  End Sub
End Module
