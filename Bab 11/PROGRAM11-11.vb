Structure Titik
  Public x As Integer
  Public y As Integer
  
  'pengindeks
  Public Default Property Fields(ByVal index As Integer) _
                         As Integer
    Set
      If index = 0 Then
        x = Value  
      ElseIf index = 1 Then
        y = Value  
      Else
        Console.WriteLine("ERROR: indeks salah")
        End
      End If
    End Set
    Get
      If index = 0 Then
        Return x
      ElseIf index = 1 Then
        Return y
      Else
        Console.WriteLine("ERROR: indeks salah")
        Return 0
      End If
    End Get
  End Property  
  
End Structure

Module Program  
  Sub Main()    
    'membuat objek struktur
    Dim A As Titik = New Titik()
    
    'mengisi data ke dalam struktur
    'menggunakan indeks
    A(0) = 10
    A(1) = 5
    
    'menampilkan data
    Console.WriteLine("Data ke-0 (x) : {0}", A(0))
    Console.WriteLine("Data ke-1 (y) : {0}", A(1))
            
    Console.ReadLine()
  End Sub
End Module
