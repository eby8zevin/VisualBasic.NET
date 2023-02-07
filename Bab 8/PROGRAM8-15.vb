'kelas paling dasar
Class A
  Private a As Integer
  
  Public Sub SetA(ByVal a As Integer)
    Me.a = a
  End Sub
  
  Public Function GetA() As Integer
    Return a
  End Function
End Class

'kelas B turunan dari kelas A
Class B: Inherits A
  Private b As Integer
  
  Public Sub SetB(ByVal b As Integer)
    Me.b = b
  End Sub
  
  Public Function GetB() As Integer
    Return b
  End Function
End Class

'kelas C turunan dari kelas B
Class C: Inherits B
  Private c As Integer
  
  Public Sub SetC(ByVal c As Integer)
    Me.c = c
  End Sub
  
  Public Function GetC() As Integer
    Return c
  End Function
End Class

'kelas D turunan dari kelas C
Class D: Inherits C
  Private d As Integer
  
  Public Sub SetD(ByVal d As Integer)
    Me.d = d
  End Sub
  
  Public Function GetD() As Integer
    Return d
  End Function
End Class

Module Program
  Sub Main()
    'membuat objek dari kelas D
    Dim obj As D = New D()

    'mengisi nilai
    obj.SetA(100)
    obj.SetB(200)
    obj.SetC(300)
    obj.SetD(400)

    'menampilkan nilai
    Console.WriteLine("a = " & obj.GetA())
    Console.WriteLine("b = " & obj.GetB())
    Console.WriteLine("c = " & obj.GetC())
    Console.WriteLine("d = " & obj.GetD())
    
    Console.ReadLine()
  End Sub
End Module
