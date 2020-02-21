<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Setting
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
        Me.labMouldType = New System.Windows.Forms.Label()
        Me.txtMouldType = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtMatCode = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtMatType = New System.Windows.Forms.TextBox()
        Me.btnMatAdd = New System.Windows.Forms.Button()
        Me.gvMatSet = New System.Windows.Forms.DataGridView()
        Me.colMatType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMatCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbMouldSet = New System.Windows.Forms.GroupBox()
        Me.btnMouldAdd = New System.Windows.Forms.Button()
        Me.gvMouldSet = New System.Windows.Forms.DataGridView()
        Me.colMouldType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.刪除此模具類型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MESConnection = New System.Windows.Forms.GroupBox()
        Me.rdiMESOffline = New System.Windows.Forms.RadioButton()
        Me.rdiMESOnline = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtRecipeIDCodeName = New System.Windows.Forms.TextBox()
        Me.labRecipeIDCodeName = New System.Windows.Forms.Label()
        Me.txtRefreshInterval = New System.Windows.Forms.TextBox()
        Me.labRefreshInterval = New System.Windows.Forms.Label()
        Me.btnDicDi = New System.Windows.Forms.Button()
        Me.txtLogPath = New System.Windows.Forms.TextBox()
        Me.labLogPath = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtMESServerURL = New System.Windows.Forms.TextBox()
        Me.labMESServerURL = New System.Windows.Forms.Label()
        Me.txtMachineID = New System.Windows.Forms.TextBox()
        Me.labMachineID = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        CType(Me.gvMatSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip2.SuspendLayout()
        Me.gbMouldSet.SuspendLayout()
        CType(Me.gvMouldSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        Me.MESConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'labMouldType
        '
        Me.labMouldType.Location = New System.Drawing.Point(20, 30)
        Me.labMouldType.Name = "labMouldType"
        Me.labMouldType.Size = New System.Drawing.Size(62, 23)
        Me.labMouldType.TabIndex = 26
        Me.labMouldType.Text = "模具類型"
        Me.labMouldType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMouldType
        '
        Me.txtMouldType.Location = New System.Drawing.Point(85, 30)
        Me.txtMouldType.Name = "txtMouldType"
        Me.txtMouldType.Size = New System.Drawing.Size(122, 22)
        Me.txtMouldType.TabIndex = 25
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtMatCode)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtMatType)
        Me.groupBox1.Controls.Add(Me.btnMatAdd)
        Me.groupBox1.Controls.Add(Me.gvMatSet)
        Me.groupBox1.Location = New System.Drawing.Point(379, 272)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(285, 167)
        Me.groupBox1.TabIndex = 44
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "物料設定清單"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(5, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 23)
        Me.label2.TabIndex = 31
        Me.label2.Text = "物料代碼"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatCode
        '
        Me.txtMatCode.Location = New System.Drawing.Point(70, 56)
        Me.txtMatCode.Name = "txtMatCode"
        Me.txtMatCode.Size = New System.Drawing.Size(122, 22)
        Me.txtMatCode.TabIndex = 30
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(5, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 23)
        Me.label1.TabIndex = 29
        Me.label1.Text = "物料類型"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatType
        '
        Me.txtMatType.Location = New System.Drawing.Point(70, 28)
        Me.txtMatType.Name = "txtMatType"
        Me.txtMatType.Size = New System.Drawing.Size(122, 22)
        Me.txtMatType.TabIndex = 28
        '
        'btnMatAdd
        '
        Me.btnMatAdd.Location = New System.Drawing.Point(198, 26)
        Me.btnMatAdd.Name = "btnMatAdd"
        Me.btnMatAdd.Size = New System.Drawing.Size(75, 52)
        Me.btnMatAdd.TabIndex = 27
        Me.btnMatAdd.Text = "添加"
        Me.btnMatAdd.UseVisualStyleBackColor = True
        '
        'gvMatSet
        '
        Me.gvMatSet.AllowUserToAddRows = False
        Me.gvMatSet.AllowUserToDeleteRows = False
        Me.gvMatSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMatSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMatType, Me.colMatCode})
        Me.gvMatSet.ContextMenuStrip = Me.contextMenuStrip2
        Me.gvMatSet.Location = New System.Drawing.Point(6, 86)
        Me.gvMatSet.Name = "gvMatSet"
        Me.gvMatSet.ReadOnly = True
        Me.gvMatSet.RowTemplate.Height = 24
        Me.gvMatSet.Size = New System.Drawing.Size(267, 75)
        Me.gvMatSet.TabIndex = 26
        '
        'colMatType
        '
        Me.colMatType.HeaderText = "物料類型"
        Me.colMatType.Name = "colMatType"
        Me.colMatType.ReadOnly = True
        '
        'colMatCode
        '
        Me.colMatCode.HeaderText = "物料代碼"
        Me.colMatCode.Name = "colMatCode"
        Me.colMatCode.ReadOnly = True
        '
        'contextMenuStrip2
        '
        Me.contextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
        Me.contextMenuStrip2.Name = "contextMenuStrip1"
        Me.contextMenuStrip2.Size = New System.Drawing.Size(159, 26)
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.toolStripMenuItem1.Text = "刪除此物料設定"
        '
        'gbMouldSet
        '
        Me.gbMouldSet.Controls.Add(Me.labMouldType)
        Me.gbMouldSet.Controls.Add(Me.txtMouldType)
        Me.gbMouldSet.Controls.Add(Me.btnMouldAdd)
        Me.gbMouldSet.Controls.Add(Me.gvMouldSet)
        Me.gbMouldSet.Location = New System.Drawing.Point(77, 272)
        Me.gbMouldSet.Name = "gbMouldSet"
        Me.gbMouldSet.Size = New System.Drawing.Size(296, 167)
        Me.gbMouldSet.TabIndex = 43
        Me.gbMouldSet.TabStop = False
        Me.gbMouldSet.Text = "模具設定清單"
        '
        'btnMouldAdd
        '
        Me.btnMouldAdd.Location = New System.Drawing.Point(215, 28)
        Me.btnMouldAdd.Name = "btnMouldAdd"
        Me.btnMouldAdd.Size = New System.Drawing.Size(75, 24)
        Me.btnMouldAdd.TabIndex = 24
        Me.btnMouldAdd.Text = "添加"
        Me.btnMouldAdd.UseVisualStyleBackColor = True
        '
        'gvMouldSet
        '
        Me.gvMouldSet.AllowUserToAddRows = False
        Me.gvMouldSet.AllowUserToDeleteRows = False
        Me.gvMouldSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMouldSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMouldType})
        Me.gvMouldSet.ContextMenuStrip = Me.contextMenuStrip1
        Me.gvMouldSet.Location = New System.Drawing.Point(21, 58)
        Me.gvMouldSet.Name = "gvMouldSet"
        Me.gvMouldSet.ReadOnly = True
        Me.gvMouldSet.RowTemplate.Height = 24
        Me.gvMouldSet.Size = New System.Drawing.Size(269, 103)
        Me.gvMouldSet.TabIndex = 23
        '
        'colMouldType
        '
        Me.colMouldType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMouldType.HeaderText = "模具類型"
        Me.colMouldType.Name = "colMouldType"
        Me.colMouldType.ReadOnly = True
        Me.colMouldType.Width = 200
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刪除此模具類型ToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(159, 26)
        '
        '刪除此模具類型ToolStripMenuItem
        '
        Me.刪除此模具類型ToolStripMenuItem.Name = "刪除此模具類型ToolStripMenuItem"
        Me.刪除此模具類型ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.刪除此模具類型ToolStripMenuItem.Text = "刪除此模具設定"
        '
        'MESConnection
        '
        Me.MESConnection.Controls.Add(Me.rdiMESOffline)
        Me.MESConnection.Controls.Add(Me.rdiMESOnline)
        Me.MESConnection.Location = New System.Drawing.Point(305, 11)
        Me.MESConnection.Name = "MESConnection"
        Me.MESConnection.Size = New System.Drawing.Size(347, 50)
        Me.MESConnection.TabIndex = 46
        Me.MESConnection.TabStop = False
        '
        'rdiMESOffline
        '
        Me.rdiMESOffline.AutoSize = True
        Me.rdiMESOffline.Checked = True
        Me.rdiMESOffline.Location = New System.Drawing.Point(214, 19)
        Me.rdiMESOffline.Name = "rdiMESOffline"
        Me.rdiMESOffline.Size = New System.Drawing.Size(47, 16)
        Me.rdiMESOffline.TabIndex = 1
        Me.rdiMESOffline.TabStop = True
        Me.rdiMESOffline.Text = "關閉"
        Me.rdiMESOffline.UseVisualStyleBackColor = True
        '
        'rdiMESOnline
        '
        Me.rdiMESOnline.AutoSize = True
        Me.rdiMESOnline.Location = New System.Drawing.Point(56, 19)
        Me.rdiMESOnline.Name = "rdiMESOnline"
        Me.rdiMESOnline.Size = New System.Drawing.Size(47, 16)
        Me.rdiMESOnline.TabIndex = 0
        Me.rdiMESOnline.TabStop = True
        Me.rdiMESOnline.Text = "開啟"
        Me.rdiMESOnline.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(50, 34)
        Me.label3.Name = "label3"
        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label3.Size = New System.Drawing.Size(234, 12)
        Me.label3.TabIndex = 45
        Me.label3.Text = "MES連線："
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecipeIDCodeName
        '
        Me.txtRecipeIDCodeName.Location = New System.Drawing.Point(305, 232)
        Me.txtRecipeIDCodeName.Name = "txtRecipeIDCodeName"
        Me.txtRecipeIDCodeName.Size = New System.Drawing.Size(106, 22)
        Me.txtRecipeIDCodeName.TabIndex = 41
        '
        'labRecipeIDCodeName
        '
        Me.labRecipeIDCodeName.Location = New System.Drawing.Point(43, 238)
        Me.labRecipeIDCodeName.Name = "labRecipeIDCodeName"
        Me.labRecipeIDCodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labRecipeIDCodeName.Size = New System.Drawing.Size(244, 12)
        Me.labRecipeIDCodeName.TabIndex = 42
        Me.labRecipeIDCodeName.Text = "RecipeID CodeName："
        Me.labRecipeIDCodeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRefreshInterval
        '
        Me.txtRefreshInterval.Location = New System.Drawing.Point(305, 189)
        Me.txtRefreshInterval.Name = "txtRefreshInterval"
        Me.txtRefreshInterval.Size = New System.Drawing.Size(106, 22)
        Me.txtRefreshInterval.TabIndex = 39
        '
        'labRefreshInterval
        '
        Me.labRefreshInterval.Location = New System.Drawing.Point(43, 197)
        Me.labRefreshInterval.Name = "labRefreshInterval"
        Me.labRefreshInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labRefreshInterval.Size = New System.Drawing.Size(244, 12)
        Me.labRefreshInterval.TabIndex = 40
        Me.labRefreshInterval.Text = "設備更新間隔(EqpStatus refresh interval)："
        Me.labRefreshInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDicDi
        '
        Me.btnDicDi.Location = New System.Drawing.Point(577, 147)
        Me.btnDicDi.Name = "btnDicDi"
        Me.btnDicDi.Size = New System.Drawing.Size(27, 23)
        Me.btnDicDi.TabIndex = 38
        Me.btnDicDi.Text = "..."
        Me.btnDicDi.UseVisualStyleBackColor = True
        '
        'txtLogPath
        '
        Me.txtLogPath.Location = New System.Drawing.Point(305, 147)
        Me.txtLogPath.Name = "txtLogPath"
        Me.txtLogPath.ReadOnly = True
        Me.txtLogPath.Size = New System.Drawing.Size(266, 22)
        Me.txtLogPath.TabIndex = 32
        '
        'labLogPath
        '
        Me.labLogPath.Location = New System.Drawing.Point(43, 153)
        Me.labLogPath.Name = "labLogPath"
        Me.labLogPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labLogPath.Size = New System.Drawing.Size(244, 12)
        Me.labLogPath.TabIndex = 37
        Me.labLogPath.Text = "Log Path："
        Me.labLogPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(667, 68)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 42)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(667, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 42)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtMESServerURL
        '
        Me.txtMESServerURL.Location = New System.Drawing.Point(305, 68)
        Me.txtMESServerURL.Name = "txtMESServerURL"
        Me.txtMESServerURL.Size = New System.Drawing.Size(299, 22)
        Me.txtMESServerURL.TabIndex = 30
        '
        'labMESServerURL
        '
        Me.labMESServerURL.Location = New System.Drawing.Point(53, 75)
        Me.labMESServerURL.Name = "labMESServerURL"
        Me.labMESServerURL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labMESServerURL.Size = New System.Drawing.Size(234, 12)
        Me.labMESServerURL.TabIndex = 35
        Me.labMESServerURL.Text = "MES Server URL："
        Me.labMESServerURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMachineID
        '
        Me.txtMachineID.Location = New System.Drawing.Point(305, 107)
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.Size = New System.Drawing.Size(106, 22)
        Me.txtMachineID.TabIndex = 31
        '
        'labMachineID
        '
        Me.labMachineID.Location = New System.Drawing.Point(87, 113)
        Me.labMachineID.Name = "labMachineID"
        Me.labMachineID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labMachineID.Size = New System.Drawing.Size(200, 12)
        Me.labMachineID.TabIndex = 36
        Me.labMachineID.Text = "設備編號(EqpNo)："
        Me.labMachineID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gbMouldSet)
        Me.Controls.Add(Me.MESConnection)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtRecipeIDCodeName)
        Me.Controls.Add(Me.labRecipeIDCodeName)
        Me.Controls.Add(Me.txtRefreshInterval)
        Me.Controls.Add(Me.labRefreshInterval)
        Me.Controls.Add(Me.btnDicDi)
        Me.Controls.Add(Me.txtLogPath)
        Me.Controls.Add(Me.labLogPath)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMESServerURL)
        Me.Controls.Add(Me.labMESServerURL)
        Me.Controls.Add(Me.txtMachineID)
        Me.Controls.Add(Me.labMachineID)
        Me.Name = "frm_Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Setting"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.gvMatSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip2.ResumeLayout(False)
        Me.gbMouldSet.ResumeLayout(False)
        Me.gbMouldSet.PerformLayout()
        CType(Me.gvMouldSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.MESConnection.ResumeLayout(False)
        Me.MESConnection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labMouldType As Label
    Private WithEvents txtMouldType As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents txtMatCode As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtMatType As TextBox
    Private WithEvents btnMatAdd As Button
    Private WithEvents gvMatSet As DataGridView
    Private WithEvents colMatType As DataGridViewTextBoxColumn
    Private WithEvents colMatCode As DataGridViewTextBoxColumn
    Private WithEvents contextMenuStrip2 As ContextMenuStrip
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents gbMouldSet As GroupBox
    Private WithEvents btnMouldAdd As Button
    Private WithEvents gvMouldSet As DataGridView
    Private WithEvents colMouldType As DataGridViewTextBoxColumn
    Private WithEvents contextMenuStrip1 As ContextMenuStrip
    Private WithEvents 刪除此模具類型ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents MESConnection As GroupBox
    Private WithEvents rdiMESOffline As RadioButton
    Private WithEvents rdiMESOnline As RadioButton
    Private WithEvents label3 As Label
    Private WithEvents txtRecipeIDCodeName As TextBox
    Private WithEvents labRecipeIDCodeName As Label
    Private WithEvents txtRefreshInterval As TextBox
    Private WithEvents labRefreshInterval As Label
    Private WithEvents btnDicDi As Button
    Private WithEvents txtLogPath As TextBox
    Private WithEvents labLogPath As Label
    Private WithEvents btnCancel As Button
    Private WithEvents btnSave As Button
    Private WithEvents txtMESServerURL As TextBox
    Private WithEvents labMESServerURL As Label
    Private WithEvents txtMachineID As TextBox
    Private WithEvents labMachineID As Label
End Class
