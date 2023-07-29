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
    Me.txtID = New System.Windows.Forms.TextBox()
    Me.txtNama = New System.Windows.Forms.TextBox()
    Me.txtHarga = New System.Windows.Forms.TextBox()
    Me.txtKeterangan = New System.Windows.Forms.TextBox()
    Me.btnTambah = New System.Windows.Forms.Button()
    Me.btnSimpan = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(26, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(55, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "ID Produk"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(26, 76)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Nama Produk"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(26, 121)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(36, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Harga"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(26, 166)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(62, 13)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Keterangan"
    '
    'txtID
    '
    Me.txtID.Location = New System.Drawing.Point(29, 46)
    Me.txtID.Name = "txtID"
    Me.txtID.Size = New System.Drawing.Size(104, 20)
    Me.txtID.TabIndex = 4
    '
    'txtNama
    '
    Me.txtNama.Location = New System.Drawing.Point(29, 92)
    Me.txtNama.Name = "txtNama"
    Me.txtNama.Size = New System.Drawing.Size(276, 20)
    Me.txtNama.TabIndex = 5
    '
    'txtHarga
    '
    Me.txtHarga.Location = New System.Drawing.Point(29, 139)
    Me.txtHarga.Name = "txtHarga"
    Me.txtHarga.Size = New System.Drawing.Size(155, 20)
    Me.txtHarga.TabIndex = 6
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(29, 182)
    Me.txtKeterangan.Multiline = True
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Size = New System.Drawing.Size(373, 68)
    Me.txtKeterangan.TabIndex = 7
    '
    'btnTambah
    '
    Me.btnTambah.Location = New System.Drawing.Point(29, 278)
    Me.btnTambah.Name = "btnTambah"
    Me.btnTambah.Size = New System.Drawing.Size(94, 23)
    Me.btnTambah.TabIndex = 8
    Me.btnTambah.Text = "Data Baru"
    Me.btnTambah.UseVisualStyleBackColor = True
    '
    'btnSimpan
    '
    Me.btnSimpan.Enabled = False
    Me.btnSimpan.Location = New System.Drawing.Point(129, 278)
    Me.btnSimpan.Name = "btnSimpan"
    Me.btnSimpan.Size = New System.Drawing.Size(94, 23)
    Me.btnSimpan.TabIndex = 9
    Me.btnSimpan.Text = "Simpan"
    Me.btnSimpan.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(436, 342)
    Me.Controls.Add(Me.btnSimpan)
    Me.Controls.Add(Me.btnTambah)
    Me.Controls.Add(Me.txtKeterangan)
    Me.Controls.Add(Me.txtHarga)
    Me.Controls.Add(Me.txtNama)
    Me.Controls.Add(Me.txtID)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo Multiline Textbox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtID As System.Windows.Forms.TextBox
  Friend WithEvents txtNama As System.Windows.Forms.TextBox
  Friend WithEvents txtHarga As System.Windows.Forms.TextBox
  Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
  Friend WithEvents btnTambah As System.Windows.Forms.Button
  Friend WithEvents btnSimpan As System.Windows.Forms.Button

End Class
