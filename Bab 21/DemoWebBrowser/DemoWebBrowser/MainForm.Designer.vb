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
    Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
    Me.btnBack = New System.Windows.Forms.Button()
    Me.btnForward = New System.Windows.Forms.Button()
    Me.txtURL = New System.Windows.Forms.TextBox()
    Me.btnGo = New System.Windows.Forms.Button()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'WebBrowser1
    '
    Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.WebBrowser1.Location = New System.Drawing.Point(-1, 46)
    Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
    Me.WebBrowser1.Name = "WebBrowser1"
    Me.WebBrowser1.Size = New System.Drawing.Size(639, 327)
    Me.WebBrowser1.TabIndex = 0
    '
    'btnBack
    '
    Me.btnBack.Location = New System.Drawing.Point(8, 12)
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(42, 23)
    Me.btnBack.TabIndex = 1
    Me.btnBack.Text = "<"
    Me.btnBack.UseVisualStyleBackColor = True
    '
    'btnForward
    '
    Me.btnForward.Location = New System.Drawing.Point(53, 12)
    Me.btnForward.Name = "btnForward"
    Me.btnForward.Size = New System.Drawing.Size(39, 23)
    Me.btnForward.TabIndex = 2
    Me.btnForward.Text = ">"
    Me.btnForward.UseVisualStyleBackColor = True
    '
    'txtURL
    '
    Me.txtURL.Location = New System.Drawing.Point(98, 15)
    Me.txtURL.Name = "txtURL"
    Me.txtURL.Size = New System.Drawing.Size(303, 20)
    Me.txtURL.TabIndex = 3
    '
    'btnGo
    '
    Me.btnGo.Location = New System.Drawing.Point(407, 13)
    Me.btnGo.Name = "btnGo"
    Me.btnGo.Size = New System.Drawing.Size(48, 23)
    Me.btnGo.TabIndex = 4
    Me.btnGo.Text = "Go"
    Me.btnGo.UseVisualStyleBackColor = True
    '
    'btnStop
    '
    Me.btnStop.Location = New System.Drawing.Point(458, 13)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(48, 23)
    Me.btnStop.TabIndex = 5
    Me.btnStop.Text = "Stop"
    Me.btnStop.UseVisualStyleBackColor = True
    '
    'btnRefresh
    '
    Me.btnRefresh.Location = New System.Drawing.Point(510, 13)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
    Me.btnRefresh.TabIndex = 6
    Me.btnRefresh.Text = "Refresh"
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(642, 373)
    Me.Controls.Add(Me.btnRefresh)
    Me.Controls.Add(Me.btnStop)
    Me.Controls.Add(Me.btnGo)
    Me.Controls.Add(Me.txtURL)
    Me.Controls.Add(Me.btnForward)
    Me.Controls.Add(Me.btnBack)
    Me.Controls.Add(Me.WebBrowser1)
    Me.Name = "Form1"
    Me.Text = "Demo WebBrowser"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
  Friend WithEvents btnBack As System.Windows.Forms.Button
  Friend WithEvents btnForward As System.Windows.Forms.Button
  Friend WithEvents txtURL As System.Windows.Forms.TextBox
  Friend WithEvents btnGo As System.Windows.Forms.Button
  Friend WithEvents btnStop As System.Windows.Forms.Button
  Friend WithEvents btnRefresh As System.Windows.Forms.Button

End Class
