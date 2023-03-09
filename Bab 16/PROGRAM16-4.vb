Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "data3.txt"
        
    'data yang akan ditulis ke dalam file
    Dim data As String() = New String(5) _
      {"C++","Java","C#", _
       "Python","Perl","Ruby"}
    
    Try
      'membuat file
      Dim file As StreamWriter = _
        New StreamWriter(Path.Combine(mypath, namafile))

      'menulis data ke dalam file
      For Each item As String in data
        file.WriteLine(item)
        Console.WriteLine(item)
      Next

      file.Close()  'menutup file

      Console.WriteLine()
      Console.WriteLine("File {0} telah terbuat", _
        Path.Combine(mypath, namafile))      
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    End Try
    
    Console.ReadLine()
  End Sub
End Module
