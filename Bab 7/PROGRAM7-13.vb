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
    se = New Segiempat
    With se
      .panjang = 8
      .lebar = 6
    End With
    
    'menampilkan luas
    se.CetakLuas()
    
    Console.ReadLine()
  End Sub
End Module
