'mendefinisikan kelas Segiempat
Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  'mendefinisikan metode dengan dua parameter
  Public Sub IsiData(p As Double, l As Double)
    panjang = p
    lebar = l
  End Sub
  
  'mendefinisikan metode untuk menghitung luas
  Public Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  'mendefinisikan metode untuk menampilkan luas
  Public Sub CetakLuas(s As String)
    Console.WriteLine("{0} {1}", s, HitungLuas())  
  End Sub
End Class

Module Program        
  Sub Main()    
    Dim se1, se2 As Segiempat
        
    se1 = New Segiempat()  
    se2 = New Segiempat()
  
    'mengisi data ke objek pertama
    se1.IsiData(8, 6)
    se2.IsiData(10,5)
    
    'menampilan luas
    se1.CetakLuas("Luas objek pertama " & Chr(9) & "=")
    se2.CetakLuas("Luas objek kedua " & Chr(9) & "=")
    
    Console.ReadLine()
  End Sub
End Module
