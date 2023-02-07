Class KelasDasar
  Protected bilangan As Integer
  
  Public Sub New(ByVal i As Integer)
    bilangan = i
  End Sub  
End Class

Class KelasTurunan: Inherits KelasDasar
  'akan menimpa data KelasDasar.bilangan
  Private bilangan As Integer
  
  Public Sub New(ByVal i1 As Integer, _
                 ByVal i2 As Integer)
    MyBase.New(i1)
    'akan mengisi nilai ke KelasTurunan.bilangan
    bilangan = i2
  End Sub
  
  Public Sub CetakData()
    Console.WriteLine("KelasDasar.bilangan {0}: {1}", _
      vbTab, MyBase.bilangan)
    Console.WriteLine("KelasTurunan.bilangan {0}: {1}", _
      vbTab, bilangan) 'bisa ditulis: Me.bilangan
  End Sub
  
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas KelasTurunan
    Dim obj As KelasTurunan = New KelasTurunan(100, 200)
    
    'memanggil metode CetakData()
    obj.CetakData()
    
    Console.ReadLine()
  End Sub
End Module
