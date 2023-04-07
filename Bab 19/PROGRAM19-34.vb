Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim data As Integer() = New Integer(4) _
      {10,20,30,40,50}
    
    'menampilkan elemen-elemen di dalam sumber data
    Console.Write("Sumber data {0}: ", vbTab)
    For Each i As Integer In data    
      Console.Write(i & " ")
    Next
    
    'menggunakan metode-metode agregasi
    Console.WriteLine()
    Console.WriteLine("Nilai maksimum {0}: {1}", _
                      vbTab, data.Max())
    Console.WriteLine("Nilai minimum {0}: {1}", _
                      vbTab, data.Min())    
    Console.WriteLine("Banyak data {0}: {1}", _
                      vbTab, data.Count())
    Console.WriteLine("Jumlah total {0}: {1}", _
                      vbTab, data.Sum())
    Console.WriteLine("Rata-rata {0}: {1}", _
                      vbTab, data.Average())
    
    Console.ReadLine()
  End Sub
End Module
