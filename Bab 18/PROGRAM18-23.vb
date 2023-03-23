Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe Dictionary(Of TKey, TValue)    
    Dim dict As Dictionary(Of Integer, String) = _
      New Dictionary(Of Integer, String)
    
    'menambah elemen menggunakan Add()
    dict.Add(1, "Januari")
    dict.Add(2, "Februari")
    dict.Add(3, "Maret")
    dict.Add(4, "April")
    dict.Add(5, "Mei")
    dict.Add(6, "Juni")
    dict.Add(7, "Juli")
    dict.Add(8, "Agustus")
    dict.Add(9, "September")
    dict.Add(10, "Oktober")
    dict.Add(11, "November")
    dict.Add(12, "Desember")
    
    'mengakses elemen koleksi
    'menggunakan statemen foreach
    Console.WriteLine("Isi dictionary awal:")
    For Each elemen As KeyValuePair(Of Integer, String) _
      In dict
      Console.Write("Kunci: {0}{1}", elemen.Key, vbTab)
      Console.Write("Nilai: {0}{1}", elemen.Value, vbNewLine)
    Next
    
    'mengakses nilai elemen
    'berdasarkan kuncinya
    Console.WriteLine()
    Console.WriteLine("Bulan ke-3: {0}", dict(3))
    Console.WriteLine("Bulan ke-6: {0}", dict(6))
    Console.WriteLine("Bukan ke-9: {0}", dict(9))
        
    'menghapus elemen dengan kunci 7..12
    For i As Integer = 7 To 12
      dict.Remove(i)
    Next
        
    'menampilkan kembali isi koleksi
    'setelah proses penghapusan elemen    
    Console.WriteLine()
    Console.WriteLine("Isi dictionary " _
                    & "setelah dihapus:")
    For Each elemen As KeyValuePair(Of Integer, String) _
      In dict
      Console.Write("Kunci: {0}{1}", elemen.Key, vbTab)
      Console.Write("Nilai: {0}{1}", elemen.Value, vbNewLine)
    Next
    
    Console.ReadLine()
  End Sub
End Module
