Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  Public Sub New(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  Public Sub New(sisi As Double)
    panjang = sisi
    lebar = sisi
  End Sub  
  
  Public Sub New(obj As Segiempat)
  	panjang = obj.panjang
  	lebar = obj.lebar
  End Sub
  
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  'metode dengan parameter keluaran
  Private Sub HitungKeliling(ByRef hasil As Double)
    'mengisikan nilai ke dalam parameter hasil
    hasil = 2 * (panjang + lebar)
  End Sub
  
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())  
  End Sub
  
  Public Sub CetakKeliling(s As String)
    Dim temp As Double = 0
    
    'memanggil metode HitungKeliling()
    'dengan temp sebagai parameter keluaran
    HitungKeliling(temp)
    
    'menampilkan nilai variabel temp
    Console.WriteLine(s & temp)  
  End Sub
    
  Public Function Sama(obj As Segiempat) As Boolean
    If (obj.panjang = panjang And _
  	    obj.lebar = lebar) Then
  	   Return True   
    Else
    	 Return False
    End If
  End Function
  
  'metode yang mengembalikan objek
  Public Function PerbesarObjek(m As Integer) _
                  As Segiempat
    Dim temp As Segiempat 'referensi temporari
    temp = New Segiempat(panjang * m, lebar * m)
    'mengembalikan objek
    Return temp
  End Function
  
End Class

Module Program
  Sub Main()
    Dim se As Segiempat
    
    se = New Segiempat(8,6)
            
    'menampilkan luas dan keliling
    se.CetakLuas("Luas: ")
    se.CetakKeliling("Keliling: ")
                                 
    Console.ReadLine()
  End Sub
End Module
