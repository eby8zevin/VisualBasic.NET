Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "data1.txt"
        
    'data yang akan ditulis ke dalam file
    Dim data As String() = New String(2) _
      {"Baris pertama", _
       "Baris kedua", _
       "Baris ketiga"}
    
    Try
      'membuat file dan menulis data ke dalamnya
      File.WriteAllLines( _
        Path.Combine(mypath, namafile), data)
      Console.WriteLine("File {0} telah terbuat...", _
        Path.Combine(mypath, namafile))
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    End Try
    
    Console.ReadLine()
  End Sub
End Module
