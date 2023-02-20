Module Program  
  Sub Main()    
    Dim s1, s2, s3 As String
  	
    s1 = "Pemrograman Visual Basic"
  	
    'menghapus string s1 dari indeks ke-11  	
    s2 = s1.Remove(11)
  	
    'menghapus string s1 dari indeks ke-0
    'sebanyak 12 karakter
    s3 = s1.Remove(0, 12)
  	
    'menampilkan nilai s1, s2, dan s2
    Console.WriteLine("s1: {0}", s1)
    Console.WriteLine("s2: {0}", s2)
    Console.WriteLine("s3: {0}", s3)
    
    Console.ReadLine()
  End Sub
End Module
