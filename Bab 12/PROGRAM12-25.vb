Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder
    
    sb = New StringBuilder(17)
        
    Console.WriteLine("Sebelum kapasitas diubah")
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    
    'mengubah kapasitas
    'menggunakan properti Capacity
    sb.Capacity = 26
    
    Console.WriteLine("{0}Setelah perubahan pertama", _
      vbNewLine)
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    
    'mengubah kapasitas
    'menggunakan metode EnsureCapacity()
    sb.EnsureCapacity(35)
    
    Console.WriteLine("{0}Setelah perubahan kedua", _
      vbNewLine)
    Console.WriteLine("sb.Capacity {0}: {1}", _
      vbTab, sb.Capacity)
    
    Console.ReadLine()
  End Sub
End Module
