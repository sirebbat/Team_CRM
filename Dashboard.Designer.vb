<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.dashboard_tab = New System.Windows.Forms.TabControl()
        Me.tabClient = New System.Windows.Forms.TabPage()
        Me.gb_activities = New System.Windows.Forms.GroupBox()
        Me.act_lv = New System.Windows.Forms.ListView()
        Me.act_lb_activity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_addedon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_lastmodified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_employee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_lb_comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.act_btn_create = New System.Windows.Forms.Button()
        Me.gb_ci = New System.Windows.Forms.GroupBox()
        Me.ci_btn_cancel = New System.Windows.Forms.Button()
        Me.adr_txt_state = New System.Windows.Forms.ComboBox()
        Me.ci_created_date = New System.Windows.Forms.MaskedTextBox()
        Me.ci_txt_email = New System.Windows.Forms.TextBox()
        Me.ci_lbl_email = New System.Windows.Forms.Label()
        Me.ci_btn_delete = New System.Windows.Forms.Button()
        Me.ci_btn_save = New System.Windows.Forms.Button()
        Me.ci_btn_update = New System.Windows.Forms.Button()
        Me.adr_txt_zip = New System.Windows.Forms.TextBox()
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.tabEmp = New System.Windows.Forms.TabPage()
        Me.emp_btn_cancel = New System.Windows.Forms.Button()
        Me.emp_btn_load = New System.Windows.Forms.Button()
        Me.emp_lv = New System.Windows.Forms.ListView()
        Me.emp_lb_employeeid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.emp_lb_fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.emp_lb_lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.emp_lb_phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.emp_lb_ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.emp_btn_delete = New System.Windows.Forms.Button()
        Me.emp_btn_add = New System.Windows.Forms.Button()
        Me.dashboard_tab.SuspendLayout()
        Me.tabClient.SuspendLayout()
        Me.gb_activities.SuspendLayout()
        Me.gb_ci.SuspendLayout()
        Me.tabEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'dashboard_tab
        '
        Me.dashboard_tab.Controls.Add(Me.tabClient)
        Me.dashboard_tab.Controls.Add(Me.tabEmp)
        resources.ApplyResources(Me.dashboard_tab, "dashboard_tab")
        Me.dashboard_tab.Name = "dashboard_tab"
        Me.dashboard_tab.SelectedIndex = 0
        Me.dashboard_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'tabClient
        '
        resources.ApplyResources(Me.tabClient, "tabClient")
        Me.tabClient.BackColor = System.Drawing.Color.SlateGray
        Me.tabClient.Controls.Add(Me.gb_activities)
        Me.tabClient.Controls.Add(Me.gb_ci)
        Me.tabClient.Controls.Add(Me.btnSearch)
        Me.tabClient.Controls.Add(Me.btnCreate)
        Me.tabClient.ForeColor = System.Drawing.Color.White
        Me.tabClient.Name = "tabClient"
        '
        'gb_activities
        '
        resources.ApplyResources(Me.gb_activities, "gb_activities")
        Me.gb_activities.Controls.Add(Me.act_lv)
        Me.gb_activities.Controls.Add(Me.act_btn_create)
        Me.gb_activities.ForeColor = System.Drawing.Color.White
        Me.gb_activities.Name = "gb_activities"
        Me.gb_activities.TabStop = False
        '
        'act_lv
        '
        Me.act_lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.act_lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.act_lb_activity, Me.act_lb_type, Me.act_lb_status, Me.act_lb_addedon, Me.act_lb_lastmodified, Me.act_lb_employee, Me.act_lb_comment})
        resources.ApplyResources(Me.act_lv, "act_lv")
        Me.act_lv.Name = "act_lv"
        Me.act_lv.UseCompatibleStateImageBehavior = False
        Me.act_lv.View = System.Windows.Forms.View.Details
        '
        'act_lb_activity
        '
        resources.ApplyResources(Me.act_lb_activity, "act_lb_activity")
        '
        'act_lb_type
        '
        resources.ApplyResources(Me.act_lb_type, "act_lb_type")
        '
        'act_lb_status
        '
        resources.ApplyResources(Me.act_lb_status, "act_lb_status")
        '
        'act_lb_addedon
        '
        resources.ApplyResources(Me.act_lb_addedon, "act_lb_addedon")
        '
        'act_lb_lastmodified
        '
        resources.ApplyResources(Me.act_lb_lastmodified, "act_lb_lastmodified")
        '
        'act_lb_employee
        '
        resources.ApplyResources(Me.act_lb_employee, "act_lb_employee")
        '
        'act_lb_comment
        '
        resources.ApplyResources(Me.act_lb_comment, "act_lb_comment")
        '
        'act_btn_create
        '
        Me.act_btn_create.BackColor = System.Drawing.Color.LightSlateGray
        Me.act_btn_create.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.act_btn_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.act_btn_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.act_btn_create, "act_btn_create")
        Me.act_btn_create.ForeColor = System.Drawing.Color.White
        Me.act_btn_create.Name = "act_btn_create"
        Me.act_btn_create.UseVisualStyleBackColor = False
        '
        'gb_ci
        '
        resources.ApplyResources(Me.gb_ci, "gb_ci")
        Me.gb_ci.Controls.Add(Me.ci_btn_cancel)
        Me.gb_ci.Controls.Add(Me.adr_txt_state)
        Me.gb_ci.Controls.Add(Me.ci_created_date)
        Me.gb_ci.Controls.Add(Me.ci_txt_email)
        Me.gb_ci.Controls.Add(Me.ci_lbl_email)
        Me.gb_ci.Controls.Add(Me.ci_btn_delete)
        Me.gb_ci.Controls.Add(Me.ci_btn_save)
        Me.gb_ci.Controls.Add(Me.ci_btn_update)
        Me.gb_ci.Controls.Add(Me.adr_txt_zip)
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
        Me.gb_ci.ForeColor = System.Drawing.Color.White
        Me.gb_ci.Name = "gb_ci"
        Me.gb_ci.TabStop = False
        '
        'ci_btn_cancel
        '
        Me.ci_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.ci_btn_cancel, "ci_btn_cancel")
        Me.ci_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.ci_btn_cancel.Name = "ci_btn_cancel"
        Me.ci_btn_cancel.UseVisualStyleBackColor = False
        '
        'adr_txt_state
        '
        resources.ApplyResources(Me.adr_txt_state, "adr_txt_state")
        Me.adr_txt_state.FormattingEnabled = True
        Me.adr_txt_state.Items.AddRange(New Object() {resources.GetString("adr_txt_state.Items"), resources.GetString("adr_txt_state.Items1"), resources.GetString("adr_txt_state.Items2"), resources.GetString("adr_txt_state.Items3"), resources.GetString("adr_txt_state.Items4"), resources.GetString("adr_txt_state.Items5"), resources.GetString("adr_txt_state.Items6"), resources.GetString("adr_txt_state.Items7"), resources.GetString("adr_txt_state.Items8"), resources.GetString("adr_txt_state.Items9"), resources.GetString("adr_txt_state.Items10"), resources.GetString("adr_txt_state.Items11"), resources.GetString("adr_txt_state.Items12"), resources.GetString("adr_txt_state.Items13"), resources.GetString("adr_txt_state.Items14"), resources.GetString("adr_txt_state.Items15"), resources.GetString("adr_txt_state.Items16"), resources.GetString("adr_txt_state.Items17"), resources.GetString("adr_txt_state.Items18"), resources.GetString("adr_txt_state.Items19"), resources.GetString("adr_txt_state.Items20"), resources.GetString("adr_txt_state.Items21"), resources.GetString("adr_txt_state.Items22"), resources.GetString("adr_txt_state.Items23"), resources.GetString("adr_txt_state.Items24"), resources.GetString("adr_txt_state.Items25"), resources.GetString("adr_txt_state.Items26"), resources.GetString("adr_txt_state.Items27"), resources.GetString("adr_txt_state.Items28"), resources.GetString("adr_txt_state.Items29"), resources.GetString("adr_txt_state.Items30"), resources.GetString("adr_txt_state.Items31"), resources.GetString("adr_txt_state.Items32"), resources.GetString("adr_txt_state.Items33"), resources.GetString("adr_txt_state.Items34"), resources.GetString("adr_txt_state.Items35"), resources.GetString("adr_txt_state.Items36"), resources.GetString("adr_txt_state.Items37"), resources.GetString("adr_txt_state.Items38"), resources.GetString("adr_txt_state.Items39"), resources.GetString("adr_txt_state.Items40"), resources.GetString("adr_txt_state.Items41"), resources.GetString("adr_txt_state.Items42"), resources.GetString("adr_txt_state.Items43"), resources.GetString("adr_txt_state.Items44"), resources.GetString("adr_txt_state.Items45"), resources.GetString("adr_txt_state.Items46"), resources.GetString("adr_txt_state.Items47"), resources.GetString("adr_txt_state.Items48"), resources.GetString("adr_txt_state.Items49"), resources.GetString("adr_txt_state.Items50"), resources.GetString("adr_txt_state.Items51"), resources.GetString("adr_txt_state.Items52"), resources.GetString("adr_txt_state.Items53"), resources.GetString("adr_txt_state.Items54"), resources.GetString("adr_txt_state.Items55"), resources.GetString("adr_txt_state.Items56"), resources.GetString("adr_txt_state.Items57"), resources.GetString("adr_txt_state.Items58"), resources.GetString("adr_txt_state.Items59"), resources.GetString("adr_txt_state.Items60"), resources.GetString("adr_txt_state.Items61")})
        Me.adr_txt_state.Name = "adr_txt_state"
        '
        'ci_created_date
        '
        resources.ApplyResources(Me.ci_created_date, "ci_created_date")
        Me.ci_created_date.Name = "ci_created_date"
        Me.ci_created_date.ReadOnly = True
        '
        'ci_txt_email
        '
        resources.ApplyResources(Me.ci_txt_email, "ci_txt_email")
        Me.ci_txt_email.Name = "ci_txt_email"
        Me.ci_txt_email.ReadOnly = True
        '
        'ci_lbl_email
        '
        resources.ApplyResources(Me.ci_lbl_email, "ci_lbl_email")
        Me.ci_lbl_email.Name = "ci_lbl_email"
        '
        'ci_btn_delete
        '
        Me.ci_btn_delete.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.ci_btn_delete, "ci_btn_delete")
        Me.ci_btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_delete.ForeColor = System.Drawing.Color.White
        Me.ci_btn_delete.Name = "ci_btn_delete"
        Me.ci_btn_delete.UseVisualStyleBackColor = False
        '
        'ci_btn_save
        '
        Me.ci_btn_save.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.ci_btn_save, "ci_btn_save")
        Me.ci_btn_save.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_save.ForeColor = System.Drawing.Color.White
        Me.ci_btn_save.Name = "ci_btn_save"
        Me.ci_btn_save.UseVisualStyleBackColor = False
        '
        'ci_btn_update
        '
        Me.ci_btn_update.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.ci_btn_update, "ci_btn_update")
        Me.ci_btn_update.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ci_btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ci_btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.ci_btn_update.ForeColor = System.Drawing.Color.White
        Me.ci_btn_update.Name = "ci_btn_update"
        Me.ci_btn_update.UseVisualStyleBackColor = False
        '
        'adr_txt_zip
        '
        resources.ApplyResources(Me.adr_txt_zip, "adr_txt_zip")
        Me.adr_txt_zip.Name = "adr_txt_zip"
        Me.adr_txt_zip.ReadOnly = True
        '
        'adr_txt_city
        '
        resources.ApplyResources(Me.adr_txt_city, "adr_txt_city")
        Me.adr_txt_city.Name = "adr_txt_city"
        Me.adr_txt_city.ReadOnly = True
        '
        'adr_lbl_zip
        '
        resources.ApplyResources(Me.adr_lbl_zip, "adr_lbl_zip")
        Me.adr_lbl_zip.Name = "adr_lbl_zip"
        '
        'adr_txt_streetadd
        '
        resources.ApplyResources(Me.adr_txt_streetadd, "adr_txt_streetadd")
        Me.adr_txt_streetadd.Name = "adr_txt_streetadd"
        Me.adr_txt_streetadd.ReadOnly = True
        '
        'adr_txt_streetad
        '
        resources.ApplyResources(Me.adr_txt_streetad, "adr_txt_streetad")
        Me.adr_txt_streetad.Name = "adr_txt_streetad"
        Me.adr_txt_streetad.ReadOnly = True
        '
        'adr_lbl_streetad
        '
        resources.ApplyResources(Me.adr_lbl_streetad, "adr_lbl_streetad")
        Me.adr_lbl_streetad.Name = "adr_lbl_streetad"
        '
        'adr_lbl_state
        '
        resources.ApplyResources(Me.adr_lbl_state, "adr_lbl_state")
        Me.adr_lbl_state.Name = "adr_lbl_state"
        '
        'adr_lbl_city
        '
        resources.ApplyResources(Me.adr_lbl_city, "adr_lbl_city")
        Me.adr_lbl_city.Name = "adr_lbl_city"
        '
        'adr_lbl_streetadd
        '
        resources.ApplyResources(Me.adr_lbl_streetadd, "adr_lbl_streetadd")
        Me.adr_lbl_streetadd.Name = "adr_lbl_streetadd"
        '
        'ci_txt_url
        '
        resources.ApplyResources(Me.ci_txt_url, "ci_txt_url")
        Me.ci_txt_url.Name = "ci_txt_url"
        Me.ci_txt_url.ReadOnly = True
        '
        'ci_txt_cellp
        '
        resources.ApplyResources(Me.ci_txt_cellp, "ci_txt_cellp")
        Me.ci_txt_cellp.Name = "ci_txt_cellp"
        Me.ci_txt_cellp.ReadOnly = True
        '
        'ci_txt_officen
        '
        resources.ApplyResources(Me.ci_txt_officen, "ci_txt_officen")
        Me.ci_txt_officen.Name = "ci_txt_officen"
        Me.ci_txt_officen.ReadOnly = True
        '
        'ci_txt_company
        '
        resources.ApplyResources(Me.ci_txt_company, "ci_txt_company")
        Me.ci_txt_company.Name = "ci_txt_company"
        Me.ci_txt_company.ReadOnly = True
        '
        'ci_txt_lname
        '
        resources.ApplyResources(Me.ci_txt_lname, "ci_txt_lname")
        Me.ci_txt_lname.Name = "ci_txt_lname"
        Me.ci_txt_lname.ReadOnly = True
        '
        'ci_lbl_url
        '
        resources.ApplyResources(Me.ci_lbl_url, "ci_lbl_url")
        Me.ci_lbl_url.Name = "ci_lbl_url"
        '
        'ci_lbl_cellp
        '
        resources.ApplyResources(Me.ci_lbl_cellp, "ci_lbl_cellp")
        Me.ci_lbl_cellp.Name = "ci_lbl_cellp"
        '
        'ci_lbl_officen
        '
        resources.ApplyResources(Me.ci_lbl_officen, "ci_lbl_officen")
        Me.ci_lbl_officen.Name = "ci_lbl_officen"
        '
        'ci_lbl_createddate
        '
        resources.ApplyResources(Me.ci_lbl_createddate, "ci_lbl_createddate")
        Me.ci_lbl_createddate.Name = "ci_lbl_createddate"
        '
        'ci_txt_fname
        '
        resources.ApplyResources(Me.ci_txt_fname, "ci_txt_fname")
        Me.ci_txt_fname.Name = "ci_txt_fname"
        Me.ci_txt_fname.ReadOnly = True
        '
        'ci_txt_account
        '
        Me.ci_txt_account.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.ci_txt_account, "ci_txt_account")
        Me.ci_txt_account.Name = "ci_txt_account"
        Me.ci_txt_account.ReadOnly = True
        '
        'ci_lbl_account
        '
        resources.ApplyResources(Me.ci_lbl_account, "ci_lbl_account")
        Me.ci_lbl_account.Name = "ci_lbl_account"
        '
        'ci_lbl_company
        '
        resources.ApplyResources(Me.ci_lbl_company, "ci_lbl_company")
        Me.ci_lbl_company.Name = "ci_lbl_company"
        '
        'ci_lbl_lname
        '
        resources.ApplyResources(Me.ci_lbl_lname, "ci_lbl_lname")
        Me.ci_lbl_lname.Name = "ci_lbl_lname"
        '
        'ci_lbl_fname
        '
        resources.ApplyResources(Me.ci_lbl_fname, "ci_lbl_fname")
        Me.ci_lbl_fname.Name = "ci_lbl_fname"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.btnCreate, "btnCreate")
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'tabEmp
        '
        resources.ApplyResources(Me.tabEmp, "tabEmp")
        Me.tabEmp.BackColor = System.Drawing.Color.SlateGray
        Me.tabEmp.Controls.Add(Me.emp_btn_cancel)
        Me.tabEmp.Controls.Add(Me.emp_btn_load)
        Me.tabEmp.Controls.Add(Me.emp_lv)
        Me.tabEmp.Controls.Add(Me.emp_btn_delete)
        Me.tabEmp.Controls.Add(Me.emp_btn_add)
        Me.tabEmp.ForeColor = System.Drawing.Color.White
        Me.tabEmp.Name = "tabEmp"
        '
        'emp_btn_cancel
        '
        Me.emp_btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.emp_btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.emp_btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.emp_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.emp_btn_cancel, "emp_btn_cancel")
        Me.emp_btn_cancel.ForeColor = System.Drawing.Color.White
        Me.emp_btn_cancel.Name = "emp_btn_cancel"
        Me.emp_btn_cancel.UseVisualStyleBackColor = False
        '
        'emp_btn_load
        '
        Me.emp_btn_load.BackColor = System.Drawing.Color.LightSlateGray
        Me.emp_btn_load.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.emp_btn_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.emp_btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.emp_btn_load, "emp_btn_load")
        Me.emp_btn_load.ForeColor = System.Drawing.Color.White
        Me.emp_btn_load.Name = "emp_btn_load"
        Me.emp_btn_load.UseVisualStyleBackColor = False
        '
        'emp_lv
        '
        Me.emp_lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.emp_lb_employeeid, Me.emp_lb_fname, Me.emp_lb_lname, Me.emp_lb_phone, Me.emp_lb_})
        resources.ApplyResources(Me.emp_lv, "emp_lv")
        Me.emp_lv.Name = "emp_lv"
        Me.emp_lv.UseCompatibleStateImageBehavior = False
        Me.emp_lv.View = System.Windows.Forms.View.Details
        '
        'emp_lb_employeeid
        '
        resources.ApplyResources(Me.emp_lb_employeeid, "emp_lb_employeeid")
        '
        'emp_lb_fname
        '
        resources.ApplyResources(Me.emp_lb_fname, "emp_lb_fname")
        '
        'emp_lb_lname
        '
        resources.ApplyResources(Me.emp_lb_lname, "emp_lb_lname")
        '
        'emp_lb_phone
        '
        resources.ApplyResources(Me.emp_lb_phone, "emp_lb_phone")
        '
        'emp_lb_
        '
        resources.ApplyResources(Me.emp_lb_, "emp_lb_")
        '
        'emp_btn_delete
        '
        Me.emp_btn_delete.BackColor = System.Drawing.Color.LightSlateGray
        Me.emp_btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.emp_btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.emp_btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.emp_btn_delete, "emp_btn_delete")
        Me.emp_btn_delete.ForeColor = System.Drawing.Color.White
        Me.emp_btn_delete.Name = "emp_btn_delete"
        Me.emp_btn_delete.UseVisualStyleBackColor = False
        '
        'emp_btn_add
        '
        Me.emp_btn_add.BackColor = System.Drawing.Color.LightSlateGray
        Me.emp_btn_add.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.emp_btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.emp_btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.emp_btn_add, "emp_btn_add")
        Me.emp_btn_add.ForeColor = System.Drawing.Color.White
        Me.emp_btn_add.Name = "emp_btn_add"
        Me.emp_btn_add.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.Controls.Add(Me.dashboard_tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.dashboard_tab.ResumeLayout(False)
        Me.tabClient.ResumeLayout(False)
        Me.tabClient.PerformLayout()
        Me.gb_activities.ResumeLayout(False)
        Me.gb_ci.ResumeLayout(False)
        Me.gb_ci.PerformLayout()
        Me.tabEmp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashboard_tab As TabControl
    Friend WithEvents tabClient As TabPage
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents gb_ci As GroupBox
    Friend WithEvents gb_activities As GroupBox
    Friend WithEvents ci_lbl_lname As Label
    Friend WithEvents ci_lbl_fname As Label
    Friend WithEvents ci_lbl_account As Label
    Friend WithEvents ci_lbl_company As Label
    Friend WithEvents ci_txt_fname As TextBox
    Friend WithEvents ci_txt_account As TextBox
    Friend WithEvents ci_lbl_createddate As Label
    Friend WithEvents ci_lbl_url As Label
    Friend WithEvents ci_lbl_cellp As Label
    Friend WithEvents ci_txt_url As TextBox
    Friend WithEvents ci_txt_cellp As TextBox
    Friend WithEvents ci_txt_officen As TextBox
    Friend WithEvents ci_txt_company As TextBox
    Friend WithEvents ci_txt_lname As TextBox
    Friend WithEvents ci_lbl_officen As Label
    Friend WithEvents act_btn_create As Button
    Friend WithEvents ci_btn_update As Button
    Friend WithEvents adr_txt_zip As TextBox
    Friend WithEvents adr_txt_city As TextBox
    Friend WithEvents adr_lbl_zip As Label
    Friend WithEvents adr_txt_streetadd As TextBox
    Friend WithEvents adr_txt_streetad As TextBox
    Friend WithEvents adr_lbl_streetad As Label
    Friend WithEvents adr_lbl_state As Label
    Friend WithEvents adr_lbl_city As Label
    Friend WithEvents adr_lbl_streetadd As Label
    Friend WithEvents tabEmp As TabPage
    Friend WithEvents emp_btn_delete As Button
    Friend WithEvents emp_btn_add As Button
    Friend WithEvents ci_btn_save As Button
    Friend WithEvents ci_btn_delete As Button
    Friend WithEvents act_lv As ListView
    Friend WithEvents act_lb_activity As ColumnHeader
    Friend WithEvents act_lb_type As ColumnHeader
    Friend WithEvents act_lb_status As ColumnHeader
    Friend WithEvents act_lb_addedon As ColumnHeader
    Friend WithEvents act_lb_lastmodified As ColumnHeader
    Friend WithEvents act_lb_employee As ColumnHeader
    Friend WithEvents act_lb_comment As ColumnHeader
    Friend WithEvents emp_lv As ListView
    Friend WithEvents emp_lb_employeeid As ColumnHeader
    Friend WithEvents emp_lb_fname As ColumnHeader
    Friend WithEvents emp_lb_lname As ColumnHeader
    Friend WithEvents emp_lb_phone As ColumnHeader
    Friend WithEvents emp_lb_ As ColumnHeader
    Friend WithEvents ci_txt_email As TextBox
    Friend WithEvents ci_lbl_email As Label
    Friend WithEvents ci_created_date As MaskedTextBox
    Friend WithEvents adr_txt_state As ComboBox
    Friend WithEvents ci_btn_cancel As Button
    Friend WithEvents emp_btn_load As Button
    Friend WithEvents emp_btn_cancel As Button
End Class
