Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa objek dari kelas List(Of T)
    Dim A As List(Of Integer) = New List(Of Integer)()
    
    'menambah elemen dari -5 sampai 5 ke dalam list
    For i As Integer = -5 To 5
      A.Add(i)
    Next
        
    'menampilkan isi list
    Console.Write("Sumber data{0}: ", vbTab)
    For Each i As Integer In A
      Console.Write(i & " ")
    Next
    
    'membuat query menggunakan operator Not
    Dim hasil1 As IEnumerable(Of Integer) = _
                     from e in A
                     where Not (e Mod 2 = 0)  
                     select e

    'membuat query menggunakan operator Or
    Dim hasil2 As IEnumerable(Of Integer) = _
                     from e in A
                     where e < 0 Or e > 0
                     select e
    
    Console.Write("{0}Hasil query ke-1{1}: ", _
      vbNewLine, vbTab)
    For Each i As Integer In hasil1    
      Console.Write(i & " ")
    Next    
    
    Console.Write("{0}Hasil query ke-2{1}: ", _
      vbNewLine, vbTab)    
    For Each i As Integer In hasil2
      Console.Write(i & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
