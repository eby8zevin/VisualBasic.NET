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
  
  'overload operator plus (+)
  Public Shared Operator +(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As BilanganBulat
    Return New BilanganBulat(bil1.__nilai + bil2.__nilai)    
  End Operator
  
End Class

Module Program
  Sub Main()
    Dim a As BilanganBulat = New BilanganBulat(4)
    Dim b As BilanganBulat = New BilanganBulat(5)
    
    'operator + dapat diterapkan 
    'untuk tipe BilanganBulat
    Dim c As BilanganBulat = a + b
        
    Console.WriteLine("a.Nilai {0}: {1}", _
      vbTab, a.Nilai)
    Console.WriteLine("b.Nilai {0}: {1}", _
      vbTab, b.Nilai)
    Console.WriteLine("c.Nilai {0}: {1}", _
      vbTab, c.Nilai)
    
    Console.ReadLine()
  End Sub
End Module
