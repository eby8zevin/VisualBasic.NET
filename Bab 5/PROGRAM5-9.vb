Module Program    
  Sub Main()  
    'array berukuran 4x3 (4 baris, 3 kolom)
    Dim tabel(,) As Integer = { _
      {1,5,3},  _
      {2,4,1},  _
      {3,2,4},  _
      {4,3,2}   _
    }    
  
    'menampilkan array
    For i=0 To tabel.GetUpperBound(0)
      'mencetak semua kolom dalam satu baris
      For j=0 To tabel.GetUpperBound(1)
        Console.Write("{0}  ", tabel(i,j))
      Next
      'membuat baris baru
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
