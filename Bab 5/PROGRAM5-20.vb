Module Program    
  'metode (fungsi) untuk mengekstrak elemen array
  Function Ekstrak(A() As Integer, _
                   indeksAwal As Integer, _
                   indeksAkhir As Integer) As Integer()
    'array temporari
    Dim temp As Integer() = _
      New Integer(indeksAkhir-indeksAwal) {}
    'indeks untuk array temp
    Dim j As Integer
    
    'mengekstrak array A dan
    'menampungnya ke array temp
    j = 0
    For i=indeksAwal To indeksAkhir
      temp(j) = A(i)
      j += 1
    Next
    
    'array temp sebagai nilai balik
    Return temp
  End Function
  
  'metode (prosedur) untuk menampilkan isi array
  Sub TampilkanArray(A() As Integer)
    For Each elemen In A
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
  End Sub
  
  'metode (prosedur) utama
  Sub Main()
    'membuat array yang akan diekstrak
    Dim A() As Integer = {10,20,30,40,50,60,70,80,90,100}
    
    'array hasil ekstrak
    Dim B() As Integer
    
    'mengekstrak array A    
    B = Ekstrak(A, 3, 6)
    
    'menampilkan array A
    Console.Write("Isi array A: ")
    TampilkanArray(A)
    
    'menampilkan array B
    Console.Write("Isi array B: ")
    TampilkanArray(B)    
    
    Console.ReadLine()
  End Sub
End Module
