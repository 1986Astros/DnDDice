<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllDice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllDice))
        Me.tlpAllDice = New System.Windows.Forms.TableLayoutPanel()
        Me.DieConsoleControl1 = New Dice.DieConsoleControl()
        Me.DieConsoleControl2 = New Dice.DieConsoleControl()
        Me.DieConsoleControl3 = New Dice.DieConsoleControl()
        Me.DieConsoleControl4 = New Dice.DieConsoleControl()
        Me.DieConsoleControl5 = New Dice.DieConsoleControl()
        Me.DieConsoleControl6 = New Dice.DieConsoleControl()
        Me.tlpAllDice.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpAllDice
        '
        Me.tlpAllDice.AutoSize = True
        Me.tlpAllDice.ColumnCount = 3
        Me.tlpAllDice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpAllDice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAllDice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAllDice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl1, 0, 0)
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl2, 1, 0)
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl3, 2, 0)
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl4, 0, 1)
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl5, 1, 1)
        Me.tlpAllDice.Controls.Add(Me.DieConsoleControl6, 2, 1)
        Me.tlpAllDice.Location = New System.Drawing.Point(16, 16)
        Me.tlpAllDice.Name = "tlpAllDice"
        Me.tlpAllDice.RowCount = 2
        Me.tlpAllDice.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAllDice.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAllDice.Size = New System.Drawing.Size(999, 476)
        Me.tlpAllDice.TabIndex = 0
        '
        'DieConsoleControl1
        '
        Me.DieConsoleControl1.AutoSize = True
        Me.DieConsoleControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl1.DieFont = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl1.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl1.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl1.FaceColor = System.Drawing.Color.Peru
        Me.DieConsoleControl1.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl1.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl1.Location = New System.Drawing.Point(3, 3)
        Me.DieConsoleControl1.Name = "DieConsoleControl1"
        Me.DieConsoleControl1.RollAnimationInterval = 1000
        Me.DieConsoleControl1.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.HorizontalAxis
        Me.DieConsoleControl1.Sides = 20
        Me.DieConsoleControl1.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl1.TabIndex = 0
        Me.DieConsoleControl1.Value = 20
        Me.DieConsoleControl1.ValueColor = System.Drawing.Color.White
        '
        'DieConsoleControl2
        '
        Me.DieConsoleControl2.AutoSize = True
        Me.DieConsoleControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl2.DieFont = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl2.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl2.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl2.FaceColor = System.Drawing.Color.Black
        Me.DieConsoleControl2.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl2.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl2.Location = New System.Drawing.Point(336, 3)
        Me.DieConsoleControl2.Name = "DieConsoleControl2"
        Me.DieConsoleControl2.RollAnimationInterval = 1000
        Me.DieConsoleControl2.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.HorizontalAxis
        Me.DieConsoleControl2.Sides = 12
        Me.DieConsoleControl2.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl2.TabIndex = 1
        Me.DieConsoleControl2.Value = 12
        Me.DieConsoleControl2.ValueColor = System.Drawing.Color.White
        '
        'DieConsoleControl3
        '
        Me.DieConsoleControl3.AutoSize = True
        Me.DieConsoleControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl3.DieFont = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl3.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl3.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl3.FaceColor = System.Drawing.Color.DarkOrange
        Me.DieConsoleControl3.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl3.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl3.Location = New System.Drawing.Point(668, 3)
        Me.DieConsoleControl3.Name = "DieConsoleControl3"
        Me.DieConsoleControl3.RollAnimationInterval = 1000
        Me.DieConsoleControl3.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.Fade
        Me.DieConsoleControl3.Sides = 10
        Me.DieConsoleControl3.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl3.TabIndex = 2
        Me.DieConsoleControl3.Value = 10
        Me.DieConsoleControl3.ValueColor = System.Drawing.Color.White
        '
        'DieConsoleControl4
        '
        Me.DieConsoleControl4.AutoSize = True
        Me.DieConsoleControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl4.DieFont = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl4.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl4.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl4.FaceColor = System.Drawing.Color.MediumOrchid
        Me.DieConsoleControl4.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl4.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl4.Location = New System.Drawing.Point(3, 241)
        Me.DieConsoleControl4.Name = "DieConsoleControl4"
        Me.DieConsoleControl4.RollAnimationInterval = 1000
        Me.DieConsoleControl4.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.HorizontalAxis
        Me.DieConsoleControl4.Sides = 8
        Me.DieConsoleControl4.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl4.TabIndex = 3
        Me.DieConsoleControl4.Value = 8
        Me.DieConsoleControl4.ValueColor = System.Drawing.Color.White
        '
        'DieConsoleControl5
        '
        Me.DieConsoleControl5.AutoSize = True
        Me.DieConsoleControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl5.DieFont = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl5.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl5.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl5.FaceColor = System.Drawing.Color.YellowGreen
        Me.DieConsoleControl5.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl5.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl5.Location = New System.Drawing.Point(336, 241)
        Me.DieConsoleControl5.Name = "DieConsoleControl5"
        Me.DieConsoleControl5.RollAnimationInterval = 1000
        Me.DieConsoleControl5.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.VerticalAxis
        Me.DieConsoleControl5.Sides = 6
        Me.DieConsoleControl5.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl5.TabIndex = 4
        Me.DieConsoleControl5.Value = 6
        Me.DieConsoleControl5.ValueColor = System.Drawing.Color.White
        '
        'DieConsoleControl6
        '
        Me.DieConsoleControl6.AutoSize = True
        Me.DieConsoleControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DieConsoleControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DieConsoleControl6.DieFont = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieConsoleControl6.DieSize = New System.Drawing.Size(150, 150)
        Me.DieConsoleControl6.EdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl6.FaceColor = System.Drawing.Color.Red
        Me.DieConsoleControl6.HiddenEdgeColor = System.Drawing.Color.White
        Me.DieConsoleControl6.HiddenEdgeWeight = 1.5!
        Me.DieConsoleControl6.Location = New System.Drawing.Point(668, 241)
        Me.DieConsoleControl6.Name = "DieConsoleControl6"
        Me.DieConsoleControl6.RollAnimationInterval = 1000
        Me.DieConsoleControl6.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.None
        Me.DieConsoleControl6.Sides = 4
        Me.DieConsoleControl6.Size = New System.Drawing.Size(301, 213)
        Me.DieConsoleControl6.TabIndex = 5
        Me.DieConsoleControl6.Value = 4
        Me.DieConsoleControl6.ValueColor = System.Drawing.Color.White
        '
        'AllDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 512)
        Me.Controls.Add(Me.tlpAllDice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AllDice"
        Me.Text = "All Dice"
        Me.tlpAllDice.ResumeLayout(False)
        Me.tlpAllDice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpAllDice As TableLayoutPanel
    Friend WithEvents DieConsoleControl1 As DieConsoleControl
    Friend WithEvents DieConsoleControl2 As DieConsoleControl
    Friend WithEvents DieConsoleControl3 As DieConsoleControl
    Friend WithEvents DieConsoleControl4 As DieConsoleControl
    Friend WithEvents DieConsoleControl5 As DieConsoleControl
    Friend WithEvents DieConsoleControl6 As DieConsoleControl
End Class
