Module Program    
  Sub Main()
    Dim A As Integer()

    'mengakses array sebelum dialokasikan
    A(0) = 10
    A(1) = 20
    A(2) = 30
    A(3) = 40
    A(4) = 50
    A(5) = 60
    A(6) = 70
    A(7) = 80
    A(8) = 90
    A(9) = 100
    A(10) = 110
    
    'menampilkan elemen array
    Console.Write("Isi array{0}: ", Chr(9))
    For i=A.GetLowerBound(0) To A.GetUpperBound(0)
      Console.Write("{0} ", A(i))
    Next
    
    Console.ReadLine()
  End Sub
End Module
