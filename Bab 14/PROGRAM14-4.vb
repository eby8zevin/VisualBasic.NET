Interface IMyInterface
  Sub Test(ByVal s As String)  
End Interface

Class CMyClass: Implements IMyInterface
  Public Sub Test(ByVal s As String) _
    Implements IMyInterface.Test
    Console.WriteLine(s)
  End Sub
End Class

Module Program   
  Sub Main()    
    'membuat objek dari kelas CMyClass
    Dim cref As CMyClass = New CMyClass()
    
    'memanggil CMyClass.Test() dari cref
    cref.Test("CMyClass")
    
    'typecasting cref ke tipe interface
    Dim iref As IMyInterface = CType(cref, IMyInterface)
    
    'memanggil CMyClass.Test() dari iref
    iref.Test("IMyInterface")
    
    Console.ReadLine()
  End Sub
End Module
