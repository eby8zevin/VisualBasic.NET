Module Program    
  Sub Main()
    'array dengan 10 elemen bertipe Integer
    Dim data() As Integer = {8,21,7,19,6,50,9,10,17,45}
    Dim maks As Integer
    
    maks = data(0) 'mula-mula elemen pertama dianggap maksimum
    'mengakses seluruh elemen array
    Console.Write("Data: ")
    For Each elemen As Integer In data
      Console.Write("{0}  ", elemen)
      If elemen > maks Then maks = elemen
    Next
    
    Console.WriteLine(Chr(10))
    
    Console.WriteLine("Nilai maksimum " _
      & "adalah: {0}", maks)    
    
    Console.ReadLine()
  End Sub
End Module
