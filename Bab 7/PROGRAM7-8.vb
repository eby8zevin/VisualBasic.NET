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
  
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())  
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
    Dim se1, se2 As Segiempat
    
    se1 = New Segiempat(8,6)
    
    'membuat objek baru dengan memanggil
    'metode PerbesarObjek() dari se1
    se2 = se1.PerbesarObjek(2)   'diperbesar 2x
                                 'dari ukuran semula
    
    'menampilkan luas
    se1.CetakLuas("Luas se1: ")
    se2.CetakLuas("Luas se2: ")
                                 
    Console.ReadLine()
  End Sub
End Module
