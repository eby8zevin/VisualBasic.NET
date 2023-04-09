Namespace NSString
  class Array
    Private data As String()
    
    Public Sub New(ByVal ukuran As Integer)
      data = New String(ukuran-1) {}
    End Sub
    
    Public Sub IsiNilai(ByVal indeks As Integer, _
                        ByVal nilai As String)
      If indeks > -1 And _
         indeks < data.Length Then
        data(indeks) = nilai
      End If
    End Sub
    
    Public Sub TampilkanNilai()
      Dim i As Integer = 0
      For Each nilai As String In data      
        Console.WriteLine("Nilai ke-{0}: {1}", _
          i+1, nilai)
        i += 1
      Next
    End Sub
  End Class
End Namespace

Namespace NSInteger
  class Array
    Private data As Integer()
    
    Public Sub New(ByVal ukuran As Integer)
      data = New Integer(ukuran-1) {}
    End Sub
    
    Public Sub IsiNilai(ByVal indeks As Integer, _
                        ByVal nilai As Integer)
      If indeks > -1 And _
         indeks < data.Length Then
        data(indeks) = nilai
      End If
    End Sub
    
    Public Sub TampilkanNilai()
      Dim i As Integer = 0
      For Each nilai As Integer In data      
        Console.WriteLine("Nilai ke-{0}: {1}", _
          i+1, nilai)
        i += 1
      Next
    End Sub
  End Class
End Namespace

Module Program  
  Sub Main()    
    'mengakses NSString.Array
    Dim A As NSString.Array = New NSString.Array(5)
    A.IsiNilai(0, "VB.NET")
    A.IsiNilai(1, "C++")
    A.IsiNilai(2, "Java")
    A.IsiNilai(3, "Python")
    A.IsiNilai(4, "Ruby")
    Console.WriteLine("Isi array A:")
    A.TampilkanNilai()
    
    'mengakses NSInteger.Array
    Dim B As NSInteger.Array = New NSInteger.Array(5)
    B.IsiNilai(0, 1000)
    B.IsiNilai(1, 2000)
    B.IsiNilai(2, 3000)
    B.IsiNilai(3, 4000)
    B.IsiNilai(4, 5000)
    Console.WriteLine()
    Console.WriteLine("Isi array B:")
    B.TampilkanNilai()
    
    Console.ReadLine()
  End Sub
End Module
