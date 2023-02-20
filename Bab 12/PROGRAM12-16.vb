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
    Dim inggris As String = ""
    Dim ketemu As Boolean = false
    
    'string yang akan dicari
    kata = "delapan"
        
    'mencari string
    For Each s As String In kamus
      If s.StartsWith(kata) Then
        Dim posisi As Integer = s.IndexOf("="c)
        inggris = s.Substring(posisi+1, _ 
                             s.Length-(posisi+1))
        ketemu = True
        Exit For
      End If
    Next
    
    if ketemu Then
      Console.WriteLine("Bahasa Inggris '{0}': {1}", _
                       kata, inggris)
    Else
      Console.WriteLine("Kata yang dicari " _
                        & "tidak ditemukan dalam kamus")      
    End If
    
    Console.ReadLine()
  End Sub
End Module
