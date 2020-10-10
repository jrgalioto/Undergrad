<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class carRentalCalculator
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
        Me.BeginingOdometerLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BeginingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMilesDrivenLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.TotalMileDrivenLabel = New System.Windows.Forms.Label()
        Me.TotalPriceTextLabel = New System.Windows.Forms.Label()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BeginingOdometerLabel
        '
        Me.BeginingOdometerLabel.AutoSize = True
        Me.BeginingOdometerLabel.Location = New System.Drawing.Point(12, 9)
        Me.BeginingOdometerLabel.Name = "BeginingOdometerLabel"
        Me.BeginingOdometerLabel.Size = New System.Drawing.Size(75, 13)
        Me.BeginingOdometerLabel.TabIndex = 0
        Me.BeginingOdometerLabel.Text = "Begining Miles"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.AutoSize = True
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(12, 57)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(67, 13)
        Me.EndingOdometerLabel.TabIndex = 1
        Me.EndingOdometerLabel.Text = "Ending Miles"
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(12, 96)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(83, 13)
        Me.NumberOfDaysLabel.TabIndex = 2
        Me.NumberOfDaysLabel.Text = "Number of Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'BeginingOdometerTextBox
        '
        Me.BeginingOdometerTextBox.Location = New System.Drawing.Point(12, 29)
        Me.BeginingOdometerTextBox.Name = "BeginingOdometerTextBox"
        Me.BeginingOdometerTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BeginingOdometerTextBox.TabIndex = 5
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(12, 73)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(152, 20)
        Me.EndingOdometerTextBox.TabIndex = 6
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(12, 112)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(152, 20)
        Me.NumberOfDaysTextBox.TabIndex = 7
        '
        'TotalMilesDrivenLabel
        '
        Me.TotalMilesDrivenLabel.AutoSize = True
        Me.TotalMilesDrivenLabel.Location = New System.Drawing.Point(211, 9)
        Me.TotalMilesDrivenLabel.Name = "TotalMilesDrivenLabel"
        Me.TotalMilesDrivenLabel.Size = New System.Drawing.Size(58, 13)
        Me.TotalMilesDrivenLabel.TabIndex = 9
        Me.TotalMilesDrivenLabel.Text = "Total Miles"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(12, 144)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(103, 37)
        Me.calculateButton.TabIndex = 10
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'TotalMileDrivenLabel
        '
        Me.TotalMileDrivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalMileDrivenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TotalMileDrivenLabel.Location = New System.Drawing.Point(214, 26)
        Me.TotalMileDrivenLabel.Name = "TotalMileDrivenLabel"
        Me.TotalMileDrivenLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalMileDrivenLabel.TabIndex = 11
        '
        'TotalPriceTextLabel
        '
        Me.TotalPriceTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalPriceTextLabel.Location = New System.Drawing.Point(214, 73)
        Me.TotalPriceTextLabel.Name = "TotalPriceTextLabel"
        Me.TotalPriceTextLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalPriceTextLabel.TabIndex = 12
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.Location = New System.Drawing.Point(211, 57)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(58, 13)
        Me.TotalPriceLabel.TabIndex = 13
        Me.TotalPriceLabel.Text = "Total Price"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(121, 144)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 37)
        Me.clearButton.TabIndex = 14
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(227, 144)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 37)
        Me.exitButton.TabIndex = 15
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'carRentalCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 193)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.TotalPriceLabel)
        Me.Controls.Add(Me.TotalPriceTextLabel)
        Me.Controls.Add(Me.TotalMileDrivenLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.TotalMilesDrivenLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.EndingOdometerTextBox)
        Me.Controls.Add(Me.BeginingOdometerTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerLabel)
        Me.Controls.Add(Me.BeginingOdometerLabel)
        Me.Name = "carRentalCalculator"
        Me.Text = "Car Rental Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BeginingOdometerLabel As Label
    Friend WithEvents EndingOdometerLabel As Label
    Friend WithEvents NumberOfDaysLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BeginingOdometerTextBox As TextBox
    Friend WithEvents EndingOdometerTextBox As TextBox
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents TotalMilesDrivenLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents TotalMileDrivenLabel As Label
    Friend WithEvents TotalPriceTextLabel As Label
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
