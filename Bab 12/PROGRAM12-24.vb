Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder
    
    'mengalokasikan 4 ruang memori untuk karakter
    sb = New StringBuilder(4)
        
    Console.WriteLine("Sebelum pengisian string:")
    Console.WriteLine("sb {0}{1}: {2}", _
      vbTab, vbTab, sb.ToString())
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    Console.WriteLine("sb.MaxCapacity {0}: {1}", _
      vbTab, sb.MaxCapacity)
    Console.WriteLine("sb.Length {0}: {1}", _
      vbTab, sb.Length)
    
    'mengisi teks ke dalam sb
    'sebanyak 9 karakter
    sb.Append("Microsoft")
    
    Console.WriteLine("{0}Setelah pengisian string:", _
      vbNewLine)
    Console.WriteLine("sb {0}{1}: {2}", _
      vbTab, vbTab, sb.ToString())
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    Console.WriteLine("sb.MaxCapacity {0}: {1}", _
      vbTab, sb.MaxCapacity)
    Console.WriteLine("sb.Length {0}: {1}", _
      vbTab, sb.Length)
    
    Console.ReadLine()
  End Sub
End Module
