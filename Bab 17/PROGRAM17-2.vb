'kelas generik
Class Generik (Of T)
  'mendeklarasikan data dengan tipe generik
  Private data As T
  
  'konstruktor dengan parameter bertipe generik
  Public Sub New(ByVal data As T)
    Me.data = data
  End Sub
  
  'metode untuk mengubah nilai data
  Public Sub SetData(ByVal data As T)
    Me.data = data
  End Sub
  
  'metode untuk mengambil nilai data
  Public Function GetData() As T
    Return data
  End Function
  
  Public Sub ShowType()
    Console.WriteLine("Tipe T: {0}", data.GetType())
  End Sub
End Class

Module Program  
  Sub Main()
    'mendeklarasikan referensi ke kelas Generik
    'dengan parameter bertipe Integer
    Dim obj1 As Generik(Of Integer)
    'membuat objek
    obj1 = New Generik(Of Integer)(777)
    
    'mengambil nilai data dari obj1
    Dim i As Integer = obj1.GetData()
      
    'menampilkan data dari obj1
    Console.WriteLine("Nilai: {0}", i)
    obj1.ShowType()
    
    'mendeklarasikan referensi ke kelas Generik
    'dengan parameter bertipe String
    Dim obj2 As Generik(Of String)
    'membuat objek
    obj2 = New Generik(Of String)("Visual Basic .NET")
    
    'mengambil nilai data dari obj2
    Dim s As String = obj2.GetData()
    
    'menampilkan data dari obj2
    Console.WriteLine("{0}Nilai: {1}", vbNewLine, s)
    obj2.ShowType()

    'mendeklarasikan referensi ke kelas Generik
    'dengan parameter bertipe Double
    Dim obj3 As Generik(Of Double)
    'membuat objek
    obj3 = New Generik(Of Double)(88.99)
    
    'mengambil nilai data dari obj3
    Dim d As Double = obj3.GetData()
    
    'menampilkan data dari obj3
    Console.WriteLine("{0}Nilai: {1}", vbNewLine, d)
    obj3.ShowType()
    
    'mendeklarasikan referensi ke kelas Generik
    'dengan parameter bertipe Char
    Dim obj4 As Generik(Of Char)
    'membuat objek
    obj4 = New Generik(Of Char)("B"c)
    
    'mengambil nilai data dari obj4
    Dim c As Char = obj4.GetData()
    
    'menampilkan data dari obj4
    Console.WriteLine("{0}Nilai: {1}", vbNewLine, c)
    obj4.ShowType()
    
    Console.ReadLine()
  End Sub
End Module
