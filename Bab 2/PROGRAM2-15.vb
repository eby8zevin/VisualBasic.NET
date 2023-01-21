Module Program
  Sub Main()    
    Dim harga As Decimal
    Dim diskon As Single
    Dim hargadiskon As Decimal
        
    harga = 500000000D
    diskon = 0.1  'diskon 10%
    hargadiskon = harga - (harga * diskon)
    
    Console.WriteLine("Harga Normal = {0}", harga)
    Console.WriteLine("Harga Diskon = {0}", hargadiskon)          
        
    Console.ReadLine()
  End Sub
End Module
