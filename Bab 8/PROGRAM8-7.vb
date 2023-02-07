Class KelasDasar
  Private bilangan As Integer
  
  'konstruktor tanpa parameter
  Public Sub New()
    Console.WriteLine("KelasDasar.New()")
  End Sub
  
  'konstruktor dengan satu parameter
  Public Sub New(ByVal i As Integer)
    i = bilangan
    Console.WriteLine("KelasDasar.New(ByVal i As Integer)")
  End Sub
  
  Public Function GetBilangan() As Integer
    Return bilangan
  End Function
End Class

Class KelasTurunan: Inherits KelasDasar
  
  'konstruktor ini akan memanggil KelasDasar.New()
  Public Sub New()
    MyBase.New()
    Console.WriteLine("KelasTurunan.New()")
  End Sub
  
  'konstruktor ini akan memanggil
  'KelasDasar.New(ByVal i As Integer)
  Public Sub New(ByVal i As Integer)
    MyBase.New(i)
    Console.WriteLine("KelasTurunan.New(ByVal i As Integer)")
  End Sub
End Class  

Module Program
  Sub Main()
    'membuat objek dari kelas KelasTurunan
    'tanpa parameter
    Dim obj1 As KelasTurunan = New KelasTurunan()

    Console.WriteLine()

    'membuat objek dari kelas KelasTurunan
    'dengan parameter
    Dim obj2 As KelasTurunan = New KelasTurunan(9)
    
    Console.ReadLine()
  End Sub
End Module
