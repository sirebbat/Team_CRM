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
        Me.adde_btn_cancel = New System.Windows.Forms.Button()
        Me.adde_btn_save = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.adde_lbl_fname = New System.Windows.Forms.Label()
        Me.adde_lbl_lname = New System.Windows.Forms.Label()
        Me.adde_lbl_email = New System.Windows.Forms.Label()
        Me.adde_lbl_phone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'adde_btn_cancel
        '
        Me.adde_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.adde_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.adde_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.adde_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.adde_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adde_btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.adde_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.adde_btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adde_btn_cancel.Location = New System.Drawing.Point(372, 163)
        Me.adde_btn_cancel.Name = "adde_btn_cancel"
        Me.adde_btn_cancel.Size = New System.Drawing.Size(198, 65)
        Me.adde_btn_cancel.TabIndex = 7
        Me.adde_btn_cancel.Text = "Cancel"
        Me.adde_btn_cancel.UseVisualStyleBackColor = False
        '
        'adde_btn_save
        '
        Me.adde_btn_save.BackColor = System.Drawing.Color.LightSlateGray
        Me.adde_btn_save.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.adde_btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.adde_btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.adde_btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adde_btn_save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.adde_btn_save.ForeColor = System.Drawing.Color.White
        Me.adde_btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adde_btn_save.Location = New System.Drawing.Point(122, 163)
        Me.adde_btn_save.Name = "adde_btn_save"
        Me.adde_btn_save.Size = New System.Drawing.Size(198, 65)
        Me.adde_btn_save.TabIndex = 8
        Me.adde_btn_save.Text = "Save"
        Me.adde_btn_save.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(113, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(324, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(470, 12)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 20)
        Me.TextBox4.TabIndex = 12
        '
        'adde_lbl_fname
        '
        Me.adde_lbl_fname.AutoSize = True
        Me.adde_lbl_fname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adde_lbl_fname.ForeColor = System.Drawing.Color.White
        Me.adde_lbl_fname.Location = New System.Drawing.Point(12, 20)
        Me.adde_lbl_fname.Name = "adde_lbl_fname"
        Me.adde_lbl_fname.Size = New System.Drawing.Size(85, 18)
        Me.adde_lbl_fname.TabIndex = 13
        Me.adde_lbl_fname.Text = "First Name"
        '
        'adde_lbl_lname
        '
        Me.adde_lbl_lname.AutoSize = True
        Me.adde_lbl_lname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adde_lbl_lname.ForeColor = System.Drawing.Color.White
        Me.adde_lbl_lname.Location = New System.Drawing.Point(12, 55)
        Me.adde_lbl_lname.Name = "adde_lbl_lname"
        Me.adde_lbl_lname.Size = New System.Drawing.Size(84, 18)
        Me.adde_lbl_lname.TabIndex = 14
        Me.adde_lbl_lname.Text = "Last Name"
        '
        'adde_lbl_email
        '
        Me.adde_lbl_email.AutoSize = True
        Me.adde_lbl_email.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adde_lbl_email.ForeColor = System.Drawing.Color.White
        Me.adde_lbl_email.Location = New System.Drawing.Point(12, 93)
        Me.adde_lbl_email.Name = "adde_lbl_email"
        Me.adde_lbl_email.Size = New System.Drawing.Size(48, 18)
        Me.adde_lbl_email.TabIndex = 15
        Me.adde_lbl_email.Text = "Email"
        '
        'adde_lbl_phone
        '
        Me.adde_lbl_phone.AutoSize = True
        Me.adde_lbl_phone.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adde_lbl_phone.ForeColor = System.Drawing.Color.White
        Me.adde_lbl_phone.Location = New System.Drawing.Point(406, 15)
        Me.adde_lbl_phone.Name = "adde_lbl_phone"
        Me.adde_lbl_phone.Size = New System.Drawing.Size(53, 18)
        Me.adde_lbl_phone.TabIndex = 16
        Me.adde_lbl_phone.Text = "Phone"
        '
        'add_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(687, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.adde_lbl_phone)
        Me.Controls.Add(Me.adde_lbl_email)
        Me.Controls.Add(Me.adde_lbl_lname)
        Me.Controls.Add(Me.adde_lbl_fname)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.adde_btn_save)
        Me.Controls.Add(Me.adde_btn_cancel)
        Me.Name = "add_employee"
        Me.Text = "Add Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents adde_btn_cancel As Button
    Friend WithEvents adde_btn_save As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents adde_lbl_fname As Label
    Friend WithEvents adde_lbl_lname As Label
    Friend WithEvents adde_lbl_email As Label
    Friend WithEvents adde_lbl_phone As Label
End Class
