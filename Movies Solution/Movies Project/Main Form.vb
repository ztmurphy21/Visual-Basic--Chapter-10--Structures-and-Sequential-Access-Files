' Name:         Movies Project
' Purpose:      Allows the user to add movie titles to and delete movie titles from a combo box.
'               Also reads movie titles from and writes movie titles to a sequential access file.
' Programmer:   Zach Murphy on 4-18-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fills list box wth data from txt file
        Dim inFile As IO.StreamReader
        Dim strInfo As String

        'check if file exist
        If IO.File.Exists("movies.txt") Then
            'open file for input
            inFile = IO.File.OpenText("movies.txt")
            'loop until end of file
            Do Until inFile.Peek = -1
                strInfo = inFile.ReadLine
                cboMovies.Items.Add(strInfo)
            Loop
            inFile.Close()
            'select first in line

        Else
            MessageBox.Show("Can't find file movies.txt.", "Movies", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add info to cbo box 

        'declarations
        Dim strMovie As String

        'get text
        strMovie = cboMovies.Text

        'add to cbo list
        cboMovies.Items.Add(strMovie)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'remove line if line is selected 
        If cboMovies.SelectedIndex <> -1 Then
            cboMovies.Items.RemoveAt(cboMovies.SelectedIndex)
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'declarations 
        Dim outFile As IO.StreamWriter

        'open file for output
        outFile = IO.File.CreateText("movies.txt")

        'write each line 
        For intIndex As Integer = 0 To cboMovies.Items.Count - 1
            outFile.WriteLine(cboMovies.Items(intIndex))
        Next intIndex

        'close file 
        outFile.Close()
    End Sub
End Class
