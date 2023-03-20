Imports System.Collections.Generic

Module Program
  'metode untuk menampilkan bilangan bulat
  Sub Tulis(ByVal s As Integer)
    Console.WriteLine(s)
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe List(Of T)
    Dim list As List(Of Integer) = New List(Of Integer)()
    list.Add(10)
    list.Add(20)
    list.Add(30)
    list.Add(40)
    list.Add(50)
    
    'menampilkan isi koleksi (list)
    'menggunakan metode ForEach()
    'dan metode Tulis() sebagai parameternya
    Console.WriteLine("Isi list:")
    list.ForEach(AddressOf Tulis)
    
    Dim total As Integer = 0
    
    'metode ForEach() untuk melakukan perhitungan
    list.ForEach(Function(x)
                   total += x
                   Return total
                 End Function)
    
    Console.WriteLine("{0}Total = {1}", _
      vbNewLine, total)
    
    Console.ReadLine()
  End Sub
End Module
