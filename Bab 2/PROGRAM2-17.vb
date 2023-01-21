Module Program
  Sub Main()        
    Dim a, b As Boolean
    
    a = True
    b = False
    
    Console.WriteLine("Nilai a: {0}", a)
    Console.WriteLine("Nilai b: {0}", b)
    
    If a Then 'bisa ditulis: If a = True Then
      Console.WriteLine("Baris ini dieksekusi")  
    Else
      Console.WriteLine("Baris ini tidak dieksekusi")
    End If
    
    'ekspresi yang menghasilkan nilai bertipe Boolean
    Console.WriteLine()
    Console.WriteLine("Contoh ekspresi Boolean:")
    Console.WriteLine("100 > 10: {0}", (100 > 10))
    Console.WriteLine("100 < 10: {0}", (100 < 10))    
    
    Console.ReadLine()
  End Sub
End Module
