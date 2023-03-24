Imports System.Collections.Generic

Module Program
  Sub TampilkanKoleksi(keterangan As String,
        koleksi As SortedSet(Of Integer))
    Console.Write("{0}{1}: ", keterangan, vbTab)
    For Each elemen As Integer In koleksi
      Console.Write(elemen & " ")
    Next
    Console.WriteLine()
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe SortedSet(Of T)
    Dim sortedset As SortedSet(Of Integer) = 
      New SortedSet(Of Integer)()
    
    'menambahkan elemen ke dalam koleksi
    '(elemen tidak berurutan)
    sortedset.Add(60)
    sortedset.Add(20)
    sortedset.Add(40)
    sortedset.Add(30)
    sortedset.Add(70)
    sortedset.Add(10)
    sortedset.Add(50)
        
    'menampilkan isi koleksi
    TampilkanKoleksi("Isi sorted set", sortedset)
    
    'mengakses elemen dengan nilai
    'antara 20 dan 40
    Dim view As SortedSet(Of Integer) = _
      sortedset.GetViewBetween(20,40)
    TampilkanKoleksi("Isi view:", view)
    
    'memindahkan elemen dengan predikat tertentu
    sortedset.RemoveWhere(Function(x) x >= 60)
    TampilkanKoleksi("Isi sorted set", sortedset)
    
    'membalik urutan elemen
    Dim temp As IEnumerable(Of Integer) = _
      sortedset.Reverse()
    Console.Write("Isi temp {0}: ", vbTab)
    For Each elemen As Integer In temp    
      Console.Write(elemen & " ")
    Next
    
    Console.ReadLine()
  End Sub
End Module
