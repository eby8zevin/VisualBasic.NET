Module Program    
  Sub Main()
    'array penampung data bilangan
    Dim bahasa As String()
    
    'alokasi array dengan 4 elemen
    bahasa = New String(3) {}
    
    'mengisi nilai ke dalam elemen array
    bahasa(0) = "VB.NET"
    bahasa(1) = "C#"
    bahasa(2) = "C++/CLI"
    bahasa(3) = "F#"
    
    'menampilkan elemen array
    Console.WriteLine("Bahasa Pemrograman:")
    For Each elemen In bahasa
      Console.WriteLine(elemen)      
    Next    
    
    Console.ReadLine()
  End Sub
End Module
