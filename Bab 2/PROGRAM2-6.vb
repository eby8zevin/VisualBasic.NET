Module Program  
  Sub Main()    
    Dim s As String
    Dim c As Char
    
    Console.Write("Masukkan karakter: ")
    'membaca data dari keyboard
    s = Console.ReadLine()
    
    'konversi dari tipe String ke Char
    If (Char.TryParse(s, c)) Then
      Console.WriteLine("Anda memasukkan karakter {0}", c)  
    Else
      Console.WriteLine("Konversi ke Char gagal")
    End If    
    
    Console.ReadLine()
  End Sub
End Module
