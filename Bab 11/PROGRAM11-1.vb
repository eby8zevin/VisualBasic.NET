'mendefinisikan struktur dengan nama Titik
Structure Titik
  Public x As Integer
  Public y As Integer
End Structure

Module Program
  Sub Main()    
    'mendeklarasikan variabel bertipe Titik
    Dim A As Titik
    Dim B As Titik
    
    'mengisi nilai ke dalam A
    A.x = 0
    A.y = 0
    
    'mengisi nilai ke dalam B
    B.x = 3
    B.y = 5
        
    'menampilkan nilai    
    Console.WriteLine("A({0},{1})", A.x, A.y)
    Console.WriteLine("B({0},{1})", B.x, B.y)      
    
    Console.ReadLine()
  End Sub
End Module
