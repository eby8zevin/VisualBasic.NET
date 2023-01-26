Module Program    
  Sub Main()
    Dim A(10) As Integer
    
    'menampilkan jumlah elemen array
    Console.WriteLine("Jumlah elemen{0}: {1}", _
      Chr(9), A.Length)
    
    'menampilkan tipe variabel A
    Console.WriteLine("Tipe A{0}: {1}", _
      Chr(9), A.GetType())
    
    'mengisi nilai ke dalam array
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
    For i=0 To A.Length-1
      Console.Write("{0} ", A(i))
    Next
    
    Console.ReadLine()
  End Sub
End Module
