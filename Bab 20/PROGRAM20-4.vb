Imports System.Collections.Generic

Namespace Akademik
  Class MataKuliah
    Private __kode As String
    Private __nama As String
    Private __sks As Integer
    
    Public Sub New(ByVal __kode As String, _
                   ByVal __nama As String, _
                   ByVal __sks As Integer)
      Me.__kode = __kode
      Me.__nama = __nama
      Me.__sks = __sks
    End Sub
    
    Public Property Kode() As String
      Set
        __kode = Value
      End Set
      Get
        Return __kode
      End Get
    End Property
    
    Public Property Nama() As String
      Set
        __nama = Value
      End Set
      Get
        Return __nama
      End Get
    End Property
    
    Public Property SKS() As Integer
      Set
        __sks = Value
      End Set
      Get
        Return __sks
      End Get
    End Property    
  End Class
  
  Class Mahasiswa
    Private __nim As String
    Private __nama As String
    Private __jurusan As String
    Private daftarMataKuliah As List(Of MataKuliah)
    
    Public Sub New(ByVal __nim As String, _
                   ByVal __nama As String, _
                   ByVal __jurusan As String)
      Me.__nim = __nim
      Me.__nama = __nama
      Me.__jurusan = __jurusan
      daftarMataKuliah = New List(Of MataKuliah)()
    End Sub
    
    Public Property NIM() As String
      Set
        __nim = Value
      End Set
      Get
        Return __nim
      End Get
    End Property
    
    Public Property Nama() As String
      Set
        __nama = Value
      End Set
      Get
        Return __nama
      End Get
    End Property
    
    Public Property Jurusan() As String
      Set
        __jurusan = Value
      End Set
      Get
        Return __jurusan
      End Get
    End Property
    
    Public Sub AmbilMataKuliah(mk As MataKuliah)
      daftarMataKuliah.Add(mk)
    End Sub
    
    Public Sub LihatDaftarMataKuliah()
      Console.WriteLine("{0}{1}{2}{3}{4}{5}", _
        "KODE", _
        vbTab, _
        "MATA KULIAH", _
        vbTab, vbTab, _
        "SKS")
      For Each mk As MataKuliah _
        In daftarMataKuliah      
        Console.WriteLine("{0}{1}{2}{3}{4}{5}", _
          mk.Kode, _
          vbTab, _      
          mk.Nama, _
          vbTab, vbTab, _
          mk.SKS)
      Next
    End Sub    
  End Class
End Namespace

Module Program  
  Sub Main()
    Dim daftarMahasiswa As _
      List(Of Akademik.Mahasiswa) = _
      New List(Of Akademik.Mahasiswa)()
    
    'menggunakan kelas di dalam namespace Akademik
    Dim mhs1 As Akademik.Mahasiswa = _
      New Akademik.Mahasiswa("111", _
            "Akhmad Syafi'i", "Kimia")
    Dim mhs2 As Akademik.Mahasiswa = _
      New Akademik.Mahasiswa("222", _
            "Achmad Kosyim", "Kimia")
    Dim mhs3 As Akademik.Mahasiswa = _ 
      New Akademik.Mahasiswa("333", _
            "Muhammad Adam", "Kimia")
    
    'mencatat mata kuliah yang diambil oleh mahasiswa
    mhs1.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-01", _
            "Kimia Organik I", 3))
    mhs1.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-02", _
            "Kimia Organik II", 4))
    mhs1.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-03", _
            "Biokimia", 3))
    
    mhs2.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-02", _
            "Kimia Organik II", 4))
    mhs2.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-04", _
            "Kimia Fisik", 2))
    mhs2.AmbilMataKuliah( _
      New Akademik.MataKuliah("KU-05", _
            "Kalkulus", 3))
    
    mhs3.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-01", _
            "Kimia Organik I", 3))
    mhs3.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-04", _
            "Kimia Fisik", 2))
    mhs3.AmbilMataKuliah( _
      New Akademik.MataKuliah("KI-06", _
            "Prak. Kimia Organik", 4))
    
    'memasukkan mahasiswa ke daftar
    daftarMahasiswa.Add(mhs1)
    daftarMahasiswa.Add(mhs2)
    daftarMahasiswa.Add(mhs3)
    
    'menampilkan daftar mata kuliah mahasiswa
    For Each mhs As Akademik.Mahasiswa _
      In daftarMahasiswa
      Console.WriteLine("NIM {0}{1}: {2}", _
        vbTab, vbTab, mhs.NIM)
      Console.WriteLine("Nama {0}{1}: {2}", _
        vbTab, vbTab, mhs.Nama)
      Console.WriteLine("Jurusan {0}: {1}", _
        vbTab, mhs.Jurusan)
      mhs.LihatDaftarMataKuliah()
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
