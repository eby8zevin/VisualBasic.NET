Imports System.Collections.Generic

Module Program 
  Sub Main()
    'membuat koleksi bertipe LinkedList(Of T)    
    Dim dll As LinkedList(Of Integer) = _
      New LinkedList(Of Integer)()
    
    'menambah node menggunakan AddLast()    
    dll.AddLast(20)
    dll.AddLast(30)
    dll.AddLast(40)
    dll.AddLast(50)
    
    'menambah node menggunakan AddFirst()
    dll.AddFirst(10)
    
    'mengambil node pertama
    'dan menyimpannya ke referensi ptrMaju
    Dim ptrMaju As LinkedListNode(Of Integer) = dll.First
    
    'mengambil node terakhir
    'dan menyimpannya ke referensi ptrMundur
    Dim ptrMundur As LinkedListNode(Of Integer) = dll.Last
        
    'menelusuri semua node dalam linked list
    'menggunakan ptrMaju
    Console.WriteLine("Isi linked list dari awal sampai akhir:")    
    While Not IsNothing(ptrMaju)
      Console.WriteLine(ptrMaju.Value)
      'ptrMaju menunjuk ke node berikutnya
      ptrMaju = ptrMaju.Next
    End While
    
    'menelusuri semua node dalam linked list
    'menggunakan ptrMundur
    Console.WriteLine()
    Console.WriteLine("Isi linked list dari akhir sampai awal:")
    while Not IsNothing(ptrMundur)
      Console.WriteLine(ptrMundur.Value)
      'ptrMundur menunjuk ke node sebelumnya
      ptrMundur = ptrMundur.Previous
    End While
    
    Console.ReadLine()
  End Sub
End Module
