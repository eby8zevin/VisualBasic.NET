Imports System.Collections.Generic

Module Program
  Sub TampilkanKoleksi(keterangan As String,
        d As IDictionary(Of Integer, String))
    Console.WriteLine(keterangan)
    For Each pair As KeyValuePair(Of Integer, String) _
      In d
      Console.WriteLine("{0}: {1}", pair.Key, pair.Value)
    Next
    Console.WriteLine()
  End Sub
  
  Sub Main()
    'membuat koleksi 
    'bertipe Dictionary(Of TKey,TValue)
    Dim A As Dictionary(Of Integer, String) = _
      New Dictionary(Of Integer, String)()
    
    'membuat koleksi 
    'bertipe SortedDictionary(Of TKey,TValue)    
    Dim B As SortedDictionary(Of Integer, String) = _ 
      New SortedDictionary(Of Integer, String)()
    
    'menambahkan elemen ke dictionary
    A.Add(4, "empat")
    A.Add(2, "dua")
    A.Add(3, "tiga")
    A.Add(5, "lima")
    A.Add(1, "satu")
    
    'menambahkan elemen ke sorted dictionary
    B.Add(4, "empat")
    B.Add(2, "dua")
    B.Add(3, "tiga")
    B.Add(5, "lima")
    B.Add(1, "satu")
    
    'menampilkan isi A dan B
    TampilkanKoleksi("Isi A (dictionary):", A)    
    TampilkanKoleksi("Isi B (sorted dictionary):", B)
    
    Console.ReadLine()
  End Sub
End Module
