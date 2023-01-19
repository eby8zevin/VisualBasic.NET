Module Program  
  Sub Main()    
    Dim s As String
    Dim i As Integer
    Dim d As Double
    
    'membaca data bilangan bulat
    Console.Write("Masukkan bilangan bulat: ")    
    s = Console.ReadLine()
    'konversi dari tipe String ke Int32
    'menggunakan metode Parse()
    i = Int32.Parse(s)
    Console.WriteLine("Anda memasukkan bilangan {0}", i)  
    
    Console.WriteLine() 'baris baru
    
    'membaca data bilangan riil    
    Console.Write("Masukkan bilangan riil: ")
    s = Console.ReadLine()
    'konversi dari tipe String ke Double
    'menggunakan kelas Convert
    d = Convert.ToDouble(s)
    Console.WriteLine("Anda memasukkan bilangan {0}", d)    
    
    Console.ReadLine()
  End Sub
End Module
