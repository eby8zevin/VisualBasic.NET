'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double  
End Class

'program utama
Module Program        
  Sub Main()    
    'mendeklarasikan dua referensi ke kelas Segiempat
    Dim se1, se2 As Segiempat
    
    'membuat objek dari kelas Segiempat
    'dan ditunjuk oleh se1
    se1 = New Segiempat()
    
    'se2 menunjuk ke objek yang sedang
    'ditunjuk oleh se1
    se2 = se1
    
    'mengisi nilai objek pertama
    se1.panjang = 8
    se1.lebar = 6      
        
    'menampilkan data awal
    Console.WriteLine("DATA AWAL:")
    Console.WriteLine("se1.panjang {0}= {1}", _
      Chr(9), se1.panjang)
    Console.WriteLine("se1.lebar {0}= {1}", _
      Chr(9), se1.lebar)
    Console.WriteLine("se2.panjang {0}= {1}", _
      Chr(9), se2.panjang)
    Console.WriteLine("se2.lebar {0}= {1}", _
      Chr(9), se2.lebar)
    
    Console.WriteLine()
    
    'mengubah nilai objek pertama
    se1.panjang = 10
    se1.lebar = 5
    
    'menampilkan data akhir
    Console.WriteLine("DATA AKHIR:")
    Console.WriteLine("se1.panjang {0}= {1}", _
      Chr(9), se1.panjang)
    Console.WriteLine("se1.lebar {0}= {1}", _
      Chr(9), se1.lebar)
    Console.WriteLine("se2.panjang {0}= {1}", _
      Chr(9), se2.panjang)
    Console.WriteLine("se2.lebar {0}= {1}", _
      Chr(9), se2.lebar)    
    
    Console.ReadLine()
  End Sub
End Module
