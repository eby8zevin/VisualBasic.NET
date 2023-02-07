Class A
  Public Sub New()
    Console.WriteLine("Konstruktor A")
  End Sub
End Class

Class B: Inherits A
  Public Sub New()
    Console.WriteLine("Konstruktor B")
  End Sub
End Class

Class C: Inherits B
  Public Sub New()
    Console.WriteLine("Konstruktor C")
  End Sub
End Class


Module Program
  Sub Main()
    Console.WriteLine("Ketika objek dari kelas A dibuat:")
    Dim obj1 As A = new A()

    Console.WriteLine("{0}Ketika objek dari kelas B dibuat:", _
                       vbNewLine)
    Dim obj2 As B = New B()

    Console.WriteLine("{0}Ketika objek dari kelas C dibuat:", _
                       vbNewLine)
    Dim obj3 As C = New C()
    
    Console.ReadLine()
  End Sub
End Module
