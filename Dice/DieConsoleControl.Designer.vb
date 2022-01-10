<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DieConsoleControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lvCounts = New System.Windows.Forms.ListView()
        Me.chEmpty = New System.Windows.Forms.ColumnHeader()
        Me.chRoll = New System.Windows.Forms.ColumnHeader()
        Me.chCount = New System.Windows.Forms.ColumnHeader()
        Me.chPct = New System.Windows.Forms.ColumnHeader()
        Me.chScrollBar = New System.Windows.Forms.ColumnHeader()
        Me.tlpRollX = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRollx = New System.Windows.Forms.Button()
        Me.nudRollCount = New System.Windows.Forms.NumericUpDown()
        Me.DieControl1 = New Dice.DieControl()
        Me.tlpMain.SuspendLayout()
        Me.tlpRollX.SuspendLayout()
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.btnRoll, 0, 1)
        Me.tlpMain.Controls.Add(Me.lvCounts, 1, 0)
        Me.tlpMain.Controls.Add(Me.tlpRollX, 1, 1)
        Me.tlpMain.Controls.Add(Me.DieControl1, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(305, 187)
        Me.tlpMain.TabIndex = 0
        '
        'btnRoll
        '
        Me.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll.Location = New System.Drawing.Point(40, 160)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lvCounts
        '
        Me.lvCounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chEmpty, Me.chRoll, Me.chCount, Me.chPct, Me.chScrollBar})
        Me.lvCounts.FullRowSelect = True
        Me.lvCounts.GridLines = True
        Me.lvCounts.HideSelection = False
        Me.lvCounts.Location = New System.Drawing.Point(159, 3)
        Me.lvCounts.Name = "lvCounts"
        Me.lvCounts.Size = New System.Drawing.Size(143, 97)
        Me.lvCounts.TabIndex = 3
        Me.lvCounts.UseCompatibleStateImageBehavior = False
        Me.lvCounts.View = System.Windows.Forms.View.Details
        '
        'chEmpty
        '
        Me.chEmpty.Text = ""
        Me.chEmpty.Width = 0
        '
        'chRoll
        '
        Me.chRoll.Text = "#"
        Me.chRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chRoll.Width = 25
        '
        'chCount
        '
        Me.chCount.Text = "Count"
        Me.chCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chCount.Width = 45
        '
        'chPct
        '
        Me.chPct.Text = "Pct"
        Me.chPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chPct.Width = 45
        '
        'chScrollBar
        '
        Me.chScrollBar.Text = ""
        Me.chScrollBar.Width = 0
        '
        'tlpRollX
        '
        Me.tlpRollX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpRollX.AutoSize = True
        Me.tlpRollX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRollX.ColumnCount = 2
        Me.tlpRollX.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRollX.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRollX.Controls.Add(Me.btnRollx, 0, 0)
        Me.tlpRollX.Controls.Add(Me.nudRollCount, 1, 0)
        Me.tlpRollX.Location = New System.Drawing.Point(171, 156)
        Me.tlpRollX.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRollX.Name = "tlpRollX"
        Me.tlpRollX.RowCount = 1
        Me.tlpRollX.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRollX.Size = New System.Drawing.Size(119, 31)
        Me.tlpRollX.TabIndex = 1
        '
        'btnRollx
        '
        Me.btnRollx.AutoSize = True
        Me.btnRollx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRollx.Location = New System.Drawing.Point(3, 3)
        Me.btnRollx.Name = "btnRollx"
        Me.btnRollx.Size = New System.Drawing.Size(45, 25)
        Me.btnRollx.TabIndex = 0
        Me.btnRollx.Text = "Roll x"
        Me.btnRollx.UseVisualStyleBackColor = True
        '
        'nudRollCount
        '
        Me.nudRollCount.AutoSize = True
        Me.nudRollCount.Location = New System.Drawing.Point(54, 5)
        Me.nudRollCount.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.nudRollCount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudRollCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudRollCount.Name = "nudRollCount"
        Me.nudRollCount.Size = New System.Drawing.Size(62, 23)
        Me.nudRollCount.TabIndex = 1
        Me.nudRollCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudRollCount.ThousandsSeparator = True
        Me.nudRollCount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'DieControl1
        '
        Me.DieControl1.Location = New System.Drawing.Point(3, 3)
        Me.DieControl1.Name = "DieControl1"
        Me.DieControl1.Sides = 6
        Me.DieControl1.Size = New System.Drawing.Size(150, 150)
        Me.DieControl1.TabIndex = 4
        Me.DieControl1.Value = 6
        '
        'DieConsoleControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "DieConsoleControl"
        Me.Size = New System.Drawing.Size(305, 187)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpRollX.ResumeLayout(False)
        Me.tlpRollX.PerformLayout()
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents btnRoll As Button
    Friend WithEvents tlpRollX As TableLayoutPanel
    Friend WithEvents btnRollx As Button
    Friend WithEvents nudRollCount As NumericUpDown
    Friend WithEvents lvCounts As ListView
    Friend WithEvents chEmpty As ColumnHeader
    Friend WithEvents chRoll As ColumnHeader
    Friend WithEvents chCount As ColumnHeader
    Friend WithEvents chPct As ColumnHeader
    Friend WithEvents chScrollBar As ColumnHeader
    Friend WithEvents DieControl1 As DieControl
End Class
