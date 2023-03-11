'kelas yang berisi data Integer
Class IntegerClass
  'mendeklarasikan data dengan tipe Integer
  Private data As Integer
  
  'konstruktor dengan parameter bertipe Integer
  Public Sub New(ByVal data As Integer)
    Me.data = data
  End Sub
  
  'metode untuk mengubah nilai data
  Public Sub SetData(ByVal data As Integer)
    Me.data = data
  End Sub
  
  'metode untuk mengambil nilai data
  Public Function GetData() As Integer
    Return data
  End Function
  
  Public Sub ShowType()
    Console.WriteLine("Tipe kelas: {0}", data.GetType())
  End Sub
End Class

'kelas yang berisi data String
Class StringClass
  'mendeklarasikan data dengan tipe String
  Private data As String
  
  'konstruktor dengan parameter bertipe String
  Public Sub New(ByVal data As String)
    Me.data = data
  End Sub
  
  'metode untuk mengubah nilai data
  Public Sub SetData(ByVal data As String)
    Me.data = data
  End Sub
  
  'metode untuk mengambil nilai data
  Public Function GetData() As String
    Return data
  End Function
  
  Public Sub ShowType()
    Console.WriteLine("Tipe kelas: {0}", data.GetType())
  End Sub
End Class

Module Program  
  Sub Main()
    'mendeklarasikan referensi ke kelas IntegerClass    
    Dim obj1 As IntegerClass
    'membuat objek
    obj1 = New IntegerClass(777)
    
    'mengambil nilai data dari obj1
    Dim i As Integer = obj1.GetData()
      
    'menampilkan data dari obj1
    Console.WriteLine("Nilai: {0}",  i)
    obj1.ShowType()
    
    'mendeklarasikan referensi ke kelas StringClass    
    Dim obj2 As StringClass
    'membuat objek
    obj2 = New StringClass("Visual Basic .NET")
    
    'mengambil nilai data dari obj2
    Dim s As String = obj2.GetData()
    
    'menampilkan data dari obj2
    Console.WriteLine("{0}Nilai: {1}", vbNewLine, s)
    obj2.ShowType()
    
    Console.ReadLine()
  End Sub
End Module
