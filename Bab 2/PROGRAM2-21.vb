Module Program  
  Sub Main()        
    Dim d As Double
    Dim i As Integer
    
    d = 123.456
    
    'konversi dari tipe Double ke Integer
    i = CType(d, Integer)
    
    Console.WriteLine("Nilai d: {0}", d)
    Console.WriteLine("Nilai i: {0}", i)
    
    Console.ReadLine()
  End Sub
End Module
