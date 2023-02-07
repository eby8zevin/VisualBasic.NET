'mendefinisikan kelas dasar
Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  Public Sub New(ByVal panjang As Double, ByVal lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  Public Sub CetakDataSegiempat()
    Console.WriteLine("panjang {0}: {1}", vbTab, panjang)
    Console.WriteLine("lebar {0}: {1}", vbTab, lebar)
  End Sub
End Class

'mendefinisikan kelas turunan
Class SegiempatBerwarna: Inherits Segiempat
  Private warna As String
  
  Public Sub New(ByVal panjang As Double, _
                 ByVal lebar As Double, _
                 ByVal warna As String)
    'memanggil konstruktor kelas dasar (kelas induk)
    MyBase.New(panjang, lebar)
    'menentukan nilai untuk data warna
    Me.warna = warna
  End Sub
  
  Public Sub CetakDataSegiempatBerwarna()
    'memanggil metode hasil pewarisan
    CetakDataSegiempat()
    'menampilkan data warna
    Console.WriteLine("warna {0}: {1}", vbTab, warna)
  End Sub
End Class  

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Console.WriteLine("Objek Segiempat")
    Dim se1 As Segiempat = New Segiempat(8, 6)
    se1.CetakDataSegiempat()

    'membuat objek dari kelas SegiempatBerwarna
    Console.WriteLine("{0}Objek SegiempatBerwarna", vbNewLine)
    Dim se2 As SegiempatBerwarna = New SegiempatBerwarna(8, 6, "merah")
    se2.CetakDataSegiempatBerwarna()
    
    Console.ReadLine()
  End Sub
End Module
