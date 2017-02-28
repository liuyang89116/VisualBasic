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
        Me.msg = New System.Windows.Forms.Label()
        Me.guess = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'msg
        '
        Me.msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg.Location = New System.Drawing.Point(50, 54)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(433, 55)
        Me.msg.TabIndex = 0
        Me.msg.Text = "Guess a number between 1 to 20"
        '
        'guess
        '
        Me.guess.Location = New System.Drawing.Point(111, 168)
        Me.guess.Name = "guess"
        Me.guess.Size = New System.Drawing.Size(100, 20)
        Me.guess.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 266)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.guess)
        Me.Controls.Add(Me.msg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msg As Label
    Friend WithEvents guess As TextBox
    Friend WithEvents Button1 As Button
End Class
