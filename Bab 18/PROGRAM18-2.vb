Imports System.Collections.Generic

Module Program  
  'menampilkan isi koleksi
  Sub TampilkanIsiKoleksi(koleksi As IList(Of String))
    Dim enumerator As IEnumerator(Of String)
    enumerator = koleksi.GetEnumerator()
    While enumerator.MoveNext()
      Console.WriteLine(enumerator.Current)
    End While
  End Sub

  Sub Main()
    'membuat koleksi bertipe List<T>,
    'tapi referensi bertipe IList<T>
    Dim koleksi As IList(Of String) = _
      New List(Of String)()
    
    'menambah elemen ke dalam koleksi
    koleksi.Add("Visual Basic .NET")
    koleksi.Add("C++")
    koleksi.Add("Java")

    'menampilkan isi koleksi
    Console.WriteLine("Isi koleksi:")
    TampilkanIsiKoleksi(koleksi)
    
    'mencari indeks dari elemen tertentu
    Dim indeks As Integer = koleksi.IndexOf("C++")
    Console.WriteLine("{0}C++ ada di indeks ke-{1}", _
      vbNewLine, indeks)
    
    'menyisipkan elemen baru ke dalam koleksi
    'pada indeks ke-2
    Console.WriteLine("{0}Menambah ""Python"" pada " _
      & "indeks ke-2", vbNewLine)
    koleksi.Insert(2, "Python")
    
    'menampilkan kembali isi koleksi
    'setelah ditambah elemen baru
    Console.WriteLine("{0}Isi koleksi setelah ditambah:", _
      vbNewLine)
    TampilkanIsiKoleksi(koleksi)
        
    'menghapus elemen pada indeks ke-1
    Console.WriteLine("{0}Menghapus elemen pada " _
      & "indeks ke-1 (""C++"")", vbNewLine)
    koleksi.RemoveAt(1)
    
    'menampilkan kembali isi koleksi
    'setelah elemen dihapus
    Console.WriteLine("{0}Isi koleksi setelah dihapus:", _
      vbNewLine)
    TampilkanIsiKoleksi(koleksi)
    
    Console.ReadLine()
  End Sub
End Module
