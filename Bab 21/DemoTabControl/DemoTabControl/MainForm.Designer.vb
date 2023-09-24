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
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.btnNext = New System.Windows.Forms.Button()
    Me.TabControl1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Location = New System.Drawing.Point(23, 24)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(447, 239)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(439, 213)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "TabPage1"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(439, 213)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "TabPage2"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'TabPage3
    '
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(439, 213)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "TabPage3"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'TabPage4
    '
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(439, 213)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "TabPage4"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'btnBack
    '
    Me.btnBack.Location = New System.Drawing.Point(312, 270)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(75, 23)
    Me.btnBack.TabIndex = 1
    Me.btnBack.Text = "<< Back"
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'btnNext
    '
    Me.btnNext.Location = New System.Drawing.Point(393, 270)
    Me.btnNext.Name = "btnNext"
    Me.btnNext.Size = New System.Drawing.Size(75, 23)
    Me.btnNext.TabIndex = 2
    Me.btnNext.Text = "Next >>"
    Me.btnNext.UseVisualStyleBackColor = True
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(494, 321)
    Me.Controls.Add(Me.btnNext)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "MainForm"
    Me.Text = "Demo TabControl"
    Me.TabControl1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents btnNext As System.Windows.Forms.Button

End Class
