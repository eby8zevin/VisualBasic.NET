'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  'mendefinisikan metode CetakLuas()
  Public Sub CetakLuas()
    'mendeklarasikan variabel lokal
    Dim luas As Double
    'menghitung luas
    luas = panjang * lebar
    'menampilkan luas
    Console.WriteLine("Luas segiempat = {0}", _
      luas)
  End Sub
End Class

Module Program        
  Sub Main()    
    Dim se As Segiempat
    
    'membuat objek dari kelas Segiempat
    'dan ditunjuk oleh se
    se = New Segiempat()  
  
    'mengisi nilai objek
    se.panjang = 8
    se.lebar = 6      
        
    'memanggil metode CetakLuas()
    se.CetakLuas()    
    
    Console.ReadLine()
  End Sub
End Module
