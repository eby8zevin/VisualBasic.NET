Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  Public Sub New(Optional panjang As Double = 4, _
                 Optional lebar As Double = 2)
    Me.panjang = panjang
    Me.lebar = lebar
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
    Dim se1, se2 As Segiempat
    
    'membuat objek dengan nilai default
    se1 = New Segiempat()
    
    'membuat objek dengan nilai lain
    se2 = New Segiempat(10,5)
    
    'menampilkan luas
    se1.CetakLuas("Luas se1: ")
    se2.CetakLuas("Luas se2: ")    
                                 
    Console.ReadLine()
  End Sub
End Module
