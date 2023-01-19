Module Program
  Sub Main()    
    Dim b As Byte = 0
    Dim s As Short = 0
    Dim i As Integer = 0
    Dim l As Long = 0L
    Dim f As Single = 0.0F
    Dim d As Double = 0.0
    Dim c As Char = "A"c
        
    Console.WriteLine("CTS dari Byte: {0}", b.GetType())
    Console.WriteLine("CTS dari Short: {0}", s.GetType())
    Console.WriteLine("CTS dari Integer: {0}", i.GetType())
    Console.WriteLine("CTS dari Long: {0}", l.GetType())
    Console.WriteLine("CTS dari Single: {0}", f.GetType())
    Console.WriteLine("CTS dari Double: {0}", d.GetType())
    Console.WriteLine("CTS dari Char: {0}", c.GetType())    
    
    Console.ReadLine()
  End Sub
End Module
