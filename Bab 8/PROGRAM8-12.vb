Module Program
  Sub Main()
    'memperoleh nama komputer
    Dim nama As String = My.Computer.Name
    
    'memperoleh nama sistem operasi
    Dim os As String = My.Computer.Info.OSFullName
    
    Console.WriteLine("Nama Komputer {0}: {1}", vbTab, nama)
    Console.WriteLine("Sistem Operasi {0}: {1}", vbTab, os)
    
    Console.ReadLine()
  End Sub
End Module
