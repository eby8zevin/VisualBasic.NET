'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  'mendefinisikan metode HitungLuas()
  Public Function HitungLuas() As Double
    'mendeklarasikan variabel lokal
    Dim luas As Double
    'menghitung luas
    luas = panjang * lebar
    'mengembalikan nilai
    Return luas
  End Sub
End Class

Module Program        
  Sub Main()    
    Dim se As Segiempat
    Dim L As Double
    
    'membuat objek dari kelas Segiempat
    'dan ditunjuk oleh se
    se = New Segiempat()  
  
    'mengisi nilai objek
    se.panjang = 8
    se.lebar = 6      
        
    'memanggil metode HitungLuas()
    L = se.HitungLuas()    
    
    Console.ReadLine()
  End Sub
End Module
