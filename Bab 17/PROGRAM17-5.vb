Class A
  Public Sub Tulis(ByVal s As String)
    Console.WriteLine(s)
  End Sub
End Class

'kelas B turunan dari A
Class B: Inherits A
  'tidak ada implementasi
End Class

'kelas C, tidak ada hubungan hirarki
'dengan A maupun B
Class C
  'tidak ada implementasi
End Class

'kelas generik
Class Generik (Of T As A)
  Private obj As T
  
  'konstruktor
  Public Sub New(obj As T)
    Me.obj = obj
  End Sub
  
  Public Sub CetakTeks(ByVal s As String)
    'obj memiliki metode Tulis() karena
    'T merupakan turunan dari A
    obj.Tulis(s)
  End Sub
End Class

Module Program  
  Sub Main()
    'membuat objek dari kelas A, B, dan C
    Dim a As A = New A()
    Dim b As B = New B()
    Dim c As C = New C()
    
    'membuat objek dari kelas Generik
    'berisi objek dari kelas A
    Dim genA As Generik(Of A) = New Generik(Of A)(a)
    genA.CetakTeks("Generik berisi objek dari kelas A")
    
    'membuat objek dari kelas Generik
    'berisi objek dari kelas B
    Dim genB As Generik(Of B) = New Generik(Of B)(b)
    genB.CetakTeks("Generik berisi objek dari kelas B")
    
    'dua baris di bawah ini salah
    'karena C bukan turunan dari kelas A
    'Dim genC As Generik(Of C) = New Generik(Of C)(c)
    'genC.CetakTeks("Generik berisi objek dari kelas C")
    
    Console.ReadLine()
  End Sub
End Module
