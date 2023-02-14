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
    Dim daftarNilai As Array
    Dim nilai As Integer
    
    daftarNilai = System.Enum.GetValues(GetType(NamaHari))
    
    Console.WriteLine("Daftar nilai pada tipe NamaHari:")
    For Each nilai In daftarNilai
      Console.WriteLine(nilai)
    Next
            
    Console.ReadLine()
  End Sub
End Module
