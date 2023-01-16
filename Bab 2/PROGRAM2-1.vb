Module Program
  Sub Main()
    'mendeklarasikan variabel
    Dim panjang As Integer
    Dim lebar As Integer
    Dim luas As Integer
    
    'mengisi nilai ke dalam variabel
    panjang = 7
    lebar = 5
    
    'melakukan perhitungan dan menampung
    'hasilnya ke dalam variabel luas
    luas = panjang * lebar
    
    'menampilkan luas
    Console.WriteLine("PERSEGI PANJANG")
    Console.WriteLine("panjang {0} = {1}", Chr(9), panjang)
    Console.WriteLine("lebar {0} = {1}", Chr(9), lebar)
    Console.WriteLine("luas persegi panjang {0} = {1}", Chr(9), luas)
    
    Console.ReadLine()
  End Sub
End Module
