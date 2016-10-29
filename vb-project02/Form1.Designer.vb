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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.button_order = New System.Windows.Forms.Button()
        Me.RadioButton_ASC = New System.Windows.Forms.RadioButton()
        Me.RadioButton_DESC = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(191, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(191, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(12, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(191, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(12, 142)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(191, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(12, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(191, 20)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(12, 194)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(191, 20)
        Me.TextBox8.TabIndex = 7
        '
        'button_order
        '
        Me.button_order.Location = New System.Drawing.Point(13, 221)
        Me.button_order.Name = "button_order"
        Me.button_order.Size = New System.Drawing.Size(190, 23)
        Me.button_order.TabIndex = 8
        Me.button_order.Text = "Ordenació"
        Me.button_order.UseVisualStyleBackColor = True
        '
        'RadioButton_ASC
        '
        Me.RadioButton_ASC.AutoSize = True
        Me.RadioButton_ASC.Checked = True
        Me.RadioButton_ASC.Location = New System.Drawing.Point(13, 251)
        Me.RadioButton_ASC.Name = "RadioButton_ASC"
        Me.RadioButton_ASC.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton_ASC.TabIndex = 9
        Me.RadioButton_ASC.TabStop = True
        Me.RadioButton_ASC.Text = "Ascendent"
        Me.RadioButton_ASC.UseVisualStyleBackColor = True
        '
        'RadioButton_DESC
        '
        Me.RadioButton_DESC.AutoSize = True
        Me.RadioButton_DESC.Location = New System.Drawing.Point(13, 275)
        Me.RadioButton_DESC.Name = "RadioButton_DESC"
        Me.RadioButton_DESC.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton_DESC.TabIndex = 10
        Me.RadioButton_DESC.TabStop = True
        Me.RadioButton_DESC.Text = "Descendent"
        Me.RadioButton_DESC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 352)
        Me.Controls.Add(Me.RadioButton_DESC)
        Me.Controls.Add(Me.RadioButton_ASC)
        Me.Controls.Add(Me.button_order)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents button_order As Button
    Friend WithEvents RadioButton_ASC As RadioButton
    Friend WithEvents RadioButton_DESC As RadioButton
End Class
