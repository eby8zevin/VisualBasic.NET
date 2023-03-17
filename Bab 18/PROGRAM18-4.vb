Imports System.Collections.Generic

Module Program  
  Sub TampilkanKoleksi(koleksi As ISet(Of String), _
                       namaKoleksi As String)
    Console.Write("Isi himpunan {0}: ", namaKoleksi)
    For Each elemen As String In koleksi
      Console.Write("{0} ", elemen)
    Next
    Console.WriteLine()
  End Sub
  
  Sub Main()
    'membuat koleksi bertipe HashSet(Of T),
    'tapi referensi bertipe ISet(Of T).
    'himpunan A
    Dim A As ISet(Of String) = _
      New HashSet(Of String)()
    A.Add("VB")
    A.Add("C++")
    A.Add("Java")
    A.Add("Python")
    
    'himpunan B
    '(semua anggota B adalah anggota A)
    Dim B As ISet(Of String) = _
      New HashSet(Of String)()
    B.Add("VB")
    B.Add("C++")
    
    'menambah elemen baru ke himpunan A
    A.Add("Ruby")
    
    'menampilkan isi himpunan A dan B
    TampilkanKoleksi(A, "A")
    TampilkanKoleksi(B, "B")
    
    'memanggil metode-metode dalam ISet(Of T)
    Console.WriteLine()
    Console.WriteLine("A.IsProperSubsetOf(B) {0}: {1}", _
                      vbTab, A.IsProperSubsetOf(B))
    Console.WriteLine("A.IsProperSupersetOf(B) {0}: {1}", _
                      vbTab, A.IsProperSupersetOf(B))
    Console.WriteLine("A.IsSubsetOf(B) {0}: {1}", _
                      vbTab, A.IsSubsetOf(B))
    Console.WriteLine("A.IsSupersetOf(B) {0}: {1}", _
                      vbTab, A.IsSupersetOf(B))
    Console.WriteLine("A.Overlaps(B) {0}: {1}", _
                      vbTab, A.Overlaps(B))
    Console.WriteLine("A.SetEquals(B) {0}: {1}", _
                      vbTab, A.SetEquals(B))
    
    'memanggil metode ExceptWith()
    A.ExceptWith(B)
    Console.WriteLine()
    Console.WriteLine("Setelah pemanggilan A.ExceptWith(B)")
    TampilkanKoleksi(A, "A")
    
    Console.ReadLine()
  End Sub
End Module
