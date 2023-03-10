Imports System.IO

Module Program  
  Sub Main()
    Dim mypath As String = "D:\Files"

    'membuat direktori
    Directory.CreateDirectory(mypath)
    
    Dim namafile As String = "kamus.txt"
        
    'meminta user memasukkan kata yang dicari
    Console.WriteLine("KAMUS BAHASA INDONESIA-INGGRIS")
    Console.Write("Masukkan kata yang dicari: ")
    Dim s As String = Console.ReadLine().ToLower()
    
    'pencarian data di dalam file
    Dim file As StreamReader = Nothing
    Try      
      file = _
        New StreamReader(Path.Combine(mypath, namafile))
      Dim ketemu As Boolean = False
      Dim baris As String = Nothing
      Dim hasil As String = Nothing
      
      baris = file.ReadLine()
      While baris <> Nothing
        Dim posisiPembatas As Integer = baris.IndexOf("="c)
        If baris.StartsWith(s) Then
          'mengambil substring setelah karakter '='
          hasil = baris.Substring(posisiPembatas+1)
          'informasi kata telah ditemukan
          ketemu = True
          'menghentikan proses pencarian
          Exit While
        End If
        baris = file.ReadLine()
      End While
      
      'menampilkan hasil
      If ketemu Then
        Console.WriteLine("{0}Bahasa inggris ""{1}"" " _
           & "adalah: {2}", vbNewLine, s, hasil)
      Else
        Console.WriteLine("{0}Kata yang Anda cari " _
           & "tidak ditemukan dalam kamus.")
      End If   
    Catch e As FileNotFoundException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    Catch e As IOException
      Console.WriteLine("ERROR: {0}", e.Message)
      End
    Finally
      If Not IsNothing(file) Then
        file.Close()
      End If
    End Try
    
    Console.ReadLine()
  End Sub
End Module
