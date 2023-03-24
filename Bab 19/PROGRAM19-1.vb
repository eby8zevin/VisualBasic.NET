Imports System.Linq

Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(9) _
      {10,2,8,4,6,5,9,3,7,1}
    
    'menampilkan isi array
    Console.Write("Sumber data{0}: ", vbTab)
    For Each elemen As Integer In A    
      Console.Write(elemen & " ")
    Next
        
    'membuat query
    Dim hasil = from e in A
                where e < 6
                select e
    
    Console.Write("{0}Hasil query{1}: ", _
      vbNewLine, vbTab)
    'eksekusi query
    For Each i As Integer In hasil    
      Console.Write(i & " ")
    Next    
    
    Console.ReadLine()
  End Sub
End Module
