<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_contact
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
        Me.sc_txt_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sc_txt_lname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.account_number = New System.Windows.Forms.TextBox()
        Me.sc_btn_search = New System.Windows.Forms.Button()
        Me.sc_btn_cancel = New System.Windows.Forms.Button()
        Me.sc_lbl_notfound = New System.Windows.Forms.Label()
        Me.sc_lbl_found = New System.Windows.Forms.Label()
        Me.sc_btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sc_txt_fname
        '
        Me.sc_txt_fname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.sc_txt_fname.Location = New System.Drawing.Point(200, 125)
        Me.sc_txt_fname.Name = "sc_txt_fname"
        Me.sc_txt_fname.Size = New System.Drawing.Size(194, 26)
        Me.sc_txt_fname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(59, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(60, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name"
        '
        'sc_txt_lname
        '
        Me.sc_txt_lname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.sc_txt_lname.Location = New System.Drawing.Point(200, 178)
        Me.sc_txt_lname.Name = "sc_txt_lname"
        Me.sc_txt_lname.Size = New System.Drawing.Size(194, 26)
        Me.sc_txt_lname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(60, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Account Number"
        '
        'account_number
        '
        Me.account_number.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.account_number.Location = New System.Drawing.Point(200, 68)
        Me.account_number.Name = "account_number"
        Me.account_number.Size = New System.Drawing.Size(194, 26)
        Me.account_number.TabIndex = 1
        '
        'sc_btn_search
        '
        Me.sc_btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.sc_btn_search.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.sc_btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.sc_btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.sc_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_btn_search.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.sc_btn_search.ForeColor = System.Drawing.Color.White
        Me.sc_btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sc_btn_search.Location = New System.Drawing.Point(82, 288)
        Me.sc_btn_search.Name = "sc_btn_search"
        Me.sc_btn_search.Size = New System.Drawing.Size(115, 65)
        Me.sc_btn_search.TabIndex = 4
        Me.sc_btn_search.Text = "Search"
        Me.sc_btn_search.UseVisualStyleBackColor = False
        '
        'sc_btn_cancel
        '
        Me.sc_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.sc_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.sc_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.sc_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.sc_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.sc_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.sc_btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sc_btn_cancel.Location = New System.Drawing.Point(279, 288)
        Me.sc_btn_cancel.Name = "sc_btn_cancel"
        Me.sc_btn_cancel.Size = New System.Drawing.Size(115, 65)
        Me.sc_btn_cancel.TabIndex = 5
        Me.sc_btn_cancel.Text = "Cancel"
        Me.sc_btn_cancel.UseVisualStyleBackColor = False
        '
        'sc_lbl_notfound
        '
        Me.sc_lbl_notfound.BackColor = System.Drawing.Color.Gold
        Me.sc_lbl_notfound.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_lbl_notfound.ForeColor = System.Drawing.Color.DarkRed
        Me.sc_lbl_notfound.Location = New System.Drawing.Point(12, 9)
        Me.sc_lbl_notfound.Name = "sc_lbl_notfound"
        Me.sc_lbl_notfound.Size = New System.Drawing.Size(463, 44)
        Me.sc_lbl_notfound.TabIndex = 14
        Me.sc_lbl_notfound.Text = "Contact not found! Please try again."
        Me.sc_lbl_notfound.Visible = False
        '
        'sc_lbl_found
        '
        Me.sc_lbl_found.BackColor = System.Drawing.Color.LightSlateGray
        Me.sc_lbl_found.Enabled = False
        Me.sc_lbl_found.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_lbl_found.ForeColor = System.Drawing.Color.YellowGreen
        Me.sc_lbl_found.Location = New System.Drawing.Point(12, 377)
        Me.sc_lbl_found.Name = "sc_lbl_found"
        Me.sc_lbl_found.Size = New System.Drawing.Size(463, 44)
        Me.sc_lbl_found.TabIndex = 15
        Me.sc_lbl_found.Text = "Contact Found. Please click ok."
        Me.sc_lbl_found.Visible = False
        '
        'sc_btn_ok
        '
        Me.sc_btn_ok.BackColor = System.Drawing.Color.LightSlateGray
        Me.sc_btn_ok.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sc_btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.sc_btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.sc_btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.sc_btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_btn_ok.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.sc_btn_ok.ForeColor = System.Drawing.Color.White
        Me.sc_btn_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sc_btn_ok.Location = New System.Drawing.Point(0, 502)
        Me.sc_btn_ok.Name = "sc_btn_ok"
        Me.sc_btn_ok.Size = New System.Drawing.Size(487, 65)
        Me.sc_btn_ok.TabIndex = 16
        Me.sc_btn_ok.Text = "Ok"
        Me.sc_btn_ok.UseVisualStyleBackColor = False
        Me.sc_btn_ok.Visible = False
        '
        'search_contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(487, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.sc_btn_search)
        Me.Controls.Add(Me.sc_btn_ok)
        Me.Controls.Add(Me.sc_lbl_found)
        Me.Controls.Add(Me.sc_lbl_notfound)
        Me.Controls.Add(Me.sc_btn_cancel)
        Me.Controls.Add(Me.account_number)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sc_txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sc_txt_fname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "search_contact"
        Me.Text = "Search Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sc_txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sc_txt_lname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents account_number As TextBox
    Friend WithEvents sc_btn_search As Button
    Friend WithEvents sc_btn_cancel As Button
    Friend WithEvents sc_lbl_notfound As Label
    Friend WithEvents sc_lbl_found As Label
    Friend WithEvents sc_btn_ok As Button
End Class
