Module Program    
  Sub Main()  
    Dim JA As Integer()() = New Integer(2)() {}

    'inisialisasi nilai pada baris pertama
    JA(0) = New Integer(1) {1,2}

    'inisialisasi nilai pada baris kedua
    JA(1) = New Integer(5) {3,4,5,6,7,8}

    'inisialisasi nilai pada baris ketiga
    JA(2) = new Integer(3) {9,10,11,12}
    
    'menampilkan array
    For i=0 To JA.GetUpperBound(0)      
      For j=0 To JA(i).Length-1
        Console.Write("{0}{1}", JA(i)(j), Chr(9))        
      Next      
      'membuat baris baru pada setiap nilai i
      Console.WriteLine()
    Next
    
    Console.ReadLine()
  End Sub
End Module
