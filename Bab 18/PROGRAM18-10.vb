Imports System.Collections.Generic

Module Program
  Sub TampilkanKoleksi(koleksi As List(Of String), _
                       namaKoleksi As String)
    Console.WriteLine("Isi {0}: ", namaKoleksi)
    For Each elemen As String In koleksi
      Console.WriteLine(elemen)
    Next
    Console.WriteLine()
  End Sub

  Sub Main()
    'membuat koleksi bertipe List<T>
    Dim list1 As List(Of String) = New List(Of String)()
    
    'menambah elemen ke dalam list1
    list1.Add("Visual Basic .NET")
    list1.Add("C#")
    list1.Add("C++")
    list1.Add("C")
    list1.Add("Java")
    
    Dim list2 As List(Of String) = New List(Of String)()
    
    'menambah elemen ke dalam list2
    list2.Add("Python")
    list2.Add("Perl")
    list2.Add("Ruby")
    
    Dim list3 As List(Of String)
        
    'mengambil elemen-elemen dari list1
    'dan menampungnya ke list3,
    'mulai indeks ke-1 sebanyak 3 elemen
    list3 = list1.GetRange(1,3)
    
    'menyisipkan elemen-elemen list3
    'ke dalam list2
    list2.InsertRange(2, list3)
    
    'menghapus elemen dalam list1
    'dari indeks ke-3 sebanyak 2 elemen
    list1.RemoveRange(3, 2)
    
    'menampilkan isi list1, list2, dan list3
    TampilkanKoleksi(list1, "list1")
    TampilkanKoleksi(list2, "list2")
    TampilkanKoleksi(list3, "list3")
    
    Console.ReadLine()
  End Sub
End Module
