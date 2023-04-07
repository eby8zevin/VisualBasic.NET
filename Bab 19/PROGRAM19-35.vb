Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim data As String() = New String(6) _
      {
         "C++",
         "Python",
         "Java",
         "Perl",
         "C#",
         "Ruby",
         "Visual Basic"
      }
    
    'menampilkan elemen-elemen di dalam sumber data
    Console.WriteLine("Sumber data: ")
    For Each s As String In data
      Console.WriteLine(s)
    Next
    
    'menggunakan metode-metode agregasi
    Console.WriteLine()
    Console.WriteLine("Elemen pertama {0}{1}: {2}", _
       vbTab, vbTab, data.First())
    Console.WriteLine("Elemen terakhir {0}: {1}", _
       vbTab, data.Last())
    
    Console.ReadLine()
  End Sub
End Module
