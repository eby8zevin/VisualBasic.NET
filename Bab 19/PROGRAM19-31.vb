Imports System.Linq
Imports System.Collections.Generic

Class Pelanggan
  'properti
  Public Property NamaDepan As String
  Public Property NamaBelakang As String
  Public Property NoTelepon As String
  Public Property Kota As String
  
  'konstruktor
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String, _
                 ByVal nt As String, _
                 ByVal k As String)
    NamaDepan = nd
    NamaBelakang = nb
    NoTelepon = nt
    Kota = k
  End Sub  
End Class

Module Program  
  Sub Main()
    'sumber data berupa List(Of T)
    Dim list As List(Of Pelanggan) = _
      New List(Of Pelanggan)()
    
    'menambah data ke dalam list
    list.Add( _
      New Pelanggan("Adi", "Wardhana", _
                    "022-25166555", "Bandung"))
    list.Add( _
      New Pelanggan("Kartika", "Dewi", _
                    "022-72011222", "Bandung"))
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
    list.Add( _
      New Pelanggan("Alex", "Hendrawan", _
                    "021-77711222", "Jakarta"))
    list.Add( _
      New Pelanggan("Bambang", "Wiryo", _
                    "024-83144555", "Semarang"))
    list.Add( _
      New Pelanggan("Joko", "Santoso", _
                    "024-83144999", "Semarang"))
    
    'membuat query
    Dim hasil As IEnumerable(Of Pelanggan) = _
      list.OrderBy(Function(p) p.NamaDepan & p.NamaBelakang)
    
    'menampilkan elemen-elemen dalam sumber data
    Console.WriteLine("Sebelum diurutkan:{0}", vbNewLine)
    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", _
      "NAMA", vbTab, vbTab, vbTab, "NO TELEPON", _
      vbTab, "KOTA")
    For Each p As Pelanggan In list
      Console.WriteLine("{0} {1}{2}{3}{4}{5}{6}",
                        p.NamaDepan, _
                        p.NamaBelakang, _
                        vbTab, vbTab, _
                        p.NoTelepon, _
                        vbTab, _
                        p.Kota)
    Next
    
    'menampilkan elemen-elemen hasil query
    Console.WriteLine()
    Console.WriteLine("Setelah diurutkan:{0}", vbNewLine)
    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", _
      "NAMA", vbTab, vbTab, vbTab, "NO TELEPON", _
      vbTab, "KOTA")
    For Each p As Pelanggan In hasil
      Console.WriteLine("{0} {1}{2}{3}{4}{5}{6}",
                        p.NamaDepan, _
                        p.NamaBelakang, _
                        vbTab, vbTab, _
                        p.NoTelepon, _
                        vbTab, _
                        p.Kota)
    Next
    
    Console.ReadLine()
  End Sub
End Module
