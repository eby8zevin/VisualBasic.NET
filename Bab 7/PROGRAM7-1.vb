Class Segiempat
  'mendeklarasikan data Private
  Private panjang As Double
  Private lebar As Double
  
  Public Sub IsiData(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
    
  'mendefinisikan metode Private
  Private Function HitungLuas()
    Return panjang * lebar
  End Function
  
  'mendefinisikan metode untuk mencetak luas
  Public Sub CetakLuas()
    Console.WriteLine("Luas = " & HitungLuas())
  End Sub
  
End Class

Module Program        
  Sub Main()    
    Dim se As Segiempat
    
    se = New Segiempat()
    
    'se.panjang = 8    'salah karena mengakses data Private
    'se.lebar = 6
    
    se.IsiData(8, 6)
    
    'Baris di bawah ini salah karena mengakses metode Private
    'Dim luas As Double = se.HitungLuas()
    
    se.CetakLuas()
    
    Console.ReadLine()
  End Sub
End Module
