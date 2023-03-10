Imports System.IO

Module Program  
  Sub Main()
    Dim f As String = "D:\Files\data5.txt"
    
    'menghapus file
    File.Delete(f)
    
    Dim dir As String = "D:\Files\Subdir"
    
    'menghapus direktori
    Directory.Delete(dir, True)
    
  End Sub
End Module
