Class Pembagian
  'metode Bagi dengan parameter bertipe Integer  
  Public Function Bagi(a As Integer, b As Integer) _
    As Integer
    Return a \ b
  End Function
  
  'metode Bagi dengan parameter bertipe Double
  Public Function Bagi(a As Double, b As Double) _
    As Double
    Return a / b
  End Function  
End Class

Module Program        
  Sub Main()    
    'membuat objek dari kelas Pembagian
    Dim obj As Pembagian
    obj = New Pembagian()
    
    Dim hasilbagi1 As Integer
    'memanggil metode Bagi()
    'dengan parameter bertipe Integer
    hasilbagi1 = obj.Bagi(10, 3)
        
    Dim hasilbagi2 As Double
    'memanggil metode Bagi()
    'dengan parameter bertipe Double
    hasilbagi2 = obj.Bagi(10.0, 3.0)
    
    Console.WriteLine("10 / 3 = {0}", hasilbagi1)
    Console.WriteLine("10.0 / 3.0 = {0}", hasilbagi2)
    
    Console.ReadLine()
  End Sub
End Module
