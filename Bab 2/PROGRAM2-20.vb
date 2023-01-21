Module Program  
  Sub Main()        
    Dim i As Integer
    Dim d As Double
    
    i = 100
    
    'akan terjadi konversi implisit
    'dari tipe Integer ke Double
    d = i
    
    Console.WriteLine("Nilai i: {0}", i)
    Console.WriteLine("Nilai d: {0}", d)
    
    Console.ReadLine()
  End Sub
End Module
