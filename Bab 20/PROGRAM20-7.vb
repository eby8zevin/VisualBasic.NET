'namespace bagian luar
Namespace Bangun
  
  'namespace bagian dalam
  Namespace DuaDimensi
    Class Segiempat
      Private __p As Double
      Private __l As Double
      Public Sub New()
        __p = 0
        __l = 0
      End Sub
      Public Sub New(ByVal __p As Double, 
                     ByVal __l As Double)      
        Me.__p = __p
        Me.__l = __l
      End Sub
      Public Sub New(ByVal sisi As Double)
        __p = sisi
        __l = sisi 
      End Sub
      Public Property Panjang() As Double
        Set
          __p = Value
        End Set
        Get
          Return __p
        End Get
      End Property
      Public Property Lebar() As Double
        Set
          __l = Value
        End Set
        Get
          Return __l
        End Get
      End Property
      Public Function HitungLuas() As Double
        Return __p * __l
      End Function
    End Class
  End Namespace  'namespace bagian dalam  
End Namespace  'namespace bagian luar

Module Program  
  Sub Main()    
    'menggunakan kelas Segiempat
    Dim obj As Bangun.DuaDimensi.Segiempat
    obj = New Bangun.DuaDimensi.Segiempat()
    
    obj.Panjang = 5
    obj.Lebar = 4
    
    Console.WriteLine("Luas persegi panjang = {0}", _
                      obj.HitungLuas())
    
    Console.ReadLine()
  End Sub
End Module
