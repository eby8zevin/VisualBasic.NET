Class Contoh
  'data statis
  Public Shared a As Integer
  'data non-statis
  Public b As Integer
  
  'konstruktor statis
  Shared Sub New()
    a = 10
    Console.WriteLine("Konstruktor statis dipanggil")
  End Sub
  
  'konstruktor non-statis
  Public Sub New(ByVal b As Integer)
    Me.b = b
    Console.WriteLine("Konstruktor non-statis dipanggil")
  End Sub
End Class

Module Program
  Sub Main()
    'mengakses data statis a
    'akan menyebabkan konstruktor statis dipanggil
    Console.WriteLine("Contoh.a = " & Contoh.a)
    Console.WriteLine()
    
    'membuat objek pertama
    'akan menyebabkan konstruktor non-statis dipanggil
    Dim obj1 As Contoh = New Contoh(1000)
    Console.WriteLine("obj1.b = " & obj1.b)
    Console.WriteLine()

    'membuat objek kedua
    'akan menyebabkan konstruktor non-statis dipanggil
    Dim obj2 As Contoh = New Contoh(2000)
    Console.WriteLine("obj2.b = " & obj2.b)
    Console.WriteLine()

    'membuat objek ketiga
    'akan menyebabkan konstruktor non-statis dipanggil
    Dim obj3 As Contoh = New Contoh(3000)
    Console.WriteLine("obj3.b = " & obj3.b)
    
    Console.ReadLine()
  End Sub
End Module
