Imports System.Collections.Generic

Module Program 
  'asumsi: node pertama berada pada indeks ke-0
  Function CariPosisiNode( _
             node As LinkedListNode(Of Integer),
             koleksi As LinkedList(Of Integer)) _
             As Integer
    Dim ptr As LinkedListNode(Of Integer) = node
    Dim counter As Integer = 0
    While Not IsNothing(ptr.Previous)
      counter += 1
      ptr = ptr.Previous
    End While
    Return counter
  End Function

  Sub Main()
    'membuat koleksi bertipe LinkedList(Of T)    
    Dim sll As LinkedList(Of Integer) = _
      New LinkedList(Of Integer)()
    
    'menambah node menggunakan AddLast()
    sll.AddLast(30)
    sll.AddLast(10)
    sll.AddLast(40)
    sll.AddLast(50)
    sll.AddLast(10)
    sll.AddLast(20)
    sll.AddLast(30)
    sll.AddLast(10)
    sll.AddLast(20)
    
    'menampilkan isi koleksi
    Console.Write("Isi linked list: ")
    For Each nilai As Integer In sll
      Console.Write(nilai & " ")
    Next
    Console.WriteLine()
    
    'mencari node menggunakan metode Find()
    Dim node1 As LinkedListNode(Of Integer) = sll.Find(10)
    Dim indeks1 As Integer = CariPosisiNode(node1, sll)
    
    'mencari node menggunakan metode FindLast()
    Dim node2 As LinkedListNode(Of Integer) = sll.FindLast(10)
    Dim indeks2 As Integer = CariPosisiNode(node2, sll)
    
    'menampilkan indeks yang ditemukan
    Console.WriteLine()
    Console.WriteLine("10 pertama ditemukan " _
                    & "pada indeks ke-" & indeks1)
    Console.WriteLine("10 terakhir ditemukan " _
                    & "pada indeks ke-" & indeks2)
    
    Console.ReadLine()
  End Sub
End Module
