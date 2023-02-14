Structure Titik
  Public x As Integer
  Public y As Integer
  
  'pengindeks
  Public Default Property Fields(ByVal index As Char) _
                         As Integer
    Set
      If index = "x"c Then
        x = Value  
      ElseIf index = "y"c Then
        y = Value  
      Else
        Console.WriteLine("ERROR: indeks salah")
        End
      End If
    End Set
    Get
      If index = "x"c Then
        Return x
      ElseIf index = "y"c Then
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
    A("x"c) = 10
    A("y"c) = 5
    
    'menampilkan data
    Console.WriteLine("Data pertama (x) : {0}", A("x"c))
    Console.WriteLine("Data kedua (y)   : {0}", A("y"c))
            
    Console.ReadLine()
  End Sub
End Module
