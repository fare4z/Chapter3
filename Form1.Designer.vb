<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnLab1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLab2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLab1
        '
        Me.btnLab1.AutoSize = True
        Me.btnLab1.Location = New System.Drawing.Point(37, 93)
        Me.btnLab1.Name = "btnLab1"
        Me.btnLab1.Size = New System.Drawing.Size(180, 60)
        Me.btnLab1.TabIndex = 0
        Me.btnLab1.Text = "Activity 1 : if elseif else "
        Me.btnLab1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LAB ACTIVITY"
        '
        'btnLab2
        '
        Me.btnLab2.AutoSize = True
        Me.btnLab2.Location = New System.Drawing.Point(253, 93)
        Me.btnLab2.Name = "btnLab2"
        Me.btnLab2.Size = New System.Drawing.Size(180, 60)
        Me.btnLab2.TabIndex = 4
        Me.btnLab2.Text = "Activity 2 : Nested if"
        Me.btnLab2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(469, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 60)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Activity 3 : Select Case Statement "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(139, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 60)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Homework 1 : BMI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(367, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 60)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Homework 2 : DAYS OF MONTH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(262, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 60)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Activity : Temperature "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(662, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Info"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 337)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLab2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLab1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLab1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLab2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
End Class
