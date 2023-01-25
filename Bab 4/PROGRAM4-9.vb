Module Program    
  Sub Main()
    'membuat array dan mengisikan
    'nilai awal ke dalamnya
    Dim hari() As String = {"Minggu", _
      "Senin","Selasa","Rabu", _
      "Kamis","Jumat","Sabtu"}
    
    Dim nohari As Integer
    Dim s, namahari As String
    
    Console.Write("Masukkan nomor hari: ")
    s = Console.ReadLine()
    
    nohari = Int32.Parse(s)
    
    'menggunakan fungsi Choose()
    'dengan indeks nohari
    'dan kumpulan nilai diambil dari array
    namahari = CStr(Choose(nohari, hari))
    
    Console.WriteLine("Hari ke-{0} " _
      & "adalah {1}", nohari, namahari)
    
    Console.ReadLine()
  End Sub
End Module
