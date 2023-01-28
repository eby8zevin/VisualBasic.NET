Module Program    
  Sub Main()  
    Dim JA As Integer()() = New Integer(2)() {}
    JA(0) = New Integer(1) {}
    JA(1) = New Integer(5) {}
    JA(2) = New Integer(3) {}

    'mengisi nilai elemen pada baris pertama
    JA(0)(0) = 1
    JA(0)(1) = 2
    
    'mengisi nilai elemen pada baris kedua
    JA(1)(0) = 3
    JA(1)(1) = 4
    JA(1)(2) = 5
    JA(1)(3) = 6
    JA(1)(4) = 7
    JA(1)(5) = 8
    
    'mengisi nilai elemen pada baris ketiga
    JA(2)(0) = 9
    JA(2)(1) = 10
    JA(2)(2) = 11
    JA(2)(3) = 12
    
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
