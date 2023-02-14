Module Program  
  Sub Main()    
    'array dari tipe karakter
    Dim arrchar As Char() = {"M"c, "i"c, "c"c, "r"c, "o"c, _
                             "s"c, "o"c, "f"c, "t"c}
    
    Dim s = New String(arrchar, 0, 5)
    Console.WriteLine(s)
            
    Console.ReadLine()
  End Sub
End Module
