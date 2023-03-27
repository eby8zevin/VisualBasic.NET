Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim A As Integer() = New Integer(9) _
      {10,20,30,40,50,60,70,80,90,100}
    
    Dim hasil As IEnumerable(Of Integer) = _
                    from e in A
                    where e > 50
                    select e
    
    Dim max As Integer = hasil.Max()
    Dim min As Integer = hasil.Min()
    Dim count As Integer = hasil.Count()
    Dim sum As Integer = hasil.Sum()
    Dim avg As Double = hasil.Average()
    
    'menampilkan hasil query
    Console.Write("Hasil query: ")
    For Each i As Integer In hasil
      Console.Write(i & " ")
    Next
    
    Console.WriteLine(vbNewLine)
    Console.WriteLine("Nilai maksimum {0}: {1}", _
      vbTab, max)
    Console.WriteLine("Nilai minimum {0}: {1}", _
      vbTab, min)
    Console.WriteLine("Banyaknya data {0}: {1}", _
      vbTab, count)
    Console.WriteLine("Jumlah total {0}: {1}", _
      vbTab, sum)
    Console.WriteLine("Nilai Rata-rata {0}: {1}", _
      vbTab, avg)
    
    Console.ReadLine()
  End Sub
End Module
