Module Program  
  Sub Main()    
    'array dari tipe string
    Dim bulan As String() = New String(11) { _
                  "Januari","Februari","Maret", _
                  "April","Mei","Juni", _
                  "Juli","Agustus","September", _
                  "Oktober","November","Desember"}
  	
    'mengambil tanggal saat ini  	
    Dim tanggal As DateTime = DateTime.Today
  	
    'ekstrak bulan dari tanggal
    Dim mm As Integer = tanggal.Month
  	
    'menampilkan tanggal dalam dua format
    Console.WriteLine("Tanggal sekarang: {0}", tanggal)
    Console.WriteLine("Tanggal sekarang: {0} {1} {2}", _
  	tanggal.Day, bulan(mm-1), tanggal.Year)
  	
    Console.ReadLine()
  End Sub
End Module
