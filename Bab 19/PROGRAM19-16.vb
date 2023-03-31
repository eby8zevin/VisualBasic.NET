Imports System.Linq
Imports System.Collections.Generic

Class Pelanggan
  'properti
  Public Property NamaDepan As String
  Public Property NamaBelakang As String
  'konstruktor
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String)
    NamaDepan = nd
    NamaBelakang = nb
  End Sub
 End Class

Module Program  
  Sub Main()
    'sumber data berupa List(Of T)
    Dim list As List(Of Pelanggan) = _
      New List(Of Pelanggan)()
    
    'menambah data ke dalam list
    list.Add( _
      New Pelanggan("Muhammad", "Adam"))
    list.Add( _
      New Pelanggan("Muhammad", "Ilman"))
    list.Add( _
      New Pelanggan("Joko", "Waluyo"))
    list.Add( _
      New Pelanggan("Joko", "Wicaksono"))
    list.Add( _
      New Pelanggan("Joko", "Wahono"))
    
    'membuat query yang mengembalikan
    'nama belakang dari setiap elemen list
    'yang nama depannya "Muhammad"
    Dim hasil As IEnumerable(Of String) = _
      from e in list
      where e.NamaDepan = "Muhammad"
      select e.NamaBelakang
    
    'menampilkan isi array
    Console.WriteLine("Sumber data: ")
    For Each plgn As Pelanggan In list    
      Console.WriteLine(plgn.NamaDepan & " " &
                        plgn.NamaBelakang)
    Next
    
    'menampilkan hasil query
    Console.WriteLine("{0}Hasil query: ", _
      vbNewLine)
    For Each s As String In hasil    
      Console.WriteLine(s)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
