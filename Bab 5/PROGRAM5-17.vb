Module Program    
  Sub Main()  
    'membuat jagged array
    Dim jagged As Integer()() = _
      New Integer()() { _
          New Integer() {1,2,3}, _
          New Integer() {4,5}, _
          New Integer() {6,7,8,9}, _
          New Integer() {10,11,12,13,14,15} _
    }
        
    Console.WriteLine("Jumlah baris{0}: {1}", _
      Chr(9), jagged.Length)
    Console.WriteLine("Jumlah dimensi{0}: {1}", _
      Chr(9), jagged.Rank)
    
    Console.WriteLine()
    
    For i=0 To jagged.Length-1
      Console.WriteLine("Jumlah kolom pada baris ke-{0}: {1}", _
        (i+1), jagged(i).Length)
    Next
    
    'menampilkan array
    Console.WriteLine("{0}Isi array: ", Chr(10))
    For i=0 To jagged.Length-1
      For j=0 To jagged(i).Length-1
        Console.Write("{0} ", jagged(i)(j))
      Next
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
