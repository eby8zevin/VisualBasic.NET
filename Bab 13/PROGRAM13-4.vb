'mendeklarasikan tipe delegasi
Delegate Function OperasiBilangan( _
  ByVal a As Double, ByVal b As Double) _
  As Double

Class Aritmetika
  'metode statis untuk proses penjumlahan  
  Public Shared Function Tambah( _
                           ByVal op1 As Double, _
                           ByVal op2 As Double) As Double
    Return op1 + op2
  End Function
  
  'metode statis untuk proses pengurangan
  Public Shared Function Kurang( _
                           ByVal op1 As Double, _
                           ByVal op2 As Double) As Double
    Return op1 - op2
  End Function
  
  'metode statis untuk proses perkalian  
  Public Shared Function Kali( _
                           ByVal op1 As Double, _
                           ByVal op2 As Double) As Double
    Return op1 * op2
  End Function
  
  'metode statis untuk proses pembagian
  Public Shared Function Bagi( _
                           ByVal op1 As Double, _
                           ByVal op2 As Double) As Double
    Return op1 / op2
  End Function
End Class

Module Program 
  Sub Main()
    'mendeklarasikan variabel lokal
    Dim a As Double = 15
    Dim b As Double = 2
    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As OperasiBilangan
        
    'membuat objek delegasi
    'untuk menunjuk ke metode statis Aritmetika.Tambah()
    objDel = AddressOf Aritmetika.Tambah
    
    'memanggil metode yang ditunjuk
    'oleh objek delegasi melalui objDel
    Console.WriteLine("{0} + {1} = {2}",
      a, b, objDel.Invoke(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode statis Aritmetika.Kurang()
    objDel = AddressOf Aritmetika.Kurang
    Console.WriteLine("{0} - {1} = {2}",
      a, b, objDel.Invoke(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode statis Aritmetika.Kali()
    objDel = AddressOf Aritmetika.Kali
    Console.WriteLine("{0} * {1} = {2}",
      a, b, objDel.Invoke(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode statis Aritmetika.Bagi()
    objDel = AddressOf Aritmetika.Bagi
    Console.WriteLine("{0} / {1} = {2}",
      a, b, objDel.Invoke(a, b))
    
    Console.ReadLine()
  End Sub
End Module
