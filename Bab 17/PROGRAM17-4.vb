'kelas generik dengan dua parameter tipe
Class Generik (Of T, V)  
  Private data1 As T
  Private data2 As V
  
  'konstruktor dengan parameter bertipe generik
  Public Sub New(data1 As T, data2 As V)
    Me.data1 = data1
    Me.data2 = data2
  End Sub
  
  'metode untuk mengubah nilai data1
  Public Sub SetData1(data1 As T)
    Me.data1 = data1
  End Sub
  
  'metode untuk mengambil nilai data1
  Public Function GetData1() As T
    Return data1
  End Function
  
  'metode untuk mengubah nilai data2
  Public Sub SetData2(data2 As V)
    Me.data2 = data2
  End Sub
  
  'metode untuk mengambil nilai data2
  Public Function GetData2() As V
    Return data2
  End Function
  
  Public Sub ShowType()
    Console.WriteLine("Tipe T: {0}", data1.GetType())
    Console.WriteLine("Tipe V: {0}", data2.GetType())
  End Sub
End Class

Module Program  
  Sub Main()
    'mendeklarasikan referensi ke kelas Generik
    'dengan parameter bertipe Integer dan String
    Dim obj As Generik(Of Integer, String)
    'membuat objek
    obj = New Generik(Of Integer, String)(777, _
      "Visual Basic .NET")
    
    'mengambil nilai data1 dan data2 dari obj
    Dim i As Integer = obj.GetData1()
    Dim s As String = obj.GetData2()
      
    'menampilkan data1 dan data2 dari obj
    Console.WriteLine(i)
    Console.WriteLine(s)
    obj.ShowType()
    
    Console.ReadLine()
  End Sub
End Module
