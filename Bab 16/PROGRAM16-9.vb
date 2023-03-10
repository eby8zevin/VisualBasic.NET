Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "data6.txt"
        
    'data yang akan ditulis ke dalam file
    Dim data As String() = New String(5) _
      {"C++","Java","C#", _
       "Python","Perl","Ruby"}
        
    'membuat file, menulis data ke dalam file, lalu menutupnya
    'secara otomatis        
    Try
      File.WriteAllLines( _
        Path.Combine(mypath, namafile), data)
      Console.WriteLine("File {0} telah terbuat", _
        Path.Combine(mypath, namafile))
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    End Try
    
    'membuka file dan membaca data dari file
    'karakter-demi-karakter
    Dim f As StreamReader = Nothing
    Try
      Console.WriteLine("{0}Isi file {1}:", _
        vbNewLine, Path.Combine(mypath, namafile))
      f = _
        New StreamReader(Path.Combine(mypath, namafile))
      Dim karakterdata As Integer = 0
      
      karakterdata = f.Read()
      While karakterdata <> -1
        Console.Write(Chr(karakterdata))
        karakterdata = f.Read()  
      End While
    Catch e As FileNotFoundException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    Finally
      If Not IsNothing(f) Then
        f.Close()
      End If
    End Try
    
    Console.ReadLine()
  End Sub
End Module
