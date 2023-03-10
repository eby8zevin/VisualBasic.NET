Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\DirBaru\data3.txt"
    
    Console.WriteLine("Nama direktori{0}: {1}", _ 
      vbTab, Path.GetDirectoryName(mypath))
    Console.WriteLine("Nama file{0}: {1}", _
      vbTab, Path.GetFileName(mypath))
    Console.WriteLine("Nama file (tanpa ekstensi){0}: {1}", _
      vbTab, Path.GetFileNameWithoutExtension(mypath))
    Console.WriteLine("Ektensi{0}: {1}", _
      vbTab, Path.GetExtension(mypath))
    
    Console.ReadLine()
  End Sub
End Module
