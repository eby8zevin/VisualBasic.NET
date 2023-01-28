Module Program    
  'deklarasi field dengan sifat read only
  ReadOnly A() As Integer = {10,20,30,40,50}
  
  Sub Main()    
    'mengubah elemen pertama pada array A
    A(0) = 777  'tetap diperbolehkan
    
    'menampilkan elemen array A
    Console.WriteLine("Isi array A:")
    For Each elemen In A
      Console.WriteLine(elemen)      
    Next        
    
    Console.ReadLine()
  End Sub
End Module
