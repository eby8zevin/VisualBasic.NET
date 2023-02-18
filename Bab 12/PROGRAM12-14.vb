Module Program  
  Sub Main()    
  	
    Dim s, inggris, indonesia As String
  	
    s = "pemrograman=programming"
  	
    'mencari indeks dari karakter '='
    Dim posisi As Integer = s.IndexOf("="c)
  	
    indonesia = s.Substring(0, posisi)
    inggris = s.Substring(posisi+1, s.Length - (posisi+1))
  	
    'menampilkan string
    Console.WriteLine("Dalam bahasa Indonesia {0}: {1}", 
  	vbTab, indonesia)
    Console.WriteLine("Dalam bahasa Inggris {0}: {1}", 
  	vbTab, inggris)
    
    Console.ReadLine()
  End Sub
End Module
