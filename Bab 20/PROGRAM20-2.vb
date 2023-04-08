Module Program  
  Sub Main()
    Dim mypath As System.String = "D:\Files"

    'membuat direktori
    System.IO.Directory.CreateDirectory(mypath)
    
    Dim namafile As System.String = "contoh.txt"

    'membuat file D:\Files\contoh.txt    
    Dim fs As System.IO.FileStream = _
      System.IO.File.Create( _
        System.IO.Path.Combine(mypath, namafile))
    
    'menulis data ke dalam file
    For i As System.Byte = 0 To 99    
      fs.WriteByte(i)
    Next

    fs.Close()  'menutup file
    
    'membaca data dari dalam file
    Try
      Dim data As System.Byte() = _
        System.IO.File.ReadAllBytes( _
          System.IO.Path.Combine(mypath, namafile))
      For Each b As System.Byte In data
        System.Console.Write(b & " ")
      Next
    Catch e As System.IO.IOException
      System.Console.WriteLine(e.Message)
    End Try
    
    System.Console.ReadLine()
  End Sub
End Module
