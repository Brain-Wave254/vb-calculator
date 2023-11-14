<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormD
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
        Me.components = New System.ComponentModel.Container()
        Me.myprogress = New System.Windows.Forms.ProgressBar()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'myprogress
        '
        Me.myprogress.ForeColor = System.Drawing.Color.Black
        Me.myprogress.Location = New System.Drawing.Point(5, 393)
        Me.myprogress.Margin = New System.Windows.Forms.Padding(0)
        Me.myprogress.Name = "myprogress"
        Me.myprogress.Size = New System.Drawing.Size(662, 32)
        Me.myprogress.TabIndex = 5
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(161, 31)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(264, 38)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "CALCULATOR PRO"
        '
        'Percentage
        '
        Me.Percentage.AutoSize = True
        Me.Percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage.Location = New System.Drawing.Point(315, 347)
        Me.Percentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(38, 31)
        Me.Percentage.TabIndex = 6
        Me.Percentage.Text = "%"
        '
        'Timer1
        '
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 200
        Me.IconButton1.Location = New System.Drawing.Point(182, 86)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(228, 233)
        Me.IconButton1.TabIndex = 75
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(676, 431)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Percentage)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.myprogress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents myprogress As ProgressBar
    Friend WithEvents LabelName As Label
    Friend WithEvents Percentage As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
