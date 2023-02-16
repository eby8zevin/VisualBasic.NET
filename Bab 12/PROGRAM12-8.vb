Module Program  
  Sub Main()    
    
    Dim s1 As String = "VB.NET"
    Dim s2 As String = "VB.NET"
    Dim s3 As String = "vb.net"  'huruf kecil
    
    'menampilkan string
    Console.WriteLine("s1 : ""{0}""", s1)
    Console.WriteLine("s2 : ""{0}""", s2)
    Console.WriteLine("s3 : ""{0}""", s3)
    Console.WriteLine()
    
    'membandingkan s1 dengan s2
    Console.WriteLine("s1 = s2 {0}{1}: {2}", _
      vbTab, vbTab, (s1 = s2))
    Console.WriteLine("String.Compare(s1,s2) {0}: {1}", _ 
      vbTab, String.Compare(s1,s2))
    Console.WriteLine("s1.CompareTo(s2) {0}: {1}", _ 
      vbTab, s1.CompareTo(s2))
    Console.WriteLine()
    
    'membandingkan s1 dengan s3
    Console.WriteLine("s1 = s3 {0}{1}: {2}", _
      vbTab, vbTab, (s1 = s3))
    Console.WriteLine("String.Compare(s1,s3) {0}: {1}", _ 
      vbTab, String.Compare(s1,s3))
    Console.WriteLine("s1.CompareTo(s3) {0}: {1}", _ 
      vbTab, s1.CompareTo(s3))
    
    Console.ReadLine()
  End Sub
End Module
