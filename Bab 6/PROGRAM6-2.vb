'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double  
End Class

'program utama
Module Program        
  Sub Main()
    'mendeklarasikan variabel lokal
    Dim luas1, luas2 As Double
    
    'mendeklarasikan dua referensi ke kelas Segiempat
    Dim se1, se2 As Segiempat
    
    'membuat objek dari kelas Segiempat
    se1 = New Segiempat()
    se2 = New Segiempat()
    
    'mengisi nilai objek pertama
    se1.panjang = 8
    se1.lebar = 6      
    
    'mengisi nilai objek kedua
    se2.panjang = 10
    se2.lebar = 5      
    
    'menghitung luas
    luas1 = se1.panjang * se1.lebar
    luas2 = se2.panjang * se2.lebar
    
    'menampilkan luas
    Console.WriteLine("Luas objek pertama {0}= {1}", _
      Chr(9), luas1)
    Console.WriteLine("Luas objek kedua {0}= {1}", _
      Chr(9), luas2)
    
    Console.ReadLine()
  End Sub
End Module
