Module Program
  Sub Main()    
    Dim i As Integer    
    Dim ul As ULong
    
    'mengisi nilai ke dalam variabel
    'bertipe Integer
    i = 2048
    
    'hasil perhitungan ditampung ke
    'variabel bertipe UInteger
    ul = i * i
    
    Console.WriteLine("{0} x {1} = {2}", i, i, ul)
        
    Console.ReadLine()
  End Sub
End Module
