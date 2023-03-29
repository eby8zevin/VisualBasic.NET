Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa objek 
    'dari kelas Dictionary(Of TKey,TValue)
    Dim katalog As Dictionary(Of String, Double) = _
      New Dictionary(Of String, Double)()
    
    katalog.Add( _
      "Mudah Belajar Java (INFORMATIKA)", 100000.00)
    katalog.Add( _
      "Tuntunan Praktis Perl (INFORMATIKA)", 85000.00)
    katalog.Add( _
      "Menjadi Master Java (INFORMATIKA)", 120000.00)
    katalog.Add( _
      "Pemrograman Java (INFORMATIKA)", 80000.00)
    katalog.Add( _
      "Struktur Data dalam Java (INFORMATIKA)", 90000.00)
    katalog.Add(_
      "Pemrograman GUI dengan Java (INFORMATIKA)", 70000.00)
    katalog.Add( _
      "Pemrograman Java (SINAR MEDIA)", 70000.00)
    katalog.Add( _
      "Mudah Belajar F# (SINAR MEDIA)", 120000.00)
        
    'menampilkan isi dictionary
    Console.WriteLine("KATALOG:")
    For Each buku As KeyValuePair(Of String, Double) _
      In katalog
      Console.WriteLine(buku.Key & vbTab & buku.Value)
    Next
    
    'query dengan dua kondisi
    Dim hasil1 As IEnumerable(Of _
      KeyValuePair(Of String, Double)) = _
                     from e in katalog
                     where e.Key.Contains("Java") And 
                           e.Key.Contains("INFORMATIKA")
                     select e
    
    'menampilkan hasil query pertama
    Console.Write("{0}Kategori: Java,{1}", _
      vbNewLine, vbTab)
    Console.WriteLine("Penerbit: INFORMATIKA")
    For Each buku As KeyValuePair(Of String, Double) _
      In hasil1
      Console.WriteLine(buku.Key & vbTab & buku.Value)
    Next
    
    'query dengan tiga kondisi
    Dim hasil2 As IEnumerable(Of _
      KeyValuePair(Of String, Double)) = _
                     from e in katalog
                     where e.Key.Contains("Java") And 
                           e.Key.Contains("INFORMATIKA") And
                           e.Value >= 100000.00
                     select e
    
    'menampilkan hasil query kedua
    Console.Write("{0}Kategori: Java,{1}", _
      vbNewLine, vbTab)
    Console.Write("Penerbit: INFORMATIKA,{0}", vbTab)
    Console.WriteLine("Harga: >= Rp 100.000,-")
    For Each buku As KeyValuePair(Of String, Double) _
      In hasil2
      Console.WriteLine(buku.Key & vbTab & buku.Value)
    Next
    
    Console.ReadLine()
  End Sub
End Module
