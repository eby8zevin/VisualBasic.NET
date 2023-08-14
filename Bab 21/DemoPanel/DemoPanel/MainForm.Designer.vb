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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtURL = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Button1)
    Me.Panel1.Controls.Add(Me.txtURL)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(606, 40)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.WebBrowser1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 40)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(606, 341)
    Me.Panel2.TabIndex = 1
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.ProgressBar1)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel3.Location = New System.Drawing.Point(0, 363)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(606, 18)
    Me.Panel3.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(62, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Alamat web"
    '
    'txtURL
    '
    Me.txtURL.Location = New System.Drawing.Point(83, 12)
    Me.txtURL.Name = "txtURL"
    Me.txtURL.Size = New System.Drawing.Size(341, 20)
    Me.txtURL.TabIndex = 1
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(430, 10)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(44, 23)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "Go"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'WebBrowser1
    '
    Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
    Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
    Me.WebBrowser1.Name = "WebBrowser1"
    Me.WebBrowser1.Size = New System.Drawing.Size(606, 341)
    Me.WebBrowser1.TabIndex = 0
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(606, 18)
    Me.ProgressBar1.TabIndex = 0
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(606, 381)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "Form1"
    Me.Text = "Demo Panel"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents txtURL As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
