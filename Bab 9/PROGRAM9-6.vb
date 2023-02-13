'kelas dasar
Class Karyawan
  Private __nama As String
  
  Public Property Nama() As String
    Set
      __nama = Value
    End Set
    Get
      Return __nama
    End Get
  End Property  
End Class

'kelas turunan
Class Manajer: Inherits Karyawan
  Private __nama As String
  
  'menyembunyikan/menimpa properti Karyawan.Nama
  Public Shadows Property Nama() As String
    Set
      __nama = Value
    End Set
    Get
      Return __nama
    End Get
  End Property
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas turunan
    Dim obj As Manajer = New Manajer()
    
    'mengisi properti Manajer.Nama
    obj.Nama = "Guntur Wibowo"
    
    'mengisi properti Karyawan.Nama
    CType(obj, Karyawan).Nama = "Joko Prabowo"
    
    'menampilkan nilai properti
    Console.WriteLine("Properti Nama " _
      & "dalam kelas Karyawan {0}: {1}", _
      vbTab, (CType(obj, Karyawan)).Nama)
    Console.WriteLine("Properti Nama " _
      & "dalam kelas Manajer {0}: {1}", _
      vbTab, obj.Nama)
    
    Console.ReadLine()
  End Sub
End Module
