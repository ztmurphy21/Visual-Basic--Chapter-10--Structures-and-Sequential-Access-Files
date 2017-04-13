' Name:         Ebook Project
' Purpose:      Adds and deletes list box entries
'               Reads information from a sequential access file
'               Writes information to a sequential access file
' Programmer:   Zach Murphy on 4-13-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with data from 
        ' a sequential access file
        Dim inFile As IO.StreamReader
        Dim strInfo As String

        'verify that the file exists
        If IO.File.Exists("Ebooks.txt") Then
            'open the file for input
            inFile = IO.File.OpenText("Ebooks.txt")
            'process loop instructions until end of file
            Do Until inFile.Peek = -1
                strInfo = inFile.ReadLine
                lstEbooks.Items.Add(strInfo)
            Loop
            inFile.Close()
            'select the first line in the list box
            lstEbooks.SelectedIndex = 0
        Else
            MessageBox.Show("Can't find the Ebooks.txt file", "eBooks", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds eBook information to the list box

        ' declare variables
        Dim strTitle As String
        Dim strAuthor As String
        Dim strPrice As String
        Dim strConcatenatedInfo As String
        Dim dblPrice As Double
        ' get the eBook information
        strTitle = InputBox("Title:", "eBooks")
        strAuthor = InputBox("Author:", "eBooks")
        strPrice = InputBox("Price:", "eBooks")
        ' format the price, then concatenate the input
        ' items, using 40 characters for the title, 
        ' 35 characters for the author, and 5 
        ' characters for the price
        Double.TryParse(strPrice, dblPrice)
        strPrice = dblPrice.ToString("n2")
        strConcatenatedInfo = strTitle.PadRight(40) & strAuthor.PadRight(35) & strPrice.PadLeft(5)
        ' add the information to the list box
        lstEbooks.Items.Add(strConcatenatedInfo)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' removes the selected line from the list box

        ' if a line is selected, remove the line
        If lstEbooks.SelectedIndex <> -1 Then
            lstEbooks.Items.RemoveAt(lstEbooks.SelectedIndex)
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter
        ' open the file for output
        outFile = IO.File.CreateText("Ebooks.txt")
        ' write each line in the list box
        For intIndex As Integer = 0 To lstEbooks.Items.Count - 1
            outFile.WriteLine(lstEbooks.Items(intIndex))
        Next intIndex

        ' close the file
        outFile.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
