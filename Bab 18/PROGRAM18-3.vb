Imports System.Collections.Generic

Module Program  
  Sub Main()
    'membuat koleksi bertipe 
    'kelas Dictionary(Of TKey, TValue),
    'tapi referensi bertipe 
    'interface IDictionary(Of TKey, TValue)
    Dim koleksi As IDictionary(Of String, String) = _
      New Dictionary(Of String, String)()
    
    'menambah elemen ke dalam koleksi
    koleksi.Add("satu","one")
    koleksi.Add("dua","two")
    koleksi.Add("tiga","three")
    koleksi.Add("empat","four")
    koleksi.Add("lima","five")
    
    'menggunakan pengindeks (properti Item)
    Console.WriteLine("Bahasa Inggris 'tiga': {0}", _
                      koleksi.Item("tiga"))
    
    'menghapus elemen dengan kunci "lima"
    koleksi.Remove("lima")
    
    'memeriksa apakah kunci "dua"
    'ada di dalam koleksi atau tidak
    Console.WriteLine( _
      "koleksi.ContainsKey(""dua""): {0}", _
      koleksi.ContainsKey("dua"))
    
    'memeriksa apakah kunci "enam"
    'ada di dalam koleksi atau tidak
    Console.WriteLine( _
      "koleksi.ContainsKey(""enam""): {0}", _
      koleksi.ContainsKey("enam"))
        
    'menggunakan TryGetValue()
    Dim s As String = Nothing
    koleksi.TryGetValue("dua", s)
    Console.WriteLine("Bahasa Inggris 'dua': {0}",  s)
    
    'menampilkan isi pasangan kunci/nilai
    'di dalam koleksi
    Console.WriteLine("{0}Isi koleksi:", vbNewLine)
    For Each pair _
      As KeyValuePair(Of String, String) In koleksi    
      Console.WriteLine("{0}:{1}", pair.Key, pair.Value)
    Next
    
    'menampilkan daftar kunci
    Console.WriteLine("{0}Daftar kunci:", vbNewLine)
    For Each kunci As String In koleksi.Keys
      Console.WriteLine(kunci)
    Next
    
    'menampilkan daftar nilai
    Console.WriteLine("{0}Daftar nilai:", vbNewLine)
    For Each nilai As String In koleksi.Values
      Console.WriteLine(nilai)
    Next
    
    Console.ReadLine()
  End Sub
End Module
