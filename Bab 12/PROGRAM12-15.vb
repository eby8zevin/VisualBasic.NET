Module Program  
  Sub Main()    
  	
    Dim s As String = "Microsoft"
  	
    'mencari karakter di dalam string
    Dim n1 As Integer = s.IndexOf("o"c)
    Dim n2 As Integer = s.LastIndexOf("o"c)
		
    'menampilkan hasil
    Console.WriteLine("s {0}{1}{2}: {3}",
	vbTab, vbTab, vbTab, s)
    Console.WriteLine("s.IndexOf(""o""c) {0}: {1}",
	vbTab, n1)
    Console.WriteLine("s.LastIndexOf(""o""c) {0}: {1}",
vbTab, n2)
  	
    Console.ReadLine()
  End Sub
End Module
