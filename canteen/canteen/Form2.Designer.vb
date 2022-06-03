<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pin_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pin_lable = New System.Windows.Forms.Label()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.pin_field = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pin_lable)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 83)
        Me.Panel1.TabIndex = 0
        '
        'pin_lable
        '
        Me.pin_lable.AutoSize = True
        Me.pin_lable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.pin_lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pin_lable.Location = New System.Drawing.Point(199, 25)
        Me.pin_lable.Name = "pin_lable"
        Me.pin_lable.Size = New System.Drawing.Size(257, 32)
        Me.pin_lable.TabIndex = 0
        Me.pin_lable.Text = "Please Enter Your Pin"
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cancel_btn.FlatAppearance.BorderSize = 4
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel_btn.Location = New System.Drawing.Point(407, 237)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(112, 45)
        Me.cancel_btn.TabIndex = 3
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'ok_btn
        '
        Me.ok_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ok_btn.Location = New System.Drawing.Point(538, 237)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(112, 45)
        Me.ok_btn.TabIndex = 4
        Me.ok_btn.Text = "Proceed"
        Me.ok_btn.UseVisualStyleBackColor = False
        '
        'pin_field
        '
        Me.pin_field.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pin_field.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.pin_field.Location = New System.Drawing.Point(237, 134)
        Me.pin_field.Mask = "0000"
        Me.pin_field.Name = "pin_field"
        Me.pin_field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pin_field.PromptChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.pin_field.RejectInputOnFirstFailure = True
        Me.pin_field.Size = New System.Drawing.Size(161, 38)
        Me.pin_field.TabIndex = 2
        Me.pin_field.UseSystemPasswordChar = True
        Me.pin_field.ValidatingType = GetType(Integer)
        '
        'pin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 294)
        Me.Controls.Add(Me.pin_field)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pin_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pin_lable As Label
    Friend WithEvents cancel_btn As Button
    Friend WithEvents ok_btn As Button
    Friend WithEvents pin_field As MaskedTextBox
    Public Function pinfieldfunction()
        Me.pin_field.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pin_field.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.pin_field.Location = New System.Drawing.Point(237, 134)
        Me.pin_field.Mask = "0000"
        Me.pin_field.Name = "pin_field"
        Me.pin_field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pin_field.PromptChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.pin_field.RejectInputOnFirstFailure = True
        Me.pin_field.Size = New System.Drawing.Size(161, 38)
        Me.pin_field.TabIndex = 2
        Me.pin_field.UseSystemPasswordChar = True
        Me.pin_field.ValidatingType = GetType(Integer)

    End Function
End Class



