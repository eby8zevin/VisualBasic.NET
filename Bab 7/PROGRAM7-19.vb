Class Generator
  'data statis
  Private Shared id As Integer = 0
  
  'metode statis
  Public Shared Function NextId() As Integer
    id += 1
    Return id
  End Function
End Class

Module Program
  Sub Main()
    Dim IDBarang As String = "BRG-"
    Dim gen As Integer
    
    'pemanggilan Next() pertama
    gen = Generator.NextId()
    Console.Write(IDBarang & gen)
    Console.WriteLine(": Televisi")
    
    'pemanggilan Next() kedua
    gen = Generator.NextId()
    Console.Write(IDBarang & gen)
    Console.WriteLine(": Radiotape")
    
    'pemanggilan Next() ketiga
    gen = Generator.NextId()
    Console.Write(IDBarang & gen)
    Console.WriteLine(": Kulkas")
    
    Console.ReadLine()
  End Sub
End Module
