Module Program
  'a bersifat global (dalam lingkup modul)
  Dim a As Integer = 10
  
  Sub Proc1()
    'b bersifat lokal
    'untuk prosedur Proc1()
    Dim b As Integer = 20
    
    Console.WriteLine("Dalam Proc1():")
    Console.WriteLine("a = {0}", a)
    Console.WriteLine("b = {0}", b)
    'Console.WriteLine("c = {0}", c)  'salah
    Console.WriteLine("c tidak dikenal")
  End Sub
  
  Sub Main()
    'c bersifat lokal
    'untuk prosedur Main()
    Dim c As Integer = 30
    
    'memanggil prosedur Proc1()
    Call Proc1()
    
    Console.WriteLine("{0}Dalam Main():", Chr(10))
    Console.WriteLine("a = {0}", a)
    'Console.WriteLine("b = {0}", b) 'salah
    Console.WriteLine("b tidak dikenal")
    Console.WriteLine("c = {0}", c)
    
    Console.ReadLine()
  End Sub
End Module
