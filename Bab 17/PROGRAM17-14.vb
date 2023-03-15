'interface generik
Interface IBisaDihitung(Of T)
  Function Tambah(ByVal nilai As T) As T
  Function Kurang(ByVal nilai As T) As T
  Function Kali(ByVal nilai As T) As T
  Function Bagi(ByVal nilai As T) As T
End Interface

'kelas Bilangan
'mengimplementasikan interface IBisaDihitung
Class Bilangan(Of T): Implements IBisaDihitung(Of T)
  Private __data As T
  
  'konstruktor
  Public Sub New(ByVal data As T)
    __data = data
  End Sub
  
  'implementasi metode Tambah()
  Public Function Tambah(ByVal nilai As T) _
    As T Implements IBisaDihitung(Of T).Tambah
    'Return __data + nilai   'salah
    Dim a As Object = __data
    Dim b As Object = nilai
    Return CType(a + b, T)
  End Function
  
  'implementasi metode Kurang()
  Public Function Kurang(ByVal nilai As T) _
    As T Implements IBisaDihitung(Of T).Kurang
    Dim a As Object = __data
    Dim b As Object = nilai
    Return CType(a - b, T)
  End Function
  
  'implementasi metode Kali()
  Public Function Kali(ByVal nilai As T) _
    As T Implements IBisaDihitung(Of T).Kali
    Dim a As Object = __data
    Dim b As Object = nilai
    Return CType(a * b, T)
  End Function
  
  'implementasi metode Bagi()
  Public Function Bagi(ByVal nilai As T) _
    As T Implements IBisaDihitung(Of T).Bagi
    Dim a As Object = __data
    Dim b As Object = nilai
    Return CType(a / b, T)
  End Function
  
  'properti Data
  Public Property Data() As T
    Set
      __data = Value
    End Set
    Get
      Return __data
    End Get
  End Property
End Class

Module Program  
  Sub Main()
    'membuat bilangan bulat
    Dim a As Bilangan(Of Integer) = _
      New Bilangan(Of Integer)(17)
   
    Console.WriteLine("Bilangan bulat:")
    Console.WriteLine("17 + 3 = {0}", _
      a.Tambah(3))
    Console.WriteLine("17 - 3 = {0}", _
      a.Kurang(3))
    Console.WriteLine("17 * 3 = {0}", _
      a.Kali(3))
    Console.WriteLine("17 / 3 = {0}", _
      a.Bagi(3))
   
    'membuat bilangan riil
    Dim b As Bilangan(Of Double) = _
      New Bilangan(Of Double)(12.25)
    
    Console.WriteLine("{0}Bilangan riil:", _
      vbNewLine)
    Console.WriteLine("12.25 + 0.25 = {0}", _
      b.Tambah(0.25))
    Console.WriteLine("12.25 - 0.25 = {0}", _
      b.Kurang(0.25))
    Console.WriteLine("12.25 * 0.25 = {0}", _
      b.Kali(0.25))
    Console.WriteLine("12.25 / 0.25 = {0}", _
      b.Bagi(0.25))
    
    Console.ReadLine()
  End Sub
End Module
