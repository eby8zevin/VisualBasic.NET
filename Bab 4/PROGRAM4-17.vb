Module Program    
  Sub Main()
    Const CUSERNAME As String = "vb"
    Const CPASSWORD As String = ".net451"
    
    Dim username, password As String
    Dim ok As Boolean = False
    
    Console.WriteLine("LOGIN")    
    Do
      Console.Write("Username: ")
      username = Console.ReadLine()
      Console.Write("Password: ")
      password = Console.ReadLine()
      Console.WriteLine()
      ok = (username = CUSERNAME) AndAlso (password = CPASSWORD)
    Loop Until (ok)
        
    Console.WriteLine("Login sukses...")
    
    Console.ReadLine()
  End Sub
End Module
