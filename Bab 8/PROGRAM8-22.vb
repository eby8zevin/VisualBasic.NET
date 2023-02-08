'kelas abstrak
MustInherit Class KelasDasar
  'mendeklarasikan metode abstrak
  '(tidak memiliki implementasi)
  MustOverride Public Sub Test1()
  
  'metode non-abstrak
  Public Sub Test2()
    Console.WriteLine("Metode non-abstrak " _
      & "di dalam kelas abstrak")
  End Sub
End Class

'kelas turunan dari kelas abstrak
Class KelasTurunan: Inherits KelasDasar
  'mengimplementasikan (override) metode Test1()  
  Public Overrides Sub Test1()
    Console.WriteLine("Implementasi Test1()")
  End Sub
End Class


Module Program
  Sub Main()
    'mendeklarasikan referensi ke kelas abstrak
    Dim r As KelasDasar
    
    'mencoba melakukan instansiasi kelas dasar
    'r = New KelasDasar()  'salah
    
    'membuat objek dari kelas KelasTurunan
    Dim obj As KelasTurunan = New KelasTurunan()
    
    'r menunjuk ke objek yang ditunjuk oleh obj
    r = obj
    
    'memanggil KelasTurunan.Test1()
    r.Test1()
    
    'memanggil KelasDasar.Test2()
    r.Test2()

    Console.ReadLine()
  End Sub
End Module
