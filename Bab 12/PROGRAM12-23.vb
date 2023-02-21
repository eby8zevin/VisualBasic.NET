Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder
    
    'membuat objek dari kelas StringBuilder
    sb = New StringBuilder(99)
    
    sb.Append("Pemrograman Visual Basic .NET")
    
    Console.WriteLine("sb {0}{1}: {2}", _
      vbTab, vbTab, sb.ToString())
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    Console.WriteLine("sb.MaxCapacity {0}: {1}", _
      vbTab, sb.MaxCapacity)
    Console.WriteLine("Integer.MaxValue {0}: {1}", _
      vbTab, Integer.MaxValue)
    Console.WriteLine("sb.Length {0}: {1}", _
      vbTab, sb.Length)
    
    Console.ReadLine()
  End Sub
End Module
