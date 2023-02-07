Class Segiempat
  Protected panjang As Double
  Protected lebar As Double
  
  Public Sub New()
    panjang = 0
    lebar = 0
  End Sub
  
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  Protected Function HitungLuas() As Double
    Return panjang * lebar
  End Function  
End Class

Class SegiempatBerwarna: Inherits Segiempat
  Private warna As String
  
  Public Sub New()
    MyBase.New()
    warna = ""
  End Sub
  
  Public Sub New(ByVal p As Double, _
                 ByVal l As Double, _
                 ByVal w As String)
    MyBase.New(p, l)
    warna = w
  End Sub
  
  Public Sub CetakData()
    Console.WriteLine("panjang {0}: {1}", vbTab, panjang)
    Console.WriteLine("lebar {0}: {1}", vbTab, lebar)
    Console.WriteLine("warna {0}: {1}", vbTab, warna)
  End Sub
  
  Public Sub CetakLuas()
    Console.WriteLine("Luas {0}: {1}", vbTab, HitungLuas())
  End Sub  
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas SegiempatBerwarna
    Dim obj As SegiempatBerwarna = New SegiempatBerwarna(8, 6, "merah")

    'menampilkan data
    obj.CetakData()

    Console.WriteLine()

    'menampilkan luas 
    obj.CetakLuas()

    
    Console.ReadLine()
  End Sub
End Module
