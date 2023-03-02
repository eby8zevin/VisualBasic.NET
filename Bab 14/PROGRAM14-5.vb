'interface untuk menyimpan data
Interface ISetData
  Sub SetData(ByVal data As Integer)  
End Interface

'interface untuk mengambil data
Interface IGetData
  Function GetData() As Integer  
End Interface

'kelas yang mengimplementasikan
'interface ISetData dan IGetData
Class BilanganBulat: Implements ISetData, IGetData
  Private data As Integer
  
  'mengimplementasikan metode SetData()
  Public Sub SetData(ByVal data As Integer) _
    Implements ISetData.SetData
    Me.data = data      
  End Sub
  
  'mengimplementasikan metode GetData
  Public Function GetData() As Integer _
    Implements IGetData.GetData
    Return data  
  End Function  
End Class

Module Program   
  Sub Main()    
    'membuat objek dari kelas BilanganBulat
    Dim obj As BilanganBulat = New BilanganBulat()
    
    'memanggil metode SetData()
    obj.SetData(99)
    
    'memanggil metode GetData()
    Console.WriteLine("Nilai = {0}", obj.GetData())
    
    Console.ReadLine()
  End Sub
End Module
