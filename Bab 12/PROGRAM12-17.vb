Module Program  
  Sub Main()    
  	
    Dim kamus As String() = {"satu=one", _
                      "dua=two", _
                      "tiga=three", _
                      "empat=four", _
                      "lima=five", _
                      "enam=six", _
                      "tujuh=seven", _
                      "delapan=eight", _
                      "sembilan=nine", _
                      "sepuluh=ten"}
    
    Dim kata As String
    Dim indonesia As String = ""
    Dim ketemu As Boolean = false
    
    'string yang akan dicari
    kata = "nine"
        
    'mencari string
    For Each s As String In kamus
      If s.EndsWith(kata) Then
        Dim posisi As Integer = s.IndexOf("="c)
        indonesia = s.Substring(0, posisi)
        ketemu = True
        Exit For
      End If
    Next
    
    if ketemu Then
      Console.WriteLine("Bahasa Indonesia '{0}': {1}", _
                       kata, indonesia)
    Else
      Console.WriteLine("Kata yang dicari " _
                        & "tidak ditemukan dalam kamus")      
    End If
    
    Console.ReadLine()
  End Sub
End Module
