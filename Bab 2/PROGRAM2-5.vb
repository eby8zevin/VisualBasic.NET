Module Program  
  Sub Main()    
    Dim nama As String
    
    Console.Write("Masukkan nama Anda: ")
    'membaca data dari keyboard
    nama = Console.ReadLine()
    
    'menampilkan data
    Console.WriteLine("Halo {0}, apa kabar?", nama)    
    
    Console.ReadLine()
  End Sub
End Module
