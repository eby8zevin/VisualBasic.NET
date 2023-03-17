Imports System.Collections.Generic

'membuat kelas yang mengimplementasikan
'interface IComparer<T>
Class Comparator: Implements IComparer(Of String)
  'implementasi metode Compare()
  Public Function Compare(s1 As String, s2 As String) _
    As Integer _
    Implements IComparer(Of String).Compare
    Return Comparer(Of String).Default.Compare(s1, s2)
  End Function
End Class

Module Program  
  Sub TampilkanKoleksi(koleksi As List(Of String))
    For Each elemen As String In koleksi
      Console.WriteLine(elemen)
    Next    
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe List<T>
    Dim koleksi As List(Of String) = _
      New List(Of String)()
    
    'menambah elemen ke dalam koleksi
    koleksi.Add("Visual Basic .NET")
    koleksi.Add("Ruby")
    koleksi.Add("Python")
    koleksi.Add("C#")
    koleksi.Add("Java")
    koleksi.Add("C++")
    
    'menampilkan isi koleksi sebelum diurutkan
    Console.WriteLine("Isi koleksi sebelum diurutkan:")
    TampilkanKoleksi(koleksi)
    
    'mengurutkan elemen dalam koleksi
    'menggunakan objek dari kelas Camparator
    Dim comp As Comparator = New Comparator()
    koleksi.Sort(comp)
    
    'menampilkan isi koleksi setelah diurutkan
    Console.WriteLine()
    Console.WriteLine("Isi koleksi setelah diurutkan:")
    TampilkanKoleksi(koleksi)
    
    Console.ReadLine()
  End Sub
End Module
