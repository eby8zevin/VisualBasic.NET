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
  
  'overload operator - (unary)
  Public Shared Operator -(ByVal bil As BilanganBulat) _                           
                           As BilanganBulat
    Return New BilanganBulat(-bil.__nilai)    
  End Operator 
  
End Class

Module Program
  Sub Main()
    Dim a As BilanganBulat = New BilanganBulat(9)
    Dim b As BilanganBulat = New BilanganBulat(-8)
    
    'menegatifkan a dan mempositifkan b
    Dim c As BilanganBulat = -a
    Dim d As BilanganBulat = -b
        
    Console.WriteLine("a.Nilai {0}: {1}", _
      vbTab, a.Nilai)
    Console.WriteLine("b.Nilai {0}: {1}", _
      vbTab, b.Nilai)
    Console.WriteLine("c.Nilai {0}: {1}", _
      vbTab, c.Nilai)
    Console.WriteLine("d.Nilai {0}: {1}", _
      vbTab, d.Nilai)
    
    Console.ReadLine()
  End Sub
End Module
