<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chkAFR = New System.Windows.Forms.CheckBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtMassMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkAFR
        '
        Me.chkAFR.AutoSize = True
        Me.chkAFR.Location = New System.Drawing.Point(140, 237)
        Me.chkAFR.Name = "chkAFR"
        Me.chkAFR.Size = New System.Drawing.Size(132, 17)
        Me.chkAFR.TabIndex = 0
        Me.chkAFR.Text = "Accept friend requests"
        Me.chkAFR.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 208)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(196, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 108)
        Me.ListBox1.TabIndex = 2
        '
        'txtMassMessage
        '
        Me.txtMassMessage.Location = New System.Drawing.Point(12, 144)
        Me.txtMassMessage.Multiline = True
        Me.txtMassMessage.Name = "txtMassMessage"
        Me.txtMassMessage.Size = New System.Drawing.Size(196, 58)
        Me.txtMassMessage.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Type the message in here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMassMessage)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.chkAFR)
        Me.Name = "Form1"
        Me.Text = "Skype Bot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkAFR As CheckBox
    Friend WithEvents btnSend As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtMassMessage As TextBox
    Friend WithEvents Label1 As Label
End Class
