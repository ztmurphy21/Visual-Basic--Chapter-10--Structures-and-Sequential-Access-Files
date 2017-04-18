' Name:         Bonus Project
' Purpose:      Writes bonus amounts to a sequential access file.
'               Also reads the file and displays its contents.
' Programmer:   Zach Murphy on 4-18-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'reads info from bonus.txt
        'displays info

        'declarations
        Dim inFile As IO.StreamReader
        Dim strBonus As String

        'clear any previous bonuses
        lstContents.Items.Clear()

        'make sure file exists
        If IO.File.Exists("bonus.txt") Then
            'open file
            inFile = IO.File.OpenText("bonus.txt")
            'loop for reading till end of file
            Do Until inFile.Peek = -1
                'read bonus
                strBonus = inFile.ReadLine
                'add bonus to box
                lstContents.Items.Add(strBonus)
            Loop
            'closes file
            inFile.Close()
        Else
            MessageBox.Show("Can't find the file", "Company Bonuses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'this function saves input data to bonus.txt in bin/debug


        'declare file var
        Dim outFile As IO.StreamWriter

        'open file
        outFile = IO.File.AppendText("bonus.txt")
        'write the name on a seperate line
        outFile.WriteLine(txtBonus.Text)
        'close the file
        outFile.Close()

        'clear list box
        lstContents.Items.Clear()

        'set focus to bonuus input box
        txtBonus.Focus()
    End Sub

    Private Sub txtBonus_Enter(sender As Object, e As EventArgs) Handles txtBonus.Enter
        txtBonus.SelectAll()
    End Sub

    Private Sub txtBonus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBonus.KeyPress
        ' allows the text box to accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBonus_TextChanged(sender As Object, e As EventArgs) Handles txtBonus.TextChanged
        lstContents.Items.Clear()
    End Sub
End Class
