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
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rcv:"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Send:"
        Me.Label1.UseWaitCursor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(197, 234)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(310, 26)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.UseWaitCursor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(197, 155)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 26)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
