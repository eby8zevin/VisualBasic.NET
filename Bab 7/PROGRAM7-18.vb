Class Segiempat
  'data statis (class variable)
  Private Shared Counter As Integer = 0
  
  'data non-statis (instance variable)
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
    'menaikkan nilai Counter
    Counter += 1
  End Sub
  
  'instance method
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  'class method
  Public Shared Function GetCounter() As Integer
    Return Counter
  End Function
End Class

Module Program
  Sub Main()
    Console.WriteLine("Jumlah objek awal: " _
      & Segiempat.GetCounter())
    
    'membuat objek pertama
    Dim se1 As Segiempat = New Segiempat(4,2)
    'membuat objek kedua
    Dim se2 As Segiempat = New Segiempat(6,4)
    'membuat objek ketiga
    Dim se3 As Segiempat = New Segiempat(8,6)
    
    Console.WriteLine("Jumlah objek akhir: " _
      & Segiempat.GetCounter())
    
    Console.ReadLine()
  End Sub
End Module
