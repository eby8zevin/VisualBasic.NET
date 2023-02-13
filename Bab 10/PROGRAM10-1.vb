Class MyString
  Private __text As String
  
  'konstruktor
  Public Sub New(ByVal s As String)
    __text = s
  End Sub
  
  'properti Text
  Public Property Text() As String
    Set
      __text = Value
    End Set
    Get
      Return __text
    End Get
  End Property
  
  'overload operator plus (+)
  Public Shared Operator +(ByVal s1 As MyString, _
                           ByVal s2 As MyString) _
                           As MyString
    Dim temp As MyString = New MyString(s1.__text & s2.__text)  
    Return temp
  End Operator
  
End Class

Module Program
  Sub Main()
    Dim namadepan As MyString = New MyString("Muhammad")
    Dim spasi As MyString = New MyString(" ")
    Dim namabelakang As MyString = New MyString("Adam")
    
    'operator + diterapkan untuk tipe MyString
    Dim namalengkap As MyString
    namalengkap = namadepan + spasi + namabelakang
    
    Console.WriteLine("Nama Depan {0}: {1}", _
      vbTab, namadepan.Text)
    Console.WriteLine("Nama Belakang {0}: {1}", _
      vbTab, namabelakang.Text)
    Console.WriteLine("Nama Lengkap {0}: {1}", _
      vbTab, namalengkap.Text)
    
    Console.ReadLine()
  End Sub
End Module
