'mendeklarasikan tipe delegasi
Delegate Function OperasiBilangan( _
  ByVal a As Double, ByVal b As Double) _
  As Double

Class Aritmetika
  Private operand1 As Double
  Private operand2 As Double
  
  Public Sub New(ByVal op1 As Double, _
                 ByVal op2 As Double)
    operand1 = op1
    operand2 = op2
  End Sub
  
  Public Function Tambah() As Double
    Return operand1 + operand2
  End Function
  
  Public Function Kurang() As Double
    Return operand1 - operand2
  End Function
  
  Public Function Kali() As Double
    Return operand1 * operand2
  End Function
  
  Public Function Bagi() As Double
    Return operand1 / operand2
  End Function  
End Class

Module Program 
  Sub Main()
    'mendeklarasikan variabel lokal
    Dim a As Double = 15
    Dim b As Double = 2
    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As OperasiBilangan
    
    'membuat objek dari kelas Aritmetika
    Dim obj As Aritmetika = New Aritmetika(a, b)
    
    
    'membuat objek delegasi
    'untuk menunjuk ke metode Aritmetika.Tambah()
    objDel = AddressOf obj.Tambah
    
    'memanggil metode yang ditunjuk
    'oleh objek delegasi melalui objDel
    Console.WriteLine("{0} + {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Aritmetika.Kurang()
    objDel = AddressOf obj.Kurang
    Console.WriteLine("{0} - {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Aritmetika.Kali()
    objDel = AddressOf obj.Kali
    Console.WriteLine("{0} * {1} = {2}",
      a, b, objDel(a, b))
    
    'membuat objek delegasi 
    'untuk menunjuk ke metode Aritmetika.Bagi()
    objDel = AddressOf obj.Bagi
    Console.WriteLine("{0} / {1} = {2}",
      a, b, objDel(a, b))
    
    Console.ReadLine()
  End Sub
End Module
