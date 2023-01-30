Class Segiempat 
  Private panjang As Double
  Private lebar As Double
  
  'konstruktor dengan dua parameter
  Public Sub New(panjang As Double, lebar As Double)
    Me.panjang = panjang
    Me.lebar = lebar
  End Sub
  
  'konstruktor dengan satu parameter
  Public Sub New(sisi As Double)
    panjang = sisi
    lebar = sisi
  End Sub  
  
  Private Function HitungLuas() As Double
    Return panjang * lebar
  End Function
  
  Public Sub CetakLuas(s As String)
    Console.WriteLine(s & HitungLuas())  
  End Sub
  
  'metode dengan parameter bertipe objek
  Public Function Sama(obj As Segiempat) As Boolean
    If (obj.panjang = panjang And _
        obj.lebar = lebar) Then
      Return True   
    Else
      Return False
    End If
  End Function
  
End Class

Module Program
  Sub Main()
    Dim se1, se2, se3 As Segiempat
    Dim hasil1, hasil2 As Boolean
		
    'membuat objek dari kelas Segiempat
    se1 = New Segiempat(6,4)
    se2 = New Segiempat(8,6)
    se3 = New Segiempat(6,4)
		
    'membandingkan objek se1 dan se2
    hasil1 = se1.Sama(se2)
		
    'membandingkan objek se1 dan se3
    hasil2 = se1.Sama(se3)
		
    'menampilkan hasil
    If (hasil1) Then
      Console.WriteLine("se1 sama dengan se2")	
    Else
      Console.WriteLine("se1 tidak sama dengan se2")
    End If
		
    If (hasil2) Then
      Console.WriteLine("se1 sama dengan se3")	
    Else
      Console.WriteLine("se1 tidak sama dengan se3")
    End If
				
    Console.ReadLine()
  End Sub
End Module
