Class Rekursi
  Public Sub CetakData(ByVal n As Integer)
    If n = 0 Then
      Console.WriteLine()
      Exit Sub  'menghentikan eksekusi metode
    Else      
      Console.Write(n & " ")
      'memanggil dirinya sendiri
      CetakData(n-1)
    End If
  End Sub
End Class

Module Program
  Sub Main()
    Dim obj As Rekursi = New Rekursi
    
    'memanggil metode HitungPangkat()
    obj.CetakData(10)
    obj.CetakData(5)
    obj.CetakData(3)
    
    Console.ReadLine()
  End Sub
End Module
