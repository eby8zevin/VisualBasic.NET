Module Program  
  Sub Main()    
  	Dim s1, s2 As String
  	
  	s1 = "Visual C++"
  	
  	'menampilkan nilai s1
  	Console.WriteLine("Sebelum pemanggilan Replace()")
  	Console.WriteLine("s1: {0}", s1)
  	
  	s2 = s1.Replace("C++", "Basic")
  	
  	'menampilkan nilai s1 dan s2
  	Console.WriteLine("{0}Setelah pemanggilan Replace()", vbNewLine)
  	Console.WriteLine("s1: {0}", s1)
  	Console.WriteLine("s2: {0}", s2)   
    
    Console.ReadLine()
  End Sub
End Module
