Module Program  
  Sub Main()            
    Dim c As Char
    Dim s, info As String
      
    Console.Write("Masukkan karakter: ")
    s = Console.ReadLine()
    
    c = Char.Parse(s)
    
    Select c
      Case "0"C To "9"C: 
        info = "angka"
      Case "A"C To "Z"C, "a"C To "z"C: 
        info = "alfabet"
      Case Else
        info = "simbol"
    End Select
    
    Console.WriteLine("Anda memasukkan " _
      & "karakter {0}", info)
    
    Console.ReadLine()
  End Sub
End Module
