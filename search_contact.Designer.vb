<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class search_contact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.sc_lbl_account_number = New System.Windows.Forms.Label()
        Me.account_number = New System.Windows.Forms.TextBox()
        Me.sc_btn_search = New System.Windows.Forms.Button()
        Me.sc_btn_cancel = New System.Windows.Forms.Button()
        Me.sc_lbl_notfound = New System.Windows.Forms.Label()
        Me.sc_lbl_found = New System.Windows.Forms.Label()
        Me.sc_btn_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sc_lbl_account_number
        '
        Me.sc_lbl_account_number.AutoSize = True
        Me.sc_lbl_account_number.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.sc_lbl_account_number.ForeColor = System.Drawing.Color.White
        Me.sc_lbl_account_number.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sc_lbl_account_number.Location = New System.Drawing.Point(60, 71)
        Me.sc_lbl_account_number.Name = "sc_lbl_account_number"
        Me.sc_lbl_account_number.Size = New System.Drawing.Size(123, 18)
        Me.sc_lbl_account_number.TabIndex = 10
        Me.sc_lbl_account_number.Text = "Account Number"
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
        Me.sc_btn_search.Location = New System.Drawing.Point(63, 182)
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
        Me.sc_btn_cancel.Location = New System.Drawing.Point(279, 182)
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
        Me.sc_lbl_found.Location = New System.Drawing.Point(8, 288)
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
        Me.sc_btn_ok.Location = New System.Drawing.Point(0, 363)
        Me.sc_btn_ok.Name = "sc_btn_ok"
        Me.sc_btn_ok.Size = New System.Drawing.Size(483, 65)
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
        Me.ClientSize = New System.Drawing.Size(483, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.sc_btn_search)
        Me.Controls.Add(Me.sc_btn_ok)
        Me.Controls.Add(Me.sc_lbl_found)
        Me.Controls.Add(Me.sc_lbl_notfound)
        Me.Controls.Add(Me.sc_btn_cancel)
        Me.Controls.Add(Me.account_number)
        Me.Controls.Add(Me.sc_lbl_account_number)
        Me.Name = "search_contact"
        Me.Text = "Search Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sc_lbl_account_number As Label
    Friend WithEvents account_number As TextBox
    Friend WithEvents sc_btn_search As Button
    Friend WithEvents sc_btn_cancel As Button
    Friend WithEvents sc_lbl_notfound As Label
    Friend WithEvents sc_lbl_found As Label
    Friend WithEvents sc_btn_ok As Button
End Class
