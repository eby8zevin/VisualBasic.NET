'namespace tempat kelas StringBuilder didefinisikan
Imports System.Text

Module Program   
  Sub Main()    
    Dim sb As StringBuilder
    
    'membuat objek dari kelas StringBuilder
    sb = New StringBuilder()
    
    'mengisi teks ke dalam objek StringBuilder
    sb.Append("Pemrograman ")
    sb.Append("Visual Basic .NET")
    
    'menampikan teks yang tersimpan di dalam
    'objek StringBuilder
    Console.WriteLine(sb)
    
    Console.ReadLine()
  End Sub
End Module
