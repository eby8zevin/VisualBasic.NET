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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lbGanjil = New System.Windows.Forms.ListBox()
    Me.lbGenap = New System.Windows.Forms.ListBox()
    Me.Progress = New System.Windows.Forms.ProgressBar()
    Me.btnMulai = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(22, 26)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(75, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Bilangan ganjil"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(222, 26)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(81, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Bilangan genap"
    '
    'lbGanjil
    '
    Me.lbGanjil.FormattingEnabled = True
    Me.lbGanjil.Location = New System.Drawing.Point(27, 48)
    Me.lbGanjil.Name = "lbGanjil"
    Me.lbGanjil.Size = New System.Drawing.Size(170, 199)
    Me.lbGanjil.TabIndex = 2
    '
    'lbGenap
    '
    Me.lbGenap.FormattingEnabled = True
    Me.lbGenap.Location = New System.Drawing.Point(225, 48)
    Me.lbGenap.Name = "lbGenap"
    Me.lbGenap.Size = New System.Drawing.Size(170, 199)
    Me.lbGenap.TabIndex = 3
    '
    'Progress
    '
    Me.Progress.Location = New System.Drawing.Point(27, 258)
    Me.Progress.Name = "Progress"
    Me.Progress.Size = New System.Drawing.Size(368, 23)
    Me.Progress.TabIndex = 4
    '
    'btnMulai
    '
    Me.btnMulai.Location = New System.Drawing.Point(161, 299)
    Me.btnMulai.Name = "btnMulai"
    Me.btnMulai.Size = New System.Drawing.Size(103, 23)
    Me.btnMulai.TabIndex = 5
    Me.btnMulai.Text = "Mulai"
    Me.btnMulai.UseVisualStyleBackColor = True
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(425, 346)
    Me.Controls.Add(Me.btnMulai)
    Me.Controls.Add(Me.Progress)
    Me.Controls.Add(Me.lbGenap)
    Me.Controls.Add(Me.lbGanjil)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainForm"
    Me.Text = "Demo ProgressBar"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lbGanjil As System.Windows.Forms.ListBox
  Friend WithEvents lbGenap As System.Windows.Forms.ListBox
  Friend WithEvents Progress As System.Windows.Forms.ProgressBar
  Friend WithEvents btnMulai As System.Windows.Forms.Button

End Class
