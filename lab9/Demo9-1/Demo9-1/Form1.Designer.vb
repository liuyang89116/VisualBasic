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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.colorBtn = New System.Windows.Forms.Button()
        Me.fontBtn = New System.Windows.Forms.Button()
        Me.imgBtn = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 203)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(276, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 78)
        Me.TextBox1.TabIndex = 1
        '
        'colorBtn
        '
        Me.colorBtn.Location = New System.Drawing.Point(264, 185)
        Me.colorBtn.Name = "colorBtn"
        Me.colorBtn.Size = New System.Drawing.Size(75, 23)
        Me.colorBtn.TabIndex = 2
        Me.colorBtn.Text = "Color"
        Me.colorBtn.UseVisualStyleBackColor = True
        '
        'fontBtn
        '
        Me.fontBtn.Location = New System.Drawing.Point(376, 185)
        Me.fontBtn.Name = "fontBtn"
        Me.fontBtn.Size = New System.Drawing.Size(75, 23)
        Me.fontBtn.TabIndex = 3
        Me.fontBtn.Text = "Font"
        Me.fontBtn.UseVisualStyleBackColor = True
        '
        'imgBtn
        '
        Me.imgBtn.Location = New System.Drawing.Point(483, 185)
        Me.imgBtn.Name = "imgBtn"
        Me.imgBtn.Size = New System.Drawing.Size(75, 23)
        Me.imgBtn.TabIndex = 4
        Me.imgBtn.Text = "Image"
        Me.imgBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 279)
        Me.Controls.Add(Me.imgBtn)
        Me.Controls.Add(Me.fontBtn)
        Me.Controls.Add(Me.colorBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents colorBtn As Button
    Friend WithEvents fontBtn As Button
    Friend WithEvents imgBtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
