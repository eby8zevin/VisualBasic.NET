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
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.txtISBN = New System.Windows.Forms.TextBox()
    Me.txtJudul = New System.Windows.Forms.TextBox()
    Me.txtPenulis = New System.Windows.Forms.TextBox()
    Me.btnTambah = New System.Windows.Forms.Button()
    Me.btnHapus = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'ListView1
    '
    Me.ListView1.FullRowSelect = True
    Me.ListView1.Location = New System.Drawing.Point(12, 12)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(499, 149)
    Me.ListView1.TabIndex = 0
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
    '
    'txtISBN
    '
    Me.txtISBN.Location = New System.Drawing.Point(14, 171)
    Me.txtISBN.Name = "txtISBN"
    Me.txtISBN.Size = New System.Drawing.Size(109, 20)
    Me.txtISBN.TabIndex = 1
    '
    'txtJudul
    '
    Me.txtJudul.Location = New System.Drawing.Point(129, 172)
    Me.txtJudul.Name = "txtJudul"
    Me.txtJudul.Size = New System.Drawing.Size(249, 20)
    Me.txtJudul.TabIndex = 2
    '
    'txtPenulis
    '
    Me.txtPenulis.Location = New System.Drawing.Point(384, 172)
    Me.txtPenulis.Name = "txtPenulis"
    Me.txtPenulis.Size = New System.Drawing.Size(127, 20)
    Me.txtPenulis.TabIndex = 3
    '
    'btnTambah
    '
    Me.btnTambah.Location = New System.Drawing.Point(15, 207)
    Me.btnTambah.Name = "btnTambah"
    Me.btnTambah.Size = New System.Drawing.Size(75, 23)
    Me.btnTambah.TabIndex = 4
    Me.btnTambah.Text = "Tambah"
    Me.btnTambah.UseVisualStyleBackColor = True
    '
    'btnHapus
    '
    Me.btnHapus.Location = New System.Drawing.Point(94, 207)
    Me.btnHapus.Name = "btnHapus"
    Me.btnHapus.Size = New System.Drawing.Size(75, 23)
    Me.btnHapus.TabIndex = 5
    Me.btnHapus.Text = "Hapus"
    Me.btnHapus.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(523, 255)
    Me.Controls.Add(Me.btnHapus)
    Me.Controls.Add(Me.btnTambah)
    Me.Controls.Add(Me.txtPenulis)
    Me.Controls.Add(Me.txtJudul)
    Me.Controls.Add(Me.txtISBN)
    Me.Controls.Add(Me.ListView1)
    Me.Name = "Form1"
    Me.Text = "Demo ListView"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents txtISBN As System.Windows.Forms.TextBox
  Friend WithEvents txtJudul As System.Windows.Forms.TextBox
  Friend WithEvents txtPenulis As System.Windows.Forms.TextBox
  Friend WithEvents btnTambah As System.Windows.Forms.Button
  Friend WithEvents btnHapus As System.Windows.Forms.Button

End Class
