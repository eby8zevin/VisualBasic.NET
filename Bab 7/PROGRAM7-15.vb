using System;
Class Rekursi
  Public Function HitungFaktorial(ByVal n As Integer) As Integer
    If n = 0 Then
      Return 1
    Else
      'memanggil dirinya sendiri
      Return n * HitungFaktorial(n-1)
    End If
  End Function
End Class

Module Program
  Sub Main()
    Dim obj As Rekursi = New Rekursi
    
    'memanggil metode HitungFaktorial()
    For i=0 To 9
      Console.WriteLine(i & "! = " & _
        obj.HitungFaktorial(i))
    Next    
    
    Console.ReadLine()
  End Sub
End Module
