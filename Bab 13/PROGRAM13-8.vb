'untuk menggunakan StringBuilder
Imports System.Text

'mendeklarasikan tipe delegasi
Delegate Sub BalikDanCetakString()

Module Program  
  
  Sub Main()    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel As BalikDanCetakString
    
    'membuat objek dari kelas StringBuilder
    Dim sb As StringBuilder = _
      New StringBuilder("TFOSORCIM")    
    
    'membuat objek delegasi
    'untuk menunjuk ke metode BalikDanCetakString()
    objDel = Sub ()
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
    'oleh objek delegasi objDel
    Console.WriteLine("Mengeksekusi objDel: ")
    objDel()
        
    Console.ReadLine()
  End Sub
End Module
