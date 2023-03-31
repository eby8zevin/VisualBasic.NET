Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(4) _
      {1,2,3,4,5}
    
    'membuat query yang mengembalikan
    'pangkat dua dari setiap elemen array A
    Dim hasil As IEnumerable(Of Integer) = _
          from e in A
          select CType(Math.Pow(e, 2), Integer)
    
    'menampilkan isi array
    Console.Write("Sumber data{0}: ", vbTab)
    For Each i As Integer In A
      Console.Write(i & " ")
    Next
    
    'menampilkan hasil query
    Console.Write("{0}Hasil query{1}: ", _
      vbNewLine, vbTab)
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next    
    
    Console.ReadLine()
  End Sub
End Module
