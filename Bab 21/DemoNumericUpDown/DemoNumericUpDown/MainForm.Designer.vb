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
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
    Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtHasil = New System.Windows.Forms.TextBox()
    Me.cbOperasi = New System.Windows.Forms.ComboBox()
    Me.btnHitung = New System.Windows.Forms.Button()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(26, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Bilangan ke-1"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(253, 28)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Bilangan ke-2"
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Location = New System.Drawing.Point(30, 48)
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(87, 20)
    Me.NumericUpDown1.TabIndex = 2
    '
    'NumericUpDown2
    '
    Me.NumericUpDown2.Location = New System.Drawing.Point(256, 48)
    Me.NumericUpDown2.Name = "NumericUpDown2"
    Me.NumericUpDown2.Size = New System.Drawing.Size(87, 20)
    Me.NumericUpDown2.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(26, 93)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(89, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Hasil perhitungan"
    '
    'txtHasil
    '
    Me.txtHasil.Enabled = False
    Me.txtHasil.Location = New System.Drawing.Point(29, 109)
    Me.txtHasil.Name = "txtHasil"
    Me.txtHasil.Size = New System.Drawing.Size(218, 20)
    Me.txtHasil.TabIndex = 5
    '
    'cbOperasi
    '
    Me.cbOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbOperasi.FormattingEnabled = True
    Me.cbOperasi.Location = New System.Drawing.Point(126, 47)
    Me.cbOperasi.Name = "cbOperasi"
    Me.cbOperasi.Size = New System.Drawing.Size(121, 21)
    Me.cbOperasi.TabIndex = 6
    '
    'btnHitung
    '
    Me.btnHitung.Location = New System.Drawing.Point(256, 107)
    Me.btnHitung.Name = "btnHitung"
    Me.btnHitung.Size = New System.Drawing.Size(87, 23)
    Me.btnHitung.TabIndex = 7
    Me.btnHitung.Text = "Hitung"
    Me.btnHitung.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(386, 171)
    Me.Controls.Add(Me.btnHitung)
    Me.Controls.Add(Me.cbOperasi)
    Me.Controls.Add(Me.txtHasil)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.NumericUpDown2)
    Me.Controls.Add(Me.NumericUpDown1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo NumericUpDown"
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtHasil As System.Windows.Forms.TextBox
  Friend WithEvents cbOperasi As System.Windows.Forms.ComboBox
  Friend WithEvents btnHitung As System.Windows.Forms.Button

End Class
