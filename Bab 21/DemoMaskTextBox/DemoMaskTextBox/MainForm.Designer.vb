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
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.mtbNIP = New System.Windows.Forms.MaskedTextBox()
    Me.mtbNama = New System.Windows.Forms.MaskedTextBox()
    Me.mtbTglLahir = New System.Windows.Forms.MaskedTextBox()
    Me.mtbJenisKelamin = New System.Windows.Forms.MaskedTextBox()
    Me.mtbTinggiBadan = New System.Windows.Forms.MaskedTextBox()
    Me.mtbNoTelepon = New System.Windows.Forms.MaskedTextBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(31, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(25, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "NIP"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(31, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Nama"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(31, 97)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(51, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Tgl. Lahir"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(31, 132)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(71, 13)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Jenis Kelamin"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(31, 165)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(70, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Tinggi Badan"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(31, 200)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(66, 13)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "No. Telepon"
    '
    'mtbNIP
    '
    Me.mtbNIP.Location = New System.Drawing.Point(143, 29)
    Me.mtbNIP.Name = "mtbNIP"
    Me.mtbNIP.Size = New System.Drawing.Size(100, 20)
    Me.mtbNIP.TabIndex = 6
    '
    'mtbNama
    '
    Me.mtbNama.Location = New System.Drawing.Point(143, 64)
    Me.mtbNama.Name = "mtbNama"
    Me.mtbNama.Size = New System.Drawing.Size(264, 20)
    Me.mtbNama.TabIndex = 7
    '
    'mtbTglLahir
    '
    Me.mtbTglLahir.Location = New System.Drawing.Point(143, 97)
    Me.mtbTglLahir.Name = "mtbTglLahir"
    Me.mtbTglLahir.Size = New System.Drawing.Size(135, 20)
    Me.mtbTglLahir.TabIndex = 8
    '
    'mtbJenisKelamin
    '
    Me.mtbJenisKelamin.Location = New System.Drawing.Point(143, 132)
    Me.mtbJenisKelamin.Name = "mtbJenisKelamin"
    Me.mtbJenisKelamin.Size = New System.Drawing.Size(31, 20)
    Me.mtbJenisKelamin.TabIndex = 9
    '
    'mtbTinggiBadan
    '
    Me.mtbTinggiBadan.Location = New System.Drawing.Point(143, 165)
    Me.mtbTinggiBadan.Name = "mtbTinggiBadan"
    Me.mtbTinggiBadan.Size = New System.Drawing.Size(49, 20)
    Me.mtbTinggiBadan.TabIndex = 10
    '
    'mtbNoTelepon
    '
    Me.mtbNoTelepon.Location = New System.Drawing.Point(143, 200)
    Me.mtbNoTelepon.Name = "mtbNoTelepon"
    Me.mtbNoTelepon.Size = New System.Drawing.Size(170, 20)
    Me.mtbNoTelepon.TabIndex = 11
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(323, 255)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(84, 23)
    Me.btnOK.TabIndex = 12
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(452, 305)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.mtbNoTelepon)
    Me.Controls.Add(Me.mtbTinggiBadan)
    Me.Controls.Add(Me.mtbJenisKelamin)
    Me.Controls.Add(Me.mtbTglLahir)
    Me.Controls.Add(Me.mtbNama)
    Me.Controls.Add(Me.mtbNIP)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo MaskedTextBox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents mtbNIP As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbNama As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbTglLahir As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbJenisKelamin As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbTinggiBadan As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbNoTelepon As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnOK As System.Windows.Forms.Button

End Class
