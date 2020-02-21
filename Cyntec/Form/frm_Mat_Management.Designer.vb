<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mat_Management
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
        Me.txtMatCancel = New System.Windows.Forms.Button()
        Me.txtMatConfirm = New System.Windows.Forms.Button()
        Me.txtMatValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMatCancel
        '
        Me.txtMatCancel.Location = New System.Drawing.Point(443, 113)
        Me.txtMatCancel.Name = "txtMatCancel"
        Me.txtMatCancel.Size = New System.Drawing.Size(89, 92)
        Me.txtMatCancel.TabIndex = 5
        Me.txtMatCancel.Text = "取消"
        Me.txtMatCancel.UseVisualStyleBackColor = True
        '
        'txtMatConfirm
        '
        Me.txtMatConfirm.Location = New System.Drawing.Point(443, 12)
        Me.txtMatConfirm.Name = "txtMatConfirm"
        Me.txtMatConfirm.Size = New System.Drawing.Size(89, 95)
        Me.txtMatConfirm.TabIndex = 4
        Me.txtMatConfirm.Text = "確認"
        Me.txtMatConfirm.UseVisualStyleBackColor = True
        '
        'txtMatValue
        '
        Me.txtMatValue.Location = New System.Drawing.Point(12, 12)
        Me.txtMatValue.Multiline = True
        Me.txtMatValue.Name = "txtMatValue"
        Me.txtMatValue.Size = New System.Drawing.Size(425, 193)
        Me.txtMatValue.TabIndex = 3
        '
        'frm_Mat_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 218)
        Me.Controls.Add(Me.txtMatCancel)
        Me.Controls.Add(Me.txtMatConfirm)
        Me.Controls.Add(Me.txtMatValue)
        Me.Name = "frm_Mat_Management"
        Me.Text = "請輸入欲更換物料二維條碼"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtMatCancel As Button
    Private WithEvents txtMatConfirm As Button
    Private WithEvents txtMatValue As TextBox
End Class
