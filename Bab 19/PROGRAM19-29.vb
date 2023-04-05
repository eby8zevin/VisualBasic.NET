Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim bilangan As Integer() = New Integer(4) _
      {50,20,10,40,30}
        
    'menggunakan metode OrderBy()
    Dim hasil = bilangan.OrderBy(Function(e) e)
        
    'menampilkan elemen-elemen dalam sumber data
    Console.Write("Sumber data {0}: ", vbTab)
    For Each i As Integer In bilangan
      Console.Write(i & " ")
    Next
    
    'menampilkan elemen-elemen dalam hasil
    Console.WriteLine()
    Console.Write("Hasil query {0}: ", vbTab)
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
