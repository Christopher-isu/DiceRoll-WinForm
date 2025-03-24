'ChristopherZ
'Spring 2025
'RCET2265
'Roll of the Dice - Win Forms
'

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all data types to match


Public Class DiceRoll
    Private random As New Random()
    Private rollCounts(11) As Integer

    ' Roll Dice and update ListBox
    Private Sub RollDice()
        ' Clear previous results
        Array.Clear(rollCounts, 0, rollCounts.Length)

        ' Roll two six-sided dice 1,000 times
        For i As Integer = 1 To 1000
            Dim roll1 As Integer = random.Next(1, 7) ' First dice roll
            Dim roll2 As Integer = random.Next(1, 7) ' Second dice roll
            Dim sum As Integer = roll1 + roll2 ' Sum of dice rolls
            rollCounts(sum - 2) += 1 ' Increment the count for the sum of the dice rolls
        Next

        ' Display results in ListBox
        ResultListBox.Items.Clear()

        ' First row: possible roll sums
        Dim topRow As String = String.Join("  |  ", Enumerable.Range(2, 11).Select(Function(i) i.ToString().PadLeft(4).PadRight(4)))
        ResultListBox.Items.Add("Roll Results")
        ResultListBox.Items.Add(New String("="c, topRow.Length))
        ResultListBox.Items.Add(topRow)

        ' Separator row
        Dim separatorRow As String = String.Join("", Enumerable.Range(2, 11).Select(Function(i) "-------"))
        ResultListBox.Items.Add(separatorRow)

        ' Bottom row: counts of each roll result
        Dim bottomRow As String = String.Join(" | ", rollCounts.Select(Function(count) count.ToString().PadLeft(3)))
        ResultListBox.Items.Add(bottomRow)
    End Sub

    ' Event handler for Roll button
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollDice()
    End Sub

    ' Event handler for Clear button
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResultListBox.Items.Clear()
    End Sub

    ' Event handler for Exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
