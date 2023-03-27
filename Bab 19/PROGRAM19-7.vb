Imports System.Linq
Imports System.Collections.Generic

Module Program  
  Sub Main()
    'sumber data berupa objek dari kelas List(Of T)
    Dim A As List(Of Integer) = New List(Of Integer)()
    
    'menambah elemen ke dalam list
    A.Add(10)
    A.Add(20)
    A.Add(30)
    A.Add(40)
    A.Add(50)
    
    'QUERY 1
    'query yang mengembalikan enumerasi.
    'Saat ini, query belum dieksekusi
    Dim hasil As IEnumerable(Of Integer) = _
                    from e in A
                    select e
    
    'QUERY 2
    'query yang menghasilkan nilai skalar.
    'Query akan langsung dieksekusi satu kali
    Dim count As Integer = _
                   (from e in A
                    select e).Count()
    
    'penelusuran pertama terhadap variabel hasil
    'akan mengeksekusi QUERY 1
    Console.WriteLine("PENELUSURAN PERTAMA")
    Console.Write("Hasil query pertama{0}: ", vbTab)
    For Each i As Integer in hasil    
      Console.Write(i & " ")
    Next
    
    'menampilkan jumlah elemen
    'tidak akan mengeksekusi QUERY 2
    Console.WriteLine("{0}Jumlah elemen{1}{2}: {3}", _
      vbNewLine, vbTab, vbTab, count)
    
    'mengubah sumber data dengan menambah
    'tiga elemen baru
    A.Add(60)
    A.Add(70)
    A.Add(80)
        
    'penelusuran kedua terhadap variabel hasil
    'akan kembali mengeksekusi QUERY 1
    Console.WriteLine("{0}PENELUSURAN KEDUA", vbNewLine)
    Console.Write("Hasil query kedua{0}: ", vbTab)
    For Each i As Integer In hasil    
      Console.Write(i & " ")
    Next
    
    'menampilkan jumlah elemen
    'tidak akan mengeksekusi QUERY 2
    Console.WriteLine("{0}Jumlah elemen{1}{2}: {3}", _
      vbNewLine, vbTab, vbTab, count)
    
    Console.ReadLine()
  End Sub
End Module
