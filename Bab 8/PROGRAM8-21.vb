Class Segiempat
  Protected panjang As Double
  Protected lebar As Double
  
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  Protected Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  'metode virtual yang akan di-override
  Public Overridable Sub CetakData()
    Console.WriteLine("panjang {0}= {1}", vbTab, panjang)
    Console.WriteLine("lebar {0}= {1}", vbTab, lebar)
  End Sub
  
  'metode yang akan di-overload oleh kelas turunan
  Public Sub CetakLuas()
    Console.WriteLine("Luas {0}= {1}", vbTab, HitungLuas())
  End Sub  
End Class

Class SegiempatBerwarna: Inherits Segiempat
  Private warna As String
  
  Public Sub New(ByVal p As Double, _
                 ByVal l As Double,
                 ByVal w As String)
    MyBase.New(p,l)
    warna = w
  End Sub
  
  'melakukan override
  Public Overrides Sub CetakData()
    MyBase.CetakData()
    Console.WriteLine("warna {0}= {1}", vbTab, warna)
  End Sub
  
  'melakukan overload
  Public Overloads Sub CetakLuas(ByVal s As String)
    Console.WriteLine("{0} {1}= {2}", s, vbTab, HitungLuas())
  End Sub
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Dim obj1 As Segiempat = New Segiempat(8,6)
    
    'menampilkan data dan luas
    Console.WriteLine("Objek Segiempat")
    'memanggil Segiempat.CetakData()
    obj1.CetakData()
    'memanggil Segiempat.CetakLuas()
    obj1.CetakLuas()
    
    'membuat objek dari kelas SegiempatBerwarna
    Dim obj2 As SegiempatBerwarna = _
      New SegiempatBerwarna(10,5,"merah")
    
    'menampilkan data dan luas
    Console.WriteLine("{0}Objek SegiempatBerwarna", vbNewLine)
    'memanggil SegiempatBerwarna.CetakData()
    obj2.CetakData()
    'memanggil SegiempatBerwarna.CetakLuas(ByVal s As String)
    obj2.CetakLuas("Luas")

    Console.ReadLine()
  End Sub
End Module
