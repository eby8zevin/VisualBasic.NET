Module Program    
  Sub Main()
    'array penampung data bilangan
    Dim A As Integer()
    'jumlah data
    Dim n As Integer
    'variabel bantu untuk menampung jumlah total
    Dim jumlah As Integer = 0
    
    Console.WriteLine("RATA-RATA BILANGAN")
    Console.WriteLine("==================")
    Console.WriteLine()
    
    Console.Write("Masukkan jumlah data yang diinginkan: ")
    n = Int32.Parse(Console.ReadLine())
    
    'alokasi array dengan n jumlah elemen
    A = New Integer(n-1) {}
    
    'mengisi nilai ke dalam elemen array
    For i=0 To n-1
      Console.Write("Data ke-{0}: ", i+1)
      A(i) = Int32.Parse(Console.ReadLine())
    Next
    
    Console.WriteLine()
    
    'menampilkan elemen array
    Console.Write("Isi array: ")
    For i=A.GetLowerBound(0) To A.GetUpperBound(0)
      Console.Write("{0} ", A(i))
      jumlah += A(i)
    Next
    
    Console.WriteLine()
    Console.WriteLine("Rata-rata = {0}", jumlah / n)
    
    Console.ReadLine()
  End Sub
End Module
