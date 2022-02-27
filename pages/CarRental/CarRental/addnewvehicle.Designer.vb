<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addnewvehicle
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlicense = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtclassid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtengine = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdaily = New System.Windows.Forms.TextBox()
        Me.txtweekly = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Model"
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(119, 15)
        Me.txtmodel.Multiline = True
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(176, 34)
        Me.txtmodel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "License No."
        '
        'btnlicense
        '
        Me.btnlicense.Location = New System.Drawing.Point(461, 15)
        Me.btnlicense.Multiline = True
        Me.btnlicense.Name = "btnlicense"
        Me.btnlicense.Size = New System.Drawing.Size(176, 34)
        Me.btnlicense.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Class ID"
        '
        'txtclassid
        '
        Me.txtclassid.Location = New System.Drawing.Point(119, 121)
        Me.txtclassid.Multiline = True
        Me.txtclassid.Name = "txtclassid"
        Me.txtclassid.Size = New System.Drawing.Size(176, 34)
        Me.txtclassid.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Engine Name"
        '
        'txtengine
        '
        Me.txtengine.Location = New System.Drawing.Point(461, 82)
        Me.txtengine.Multiline = True
        Me.txtengine.Name = "txtengine"
        Me.txtengine.Size = New System.Drawing.Size(176, 34)
        Me.txtengine.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Daily Rate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Weekly Rate"
        '
        'txtdaily
        '
        Me.txtdaily.Location = New System.Drawing.Point(119, 268)
        Me.txtdaily.Multiline = True
        Me.txtdaily.Name = "txtdaily"
        Me.txtdaily.Size = New System.Drawing.Size(176, 35)
        Me.txtdaily.TabIndex = 16
        '
        'txtweekly
        '
        Me.txtweekly.Location = New System.Drawing.Point(119, 324)
        Me.txtweekly.Multiline = True
        Me.txtweekly.Name = "txtweekly"
        Me.txtweekly.Size = New System.Drawing.Size(176, 35)
        Me.txtweekly.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 23)
        Me.ComboBox1.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Status:"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(101, 421)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(339, 33)
        Me.ProgressBar1.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(446, 430)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(356, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 15)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Upload Image"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(332, 206)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 177)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btncancel
        '
        Me.btncancel.Image = Global.CarRental.My.Resources.Resources.close32
        Me.btncancel.Location = New System.Drawing.Point(591, 311)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(104, 72)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = Global.CarRental.My.Resources.Resources.save
        Me.btnsave.Location = New System.Drawing.Point(591, 191)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(104, 99)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Quantity"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 206)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 22)
        Me.TextBox1.TabIndex = 28
        '
        'addnewvehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 470)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtweekly)
        Me.Controls.Add(Me.txtdaily)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtengine)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtclassid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnlicense)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "addnewvehicle"
        Me.Text = "addnewvehicle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmodel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnlicense As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtclassid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtengine As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdaily As System.Windows.Forms.TextBox
    Friend WithEvents txtweekly As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
