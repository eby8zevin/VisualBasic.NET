Imports System.Collections.Generic

Module Program
  Sub TampilkanKoleksi(keterangan As String,
        koleksi As SortedList(Of Integer, String))
    Console.WriteLine(keterangan)
    For Each pair As KeyValuePair(Of Integer, String) _
      In koleksi
      Console.WriteLine("{0}: {1}", pair.Key, pair.Value)
    Next
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe SortedList(Of TKey,TValue)    
    Dim sl As SortedList(Of Integer, String) = _
      New SortedList(Of Integer, String)()
    
    'menambahkan elemen ke dalam koleksi
    '(kunci tidak berurutan)
    sl.Add(4, "C++")
    sl.Add(2, "Java")
    sl.Add(3, "Python")
    sl.Add(5, "Perl")
    sl.Add(1, "Visual Basic .NET")
        
    'menampilkan isi koleksi
    TampilkanKoleksi("Isi sorted list:", sl)
    
    Console.WriteLine()
    Console.WriteLine("sl.IndexOfKey(3) {0}: {1}", _
       vbTab, sl.IndexOfKey(3))
    Console.WriteLine("sl.IndexOfValue(""C++"") {0}: {1}", _
       vbTab, sl.IndexOfValue("C++"))
    
    'mengubah nilai elemen untuk kunci 5
    sl(5) = "Ruby"
    
    'menghapus indeks ke-1
    sl.RemoveAt(1)
    
    'menghapus nilai kunci 4 ("C++")
    sl.Remove(4)
    
    'menampilkan kembali isi koleksi
    'setelah diubah dan dihapus
    Console.WriteLine()
    TampilkanKoleksi("Setelah diubah dan dihapus:", sl)
    
    Console.ReadLine()
  End Sub
End Module
