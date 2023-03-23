Imports System.Collections.Generic

Module Program
  Sub TampilkanKoleksi(keterangan As String, _
                       s As HashSet(Of Integer))
    Console.Write(keterangan & vbTab)
    For Each elemen As Integer In s
      Console.Write(elemen & " ")
    Next
    Console.WriteLine()
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe HashSet(Of T)
    Dim A As HashSet(Of Integer) = _
      New HashSet(Of Integer)()
    Dim B As HashSet(Of Integer) = _
      New HashSet(Of Integer)()
    Dim C As HashSet(Of Integer) = _
      New HashSet(Of Integer)()
    
    'menambah elemen ke dalam koleksi
    '(himpunan A)
    A.Add(10)
    A.Add(20)
    A.Add(30)
    A.Add(60)
         
    'menambah elemen ke dalam koleksi
    '(himpunan B)
    B.Add(20)
    B.Add(30)
    B.Add(40)
    B.Add(50)
    B.Add(60) 
    
    'menambah elemen ke dalam koleksi
    '(himpunan C)
    C.Add(60)
    C.Add(70)
    
    'menampilkan isi koleksi A, B, dan C
    TampilkanKoleksi("Isi A:", A)
    TampilkanKoleksi("Isi B:", B)
    TampilkanKoleksi("Isi C:", C)
    
    'gabungan B dan C
    B.UnionWith(C)
    Console.WriteLine()
    TampilkanKoleksi("B gabungan C:", B)
    
    'irisan A dan B
    A.IntersectWith(B)
    TampilkanKoleksi("A irisan B:", A)
    
    Console.ReadLine()
  End Sub
End Module
