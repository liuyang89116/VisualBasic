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
        Me.firstName = New System.Windows.Forms.Label()
        Me.secondName = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(33, 35)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(66, 13)
        Me.firstName.TabIndex = 0
        Me.firstName.Text = "First Number"
        '
        'secondName
        '
        Me.secondName.AutoSize = True
        Me.secondName.Location = New System.Drawing.Point(36, 86)
        Me.secondName.Name = "secondName"
        Me.secondName.Size = New System.Drawing.Size(75, 13)
        Me.secondName.TabIndex = 1
        Me.secondName.Text = "Second Name"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(36, 143)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(31, 13)
        Me.total.TabIndex = 2
        Me.total.Text = "Total"
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Location = New System.Drawing.Point(167, 35)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(19, 13)
        Me.num1.TabIndex = 3
        Me.num1.Text = "24"
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Location = New System.Drawing.Point(166, 86)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(19, 13)
        Me.num2.TabIndex = 4
        Me.num2.Text = "16"
        '
        'sum
        '
        Me.sum.AutoSize = True
        Me.sum.Location = New System.Drawing.Point(165, 143)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(37, 13)
        Me.sum.TabIndex = 5
        Me.sum.Text = "Result"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.secondName)
        Me.Controls.Add(Me.firstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstName As Label
    Friend WithEvents secondName As Label
    Friend WithEvents total As Label
    Friend WithEvents num1 As Label
    Friend WithEvents num2 As Label
    Friend WithEvents sum As Label
    Friend WithEvents Button1 As Button
End Class
