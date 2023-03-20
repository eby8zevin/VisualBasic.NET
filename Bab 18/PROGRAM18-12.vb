Imports System.Collections.Generic

Module Program
  Sub Main()
    'membuat koleksi bertipe List(Of T)
    Dim list As List(Of String) = New List(Of String)()
    list.Add("Java")
    list.Add("Visual Basic .NET")
    list.Add("Ruby")
    list.Add("Python")    
    list.Add("C#")
    
    'menampilkan isi koleksi
    'sebelum diurutkan
    Console.WriteLine("Isi list sebelum pengurutan:")
    For Each elemen As String In list
      Console.WriteLine(elemen)
    Next
    
    'mengurutkan elemen (descending)
    list.Sort()
    list.Reverse()
        
    'menampilkan isi koleksi
    Console.WriteLine()
    Console.WriteLine("Isi list setelah pengurutan:")
    For Each elemen As String In list
      Console.WriteLine(elemen)
    Next       
    
    Console.ReadLine()
  End Sub
End Module
