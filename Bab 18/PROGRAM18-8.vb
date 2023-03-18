Imports System.Collections.Generic

Module Program
  Sub Main()
    'membuat koleksi 
    'menggunakan kelas Dictionary(Of String, String)
    Dim d As Dictionary(Of String, String) = _
      New Dictionary(Of String, String)( _
        StringComparer.CurrentCultureIgnoreCase _
      )
    
    'mengisi elemen ke dalam koleksi
    d.Add("satu", "Python")
    d.Add("dua", "Ruby")
    
    Try
      d.Add("SATU", "Perl")
    Catch e As ArgumentException
      Console.WriteLine("ERROR: {0}", e.Message)
      Console.WriteLine()
    End Try
    
    'menampilkan isi koleksi
    Console.WriteLine("Isi koleksi:")  
    For Each pair As KeyValuePair(Of String, String) In d
      Console.WriteLine("{0} : {1}", pair.Key, pair.Value)
    Next
    
    'menampilkan jumlah elemen
    Console.WriteLine("{0}Jumlah elemen: {1}", _
      vbNewLine, d.Count)
    
    Console.ReadLine()
  End Sub
End Module
