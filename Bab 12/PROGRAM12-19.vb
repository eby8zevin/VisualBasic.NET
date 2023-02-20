Module Program  
  Sub Main()    
    Dim s1, s2 As String
  	
    s1 = "Pemrograman Basic"
  	
    'menyisipkan string  	
    s2 = s1.Insert(12, "Visual ")
  	
    'menampilkan nilai s1 dan s2
    Console.WriteLine("s1: {0}", s1)
    Console.WriteLine("s2: {0}", s2)   
    
    Console.ReadLine()
  End Sub
End Module
