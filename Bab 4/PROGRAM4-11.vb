Module Program    
  Sub Main()
    Dim indeks, data As Integer
    Dim s As String
    
    Console.Write("60 80 10 70 40 ")
    Console.Write("30 20 100 90 50")
    Console.WriteLine()
    Console.WriteLine()
    
    Console.Write("Masukkan indeks: ")
    s = Console.ReadLine()
    
    indeks = Int32.Parse(s)
    
    data = CType(Choose(indeks, _
      60,80,10,70,40, _
      30,20,100,90,50), Int32)      
    
    Console.WriteLine("Data ke-{0} " _
      & "adalah {1}", indeks, data)
    
    Console.ReadLine()
  End Sub
End Module
