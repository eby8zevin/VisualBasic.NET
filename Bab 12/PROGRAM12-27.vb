Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder = _
      New StringBuilder("Visual C++")
    
    Console.WriteLine("Sebelum diubah")
    Console.WriteLine("sb : {0}", sb)

    'mengubah teks di dalam sb
    sb.Replace("C++","Basic")
    
    Console.WriteLine("{0}Setelah diubah", vbNewLine)
    Console.WriteLine("sb : {0}", sb)
    
    Console.ReadLine()
  End Sub
End Module
