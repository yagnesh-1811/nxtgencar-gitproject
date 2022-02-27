<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicleslist
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 75)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 441)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Of Vehicles Available for Renting"
        '
        'Button1
        '
        Me.Button1.Image = Global.CarRental.My.Resources.Resources.close321
        Me.Button1.Location = New System.Drawing.Point(12, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 68)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Image = Global.CarRental.My.Resources.Resources.back
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button22.Location = New System.Drawing.Point(112, 4)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(82, 65)
        Me.Button22.TabIndex = 14
        Me.Button22.Text = "Back"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button22.UseVisualStyleBackColor = True
        '
        'vehicleslist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 528)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "vehicleslist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "vehicleslist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
End Class
