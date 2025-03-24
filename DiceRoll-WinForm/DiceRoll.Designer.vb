<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceRoll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ResultListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultListBox
        '
        Me.ResultListBox.Font = New System.Drawing.Font("Roboto Slab", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultListBox.FormattingEnabled = True
        Me.ResultListBox.ItemHeight = 23
        Me.ResultListBox.Location = New System.Drawing.Point(12, 12)
        Me.ResultListBox.Name = "ResultListBox"
        Me.ResultListBox.Size = New System.Drawing.Size(556, 349)
        Me.ResultListBox.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(12, 451)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(158, 59)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(410, 451)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(158, 59)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(211, 451)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(158, 59)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DiceRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 521)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ResultListBox)
        Me.Name = "DiceRoll"
        Me.Text = "Dice Roll - WinForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResultListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
End Class
