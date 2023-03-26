Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa Dictionary(Of TKey,TValue)    
    Dim dict As Dictionary(Of String, String) = _
      New Dictionary(Of String, String)()
    
    'menambah elemen ke dalam dictionary
    dict.Add("winword", "Windows")
    dict.Add("paint", "Windows")
    dict.Add("notepad", "Windows")
    dict.Add("xterm", "Linux")
    dict.Add("gedit", "Linux")
    dict.Add("geany", "Linux")
    
    'menampilkan isi dictionary
    Console.WriteLine("Daftar program: ")
    For Each pair As KeyValuePair(Of String, String) _
      In dict    
      Console.WriteLine("{0}{1}: {2}", _
        pair.Key, vbTab, pair.Value)
    Next
        
    'membuat query
    Dim hasil As _
      IEnumerable(Of KeyValuePair(Of String,String)) = _
        dict.Where(Function(kv) kv.Value.Equals("Linux"))
    
    Console.WriteLine("{0}Program Linux: ", vbNewLine)
    'eksekusi query
    For Each pair As KeyValuePair(Of String, String) _
      In hasil
      Console.WriteLine(pair.Key)
    Next
    
    Console.ReadLine()
  End Sub
End Module
