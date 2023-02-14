Module Program  
  Sub Main() 
    'array dari tipe karakter   
    Dim arrchar As Char() = {"."c, "N"c, "E"c, "T"c}
    
    Dim s = New String(arrchar)
    Console.WriteLine(s)
            
    Console.ReadLine()
  End Sub
End Module
