Imports System.Linq
Imports System.Collections.Generic

Module Program
  Sub Main()
    Dim bilangan As Integer() = New Integer(7) _
      {2, -1, 4, -3, 5, -6, -7, 8}
    
    'query syntax
    Dim hasil1 = from e in bilangan
                 where e < 4
                 select e
    
    'method syntax
    Dim hasil2 = bilangan.Where(Function(x) x < 4)
    
    'gabungan query syntax dan method syntax
    Dim hasil3 As Integer = _
                (from e in bilangan
                 where e < 4
                 select e).Count()
    
    'menampilkan elemen-elemen dalam hasil1
    Console.Write("hasil1 {0}{1}: ", _
      vbTab, vbTab)
    For Each i As Integer In hasil1    
      Console.Write(i & " ")
    Next
        
    'menampilkan elemen-elemen dalam hasil2
    Console.WriteLine()    
    Console.Write("hasil2 {0}{1}: ", _
      vbTab, vbTab)
    For Each i As Integer In hasil2
      Console.Write(i & " ")
    Next
    
    'menampilkan nilai hasil3
    Console.WriteLine()
    Console.WriteLine("Banyaknya data{0}: {1}", _
      vbTab, hasil3)

    Console.ReadLine()
  End Sub
End Module
