Class Rekursi
  Public Function HitungPangkat(ByVal n As Integer, _
                                ByVal e As Integer) As Integer
    If e = 0 Then
      Return 1
    Else      
      Return n * HitungPangkat(n, e-1)
    End If
  End Function
End Class

Module Program
  Sub Main()
    Dim obj As Rekursi = New Rekursi
    
    'bilangan yang akan dipangkatkan
    Dim bilangan As Integer = 2
    
    'memanggil metode HitungPangkat()
    For i=0 To 9
      Console.WriteLine(bilangan & " ^ " & i _
        & " = " & obj.HitungPangkat(bilangan, i))
    Next
    
    Console.ReadLine()
  End Sub
End Module
