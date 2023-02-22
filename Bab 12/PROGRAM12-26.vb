Imports System.Text

Module Program   
  Sub Main()    
    Dim s1 As String
    Dim sb As StringBuilder
    
    'membuat objek String
    s1 = "Visual Basic"
    
    'membuat objek StringBuilder
    sb = New StringBuilder()
    sb.Append("Visual Basic")
    
    'menampilkan string
    Console.WriteLine("Sebelum disisipi teks")
    Console.WriteLine("s1 : {0}", s1)
    Console.WriteLine("sb : {0}", sb)
    
    'menyisipkan teks ke objek String (s1)
    Dim s2 As String = s1.Insert(7,"C++ dan Visual ")
    
    'menyisipkan teks ke objek StringBuilder (sb)
    sb.Insert(7,"C++ dan Visual ")
    
    'menampilkan string    
    Console.WriteLine("{0}Setelah disisipi teks", _
      vbNewLine)
    Console.WriteLine("s1 : {0}", s1)
    Console.WriteLine("sb : {0}", sb)
    Console.WriteLine("s2 : {0}", s2)
    
    Console.ReadLine()
  End Sub
End Module
