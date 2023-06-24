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
    Me.txtItem = New System.Windows.Forms.TextBox()
    Me.lbKiri = New System.Windows.Forms.ListBox()
    Me.lbKanan = New System.Windows.Forms.ListBox()
    Me.btnTambah = New System.Windows.Forms.Button()
    Me.btnPindahKeKanan = New System.Windows.Forms.Button()
    Me.btnPindahSemuaKeKanan = New System.Windows.Forms.Button()
    Me.btnPindahKeKiri = New System.Windows.Forms.Button()
    Me.btnPindahSemuaKeKiri = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(29, 27)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Elemen baru"
    '
    'txtItem
    '
    Me.txtItem.Location = New System.Drawing.Point(32, 46)
    Me.txtItem.Name = "txtItem"
    Me.txtItem.Size = New System.Drawing.Size(175, 20)
    Me.txtItem.TabIndex = 1
    '
    'lbKiri
    '
    Me.lbKiri.FormattingEnabled = True
    Me.lbKiri.Location = New System.Drawing.Point(32, 74)
    Me.lbKiri.Name = "lbKiri"
    Me.lbKiri.Size = New System.Drawing.Size(132, 199)
    Me.lbKiri.TabIndex = 2
    '
    'lbKanan
    '
    Me.lbKanan.FormattingEnabled = True
    Me.lbKanan.Location = New System.Drawing.Point(226, 74)
    Me.lbKanan.Name = "lbKanan"
    Me.lbKanan.Size = New System.Drawing.Size(132, 199)
    Me.lbKanan.TabIndex = 3
    '
    'btnTambah
    '
    Me.btnTambah.Location = New System.Drawing.Point(211, 44)
    Me.btnTambah.Name = "btnTambah"
    Me.btnTambah.Size = New System.Drawing.Size(85, 23)
    Me.btnTambah.TabIndex = 4
    Me.btnTambah.Text = "Tambah"
    Me.btnTambah.UseVisualStyleBackColor = True
    '
    'btnPindahKeKanan
    '
    Me.btnPindahKeKanan.Location = New System.Drawing.Point(172, 93)
    Me.btnPindahKeKanan.Name = "btnPindahKeKanan"
    Me.btnPindahKeKanan.Size = New System.Drawing.Size(47, 22)
    Me.btnPindahKeKanan.TabIndex = 5
    Me.btnPindahKeKanan.Text = ">"
    Me.btnPindahKeKanan.UseVisualStyleBackColor = True
    '
    'btnPindahSemuaKeKanan
    '
    Me.btnPindahSemuaKeKanan.Location = New System.Drawing.Point(172, 121)
    Me.btnPindahSemuaKeKanan.Name = "btnPindahSemuaKeKanan"
    Me.btnPindahSemuaKeKanan.Size = New System.Drawing.Size(47, 22)
    Me.btnPindahSemuaKeKanan.TabIndex = 6
    Me.btnPindahSemuaKeKanan.Text = ">>"
    Me.btnPindahSemuaKeKanan.UseVisualStyleBackColor = True
    '
    'btnPindahKeKiri
    '
    Me.btnPindahKeKiri.Location = New System.Drawing.Point(172, 149)
    Me.btnPindahKeKiri.Name = "btnPindahKeKiri"
    Me.btnPindahKeKiri.Size = New System.Drawing.Size(47, 22)
    Me.btnPindahKeKiri.TabIndex = 7
    Me.btnPindahKeKiri.Text = "<"
    Me.btnPindahKeKiri.UseVisualStyleBackColor = True
    '
    'btnPindahSemuaKeKiri
    '
    Me.btnPindahSemuaKeKiri.Location = New System.Drawing.Point(172, 177)
    Me.btnPindahSemuaKeKiri.Name = "btnPindahSemuaKeKiri"
    Me.btnPindahSemuaKeKiri.Size = New System.Drawing.Size(47, 22)
    Me.btnPindahSemuaKeKiri.TabIndex = 8
    Me.btnPindahSemuaKeKiri.Text = "<<"
    Me.btnPindahSemuaKeKiri.UseVisualStyleBackColor = True
    '
    'MainForm
    '
    Me.AcceptButton = Me.btnTambah
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(436, 335)
    Me.Controls.Add(Me.btnPindahSemuaKeKiri)
    Me.Controls.Add(Me.btnPindahKeKiri)
    Me.Controls.Add(Me.btnPindahSemuaKeKanan)
    Me.Controls.Add(Me.btnPindahKeKanan)
    Me.Controls.Add(Me.btnTambah)
    Me.Controls.Add(Me.lbKanan)
    Me.Controls.Add(Me.lbKiri)
    Me.Controls.Add(Me.txtItem)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainForm"
    Me.Text = "Demo ListBox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtItem As System.Windows.Forms.TextBox
  Friend WithEvents lbKiri As System.Windows.Forms.ListBox
  Friend WithEvents lbKanan As System.Windows.Forms.ListBox
  Friend WithEvents btnTambah As System.Windows.Forms.Button
  Friend WithEvents btnPindahKeKanan As System.Windows.Forms.Button
  Friend WithEvents btnPindahSemuaKeKanan As System.Windows.Forms.Button
  Friend WithEvents btnPindahKeKiri As System.Windows.Forms.Button
  Friend WithEvents btnPindahSemuaKeKiri As System.Windows.Forms.Button

End Class
