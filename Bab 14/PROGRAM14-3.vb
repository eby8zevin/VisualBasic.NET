'mendeklarasikan interface
Interface IKaryawan
  Property NIP() As String
  Property Nama() As String
  Property Alamat() As String
  Property Notelp() As String
End Interface


'kelas Manajer mengimplementasikan IKaryawan
Class Manajer: Implements IKaryawan
  Private __nip As String
  Private __nama As String
  Private __alamat As String
  Private __notelp As String
    
  'mengimplementasikan properti NIP
  Public Property NIP() As String Implements IKaryawan.NIP
    Set
      __nip = Value
    End Set
    Get
      Return __nip
    End Get
  End Property
  
  'mengimplementasikan properti Nama
  Public Property Nama() As String Implements IKaryawan.Nama
    Set
      __nama = Value
    End Set
    Get
      Return __nama
    End Get
  End Property
  
  'mengimplementasikan properti Alamat
  Public Property Alamat() As String Implements IKaryawan.Alamat
    Set
      __alamat = Value
    End Set
    Get
      Return __alamat
    End Get
  End Property
  
  'mengimplementasikan properti NIP
  Public Property Notelp() As String Implements IKaryawan.Notelp
    Set
      __notelp = Value
    End Set
    Get
      Return __notelp
    End Get
  End Property  
End Class  

Module Program   
  Sub Main()    
    'membuat objek dari kelas Manajer
    Dim karyawan As Manajer = New Manajer()
    
    'mengisi nilai properti
    karyawan.NIP = "131.000.8888"
    karyawan.Nama = "Akhmad Yusuf"
    karyawan.Alamat = "Jl. Kebon Teratai 99 Bandung"
    karyawan.Notelp = "022-2889999"
    
    'menampilkan nilai properti
    Console.WriteLine("MANAJER")
    Console.WriteLine("--------------------------------------")
    Console.WriteLine("NIP {0}: {1}", _
      vbTab, karyawan.NIP)
    Console.WriteLine("Nama {0}: {1}", _
      vbTab, karyawan.Nama)
    Console.WriteLine("Alamat {0}: {1}", _
      vbTab, karyawan.Alamat)
    Console.WriteLine("No. Telp {0}: {1}", _
      vbTab, karyawan.Notelp)
    
    Console.ReadLine()
  End Sub
End Module
