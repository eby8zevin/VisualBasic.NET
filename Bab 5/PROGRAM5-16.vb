Module Program    
  Sub Main()  
    Const BARIS As Integer = 4
    Const KOLOM As Integer = 2
    
    'membuat array dua dimensi
    Dim Array2D As Integer(,) = _
      New Integer(BARIS-1, KOLOM-1) { _
          {10,20}, _
          {30,40}, _
          {50,60}, _
          {70,80} _
    }
        
    Console.WriteLine("Jumlah elemen{0}: {1}", _
      Chr(9), Array2D.Length)
    Console.WriteLine("Jumlah dimensi{0}: {1}", _
      Chr(9), Array2D.Rank)
    
    'menampilkan array
    Console.WriteLine("{0}Isi array: ", Chr(10))
    For i=0 To BARIS-1
      For j=0 To KOLOM-1
        Console.Write("{0} ", Array2D(i,j))
      Next
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
