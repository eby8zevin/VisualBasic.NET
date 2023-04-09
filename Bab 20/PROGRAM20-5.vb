'membuat alias namespace
Imports gen = System.Collections.Generic

Module Program  
  Sub Main()    
    'menggunakan alias
    Dim dict As gen.Dictionary(Of Integer, String) = _
      New gen.Dictionary(Of Integer, String)
    
    dict.Add(1, "satu")
    dict.Add(2, "dua")
    dict.Add(3, "tiga")
    dict.Add(4, "empat")
    dict.Add(5, "lima")
    
    For Each pair As gen.KeyValuePair(Of Integer, String) _
      In dict    
      Console.WriteLine("{0}: {1}", _
                       pair.Key, pair.Value)
    Next
    
    Console.ReadLine()
  End Sub
End Module
