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
  
  '-----------------------------------------------------
  'pasangan operator = dan <>
  'overload operator =
  Public Shared Operator =(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai = bil2.__nilai
  End Operator
  'overload operator <>
  Public Shared Operator <>(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai <> bil2.__nilai
  End Operator
  '-----------------------------------------------------
  
  '-----------------------------------------------------
  'pasangan operator < dan >
  'overload operator <
  Public Shared Operator <(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai < bil2.__nilai
  End Operator
  'overload operator >
  Public Shared Operator >(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai > bil2.__nilai
  End Operator
  '-----------------------------------------------------
  
  '-----------------------------------------------------
  'pasangan operator <= dan >=
  'overload operator <=
  Public Shared Operator <=(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai <= bil2.__nilai
  End Operator
  'overload operator >
  Public Shared Operator >=(ByVal bil1 As BilanganBulat, _
                           ByVal bil2 As BilanganBulat) _
                           As Boolean
    Return bil1.__nilai >= bil2.__nilai
  End Operator
  '-----------------------------------------------------
  
End Class

Module Program
  Sub Main()
    Dim a As BilanganBulat = New BilanganBulat(8)
    Dim b As BilanganBulat = New BilanganBulat(9)
    Dim c As BilanganBulat = New BilanganBulat(8)
        
    'menampilkan nilai    
    Console.WriteLine("a.Nilai {0}: {1}", _
      vbTab, a.Nilai)
    Console.WriteLine("b.Nilai {0}: {1}", _
      vbTab, b.Nilai)
    Console.WriteLine("c.Nilai {0}: {1}", _
      vbTab, c.Nilai)
    
    'membandingkan objek dari kelas BilanganBulat
    Console.WriteLine("a = b {0}: {1}", _
      vbTab, (a = b))
    Console.WriteLine("a = c {0}: {1}", _
      vbTab, (a = c))
    Console.WriteLine()
    
    Console.WriteLine("a < b {0}: {1}", _
      vbTab, (a < b))
    Console.WriteLine("a <= b {0}: {1}", _
      vbTab, (a <= b))
    Console.WriteLine()
    
    Console.WriteLine("a > b {0}: {1}", _
      vbTab, (a > b))
    Console.WriteLine("a >= c {0}: {1}", _
      vbTab, (a >= b))
    Console.WriteLine()
    
    Console.ReadLine()
  End Sub
End Module
