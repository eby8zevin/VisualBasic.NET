Module Program    
  Sub Main()
    Dim data() As Integer = {80,20,100,40,30,60,50,90,10,70}
    Dim nilai, indeks, i As Integer
    Dim s As String
    
    'menampilkan elemen array
    Console.Write("Data: ")
    For Each elemen In data    
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
    
    Console.Write("Masukkan nilai yang akan dicari: ")
    s = Console.ReadLine()
    nilai = Int32.Parse(s)
    
    'mencari nilai
    indeks = -1
    i = 0
    For Each elemen In data    
      If (elemen = nilai) Then
        indeks = i
        Exit For
      End If
      i += 1
    Next    
    
    Console.WriteLine(Chr(9))
    Console.WriteLine("{0} terdapat pada indeks ke-{1}", _
      nilai, indeks)    
    
    Console.ReadLine()
  End Sub
End Module
