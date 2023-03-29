Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(4) _
      {50,10,20,40,30}
    
    Dim hasil As IEnumerable(Of Integer) = _
                    from e in A
                    order by e descending
                    select e
    
    Console.Write("Sumber data{0}: ", vbTab)
    For Each i As Integer In A
      Console.Write(i & " ")
    Next
    
    Console.Write("{0}Hasil query{1}: ", _
      vbNewLine, vbTab)
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
