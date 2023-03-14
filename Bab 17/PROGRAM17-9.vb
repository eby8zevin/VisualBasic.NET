Class Daftar (Of T As Structure)
  Private __daftar As T()
  Private indeks As Integer
  
  Public Sub New(ByVal ukuran As Integer)
    __daftar = New T(ukuran-1) {}
    indeks = -1
  End Sub
  
  Public Sub IsiObjek(ByVal indeks As Integer, _
                      objek As T)
    If indeks >= __daftar.Length Then
      Console.WriteLine("Indeks terlalu besar")
    ElseIf indeks < 0 Then
      Console.WriteLine("Indeks tidak boleh negatif")
    Else
      __daftar(indeks) = objek
      Me.indeks += 1
    End If
  End Sub
  
  Public Function AmbilObjek(ByVal indeks As Integer) _
    As T
    If indeks >= __daftar.Length Then
      Console.WriteLine("Indeks terlalu besar")
      End
    ElseIf indeks < 0 Then
      Console.WriteLine("Indeks tidak boleh negatif")
      End
    End If
    Return __daftar(indeks)
  End Function  
End Class

Module Program  
  Sub Main()
    'membuat objek dari kelas Daftar
    Dim list As Daftar(Of Integer) = _
      New Daftar(Of Integer)(5)
    
    'mengisi objek ke dalam list
    list.IsiObjek(0, 10)
    list.IsiObjek(1, 20)
    list.IsiObjek(2, 30)
    list.IsiObjek(3, 40)
    list.IsiObjek(4, 50)
    
    'menampilkan objek di dalam list
    Console.WriteLine("Isi daftar: ")
    For i As Integer = 0 To 4    
      Console.WriteLine(list.AmbilObjek(i))
    Next
    
    Console.ReadLine()
  End Sub
End Module
