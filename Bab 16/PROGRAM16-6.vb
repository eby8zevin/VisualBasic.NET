Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "data4.txt"
        
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
    
    'membuka file, membaca data dari file, lalu menutupnya
    'secara otomatis
    Try
      Console.WriteLine("{0}Isi file {1}:", _
         vbNewLine, Path.Combine(mypath, namafile))

      'membaca seluruh baris data di dalam file
      'menggunakan metode ReadAllText()
      'dan menyimpannya ke variabel bertipe string
      Dim semuabaris As String = _
        File.ReadAllText(Path.Combine(mypath, namafile))

      'menampilkan data yang telah dibaca
      Console.WriteLine(semuabaris)      
    Catch e As FileNotFoundException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    End Try
    
    Console.ReadLine()
  End Sub
End Module
