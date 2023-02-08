'kelas abstrak
MustInherit Class Bangun2D
  'metode abstrak  
  MustOverride Public Function HitungLuas() As Double
  
  'metode non-abstrak
  Public Sub CetakLuas(ByVal namabangun As String)
    Console.WriteLine("Luas {0} {1}= {2}", _
      namabangun, vbTab, HitungLuas())
  End Sub
End Class

'kelas Segiempat, turunan dari Bangun2D
Class Segiempat: Inherits Bangun2D
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor persegi panjang
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  'konstruktor bujursangkar
  Public Sub New(ByVal sisi As Double)
    panjang = sisi
    lebar = sisi
  End Sub
  
  'implementasi Bangun2D.HitungLuas()
  Public Overrides Function HitungLuas() As Double
    Return panjang * lebar
  End Function 
End Class

'kelas Segitiga, turunan dari Bangun2D
Class Segitiga: Inherits Bangun2D
  Private alas As Double
  Private tinggi As Double
  
  'konstruktor segitiga
  Public Sub New(ByVal a As Double, ByVal t As Double)
    alas = a
    tinggi = t
  End Sub   
  
  'implementasi Bangun2D.HitungLuas()
  Public Overrides Function HitungLuas() As Double
    Return (alas * tinggi) / 2
  End Function 
End Class

'kelas Lingkaran, turunan dari Bangun2D
Class Lingkaran: Inherits Bangun2D
  Private jarijari As Double
  
  'konstruktor lingkaran
  Public Sub New(ByVal r As Double)
    jarijari = r
  End Sub
  
  'implementasi Bangun2D.HitungLuas()
  Public Overrides Function HitungLuas() As Double
    Return Math.PI * jarijari * jarijari
  End Function
End Class

Module Program
  Sub Main()
    Dim r As Bangun2D
    
    'membuat objek dari kelas Segiempat
    r = New Segiempat(10,5)
    r.CetakLuas("persegi panjang")
    
    'membuat objek dari kelas Segiempat
    r = New Segiempat(8)
    r.CetakLuas("bujursangkar")
    
    'membuat objek dari kelas Segitiga
    r = New Segitiga(4,3)
    r.CetakLuas("segitiga")
    
    'membuat objek dari kelas Lingkaran
    r = New Lingkaran(3)
    r.CetakLuas("lingkaran")
    
    Console.ReadLine()
  End Sub
End Module
