Module Program
  'SALAH: konstanta tidak boleh dideklarasikan
  'menggunakan kata kunci ReadOnly, Static, maupun Shared
  ReadOnly Const PI As Double = 3.14  
  
  Sub Main()    
    Dim s As String
    Dim r, luas As Double
    
    'membaca data bilangan bulat
    Console.Write("Masukkan jari-jari: ")    
    s = Console.ReadLine()
    r = Convert.ToDouble(s)
    
    'menggunakan konstanta
    luas = PI * r * r
    
    Console.WriteLine("Luas lingkaran = {0}", luas)
    
    Console.ReadLine()
  End Sub
End Module
