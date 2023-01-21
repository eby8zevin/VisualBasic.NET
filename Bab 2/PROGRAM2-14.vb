Module Program
  Sub Main()
    'konstanta bertipe Single
    Const PI As Single = 3.14159265F
    
    Dim r As Single = 0.0F
    Dim luas As Double = 0.0
    Dim keliling As Double = 0.0
    Dim s As String = Nothing 'null string
    
    Console.Write("Masukkan jari-jari: ")
    s = Console.ReadLine
    
    r = Convert.ToSingle(s)
    luas = PI * r * r
    keliling = 2 * PI * r
    
    Console.WriteLine("Luas lingkaran {0}= {1}", _
      Chr(9), luas)
    Console.WriteLine("Keliling lingkaran {0}= {1}", _
      Chr(9), keliling)        
        
    Console.ReadLine()
  End Sub
End Module
