Module Program        
  Sub Main()
    Dim A As Array = {10,20,30,40,50}
    Dim B As Array
    
    'mengalokasikan memori
    'sebanyak 3 elemen untuk array B
    B = New Integer(2) {}
    
    'menyalin 3 elemen pertama
    'dari array A ke array B
    Array.Copy(A, B, 3)
        
    'menampilkan array sebelum dibalik
    Console.Write("Isi array A: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
    
    'membalik urutan array
    Array.Reverse(A)
    
    'menampilkan array setelah dibalik
    Console.Write("Isi array B: ")
    For Each elemen In B
      Console.Write("{0} ", elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
