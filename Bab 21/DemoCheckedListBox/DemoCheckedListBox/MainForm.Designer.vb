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
    Me.clbBahasa = New System.Windows.Forms.CheckedListBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(30, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(107, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Bahasa pilihan Anda:"
    '
    'clbBahasa
    '
    Me.clbBahasa.CheckOnClick = True
    Me.clbBahasa.FormattingEnabled = True
    Me.clbBahasa.Location = New System.Drawing.Point(33, 49)
    Me.clbBahasa.Name = "clbBahasa"
    Me.clbBahasa.Size = New System.Drawing.Size(184, 199)
    Me.clbBahasa.TabIndex = 1
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(233, 49)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 2
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(328, 275)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.clbBahasa)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Demo CheckedListBox"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents clbBahasa As System.Windows.Forms.CheckedListBox
  Friend WithEvents btnOK As System.Windows.Forms.Button

End Class
