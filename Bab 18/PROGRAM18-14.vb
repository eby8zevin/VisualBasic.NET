Imports System.Collections.Generic

Module Program
  'metode untuk menampilkan string
  Sub Tulis(ByVal s As String)
    Console.WriteLine(s)
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe List(Of T)
    Dim list As List(Of String) = New List(Of String)()
    list.Add("Visual Basic .NET")
    list.Add("C#")
    list.Add("Java")
    list.Add("Python")
    list.Add("Ruby")
    
    'menampilkan isi koleksi (list)
    'menggunakan metode ForEach()
    'dan metode Tulis() sebagai parameternya
    Console.WriteLine("Isi list:")
    list.ForEach(AddressOf Tulis)
    
    Console.ReadLine()
  End Sub
End Module
