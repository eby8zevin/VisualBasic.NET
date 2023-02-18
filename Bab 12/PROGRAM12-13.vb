Module Program  
  Sub Main()    
    
    Dim barisdata As String = "001,Muhammad Adam,Bandung,08122499999"
    
    'mengurai string
    Dim data As String() = Split(barisdata, ",")
		
    'menampilkan data hasil penguraian
    For Each s As String In data
      Console.WriteLine(s)
    Next
    
    Console.ReadLine()
  End Sub
End Module
