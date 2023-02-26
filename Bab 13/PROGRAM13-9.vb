'untuk menggunakan StringBuilder
Imports System.Text

'mendeklarasikan tipe delegasi
Delegate Sub BalikDanCetakString( _
  ByVal sb As StringBuilder)

Module Program  
  
  Sub Main()    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As BalikDanCetakString
    
    'membuat objek dari kelas StringBuilder
    Dim sb1 As StringBuilder = _
      New StringBuilder("TFOSORCIM")    
    Dim sb2 As StringBuilder = _
      New StringBuilder("TEN. cisaB lausiV")
    
    'membuat objek delegasi
    'untuk menunjuk ke metode BalikDanCetakString()
    objDel = Sub (ByVal sb As StringBuilder)
               Dim temp As Char() = New Char(sb.Length-1) {}
               Dim j As Integer = 0
               For i = sb.Length-1 To 0 Step -1
                 temp(j) = sb(i)
                 j += 1
               Next
               sb.Clear()
               sb.Append(New String(temp))
               Console.WriteLine(sb.ToString())
             End Sub
           
    'memanggil metode yang ditunjuk
    'oleh objek delegasi objDel dengan melewatkan
    'sb1 sebagai parameternya
    Console.WriteLine("Mengeksekusi objDel: ")
    objDel(sb1)
    
    'memanggil metode yang ditunjuk
    'oleh objek delegasi objDel dengan melewatkan
    'sb2 sebagai parameternya
    Console.WriteLine("{0}Mengeksekusi kembali objDel: ", _
      vbNewLine)
    objDel(sb2)
        
    Console.ReadLine()
  End Sub
End Module
