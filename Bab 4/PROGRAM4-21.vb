Module Program    
  Sub Main()
    'array dengan 5 elemen bertipe Integer
    Dim data() As Integer = {10,20,30,40,50}
    
    'mengakses seluruh elemen array
    For Each elemen As Integer In data
      Console.WriteLine(elemen)
    Next
    
    Console.ReadLine()
  End Sub
End Module
