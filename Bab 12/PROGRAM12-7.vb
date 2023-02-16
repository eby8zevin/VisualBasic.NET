Module Program  
  Sub Main()    
    Dim nomor As Integer = 52
    
    'menyambung string menggunakan operator &
    Dim alamat As String = "Jl Buah Batu No. " _
                           & nomor.ToString() _
                           & " "
    Dim kota As String = "Bandung"
    
    'menyambung string menggunakan metode Concat()
    Console.WriteLine(String.Concat(alamat, kota))
            
    Console.ReadLine()
  End Sub
End Module
