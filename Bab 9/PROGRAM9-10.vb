Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  'mendefinisikan pengindeks (properti default) pertama
  Public Overloads Default Property _
    Fields(ByVal index As Integer) As Double
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
  
  'mendefinisikan pengindeks (properti default) kedua
  Public Overloads Default Property _
    Fields(ByVal index As String) As Double
    Set
      If index.ToLower() = "panjang" Then
        panjang = Value  
      ElseIf index.ToLower() = "lebar" Then
        lebar = Value
      Else
        Console.WriteLine("ERROR: " _
          & "Tidak ada indeks dengan nama '{0}'", index)
        End
      End If
    End Set
    Get
      If index.ToLower() = "panjang" Then
        Return panjang  
      ElseIf index.ToLower() = "lebar" Then
        Return lebar
      Else
        Console.WriteLine("ERROR: " _
          & "Tidak ada indeks dengan nama '{0}'", index)
        Return 0
      End If
    End Get
  End Property
End Class

Module Program
  Sub Main()
    Dim obj As Segiempat = New Segiempat()
    
    'mengisi nilai data melalui pengindeks pertama
    obj(0) = 8
    obj(1) = 6
        
    'mengambil nilai data melalui pengindeks pertama
    Console.WriteLine("Parameter pengindeks bertipe Integer:")
    Console.WriteLine("panjang {0}= {1}", vbTab, obj(0))
    Console.WriteLine("lebar {0}= {1}", vbTab, obj(1))
    Console.WriteLine("Luas {0}= {1}", vbTab, _
      obj(0) * obj(1))
    Console.WriteLine()
    
    'mengisi nilai data melalui pengindeks kedua
    obj("panjang") = 10
    obj("lebar") = 5
        
    'mengambil nilai data melalui pengindeks kedua
    Console.WriteLine("Parameter pengindeks bertipe String:")
    Console.WriteLine("panjang {0}= {1}", vbTab, obj("panjang"))
    Console.WriteLine("lebar {0}= {1}", vbTab, obj("lebar"))
    Console.WriteLine("Luas {0}= {1}", vbTab, _
      obj("panjang") * obj("lebar"))
    
    Console.ReadLine()
  End Sub
End Module
