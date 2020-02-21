<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_moould_management
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMouldCancel = New System.Windows.Forms.Button()
        Me.btnMouldConfirm = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtTotalUsageQty = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtUsageQty = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtMouldNo = New System.Windows.Forms.TextBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnMouldCancel)
        Me.groupBox1.Controls.Add(Me.btnMouldConfirm)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtTotalUsageQty)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtUsageQty)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtMouldNo)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(554, 165)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "模具資訊"
        '
        'btnMouldCancel
        '
        Me.btnMouldCancel.Location = New System.Drawing.Point(430, 76)
        Me.btnMouldCancel.Name = "btnMouldCancel"
        Me.btnMouldCancel.Size = New System.Drawing.Size(111, 43)
        Me.btnMouldCancel.TabIndex = 7
        Me.btnMouldCancel.Text = "取消"
        Me.btnMouldCancel.UseVisualStyleBackColor = True
        '
        'btnMouldConfirm
        '
        Me.btnMouldConfirm.Location = New System.Drawing.Point(430, 17)
        Me.btnMouldConfirm.Name = "btnMouldConfirm"
        Me.btnMouldConfirm.Size = New System.Drawing.Size(111, 43)
        Me.btnMouldConfirm.TabIndex = 6
        Me.btnMouldConfirm.Text = "確認"
        Me.btnMouldConfirm.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(19, 132)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 12)
        Me.label3.TabIndex = 5
        Me.label3.Text = "累計總次數"
        '
        'txtTotalUsageQty
        '
        Me.txtTotalUsageQty.Location = New System.Drawing.Point(105, 127)
        Me.txtTotalUsageQty.Name = "txtTotalUsageQty"
        Me.txtTotalUsageQty.ReadOnly = True
        Me.txtTotalUsageQty.Size = New System.Drawing.Size(90, 22)
        Me.txtTotalUsageQty.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(19, 82)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 12)
        Me.label2.TabIndex = 3
        Me.label2.Text = "已使用次數"
        '
        'txtUsageQty
        '
        Me.txtUsageQty.Location = New System.Drawing.Point(105, 76)
        Me.txtUsageQty.Name = "txtUsageQty"
        Me.txtUsageQty.ReadOnly = True
        Me.txtUsageQty.Size = New System.Drawing.Size(90, 22)
        Me.txtUsageQty.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 12)
        Me.label1.TabIndex = 1
        Me.label1.Text = "模具編號"
        '
        'txtMouldNo
        '
        Me.txtMouldNo.Location = New System.Drawing.Point(105, 27)
        Me.txtMouldNo.Name = "txtMouldNo"
        Me.txtMouldNo.Size = New System.Drawing.Size(219, 22)
        Me.txtMouldNo.TabIndex = 0
        '
        'frm_moould_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 193)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frm_moould_management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "模具管理"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnMouldCancel As Button
    Private WithEvents btnMouldConfirm As Button
    Private WithEvents label3 As Label
    Private WithEvents txtTotalUsageQty As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtUsageQty As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtMouldNo As TextBox
End Class
