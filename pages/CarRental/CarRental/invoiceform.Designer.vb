<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceform
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcompletion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbllicense = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsurname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblinvoicedate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblbillnum = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblstyle = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblplateno = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbldfare = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblwfare = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblmfare = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Bill Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Starting Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Completion Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(364, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(364, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Image = Global.CarRental.My.Resources.Resources.edit32
        Me.Button2.Location = New System.Drawing.Point(723, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 79)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.CarRental.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(612, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 79)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Image = Global.CarRental.My.Resources.Resources.zoom_48_hot
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button16.Location = New System.Drawing.Point(112, 15)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(89, 76)
        Me.Button16.TabIndex = 11
        Me.Button16.Text = "Search"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Image = Global.CarRental.My.Resources.Resources.close321
        Me.Button12.Location = New System.Drawing.Point(12, 12)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 76)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "Exit"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblcompletion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbllicense)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblsurname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblinvoicedate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblbillnum)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 197)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing Information"
        '
        'lblcompletion
        '
        Me.lblcompletion.AutoSize = True
        Me.lblcompletion.Location = New System.Drawing.Point(150, 166)
        Me.lblcompletion.Name = "lblcompletion"
        Me.lblcompletion.Size = New System.Drawing.Size(19, 14)
        Me.lblcompletion.TabIndex = 23
        Me.lblcompletion.Text = "..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Completion Date"
        '
        'lbllicense
        '
        Me.lbllicense.AutoSize = True
        Me.lbllicense.Location = New System.Drawing.Point(126, 134)
        Me.lbllicense.Name = "lbllicense"
        Me.lbllicense.Size = New System.Drawing.Size(19, 14)
        Me.lbllicense.TabIndex = 9
        Me.lbllicense.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "License No."
        '
        'lblsurname
        '
        Me.lblsurname.AutoSize = True
        Me.lblsurname.Location = New System.Drawing.Point(126, 109)
        Me.lblsurname.Name = "lblsurname"
        Me.lblsurname.Size = New System.Drawing.Size(19, 14)
        Me.lblsurname.TabIndex = 7
        Me.lblsurname.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Surname:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(126, 82)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(19, 14)
        Me.lblname.TabIndex = 5
        Me.lblname.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cust. Name:"
        '
        'lblinvoicedate
        '
        Me.lblinvoicedate.AutoSize = True
        Me.lblinvoicedate.Location = New System.Drawing.Point(126, 55)
        Me.lblinvoicedate.Name = "lblinvoicedate"
        Me.lblinvoicedate.Size = New System.Drawing.Size(19, 14)
        Me.lblinvoicedate.TabIndex = 3
        Me.lblinvoicedate.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Invoice Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Bill No."
        '
        'lblbillnum
        '
        Me.lblbillnum.AutoSize = True
        Me.lblbillnum.Location = New System.Drawing.Point(126, 27)
        Me.lblbillnum.Name = "lblbillnum"
        Me.lblbillnum.Size = New System.Drawing.Size(19, 14)
        Me.lblbillnum.TabIndex = 0
        Me.lblbillnum.Text = "..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblmfare)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblwfare)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lbldfare)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblcolor)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblstyle)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblcompany)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblplateno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 284)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vehicle Information"
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.Location = New System.Drawing.Point(126, 122)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(19, 15)
        Me.lblcolor.TabIndex = 7
        Me.lblcolor.Text = "..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Color:"
        '
        'lblstyle
        '
        Me.lblstyle.AutoSize = True
        Me.lblstyle.Location = New System.Drawing.Point(124, 94)
        Me.lblstyle.Name = "lblstyle"
        Me.lblstyle.Size = New System.Drawing.Size(19, 15)
        Me.lblstyle.TabIndex = 5
        Me.lblstyle.Text = "..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Style:"
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Location = New System.Drawing.Point(126, 64)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(19, 15)
        Me.lblcompany.TabIndex = 3
        Me.lblcompany.Text = "..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Company:"
        '
        'lblplateno
        '
        Me.lblplateno.AutoSize = True
        Me.lblplateno.Location = New System.Drawing.Point(126, 37)
        Me.lblplateno.Name = "lblplateno"
        Me.lblplateno.Size = New System.Drawing.Size(19, 15)
        Me.lblplateno.TabIndex = 1
        Me.lblplateno.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Plate No."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 15)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Daily Fare:"
        '
        'lbldfare
        '
        Me.lbldfare.AutoSize = True
        Me.lbldfare.Location = New System.Drawing.Point(129, 150)
        Me.lbldfare.Name = "lbldfare"
        Me.lbldfare.Size = New System.Drawing.Size(19, 15)
        Me.lbldfare.TabIndex = 9
        Me.lbldfare.Text = "..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Weekly Fare:"
        '
        'lblwfare
        '
        Me.lblwfare.AutoSize = True
        Me.lblwfare.Location = New System.Drawing.Point(132, 179)
        Me.lblwfare.Name = "lblwfare"
        Me.lblwfare.Size = New System.Drawing.Size(19, 15)
        Me.lblwfare.TabIndex = 11
        Me.lblwfare.Text = "..."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(36, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 15)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Monthly Fare:"
        '
        'lblmfare
        '
        Me.lblmfare.AutoSize = True
        Me.lblmfare.Location = New System.Drawing.Point(132, 212)
        Me.lblmfare.Name = "lblmfare"
        Me.lblmfare.Size = New System.Drawing.Size(19, 15)
        Me.lblmfare.TabIndex = 13
        Me.lblmfare.Text = "..."
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(251, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 485)
        Me.DataGridView1.TabIndex = 23
        '
        'invoiceform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 597)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button12)
        Me.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "invoiceform"
        Me.Text = "invoiceform"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcompletion As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbllicense As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblsurname As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblinvoicedate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblbillnum As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcolor As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblstyle As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblplateno As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblmfare As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblwfare As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbldfare As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
