Module Program    
  Sub Main()  
    'array berukuran 4x3 (4 baris, 3 kolom)
    Dim tabel(3,2) As Integer
    
    'mengisi nilai ke dalam array.
    'baris pertama
    tabel(0,0) = 1
    tabel(0,1) = 5
    tabel(0,2) = 3
    
    'baris kedua
    tabel(1,0) = 2
    tabel(1,1) = 4
    tabel(1,2) = 1
    
    'baris ketiga
    tabel(2,0) = 3
    tabel(2,1) = 2
    tabel(2,2) = 4
    
    'baris keempat
    tabel(3,0) = 4
    tabel(3,1) = 3
    tabel(3,2) = 2
    
    'mencetak array
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
