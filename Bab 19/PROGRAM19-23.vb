Imports System.Linq
Imports System.Collections.Generic

Module Program
  Sub Main()
    Dim strings As String() = New String(4) _
      {
        "Microsoft", "VB.NET", 
        "C#", "C++/CLI", "F#"
      }
    
    'membuat query
    Dim hasil As IEnumerable(Of String) = _
                    from s in strings
                    let n = s.Length
                    select s & vbTab & ": " & n

    'eksekusi query
    Console.WriteLine("JUMLAH KARAKTER:")
    For Each elemen In hasil
      Console.WriteLine(elemen)
    Next

    Console.ReadLine()
  End Sub
End Module
