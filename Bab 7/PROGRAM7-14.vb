Class Segiempat
  Public panjang As Double
  Public lebar As Double
  
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  Public Sub CetakLuas()
    Console.WriteLine("Luas = " & HitungLuas())
  End Sub
  
End Class

Module Program
  Sub Main()
    Dim se As Segiempat

    'object initializer
    se = New Segiempat With {
      .panjang = 8,
      .lebar = 6
    }
    
    'menampilkan luas
    se.CetakLuas()
    
    Console.ReadLine()
  End Sub
End Module
