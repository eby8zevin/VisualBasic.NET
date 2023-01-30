Class PassByValue
  
  'mendefinisikan metode untuk menukar
  'dua bilangan
  Public Sub Tukar(ByVal a As Integer, ByVal b As Integer)
    Dim c As Integer = a
    a = b
    b = c
  End Sub
  
End Class

Module Program        
  Sub Main()    
    Dim obj As PassByValue
    
    'mendeklarasikan dua variabel bertipe Integer
    Dim x As Integer = 100
    Dim y As Integer = 200
    
    'menampilan x dan y sebelum ditukar
    Console.WriteLine("SEBELUM DITUKAR")
    Console.WriteLine("Nilai x: {0}", x)
    Console.WriteLine("Nilai y: {0}", y)
    Console.WriteLine()
    
    'membuat objek dari kelas Pass
    obj = New PassByValue()
    
    'menukar x dan y
    obj.Tukar(x, y)
    
    'menampilan x dan y setelah ditukar    
    Console.WriteLine("SETELAH DITUKAR")
    Console.WriteLine("Nilai x: {0}", x)
    Console.WriteLine("Nilai y: {0}", y)
    
    Console.ReadLine()
  End Sub
End Module
