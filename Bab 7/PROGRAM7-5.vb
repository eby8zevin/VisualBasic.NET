Class ParameterArray
  Public Sub CetakBilangan(ParamArray daftar() As Integer)
    For i As Integer = 0 To UBound(daftar)
      Console.Write(daftar(i) & " ")
    Next
    Console.WriteLine()
  End Sub
  
  Public Function HitungJumlah(ParamArray daftar() As Integer) _
    As Integer
    Dim jumlah As Integer = 0
    For i As Integer = 0 To UBound(daftar)
      jumlah += daftar(i)
    Next
    Return jumlah
  End Function  
End Class

Module Program        
  Sub Main()        
    'membuat objek ParameterArray
    Dim obj As ParameterArray
    obj = New ParameterArray()
    
    'memanggil metode CetakBilangan() dan HitungJumlah()
    'dengan dua parameter
    obj.CetakBilangan(1, 2)
    Console.Write("Jumlah = ")
    Console.WriteLine(obj.HitungJumlah(1, 2))
    Console.WriteLine()
    
    'memanggil metode CetakBilangan() dan HitungJumlah()
    'dengan tiga parameter
    obj.CetakBilangan(10, 20, 30)
    Console.Write("Jumlah = ")
    Console.WriteLine(obj.HitungJumlah(10, 20, 30))
    Console.WriteLine()
    
    'memanggil metode CetakBilangan() dan HitungJumlah()
    'dengan lima parameter
    obj.CetakBilangan(100, 200, 300, 400, 500)
    Console.Write("Jumlah = ")
    Console.WriteLine(obj.HitungJumlah(100, 200, 300, 400, 500))
    
    Console.ReadLine()
  End Sub
End Module
