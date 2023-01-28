Module Program    
  Sub Main()  
    'array berukuran 2x3x3 (2 halaman, 3 baris, 3 kolom)
    Dim A(1,2,2) As Integer
    
    'mengisi nilai ke dalam array.        
    'HALAMAN KE-1, baris pertama
    A(0, 0, 0) = 1
    A(0, 0, 1) = 0
    A(0, 0, 2) = 3
    
    'HALAMAN KE-1, baris kedua
    A(0, 1, 0) = 4
    A(0, 1, 1) = -1
    A(0, 1, 2) = 2
    
    'HALAMAN KE-1, baris ketiga
    A(0, 2, 0) = 8
    A(0, 2, 1) = 2
    A(0, 2, 2) = 1
    
    'HALAMAN KE-2, baris pertama
    A(1, 0, 0) = 6
    A(1, 0, 1) = 8
    A(1, 0, 2) = 3
    
    'HALAMAN KE-2, baris kedua
    A(1, 1, 0) = 4
    A(1, 1, 1) = 3
    A(1, 1, 2) = 6
    
    'HALAMAN KE-2, baris ketiga
    A(1, 2, 0) = 5
    A(1, 2, 1) = 9
    A(1, 2, 2) = 2
    
    'menampilkan array
    For i=0 To A.GetUpperBound(0)
      Console.WriteLine("HALAMAN KE-{0}", i+1)
      For j=0 To A.GetUpperBound(1)
        For k=0 To A.GetUpperBound(2)
          Console.Write("{0}  ", A(i,j,k))
        Next
        'membuat baris baru pada setiap nilai j
        Console.WriteLine()
      Next      
      'membuat baris baru pada setiap nilai i
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
