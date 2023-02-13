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
  
  'overload operator CType untuk mengonversi tipe
  'secara eksplisit dari BilanganBulat ke Double
  Public Shared Narrowing Operator CType(ByVal bil As BilanganBulat) _
                           As Double
    Return bil.__nilai * 1.0
  End Operator
  
End Class

Module Program
  Sub Main()
    Dim a As BilanganBulat = New BilanganBulat(8)
    
    'mendeklarasikan variabel bertipe Double
    Dim c As Double

    'konversi implicit masih bisa dilakukan,
    'tapi akan menyebabkan pesan peringatan
    'c = a
    
    'mengisi a ke c, BilanganBulat akan dikonversi
    'secara eksplisit ke tipe Double
    c = CType(a, Double)
        
    'menampilkan nilai    
    Console.WriteLine("a.Nilai {0}: {1}", _
      vbTab, a.Nilai)
    Console.WriteLine("c {0}: {1}", _
      vbTab, c.ToString("F2"))    
    
    Console.ReadLine()
  End Sub
End Module
