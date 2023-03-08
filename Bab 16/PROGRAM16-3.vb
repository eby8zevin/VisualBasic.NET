Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "data2.txt"
        
    'data yang akan ditulis ke dalam file
    Dim data As String = _
      "Visual Basic .NET adalah bahasa pemrograman modern " _
      & "yang berlimpah fitur, dan merupakan generasi penerus " _
      & "dari versi Visual Basic sebelumnya " _
      & "(VB 1 sampai VB 6)"
    
    Try
      'membuat file dan menulis data ke dalamnya
      File.WriteAllText( _
        Path.Combine(mypath, namafile), data)
      Console.WriteLine("File {0} telah terbuat", _
        Path.Combine(mypath, namafile))
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    End Try
    
    Console.ReadLine()
  End Sub
End Module
