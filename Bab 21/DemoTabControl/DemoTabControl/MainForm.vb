Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnBack.Enabled = False
    'tabControl1.SelectedTab = tabPage1
    TabControl1.SelectedIndex = 0
  End Sub

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    If TabControl1.SelectedIndex > 0 Then
      If TabControl1.SelectedIndex = 1 Then
        btnBack.Enabled = False
      End If
      TabControl1.SelectedIndex -= 1
      If Not btnNext.Enabled Then btnNext.Enabled = True
    End If
  End Sub

  Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    If TabControl1.SelectedIndex < _
       TabControl1.TabPages.Count Then
      If TabControl1.SelectedIndex = _
         TabControl1.TabPages.Count - 2 Then
        btnNext.Enabled = False
      End If
      TabControl1.SelectedIndex += 1
      If Not btnBack.Enabled Then btnBack.Enabled = True
    End If
  End Sub

  Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
    Dim index As Integer = TabControl1.SelectedIndex
    If index = 0 Then
      btnBack.Enabled = False
      btnNext.Enabled = True
    ElseIf index = TabControl1.TabPages.Count - 1 Then
      btnBack.Enabled = True
      btnNext.Enabled = False
    Else
      btnBack.Enabled = True
      btnNext.Enabled = True
    End If
  End Sub
End Class
