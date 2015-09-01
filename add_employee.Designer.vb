<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_employee
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
        Me.add_emp_btn_cancel = New System.Windows.Forms.Button()
        Me.add_emp_btn_save = New System.Windows.Forms.Button()
        Me.add_emp_txt_fname = New System.Windows.Forms.TextBox()
        Me.add_emp_txt_lname = New System.Windows.Forms.TextBox()
        Me.add_emp_txt_email = New System.Windows.Forms.TextBox()
        Me.add_emp_lbl_fname = New System.Windows.Forms.Label()
        Me.add_emp_lbl_lname = New System.Windows.Forms.Label()
        Me.add_emp_lbl_email = New System.Windows.Forms.Label()
        Me.add_emp_lbl_phone = New System.Windows.Forms.Label()
        Me.add_emp_txt_phone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'add_emp_btn_cancel
        '
        Me.add_emp_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.add_emp_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.add_emp_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.add_emp_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.add_emp_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_emp_btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.add_emp_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.add_emp_btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.add_emp_btn_cancel.Location = New System.Drawing.Point(372, 163)
        Me.add_emp_btn_cancel.Name = "add_emp_btn_cancel"
        Me.add_emp_btn_cancel.Size = New System.Drawing.Size(198, 65)
        Me.add_emp_btn_cancel.TabIndex = 7
        Me.add_emp_btn_cancel.Text = "Cancel"
        Me.add_emp_btn_cancel.UseVisualStyleBackColor = False
        '
        'add_emp_btn_save
        '
        Me.add_emp_btn_save.BackColor = System.Drawing.Color.LightSlateGray
        Me.add_emp_btn_save.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.add_emp_btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.add_emp_btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.add_emp_btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_emp_btn_save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.add_emp_btn_save.ForeColor = System.Drawing.Color.White
        Me.add_emp_btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.add_emp_btn_save.Location = New System.Drawing.Point(122, 163)
        Me.add_emp_btn_save.Name = "add_emp_btn_save"
        Me.add_emp_btn_save.Size = New System.Drawing.Size(198, 65)
        Me.add_emp_btn_save.TabIndex = 8
        Me.add_emp_btn_save.Text = "Save"
        Me.add_emp_btn_save.UseVisualStyleBackColor = False
        '
        'add_emp_txt_fname
        '
        Me.add_emp_txt_fname.Location = New System.Drawing.Point(113, 13)
        Me.add_emp_txt_fname.Name = "add_emp_txt_fname"
        Me.add_emp_txt_fname.Size = New System.Drawing.Size(100, 20)
        Me.add_emp_txt_fname.TabIndex = 9
        '
        'add_emp_txt_lname
        '
        Me.add_emp_txt_lname.Location = New System.Drawing.Point(113, 53)
        Me.add_emp_txt_lname.Name = "add_emp_txt_lname"
        Me.add_emp_txt_lname.Size = New System.Drawing.Size(100, 20)
        Me.add_emp_txt_lname.TabIndex = 10
        '
        'add_emp_txt_email
        '
        Me.add_emp_txt_email.Location = New System.Drawing.Point(113, 91)
        Me.add_emp_txt_email.Name = "add_emp_txt_email"
        Me.add_emp_txt_email.Size = New System.Drawing.Size(324, 20)
        Me.add_emp_txt_email.TabIndex = 11
        '
        'add_emp_lbl_fname
        '
        Me.add_emp_lbl_fname.AutoSize = True
        Me.add_emp_lbl_fname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.add_emp_lbl_fname.ForeColor = System.Drawing.Color.White
        Me.add_emp_lbl_fname.Location = New System.Drawing.Point(12, 20)
        Me.add_emp_lbl_fname.Name = "add_emp_lbl_fname"
        Me.add_emp_lbl_fname.Size = New System.Drawing.Size(85, 18)
        Me.add_emp_lbl_fname.TabIndex = 13
        Me.add_emp_lbl_fname.Text = "First Name"
        '
        'add_emp_lbl_lname
        '
        Me.add_emp_lbl_lname.AutoSize = True
        Me.add_emp_lbl_lname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.add_emp_lbl_lname.ForeColor = System.Drawing.Color.White
        Me.add_emp_lbl_lname.Location = New System.Drawing.Point(12, 55)
        Me.add_emp_lbl_lname.Name = "add_emp_lbl_lname"
        Me.add_emp_lbl_lname.Size = New System.Drawing.Size(84, 18)
        Me.add_emp_lbl_lname.TabIndex = 14
        Me.add_emp_lbl_lname.Text = "Last Name"
        '
        'add_emp_lbl_email
        '
        Me.add_emp_lbl_email.AutoSize = True
        Me.add_emp_lbl_email.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.add_emp_lbl_email.ForeColor = System.Drawing.Color.White
        Me.add_emp_lbl_email.Location = New System.Drawing.Point(12, 93)
        Me.add_emp_lbl_email.Name = "add_emp_lbl_email"
        Me.add_emp_lbl_email.Size = New System.Drawing.Size(48, 18)
        Me.add_emp_lbl_email.TabIndex = 15
        Me.add_emp_lbl_email.Text = "Email"
        '
        'add_emp_lbl_phone
        '
        Me.add_emp_lbl_phone.AutoSize = True
        Me.add_emp_lbl_phone.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.add_emp_lbl_phone.ForeColor = System.Drawing.Color.White
        Me.add_emp_lbl_phone.Location = New System.Drawing.Point(406, 15)
        Me.add_emp_lbl_phone.Name = "add_emp_lbl_phone"
        Me.add_emp_lbl_phone.Size = New System.Drawing.Size(53, 18)
        Me.add_emp_lbl_phone.TabIndex = 16
        Me.add_emp_lbl_phone.Text = "Phone"
        '
        'add_emp_txt_phone
        '
        Me.add_emp_txt_phone.Location = New System.Drawing.Point(465, 13)
        Me.add_emp_txt_phone.Mask = "(999) 000-0000"
        Me.add_emp_txt_phone.Name = "add_emp_txt_phone"
        Me.add_emp_txt_phone.Size = New System.Drawing.Size(84, 20)
        Me.add_emp_txt_phone.TabIndex = 17
        '
        'add_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(687, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.add_emp_txt_phone)
        Me.Controls.Add(Me.add_emp_lbl_phone)
        Me.Controls.Add(Me.add_emp_lbl_email)
        Me.Controls.Add(Me.add_emp_lbl_lname)
        Me.Controls.Add(Me.add_emp_lbl_fname)
        Me.Controls.Add(Me.add_emp_txt_email)
        Me.Controls.Add(Me.add_emp_txt_lname)
        Me.Controls.Add(Me.add_emp_txt_fname)
        Me.Controls.Add(Me.add_emp_btn_save)
        Me.Controls.Add(Me.add_emp_btn_cancel)
        Me.Name = "add_employee"
        Me.Text = "Add Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_emp_btn_cancel As Button
    Friend WithEvents add_emp_btn_save As Button
    Friend WithEvents add_emp_txt_fname As TextBox
    Friend WithEvents add_emp_txt_lname As TextBox
    Friend WithEvents add_emp_txt_email As TextBox
    Friend WithEvents add_emp_lbl_fname As Label
    Friend WithEvents add_emp_lbl_lname As Label
    Friend WithEvents add_emp_lbl_email As Label
    Friend WithEvents add_emp_lbl_phone As Label
    Friend WithEvents add_emp_txt_phone As MaskedTextBox
End Class
