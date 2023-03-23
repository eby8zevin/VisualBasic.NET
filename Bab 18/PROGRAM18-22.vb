Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe Queue<T>    
    Dim queue As Queue(Of String) = _
      New Queue(Of String)()
    
    'menambah elemen menggunakan Enqueue()
    queue.Enqueue("Visual Basic .NET")
    queue.Enqueue("Python")
    queue.Enqueue("C++")
    queue.Enqueue("Java")
    queue.Enqueue("Ruby")
    
    'mengakses elemen koleksi
    'menggunakan statemen foreach
    'tidak mengubah elemen di dalam koleksi
    Console.WriteLine("Isi queue:")
    For Each elemen As String In queue    
      Console.WriteLine(elemen)
    Next
    
    Console.WriteLine()
    
    'mengakses elemen pertama menggunakan Peek()
    'tidak mengubah elemen di dalam koleksi
    Dim elemenPertama As String = queue.Peek()
    Console.WriteLine("Elemen pertama: {0}", _ 
                      elemenPertama)

    'menampilkan jumlah elemen koleksi
    'setelah pemanggilan Peek()
    Console.WriteLine("Jumlah elemen setelah " _
                    & "pamanggilan Peek(): {0}", _
                     queue.Count)
    
    'mengambil setiap elemen di dalam koleksi
    'menggunakan Dequeue()
    Console.WriteLine()
    Console.WriteLine("Mengambil elemen dalam queue:")
    While queue.Count > 0
      Console.WriteLine(queue.Dequeue())
    End While
    
    Console.WriteLine()
    Console.WriteLine("Jumlah elemen setelah " _
                    & "pamanggilan Dequeue(): {0}", _
                    queue.Count)
    
    Console.ReadLine()
  End Sub
End Module
