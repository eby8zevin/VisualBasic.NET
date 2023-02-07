Class Segiempat
  Protected panjang As Double
  Protected lebar As Double
  
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  Public Sub CetakData()
    Console.WriteLine("panjang {0}= {1}", vbTab, panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, lebar)
  End Sub  
End Class

Class SegiempatBerwarna: Inherits Segiempat
  Private warna As String
  
  Public Sub New(ByVal p As Double, _
                 ByVal l As Double, _
                 ByVal w As String)
    MyBase.New(p, l)
    warna = w
  End Sub
  
  'metode ini akan menimpa Segiempat.CetakData()
  Public Sub CetakData()
    MyBase.CetakData()  'memanggil metode Segiempat.CetakData()
    Console.WriteLine("warna {0}= {1}", vbTab, warna)
  End Sub  
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas SegiempatBerwarna
    Dim obj As SegiempatBerwarna = New SegiempatBerwarna(10,8,"biru")
    
    'memanggil metode SegiempatBerwarna.CetakData()
    obj.CetakData()
    
    Console.ReadLine()
  End Sub
End Module
