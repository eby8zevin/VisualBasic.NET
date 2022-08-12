Imports System

'blok kode yang berupa modul
Module Program
  'blok kode yang berupa metode
  Sub Main()
    Dim n As Integer
    Console.Write("Masukkan nilai n: ")
    Dim s As String = Console.ReadLine()

    'blok kode untuk proses pemilihan statemen
    If Not Integer.TryParse(s, n) Then
      Console.WriteLine("ERROR: n harus berupa " _
                      & "bilangan bulat")
      Environment.Exit(1)
    End If 'akhir blok pemilihan

    'blok kode untuk proses pemilihan statemen
    If n < 0 Then
      Console.WriteLine("ERROR: n tidak boleh negatif")
      Environment.Exit(1)
    End If 'akhir blok pemilihan

    'blok kode untuk proses pengulangan statemen
    For i As Integer = 0 To n-1
      Console.WriteLine(i)
    Next 'akhir blok pengulangan

  End Sub 'akhir metode
End Module 'akhir modul
