Imports System.IO

Module Program  
  Sub Main()
    Dim fileAsal As String = "D:\Files\data6.txt"
    Dim fileTujuan As String = "D:\Files\hasilcopy.txt"
    
    'PROSES I:
    'menyalin satu file: data6.txt ke hasilcopy.txt
    File.Copy(fileAsal, fileTujuan, True)
    
    'membuat subdirektori "Subdir" di dalam direktori "D:\Files"
    Directory.CreateDirectory("D:\Files\Subdir")
    
    'mendapatkan semua file di direktori D:\Files
    Dim semuaFile As String() = Directory.GetFiles("D:\Files")
    
    'PROSES II:
    'menyalin semua file dari D:\Files ke D:\Files\Subdir
    For Each s As String in semuaFile
      'ekstrak nama file
      Dim namaFile As String = Path.GetFileName(s)
      
      'menentukan nama file tujuan (beserta path-nya)
      fileTujuan = Path.Combine("D:\Files\Subdir", namaFile)
      
      'menyalin file
      File.Copy(s, fileTujuan, True)
    Next
    
  End Sub
End Module
