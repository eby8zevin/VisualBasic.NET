'kelas bagian pertama 
Partial Class Segiempat
  Private panjang As Double
  Private lebar As Double
  
  'deklarasi metode parsial
  Partial Private Sub HitungLuas(ByRef luas As Double)
  End Sub
  
End Class 'akhir kelas Segiempat bagian pertama

'kelas bagian kedua
Partial Class Segiempat
  
  'konstruktor
  Public Sub New(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub  
  
  'implementasi metode parsial
  Private Sub HitungLuas(ByRef luas As Double)
    luas = panjang * lebar
  End Sub
  
  Public Sub UbahData(ByVal p As Double, ByVal l As Double)
    panjang = p
    lebar = l
  End Sub
  
  Public Sub CetakLuas()
    Dim luas As Double = 0
    'memanggil metode HitungLuas()
    HitungLuas(luas)
    Console.WriteLine("Luas = " & luas)
  End Sub
  
End Class 'akhir kelas Segiempat bagian kedua

Module Program
  Sub Main()
    'membuat objek dari kelas Segiempat
    'dengan nilai awal 10 dan 8
    Dim se As Segiempat = New Segiempat(10, 8)
    
    Console.WriteLine("Sebelum diubah:")
    se.CetakLuas()

    'mengubah nilai dari data panjang dan lebar
    se.UbahData(20,15)

    Console.WriteLine("{0}Setelah diubah:", vbNewLine)
    se.CetakLuas()
    
    Console.ReadLine()
  End Sub
End Module
