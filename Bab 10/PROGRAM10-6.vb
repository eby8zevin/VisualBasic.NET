Class MyBoolean
  Private __nilai As Boolean
  
  'konstruktor
  Public Sub New(ByVal nilai As Boolean)
    __nilai = nilai
  End Sub
  
  'properti Nilai
  Public Property Nilai() As Boolean
    Set
      __nilai = Value
    End Set
    Get
      Return __nilai
    End Get
  End Property
  
  'overload operator Not
  Public Shared Operator Not(ByVal b As MyBoolean) _                           
                           As MyBoolean
    Return New MyBoolean(Not b.__nilai)
  End Operator 
  
End Class

Module Program
  Sub Main()
    Dim a As MyBoolean = New MyBoolean(True)
    Dim b As MyBoolean = New MyBoolean(False)
        
    Dim c As MyBoolean = Not a
    Dim d As MyBoolean = Not b
        
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
