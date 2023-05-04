<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.cbxOlahraga = New System.Windows.Forms.CheckBox()
    Me.cbxMembaca = New System.Windows.Forms.CheckBox()
    Me.cbxTamasya = New System.Windows.Forms.CheckBox()
    Me.cbxLain = New System.Windows.Forms.CheckBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(35, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(60, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Hobi Anda:"
    '
    'cbxOlahraga
    '
    Me.cbxOlahraga.AutoSize = True
    Me.cbxOlahraga.Location = New System.Drawing.Point(39, 64)
    Me.cbxOlahraga.Name = "cbxOlahraga"
    Me.cbxOlahraga.Size = New System.Drawing.Size(69, 17)
    Me.cbxOlahraga.TabIndex = 1
    Me.cbxOlahraga.Text = "Olahraga"
    Me.cbxOlahraga.UseVisualStyleBackColor = True
    '
    'cbxMembaca
    '
    Me.cbxMembaca.AutoSize = True
    Me.cbxMembaca.Location = New System.Drawing.Point(39, 90)
    Me.cbxMembaca.Name = "cbxMembaca"
    Me.cbxMembaca.Size = New System.Drawing.Size(73, 17)
    Me.cbxMembaca.TabIndex = 2
    Me.cbxMembaca.Text = "Membaca"
    Me.cbxMembaca.UseVisualStyleBackColor = True
    '
    'cbxTamasya
    '
    Me.cbxTamasya.AutoSize = True
    Me.cbxTamasya.Location = New System.Drawing.Point(39, 114)
    Me.cbxTamasya.Name = "cbxTamasya"
    Me.cbxTamasya.Size = New System.Drawing.Size(69, 17)
    Me.cbxTamasya.TabIndex = 3
    Me.cbxTamasya.Text = "Tamasya"
    Me.cbxTamasya.UseVisualStyleBackColor = True
    '
    'cbxLain
    '
    Me.cbxLain.AutoSize = True
    Me.cbxLain.Location = New System.Drawing.Point(39, 137)
    Me.cbxLain.Name = "cbxLain"
    Me.cbxLain.Size = New System.Drawing.Size(65, 17)
    Me.cbxLain.TabIndex = 4
    Me.cbxLain.Text = "Lain-lain"
    Me.cbxLain.UseVisualStyleBackColor = True
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(159, 185)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 27)
    Me.btnOK.TabIndex = 5
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(261, 237)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.cbxLain)
    Me.Controls.Add(Me.cbxTamasya)
    Me.Controls.Add(Me.cbxMembaca)
    Me.Controls.Add(Me.cbxOlahraga)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo CheckBox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbxOlahraga As System.Windows.Forms.CheckBox
  Friend WithEvents cbxMembaca As System.Windows.Forms.CheckBox
  Friend WithEvents cbxTamasya As System.Windows.Forms.CheckBox
  Friend WithEvents cbxLain As System.Windows.Forms.CheckBox
  Friend WithEvents btnOK As System.Windows.Forms.Button

End Class
