'membuat tipe eksepsi
Class NegativeValueException: Inherits Exception
  'konstruktor tanpa parameter
  Public Sub New()    
  End Sub
  
  'konstruktor dengan satu parameter
  Public Sub New(ByVal message As String)
    MyBase.New(message)    
  End Sub
  
  'konstruktor dengan dua parameter
  Public Sub New(ByVal message As String, _ 
    ByVal inner As Exception) 
    MyBase.New(message, inner)
  End Sub
End Class

'menggunakan eksepsi
Class Lingkaran
  Private jarijari As Double
  
  'konstruktor Lingkaran
  Public Sub New()
    jarijari = 0
  End Sub
  
  Public Sub New(ByVal jarijari As Double)
    If jarijari < 0 Then
      'melempar eksepsi NegativeValueException
      Throw New NegativeValueException("ERROR: " _
            & "Nilai jari-jari tidak boleh negatif.")
    End If
    Me.jarijari = jarijari
  End Sub
  
  Public Function HitungLuas() As Double
    Return Math.PI * Math.Pow(jarijari, 2)
  End Function
  
  Public Function HitungKeliling() As Double
    Return 2 * Math.PI * jarijari
  End Function
  
  Public Sub CetakLuas()
    Console.WriteLine("Luas lingkaran {0}= {1}", _ 
                      vbTab, HitungLuas())
  End Sub
  
  Public Sub CetakKeliling()
    Console.WriteLine("Keliling lingkaran {0}= {1}", _ 
                      vbTab, HitungKeliling())
  End Sub
End Class

Module Program  
  Sub Main()
    Dim obj As Lingkaran = Nothing    
    Console.Write("Masukkan nilai jari-jari: ")
    Dim s As String = Console.ReadLine()

    Try
      Dim r As Double = Double.Parse(s)
      'membuat objek Lingkaran
      obj = New Lingkaran(r)
      
      Console.WriteLine()
      
      'menampilkan luas dan keliling
      obj.CetakLuas()
      obj.CetakKeliling()
    Catch e As NegativeValueException
      Console.WriteLine(e.Message)
    Catch e As FormatException
      Console.WriteLine("ERROR: " _
        & "Anda tidak memasukkan bilangan.")
    End Try
    
    Console.ReadLine()
  End Sub
End Module
