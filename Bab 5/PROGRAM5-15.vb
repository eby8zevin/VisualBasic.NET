Module Program    
  Sub Main()  
    Dim Array1D() As Integer = {10,20,30,40,50}
        
    Console.WriteLine("Jumlah elemen{0}: {1}", _
      Chr(9), Array1D.Length)
    Console.WriteLine("Jumlah dimensi{0}: {1}", _
      Chr(9), Array1D.Rank)
    
    'menampilkan array
    Console.Write("{0}Isi array: ", Chr(10))
    For i=0 To Array1D.Length-1
      Console.Write("{0} ", Array1D(i))      
    Next
    
    Console.ReadLine()
  End Sub
End Module
