Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa objek dari kelas List(Of T)
    Dim A As List(Of Integer) = New List(Of Integer)()
    
    A.Add(10)
    A.Add(-20)
    A.Add(30)
    A.Add(-10)
    A.Add(50)
    A.Add(-30)
    A.Add(-40)
    A.Add(40)
    A.Add(20)
    A.Add(-50)
    
    'menampilkan isi list
    Console.Write("Sumber data{0}: ", vbTab)
    For Each i As Integer In A
      Console.Write(i & " ")
    Next
    
    'membuat query dengan dua kondisi
    Dim hasil As IEnumerable(Of Integer) = _
                    from e in A
                    where e > 0
                    where e < 50
                    select e
    
    Console.Write("{0}Hasil query{1}: ", _
      vbNewLine, vbTab)
    
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
