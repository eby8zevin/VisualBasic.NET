Imports System

Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  'mendefinisikan konstruktor
  Public Sub New(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  'mendefinisikan metode untuk mengubah data
  Public Sub UbahData(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
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
    Dim se1, se2 As Segiempat
    
    se1 = New Segiempat(8, 6)
    se2 = New Segiempat(10, 5)
    
    se1.CetakLuas("Luas objek pertama " & Chr(9) & "= ")    
    se2.CetakLuas("Luas objek kedua " & Chr(9) & "= ")
    
    Console.ReadLine()
  End Sub
End Module
