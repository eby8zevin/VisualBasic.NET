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
    Me.rbStandar = New System.Windows.Forms.RadioButton()
    Me.rbMerah = New System.Windows.Forms.RadioButton()
    Me.rbHijau = New System.Windows.Forms.RadioButton()
    Me.rbBiru = New System.Windows.Forms.RadioButton()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(35, 44)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(65, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Warna form:"
    '
    'rbStandar
    '
    Me.rbStandar.AutoSize = True
    Me.rbStandar.Checked = True
    Me.rbStandar.Location = New System.Drawing.Point(39, 74)
    Me.rbStandar.Name = "rbStandar"
    Me.rbStandar.Size = New System.Drawing.Size(95, 17)
    Me.rbStandar.TabIndex = 1
    Me.rbStandar.TabStop = True
    Me.rbStandar.Text = "Warna standar"
    Me.rbStandar.UseVisualStyleBackColor = True
    '
    'rbMerah
    '
    Me.rbMerah.AutoSize = True
    Me.rbMerah.Location = New System.Drawing.Point(39, 97)
    Me.rbMerah.Name = "rbMerah"
    Me.rbMerah.Size = New System.Drawing.Size(55, 17)
    Me.rbMerah.TabIndex = 2
    Me.rbMerah.Text = "Merah"
    Me.rbMerah.UseVisualStyleBackColor = True
    '
    'rbHijau
    '
    Me.rbHijau.AutoSize = True
    Me.rbHijau.Location = New System.Drawing.Point(38, 120)
    Me.rbHijau.Name = "rbHijau"
    Me.rbHijau.Size = New System.Drawing.Size(49, 17)
    Me.rbHijau.TabIndex = 3
    Me.rbHijau.Text = "Hijau"
    Me.rbHijau.UseVisualStyleBackColor = True
    '
    'rbBiru
    '
    Me.rbBiru.AutoSize = True
    Me.rbBiru.Location = New System.Drawing.Point(38, 143)
    Me.rbBiru.Name = "rbBiru"
    Me.rbBiru.Size = New System.Drawing.Size(43, 17)
    Me.rbBiru.TabIndex = 4
    Me.rbBiru.Text = "Biru"
    Me.rbBiru.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 221)
    Me.Controls.Add(Me.rbBiru)
    Me.Controls.Add(Me.rbHijau)
    Me.Controls.Add(Me.rbMerah)
    Me.Controls.Add(Me.rbStandar)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo RadioButton"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents rbStandar As System.Windows.Forms.RadioButton
  Friend WithEvents rbMerah As System.Windows.Forms.RadioButton
  Friend WithEvents rbHijau As System.Windows.Forms.RadioButton
  Friend WithEvents rbBiru As System.Windows.Forms.RadioButton

End Class
