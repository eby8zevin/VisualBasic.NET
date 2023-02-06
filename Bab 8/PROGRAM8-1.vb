'mendefinisikan kelas dasar
Class A
  Private a As Integer
  Public Sub SetA(ByVal a As Integer)
    Me.a = a
  End Sub
  Public Function GetA() As Integer
    Return a
  End Function
End Class

'mendefinisikan kelas turunan
Class B: Inherits A
  Private b As Integer
  Public Sub SetB(ByVal b As Integer)
    Me.b = b
  End Sub
  Public Function GetB() As Integer
    Return b
  End Function
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas turunan
    Dim obj As B = New B
    
    'memanggil metode
    obj.SetA(1000)
    Console.WriteLine("obj.GetA() : " & obj.GetA())
    obj.SetB(2000)
    Console.WriteLine("obj.GetB() : " & obj.GetB())
    
    Console.ReadLine()
  End Sub
End Module
