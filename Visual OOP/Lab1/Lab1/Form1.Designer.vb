<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GreetingsForm
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
        Me.Saying1Button = New System.Windows.Forms.Button()
        Me.Saying2Button = New System.Windows.Forms.Button()
        Me.Saying3Button = New System.Windows.Forms.Button()
        Me.Saying4Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.ProgrammedByLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Saying1Button
        '
        Me.Saying1Button.Location = New System.Drawing.Point(11, 194)
        Me.Saying1Button.Name = "Saying1Button"
        Me.Saying1Button.Size = New System.Drawing.Size(123, 48)
        Me.Saying1Button.TabIndex = 0
        Me.Saying1Button.Text = "Saying #1"
        Me.Saying1Button.UseVisualStyleBackColor = True
        '
        'Saying2Button
        '
        Me.Saying2Button.Location = New System.Drawing.Point(140, 194)
        Me.Saying2Button.Name = "Saying2Button"
        Me.Saying2Button.Size = New System.Drawing.Size(120, 48)
        Me.Saying2Button.TabIndex = 1
        Me.Saying2Button.Text = "Saying #2"
        Me.Saying2Button.UseVisualStyleBackColor = True
        '
        'Saying3Button
        '
        Me.Saying3Button.Location = New System.Drawing.Point(266, 194)
        Me.Saying3Button.Name = "Saying3Button"
        Me.Saying3Button.Size = New System.Drawing.Size(128, 48)
        Me.Saying3Button.TabIndex = 2
        Me.Saying3Button.Text = "Saying #3"
        Me.Saying3Button.UseVisualStyleBackColor = True
        '
        'Saying4Button
        '
        Me.Saying4Button.Location = New System.Drawing.Point(400, 194)
        Me.Saying4Button.Name = "Saying4Button"
        Me.Saying4Button.Size = New System.Drawing.Size(125, 48)
        Me.Saying4Button.TabIndex = 3
        Me.Saying4Button.Text = "Saying #4"
        Me.Saying4Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(195, 248)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(133, 46)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(11, 74)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(514, 74)
        Me.MessageLabel.TabIndex = 5
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgrammedByLabel
        '
        Me.ProgrammedByLabel.AutoSize = True
        Me.ProgrammedByLabel.Location = New System.Drawing.Point(13, 390)
        Me.ProgrammedByLabel.Name = "ProgrammedByLabel"
        Me.ProgrammedByLabel.Size = New System.Drawing.Size(138, 13)
        Me.ProgrammedByLabel.TabIndex = 6
        Me.ProgrammedByLabel.Text = "Programmed By: Jim Galioto"
        '
        'GreetingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 415)
        Me.Controls.Add(Me.ProgrammedByLabel)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Saying4Button)
        Me.Controls.Add(Me.Saying3Button)
        Me.Controls.Add(Me.Saying2Button)
        Me.Controls.Add(Me.Saying1Button)
        Me.Name = "GreetingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSIS 3726 Lab #1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Saying1Button As Button
    Friend WithEvents Saying2Button As Button
    Friend WithEvents Saying3Button As Button
    Friend WithEvents Saying4Button As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MessageLabel As Label
    Friend WithEvents ProgrammedByLabel As Label
End Class
