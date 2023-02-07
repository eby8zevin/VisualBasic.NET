Class Segiempat
  'data dengan tipe akses Protected
  Protected panjang As Double
  Protected lebar As Double
  
  'konstruktor kelas Segiempat
  Public Sub New(ByVal panjang As Double, _
                 ByVal lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  'metode dengan tipe akses Protected
  Protected Function HitungLuas() As Double
    Return panjang * lebar
  End Function
End Class

Class SegiempatBerwarna: Inherits Segiempat
  Private warna As String
  
  'konstruktor kelas SegiempatBerwarna
  Public Sub New(ByVal panjang As Double, _
                 ByVal lebar As Double, _
                 ByVal warna As String)
    MyBase.New(panjang, lebar)
    Me.warna = warna
  End Sub
  
  Public Sub CetakData()
    'mengakses data panjang dan lebar
    Console.WriteLine("panjang {0}= {1}", vbTab, panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, lebar)

    Console.WriteLine("warna {0}= {1}", vbTab, warna)
    Console.WriteLine()

    'memanggil metode HitungLuas()
    Console.WriteLine("luas {0}= {1}", vbTab, HitungLuas())
  End Sub

  '...

End Class  

Module Program
  Sub Main()
    'membuat objek dari kelas SegiempatBerwarna
    Dim obj As SegiempatBerwarna = _
      New SegiempatBerwarna(8, 6, "merah")

    obj.CetakData()
    
    Console.ReadLine()
  End Sub
End Module
