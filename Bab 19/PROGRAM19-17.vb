Imports System.Linq
Imports System.Collections.Generic

Class Pelanggan
  'properti
  Public Property NamaDepan As String
  Public Property NamaBelakang As String
  Public Property NoTelepon As String
  public Property Kota As String
  
  'konstruktor pertama
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String, _
                 ByVal nt As String, _
                 ByVal k As String)
    NamaDepan = nd
    NamaBelakang = nb
    NoTelepon = nt
    Kota = k
  End Sub
  
  'konstruktor kedua
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String, _
                 ByVal nt As String)
    NamaDepan = nd
    NamaBelakang = nb
    NoTelepon = nt
  End Sub
End Class

Module Program  
  Sub Main()
    'sumber data berupa List(Of T)
    Dim list As List(Of Pelanggan) = _
      New List(Of Pelanggan)()
    
    'menambah data ke dalam list
    list.Add( _
      New Pelanggan("Akhmad", "Maulana", _
                    "022-20099888", "Bandung"))
    list.Add( _
      New Pelanggan("Cindy", "Melani", _
                    "021-80822111", "Jakarta"))
    list.Add( _
      New Pelanggan("Dewi", "Ayuandira", _ 
                    "022-25177555", "Bandung"))
    list.Add( _
      New Pelanggan("Akhmad", "Kosyim", _
                    "021-77700111", "Jakarta"))
    
    'membuat query yang mengembalikan
    'daftar pelanggan
    'yang berasal dari "Jakarta"
    Dim hasil As IEnumerable(Of Pelanggan) = _
      from e in list
      where e.Kota = "Jakarta"
      select New Pelanggan(e.NamaDepan, _
                           e.NamaBelakang, _
                           e.NoTelepon)
    
    'menampilkan isi array
    Console.WriteLine("Daftar Pelanggan: ")
    For Each plgn As Pelanggan In list    
      Console.WriteLine("{0} {1} {2}{3} {4}{5}", _
                        plgn.NamaDepan, _
                        plgn.NamaBelakang, _
                        vbTab, _
                        plgn.NoTelepon, _
                        vbTab, _
                        plgn.Kota)
    Next
    
    'menampilkan hasil query
    Console.WriteLine()
    Console.WriteLine("Pelanggan dari Jakarta: ")    
    For Each plgn As Pelanggan In hasil
      Console.WriteLine("{0} {1} {2}{3}", _
                        plgn.NamaDepan, _
                        plgn.NamaBelakang, _
                        vbTab, _
                        plgn.NoTelepon)
    Next
    
    Console.ReadLine()
  End Sub
End Module
