Module Program    
  Sub Main()
    'array tidak terurut
    Dim data() As Integer = {8,21,7,19,6,50,9,10,17,45}
    Dim n As Integer
    
    'menampilkan data sebelum diurutkan
    Console.Write("Sebelum diurutkan: ")
    For Each elemen In data
      Console.Write("{0} ", elemen)
    Next
    
    Console.WriteLine()
    
    'jumlah elemen di dalam array
    n = data.Length
    
    'mengurutkan data
    For i=0 To n-2 'ada n-1 langkah (dari i=0 sampai i=8)
      For j=n-1 To i+1 Step -1
        If (data(j) < data(j-1)) Then
          'tukar data A(j) dengan A(j-1)
          Dim temp As Integer = data(j)
          data(j) = data(j-1)
          data(j-1) = temp
        End If
      Next
    Next
    
    'menampilkan data sebelum diurutkan
    Console.Write("Setelah diurutkan: ")
    For Each elemen In data
      Console.Write("{0} ", elemen)
    Next    
    
    Console.ReadLine()
  End Sub
End Module
