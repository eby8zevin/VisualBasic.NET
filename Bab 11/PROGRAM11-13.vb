Enum JenisKelamin
  Pria
  Wanita
End Enum

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
    Dim nama As String = "Bimo"
    
    Console.WriteLine("Nama {0}: {1}",
      vbTab, nama)
    Console.WriteLine("Jenis Kelamin {0}: {1}",
      vbTab, CType(JenisKelamin.Pria, Integer))
    Console.WriteLine("Hari Lahir {0}: {1}",
      vbTab, CType(NamaHari.Jumat, Integer))
            
    Console.ReadLine()
  End Sub
End Module
