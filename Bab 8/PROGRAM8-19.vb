Class KelasDasar
  'mendefinisikan metode virtual
  Public Overridable Sub Test()
    Console.WriteLine("Implementasi KelasDasar.Test()")
  End Sub
End Class

Class KelasTurunan: Inherits KelasDasar
  'melakukan override terhadap metode KelasDasar.Test()
  Public Overrides Sub Test()
    'memanggil kode lama
    MyBase.Test()
    'menambah kode baru
    Console.WriteLine("Implementasi baru " _
      & "di dalam KelasTurunan.Test()")
  End Sub
End Class

Module Program
  Sub Main()
    Dim obj As KelasTurunan = New KelasTurunan()
    
    'memanggil KelasTurunan.Test()
    obj.Test()

    Console.ReadLine()
  End Sub
End Module
