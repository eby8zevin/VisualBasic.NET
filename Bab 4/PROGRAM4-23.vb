Module Program    
  Sub Main()
    'pengulangan bagian luar
    For i=1 To 10
      'pengulangan bagian dalam
      For j=1 To i
        Console.Write("{0} ", i * j)
      Next
      'baris baru di setiap nilai i
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
