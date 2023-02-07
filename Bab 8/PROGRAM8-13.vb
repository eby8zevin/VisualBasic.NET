Class KelasDasar
  
  Public Overridable Sub Metode1()
    Console.WriteLine("KelasDasar.Metode1()")
  End Sub
  
  Public Sub Metode2()
    'memanggil metode Metode1() menggunakan MyClass
    MyClass.Metode1()
  End Sub
  
End Class

Class KelasTurunan: Inherits KelasDasar
  'melakukan override terhadap metode Metode1()
  Public Overrides Sub Metode1()
    Console.WriteLine("KelasTurunan.Metode1()")
  End Sub
End Class

Module Program
  Sub Main()
    Dim obj As KelasTurunan = New KelasTurunan()
    obj.Metode2()

    Console.ReadLine()
  End Sub
End Module
