Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe Dictionary(Of TKey, TValue>
    Dim dict As Dictionary(Of String, String) = _
      New Dictionary(Of String, String)()
    
    'menambah elemen menggunakan Add()
    dict.Add("Microsoft", "Bill Gates")
    dict.Add("Oracle", "Larry Ellison")
    dict.Add("Apple", "Steve Jobs")
    dict.Add("Dell", "Michael S. Dell")
    
    'menampilkan isi koleksi
    Console.WriteLine("Isi dictionary:")
    For Each elemen As KeyValuePair(Of String, String) _
      In dict
      Console.Write("Kunci: {0}{1}", elemen.Key, vbTab)
      Console.Write("Nilai: {0}{1}", elemen.Value, vbNewLine)
    Next
    
    'memeriksa nilai
    Console.WriteLine()
    Console.WriteLine( _
      "dict.ContainsValue(""Bill Gates""): {0}", _
      dict.ContainsValue("Bill Gates"))
    
    'memeriksa kunci
    Console.WriteLine( _
      "dict.ContainsKey(""Microsoft""): {0}", _
      dict.ContainsKey("Microsoft"))
    Console.WriteLine( _
      "dict.ContainsKey(""Borland""): {0}", _
      dict.ContainsKey("Borland"))
    
    Console.ReadLine()
  End Sub
End Module
