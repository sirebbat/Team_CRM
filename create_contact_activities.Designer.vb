<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_contact_activities
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
        Me.cca_lbl_contact_type = New System.Windows.Forms.Label()
        Me.cca_cb_contact_type = New System.Windows.Forms.ComboBox()
        Me.cca_dp_created_on = New System.Windows.Forms.DateTimePicker()
        Me.cca_lbl_created_on = New System.Windows.Forms.Label()
        Me.cca_lbl_employee = New System.Windows.Forms.Label()
        Me.cca_cb_employee = New System.Windows.Forms.ComboBox()
        Me.cca_btn_update = New System.Windows.Forms.Button()
        Me.cca_txt_comment = New System.Windows.Forms.RichTextBox()
        Me.cca_btn_cancel = New System.Windows.Forms.Button()
        Me.cca_lbl_current_char = New System.Windows.Forms.Label()
        Me.cca_lbl_char_left = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cca_lbl_contact_type
        '
        Me.cca_lbl_contact_type.AutoSize = True
        Me.cca_lbl_contact_type.BackColor = System.Drawing.Color.SlateGray
        Me.cca_lbl_contact_type.Location = New System.Drawing.Point(13, 141)
        Me.cca_lbl_contact_type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cca_lbl_contact_type.Name = "cca_lbl_contact_type"
        Me.cca_lbl_contact_type.Size = New System.Drawing.Size(99, 18)
        Me.cca_lbl_contact_type.TabIndex = 0
        Me.cca_lbl_contact_type.Text = "Contact Type"
        '
        'cca_cb_contact_type
        '
        Me.cca_cb_contact_type.DropDownHeight = 170
        Me.cca_cb_contact_type.FormattingEnabled = True
        Me.cca_cb_contact_type.IntegralHeight = False
        Me.cca_cb_contact_type.Location = New System.Drawing.Point(133, 133)
        Me.cca_cb_contact_type.Name = "cca_cb_contact_type"
        Me.cca_cb_contact_type.Size = New System.Drawing.Size(175, 26)
        Me.cca_cb_contact_type.TabIndex = 3
        '
        'cca_dp_created_on
        '
        Me.cca_dp_created_on.CustomFormat = "MM/dd/yyyy"
        Me.cca_dp_created_on.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cca_dp_created_on.Location = New System.Drawing.Point(133, 36)
        Me.cca_dp_created_on.Name = "cca_dp_created_on"
        Me.cca_dp_created_on.Size = New System.Drawing.Size(114, 26)
        Me.cca_dp_created_on.TabIndex = 1
        '
        'cca_lbl_created_on
        '
        Me.cca_lbl_created_on.AutoSize = True
        Me.cca_lbl_created_on.BackColor = System.Drawing.Color.SlateGray
        Me.cca_lbl_created_on.Location = New System.Drawing.Point(13, 40)
        Me.cca_lbl_created_on.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cca_lbl_created_on.Name = "cca_lbl_created_on"
        Me.cca_lbl_created_on.Size = New System.Drawing.Size(89, 18)
        Me.cca_lbl_created_on.TabIndex = 3
        Me.cca_lbl_created_on.Text = "Created On"
        '
        'cca_lbl_employee
        '
        Me.cca_lbl_employee.AutoSize = True
        Me.cca_lbl_employee.BackColor = System.Drawing.Color.SlateGray
        Me.cca_lbl_employee.Location = New System.Drawing.Point(13, 91)
        Me.cca_lbl_employee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cca_lbl_employee.Name = "cca_lbl_employee"
        Me.cca_lbl_employee.Size = New System.Drawing.Size(78, 18)
        Me.cca_lbl_employee.TabIndex = 4
        Me.cca_lbl_employee.Text = "Employee"
        '
        'cca_cb_employee
        '
        Me.cca_cb_employee.DropDownHeight = 130
        Me.cca_cb_employee.FormattingEnabled = True
        Me.cca_cb_employee.IntegralHeight = False
        Me.cca_cb_employee.Location = New System.Drawing.Point(133, 91)
        Me.cca_cb_employee.Name = "cca_cb_employee"
        Me.cca_cb_employee.Size = New System.Drawing.Size(175, 26)
        Me.cca_cb_employee.TabIndex = 2
        '
        'cca_btn_update
        '
        Me.cca_btn_update.BackColor = System.Drawing.Color.LightSlateGray
        Me.cca_btn_update.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.cca_btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cca_btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.cca_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cca_btn_update.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cca_btn_update.ForeColor = System.Drawing.Color.White
        Me.cca_btn_update.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cca_btn_update.Location = New System.Drawing.Point(57, 390)
        Me.cca_btn_update.Name = "cca_btn_update"
        Me.cca_btn_update.Size = New System.Drawing.Size(105, 65)
        Me.cca_btn_update.TabIndex = 5
        Me.cca_btn_update.Text = "Save"
        Me.cca_btn_update.UseVisualStyleBackColor = False
        '
        'cca_txt_comment
        '
        Me.cca_txt_comment.ForeColor = System.Drawing.Color.Black
        Me.cca_txt_comment.Location = New System.Drawing.Point(16, 197)
        Me.cca_txt_comment.MaxLength = 140
        Me.cca_txt_comment.Name = "cca_txt_comment"
        Me.cca_txt_comment.Size = New System.Drawing.Size(369, 96)
        Me.cca_txt_comment.TabIndex = 4
        Me.cca_txt_comment.Text = ""
        '
        'cca_btn_cancel
        '
        Me.cca_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.cca_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.cca_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cca_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.cca_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cca_btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cca_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.cca_btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cca_btn_cancel.Location = New System.Drawing.Point(206, 390)
        Me.cca_btn_cancel.Name = "cca_btn_cancel"
        Me.cca_btn_cancel.Size = New System.Drawing.Size(102, 65)
        Me.cca_btn_cancel.TabIndex = 6
        Me.cca_btn_cancel.Text = "Cancel"
        Me.cca_btn_cancel.UseVisualStyleBackColor = False
        '
        'cca_lbl_current_char
        '
        Me.cca_lbl_current_char.AutoSize = True
        Me.cca_lbl_current_char.BackColor = System.Drawing.Color.SlateGray
        Me.cca_lbl_current_char.Location = New System.Drawing.Point(13, 315)
        Me.cca_lbl_current_char.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cca_lbl_current_char.Name = "cca_lbl_current_char"
        Me.cca_lbl_current_char.Size = New System.Drawing.Size(174, 18)
        Me.cca_lbl_current_char.TabIndex = 18
        Me.cca_lbl_current_char.Text = "Current Characters Left:"
        '
        'cca_lbl_char_left
        '
        Me.cca_lbl_char_left.AutoSize = True
        Me.cca_lbl_char_left.BackColor = System.Drawing.Color.SlateGray
        Me.cca_lbl_char_left.Location = New System.Drawing.Point(195, 315)
        Me.cca_lbl_char_left.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cca_lbl_char_left.Name = "cca_lbl_char_left"
        Me.cca_lbl_char_left.Size = New System.Drawing.Size(0, 18)
        Me.cca_lbl_char_left.TabIndex = 19
        '
        'create_contact_activities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(411, 477)
        Me.Controls.Add(Me.cca_lbl_char_left)
        Me.Controls.Add(Me.cca_lbl_current_char)
        Me.Controls.Add(Me.cca_btn_cancel)
        Me.Controls.Add(Me.cca_txt_comment)
        Me.Controls.Add(Me.cca_btn_update)
        Me.Controls.Add(Me.cca_cb_employee)
        Me.Controls.Add(Me.cca_lbl_employee)
        Me.Controls.Add(Me.cca_lbl_created_on)
        Me.Controls.Add(Me.cca_dp_created_on)
        Me.Controls.Add(Me.cca_cb_contact_type)
        Me.Controls.Add(Me.cca_lbl_contact_type)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "create_contact_activities"
        Me.Text = "create_contact_activities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cca_lbl_contact_type As Label
    Friend WithEvents cca_cb_contact_type As ComboBox
    Friend WithEvents cca_dp_created_on As DateTimePicker
    Friend WithEvents cca_lbl_created_on As Label
    Friend WithEvents cca_lbl_employee As Label
    Friend WithEvents cca_cb_employee As ComboBox
    Friend WithEvents cca_btn_update As Button
    Friend WithEvents cca_txt_comment As RichTextBox
    Friend WithEvents cca_btn_cancel As Button
    Friend WithEvents cca_lbl_current_char As Label
    Friend WithEvents cca_lbl_char_left As Label
End Class
