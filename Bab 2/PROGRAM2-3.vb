Module Program
  Sub Main()
    'mendeklarasikan variabel tanpa tipe    
    Dim a=10, b=4.95, c="B"c, d=4.95F, e="B"
    'variabel f belum diinisialisasi
    Dim f
    
    'mengisi nilai ke dalam variabel f
    f = 777
    
    'menampilkan nilai
    Console.WriteLine("Nilai variabel:")
    Console.WriteLine("a = {0}", a)
    Console.WriteLine("b = {0}", b)
    Console.WriteLine("c = {0}", c)
    Console.WriteLine("d = {0}", d)
    Console.WriteLine("e = {0}", e)
    Console.WriteLine("f = {0}", f)
    Console.WriteLine() 'membuat baris baru
    
    Console.WriteLine("Tipe variabel:")
    Console.WriteLine("Tipe a = {0}", a.GetType())
    Console.WriteLine("Tipe b = {0}", b.GetType())
    Console.WriteLine("Tipe c = {0}", c.GetType())
    Console.WriteLine("Tipe d = {0}", d.GetType())
    Console.WriteLine("Tipe e = {0}", e.GetType())
    Console.WriteLine("Tipe f = {0}", f.GetType())
    
    Console.ReadLine()
  End Sub
End Module
