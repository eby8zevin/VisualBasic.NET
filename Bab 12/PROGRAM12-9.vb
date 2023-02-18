Module Program  
  Sub Main()    
    
    Dim s1 As String = "MICROSOFT"
    Dim s2 As String = "microsoft"
    
    'menampilkan string
    Console.WriteLine("s1 : ""{0}""", s1)
    Console.WriteLine("s2 : ""{0}""", s2)
    Console.WriteLine()
    
    'membandingkan s1 dengan s2
    Console.WriteLine("s1 = s2 {0}{1}: {2}", _
      vbTab, vbTab, (s1 = s2))
    Console.WriteLine("String.Compare(s1,s2) {0}: {1}", _ 
      vbTab, String.Compare(s1,s2))
    Console.WriteLine("String.Compare(s1,s2,True) {0}: {1}", _ 
      vbTab, String.Compare(s1,s2,True))
    Console.WriteLine("s1.CompareTo(s2) {0}: {1}", _ 
      vbTab, s1.CompareTo(s2))
    Console.WriteLine()
    
    Console.ReadLine()
  End Sub
End Module
