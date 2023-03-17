Imports System.Collections.Generic

Module Program  
  Sub Main()
    'membuat koleksi bertipe List(Of T)
    Dim koleksi As IList(Of String) = New List(Of String)()
    
    'menambah elemen ke dalam koleksi
    koleksi.Add("VB")
    koleksi.Add("C++")
    koleksi.Add("Java")
    koleksi.Add("Python")
    koleksi.Add("Ruby")
    
    'mendeklarasikan referensi bertipe enumerator
    Dim enumerator As IEnumerator(Of String)
    
    'memperoleh enumerator dari koleksi    
    enumerator = koleksi.GetEnumerator()
    
    Console.WriteLine("Isi koleksi:")
    'menelusuri setiap elemen di dalam koleksi
    'menggunakan enumerator
    While enumerator.MoveNext()
      'mengambil elemen yang sedang ditunjuk
      'oleh enumerator dan menampilkannya
      'ke layar console
      Console.WriteLine(enumerator.Current)
    End While
    
    'mengembalikan enumerator ke posisi awal
    enumerator.Reset()
    
    If enumerator.MoveNext() Then
      'mengambil elemen pertama
      Console.WriteLine()
      Console.WriteLine("Elemen pertama: {0}", _
                        enumerator.Current)
    End If
    
    Console.ReadLine()
  End Sub
End Module
