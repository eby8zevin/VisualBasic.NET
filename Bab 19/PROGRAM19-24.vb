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
    Dim hasil = _ 
      from s in websites
      let lastIndex = s.LastIndexOf("."c)
      where lastIndex <> -1
      group s by akhiran = s.Substring(lastIndex)
      into daftarSitus = group

    'eksekusi query    
    For Each grup In hasil
      Console.WriteLine(grup.akhiran.ToUpper() + ":")
      For Each elemen As String In grup.daftarSitus
        Console.WriteLine(vbTab & elemen)
      Next
    Next

    Console.ReadLine()
  End Sub
End Module
