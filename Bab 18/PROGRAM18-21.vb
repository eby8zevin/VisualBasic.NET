Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe Stack<T>    
    Dim stack As Stack(Of String) = _
      New Stack(Of String)()
    
    'menambah elemen menggunakan Push()
    stack.Push("Visual Basic .NET")
    stack.Push("Python")
    stack.Push("C++")
    stack.Push("Java")
    stack.Push("Ruby")
    
    'mengakses elemen koleksi
    'menggunakan statemen For Each
    'tidak mengubah elemen di dalam koleksi
    Console.WriteLine("Isi stack:")
    For Each elemen As String In stack    
      Console.WriteLine(elemen)
    Next
    
    Console.WriteLine()
    
    'mengakses elemen terakhir menggunakan Peek()
    'tidak mengubah elemen di dalam koleksi
    Dim elemenTerakhir As String = stack.Peek()
    Console.WriteLine("Elemen terakhir: {0}", _ 
                      elemenTerakhir)

    'menampilkan jumlah elemen koleksi
    'setelah pemanggilan Peek()
    Console.WriteLine("Jumlah elemen setelah " _
                    & "pamanggilan Peek(): {0}", _
                    stack.Count)
    
    'mengambil setiap elemen di dalam koleksi
    'menggunakan Pop()
    Console.WriteLine()
    Console.WriteLine("Mengambil elemen dalam stack:")
    Dim n As Integer = stack.Count
    For i As Integer = 0 To n-1    
      Console.WriteLine(stack.Pop())
    Next
    
    Console.WriteLine()
    Console.WriteLine("Jumlah elemen setelah " _
                    & "pamanggilan Pop(): {0}", _
                    stack.Count)
    
    Console.ReadLine()
  End Sub
End Module
