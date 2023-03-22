Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe LinkedList(Of T)    
    Dim sll As LinkedList(Of Integer) = _
      New LinkedList(Of Integer)()
    
    'menambah node menggunakan AddLast()
    sll.AddLast(40)
    sll.AddLast(50)
    
    'menambah node menggunakan AddFirst()
    sll.AddFirst(10)
    
    'mengambil node pertama
    'dan menyimpannya ke referensi ptr
    Dim ptr As LinkedListNode(Of Integer) = sll.First
    
    'menambah node setelah ptr
    sll.AddAfter(ptr, 30)
    
    'mengubah posisi ptr untuk menunjuk
    'ke node berikutnya
    ptr = ptr.Next  'ptr menunjuk ke 30

    'menambah node sebelum ptr
    sll.AddBefore(ptr, 20)
    
    'menampilkan isi linked list
    Console.WriteLine("Isi linked list:")
    ptr = sll.First   'ptr menunjuk ke node pertama
    While Not IsNothing(ptr)
      Console.WriteLine(ptr.Value)
      ptr = ptr.Next  'menunjuk ke node berikutnya
    End While
    
    Console.ReadLine()
  End Sub
End Module
