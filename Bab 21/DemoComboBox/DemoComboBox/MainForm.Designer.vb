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
    Me.cbJenis = New System.Windows.Forms.ComboBox()
    Me.cbUkuran = New System.Windows.Forms.ComboBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.labelContoh = New System.Windows.Forms.Label()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(28, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(58, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Jenis huruf"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(321, 34)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(69, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Ukuran huruf"
    '
    'cbJenis
    '
    Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbJenis.FormattingEnabled = True
    Me.cbJenis.Location = New System.Drawing.Point(31, 50)
    Me.cbJenis.Name = "cbJenis"
    Me.cbJenis.Size = New System.Drawing.Size(280, 21)
    Me.cbJenis.TabIndex = 2
    '
    'cbUkuran
    '
    Me.cbUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbUkuran.FormattingEnabled = True
    Me.cbUkuran.Location = New System.Drawing.Point(324, 50)
    Me.cbUkuran.Name = "cbUkuran"
    Me.cbUkuran.Size = New System.Drawing.Size(98, 21)
    Me.cbUkuran.TabIndex = 3
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.labelContoh)
    Me.GroupBox1.Location = New System.Drawing.Point(31, 91)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(391, 110)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Contoh teks"
    '
    'labelContoh
    '
    Me.labelContoh.AutoSize = True
    Me.labelContoh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
    Me.labelContoh.Location = New System.Drawing.Point(15, 42)
    Me.labelContoh.Name = "labelContoh"
    Me.labelContoh.Size = New System.Drawing.Size(222, 25)
    Me.labelContoh.TabIndex = 0
    Me.labelContoh.Text = "Ini adalah contoh teks"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(455, 242)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.cbUkuran)
    Me.Controls.Add(Me.cbJenis)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainForm"
    Me.Text = "Demo ComboBox"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cbJenis As System.Windows.Forms.ComboBox
  Friend WithEvents cbUkuran As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents labelContoh As System.Windows.Forms.Label

End Class
