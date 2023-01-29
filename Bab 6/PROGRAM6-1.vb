'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double  
End Class

'program utama
Module Program        
  Sub Main()
    'mendeklarasikan variabel lokal
    Dim luas As Double
    
    'mendeklarasikan referensi ke kelas Segiempat
    Dim se As Segiempat
    
    'membuat objek dari kelas Segiempat
    se = New Segiempat()
    
    'mengisi nilai objek
    se.panjang = 8
    se.lebar = 6
    
    'menghitung luas
    luas = se.panjang * se.lebar
    
    'menampilkan luas
    Console.WriteLine("Luas segiempat = {0}", luas)
    
    Console.ReadLine()
  End Sub
End Module
