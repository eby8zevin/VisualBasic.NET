Imports System.Collections.Generic

'membuat kelas yang mengimplementasikan
'interface IEqualityComparer(Of T)
Class Comparator: Implements IEqualityComparer(Of String)
  
  'implementasi metode Equals()
  Public Overloads Function Equals(s1 As String, s2 As String) _
    As Boolean _
    Implements IEqualityComparer(Of String).Equals
    
    Return StringComparer.CurrentCultureIgnoreCase. _
      Compare(s1, s2) = 0
    
  End Function
  
  'implementasi metode GetHashCode()
  Public Overloads Function GetHashCode(s As String) _
    As Integer _
    Implements IEqualityComparer(Of String).GetHashCode
    
    Return StringComparer.CurrentCultureIgnoreCase. _
      GetHashCode(s)
    
  End Function
End Class  

Module Program
  Sub Main()
    'membuat koleksi 
    'menggunakan kelas Dictionary(Of String, String)
    Dim d As Dictionary(Of String, String) = _
      New Dictionary(Of String, String)( _
        New Comparator() _
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
