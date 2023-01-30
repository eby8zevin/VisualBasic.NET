Class Contoh
  Public Sub CetakTeks(s As String, _
                       Optional barisbaru As Boolean = True)
    Console.Write(s)
    If (barisbaru) Then
      Console.WriteLine()
    End If
  End Sub
End Class

Module Program
  Sub Main()
    Dim obj As Contoh
    
    obj = New Contoh()
            
    'memanggil metode CetakTeks()
    obj.CetakTeks("Pemrograman ", False)
    obj.CetakTeks("Visual Basic .NET")
    obj.CetakTeks("Penerbit ", False)
    obj.CetakTeks("INFORMATIKA")
                                 
    Console.ReadLine()
  End Sub
End Module
