'mendefinisikan modul (kelas statis)
'dengan nama Generator
Module Generator
  Private id As Integer
  
  'konstruktor statis
  Sub New()
    id = -1
  End Sub
  
  Public Function NextId() As Integer
    id += 1
    Return id
  End Function
  
  Public Sub ResetId()
    id = -1
  End Sub
  
End Module

'mendefinisikan modul utama
'dengan nama Program
Module Program
  Sub Main()
    Dim gen As Integer
    
    'pemanggilan NextId() pertama
    'akan menyebabkan konstruktor statis dipanggil
    gen = Generator.NextId()
    Console.Write("Pemanggilan NextId() pertama {0}: ", vbTab)
    Console.WriteLine(gen)

    'pemanggilan NextId() kedua
    gen = Generator.NextId()
    Console.Write("Pemanggilan NextId() kedua {0}: ", vbTab)
    Console.WriteLine(gen)

    'pemanggilan NextId() ketiga
    gen = Generator.NextId()
    Console.Write("Pemanggilan NextId() ketiga {0}: ", vbTab)
    Console.WriteLine(gen)
    
    'memanggil metode ResetId()
    Generator.ResetId()
    
    'pemanggilan NextId() setelah ResetId()
    gen = Generator.NextId()
    Console.Write("Pemanggilan NextId() " _
                  & "setelah ResetId() {0}: ", vbTab)
    Console.WriteLine(gen)
    
    Console.ReadLine()
  End Sub
End Module
