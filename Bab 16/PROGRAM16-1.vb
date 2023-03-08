Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "contoh.txt"

    'membuat file D:\Files\contoh.txt    
    Dim fs As FileStream = _
      File.Create(Path.Combine(mypath, namafile))
    
    'menulis data ke dalam file
    For i As Byte = 0 To 99
      fs.WriteByte(i)
    Next

    fs.Close()  'menutup file
    
    'membaca data dari dalam file
    Try
      Dim data As Byte() = _
        File.ReadAllBytes(Path.Combine(mypath, namafile))
      For Each b As Byte In data
        Console.Write(b & " ")
      Next
    Catch e As IOException
      Console.WriteLine(e.Message)
    End Try
    
    Console.ReadLine()
  End Sub
End Module
