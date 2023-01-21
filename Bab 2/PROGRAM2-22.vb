Module Program  
  Sub Main()        
    Dim s As Object
    Dim i As Object
    Dim b As Object
    Dim l As Object
    Dim d As Object
    
    s = Convert.ToString(100)
    i = Convert.ToInt32(3.14)
    b = Convert.ToByte(1)
    l = Convert.ToInt64(123456789)
    d = Convert.ToDateTime("2017-07-07")
    
    Console.Write("Nilai s: {0}", s)
    Console.WriteLine("{0}Tipe s: {1}", Chr(9), s.GetType())
    Console.Write("Nilai i: {0}", i)
    Console.WriteLine("{0}Tipe i: {1}", Chr(9), i.GetType())
    Console.Write("Nilai b: {0}", b)
    Console.WriteLine("{0}Tipe b: {1}", Chr(9), b.GetType())
    Console.Write("Nilai l: {0}", l)
    Console.WriteLine("{0}Tipe l: {1}", Chr(9), l.GetType())
    Console.Write("Nilai d: {0}", d)
    Console.WriteLine("{0}Tipe d: {1}", Chr(9), d.GetType())
    
    Console.ReadLine()
  End Sub
End Module
