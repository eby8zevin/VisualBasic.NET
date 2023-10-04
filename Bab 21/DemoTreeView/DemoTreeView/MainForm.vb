Public Class MainForm

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'membuat dan menampilkan node ke dalam TreeView
    TreeView1.BeginUpdate()
    For i As Integer = 0 To 2
      TreeView1.Nodes.Add((i + 1).ToString(),
                      "Parent Node #" & (i + 1).ToString())
      For j As Integer = 0 To 4
        Dim s As String = (i + 1).ToString() _
          & "-" & (j + 1).ToString()
        TreeView1.Nodes(i).Nodes.Add(s, _
          "Child Node " & s)
      Next
    Next
    TreeView1.EndUpdate()
  End Sub

  Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
    Dim node As TreeNode = TreeView1.SelectedNode
    Dim keyvalue As String = "Node.Name: " & node.Name &
                    vbNewLine & "Node.Text: " & node.Text
    MessageBox.Show(keyvalue)
  End Sub
End Class
