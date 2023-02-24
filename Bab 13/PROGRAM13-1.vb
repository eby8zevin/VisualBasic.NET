'mendeklarasikan tipe delegasi
Delegate Function OperasiBilangan( _
  ByVal a As Double, ByVal b As Double) _
  As Double

Module Program  
  
  Function Tambah(ByVal bil1 As Double, _
                  ByVal bil2 As Double) As Double
    Return bil1 + bil2  
  End Function
  
  Function Kurang(ByVal bil1 As Double, _
                  ByVal bil2 As Double) As Double
    Return bil1 - bil2  
  End Function
  
  Function Kali(ByVal bil1 As Double, _
                  ByVal bil2 As Double) As Double
    Return bil1 * bil2  
  End Function
  
  Function Bagi(ByVal bil1 As Double, _
                  ByVal bil2 As Double) As Double
    Return bil1 / bil2  
  End Function
  
  Sub Main()
    'mendeklarasikan variabel lokal
    Dim a As Double = 10
    Dim b As Double = 3
    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As OperasiBilangan
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Tambah()
    objDel = AddressOf Tambah
    
    'memanggil metode yang ditunjuk
    'oleh objek delegasi melalui objDel
    Console.WriteLine("{0} + {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Kurang()
    objDel = AddressOf Kurang
    Console.WriteLine("{0} - {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Kali()
    objDel = AddressOf Kali
    Console.WriteLine("{0} * {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Bagi()
    objDel = AddressOf Bagi
    Console.WriteLine("{0} / {1} = {2}",
      a, b, objDel(a, b))
    
    Console.ReadLine()
  End Sub
End Module
