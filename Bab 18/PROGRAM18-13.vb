Imports System.Collections.Generic

Module Program
  Sub Main()
    'membuat koleksi bertipe List(Of T)
    Dim list As List(Of String) = New List(Of String)()
    list.Add("Visual Basic .NET")
    list.Add("C#")
    list.Add("Java")
    list.Add("Python")
    list.Add("Ruby")
    
    'mengurutkan elemen sebelum pencarian
    list.Sort()
    
    'mencari elemen
    Dim indeks1 As Integer = _
      list.BinarySearch("Python")
    Dim indeks2 As Integer = _
      list.BinarySearch("Visual Basic .NET")
        
    'menampilkan isi koleksi
    Console.WriteLine("Isi list:")
    For Each elemen As String In list
      Console.WriteLine(elemen)
    Next     
    
    Console.WriteLine()
    Console.WriteLine("""Python"" berada pada indeks ke-{0}", _ 
                      indeks1)
    Console.WriteLine("""Visual Basic .NET"" berada " _
                      & "pada indeks ke-{0}", _
                      indeks2)    
    
    Console.ReadLine()
  End Sub
End Module
