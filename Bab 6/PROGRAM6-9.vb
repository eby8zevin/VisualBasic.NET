Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  'mendefinisikan konstruktor
  Public Sub New()
    panjang = 8
    lebar = 6
  End Sub
  
  'mendefinisikan metode untuk mengubah data
  Public Sub UbahData(p As Double, l As Double)
    panjang = p
    lebar = l
  End Sub
  
  'mendefinisikan metode untuk menghitung luas
  Public Function HitungLuas()
    Return panjang * lebar
  End Function
  
  'mendefinisikan metode untuk mencetak luas
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())
  End Sub
  
End Class

Module Program        
  Sub Main()    
    Dim se As Segiempat
    se = New Segiempat()
    
    se.CetakLuas("Luas awal " & Chr(9) & "= ")
    
    'mengubah data panjang dan lebar
    se.UbahData(10, 5)
    
    se.CetakLuas("Luas akhir " & Chr(9) & "= ")
    
    Console.ReadLine()
  End Sub
End Module
