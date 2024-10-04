<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarGame
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
        Me.ThrowButton = New System.Windows.Forms.Button()
        Me.Card1TextBox = New System.Windows.Forms.TextBox()
        Me.Card2TextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.RoundsTextBox = New System.Windows.Forms.TextBox()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.Player1WinsTextBox = New System.Windows.Forms.TextBox()
        Me.Player2WinsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ThrowButton
        '
        Me.ThrowButton.Location = New System.Drawing.Point(613, 338)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(125, 66)
        Me.ThrowButton.TabIndex = 0
        Me.ThrowButton.Text = "Throw Cards"
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'Card1TextBox
        '
        Me.Card1TextBox.Location = New System.Drawing.Point(56, 360)
        Me.Card1TextBox.Name = "Card1TextBox"
        Me.Card1TextBox.Size = New System.Drawing.Size(176, 22)
        Me.Card1TextBox.TabIndex = 1
        '
        'Card2TextBox
        '
        Me.Card2TextBox.Location = New System.Drawing.Point(420, 360)
        Me.Card2TextBox.Name = "Card2TextBox"
        Me.Card2TextBox.Size = New System.Drawing.Size(176, 22)
        Me.Card2TextBox.TabIndex = 2
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(238, 360)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(176, 22)
        Me.ResultTextBox.TabIndex = 3
        '
        'RoundsTextBox
        '
        Me.RoundsTextBox.Location = New System.Drawing.Point(238, 388)
        Me.RoundsTextBox.Name = "RoundsTextBox"
        Me.RoundsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.RoundsTextBox.TabIndex = 4
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(613, 266)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(125, 66)
        Me.NewGameButton.TabIndex = 5
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'Player1WinsTextBox
        '
        Me.Player1WinsTextBox.Location = New System.Drawing.Point(56, 388)
        Me.Player1WinsTextBox.Name = "Player1WinsTextBox"
        Me.Player1WinsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Player1WinsTextBox.TabIndex = 6
        '
        'Player2WinsTextBox
        '
        Me.Player2WinsTextBox.Location = New System.Drawing.Point(420, 388)
        Me.Player2WinsTextBox.Name = "Player2WinsTextBox"
        Me.Player2WinsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Player2WinsTextBox.TabIndex = 7
        '
        'WarGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Player2WinsTextBox)
        Me.Controls.Add(Me.Player1WinsTextBox)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.RoundsTextBox)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.Card2TextBox)
        Me.Controls.Add(Me.Card1TextBox)
        Me.Controls.Add(Me.ThrowButton)
        Me.Name = "WarGame"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThrowButton As Button
    Friend WithEvents Card1TextBox As TextBox
    Friend WithEvents Card2TextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents RoundsTextBox As TextBox
    Friend WithEvents NewGameButton As Button
    Friend WithEvents Player1WinsTextBox As TextBox
    Friend WithEvents Player2WinsTextBox As TextBox
End Class
