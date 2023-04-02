Imports System.Linq
Imports System.Collections.Generic

Class Penerbit
  'properti
  Public Property ID As String
  Public Property Nama As String
  'konstruktor
  Public Sub New(ByVal ID As String, 
                 ByVal Nama As String)
    Me.ID = ID
    Me.Nama = Nama
  End Sub
End Class

Class Buku
  'properti
  Public Property ISBN As String
  Public Property Judul As String
  Public Property IDPenerbit As String
  Public Property Harga As Decimal
  'konstruktor
  Public Sub New(ByVal ISBN As String, _
                 ByVal Judul As String, _
                 ByVal IDPenerbit As String, _
                 ByVal Harga As Decimal)
    Me.ISBN = ISBN
    Me.Judul = Judul
    Me.IDPenerbit = IDPenerbit
    Me.Harga = Harga
  End Sub
End Class

'kelas untuk menampung hasil query
Class View
  'properti
  Public Property Judul As String
  Public Property Penerbit As String
  Public Property Harga As Decimal
  'konstruktor
  Public Sub New(ByVal Judul As String, _
                 ByVal Penerbit As String, _
                 ByVal Harga As Decimal)
    Me.Judul = Judul
    Me.Penerbit = Penerbit
    Me.Harga = Harga
  End Sub
End Class

Module Program
  Sub Main()
    'sumber data pertama (berisi daftar penerbit)
    Dim list1 As List(Of Penerbit) = New List(Of Penerbit)()
    list1.Add(New Penerbit("P01", "Angkasa Media"))
    list1.Add(New Penerbit("P02", "Sinar Media"))
    list1.Add(New Penerbit("P03", "Promedia"))
        
    'sumber data kedua (berisi daftar buku)
    Dim list2 As List(Of Buku) = New List(Of Buku)()
    list2.Add( _
      New Buku("978-602-1111-11-1", "Mahir PHP", _
               "P01", 70000.00D))
    list2.Add( _
      New Buku("978-602-1111-11-2", "Belajar Perl", _ 
               "P01", 65000.00D))
    list2.Add( _
      New Buku("978-602-1111-11-3", "Bahasa Assembly", _
                  "P02", 90000.00D))
    list2.Add( _
      New Buku("978-602-1111-11-4", "Pemrograman F#", _
                  "P03", 80000.00D))
    list2.Add( _
      New Buku("978-602-1111-11-5", "Belajar ASP.NET", _ 
                  "P03", 75000.00D))
       
    'melakukan operasi join
    Dim hasil As IEnumerable(Of View) = _
      from penerbit in list1
      join buku in list2
        on penerbit.ID equals buku.IDPenerbit
      select New View(buku.Judul, penerbit.Nama, buku.Harga)
    
    'menampilkan hasil query
    Console.WriteLine("JUDUL{0}{1}{2}PENERBIT{3}{4}HARGA", _
      vbTab, vbTab, vbTab, vbTab, vbTab)
    For Each v As View In hasil
      Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", _
        v.Judul, _
        vbTab, vbTab, _
        v.Penerbit, _
        vbTab, vbTab, _
        v.Harga)
    Next

    Console.ReadLine()
  End Sub
End Module
