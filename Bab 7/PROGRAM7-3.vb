Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  Public Sub New(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  'metode CetakLuas() tanpa parameter
  Public Sub CetakLuas()
    Console.WriteLine("Luas = " & HitungLuas())
  End Sub
  
  'metode CetakLuas() dengan satu parameter
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())  
  End Sub  
End Class

Module Program        
  Sub Main()    
    'membuat objek dari kelas Segiempat
    Dim se As Segiempat
    se = New Segiempat(8, 6)
    
    'memanggil metode CetakLuas()
    'tanpa parameter
    se.CetakLuas()
        
    'memanggil metode CetakLuas()
    'dengan parameter
    se.CetakLuas("Luas segiempat adalah ")
    
    Console.ReadLine()
  End Sub
End Module
