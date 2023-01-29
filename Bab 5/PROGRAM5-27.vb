Module Program        
  Sub Main()
    Dim A As Array
    Dim B As Array
    
    'mengalokasikan 3 elemen
    'untuk array A
    A = New Integer(2) {77,88,99}
    
    'mengalokasikan 8 elemen
    'untuk array B
    B = Array.CreateInstance(GetType(Integer), 8)
    
    'mengisi 5 elemen pertama ke array B
    B(0) = 10
    B(1) = 20
    B(2) = 30
    B(3) = 40
    B(4) = 50
    
    Console.WriteLine("SEBELUM PENYALINAN")    
    'menampilkan array A
    Console.Write("Isi array A: ")
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
        
    'menampilkan array B
    Console.Write("Isi array B: ")
    For Each elemen In B
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
    
    'menyalin semua elemen
    'dari array A ke array B dan
    'menempatkannya pada indeks ke-5
    A.CopyTo(B, 5)
        
    'menampilkan array setelah pemanggilan CopyTo()
    Console.WriteLine()
    Console.WriteLine("SETELAH PENYALINAN")
    Console.Write("Isi array B: ")
    For Each elemen In B
      Console.Write("{0} ", elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
