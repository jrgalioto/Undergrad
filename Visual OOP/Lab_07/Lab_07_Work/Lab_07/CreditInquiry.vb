'Project: StreamReader
'Author: Jim Galioto 
'Date: Spring 2019 
'Description: 
' Read a file sequentially and display contents based on
' account type specified by user (credit, debit or zero balances).
Imports System.IO ' using classes from this namespace

Public Class CreditInquiry
    'class level variables/objects
    Dim FileNameString As String    'holds file to be opened
    Enum AccountType
        POSITIVE
        NEGATIVE
        ZERO
    End Enum

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'figure out file name to open
        Dim FileDialogResult As DialogResult    'stores the button they clicked (open/cancel)

        'create dialog box to get file to open
        Dim AccountOpenFileDialog As New OpenFileDialog

        'opens it on the screen
        FileDialogResult = AccountOpenFileDialog.ShowDialog()
        FileNameString = AccountOpenFileDialog.FileName

        'check which button
        If FileDialogResult <> Windows.Forms.DialogResult.Cancel Then
            'they did not click 'cancel'
            'the clicked 'open'
            'eneable the buton to read file
            creditBalancesButton.Enabled = True
            debitBalancesButton.Enabled = True
            zeroBalancesButton.Enabled = True

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub debitBalancesButton_Click(sender As Object, e As EventArgs) Handles debitBalancesButton.Click
        'display all positive balances
        DisplayAccounts(AccountType.POSITIVE)

    End Sub

    Sub DisplayAccounts(inAccountType As AccountType)
        'open file, loop through and display records
        Dim AccountStreamReader As StreamReader
        accountsTextBox.Text = "The accounts are: " & vbCrLf

        'open the file
        Try
            AccountStreamReader = New StreamReader(FileNameString)
            'I have opened the stream
            'created the stream reader

            'loop one line at a time until end of file
            Do While Not AccountStreamReader.EndOfStream

                'read one line
                Dim LineString As String = AccountStreamReader.ReadLine
                Dim FieldString() As String = LineString.Split(","c)    'splits items, separated by commas, into an array

                'analize that line
                Dim AccountString As String = FieldString(0)
                Dim FirstNameString As String = FieldString(1)
                Dim LastNameString As String = FieldString(2)
                Dim BalanceDecimal As Decimal
                BalanceDecimal = Convert.ToDecimal(FieldString(3))

                'display result
                If ShouldDisplay(BalanceDecimal, inAccountType) Then

                    'show that line
                    accountsTextBox.AppendText(AccountString & vbTab &
                                               FirstNameString & vbTab &
                                               LastNameString & vbTab &
                                               BalanceDecimal.ToString("c") & vbCrLf)
                End If
            Loop

        Catch ex As IOException
            'open file failed
            MessageBox.Show("WRONG!")

        Finally
            Try
                'close the file
                AccountStreamReader.Close()
            Catch ex As IOException
                MessageBox.Show("The Close Failed.")
            End Try


        End Try

    End Sub

    Function ShouldDisplay(inBalanceDecimal As Decimal,
                           inAccountType As AccountType) As Boolean

        If inBalanceDecimal > 0 And inAccountType = AccountType.POSITIVE Then
            Return True
        ElseIf inBalanceDecimal = 0 And inAccountType = AccountType.ZERO Then
            Return True
        ElseIf inBalanceDecimal < 0 And inAccountType = AccountType.NEGATIVE Then
            Return True

        Else
            'DON'T  SHOW IT
            Return False

        End If
    End Function

    Private Sub creditBalancesButton_Click(sender As Object, e As EventArgs) Handles creditBalancesButton.Click
        DisplayAccounts(AccountType.NEGATIVE)
    End Sub

    Private Sub zeroBalancesButton_Click(sender As Object, e As EventArgs) Handles zeroBalancesButton.Click
        DisplayAccounts(AccountType.ZERO)
    End Sub
End Class ' Credit Inquiry

