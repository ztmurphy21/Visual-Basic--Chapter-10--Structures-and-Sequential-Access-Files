' Name:         Paper Project
' Purpose:      Displays the price of an item
' Programmer:   Zach Murphy on 4-13-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Structure ProductInfo
        Public strId As String
        Public dblPrice As Double
    End Structure

    ' declare array of structure variables
    Private priceList(4) As ProductInfo

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' display an item's price

        Dim strSearchId As String
        Dim intSub As Integer
        Dim dblItemPrice As Double

        strSearchId = txtId.Text

        ' search the pricelist array until the
        ' end of the array or the ID is found
        Do Until intSub = priceList.Length OrElse
            priceList(intSub).strId = strSearchId
            intSub += 1
        Loop

        If intSub < priceList.Length Then
            dblItemPrice = priceList(intSub).dblPrice
            If chkDisc.Checked Then
                dblItemPrice *= 0.9
            End If
            lblPrice.Text = dblItemPrice.ToString("c2")
        Else
            MessageBox.Show("Invalid ID", "Paper Warehouse",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub ClearPrice(sender As Object, e As EventArgs) Handles txtId.TextChanged, chkDisc.CheckedChanged
        lblPrice.Text = String.Empty
    End Sub
End Class
