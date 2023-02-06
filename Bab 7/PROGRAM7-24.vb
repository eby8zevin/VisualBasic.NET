'kelas bagian luar
Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor kelas bagian luar
  Public Sub New(ByVal panjang As Double, ByVal lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  Public Sub CetakData()
    Console.WriteLine("panjang = " & panjang)
    Console.WriteLine("lebar = " & lebar)
  End Sub
  
  'metode untuk menghasilkan objek SegiempatBerwarna
  Public Function Salin(ByVal warna As String) As SegiempatBerwarna
    Dim temp As SegiempatBerwarna = New SegiempatBerwarna(Me, warna)
    Return temp
  End Function
  
  '#####################################################
  'kelas bagian dalam
  Class SegiempatBerwarna
    Private obj As Segiempat
    Private warna As String
    
    'konstruktor kelas bagian dalam
    Public Sub New(ByVal obj As Segiempat, ByVal warna As String)
      Me.obj = obj
      Me.warna = warna
    End Sub
    
    'mengubah sifat dari CetakData() pada kelas Segiempat
    Public Sub CetakData()
      'memanggil Segiempat.CetakData()
      obj.CetakData()
      'menambah sifat baru
      Console.WriteLine("warna = " & warna)
    End Sub
    
  End Class 'akhir kelas SegiempatBerwarna
  '#####################################################
  
End Class 'akhir kelas Segiempat

Module Program
  Sub Main()
    'membuat objek dari kelas bagian luar
    Console.WriteLine("Objek Segiempat")
    Dim se1 As Segiempat = New Segiempat(8, 6)
    se1.CetakData()
    
    'membuat objek dari kelas bagian dalam
    'dengan memanggil metode Salin()
    Console.WriteLine("{0}Objek SegiempatBerwarna", vbNewLine)
    Dim se2 As Segiempat.SegiempatBerwarna = se1.Salin("merah")
    se2.CetakData()
    
    Console.ReadLine()
  End Sub
End Module
