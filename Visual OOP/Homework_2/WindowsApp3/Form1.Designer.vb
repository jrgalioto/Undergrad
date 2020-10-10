<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoffeeOrderForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CoffeeSelectionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ItemAmountTextLabel = New System.Windows.Forms.Label()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.TakeoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.CoffeeSelectionsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CoffeeSelectionsGroupBox)
        Me.GroupBox1.Controls.Add(Me.ItemAmountTextLabel)
        Me.GroupBox1.Controls.Add(Me.ItemAmountLabel)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.CalculateButton)
        Me.GroupBox1.Controls.Add(Me.TakeoutCheckBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(513, 236)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'CoffeeSelectionsGroupBox
        '
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.IcedLatteRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.LatteRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.EspressoRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.CappuccinoRadioButton)
        Me.CoffeeSelectionsGroupBox.Location = New System.Drawing.Point(309, 34)
        Me.CoffeeSelectionsGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CoffeeSelectionsGroupBox.Name = "CoffeeSelectionsGroupBox"
        Me.CoffeeSelectionsGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.CoffeeSelectionsGroupBox.Size = New System.Drawing.Size(187, 174)
        Me.CoffeeSelectionsGroupBox.TabIndex = 7
        Me.CoffeeSelectionsGroupBox.TabStop = False
        Me.CoffeeSelectionsGroupBox.Text = "Coffee Selections"
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(9, 140)
        Me.IcedCappuccinoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(133, 21)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.Text = "Iced Cappuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(9, 113)
        Me.IcedLatteRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(91, 21)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.Text = "Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(9, 84)
        Me.LatteRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(61, 21)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.Text = "Latte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(9, 54)
        Me.EspressoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(88, 21)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.Text = "Espresso"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Checked = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(9, 25)
        Me.CappuccinoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(103, 21)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "Cappuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'ItemAmountTextLabel
        '
        Me.ItemAmountTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemAmountTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemAmountTextLabel.Location = New System.Drawing.Point(125, 167)
        Me.ItemAmountTextLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemAmountTextLabel.Name = "ItemAmountTextLabel"
        Me.ItemAmountTextLabel.Size = New System.Drawing.Size(133, 28)
        Me.ItemAmountTextLabel.TabIndex = 6
        '
        'ItemAmountLabel
        '
        Me.ItemAmountLabel.AutoSize = True
        Me.ItemAmountLabel.Location = New System.Drawing.Point(8, 175)
        Me.ItemAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemAmountLabel.Name = "ItemAmountLabel"
        Me.ItemAmountLabel.Size = New System.Drawing.Size(90, 17)
        Me.ItemAmountLabel.TabIndex = 5
        Me.ItemAmountLabel.Text = "Item Amount:"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(137, 96)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(121, 43)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(8, 96)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(121, 43)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'TakeoutCheckBox
        '
        Me.TakeoutCheckBox.AutoSize = True
        Me.TakeoutCheckBox.Location = New System.Drawing.Point(13, 70)
        Me.TakeoutCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TakeoutCheckBox.Name = "TakeoutCheckBox"
        Me.TakeoutCheckBox.Size = New System.Drawing.Size(90, 21)
        Me.TakeoutCheckBox.TabIndex = 2
        Me.TakeoutCheckBox.Text = "Takeout?"
        Me.TakeoutCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(81, 34)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(132, 22)
        Me.QuantityTextBox.TabIndex = 1
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(8, 38)
        Me.QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(65, 17)
        Me.QuantityLabel.TabIndex = 0
        Me.QuantityLabel.Text = "Quantity:"
        '
        'CoffeeOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 266)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CoffeeOrderForm"
        Me.Text = "Coffee Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CoffeeSelectionsGroupBox.ResumeLayout(False)
        Me.CoffeeSelectionsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ItemAmountLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents TakeoutCheckBox As CheckBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents CoffeeSelectionsGroupBox As GroupBox
    Friend WithEvents IcedCappuccinoRadioButton As RadioButton
    Friend WithEvents IcedLatteRadioButton As RadioButton
    Friend WithEvents LatteRadioButton As RadioButton
    Friend WithEvents EspressoRadioButton As RadioButton
    Friend WithEvents CappuccinoRadioButton As RadioButton
    Friend WithEvents ItemAmountTextLabel As Label
End Class
