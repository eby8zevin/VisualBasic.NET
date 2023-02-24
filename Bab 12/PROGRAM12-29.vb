Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder = New StringBuilder()
    sb.Append("Pemrograman Visual Basic .NET")
    
    Console.WriteLine("Sebelum dikosongkan")
    Console.WriteLine("sb {0}{1}: {2}", _
      vbTab, vbTab, sb)
    Console.WriteLine("sb.Length {0}: {1}", _
      vbTab, sb.Length)

    'mengosongkan teks di dalam sb
    sb.Clear()
    
    Console.WriteLine("{0}Setelah dikosongkan", _
      vbNewLine)
    Console.WriteLine("sb {0}{1}: {2}", _
      vbTab, vbTab, sb)
    Console.WriteLine("sb.Length {0}: {1}", _
      vbTab, sb.Length)
    
    Console.ReadLine()
  End Sub
End Module
