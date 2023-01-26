Module Program    
  'membuat fungsi
  Function Kali(a As Double, b As Double) As Double 'BARIS A
    Dim hasil As Double = a * b
    Return hasil
  End Function
  
  Sub Main()
    Dim x, y, hasilkali As Integer
    
    x = 8
    y = 9
    
    'memanggil fungsi
    hasilkali = Kali(x, y)    'BARIS B
    
    Console.WriteLine("{0} x {1} = {2}", _
      x, y, hasilkali)
    
    Console.ReadLine()
  End Sub
End Module
