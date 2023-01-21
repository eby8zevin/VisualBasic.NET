Module Program
  Sub Main()    
    Dim c As Char
    Dim s As String
    
    Console.Write("Masukkan karakter: ")
    s = Console.ReadLine()
    
    c = Convert.ToChar(s)
    c = Char.ToLower(c)
        
    If c = "a"C Or c = "i"C Or _
      c = "u"C Or c = "e"C Or c = "o"C Then
      Console.WriteLine("{0} adalah huruf vokal", c)
    Else
      Console.WriteLine("{0} adalah huruf konsonan", c)
    End If
        
    Console.ReadLine()
  End Sub
End Module
