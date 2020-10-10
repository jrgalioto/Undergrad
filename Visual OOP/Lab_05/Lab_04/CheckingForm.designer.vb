Partial Public Class CheckingForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChargeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckRadioButton = New System.Windows.Forms.RadioButton()
        Me.DepositRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearTextBox = New System.Windows.Forms.Button()
        Me.CalculateTextBox = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Location = New System.Drawing.Point(208, 34)
        Me.BalanceTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BalanceTextBox.TabIndex = 3
        Me.BalanceTextBox.TabStop = False
        Me.BalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChargeRadioButton)
        Me.GroupBox1.Controls.Add(Me.CheckRadioButton)
        Me.GroupBox1.Controls.Add(Me.DepositRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 148)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'ChargeRadioButton
        '
        Me.ChargeRadioButton.Location = New System.Drawing.Point(11, 108)
        Me.ChargeRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChargeRadioButton.Name = "ChargeRadioButton"
        Me.ChargeRadioButton.Size = New System.Drawing.Size(139, 20)
        Me.ChargeRadioButton.TabIndex = 2
        Me.ChargeRadioButton.Text = "&Service Charge"
        '
        'CheckRadioButton
        '
        Me.CheckRadioButton.Location = New System.Drawing.Point(11, 69)
        Me.CheckRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckRadioButton.Name = "CheckRadioButton"
        Me.CheckRadioButton.Size = New System.Drawing.Size(107, 20)
        Me.CheckRadioButton.TabIndex = 1
        Me.CheckRadioButton.Text = "C&heck"
        '
        'DepositRadioButton
        '
        Me.DepositRadioButton.Location = New System.Drawing.Point(11, 30)
        Me.DepositRadioButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DepositRadioButton.Name = "DepositRadioButton"
        Me.DepositRadioButton.Size = New System.Drawing.Size(117, 20)
        Me.DepositRadioButton.TabIndex = 0
        Me.DepositRadioButton.Text = "&Deposit"
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(208, 209)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 28)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "E&xit"
        '
        'ClearTextBox
        '
        Me.ClearTextBox.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearTextBox.Location = New System.Drawing.Point(208, 137)
        Me.ClearTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClearTextBox.Name = "ClearTextBox"
        Me.ClearTextBox.Size = New System.Drawing.Size(100, 28)
        Me.ClearTextBox.TabIndex = 6
        Me.ClearTextBox.Text = "C&lear"
        '
        'CalculateTextBox
        '
        Me.CalculateTextBox.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CalculateTextBox.Location = New System.Drawing.Point(208, 101)
        Me.CalculateTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CalculateTextBox.Name = "CalculateTextBox"
        Me.CalculateTextBox.Size = New System.Drawing.Size(100, 28)
        Me.CalculateTextBox.TabIndex = 5
        Me.CalculateTextBox.Text = "&Calculate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Balance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter &Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(16, 34)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AmountTextBox.TabIndex = 1
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(208, 173)
        Me.SummaryButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(100, 28)
        Me.SummaryButton.TabIndex = 7
        Me.SummaryButton.Text = "Su&mmary"
        '
        'CheckingForm
        '
        Me.AcceptButton = Me.CalculateTextBox
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearTextBox
        Me.ClientSize = New System.Drawing.Size(335, 256)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearTextBox)
        Me.Controls.Add(Me.CalculateTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CheckingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checking Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChargeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CheckRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DepositRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearTextBox As System.Windows.Forms.Button
    Friend WithEvents CalculateTextBox As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
