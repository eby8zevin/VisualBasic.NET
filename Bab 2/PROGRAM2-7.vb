Module Program  
  Sub Main()    
    Dim s As String
    Dim i As Integer
    Dim d As Double
    
    'membaca data bilangan bulat
    Console.Write("Masukkan bilangan bulat: ")    
    s = Console.ReadLine()
    'konversi dari tipe String ke Int32
    If (Int32.TryParse(s, i)) Then
      Console.WriteLine("Anda memasukkan bilangan {0}", i)  
    Else
      Console.WriteLine("Konversi ke Int32 gagal")
    End If    
    
    Console.WriteLine() 'baris baru
    
    'membaca data bilangan riil    
    Console.Write("Masukkan bilangan riil: ")
    s = Console.ReadLine()
    'konversi dari tipe String ke Double
    If (Double.TryParse(s, d)) Then
      Console.WriteLine("Anda memasukkan bilangan {0}", d)  
    Else
      Console.WriteLine("Konversi ke Double gagal")
    End If
    
    Console.ReadLine()
  End Sub
End Module
