Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa List(Of T)    
    Dim list As List(Of String) = New List(Of String)()

    'menambah data ke dalam list    
    list.Add("Visual Basic .NET")
    list.Add("Python")
    list.Add("C#")
    list.Add("Perl")
    list.Add("C++")
    list.Add("Ruby")
    list.Add("Pascal")
    
    'menampilkan isi list
    Console.WriteLine("Sumber data: ")
    For Each elemen As String In list    
      Console.WriteLine(elemen)
    Next
        
    'membuat query
    Dim hasil = from e in list
                where e(0) = "P"c
                select e
    
    Console.WriteLine("{0}Hasil query: ", _
      vbNewLine)

    'eksekusi query
    For Each s As String In hasil
      Console.WriteLine(s)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
