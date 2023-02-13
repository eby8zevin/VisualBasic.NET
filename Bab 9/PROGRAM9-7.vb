'kelas dasar
MustInherit Class Bangun2Dimensi
  'properti abstrak yang bersifat read-only
  Public MustOverride ReadOnly Property Luas As Double
End Class

'kelas turunan pertama
Class Segiempat: Inherits Bangun2Dimensi
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor Segiempat
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  'melakukan override terhadap properti Luas
  Public Overrides ReadOnly Property Luas() As Double
    Get
      Return panjang * lebar
    End Get
  End Property  
End Class

'kelas turunan kedua
Class Lingkaran: Inherits Bangun2Dimensi
  Private r As Double
  
  'konstruktor Lingkaran
  Public Sub New(ByVal r As Double)
    Me.r = r
  End Sub
  
  'melakukan override terhadap properti Luas
  Public Overrides ReadOnly Property Luas() As Double
    Get
      Return Math.PI * r * r
    End Get
  End Property
End Class  

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    Dim obj1 As Segiempat = New Segiempat(8,6)
    
    'menampilkan luas segiempat
    Console.WriteLine("Luas segiempat {0}= {1}", _
      vbTab, obj1.Luas)
    
    'membuat objek dari kelas Lingkaran
    Dim obj2 As Lingkaran = New Lingkaran(3)
    
    'menampilkan luas lingkaran
    Console.WriteLine("Luas lingkaran {0}= {1}", _
      vbTab, obj2.Luas)
    
    Console.ReadLine()
  End Sub
End Module
