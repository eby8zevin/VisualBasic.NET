Class A
  Protected a As Integer
  
  Public Sub SetA(ByVal a As Integer)
    Me.a = a
  End Sub
  
  Public Function GetA() As Integer
    Return a
  End Function
End Class

Class B: Inherits A
  Private b As Integer
  
  Public Sub SetB(ByVal b As Integer)
    Me.b = b
  End Sub
  
  Public Function GetB() As Integer
    Return b
  End Function  
  
  Public Sub PrintData()
    'mengakses data a dari kelas B
    Console.WriteLine("a = " & a)    'benar

    'mengakses data milik sendiri
    Console.WriteLine("b = " & b)
  End Sub
End Class  

Module Program
  Sub Main()
    'membuat objek dari kelas A
    Dim obj1 As A = new A()

    'baris kode di bawah ini akan menyebabkan kesalahan
    'karena a bersifat Protected.
    'obj1.a = 5   'salah

    obj1.SetA(5)   'benar

    Console.WriteLine("Objek A")
    Console.WriteLine("a = " & obj1.GetA())

    'membuat objek dari kelas B
    Dim obj2 As B = new B()

    obj2.SetA(10)
    obj2.SetB(20)

    Console.WriteLine("{0}Objek B", vbNewLine)
    obj2.PrintData() 
    
    Console.ReadLine()
  End Sub
End Module
