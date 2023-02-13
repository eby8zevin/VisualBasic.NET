Class KoleksiString
  Private Const UKURAN_STANDAR As Integer = 10
  Private kontainer As String()
  Private __kapasitas As Integer
  
  Public Sub New()
    kontainer = New String(UKURAN_STANDAR) {}
    __kapasitas = UKURAN_STANDAR
  End Sub
  
  Public Sub New(ByVal kapasitas As Integer)
    kontainer = New String(kapasitas) {}
    __kapasitas = kapasitas
  End Sub
    
  'mendefinisikan pengindeks (properti default)
  Public Default Property _
    Baris(ByVal index As Integer) As String
    Set
      If index < __kapasitas Then
        kontainer(index) = Value
      Else
        Console.WriteLine("Kontainer penuh")
        End
      End If
    End Set
    Get
      If index < __kapasitas Then
        Return kontainer(index)      
      Else        
        Return Nothing
      End If
    End Get
  End Property
  
  'properti Kapasitas (read-only)
  Public ReadOnly Property Kapasitas() As Integer
    Get
      Return __kapasitas
    End Get
  End Property
End Class

Module Program
  Sub Main()
    Dim obj As KoleksiString = New KoleksiString(3)
    
    'mengisi nilai data melalui pengindeks pertama
    obj(0) = "Visual Basic"
    obj(1) = "C#"
    obj(2) = "C++/CLI"
        
    'menampilkan isi koleksi menggunakan pengindeks
    For i=0 To obj.Kapasitas-1
      Console.WriteLine(obj(i))
    Next    
    
    Console.ReadLine()
  End Sub
End Module
