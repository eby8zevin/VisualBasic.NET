'mengimpor namespace StrukturData
Imports StrukturData

Module Program  
  Sub Main()    
    'menggunakan kelas StrukturData.Stack
    'untuk mengalokasikan lima elemen
    Dim s As Stack = New Stack(5)
    
    'mengisi empat elemen ke dalam stack
    s.push(10)
    s.push(20)
    s.push(30)
    s.push(40)
    
    'sebelum diambil
    Console.WriteLine("SEBELUM ISI STACK DIAMBIL")
    Console.WriteLine("Kapasitas stack {0}: {1}", _
      vbTab, s.getCapacity())
    Console.WriteLine("Ukuran stack {0}{1}: {2}", _
      vbTab, vbTab, s.getSize())
    
    'mengambil tiga isi stack    
    Console.WriteLine()
    Console.WriteLine("MENGAMBIL 3 ISI STACK")
    For i As Integer = 0 To 2    
      Console.WriteLine(s.pop())
    Next
    
    'setelah diambil
    Console.WriteLine
    Console.WriteLine("SETELAH ISI STACK DIAMBIL")
    Console.WriteLine("Kapasitas stack {0}: {1}", _
      vbTab, s.getCapacity())
    Console.WriteLine("Ukuran stack {0}{1}: {2}", _
      vbTab, vbTab, s.getSize())
    
    Console.ReadLine()
  End Sub
End Module
