'kelas bagian pertama
Partial Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub  
End Class 'akhir kelas Segiempat bagian pertama

'kelas bagian kedua
Partial Class Segiempat
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  Public Sub CetakLuas()
    Console.WriteLine("Luas = " & HitungLuas())
  End Sub
  
End Class 'akhir kelas Segiempat bagian kedua

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Dim se As Segiempat = New Segiempat(8, 6)
    
    'memanggil metode CetakLuas()
    se.CetakLuas()
    
    Console.ReadLine()
  End Sub
End Module
