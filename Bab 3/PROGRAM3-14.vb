Module Program  
  Sub Main()       
    's tidak diinisialisasi     
    Dim s As String
        
    If (TypeOf(s) Is System.String) Then 
      Console.WriteLine("s bertipe String")
    Else
      Console.Write("s belum menunjuk ke objek")
    End If
    
    Console.ReadLine()
  End Sub
End Module
