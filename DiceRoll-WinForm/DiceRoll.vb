'ChristopherZ
'Spring 2025
'RCET2265
'Roll of the Dice - Win Forms
'https://github.com/Christopher-isu/DiceRoll-WinForm.git

Option Explicit On
Option Strict On

Public Class DiceRoll
    Private random As New Random() ' Random number generator
    Private rollCounts(11) As Integer ' Array to store counts of each possible roll sum

    ' Roll Dice and update ListBox
    Private Sub RollDice() ' Private is used to make sure that the method is only used in this class
        Array.Clear(rollCounts, 0, rollCounts.Length) ' Clear the roll counts array

        For i As Integer = 1 To 1000 ' Roll the dice 1000 times
            Randomize() ' Initialize random number generator
            Dim roll1 As Integer = random.Next(1, 7) ' First dice roll
            Dim roll2 As Integer = random.Next(1, 7) ' Second dice roll
            Dim sum As Integer = roll1 + roll2 ' Sum of dice rolls
            rollCounts(sum - 2) += 1 ' Increment the count for the sum of the dice rolls
        Next

        ' Display results in ListBox
        ResultListBox.Items.Clear()

        ' First row: possible roll sums (aligned)
        Dim topRow As String = String.Join(" | ", Enumerable.Range(2, 11).Select(Function(i) i.ToString().PadLeft(3)))
        'PadLeft(3) ensures that each number is 3 characters wide and values look centered
        ResultListBox.Items.Add("Roll Results") ' Title
        ResultListBox.Items.Add(New String("="c, topRow.Length)) ' Separator
        ResultListBox.Items.Add(topRow) ' Possible roll sums

        ' Continuous separator row
        Dim separatorRow As String = New String("-"c, topRow.Length) ' Separator
        ResultListBox.Items.Add(separatorRow) ' Separator row

        ' Bottom row: counts of each roll result (aligned)
        Dim bottomRow As String = String.Join(" | ", rollCounts.Take(11).Select(Function(count) count.ToString().PadLeft(3)))
        'PadLeft(3) ensures that each number is 3 characters wide and values look centered
        ResultListBox.Items.Add(bottomRow) ' Counts of each roll result
    End Sub

    ' Event handler for Roll button
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollDice() ' When Roll button is clicked, roll the dice and update ListBox
    End Sub

    ' Event handler for Clear button
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResultListBox.Items.Clear() ' When Clear button is clicked, clear the ListBox
    End Sub

    ' Event handler for Exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() ' When Exit button is clicked, close the form.
    End Sub
End Class
