<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.colMatType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMatChange = New System.Windows.Forms.Button()
        Me.gbMatList = New System.Windows.Forms.GroupBox()
        Me.gvMat = New System.Windows.Forms.DataGridView()
        Me.colMatCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMatValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldOnlineDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldTotalUsageQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldUsageQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMouldStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMouldOffline = New System.Windows.Forms.Button()
        Me.btnMouldOnline = New System.Windows.Forms.Button()
        Me.gvMould = New System.Windows.Forms.DataGridView()
        Me.gbMouldInfo = New System.Windows.Forms.GroupBox()
        Me.txtReplyJson_MouldQry = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReplyJson_Connection = New System.Windows.Forms.TextBox()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.txtReplyJson_JustFail = New System.Windows.Forms.TextBox()
        Me.tpReturnNG = New System.Windows.Forms.TabPage()
        Me.txtReplyJson_JustOK = New System.Windows.Forms.TextBox()
        Me.txtWONO = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.gvNGList = New System.Windows.Forms.DataGridView()
        Me.colNGCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNGCHName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtWOOutQty = New System.Windows.Forms.TextBox()
        Me.labWOOutQty = New System.Windows.Forms.Label()
        Me.txtRecipeID = New System.Windows.Forms.TextBox()
        Me.labRecipeID = New System.Windows.Forms.Label()
        Me.txtWOQty = New System.Windows.Forms.TextBox()
        Me.lblWOQty = New System.Windows.Forms.Label()
        Me.txtWorkCenterName = New System.Windows.Forms.TextBox()
        Me.lblWorkCenterName = New System.Windows.Forms.Label()
        Me.txtWorkCenterNo = New System.Windows.Forms.TextBox()
        Me.lblWorkCenterNo = New System.Windows.Forms.Label()
        Me.txtPartNo = New System.Windows.Forms.TextBox()
        Me.lblPartNo = New System.Windows.Forms.Label()
        Me.lblWONO = New System.Windows.Forms.Label()
        Me.gbWOInfo = New System.Windows.Forms.GroupBox()
        Me.btnUserIDChange = New System.Windows.Forms.Button()
        Me.gbUserID = New System.Windows.Forms.GroupBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.tpReturnOK = New System.Windows.Forms.TabPage()
        Me.txtReplyJson_WOPARMQRY = New System.Windows.Forms.TextBox()
        Me.InputCodeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvInputCode = New System.Windows.Forms.DataGridView()
        Me.InputCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputCodeValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputCodeRequiredInput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputCodeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputCodeDataItemList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbManagementItem = New System.Windows.Forms.GroupBox()
        Me.colWOlistWorkOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvACWorkOrder = New System.Windows.Forms.DataGridView()
        Me.gbWOList = New System.Windows.Forms.GroupBox()
        Me.txtResultCode = New System.Windows.Forms.TextBox()
        Me.labResultCode = New System.Windows.Forms.Label()
        Me.txtResultMessage = New System.Windows.Forms.TextBox()
        Me.labResultMessage = New System.Windows.Forms.Label()
        Me.btnMESOnline = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.labResult = New System.Windows.Forms.Label()
        Me.btnEqpCheck = New System.Windows.Forms.Button()
        Me.gbResult = New System.Windows.Forms.GroupBox()
        Me.btnMESSetting = New System.Windows.Forms.Button()
        Me.btnWOQry = New System.Windows.Forms.Button()
        Me.btnWOCheckOut = New System.Windows.Forms.Button()
        Me.btnWOCheckIn = New System.Windows.Forms.Button()
        Me.txtReplyJson_WoQry = New System.Windows.Forms.TextBox()
        Me.tpWOQry = New System.Windows.Forms.TabPage()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tpWORecipeQry = New System.Windows.Forms.TabPage()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdiTest = New System.Windows.Forms.RadioButton()
        Me.rdiProduction = New System.Windows.Forms.RadioButton()
        Me.gbModeChange = New System.Windows.Forms.GroupBox()
        Me.rdiFail = New System.Windows.Forms.RadioButton()
        Me.rdiSuccess = New System.Windows.Forms.RadioButton()
        Me.gbTestResultType = New System.Windows.Forms.GroupBox()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.ParamInputType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Required = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParamValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParamCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvParam = New System.Windows.Forms.DataGridView()
        Me.ParamComboDataList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbParam = New System.Windows.Forms.GroupBox()
        Me.gbMatList.SuspendLayout()
        CType(Me.gvMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMould, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMouldInfo.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tpReturnNG.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.gvNGList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWOInfo.SuspendLayout()
        Me.gbUserID.SuspendLayout()
        Me.tpReturnOK.SuspendLayout()
        CType(Me.gvInputCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbManagementItem.SuspendLayout()
        CType(Me.gvACWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWOList.SuspendLayout()
        Me.gbResult.SuspendLayout()
        Me.tpWOQry.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tpWORecipeQry.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.gbModeChange.SuspendLayout()
        Me.gbTestResultType.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        CType(Me.gvParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParam.SuspendLayout()
        Me.SuspendLayout()
        '
        'colMatType
        '
        Me.colMatType.HeaderText = "物料類型"
        Me.colMatType.Name = "colMatType"
        Me.colMatType.ReadOnly = True
        '
        'btnMatChange
        '
        Me.btnMatChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatChange.Location = New System.Drawing.Point(759, 21)
        Me.btnMatChange.Name = "btnMatChange"
        Me.btnMatChange.Size = New System.Drawing.Size(88, 45)
        Me.btnMatChange.TabIndex = 48
        Me.btnMatChange.Text = "更換(MatChange)"
        Me.btnMatChange.UseVisualStyleBackColor = True
        '
        'gbMatList
        '
        Me.gbMatList.Controls.Add(Me.btnMatChange)
        Me.gbMatList.Controls.Add(Me.gvMat)
        Me.gbMatList.Location = New System.Drawing.Point(11, 699)
        Me.gbMatList.Name = "gbMatList"
        Me.gbMatList.Size = New System.Drawing.Size(858, 112)
        Me.gbMatList.TabIndex = 85
        Me.gbMatList.TabStop = False
        Me.gbMatList.Text = "物料清單(Mat item)"
        '
        'gvMat
        '
        Me.gvMat.AllowUserToAddRows = False
        Me.gvMat.AllowUserToDeleteRows = False
        Me.gvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMatType, Me.colMatCode, Me.colMatValue})
        Me.gvMat.Location = New System.Drawing.Point(16, 21)
        Me.gvMat.Name = "gvMat"
        Me.gvMat.ReadOnly = True
        Me.gvMat.RowTemplate.Height = 24
        Me.gvMat.Size = New System.Drawing.Size(737, 85)
        Me.gvMat.TabIndex = 1
        '
        'colMatCode
        '
        Me.colMatCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMatCode.HeaderText = "物料代碼"
        Me.colMatCode.Name = "colMatCode"
        Me.colMatCode.ReadOnly = True
        '
        'colMatValue
        '
        Me.colMatValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMatValue.HeaderText = "物料編號"
        Me.colMatValue.Name = "colMatValue"
        Me.colMatValue.ReadOnly = True
        Me.colMatValue.Width = 450
        '
        'colMouldNo
        '
        Me.colMouldNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMouldNo.HeaderText = "模具編號"
        Me.colMouldNo.Name = "colMouldNo"
        Me.colMouldNo.ReadOnly = True
        Me.colMouldNo.Width = 220
        '
        'colMouldOnlineDate
        '
        Me.colMouldOnlineDate.HeaderText = "上線時間"
        Me.colMouldOnlineDate.Name = "colMouldOnlineDate"
        Me.colMouldOnlineDate.ReadOnly = True
        '
        'colMouldTotalUsageQty
        '
        Me.colMouldTotalUsageQty.HeaderText = "總使用次數"
        Me.colMouldTotalUsageQty.Name = "colMouldTotalUsageQty"
        Me.colMouldTotalUsageQty.ReadOnly = True
        '
        'colMouldUsageQty
        '
        Me.colMouldUsageQty.HeaderText = "已使用次數"
        Me.colMouldUsageQty.Name = "colMouldUsageQty"
        Me.colMouldUsageQty.ReadOnly = True
        '
        'colMouldType
        '
        Me.colMouldType.HeaderText = "類型"
        Me.colMouldType.Name = "colMouldType"
        Me.colMouldType.ReadOnly = True
        '
        'colMouldStatus
        '
        Me.colMouldStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMouldStatus.HeaderText = "狀態"
        Me.colMouldStatus.Name = "colMouldStatus"
        Me.colMouldStatus.ReadOnly = True
        Me.colMouldStatus.Width = 70
        '
        'btnMouldOffline
        '
        Me.btnMouldOffline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMouldOffline.Location = New System.Drawing.Point(488, 71)
        Me.btnMouldOffline.Name = "btnMouldOffline"
        Me.btnMouldOffline.Size = New System.Drawing.Size(88, 45)
        Me.btnMouldOffline.TabIndex = 49
        Me.btnMouldOffline.Text = "下線(MouldOffline)"
        Me.btnMouldOffline.UseVisualStyleBackColor = True
        '
        'btnMouldOnline
        '
        Me.btnMouldOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMouldOnline.Location = New System.Drawing.Point(488, 21)
        Me.btnMouldOnline.Name = "btnMouldOnline"
        Me.btnMouldOnline.Size = New System.Drawing.Size(88, 45)
        Me.btnMouldOnline.TabIndex = 48
        Me.btnMouldOnline.Text = "上線(MouldOnline)"
        Me.btnMouldOnline.UseVisualStyleBackColor = True
        '
        'gvMould
        '
        Me.gvMould.AllowUserToAddRows = False
        Me.gvMould.AllowUserToDeleteRows = False
        Me.gvMould.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMould.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMouldStatus, Me.colMouldType, Me.colMouldUsageQty, Me.colMouldTotalUsageQty, Me.colMouldOnlineDate, Me.colMouldNo})
        Me.gvMould.Location = New System.Drawing.Point(16, 21)
        Me.gvMould.Name = "gvMould"
        Me.gvMould.ReadOnly = True
        Me.gvMould.RowTemplate.Height = 24
        Me.gvMould.Size = New System.Drawing.Size(466, 144)
        Me.gvMould.TabIndex = 1
        '
        'gbMouldInfo
        '
        Me.gbMouldInfo.Controls.Add(Me.btnMouldOffline)
        Me.gbMouldInfo.Controls.Add(Me.btnMouldOnline)
        Me.gbMouldInfo.Controls.Add(Me.gvMould)
        Me.gbMouldInfo.Location = New System.Drawing.Point(282, 513)
        Me.gbMouldInfo.Name = "gbMouldInfo"
        Me.gbMouldInfo.Size = New System.Drawing.Size(582, 180)
        Me.gbMouldInfo.TabIndex = 84
        Me.gbMouldInfo.TabStop = False
        Me.gbMouldInfo.Text = "模具清單(Mould item)"
        '
        'txtReplyJson_MouldQry
        '
        Me.txtReplyJson_MouldQry.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_MouldQry.Location = New System.Drawing.Point(6, 6)
        Me.txtReplyJson_MouldQry.Multiline = True
        Me.txtReplyJson_MouldQry.Name = "txtReplyJson_MouldQry"
        Me.txtReplyJson_MouldQry.Size = New System.Drawing.Size(401, 353)
        Me.txtReplyJson_MouldQry.TabIndex = 41
        Me.txtReplyJson_MouldQry.Text = "{""Result"":""success"",""ResultCode"":"""",""Message"":""模具查詢成功！"",""UsageQty"":""1000"",""TotalU" &
    "sageQty"":""2000""}"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.txtReplyJson_MouldQry)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(413, 365)
        Me.tabPage2.TabIndex = 5
        Me.tabPage2.Text = "MouldQry"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'txtReplyJson_Connection
        '
        Me.txtReplyJson_Connection.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_Connection.Location = New System.Drawing.Point(6, 6)
        Me.txtReplyJson_Connection.Multiline = True
        Me.txtReplyJson_Connection.Name = "txtReplyJson_Connection"
        Me.txtReplyJson_Connection.Size = New System.Drawing.Size(401, 353)
        Me.txtReplyJson_Connection.TabIndex = 40
        Me.txtReplyJson_Connection.Text = resources.GetString("txtReplyJson_Connection.Text")
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.txtReplyJson_Connection)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(413, 365)
        Me.tabPage1.TabIndex = 4
        Me.tabPage1.Text = "Connection"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'txtReplyJson_JustFail
        '
        Me.txtReplyJson_JustFail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_JustFail.Location = New System.Drawing.Point(6, 6)
        Me.txtReplyJson_JustFail.Multiline = True
        Me.txtReplyJson_JustFail.Name = "txtReplyJson_JustFail"
        Me.txtReplyJson_JustFail.Size = New System.Drawing.Size(401, 353)
        Me.txtReplyJson_JustFail.TabIndex = 42
        Me.txtReplyJson_JustFail.Text = "{""Result"":""fail"",""ResultCode"":""ERROR0089"",""Message"":""此機台編號『XXX』狀態異常 !""}"
        '
        'tpReturnNG
        '
        Me.tpReturnNG.Controls.Add(Me.txtReplyJson_JustFail)
        Me.tpReturnNG.Location = New System.Drawing.Point(4, 22)
        Me.tpReturnNG.Name = "tpReturnNG"
        Me.tpReturnNG.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReturnNG.Size = New System.Drawing.Size(413, 365)
        Me.tpReturnNG.TabIndex = 3
        Me.tpReturnNG.Text = "Return NG"
        Me.tpReturnNG.UseVisualStyleBackColor = True
        '
        'txtReplyJson_JustOK
        '
        Me.txtReplyJson_JustOK.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_JustOK.Location = New System.Drawing.Point(6, 13)
        Me.txtReplyJson_JustOK.Multiline = True
        Me.txtReplyJson_JustOK.Name = "txtReplyJson_JustOK"
        Me.txtReplyJson_JustOK.Size = New System.Drawing.Size(401, 346)
        Me.txtReplyJson_JustOK.TabIndex = 41
        Me.txtReplyJson_JustOK.Text = "{""Result"":""success"",""ResultCode"":"""",""Message"":""""}"
        '
        'txtWONO
        '
        Me.txtWONO.Location = New System.Drawing.Point(121, 30)
        Me.txtWONO.Name = "txtWONO"
        Me.txtWONO.Size = New System.Drawing.Size(150, 22)
        Me.txtWONO.TabIndex = 57
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.gvNGList)
        Me.groupBox1.Location = New System.Drawing.Point(294, 57)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(361, 203)
        Me.groupBox1.TabIndex = 70
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "NGList"
        '
        'gvNGList
        '
        Me.gvNGList.AllowUserToAddRows = False
        Me.gvNGList.AllowUserToDeleteRows = False
        Me.gvNGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvNGList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNGCode, Me.colNGCHName, Me.colQty})
        Me.gvNGList.Location = New System.Drawing.Point(16, 18)
        Me.gvNGList.Name = "gvNGList"
        Me.gvNGList.RowTemplate.Height = 24
        Me.gvNGList.Size = New System.Drawing.Size(325, 169)
        Me.gvNGList.TabIndex = 0
        '
        'colNGCode
        '
        Me.colNGCode.HeaderText = "NGCode"
        Me.colNGCode.Name = "colNGCode"
        Me.colNGCode.Visible = False
        '
        'colNGCHName
        '
        Me.colNGCHName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colNGCHName.HeaderText = "NG Chinese Name"
        Me.colNGCHName.Name = "colNGCHName"
        Me.colNGCHName.Width = 140
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        '
        'txtWOOutQty
        '
        Me.txtWOOutQty.Location = New System.Drawing.Point(378, 27)
        Me.txtWOOutQty.Name = "txtWOOutQty"
        Me.txtWOOutQty.ReadOnly = True
        Me.txtWOOutQty.Size = New System.Drawing.Size(150, 22)
        Me.txtWOOutQty.TabIndex = 69
        '
        'labWOOutQty
        '
        Me.labWOOutQty.AutoSize = True
        Me.labWOOutQty.Location = New System.Drawing.Point(297, 33)
        Me.labWOOutQty.Name = "labWOOutQty"
        Me.labWOOutQty.Size = New System.Drawing.Size(70, 12)
        Me.labWOOutQty.TabIndex = 68
        Me.labWOOutQty.Text = "WOOutQty："
        '
        'txtRecipeID
        '
        Me.txtRecipeID.Location = New System.Drawing.Point(121, 195)
        Me.txtRecipeID.Name = "txtRecipeID"
        Me.txtRecipeID.ReadOnly = True
        Me.txtRecipeID.Size = New System.Drawing.Size(150, 22)
        Me.txtRecipeID.TabIndex = 67
        '
        'labRecipeID
        '
        Me.labRecipeID.AutoSize = True
        Me.labRecipeID.Location = New System.Drawing.Point(49, 200)
        Me.labRecipeID.Name = "labRecipeID"
        Me.labRecipeID.Size = New System.Drawing.Size(61, 12)
        Me.labRecipeID.TabIndex = 66
        Me.labRecipeID.Text = "RecipeID："
        '
        'txtWOQty
        '
        Me.txtWOQty.Location = New System.Drawing.Point(121, 162)
        Me.txtWOQty.Name = "txtWOQty"
        Me.txtWOQty.ReadOnly = True
        Me.txtWOQty.Size = New System.Drawing.Size(150, 22)
        Me.txtWOQty.TabIndex = 65
        '
        'lblWOQty
        '
        Me.lblWOQty.AutoSize = True
        Me.lblWOQty.Location = New System.Drawing.Point(55, 168)
        Me.lblWOQty.Name = "lblWOQty"
        Me.lblWOQty.Size = New System.Drawing.Size(55, 12)
        Me.lblWOQty.TabIndex = 64
        Me.lblWOQty.Text = "WIPQty："
        '
        'txtWorkCenterName
        '
        Me.txtWorkCenterName.Location = New System.Drawing.Point(121, 130)
        Me.txtWorkCenterName.Name = "txtWorkCenterName"
        Me.txtWorkCenterName.ReadOnly = True
        Me.txtWorkCenterName.Size = New System.Drawing.Size(150, 22)
        Me.txtWorkCenterName.TabIndex = 63
        '
        'lblWorkCenterName
        '
        Me.lblWorkCenterName.AutoSize = True
        Me.lblWorkCenterName.Location = New System.Drawing.Point(8, 135)
        Me.lblWorkCenterName.Name = "lblWorkCenterName"
        Me.lblWorkCenterName.Size = New System.Drawing.Size(102, 12)
        Me.lblWorkCenterName.TabIndex = 62
        Me.lblWorkCenterName.Text = "WorkCenterName："
        '
        'txtWorkCenterNo
        '
        Me.txtWorkCenterNo.Location = New System.Drawing.Point(121, 98)
        Me.txtWorkCenterNo.Name = "txtWorkCenterNo"
        Me.txtWorkCenterNo.ReadOnly = True
        Me.txtWorkCenterNo.Size = New System.Drawing.Size(150, 22)
        Me.txtWorkCenterNo.TabIndex = 61
        '
        'lblWorkCenterNo
        '
        Me.lblWorkCenterNo.AutoSize = True
        Me.lblWorkCenterNo.Location = New System.Drawing.Point(21, 103)
        Me.lblWorkCenterNo.Name = "lblWorkCenterNo"
        Me.lblWorkCenterNo.Size = New System.Drawing.Size(89, 12)
        Me.lblWorkCenterNo.TabIndex = 60
        Me.lblWorkCenterNo.Text = "WorkCenterNo："
        '
        'txtPartNo
        '
        Me.txtPartNo.Location = New System.Drawing.Point(121, 65)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.ReadOnly = True
        Me.txtPartNo.Size = New System.Drawing.Size(150, 22)
        Me.txtPartNo.TabIndex = 59
        '
        'lblPartNo
        '
        Me.lblPartNo.AutoSize = True
        Me.lblPartNo.Location = New System.Drawing.Point(61, 68)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(49, 12)
        Me.lblPartNo.TabIndex = 58
        Me.lblPartNo.Text = "MatNo："
        '
        'lblWONO
        '
        Me.lblWONO.AutoSize = True
        Me.lblWONO.Location = New System.Drawing.Point(40, 37)
        Me.lblWONO.Name = "lblWONO"
        Me.lblWONO.Size = New System.Drawing.Size(71, 12)
        Me.lblWONO.TabIndex = 56
        Me.lblWONO.Text = "WorkOrder："
        '
        'gbWOInfo
        '
        Me.gbWOInfo.Controls.Add(Me.groupBox1)
        Me.gbWOInfo.Controls.Add(Me.txtWOOutQty)
        Me.gbWOInfo.Controls.Add(Me.labWOOutQty)
        Me.gbWOInfo.Controls.Add(Me.txtRecipeID)
        Me.gbWOInfo.Controls.Add(Me.labRecipeID)
        Me.gbWOInfo.Controls.Add(Me.txtWOQty)
        Me.gbWOInfo.Controls.Add(Me.lblWOQty)
        Me.gbWOInfo.Controls.Add(Me.txtWorkCenterName)
        Me.gbWOInfo.Controls.Add(Me.lblWorkCenterName)
        Me.gbWOInfo.Controls.Add(Me.txtWorkCenterNo)
        Me.gbWOInfo.Controls.Add(Me.lblWorkCenterNo)
        Me.gbWOInfo.Controls.Add(Me.txtPartNo)
        Me.gbWOInfo.Controls.Add(Me.lblPartNo)
        Me.gbWOInfo.Controls.Add(Me.txtWONO)
        Me.gbWOInfo.Controls.Add(Me.lblWONO)
        Me.gbWOInfo.Location = New System.Drawing.Point(11, 71)
        Me.gbWOInfo.Name = "gbWOInfo"
        Me.gbWOInfo.Size = New System.Drawing.Size(661, 268)
        Me.gbWOInfo.TabIndex = 86
        Me.gbWOInfo.TabStop = False
        Me.gbWOInfo.Text = "工單訊息"
        '
        'btnUserIDChange
        '
        Me.btnUserIDChange.Location = New System.Drawing.Point(271, 18)
        Me.btnUserIDChange.Name = "btnUserIDChange"
        Me.btnUserIDChange.Size = New System.Drawing.Size(80, 22)
        Me.btnUserIDChange.TabIndex = 72
        Me.btnUserIDChange.Text = "更換"
        Me.btnUserIDChange.UseVisualStyleBackColor = True
        '
        'gbUserID
        '
        Me.gbUserID.Controls.Add(Me.btnUserIDChange)
        Me.gbUserID.Controls.Add(Me.txtUserID)
        Me.gbUserID.Location = New System.Drawing.Point(11, 9)
        Me.gbUserID.Name = "gbUserID"
        Me.gbUserID.Size = New System.Drawing.Size(661, 53)
        Me.gbUserID.TabIndex = 87
        Me.gbUserID.TabStop = False
        Me.gbUserID.Text = "當前作業人員"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(15, 18)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(250, 22)
        Me.txtUserID.TabIndex = 33
        '
        'tpReturnOK
        '
        Me.tpReturnOK.Controls.Add(Me.txtReplyJson_JustOK)
        Me.tpReturnOK.Location = New System.Drawing.Point(4, 22)
        Me.tpReturnOK.Name = "tpReturnOK"
        Me.tpReturnOK.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReturnOK.Size = New System.Drawing.Size(413, 365)
        Me.tpReturnOK.TabIndex = 2
        Me.tpReturnOK.Text = "return OK"
        Me.tpReturnOK.UseVisualStyleBackColor = True
        '
        'txtReplyJson_WOPARMQRY
        '
        Me.txtReplyJson_WOPARMQRY.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_WOPARMQRY.Location = New System.Drawing.Point(6, 6)
        Me.txtReplyJson_WOPARMQRY.Multiline = True
        Me.txtReplyJson_WOPARMQRY.Name = "txtReplyJson_WOPARMQRY"
        Me.txtReplyJson_WOPARMQRY.Size = New System.Drawing.Size(401, 353)
        Me.txtReplyJson_WOPARMQRY.TabIndex = 40
        Me.txtReplyJson_WOPARMQRY.Text = "{""ParamName"":""RECIPEID"",""ParamValue"":""#1"",""UpperValue"":"""",""LowerValue"":"""",""Result" &
    """:""success"",""ResultCode"":"""",""Message"":""""}"
        '
        'InputCodeName
        '
        Me.InputCodeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.InputCodeName.HeaderText = "管理項目名稱(Manage item name)"
        Me.InputCodeName.Name = "InputCodeName"
        '
        'gvInputCode
        '
        Me.gvInputCode.AllowUserToAddRows = False
        Me.gvInputCode.AllowUserToDeleteRows = False
        Me.gvInputCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvInputCode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InputCode, Me.InputCodeName, Me.InputCodeValue, Me.InputCodeRequiredInput, Me.InputCodeType, Me.InputCodeDataItemList})
        Me.gvInputCode.Location = New System.Drawing.Point(16, 18)
        Me.gvInputCode.Name = "gvInputCode"
        Me.gvInputCode.RowTemplate.Height = 24
        Me.gvInputCode.Size = New System.Drawing.Size(385, 137)
        Me.gvInputCode.TabIndex = 0
        '
        'InputCode
        '
        Me.InputCode.HeaderText = "WOInputCode"
        Me.InputCode.Name = "InputCode"
        Me.InputCode.Visible = False
        '
        'InputCodeValue
        '
        Me.InputCodeValue.HeaderText = "管理項目值(Manage item values)"
        Me.InputCodeValue.Name = "InputCodeValue"
        '
        'InputCodeRequiredInput
        '
        Me.InputCodeRequiredInput.HeaderText = "需輸入?(Must enter?)"
        Me.InputCodeRequiredInput.Name = "InputCodeRequiredInput"
        Me.InputCodeRequiredInput.ReadOnly = True
        Me.InputCodeRequiredInput.Width = 80
        '
        'InputCodeType
        '
        Me.InputCodeType.HeaderText = "輸入類型(Input type)"
        Me.InputCodeType.Name = "InputCodeType"
        Me.InputCodeType.Width = 80
        '
        'InputCodeDataItemList
        '
        Me.InputCodeDataItemList.HeaderText = "資料清單(List of information)"
        Me.InputCodeDataItemList.Name = "InputCodeDataItemList"
        '
        'gbManagementItem
        '
        Me.gbManagementItem.Controls.Add(Me.gvInputCode)
        Me.gbManagementItem.Location = New System.Drawing.Point(11, 345)
        Me.gbManagementItem.Name = "gbManagementItem"
        Me.gbManagementItem.Size = New System.Drawing.Size(407, 162)
        Me.gbManagementItem.TabIndex = 81
        Me.gbManagementItem.TabStop = False
        Me.gbManagementItem.Text = "管理項目(Management item)"
        '
        'colWOlistWorkOrder
        '
        Me.colWOlistWorkOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colWOlistWorkOrder.HeaderText = "工單號碼(WorkOrder)"
        Me.colWOlistWorkOrder.Name = "colWOlistWorkOrder"
        Me.colWOlistWorkOrder.ReadOnly = True
        Me.colWOlistWorkOrder.Width = 150
        '
        'gvACWorkOrder
        '
        Me.gvACWorkOrder.AllowUserToAddRows = False
        Me.gvACWorkOrder.AllowUserToDeleteRows = False
        Me.gvACWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvACWorkOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWOlistWorkOrder})
        Me.gvACWorkOrder.Location = New System.Drawing.Point(16, 18)
        Me.gvACWorkOrder.Name = "gvACWorkOrder"
        Me.gvACWorkOrder.ReadOnly = True
        Me.gvACWorkOrder.RowTemplate.Height = 24
        Me.gvACWorkOrder.Size = New System.Drawing.Size(233, 147)
        Me.gvACWorkOrder.TabIndex = 0
        '
        'gbWOList
        '
        Me.gbWOList.Controls.Add(Me.gvACWorkOrder)
        Me.gbWOList.Location = New System.Drawing.Point(11, 513)
        Me.gbWOList.Name = "gbWOList"
        Me.gbWOList.Size = New System.Drawing.Size(265, 180)
        Me.gbWOList.TabIndex = 80
        Me.gbWOList.TabStop = False
        Me.gbWOList.Text = "已進站工單(aleardy Check WorkOrder)"
        '
        'txtResultCode
        '
        Me.txtResultCode.Location = New System.Drawing.Point(111, 62)
        Me.txtResultCode.Name = "txtResultCode"
        Me.txtResultCode.ReadOnly = True
        Me.txtResultCode.Size = New System.Drawing.Size(150, 22)
        Me.txtResultCode.TabIndex = 37
        '
        'labResultCode
        '
        Me.labResultCode.Location = New System.Drawing.Point(13, 67)
        Me.labResultCode.Name = "labResultCode"
        Me.labResultCode.Size = New System.Drawing.Size(87, 12)
        Me.labResultCode.TabIndex = 36
        Me.labResultCode.Text = "ResultCode："
        Me.labResultCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResultMessage
        '
        Me.txtResultMessage.Location = New System.Drawing.Point(111, 103)
        Me.txtResultMessage.Multiline = True
        Me.txtResultMessage.Name = "txtResultMessage"
        Me.txtResultMessage.ReadOnly = True
        Me.txtResultMessage.Size = New System.Drawing.Size(736, 62)
        Me.txtResultMessage.TabIndex = 35
        '
        'labResultMessage
        '
        Me.labResultMessage.Location = New System.Drawing.Point(13, 110)
        Me.labResultMessage.Name = "labResultMessage"
        Me.labResultMessage.Size = New System.Drawing.Size(88, 12)
        Me.labResultMessage.TabIndex = 34
        Me.labResultMessage.Text = "ResultMessage："
        Me.labResultMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMESOnline
        '
        Me.btnMESOnline.Location = New System.Drawing.Point(696, 10)
        Me.btnMESOnline.Name = "btnMESOnline"
        Me.btnMESOnline.Size = New System.Drawing.Size(168, 32)
        Me.btnMESOnline.TabIndex = 79
        Me.btnMESOnline.Text = "MES 連線測試  (MES Connection)"
        Me.btnMESOnline.UseVisualStyleBackColor = True
        '
        'timer1
        '
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(111, 21)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(150, 22)
        Me.txtResult.TabIndex = 33
        '
        'labResult
        '
        Me.labResult.Location = New System.Drawing.Point(13, 28)
        Me.labResult.Name = "labResult"
        Me.labResult.Size = New System.Drawing.Size(88, 12)
        Me.labResult.TabIndex = 32
        Me.labResult.Text = "Result："
        Me.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEqpCheck
        '
        Me.btnEqpCheck.Location = New System.Drawing.Point(696, 230)
        Me.btnEqpCheck.Name = "btnEqpCheck"
        Me.btnEqpCheck.Size = New System.Drawing.Size(168, 23)
        Me.btnEqpCheck.TabIndex = 78
        Me.btnEqpCheck.Text = "設備點檢(EqpCheck)"
        Me.btnEqpCheck.UseVisualStyleBackColor = True
        '
        'gbResult
        '
        Me.gbResult.Controls.Add(Me.txtResultCode)
        Me.gbResult.Controls.Add(Me.labResultCode)
        Me.gbResult.Controls.Add(Me.txtResultMessage)
        Me.gbResult.Controls.Add(Me.labResultMessage)
        Me.gbResult.Controls.Add(Me.txtResult)
        Me.gbResult.Controls.Add(Me.labResult)
        Me.gbResult.Location = New System.Drawing.Point(11, 817)
        Me.gbResult.Name = "gbResult"
        Me.gbResult.Size = New System.Drawing.Size(853, 180)
        Me.gbResult.TabIndex = 77
        Me.gbResult.TabStop = False
        Me.gbResult.Text = "Transaction result"
        '
        'btnMESSetting
        '
        Me.btnMESSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMESSetting.Location = New System.Drawing.Point(696, 306)
        Me.btnMESSetting.Name = "btnMESSetting"
        Me.btnMESSetting.Size = New System.Drawing.Size(168, 23)
        Me.btnMESSetting.TabIndex = 76
        Me.btnMESSetting.Text = "MES 設定(MES Setting)"
        Me.btnMESSetting.UseVisualStyleBackColor = True
        '
        'btnWOQry
        '
        Me.btnWOQry.Location = New System.Drawing.Point(696, 63)
        Me.btnWOQry.Name = "btnWOQry"
        Me.btnWOQry.Size = New System.Drawing.Size(168, 23)
        Me.btnWOQry.TabIndex = 75
        Me.btnWOQry.Text = "工單查詢(WOQry)"
        Me.btnWOQry.UseVisualStyleBackColor = True
        '
        'btnWOCheckOut
        '
        Me.btnWOCheckOut.Location = New System.Drawing.Point(696, 138)
        Me.btnWOCheckOut.Name = "btnWOCheckOut"
        Me.btnWOCheckOut.Size = New System.Drawing.Size(168, 23)
        Me.btnWOCheckOut.TabIndex = 74
        Me.btnWOCheckOut.Text = "工單出站(WOCheckOut)"
        Me.btnWOCheckOut.UseVisualStyleBackColor = True
        '
        'btnWOCheckIn
        '
        Me.btnWOCheckIn.Location = New System.Drawing.Point(696, 103)
        Me.btnWOCheckIn.Name = "btnWOCheckIn"
        Me.btnWOCheckIn.Size = New System.Drawing.Size(168, 23)
        Me.btnWOCheckIn.TabIndex = 73
        Me.btnWOCheckIn.Text = "工單進站(WOCheckIn)"
        Me.btnWOCheckIn.UseVisualStyleBackColor = True
        '
        'txtReplyJson_WoQry
        '
        Me.txtReplyJson_WoQry.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReplyJson_WoQry.Location = New System.Drawing.Point(6, 6)
        Me.txtReplyJson_WoQry.Multiline = True
        Me.txtReplyJson_WoQry.Name = "txtReplyJson_WoQry"
        Me.txtReplyJson_WoQry.Size = New System.Drawing.Size(401, 353)
        Me.txtReplyJson_WoQry.TabIndex = 39
        Me.txtReplyJson_WoQry.Text = resources.GetString("txtReplyJson_WoQry.Text")
        '
        'tpWOQry
        '
        Me.tpWOQry.Controls.Add(Me.txtReplyJson_WoQry)
        Me.tpWOQry.Location = New System.Drawing.Point(4, 22)
        Me.tpWOQry.Name = "tpWOQry"
        Me.tpWOQry.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWOQry.Size = New System.Drawing.Size(413, 365)
        Me.tpWOQry.TabIndex = 0
        Me.tpWOQry.Text = "WOQry"
        Me.tpWOQry.UseVisualStyleBackColor = True
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tpWOQry)
        Me.tabControl1.Controls.Add(Me.tpWORecipeQry)
        Me.tabControl1.Controls.Add(Me.tpReturnOK)
        Me.tabControl1.Controls.Add(Me.tpReturnNG)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(18, 21)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(421, 391)
        Me.tabControl1.TabIndex = 0
        '
        'tpWORecipeQry
        '
        Me.tpWORecipeQry.Controls.Add(Me.txtReplyJson_WOPARMQRY)
        Me.tpWORecipeQry.Location = New System.Drawing.Point(4, 22)
        Me.tpWORecipeQry.Name = "tpWORecipeQry"
        Me.tpWORecipeQry.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWORecipeQry.Size = New System.Drawing.Size(413, 365)
        Me.tpWORecipeQry.TabIndex = 1
        Me.tpWORecipeQry.Text = "RecipeQry"
        Me.tpWORecipeQry.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.tabControl1)
        Me.groupBox2.Location = New System.Drawing.Point(18, 103)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(445, 418)
        Me.groupBox2.TabIndex = 69
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "return Sample"
        '
        'rdiTest
        '
        Me.rdiTest.AutoSize = True
        Me.rdiTest.Checked = True
        Me.rdiTest.Location = New System.Drawing.Point(151, 30)
        Me.rdiTest.Name = "rdiTest"
        Me.rdiTest.Size = New System.Drawing.Size(42, 16)
        Me.rdiTest.TabIndex = 1
        Me.rdiTest.TabStop = True
        Me.rdiTest.Text = "Test"
        Me.rdiTest.UseVisualStyleBackColor = True
        '
        'rdiProduction
        '
        Me.rdiProduction.AutoSize = True
        Me.rdiProduction.Location = New System.Drawing.Point(28, 30)
        Me.rdiProduction.Name = "rdiProduction"
        Me.rdiProduction.Size = New System.Drawing.Size(74, 16)
        Me.rdiProduction.TabIndex = 0
        Me.rdiProduction.Text = "Production"
        Me.rdiProduction.UseVisualStyleBackColor = True
        '
        'gbModeChange
        '
        Me.gbModeChange.Controls.Add(Me.rdiTest)
        Me.gbModeChange.Controls.Add(Me.rdiProduction)
        Me.gbModeChange.Location = New System.Drawing.Point(18, 31)
        Me.gbModeChange.Name = "gbModeChange"
        Me.gbModeChange.Size = New System.Drawing.Size(226, 66)
        Me.gbModeChange.TabIndex = 70
        Me.gbModeChange.TabStop = False
        Me.gbModeChange.Text = "Mode Change"
        '
        'rdiFail
        '
        Me.rdiFail.AutoSize = True
        Me.rdiFail.Location = New System.Drawing.Point(145, 30)
        Me.rdiFail.Name = "rdiFail"
        Me.rdiFail.Size = New System.Drawing.Size(40, 16)
        Me.rdiFail.TabIndex = 3
        Me.rdiFail.Text = "Fail"
        Me.rdiFail.UseVisualStyleBackColor = True
        '
        'rdiSuccess
        '
        Me.rdiSuccess.AutoSize = True
        Me.rdiSuccess.Checked = True
        Me.rdiSuccess.Location = New System.Drawing.Point(22, 30)
        Me.rdiSuccess.Name = "rdiSuccess"
        Me.rdiSuccess.Size = New System.Drawing.Size(58, 16)
        Me.rdiSuccess.TabIndex = 2
        Me.rdiSuccess.TabStop = True
        Me.rdiSuccess.Text = "Success"
        Me.rdiSuccess.UseVisualStyleBackColor = True
        '
        'gbTestResultType
        '
        Me.gbTestResultType.Controls.Add(Me.rdiFail)
        Me.gbTestResultType.Controls.Add(Me.rdiSuccess)
        Me.gbTestResultType.Location = New System.Drawing.Point(253, 31)
        Me.gbTestResultType.Name = "gbTestResultType"
        Me.gbTestResultType.Size = New System.Drawing.Size(210, 66)
        Me.gbTestResultType.TabIndex = 71
        Me.gbTestResultType.TabStop = False
        Me.gbTestResultType.Text = "Test Result Type"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.gbTestResultType)
        Me.groupBox5.Controls.Add(Me.gbModeChange)
        Me.groupBox5.Controls.Add(Me.groupBox2)
        Me.groupBox5.Location = New System.Drawing.Point(875, 10)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(482, 987)
        Me.groupBox5.TabIndex = 83
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "this block only for test"
        '
        'ParamInputType
        '
        Me.ParamInputType.HeaderText = "輸入類型(Input type)"
        Me.ParamInputType.Name = "ParamInputType"
        Me.ParamInputType.ReadOnly = True
        '
        'Required
        '
        Me.Required.HeaderText = "需輸入?(Must enter?)"
        Me.Required.Name = "Required"
        Me.Required.ReadOnly = True
        Me.Required.Width = 80
        '
        'ParamValue
        '
        Me.ParamValue.HeaderText = "參數值(Parameter value)"
        Me.ParamValue.Name = "ParamValue"
        '
        'ParamName
        '
        Me.ParamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ParamName.HeaderText = "參數名稱(parameter name)"
        Me.ParamName.Name = "ParamName"
        Me.ParamName.Width = 80
        '
        'ParamCode
        '
        Me.ParamCode.HeaderText = "ParmCode"
        Me.ParamCode.Name = "ParamCode"
        Me.ParamCode.Visible = False
        '
        'gvParam
        '
        Me.gvParam.AllowUserToAddRows = False
        Me.gvParam.AllowUserToDeleteRows = False
        Me.gvParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvParam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParamCode, Me.ParamName, Me.ParamValue, Me.Required, Me.ParamInputType, Me.ParamComboDataList})
        Me.gvParam.Location = New System.Drawing.Point(16, 18)
        Me.gvParam.Name = "gvParam"
        Me.gvParam.RowTemplate.Height = 24
        Me.gvParam.Size = New System.Drawing.Size(418, 137)
        Me.gvParam.TabIndex = 0
        '
        'ParamComboDataList
        '
        Me.ParamComboDataList.HeaderText = "資料清單(List of information)"
        Me.ParamComboDataList.Name = "ParamComboDataList"
        Me.ParamComboDataList.ReadOnly = True
        '
        'gbParam
        '
        Me.gbParam.Controls.Add(Me.gvParam)
        Me.gbParam.Location = New System.Drawing.Point(424, 345)
        Me.gbParam.Name = "gbParam"
        Me.gbParam.Size = New System.Drawing.Size(440, 162)
        Me.gbParam.TabIndex = 82
        Me.gbParam.TabStop = False
        Me.gbParam.Text = "管理參數(Management parameter)"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 1024)
        Me.Controls.Add(Me.gbMatList)
        Me.Controls.Add(Me.gbMouldInfo)
        Me.Controls.Add(Me.gbWOInfo)
        Me.Controls.Add(Me.gbUserID)
        Me.Controls.Add(Me.gbManagementItem)
        Me.Controls.Add(Me.gbWOList)
        Me.Controls.Add(Me.btnMESOnline)
        Me.Controls.Add(Me.btnEqpCheck)
        Me.Controls.Add(Me.gbResult)
        Me.Controls.Add(Me.btnMESSetting)
        Me.Controls.Add(Me.btnWOQry)
        Me.Controls.Add(Me.btnWOCheckOut)
        Me.Controls.Add(Me.btnWOCheckIn)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.gbParam)
        Me.Name = "frm_Main"
        Me.Text = "MES"
        Me.gbMatList.ResumeLayout(False)
        CType(Me.gvMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMould, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMouldInfo.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tpReturnNG.ResumeLayout(False)
        Me.tpReturnNG.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.gvNGList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWOInfo.ResumeLayout(False)
        Me.gbWOInfo.PerformLayout()
        Me.gbUserID.ResumeLayout(False)
        Me.gbUserID.PerformLayout()
        Me.tpReturnOK.ResumeLayout(False)
        Me.tpReturnOK.PerformLayout()
        CType(Me.gvInputCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbManagementItem.ResumeLayout(False)
        CType(Me.gvACWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWOList.ResumeLayout(False)
        Me.gbResult.ResumeLayout(False)
        Me.gbResult.PerformLayout()
        Me.tpWOQry.ResumeLayout(False)
        Me.tpWOQry.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tpWORecipeQry.ResumeLayout(False)
        Me.tpWORecipeQry.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.gbModeChange.ResumeLayout(False)
        Me.gbModeChange.PerformLayout()
        Me.gbTestResultType.ResumeLayout(False)
        Me.gbTestResultType.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        CType(Me.gvParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParam.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents colMatType As DataGridViewTextBoxColumn
    Private WithEvents btnMatChange As Button
    Private WithEvents gbMatList As GroupBox
    Private WithEvents gvMat As DataGridView
    Private WithEvents colMatCode As DataGridViewTextBoxColumn
    Private WithEvents colMatValue As DataGridViewTextBoxColumn
    Private WithEvents colMouldNo As DataGridViewTextBoxColumn
    Private WithEvents colMouldOnlineDate As DataGridViewTextBoxColumn
    Private WithEvents colMouldTotalUsageQty As DataGridViewTextBoxColumn
    Private WithEvents colMouldUsageQty As DataGridViewTextBoxColumn
    Private WithEvents colMouldType As DataGridViewTextBoxColumn
    Private WithEvents colMouldStatus As DataGridViewTextBoxColumn
    Private WithEvents btnMouldOffline As Button
    Private WithEvents btnMouldOnline As Button
    Private WithEvents gvMould As DataGridView
    Private WithEvents gbMouldInfo As GroupBox
    Private WithEvents txtReplyJson_MouldQry As TextBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents txtReplyJson_Connection As TextBox
    Private WithEvents tabPage1 As TabPage
    Private WithEvents txtReplyJson_JustFail As TextBox
    Private WithEvents tpReturnNG As TabPage
    Private WithEvents txtReplyJson_JustOK As TextBox
    Private WithEvents txtWONO As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents gvNGList As DataGridView
    Private WithEvents colNGCode As DataGridViewTextBoxColumn
    Private WithEvents colNGCHName As DataGridViewTextBoxColumn
    Private WithEvents colQty As DataGridViewTextBoxColumn
    Private WithEvents txtWOOutQty As TextBox
    Private WithEvents labWOOutQty As Label
    Private WithEvents txtRecipeID As TextBox
    Private WithEvents labRecipeID As Label
    Private WithEvents txtWOQty As TextBox
    Private WithEvents lblWOQty As Label
    Private WithEvents txtWorkCenterName As TextBox
    Private WithEvents lblWorkCenterName As Label
    Private WithEvents txtWorkCenterNo As TextBox
    Private WithEvents lblWorkCenterNo As Label
    Private WithEvents txtPartNo As TextBox
    Private WithEvents lblPartNo As Label
    Private WithEvents lblWONO As Label
    Private WithEvents gbWOInfo As GroupBox
    Private WithEvents btnUserIDChange As Button
    Private WithEvents gbUserID As GroupBox
    Private WithEvents txtUserID As TextBox
    Private WithEvents tpReturnOK As TabPage
    Private WithEvents txtReplyJson_WOPARMQRY As TextBox
    Private WithEvents InputCodeName As DataGridViewTextBoxColumn
    Private WithEvents gvInputCode As DataGridView
    Private WithEvents InputCode As DataGridViewTextBoxColumn
    Private WithEvents InputCodeValue As DataGridViewTextBoxColumn
    Private WithEvents InputCodeRequiredInput As DataGridViewTextBoxColumn
    Private WithEvents InputCodeType As DataGridViewTextBoxColumn
    Private WithEvents InputCodeDataItemList As DataGridViewTextBoxColumn
    Private WithEvents gbManagementItem As GroupBox
    Private WithEvents colWOlistWorkOrder As DataGridViewTextBoxColumn
    Private WithEvents gvACWorkOrder As DataGridView
    Private WithEvents gbWOList As GroupBox
    Private WithEvents txtResultCode As TextBox
    Private WithEvents labResultCode As Label
    Private WithEvents txtResultMessage As TextBox
    Private WithEvents labResultMessage As Label
    Private WithEvents btnMESOnline As Button
    Private WithEvents timer1 As Timer
    Private WithEvents txtResult As TextBox
    Private WithEvents labResult As Label
    Private WithEvents btnEqpCheck As Button
    Private WithEvents gbResult As GroupBox
    Private WithEvents btnMESSetting As Button
    Private WithEvents btnWOQry As Button
    Private WithEvents btnWOCheckOut As Button
    Private WithEvents btnWOCheckIn As Button
    Private WithEvents txtReplyJson_WoQry As TextBox
    Private WithEvents tpWOQry As TabPage
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tpWORecipeQry As TabPage
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents rdiTest As RadioButton
    Private WithEvents rdiProduction As RadioButton
    Private WithEvents gbModeChange As GroupBox
    Private WithEvents rdiFail As RadioButton
    Private WithEvents rdiSuccess As RadioButton
    Private WithEvents gbTestResultType As GroupBox
    Private WithEvents groupBox5 As GroupBox
    Private WithEvents ParamInputType As DataGridViewTextBoxColumn
    Private WithEvents Required As DataGridViewTextBoxColumn
    Private WithEvents ParamValue As DataGridViewTextBoxColumn
    Private WithEvents ParamName As DataGridViewTextBoxColumn
    Private WithEvents ParamCode As DataGridViewTextBoxColumn
    Private WithEvents gvParam As DataGridView
    Private WithEvents ParamComboDataList As DataGridViewTextBoxColumn
    Private WithEvents gbParam As GroupBox
End Class
