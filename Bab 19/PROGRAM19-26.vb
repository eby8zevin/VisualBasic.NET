Imports System.Linq
Imports System.Collections.Generic

Module Program
  Sub Main()
    Dim bilangan As Integer() = New Integer(4) _
      {10,20,30,40,50}
        
    'mengambil setiap elemen dan
    'elemen tersebut dipangkatkan 2
    Dim hasil1 = bilangan.Select(Function(e) Math.Pow(e, 2))
    
    'mengambil setiap elemen dan
    'elemen tersebut dipangkatkan 3
    Dim hasil2 = bilangan.Select(Function(e) Math.Pow(e, 3))
    
    'menampilkan elemen-elemen dalam sumber data
    Console.Write("Sumber data {0}: ", vbTab)
    For Each i As Integer In bilangan
      Console.Write(i & " ")
    Next
    
    'menampilkan elemen-elemen dalam hasil1
    Console.WriteLine()
    Console.Write("Hasil query 1 {0}: ", vbTab)
    For Each i As Integer In hasil1
      Console.Write(i & " ")
    Next
        
    'menampilkan elemen-elemen dalam hasil2
    Console.WriteLine()    
    Console.Write("Hasil query 2 {0}: ", vbTab)
    For Each i As Integer In hasil2
      Console.Write(i & " ")
    Next

    Console.ReadLine()
  End Sub
End Module
