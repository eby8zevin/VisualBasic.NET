Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    Dim websites As String() = New String(8) _
      {
        "www.microsoft.com", 
        "www.python.org",
        "www.wikibooks.org",
        "www.gnu.org",
        "www.google.com", 
        "www.yahoo.com",
        "www.programmer2programmer.net",
        "www.asp.net",
        "www.thesecret.tv"
    }
    
    'membuat query
    Dim hasil As IEnumerable(Of _
      IGrouping(Of String, String)) = _
      websites.Where(Function(s) s.LastIndexOf("."c) <> -1) _
              .GroupBy(Function(e) _
                       e.Substring(e.LastIndexOf("."c)))     

    'eksekusi query
    For Each grup As IGrouping(Of String, String) _
      In hasil
      Console.WriteLine(grup.Key.ToUpper() & ":")
      For Each elemen As String In grup
        Console.WriteLine(vbTab & elemen)
      Next
    Next
    
    Console.ReadLine()
  End Sub
End Module
