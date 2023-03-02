Interface IPertama
  Sub Test(ByVal s As String)
End Interface

Interface IKedua
  Sub Test(ByVal s As String)
End Interface

Class CMyClass: Implements IPertama, IKedua
  'satu implementasi 
  'untuk IPertama.Test() dan IKedua.Test()
  Public Sub Test(ByVal s As String) _
    Implements IPertama.Test, IKedua.Test
    Console.WriteLine(s)
  End Sub
End Class

Module Program   
  Sub Main()    
    'membuat objek dari kelas CMyClass
    Dim obj As CMyClass = New CMyClass()
    
    'memanggil metode Test()
    obj.Test("Satu implementasi untuk dua interface")
        
    Console.ReadLine()
  End Sub
End Module
