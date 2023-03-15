'delegasi generik
Delegate Sub Tulis(Of T)(ByVal nilai As T)

Module Program  
  'metode untuk mencetak data String
  Sub TulisString(ByVal s As String)
    Console.WriteLine("String{0}: {1}", _
      vbTab, s)
  End Sub
  
  'metode untuk mencetak data Integer
  Sub TulisInteger(ByVal i As Integer)
    Console.WriteLine("Integer{0}: {1}", _
      vbTab, i)
  End Sub
  
  'metode untuk mencetak data Double
  Sub TulisDouble(ByVal d As Double)
    Console.WriteLine("Double{0}: {1}", _
      vbTab, d)
  End Sub
  
  'metode untuk mencetak data karakter
  Sub TulisKarakter(ByVal c As Char)
    Console.WriteLine("Char{0}: {1}", _
      vbTab, c)
  End Sub
  
  Sub Main()
    'membuat delegasi untuk tipe String
    Dim del1 As Tulis(Of String) = _
      New Tulis(Of String)(AddressOf TulisString)
    'memanggil delegasi
    del1("Visual Basic .NET")
   
    'membuat delegasi untuk tipe Integer
    Dim del2 As Tulis(Of Integer) = _
      New Tulis(Of Integer)(AddressOf TulisInteger)
    del2(777)
   
    'membuat delegasi untuk tipe Double
    Dim del3 As Tulis(Of Double) = _
      New Tulis(Of Double)(AddressOf TulisDouble)
    del3(44.55)
   
    'membuat delegasi untuk tipe Char
    Dim del4 As Tulis(Of Char) = _
      New Tulis(Of Char)(AddressOf TulisKarakter)
    del4("M"c)    
    
    Console.ReadLine()
  End Sub
End Module
