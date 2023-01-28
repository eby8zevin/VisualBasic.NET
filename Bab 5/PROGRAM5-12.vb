Module Program    
  Sub Main()  
    'array berukuran 2x3x3 (2 halaman, 3 baris, 3 kolom)
    Dim A( , , ) As Integer = { _
             { _
               {1,0,3}, _
               {4,-1,2}, _
               {8,2,1} _
             }, _
             { _
               {6,8,3}, _
               {4,3,6}, _
               {5,9,2} _
             } _
    }
    
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
