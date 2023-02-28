'mendeklarasikan interface
Interface IZoomable
  Sub ZoomIn()
  Sub ZoomOut()
End Interface

'mendeklarasikan kelas abstrak
MustInherit Class Bangun2D
  Public MustOverride _
    Function HitungLuas() As Double
  Public MustOverride _
    Function HitungKeliling() As Double
End Class

'kelas Segiempat, turunan dari kelas Bangun2D
'dan mengimplementasikan IZoomable
Class Segiempat: Inherits Bangun2D: Implements IZoomable
  Private __panjang As Double
  Private __lebar As Double
  
  'konstruktor persegi panjang
  Public Sub New(ByVal panjang As Double, _
                 ByVal lebar As Double)
    __panjang = panjang
    __lebar = lebar
  End Sub
  
  'konstruktor bujursangkar
  Public Sub New(ByVal sisi As Double)
    __panjang = sisi
    __lebar = sisi
  End Sub
  
  'properti Panjang
  Public Property Panjang() As Double
    Set
      __panjang = Value
    End Set
    Get
      Return __panjang
    End Get
  End Property
  
  'properti Lebar
  Public Property Lebar() As Double
    Set
      __lebar = Value
    End Set
    Get
      Return __lebar
    End Get
  End Property
  
  'override metode Bangun2D.HitungLuas()
  Public Overrides Function HitungLuas() As Double
    Return __panjang * __lebar
  End Function
  
  'override metode Bangun2D.HitungKeliling()
  Public Overrides Function HitungKeliling() As Double
    Return 2 * (__panjang + __lebar)
  End Function
  
  'mengimplementasikan metode ZoomIn()
  Public Sub ZoomIn() Implements IZoomable.ZoomIn
    __panjang += 1
    __lebar += 1
  End Sub
  
  'mengimplementasikan metode ZoomOut()
  Public Sub ZoomOut() Implements IZoomable.ZoomOut
    __panjang -= 1
    __lebar -= 1
  End Sub
End Class  

'kelas Lingkaran mengimplementasikan IZoomable
Class Lingkaran: Inherits Bangun2D: Implements IZoomable
  Private __jarijari As Double
  
  'konstruktor
  Public Sub New(ByVal jarijari As Double)
    __jarijari = jarijari
  End Sub 
  
  'properti Jarijari
  Public Property Jarijari() As Double
    Set
      __jarijari = Value
    End Set
    Get
      Return __jarijari
    End Get
  End Property 
  
  'override metode Bangun2D.HitungLuas()
  Public Overrides Function HitungLuas() As Double
    Return Math.PI * Math.Pow(__jarijari, 2)
  End Function
  
  'override metode Bangun2D.HitungKeliling()
  Public Overrides Function HitungKeliling() As Double
    Return 2 * Math.PI * __jarijari
  End Function
  
  'mengimplementasikan metode ZoomIn()
  Public Sub ZoomIn() Implements IZoomable.ZoomIn
    __jarijari += 1    
  End Sub
  
  'mengimplementasikan metode ZoomOut()
  Public Sub ZoomOut() Implements IZoomable.ZoomOut
    __jarijari -= 1    
  End Sub  
End Class  

Module Program   
  Sub Main()    
    'membuat objek dari kelas Segiempat
    Dim obj1 As Segiempat = New Segiempat(10, 6)
    
    'menampilkan nilai awal
    Console.WriteLine("OBJEK SEGIEMPAT")
    Console.WriteLine("{0}Sebelum diperbesar:", vbNewLine)
    Console.WriteLine("Panjang {0}= {1}", _
      vbTab, obj1.Panjang)
    Console.WriteLine("Lebar {0}{1}= {2}", _
      vbTab, vbTab, obj1.Lebar)
    Console.WriteLine("Luas {0}{1}= {2}", _
      vbTab, vbTab, obj1.HitungLuas())
    Console.WriteLine("Keliling {0}= {1}", _
      vbTab, obj1.HitungKeliling())
    
    'memperbesar objek Segiempat
    obj1.ZoomIn()
    
    'menampilkan nilai akhir    
    Console.WriteLine("{0}Setelah diperbesar:", vbNewLine)
    Console.WriteLine("Panjang {0}= {1}", _
      vbTab, obj1.Panjang)
    Console.WriteLine("Lebar {0}{1}= {2}", _
      vbTab, vbTab, obj1.Lebar)
    Console.WriteLine("Luas {0}{1}= {2}", _
      vbTab, vbTab, obj1.HitungLuas())
    Console.WriteLine("Keliling {0}= {1}", _
      vbTab, obj1.HitungKeliling())
    
    'membuat objek Lingkaran
    Dim obj2 As Lingkaran = New Lingkaran(3)
    
    'menampilkan nilai awal
    Console.WriteLine("{0}OBJEK LINGKARAN", vbNewLine)
    Console.WriteLine("{0}Sebelum diperkecil:", vbNewLine)
    Console.WriteLine("Jari-jari {0}= {1}", _
      vbTab, obj2.Jarijari)
    Console.WriteLine("Luas {0}{1}= {2}", _
      vbTab, vbTab, obj2.HitungLuas())
    Console.WriteLine("Keliling {0}= {1}", _
      vbTab, obj2.HitungKeliling())
    
    'memperkecil objek Lingkaran
    obj2.ZoomOut()
    
    'menampilkan nilai akhir
    Console.WriteLine("{0}Setelah diperkecil:", vbNewLine)
    Console.WriteLine("Jari-jari {0}= {1}", _
      vbTab, obj2.Jarijari)
    Console.WriteLine("Luas {0}{1}= {2}", _
      vbTab, vbTab, obj2.HitungLuas())
    Console.WriteLine("Keliling {0}= {1}", _
      vbTab, obj2.HitungKeliling())
    
    Console.ReadLine()
  End Sub
End Module
