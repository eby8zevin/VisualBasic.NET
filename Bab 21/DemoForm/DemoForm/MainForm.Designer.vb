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
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHello
        '
        Me.txtHello.Location = New System.Drawing.Point(57, 63)
        Me.txtHello.Name = "txtHello"
        Me.txtHello.Size = New System.Drawing.Size(122, 20)
        Me.txtHello.TabIndex = 0
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(89, 100)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.txtHello)
        Me.Name = "MainForm"
        Me.Text = "Demo Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHello As System.Windows.Forms.TextBox
    Friend WithEvents btnHello As System.Windows.Forms.Button

End Class
