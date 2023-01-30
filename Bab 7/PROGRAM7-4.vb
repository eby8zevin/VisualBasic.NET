Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor dengan dua parameter
  Public Sub New(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  'konstruktor dengan satu parameter
  Public Sub New(sisi As Double)
    panjang = sisi
    lebar = sisi
  End Sub  
  
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())  
  End Sub  
End Class

Module Program        
  Sub Main()        
    Dim persegipanjang As Segiempat
    Dim bujurssangkar As Segiempat
    
    'membuat objek persegi panjang
    persegipanjang = New Segiempat(8, 6)
    
    'membuat objek bujursangkar
    bujurssangkar = New Segiempat(4)
    
    'memanggil metode CetakLuas()    
    persegipanjang.CetakLuas( _
      "Luas persegi panjang " & Chr(9) & ": ")
    bujurssangkar.CetakLuas( _
      "Luas bujursangkar " & Chr(9) & ": ")    
    
    Console.ReadLine()
  End Sub
End Module
