Interface IPertama
  Sub Test(ByVal s As String)
End Interface

Interface IKedua
  Sub Test(ByVal s As String)
End Interface

Class CMyClass: Implements IPertama, IKedua
  'implementasi IPertama.Test()
  Public Sub Test1(ByVal s As String) _
    Implements IPertama.Test
    Console.WriteLine("IPertama: {0}", s)
  End Sub

  'implementasi IKedua.Test()
  Public Sub Test2(ByVal s As String) _
    Implements IKedua.Test
    Console.WriteLine("IKedua: {0}", s)
  End Sub
End Class

Module Program   
  Sub Main()    
    'membuat objek dari kelas CMyClass
    Dim obj As CMyClass = New CMyClass()
    
    'memanggil metode Test1() dan Test2()
    obj.Test1("implementasi interface pertama")
    obj.Test2("implementasi interface kedua")
    
    Console.ReadLine()
  End Sub
End Module
