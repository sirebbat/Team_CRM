<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_activity
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.gb_add_activity = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ci_btn_update = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.gb_add_activity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(200, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Created On"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(412, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Employee"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(547, 35)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox3.TabIndex = 12
        '
        'gb_add_activity
        '
        Me.gb_add_activity.Controls.Add(Me.DateTimePicker1)
        Me.gb_add_activity.Controls.Add(Me.Label9)
        Me.gb_add_activity.Controls.Add(Me.Label8)
        Me.gb_add_activity.Controls.Add(Me.Label5)
        Me.gb_add_activity.Controls.Add(Me.ComboBox3)
        Me.gb_add_activity.Controls.Add(Me.RichTextBox1)
        Me.gb_add_activity.Controls.Add(Me.Label7)
        Me.gb_add_activity.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_add_activity.ForeColor = System.Drawing.Color.White
        Me.gb_add_activity.Location = New System.Drawing.Point(13, 13)
        Me.gb_add_activity.Name = "gb_add_activity"
        Me.gb_add_activity.Size = New System.Drawing.Size(708, 326)
        Me.gb_add_activity.TabIndex = 13
        Me.gb_add_activity.TabStop = False
        Me.gb_add_activity.Text = "Add Activity"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(187, 35)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 14
        Me.DateTimePicker1.Value = New Date(2015, 9, 2, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(523, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Characters out of 140"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(29, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Comment"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 174)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(652, 105)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ci_btn_update
        '
        Me.ci_btn_update.BackColor = System.Drawing.Color.LightSlateGray
        Me.ci_btn_update.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ci_btn_update.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ci_btn_update.ForeColor = System.Drawing.Color.White
        Me.ci_btn_update.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_btn_update.Location = New System.Drawing.Point(158, 374)
        Me.ci_btn_update.Name = "ci_btn_update"
        Me.ci_btn_update.Size = New System.Drawing.Size(198, 65)
        Me.ci_btn_update.TabIndex = 14
        Me.ci_btn_update.Text = "Save"
        Me.ci_btn_update.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cancel.Location = New System.Drawing.Point(419, 374)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(198, 65)
        Me.btn_cancel.TabIndex = 15
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'create_activity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(744, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.ci_btn_update)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gb_add_activity)
        Me.Name = "create_activity"
        Me.Text = "Add Activity"
        Me.gb_add_activity.ResumeLayout(False)
        Me.gb_add_activity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents gb_add_activity As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ci_btn_update As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
