'mendeklarasikan tipe delegasi
Delegate Function BalikString( _
  ByVal s As String) As String

Module Program  
  
  Sub Main()    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As BalikString      
    
    'membuat objek delegasi
    'untuk menunjuk ke metode BalikDanCetakString()
    objDel = Function (ByVal s As String)
               Dim temp As Char() = New Char(s.Length-1) {}
               Dim j As Integer = 0
               For i = s.Length-1 To 0 Step -1
                 temp(j) = s(i)
                 j += 1
               Next               
               Return New String(temp)               
             End Function
           
    Console.WriteLine("Mengeksekusi objDel:")    
    Dim s1 As String = objDel("MICROSOFT")
    Console.WriteLine(s1)

    Console.WriteLine("{0}Mengeksekusi kembali objDel:",
      vbNewLine)
    Dim s2 As String = objDel("Visual Basic .NET")    
    Console.WriteLine(s2)
        
    Console.ReadLine()
  End Sub
End Module
