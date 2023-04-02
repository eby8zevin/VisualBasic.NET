Imports System.Linq
Imports System.Collections.Generic

Module Program
  Sub Main()
    Dim arrayA As Integer() = New Integer(4) {1,2,3,4,5}
    Dim arrayB As Integer() = New Integer(4) {1,3,5,7,9}
    
    Dim hasil As IEnumerable(Of Integer) = _
                    from a in arrayA
                    group join b in arrayB on a equals b
                    into arrayC = group
                    from c in arrayC
                    select c
    
    'menampilkan hasil query
    Console.Write("Hasil query: ")
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next

    Console.ReadLine()
  End Sub
End Module
