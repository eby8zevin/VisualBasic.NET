Imports System.Collections.Generic

Module Program  
  Sub Main()
    'membuat koleksi bertipe List(Of T),
    'tapi referensi bertipe ICollection(Of T)
    Dim koleksi As ICollection(Of String) = _
      New List(Of String)()
    
    'menambah elemen ke dalam koleksi
    koleksi.Add("Visual Basic .NET")
    koleksi.Add("C++")
    koleksi.Add("Java")
    koleksi.Add("Python")
    koleksi.Add("Ruby")
    
    'menelusuri koleksi menggunakan enumerator
    Console.WriteLine("Isi koleksi:")
    Dim enumerator As IEnumerator(Of String)
    enumerator = koleksi.GetEnumerator()
    While enumerator.MoveNext()
      Console.WriteLine(enumerator.Current)
    End While
    
    'memeriksa apakah suatu objek
    'ada di dalam koleksi atau tidak
    Console.WriteLine()
    Console.WriteLine("koleksi.Containts(""C++""): {0}", _
                      koleksi.Contains("C++"))
    Console.WriteLine("koleksi.Containts(""VB""): {0}", _
                      koleksi.Contains("VB"))
  
    'menyalin isi koleksi ke array
    Dim array As String() = _
      New String(koleksi.Count-1) {}
    koleksi.CopyTo(array, 0)
    
    'menampilkan isi array
    Console.WriteLine()
    Console.WriteLine("Isi array (hasil copy):")
    For Each elemen As String in array
      Console.WriteLine(elemen)
    Next
    
    'memindahkan "C++" dan "Ruby"
    'dari koleksi
    koleksi.Remove("C++")
    Console.WriteLine()
    Console.WriteLine("Menghapus ""C++""...")
    koleksi.Remove("Ruby")
    Console.WriteLine("Menghapus ""Ruby""...")
    
    'menampilkan isi koleksi setelah dua elemen dihapus
    'menggunakan statemen foreach
    '(Catatan: Anda juga dapat menggunakan enumerator)
    Console.WriteLine()
    Console.WriteLine("Isi koleksi setelah dihapus:")
    For Each elemen As String in koleksi
      Console.WriteLine(elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
