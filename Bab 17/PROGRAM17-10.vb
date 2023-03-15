Class Generik (Of T)
  Dim obj As T
  
  'konstruktor
  Public Sub New()
    obj = CType(Nothing, T) 'nilai default untuk obj
  End Sub
  
  Public Sub CekTipe()    
    If IsReference(obj) Then
      'jika berasal dari tipe referensi  
      Console.WriteLine("T adalah tipe referensi")
      Console.WriteLine("Nilai default: Nothing (null)")
    Else
      'jika berasal dari tipe nilai
      Console.WriteLine("T adalah tipe nilai")
      Console.WriteLine("Nilai default: {0}", obj)
    End If
  End Sub
End Class

'contoh kelas
Class Test
  'tidak ada implementasi  
End Class

Module Program  
  Sub Main()
    'membuat objek dari kelas Generik
    'dengan parameter bertipe String
    Dim g1 As Generik(Of String) = _
      New Generik(Of String)()
    Console.WriteLine("Dalam g1 (kelas String):")
    g1.CekTipe()
    
    Console.WriteLine()
    
    'membuat objek dari kelas Generik
    'dengan parameter bertipe Integer
    Dim g2 As Generik(Of Integer) = _
      New Generik(Of Integer)()
    Console.WriteLine("Dalam g2 (struktur Integer):")
    g2.CekTipe()
    
    Console.WriteLine()
    
    'membuat objek dari kelas Generik
    'dengan parameter bertipe Boolean
    Dim g3 As Generik(Of Boolean) = _
      New Generik(Of Boolean)()
    Console.WriteLine("Dalam g3 (struktur Boolean):")
    g3.CekTipe()
    
    Console.WriteLine()
    
    'membuat objek dari kelas Generik
    'dengan parameter bertipe Test
    Dim g4 As Generik(Of Test) = _
      New Generik(Of Test)()
    Console.WriteLine("Dalam g4 (kelas Test):")
    g4.CekTipe()
    
    Console.ReadLine()
  End Sub
End Module
