<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UserID
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
        Me.gbUserID = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.gbUserID.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUserID
        '
        Me.gbUserID.Controls.Add(Me.btnCancel)
        Me.gbUserID.Controls.Add(Me.btnConfirm)
        Me.gbUserID.Controls.Add(Me.txtUserID)
        Me.gbUserID.Location = New System.Drawing.Point(12, 12)
        Me.gbUserID.Name = "gbUserID"
        Me.gbUserID.Size = New System.Drawing.Size(415, 57)
        Me.gbUserID.TabIndex = 1
        Me.gbUserID.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(325, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(244, 20)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "確認"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(16, 21)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(222, 22)
        Me.txtUserID.TabIndex = 0
        '
        'frm_UserID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 82)
        Me.Controls.Add(Me.gbUserID)
        Me.Name = "frm_UserID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請輸入欲更換之工號"
        Me.gbUserID.ResumeLayout(False)
        Me.gbUserID.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents gbUserID As GroupBox
    Private WithEvents btnCancel As Button
    Private WithEvents btnConfirm As Button
    Private WithEvents txtUserID As TextBox
End Class
