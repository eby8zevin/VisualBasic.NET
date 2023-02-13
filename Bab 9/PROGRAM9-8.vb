Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  'mendefinisikan pengindeks (properti default)
  Public Default Property Fields(ByVal index As Integer) As Double
    Set
      If index = 0 Then
        panjang = Value  
      ElseIf index = 1 Then
        lebar = Value
      Else
        Console.WriteLine("ERROR: Tidak ada indeks ke-{0}", index)
        End
      End If
    End Set
    Get
      If index = 0 Then
        Return panjang  
      ElseIf index = 1 Then
        Return lebar
      Else
        Console.WriteLine("ERROR: Tidak ada indeks ke-{0}", index)
        Return 0
      End If
    End Get
  End Property
  
End Class

Module Program
  Sub Main()
    Dim obj As Segiempat = New Segiempat()
    
    'mengisi nilai data melalui pengindeks
    obj(0) = 8
    obj(1) = 6
    'obj(2) = 4   'salah
    
    'mengambil nilai data melalui pengindeks
    Console.WriteLine("panjang {0}= {1}", vbTab, obj(0))
    Console.WriteLine("lebar {0}= {1}", vbTab, obj(1))
    Console.WriteLine("Luas {0}= {1}", vbTab, _
      obj(0) * obj(1))
    
    Console.ReadLine()
  End Sub
End Module
