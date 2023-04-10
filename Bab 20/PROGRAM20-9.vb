'menambah anggota baru ke dalam
'namespace System
Namespace System
  Class Contoh
    Private x As Integer
    Public Sub New(ByVal x As Integer)
      Me.x = x
    End Sub
    Public Function getX() As Integer
      Return x
    End Function
  End Class
End Namespace

Module Program  
  Sub Main()    
    'mengakses kelas Contoh yang ada di dalam
    'namespace System
    Dim obj As System.Contoh = New System.Contoh(12)
    
    Console.WriteLine("Nilai obj.x: {0}", _
                            obj.getX())
    
    Console.ReadLine()
  End Sub
End Module
