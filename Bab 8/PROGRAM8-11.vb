Class A
  Private a As Integer
  
  Public Sub SetA(ByVal a As Integer)
    Me.a = a
  End Sub
  
  Public Function GetA() As Integer
    Return Me.a
  End Function
  
End Class

Module Program
  Sub Main()
    'membuat objek pertama dari kelas A
    Dim obj1 As A = New A()
    'menentukan nilai a untuk objek pertama
    obj1.SetA(100)
    'memanggil GetA() melalui objek pertama
    Console.WriteLine("Me.a pada objek pertama {0}: {1}", _ 
      vbTab, obj1.GetA())
    
    'membuat objek kedua dari kelas A
    Dim obj2 As A = New A()
    'menentukan nilai a untuk objek kedua
    obj2.SetA(200)
    'memanggil GetA() melalui objek kedua
    Console.WriteLine("Me.a pada objek kedua {0}: {1}", _
      vbTab, obj2.GetA())
    
    Console.ReadLine()
  End Sub
End Module
