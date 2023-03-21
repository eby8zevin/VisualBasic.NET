Imports System.Collections.Generic

Module Program
  Sub Tulis(ByVal s As String)
    Console.WriteLine(s)
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe List<T>
    'dengan kapasitas 5 elemen
    Dim list As List(Of String) = _
      New List(Of String)(5)
    
    'menampilkan kapasitas dan
    'jumlah elemen awal
    Console.WriteLine("Kapasitas {0}: {1}",
      vbTab, list.Capacity)
    Console.WriteLine("Jumlah elemen {0}: {1}", _
      vbTab, list.Count)
    
    'menambah 5 elemen ke dalam list
    list.Add("Python")
    list.Add("C#")
    list.Add("Ruby")
    list.Add("Java")
    list.Add("C++")
    
    'menambah 2 elemen baru
    list.Add("Perl")
    list.Add("Lua")
    
    'menampilkan isi koleksi
    'menggunakan metode ForEach()
    Console.WriteLine()
    Console.WriteLine("Isi list: ")
    list.ForEach(AddressOf Tulis)
    
    'menampilkan kapasitas dan
    'jumlah elemen setelah ditambah
    Console.WriteLine()
    Console.WriteLine("Setelah ditambah elemen:")
    Console.WriteLine("Kapasitas {0}: {1}", _
      vbTab, list.Capacity)
    Console.WriteLine("Jumlah elemen {0}: {1}", _
      vbTab, list.Count)
    
    'menghapus 2 elemen terakhir
    list.Remove("Perl")
    list.Remove("Lua")
    
    'menampilkan kapasitas dan
    'jumlah elemen setelah dihapus
    Console.WriteLine()
    Console.WriteLine("Setelah 2 elemen dihapus:")
    Console.WriteLine("Kapasitas {0}: {1}", _
      vbTab, list.Capacity)
    Console.WriteLine("Jumlah elemen {0}: {1}", _
      vbTab, list.Count)
    
    'menghapus ruang kosong yang tidak
    'ditempati oleh elemen
    list.TrimExcess()
    
    'menampilkan kapasitas dan
    'jumlah elemen setelah dihapus
    Console.WriteLine()
    Console.WriteLine("Setelah pemanggilan TrimExess():")
    Console.WriteLine("Kapasitas {0}: {1}", _
      vbTab, list.Capacity)
    Console.WriteLine("Jumlah elemen {0}: {1}", _
      vbTab, list.Count)
    
    'menyalin 3 elemen mulai indeks ke-1,
    'dan memasukkannya ke array mulai indeks ke-0
    Dim array As String() = New String(2) {}
    list.CopyTo(1, array, 0, 3)
    
    'menampilkan array hasil penyalinan
    Console.WriteLine()
    Console.WriteLine("Isi array:")
    For Each elemen As String In array
      Console.WriteLine(elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
