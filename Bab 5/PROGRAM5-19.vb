Module Program    
  'metode (fungsi) untuk menghitung nilai rata-rata
  Function HitungRataRata(A() As Integer) As Double
    Dim jumlah As Integer = 0
    Dim rata2 As Double
    For Each elemen In A
      jumlah += elemen
    Next
    rata2 = jumlah / A.Length
    Return rata2
  End Function
  
  'metode (prosedur) untuk menampilkan isi array
  Sub TampilkanArray(A() As Integer)
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
  End Sub
  
  'metode (prosedur) utama
  Sub Main()
    'membuat array
    Dim data() As Integer = {10,20,30,40,50}
    Dim hasil As Double
    
    'memanggil metode TampilkanArray()
    'dan menggunakan array data sebagai parameter
    Console.Write("Isi array: ")
    TampilkanArray(data)
    
    'memanggil metode HitungRataRata()
    'dan menggunakan array data sebagai parameter
    hasil = HitungRataRata(data)
    Console.WriteLine("Rata-rata: {0}", hasil)
    
    Console.ReadLine()
  End Sub
End Module
