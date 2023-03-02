'interface untuk menyimpan data
Interface ISetData
  Sub SetData(ByVal data As Integer)
End Interface

'interface untuk mengambil data
Interface IGetData
  Function GetData() As Integer
End Interface

'interface yang diturunkan dari
'inteface ISetData dan IGetData
Interface IData: Inherits ISetData, IGetData
  'menambah deklarasi metode baru
  Sub PrintData()
End Interface  

'kelas yang mengimplementasikan interface IData
Class BilanganBulat: Implements IData
  Private data As Integer
  
  'implementasi IData.SetData()
  Public Sub SetData(ByVal data As Integer) _
    Implements IData.SetData
    Me.data = data
  End Sub

  'implementasi IData.GetData()
  Public Function GetData() As Integer _
    Implements IData.GetData
    Return data
  End Function
  
  'implementasi IData.PrintData()
  Public Sub PrintData() _
    Implements IData.PrintData
    Console.WriteLine("Nilai = {0}", data)
  End Sub  
End Class

Module Program   
  Sub Main()    
    'membuat objek dari kelas BilanganBulat
    Dim obj As BilanganBulat = New BilanganBulat()
    
    'memanggil metode SetData()
    obj.SetData(99)
    
    'memanggil metode GetData()
    Console.WriteLine("Nilai = {0}", obj.GetData())
    
    'memanggil kembali metode SetData()
    obj.SetData(88)
    
    'cara lain menampilkan data
    obj.PrintData()
    
    Console.ReadLine()
  End Sub
End Module
