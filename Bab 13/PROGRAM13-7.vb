'untuk menggunakan StringBuilder
Imports System.Text

'mendeklarasikan tipe delegasi
Delegate Sub OperasiString( _
  ByVal sb As StringBuilder)

Module Program 
  
  'metode untuk membalik string
  Sub BalikString(ByVal sb As StringBuilder)
    Dim temp As Char() = New Char(sb.Length-1) {}
    Dim j As Integer = 0
    For i = sb.Length-1 To 0 Step -1
      temp(j) = sb(i)
      j += 1
    Next
    sb.Clear()
    sb.Append(New String(temp))
  End Sub
  
  'metode untuk mencetak string
  Sub CetakString(ByVal sb As StringBuilder)
    Console.WriteLine(sb.ToString())
  End Sub
  
  Sub Main()    
    'mendeklarasikan referensi ke tipe delegasi
    Dim objDel1, objDel2, objDel3 As OperasiString
    
    'membuat objek dari kelas StringBuilder
    Dim sb1 As StringBuilder = _
      New StringBuilder("TEN. cisaB lausiV")
    Dim sb2 As StringBuilder = _
      New StringBuilder("TEN. cisaB lausiV")
    
    
    'membuat objek delegasi
    'untuk menunjuk ke metode BalikString()
    objDel1 = AddressOf BalikString
    
    'membuat objek delegasi
    'untuk menunjuk ke metode CetakString()
    objDel2 = AddressOf CetakString
    
    'menggabung objek delegasi
    objDel3 = CType(System.Delegate.Combine( _
                objDel1, objDel2), _
                OperasiString _
              )
        
    'memanggil metode yang ditunjuk
    'oleh objek delegasi objDel3
    Console.WriteLine("Mengeksekusi objDel3 " _
      & "(sebelum objDel1 dipindah):")
    objDel3(sb1)
    
    'menghapus objDel1 dari objDel3
    objDel3 = CType(System.Delegate.Remove( _
                objDel3, objDel1), _
                OperasiString _
              )
    
    Console.WriteLine()
    Console.WriteLine("Mengeksekusi objDel3 " _
      & "(setelah objDel1 dipindah):")
    objDel3(sb2)
    
    Console.ReadLine()
  End Sub
End Module
