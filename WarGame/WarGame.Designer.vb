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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarGame))
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.RoundsTextBox = New System.Windows.Forms.TextBox()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.Player1WinsTextBox = New System.Windows.Forms.TextBox()
        Me.Player2WinsTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.SolveTieButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Player2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player1PictureBox = New System.Windows.Forms.PictureBox()
        Me.TopToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DrawToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DrawCardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NewGameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NewGameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SolveTieToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SolveTieToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExitToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ExitToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GeneralToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(663, 372)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(125, 66)
        Me.DrawButton.TabIndex = 0
        Me.DrawButton.Text = "Draw Cards"
        Me.GeneralToolTip.SetToolTip(Me.DrawButton, "By pressing this button, the ENTER key or the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Top Draw Card Button, it will disp" &
        "lay each" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "players card for each round.")
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'RoundsTextBox
        '
        Me.RoundsTextBox.Location = New System.Drawing.Point(248, 228)
        Me.RoundsTextBox.Name = "RoundsTextBox"
        Me.RoundsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.RoundsTextBox.TabIndex = 4
        Me.GeneralToolTip.SetToolTip(Me.RoundsTextBox, "Displays the number of rounds played")
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(663, 300)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(125, 66)
        Me.NewGameButton.TabIndex = 5
        Me.NewGameButton.Text = "&New Game"
        Me.GeneralToolTip.SetToolTip(Me.NewGameButton, "By pressing this button, the N key and the top new game button " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is starts a new " &
        "game. It can only be used after one game ended.")
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'Player1WinsTextBox
        '
        Me.Player1WinsTextBox.Location = New System.Drawing.Point(12, 416)
        Me.Player1WinsTextBox.Name = "Player1WinsTextBox"
        Me.Player1WinsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Player1WinsTextBox.TabIndex = 6
        Me.GeneralToolTip.SetToolTip(Me.Player1WinsTextBox, "Displays the number of rounds won by player 1")
        '
        'Player2WinsTextBox
        '
        Me.Player2WinsTextBox.Location = New System.Drawing.Point(481, 416)
        Me.Player2WinsTextBox.Name = "Player2WinsTextBox"
        Me.Player2WinsTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Player2WinsTextBox.TabIndex = 7
        Me.GeneralToolTip.SetToolTip(Me.Player2WinsTextBox, "Displays the number of rounds won by player 2")
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(177, 174)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(315, 22)
        Me.ResultTextBox.TabIndex = 3
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GeneralToolTip.SetToolTip(Me.ResultTextBox, "Displays who wins the round, if there is a tie and who wins the game")
        '
        'SolveTieButton
        '
        Me.SolveTieButton.Location = New System.Drawing.Point(663, 228)
        Me.SolveTieButton.Name = "SolveTieButton"
        Me.SolveTieButton.Size = New System.Drawing.Size(125, 66)
        Me.SolveTieButton.TabIndex = 12
        Me.SolveTieButton.Text = "Solve &Tie"
        Me.GeneralToolTip.SetToolTip(Me.SolveTieButton, "When there is a tie, by pressing this button the tie will be solved. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By pressin" &
        "g T key and the top Solve Tie button this action can be made.")
        Me.SolveTieButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(663, 152)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(125, 66)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.GeneralToolTip.SetToolTip(Me.ExitButton, "Closes the program when is pressed. Also works" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " using the ESC key and the Top Ex" &
        "it button.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.Location = New System.Drawing.Point(498, 97)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(159, 197)
        Me.Player2PictureBox.TabIndex = 9
        Me.Player2PictureBox.TabStop = False
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.Location = New System.Drawing.Point(12, 97)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(159, 197)
        Me.Player1PictureBox.TabIndex = 8
        Me.Player1PictureBox.TabStop = False
        Me.GeneralToolTip.SetToolTip(Me.Player1PictureBox, "Displays player 1's cards")
        '
        'TopToolStrip
        '
        Me.TopToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawToolStripLabel, Me.DrawCardToolStripButton, Me.NewGameToolStripLabel, Me.NewGameToolStripButton, Me.SolveTieToolStripLabel, Me.SolveTieToolStripButton, Me.ExitToolStripLabel, Me.ExitToolStripButton})
        Me.TopToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStrip.Name = "TopToolStrip"
        Me.TopToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.TopToolStrip.TabIndex = 14
        Me.TopToolStrip.Text = "TopToolStrip"
        '
        'DrawToolStripLabel
        '
        Me.DrawToolStripLabel.Name = "DrawToolStripLabel"
        Me.DrawToolStripLabel.Size = New System.Drawing.Size(79, 24)
        Me.DrawToolStripLabel.Text = "Draw Card"
        '
        'DrawCardToolStripButton
        '
        Me.DrawCardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DrawCardToolStripButton.Image = CType(resources.GetObject("DrawCardToolStripButton.Image"), System.Drawing.Image)
        Me.DrawCardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DrawCardToolStripButton.Name = "DrawCardToolStripButton"
        Me.DrawCardToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.DrawCardToolStripButton.Text = "Draw Card"
        Me.DrawCardToolStripButton.ToolTipText = "By pressing this button, the ENTER key or the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Main Draw Card Button, it will dis" &
    "play each" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "players card for each round."
        '
        'NewGameToolStripLabel
        '
        Me.NewGameToolStripLabel.Name = "NewGameToolStripLabel"
        Me.NewGameToolStripLabel.Size = New System.Drawing.Size(82, 24)
        Me.NewGameToolStripLabel.Text = "New Game"
        '
        'NewGameToolStripButton
        '
        Me.NewGameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewGameToolStripButton.Image = CType(resources.GetObject("NewGameToolStripButton.Image"), System.Drawing.Image)
        Me.NewGameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewGameToolStripButton.Name = "NewGameToolStripButton"
        Me.NewGameToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.NewGameToolStripButton.Text = "New Game"
        Me.NewGameToolStripButton.ToolTipText = "By pressing this button, the N key and the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "main new game button is starts a new" &
    " game. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It can only be used once the current game is done."
        '
        'SolveTieToolStripLabel
        '
        Me.SolveTieToolStripLabel.Name = "SolveTieToolStripLabel"
        Me.SolveTieToolStripLabel.Size = New System.Drawing.Size(69, 24)
        Me.SolveTieToolStripLabel.Text = "Solve Tie"
        '
        'SolveTieToolStripButton
        '
        Me.SolveTieToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SolveTieToolStripButton.Image = CType(resources.GetObject("SolveTieToolStripButton.Image"), System.Drawing.Image)
        Me.SolveTieToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SolveTieToolStripButton.Name = "SolveTieToolStripButton"
        Me.SolveTieToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.SolveTieToolStripButton.Text = "Solve Tie"
        Me.SolveTieToolStripButton.ToolTipText = "When there is a tie, by pressing this button " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the tie will be solved. By pressin" &
    "g T key and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the top Solve Tie button this action can be made."
        '
        'ExitToolStripLabel
        '
        Me.ExitToolStripLabel.Name = "ExitToolStripLabel"
        Me.ExitToolStripLabel.Size = New System.Drawing.Size(33, 24)
        Me.ExitToolStripLabel.Text = "Exit"
        '
        'ExitToolStripButton
        '
        Me.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitToolStripButton.Image = CType(resources.GetObject("ExitToolStripButton.Image"), System.Drawing.Image)
        Me.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolStripButton.Name = "ExitToolStripButton"
        Me.ExitToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.ExitToolStripButton.Text = "ExitToolStripButton"
        Me.ExitToolStripButton.ToolTipText = "Closes the program when is pressed. Also works " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using the ESC key and the Top Ex" &
    "it button."
        '
        'WarGame
        '
        Me.AcceptButton = Me.DrawButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TopToolStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SolveTieButton)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Controls.Add(Me.Player2WinsTextBox)
        Me.Controls.Add(Me.Player1WinsTextBox)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.RoundsTextBox)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.DrawButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WarGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "War Game"
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopToolStrip.ResumeLayout(False)
        Me.TopToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawButton As Button
    Friend WithEvents RoundsTextBox As TextBox
    Friend WithEvents NewGameButton As Button
    Friend WithEvents Player1WinsTextBox As TextBox
    Friend WithEvents Player2WinsTextBox As TextBox
    Friend WithEvents Player1PictureBox As PictureBox
    Friend WithEvents Player2PictureBox As PictureBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents SolveTieButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TopToolStrip As ToolStrip
    Friend WithEvents DrawToolStripLabel As ToolStripLabel
    Friend WithEvents DrawCardToolStripButton As ToolStripButton
    Friend WithEvents NewGameToolStripLabel As ToolStripLabel
    Friend WithEvents NewGameToolStripButton As ToolStripButton
    Friend WithEvents SolveTieToolStripLabel As ToolStripLabel
    Friend WithEvents SolveTieToolStripButton As ToolStripButton
    Friend WithEvents ExitToolStripLabel As ToolStripLabel
    Friend WithEvents ExitToolStripButton As ToolStripButton
    Friend WithEvents GeneralToolTip As ToolTip
End Class
