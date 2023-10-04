<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.TreeView1 = New System.Windows.Forms.TreeView()
    Me.btnGet = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'TreeView1
    '
    Me.TreeView1.Location = New System.Drawing.Point(12, 12)
    Me.TreeView1.Name = "TreeView1"
    Me.TreeView1.Size = New System.Drawing.Size(216, 285)
    Me.TreeView1.TabIndex = 0
    '
    'btnGet
    '
    Me.btnGet.Location = New System.Drawing.Point(241, 23)
    Me.btnGet.Name = "btnGet"
    Me.btnGet.Size = New System.Drawing.Size(90, 23)
    Me.btnGet.TabIndex = 1
    Me.btnGet.Text = "Get Node"
    Me.btnGet.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(344, 309)
    Me.Controls.Add(Me.btnGet)
    Me.Controls.Add(Me.TreeView1)
    Me.Name = "Form1"
    Me.Text = "Demo TreeView"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
  Friend WithEvents btnGet As System.Windows.Forms.Button

End Class
