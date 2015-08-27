<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_contact
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
        Me.gb_ci = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.adr_txt_zip = New System.Windows.Forms.TextBox()
        Me.adr_txt_state = New System.Windows.Forms.TextBox()
        Me.adr_txt_city = New System.Windows.Forms.TextBox()
        Me.adr_lbl_zip = New System.Windows.Forms.Label()
        Me.adr_txt_streetadd = New System.Windows.Forms.TextBox()
        Me.adr_txt_streetad = New System.Windows.Forms.TextBox()
        Me.adr_lbl_streetad = New System.Windows.Forms.Label()
        Me.adr_lbl_state = New System.Windows.Forms.Label()
        Me.adr_lbl_city = New System.Windows.Forms.Label()
        Me.adr_lbl_streetadd = New System.Windows.Forms.Label()
        Me.ci_txt_url = New System.Windows.Forms.TextBox()
        Me.ci_txt_cellp = New System.Windows.Forms.TextBox()
        Me.ci_txt_officen = New System.Windows.Forms.TextBox()
        Me.ci_txt_company = New System.Windows.Forms.TextBox()
        Me.ci_txt_lname = New System.Windows.Forms.TextBox()
        Me.ci_lbl_url = New System.Windows.Forms.Label()
        Me.ci_lbl_cellp = New System.Windows.Forms.Label()
        Me.ci_lbl_officen = New System.Windows.Forms.Label()
        Me.ci_lbl_createddate = New System.Windows.Forms.Label()
        Me.ci_txt_fname = New System.Windows.Forms.TextBox()
        Me.ci_txt_account = New System.Windows.Forms.TextBox()
        Me.ci_lbl_account = New System.Windows.Forms.Label()
        Me.ci_lbl_company = New System.Windows.Forms.Label()
        Me.ci_lbl_lname = New System.Windows.Forms.Label()
        Me.ci_lbl_fname = New System.Windows.Forms.Label()
        Me.ci_btn_update = New System.Windows.Forms.Button()
        Me.ci_btn_cancel = New System.Windows.Forms.Button()
        Me.gb_ci.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_ci
        '
        Me.gb_ci.Controls.Add(Me.DateTimePicker1)
        Me.gb_ci.Controls.Add(Me.adr_txt_zip)
        Me.gb_ci.Controls.Add(Me.adr_txt_state)
        Me.gb_ci.Controls.Add(Me.adr_txt_city)
        Me.gb_ci.Controls.Add(Me.adr_lbl_zip)
        Me.gb_ci.Controls.Add(Me.adr_txt_streetadd)
        Me.gb_ci.Controls.Add(Me.adr_txt_streetad)
        Me.gb_ci.Controls.Add(Me.adr_lbl_streetad)
        Me.gb_ci.Controls.Add(Me.adr_lbl_state)
        Me.gb_ci.Controls.Add(Me.adr_lbl_city)
        Me.gb_ci.Controls.Add(Me.adr_lbl_streetadd)
        Me.gb_ci.Controls.Add(Me.ci_txt_url)
        Me.gb_ci.Controls.Add(Me.ci_txt_cellp)
        Me.gb_ci.Controls.Add(Me.ci_txt_officen)
        Me.gb_ci.Controls.Add(Me.ci_txt_company)
        Me.gb_ci.Controls.Add(Me.ci_txt_lname)
        Me.gb_ci.Controls.Add(Me.ci_lbl_url)
        Me.gb_ci.Controls.Add(Me.ci_lbl_cellp)
        Me.gb_ci.Controls.Add(Me.ci_lbl_officen)
        Me.gb_ci.Controls.Add(Me.ci_lbl_createddate)
        Me.gb_ci.Controls.Add(Me.ci_txt_fname)
        Me.gb_ci.Controls.Add(Me.ci_txt_account)
        Me.gb_ci.Controls.Add(Me.ci_lbl_account)
        Me.gb_ci.Controls.Add(Me.ci_lbl_company)
        Me.gb_ci.Controls.Add(Me.ci_lbl_lname)
        Me.gb_ci.Controls.Add(Me.ci_lbl_fname)
        Me.gb_ci.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.gb_ci.ForeColor = System.Drawing.Color.White
        Me.gb_ci.Location = New System.Drawing.Point(26, 12)
        Me.gb_ci.Name = "gb_ci"
        Me.gb_ci.Size = New System.Drawing.Size(1348, 403)
        Me.gb_ci.TabIndex = 4
        Me.gb_ci.TabStop = False
        Me.gb_ci.Text = "Contact Information"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1084, 35)
        Me.DateTimePicker1.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 26)
        Me.DateTimePicker1.TabIndex = 32
        '
        'adr_txt_zip
        '
        Me.adr_txt_zip.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_txt_zip.Location = New System.Drawing.Point(979, 269)
        Me.adr_txt_zip.Name = "adr_txt_zip"
        Me.adr_txt_zip.Size = New System.Drawing.Size(100, 26)
        Me.adr_txt_zip.TabIndex = 31
        '
        'adr_txt_state
        '
        Me.adr_txt_state.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_txt_state.Location = New System.Drawing.Point(584, 319)
        Me.adr_txt_state.Name = "adr_txt_state"
        Me.adr_txt_state.Size = New System.Drawing.Size(61, 26)
        Me.adr_txt_state.TabIndex = 30
        '
        'adr_txt_city
        '
        Me.adr_txt_city.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_txt_city.Location = New System.Drawing.Point(584, 272)
        Me.adr_txt_city.Name = "adr_txt_city"
        Me.adr_txt_city.Size = New System.Drawing.Size(100, 26)
        Me.adr_txt_city.TabIndex = 29
        '
        'adr_lbl_zip
        '
        Me.adr_lbl_zip.AutoSize = True
        Me.adr_lbl_zip.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_lbl_zip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adr_lbl_zip.Location = New System.Drawing.Point(797, 272)
        Me.adr_lbl_zip.Name = "adr_lbl_zip"
        Me.adr_lbl_zip.Size = New System.Drawing.Size(73, 18)
        Me.adr_lbl_zip.TabIndex = 28
        Me.adr_lbl_zip.Text = "Zip Code"
        '
        'adr_txt_streetadd
        '
        Me.adr_txt_streetadd.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_txt_streetadd.Location = New System.Drawing.Point(147, 319)
        Me.adr_txt_streetadd.Name = "adr_txt_streetadd"
        Me.adr_txt_streetadd.Size = New System.Drawing.Size(266, 26)
        Me.adr_txt_streetadd.TabIndex = 27
        '
        'adr_txt_streetad
        '
        Me.adr_txt_streetad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_txt_streetad.Location = New System.Drawing.Point(147, 269)
        Me.adr_txt_streetad.Name = "adr_txt_streetad"
        Me.adr_txt_streetad.Size = New System.Drawing.Size(266, 26)
        Me.adr_txt_streetad.TabIndex = 26
        '
        'adr_lbl_streetad
        '
        Me.adr_lbl_streetad.AutoSize = True
        Me.adr_lbl_streetad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_lbl_streetad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adr_lbl_streetad.Location = New System.Drawing.Point(6, 272)
        Me.adr_lbl_streetad.Name = "adr_lbl_streetad"
        Me.adr_lbl_streetad.Size = New System.Drawing.Size(112, 18)
        Me.adr_lbl_streetad.TabIndex = 25
        Me.adr_lbl_streetad.Text = "Street Address"
        '
        'adr_lbl_state
        '
        Me.adr_lbl_state.AutoSize = True
        Me.adr_lbl_state.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_lbl_state.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adr_lbl_state.Location = New System.Drawing.Point(485, 327)
        Me.adr_lbl_state.Name = "adr_lbl_state"
        Me.adr_lbl_state.Size = New System.Drawing.Size(45, 18)
        Me.adr_lbl_state.TabIndex = 24
        Me.adr_lbl_state.Text = "State"
        '
        'adr_lbl_city
        '
        Me.adr_lbl_city.AutoSize = True
        Me.adr_lbl_city.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_lbl_city.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adr_lbl_city.Location = New System.Drawing.Point(485, 272)
        Me.adr_lbl_city.Name = "adr_lbl_city"
        Me.adr_lbl_city.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.adr_lbl_city.Size = New System.Drawing.Size(35, 18)
        Me.adr_lbl_city.TabIndex = 23
        Me.adr_lbl_city.Text = "City"
        '
        'adr_lbl_streetadd
        '
        Me.adr_lbl_streetadd.AutoSize = True
        Me.adr_lbl_streetadd.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.adr_lbl_streetadd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.adr_lbl_streetadd.Location = New System.Drawing.Point(6, 319)
        Me.adr_lbl_streetadd.Name = "adr_lbl_streetadd"
        Me.adr_lbl_streetadd.Size = New System.Drawing.Size(125, 18)
        Me.adr_lbl_streetadd.TabIndex = 22
        Me.adr_lbl_streetadd.Text = "Street Address 2"
        '
        'ci_txt_url
        '
        Me.ci_txt_url.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_url.Location = New System.Drawing.Point(582, 183)
        Me.ci_txt_url.Name = "ci_txt_url"
        Me.ci_txt_url.Size = New System.Drawing.Size(297, 26)
        Me.ci_txt_url.TabIndex = 21
        '
        'ci_txt_cellp
        '
        Me.ci_txt_cellp.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_cellp.Location = New System.Drawing.Point(582, 137)
        Me.ci_txt_cellp.Name = "ci_txt_cellp"
        Me.ci_txt_cellp.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_cellp.TabIndex = 20
        '
        'ci_txt_officen
        '
        Me.ci_txt_officen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_officen.Location = New System.Drawing.Point(582, 88)
        Me.ci_txt_officen.Name = "ci_txt_officen"
        Me.ci_txt_officen.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_officen.TabIndex = 19
        '
        'ci_txt_company
        '
        Me.ci_txt_company.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_company.Location = New System.Drawing.Point(147, 186)
        Me.ci_txt_company.Name = "ci_txt_company"
        Me.ci_txt_company.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_company.TabIndex = 17
        '
        'ci_txt_lname
        '
        Me.ci_txt_lname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_lname.Location = New System.Drawing.Point(147, 134)
        Me.ci_txt_lname.Name = "ci_txt_lname"
        Me.ci_txt_lname.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_lname.TabIndex = 16
        '
        'ci_lbl_url
        '
        Me.ci_lbl_url.AutoSize = True
        Me.ci_lbl_url.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_url.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_url.Location = New System.Drawing.Point(430, 191)
        Me.ci_lbl_url.Name = "ci_lbl_url"
        Me.ci_lbl_url.Size = New System.Drawing.Size(39, 18)
        Me.ci_lbl_url.TabIndex = 14
        Me.ci_lbl_url.Text = "URL"
        '
        'ci_lbl_cellp
        '
        Me.ci_lbl_cellp.AutoSize = True
        Me.ci_lbl_cellp.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_cellp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_cellp.Location = New System.Drawing.Point(430, 137)
        Me.ci_lbl_cellp.Name = "ci_lbl_cellp"
        Me.ci_lbl_cellp.Size = New System.Drawing.Size(88, 18)
        Me.ci_lbl_cellp.TabIndex = 11
        Me.ci_lbl_cellp.Text = "Cell Phone "
        '
        'ci_lbl_officen
        '
        Me.ci_lbl_officen.AutoSize = True
        Me.ci_lbl_officen.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_officen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_officen.Location = New System.Drawing.Point(430, 88)
        Me.ci_lbl_officen.Name = "ci_lbl_officen"
        Me.ci_lbl_officen.Size = New System.Drawing.Size(108, 18)
        Me.ci_lbl_officen.TabIndex = 10
        Me.ci_lbl_officen.Text = "Office Number"
        '
        'ci_lbl_createddate
        '
        Me.ci_lbl_createddate.AutoSize = True
        Me.ci_lbl_createddate.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_createddate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_createddate.Location = New System.Drawing.Point(942, 41)
        Me.ci_lbl_createddate.Name = "ci_lbl_createddate"
        Me.ci_lbl_createddate.Size = New System.Drawing.Size(103, 18)
        Me.ci_lbl_createddate.TabIndex = 8
        Me.ci_lbl_createddate.Text = "Created Date"
        '
        'ci_txt_fname
        '
        Me.ci_txt_fname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_fname.Location = New System.Drawing.Point(147, 88)
        Me.ci_txt_fname.Name = "ci_txt_fname"
        Me.ci_txt_fname.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_fname.TabIndex = 5
        '
        'ci_txt_account
        '
        Me.ci_txt_account.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_txt_account.Location = New System.Drawing.Point(147, 38)
        Me.ci_txt_account.Name = "ci_txt_account"
        Me.ci_txt_account.ReadOnly = True
        Me.ci_txt_account.Size = New System.Drawing.Size(100, 26)
        Me.ci_txt_account.TabIndex = 4
        '
        'ci_lbl_account
        '
        Me.ci_lbl_account.AutoSize = True
        Me.ci_lbl_account.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_account.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_account.Location = New System.Drawing.Point(6, 41)
        Me.ci_lbl_account.Name = "ci_lbl_account"
        Me.ci_lbl_account.Size = New System.Drawing.Size(68, 18)
        Me.ci_lbl_account.TabIndex = 3
        Me.ci_lbl_account.Text = "Account "
        '
        'ci_lbl_company
        '
        Me.ci_lbl_company.AutoSize = True
        Me.ci_lbl_company.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_company.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_company.Location = New System.Drawing.Point(6, 189)
        Me.ci_lbl_company.Name = "ci_lbl_company"
        Me.ci_lbl_company.Size = New System.Drawing.Size(75, 18)
        Me.ci_lbl_company.TabIndex = 2
        Me.ci_lbl_company.Text = "Company"
        '
        'ci_lbl_lname
        '
        Me.ci_lbl_lname.AutoSize = True
        Me.ci_lbl_lname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_lname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_lname.Location = New System.Drawing.Point(6, 137)
        Me.ci_lbl_lname.Name = "ci_lbl_lname"
        Me.ci_lbl_lname.Size = New System.Drawing.Size(84, 18)
        Me.ci_lbl_lname.TabIndex = 1
        Me.ci_lbl_lname.Text = "Last Name"
        '
        'ci_lbl_fname
        '
        Me.ci_lbl_fname.AutoSize = True
        Me.ci_lbl_fname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ci_lbl_fname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_lbl_fname.Location = New System.Drawing.Point(6, 88)
        Me.ci_lbl_fname.Name = "ci_lbl_fname"
        Me.ci_lbl_fname.Size = New System.Drawing.Size(85, 18)
        Me.ci_lbl_fname.TabIndex = 0
        Me.ci_lbl_fname.Text = "First Name"
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
        Me.ci_btn_update.Location = New System.Drawing.Point(356, 471)
        Me.ci_btn_update.Name = "ci_btn_update"
        Me.ci_btn_update.Size = New System.Drawing.Size(198, 65)
        Me.ci_btn_update.TabIndex = 5
        Me.ci_btn_update.Text = "Save"
        Me.ci_btn_update.UseVisualStyleBackColor = False
        '
        'ci_btn_cancel
        '
        Me.ci_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.ci_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ci_btn_cancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ci_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.ci_btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ci_btn_cancel.Location = New System.Drawing.Point(673, 471)
        Me.ci_btn_cancel.Name = "ci_btn_cancel"
        Me.ci_btn_cancel.Size = New System.Drawing.Size(198, 65)
        Me.ci_btn_cancel.TabIndex = 6
        Me.ci_btn_cancel.Text = "Cancel"
        Me.ci_btn_cancel.UseVisualStyleBackColor = False
        '
        'create_contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1399, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.ci_btn_cancel)
        Me.Controls.Add(Me.ci_btn_update)
        Me.Controls.Add(Me.gb_ci)
        Me.Name = "create_contact"
        Me.Text = "Create Contact"
        Me.gb_ci.ResumeLayout(False)
        Me.gb_ci.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_ci As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents adr_txt_zip As TextBox
    Friend WithEvents adr_txt_state As TextBox
    Friend WithEvents adr_txt_city As TextBox
    Friend WithEvents adr_lbl_zip As Label
    Friend WithEvents adr_txt_streetadd As TextBox
    Friend WithEvents adr_txt_streetad As TextBox
    Friend WithEvents adr_lbl_streetad As Label
    Friend WithEvents adr_lbl_state As Label
    Friend WithEvents adr_lbl_city As Label
    Friend WithEvents adr_lbl_streetadd As Label
    Friend WithEvents ci_txt_url As TextBox
    Friend WithEvents ci_txt_cellp As TextBox
    Friend WithEvents ci_txt_officen As TextBox
    Friend WithEvents ci_txt_company As TextBox
    Friend WithEvents ci_txt_lname As TextBox
    Friend WithEvents ci_lbl_url As Label
    Friend WithEvents ci_lbl_cellp As Label
    Friend WithEvents ci_lbl_officen As Label
    Friend WithEvents ci_lbl_createddate As Label
    Friend WithEvents ci_txt_fname As TextBox
    Friend WithEvents ci_txt_account As TextBox
    Friend WithEvents ci_lbl_account As Label
    Friend WithEvents ci_lbl_company As Label
    Friend WithEvents ci_lbl_lname As Label
    Friend WithEvents ci_lbl_fname As Label
    Friend WithEvents ci_btn_update As Button
    Friend WithEvents ci_btn_cancel As Button
End Class
