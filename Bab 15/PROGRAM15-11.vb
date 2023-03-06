'untuk menggunakan kelas StreamReader dan 
'FileNotFoundException
Imports System.IO

Module Program  
  Sub Main()
    Dim file As StreamReader = Nothing 
    'membuat array dengan 5 elemen bertipe int
    Dim A As Integer() = New Integer(4) {}
    Dim baris As String
    
    Try
      'mengakses file D:\data.txt
      file = New StreamReader("D:\data.txt")
      
      'membaca isi file baris-demi-baris
      Dim i As Integer = 0
      baris = file.ReadLine()
      While baris <> Nothing
        'menyalin baris data dari file ke array
        A(i) = Integer.Parse(baris)
        Console.WriteLine("A({0}) = {1}", i, A(i))
        i += 1
        baris = file.ReadLine()
      End While  
    Catch e1 As FileNotFoundException
      Console.WriteLine("ERROR: File tidak ditemukan.")
    Catch e2 As IndexOutOfRangeException
      Console.WriteLine("ERROR: " _
        & "Indeks array di luar rentang.")
    Finally
      If Not IsNothing(file) Then
        Console.WriteLine("Menutup file d:\data.txt")
        file.Close()  'menutup file
      End If      
    End Try
    
    Console.ReadLine()
  End Sub
End Module
