Class BilanganBulat
  Private __nilai As Integer
  
  'konstruktor
  Public Sub New(ByVal nilai As Integer)
    __nilai = nilai
  End Sub
  
  'properti Nilai
  Public Property Nilai() As Integer
    Set
      __nilai = Value
    End Set
    Get
      Return __nilai
    End Get
  End Property
  
  'overload operator True
  Public Shared Operator IsTrue(ByVal bil As BilanganBulat) _
                           As Boolean
    Return bil.__nilai <> 0
  End Operator
  
  'overload operator False
  Public Shared Operator IsFalse(ByVal bil As BilanganBulat) _
                           As Boolean
    Return bil.__nilai = 0
  End Operator
  
  'overload Not
  Public Shared Operator Not(ByVal bil As BilanganBulat) _
                             As Boolean                               
    Return bil.Nilai = 0
  End Operator
  
  'metode untuk decrement __nilai
  Public Sub Decrement()
    __nilai -= 1
  End Sub

End Class

Module Program
  Sub Main()
    Dim a As BilanganBulat = New BilanganBulat(10)
    Dim b As BilanganBulat = New BilanganBulat(0)
        
    'menampilkan nilai    
    Console.WriteLine("a.Nilai {0}: {1}", _
      vbTab, a.Nilai)
    Console.WriteLine("b.Nilai {0}: {1}", _
      vbTab, b.Nilai)
    Console.WriteLine()
    
    'menggunakan objek BilanganBulat sebagai kondisi
    'di dalam statemen If
    If a Then
      Console.WriteLine("a.Nilai <> 0")  
    Else
      Console.WriteLine("a.Nilai = 0")
    End If
    
    If b Then
      Console.WriteLine("b.Nilai <> 0")  
    Else
      Console.WriteLine("b.Nilai = 0")
    End If
    Console.WriteLine()
    
    'menggunakan objek BilanganBulat sebagai kondisi
    'di dalam statemen While
    While True
      If Not a Then Exit While      'benar
      Console.Write(a.Nilai & " ")
      a.Decrement()
    End While    
    
    Console.ReadLine()
  End Sub
End Module
