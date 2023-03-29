Imports System.Linq

Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(4) _
      {50,10,40,20,30}
    
    Dim hasil1 = from e in A
                 where e > 10 And e < 50
                 select e

    'menggabung penggunaan klausa where dan order by    
    Dim hasil2 = from e in A
                 where e > 10 And e < 50
                 order by e
                 select e
    
    Console.Write("Sumber data{0}{1}{2}: ", _
      vbTab, vbTab, vbTab)
    For Each i As Integer In A
      Console.Write(i & " ")
    Next

    'menyaring data tanpa diurutkan
    Console.Write("{0}Hasil query tanpa order by{1}: ", _
      vbNewLine, vbTab)
    For Each i As Integer In hasil1
      Console.Write(i & " ")
    Next

    'menyaring data dan diurutkan
    Console.Write("{0}Hasil query dengan order by{1}: ", _
      vbNewLine, vbTab)
    For Each i As Integer In hasil2
      Console.Write(i & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
