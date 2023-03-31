Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data pertama
    Dim array1 As Integer() = _
      New Integer(2) {1,2,3}
  
    'sumber data kedua
    Dim array2 As Char() = _
      New Char(2) {"A"c,"B"c,"C"c}
    
    'membuat query yang mengembalikan
    'IEnumerable(Of KeyValuePair(Of Integer, Char))
    Dim dict As IEnumerable(Of _
      KeyValuePair(Of Integer,Char)) = _
      from e1 in array1
        from e2 in array2
        select New KeyValuePair(Of Integer,Char)(e1,e2)
    
    'menampilkan isi array1
    Console.WriteLine("Isi array1:")
    For Each i As Integer In array1
      Console.WriteLine(i)
    Next
    
    'menampilkan isi array2
    Console.WriteLine("{0}Isi array2:", vbNewLine)
    For Each c As Char In array2
      Console.WriteLine(c)
    Next
    
    'menampilkan isi dictionary
    Console.WriteLine("{0}Isi dictionary:", vbNewLine)
    For Each pair As KeyValuePair(Of Integer, Char) _
      In dict    
      Console.WriteLine("{0}{1}", pair.Key, pair.Value)
    Next
    
    Console.ReadLine()
  End Sub
End Module
