Imports System.IO

Module Program  
  Sub Main()
    Dim dirBaru As String = "D:\DirBaru"
    'membuat direktori baru
    Directory.CreateDirectory(dirBaru)
    
    Dim f As String = "D:\Files\data3.txt"
    'ekstrak nama file
    Dim namaFile As String = Path.GetFileName(f)
    
    'memindahkan file data3.txt
    'dari D:\Files ke D:\DirBaru
    File.Move(f, Path.Combine(dirBaru, namaFile))
    
    Dim dir As String = "D:\Files"
    
    'memindahkan direktori D:\Files ke D:\DirBaru\Files
    Directory.Move(dir, dirBaru & "\Files")
    
  End Sub
End Module
