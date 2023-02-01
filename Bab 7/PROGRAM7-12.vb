Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  Public Sub IsiData(p As Double, l As Double)
    panjang = p
    lebar = l
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
    Dim se As Segiempat
    
    'membuat objek
    se = New Segiempat()
    
    'mengisi data menggunakan metode IsiData()
    'dengan urutan parameter diubah
    se.IsiData(l:=6, p:=8)
    
    'menampilkan luas
    se.CetakLuas("Luas se: ")
                                 
    Console.ReadLine()
  End Sub
End Module
