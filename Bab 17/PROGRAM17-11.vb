'kelas non-generik
Class MyArray
  'metode generik untuk mengurutkan array
  Public Shared Sub UrutData(Of T)(array As T())
    For i As Integer = 0 To array.Length-2
      For j As Integer = array.Length-1 To i+1 Step -1
        If CType(array(j), IComparable).CompareTo(array(j-1)) < 0 Then
        'If (array(j) < array(j-1)) Then   'salah
          Dim temp As T = array(j)
          array(j) = array(j-1)
          array(j-1) = temp
        End If
      Next
    Next
  End Sub
  
  'metode generik untuk menampilkan elemen array
  Public Shared Sub TampilkanData(Of T)(array As T())
    For Each elemen As T in array
      Console.Write(elemen.ToString() & " ")
    Next
    Console.WriteLine()
  End Sub
End Class

Module Program  
  Sub Main()
    'membuat array bertipe Integer
    Dim A As Integer() = New Integer(4) _
      {50,10,20,40,30}
    
    'membuat array bertipe char
    Dim B As Char() = New Char(4) _
      {"B"c,"D"c,"A"c,"E"c,"C"c}
    
    'menampilkan array A dan B
    'sebelum diurutkan
    Console.WriteLine("SEBELUM DIURUTKAN")
    Console.Write("Array A: ")
    MyArray.TampilkanData(A)
    Console.Write("Array B: ")
    MyArray.TampilkanData(B)
    
    'mengurutkan data
    MyArray.UrutData(A)
    MyArray.UrutData(B)
    
    'menampilkan array A dan B
    'sebelum diurutkan
    Console.WriteLine("{0}SETELAH DIURUTKAN", _
      vbNewLine)
    Console.Write("Array A: ")
    MyArray.TampilkanData(A)
    Console.Write("Array B: ")
    MyArray.TampilkanData(B)
    
    Console.ReadLine()
  End Sub
End Module
