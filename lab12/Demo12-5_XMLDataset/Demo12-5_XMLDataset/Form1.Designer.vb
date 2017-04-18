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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.readBtn = New System.Windows.Forms.Button()
        Me.writeBtn = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(267, 179)
        Me.DataGridView1.TabIndex = 0
        '
        'readBtn
        '
        Me.readBtn.Location = New System.Drawing.Point(372, 64)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(75, 23)
        Me.readBtn.TabIndex = 1
        Me.readBtn.Text = "Read XML"
        Me.readBtn.UseVisualStyleBackColor = True
        '
        'writeBtn
        '
        Me.writeBtn.Location = New System.Drawing.Point(372, 164)
        Me.writeBtn.Name = "writeBtn"
        Me.writeBtn.Size = New System.Drawing.Size(75, 23)
        Me.writeBtn.TabIndex = 2
        Me.writeBtn.Text = "Write XML"
        Me.writeBtn.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 245)
        Me.Controls.Add(Me.writeBtn)
        Me.Controls.Add(Me.readBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents readBtn As Button
    Friend WithEvents writeBtn As Button
    Friend WithEvents DataSet1 As DataSet
End Class
