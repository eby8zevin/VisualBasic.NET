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
    Me.txtBilangan1 = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtBilangan2 = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtHasil = New System.Windows.Forms.TextBox()
    Me.btnTambah = New System.Windows.Forms.Button()
    Me.btnKurang = New System.Windows.Forms.Button()
    Me.btnKali = New System.Windows.Forms.Button()
    Me.btnBagi = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(30, 33)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Bilangan ke-1"
    '
    'txtBilangan1
    '
    Me.txtBilangan1.Location = New System.Drawing.Point(33, 49)
    Me.txtBilangan1.Name = "txtBilangan1"
    Me.txtBilangan1.Size = New System.Drawing.Size(169, 20)
    Me.txtBilangan1.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(30, 84)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Bilangan ke-2"
    '
    'txtBilangan2
    '
    Me.txtBilangan2.Location = New System.Drawing.Point(34, 101)
    Me.txtBilangan2.Name = "txtBilangan2"
    Me.txtBilangan2.Size = New System.Drawing.Size(168, 20)
    Me.txtBilangan2.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(31, 140)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(89, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Hasil perhitungan"
    '
    'txtHasil
    '
    Me.txtHasil.Location = New System.Drawing.Point(35, 157)
    Me.txtHasil.Name = "txtHasil"
    Me.txtHasil.Size = New System.Drawing.Size(167, 20)
    Me.txtHasil.TabIndex = 5
    '
    'btnTambah
    '
    Me.btnTambah.Location = New System.Drawing.Point(240, 34)
    Me.btnTambah.Name = "btnTambah"
    Me.btnTambah.Size = New System.Drawing.Size(75, 23)
    Me.btnTambah.TabIndex = 6
    Me.btnTambah.Text = "Tambah"
    Me.btnTambah.UseVisualStyleBackColor = True
    '
    'btnKurang
    '
    Me.btnKurang.Location = New System.Drawing.Point(240, 63)
    Me.btnKurang.Name = "btnKurang"
    Me.btnKurang.Size = New System.Drawing.Size(75, 23)
    Me.btnKurang.TabIndex = 7
    Me.btnKurang.Text = "Kurang"
    Me.btnKurang.UseVisualStyleBackColor = True
    '
    'btnKali
    '
    Me.btnKali.Location = New System.Drawing.Point(240, 92)
    Me.btnKali.Name = "btnKali"
    Me.btnKali.Size = New System.Drawing.Size(75, 23)
    Me.btnKali.TabIndex = 8
    Me.btnKali.Text = "Kali"
    Me.btnKali.UseVisualStyleBackColor = True
    '
    'btnBagi
    '
    Me.btnBagi.Location = New System.Drawing.Point(240, 121)
    Me.btnBagi.Name = "btnBagi"
    Me.btnBagi.Size = New System.Drawing.Size(75, 23)
    Me.btnBagi.TabIndex = 9
    Me.btnBagi.Text = "Bagi"
    Me.btnBagi.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(401, 229)
    Me.Controls.Add(Me.btnBagi)
    Me.Controls.Add(Me.btnKali)
    Me.Controls.Add(Me.btnKurang)
    Me.Controls.Add(Me.btnTambah)
    Me.Controls.Add(Me.txtHasil)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtBilangan2)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtBilangan1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo Button dan TextBox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtBilangan1 As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtBilangan2 As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtHasil As System.Windows.Forms.TextBox
  Friend WithEvents btnTambah As System.Windows.Forms.Button
  Friend WithEvents btnKurang As System.Windows.Forms.Button
  Friend WithEvents btnKali As System.Windows.Forms.Button
  Friend WithEvents btnBagi As System.Windows.Forms.Button

End Class
