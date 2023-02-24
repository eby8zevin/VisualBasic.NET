Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder = New StringBuilder()
    sb.Append("Pemrograman Visual Basic .NET")
    
    Console.WriteLine("Sebelum dihapus")
    Console.WriteLine("sb : {0}", sb)

    'menghapus teks di dalam sb
    sb.Remove(0, 12)
    
    Console.WriteLine("{0}Setelah dihapus", _
      vbNewLine)
    Console.WriteLine("sb : {0}", sb)
    
    Console.ReadLine()
  End Sub
End Module
