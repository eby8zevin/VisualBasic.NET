Module Program    
  Sub Main()
    'array satu dimensi
    Dim A() = {10,20,30,40,50}
    
    'array dua dimensi
    Dim B(,) = { _
      {10,20}, _
      {30,40}, _
      {50,60}, _
      {70,80} _
    }
    
    'menampilkan jumlah dimensi
    Console.WriteLine("Jumlah dimensi array A: {0}", _
      A.Rank)
    Console.WriteLine("Jumlah dimensi array B: {0}", _
      B.Rank)
    
    Console.WriteLine()
    
    'menampilkan array
    Console.WriteLine("Isi array A:")
    For Each elemen In A 
      Console.Write("{0} ", elemen)
    Next
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Isi array B:")
    For i=0 To 3
      For j=0 To 1
        Console.Write("{0} ", B(i,j))
      Next
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
