Imports System.Linq
Imports System.Collections.Generic

'membuat kelas Manusia
Class Manusia
  'properti
  Public Property NamaDepan As String
  Public Property NamaBelakang As String
  Public Property TinggiBadan As Double
  Public Property BeratBadan As Double
  
  'konstruktor
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String, _
                 ByVal tb As Double, _
                 ByVal bb As Double)
    NamaDepan = nd
    NamaBelakang = nb
    TinggiBadan = tb
    BeratBadan = bb
  End Sub
End Class

Module Program  
  Sub Main()
    'membuat koleksi dari kelas List(Of T)
    Dim list As List(Of Manusia) = New List(Of Manusia)()
    
    'menambah objek Manusia ke dalam list
    list.Add( _
      New Manusia("Doni", "Susanto", 170, 65))
    list.Add( _
      New Manusia("Doni", "Kuncoro", 163, 60))
    list.Add( _
      New Manusia("Doni", "Wisnu", 171, 70))
    list.Add( _ 
      New Manusia("Doni", "Waluyo", 165, 60))
    list.Add( _
      New Manusia("Adi", "Winaryo", 169, 67))
    list.Add( _
      New Manusia("Adi", "Dharma", 166, 75))
    list.Add( _
      New Manusia("Adi", "Suradi", 160, 57))
    list.Add( _
      New Manusia("Adi", "Jaya", 175, 68))
    list.Add( _
      New Manusia("Ayu", "Andira", 163, 50))
    list.Add( _
      New Manusia("Ayu", "Ferisa", 165, 52))
    list.Add( _
      New Manusia("Ayu", "Kusuma", 162, 48))
    
    'membuat query    
    Dim hasil As IEnumerable(Of Manusia) = _ 
      from e in list
      order by e.NamaDepan, e.NamaBelakang descending
      select e
    
    'eksekusi query
    For Each m As Manusia In hasil
      Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", _
        m.NamaDepan, _
        vbTab, _
        m.NamaBelakang, _
        vbTab, vbTab, _
        m.TinggiBadan, _
        vbTab, _
        m.BeratBadan)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
