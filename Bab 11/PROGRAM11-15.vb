Enum NamaHari 
  Minggu=1
  Senin
  Selasa
  Rabu
  Kamis
  Jumat
  Sabtu
End Enum

Module Program  
  Sub Main()    
    Dim daftarNamaHari As Array
    Dim nama As String
    
    daftarNamaHari = System.Enum.GetNames(GetType(NamaHari))
    
    Console.WriteLine("Daftar nilai konstan pada tipe NamaHari:")
    For Each nama In daftarNamaHari
      Console.WriteLine(nama)
    Next
            
    Console.ReadLine()
  End Sub
End Module
