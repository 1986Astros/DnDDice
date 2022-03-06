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
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureAndSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.IntervalToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveThisDieFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tlpMain.SuspendLayout()
        Me.tlpRollX.SuspendLayout()
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.btnRoll, 0, 2)
        Me.tlpMain.Controls.Add(Me.lvCounts, 1, 1)
        Me.tlpMain.Controls.Add(Me.tlpRollX, 1, 2)
        Me.tlpMain.Controls.Add(Me.DieControl1, 0, 1)
        Me.tlpMain.Controls.Add(Me.MainMenuStrip, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(305, 211)
        Me.tlpMain.TabIndex = 0
        '
        'btnRoll
        '
        Me.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll.Location = New System.Drawing.Point(40, 184)
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
        Me.lvCounts.Location = New System.Drawing.Point(159, 27)
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
        Me.tlpRollX.Location = New System.Drawing.Point(171, 180)
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
        Me.DieControl1.Location = New System.Drawing.Point(3, 27)
        Me.DieControl1.Name = "DieControl1"
        Me.DieControl1.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.HorizontalAxis
        Me.DieControl1.Sides = 6
        Me.DieControl1.Size = New System.Drawing.Size(150, 150)
        Me.DieControl1.TabIndex = 4
        Me.DieControl1.Value = 6
        '
        'MainMenuStrip
        '
        Me.tlpMain.SetColumnSpan(Me.MainMenuStrip, 2)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AnimationToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(305, 24)
        Me.MainMenuStrip.TabIndex = 5
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ConfigureAndSaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ConfigureAndSaveToolStripMenuItem
        '
        Me.ConfigureAndSaveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ConfigureAndSaveToolStripMenuItem.Name = "ConfigureAndSaveToolStripMenuItem"
        Me.ConfigureAndSaveToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConfigureAndSaveToolStripMenuItem.Text = "Configure and save ..."
        '
        'AnimationToolStripMenuItem
        '
        Me.AnimationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AnimationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.VerticalAxisToolStripMenuItem, Me.HorizontalAxisToolStripMenuItem, Me.FadeToolStripMenuItem, Me.SpinToolStripMenuItem, Me.ToolStripSeparator1, Me.IntervalToolStripComboBox})
        Me.AnimationToolStripMenuItem.Name = "AnimationToolStripMenuItem"
        Me.AnimationToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AnimationToolStripMenuItem.Text = "No animation"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.CheckOnClick = True
        Me.NoneToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NoneToolStripMenuItem.Tag = "0"
        Me.NoneToolStripMenuItem.Text = "No animation"
        '
        'VerticalAxisToolStripMenuItem
        '
        Me.VerticalAxisToolStripMenuItem.CheckOnClick = True
        Me.VerticalAxisToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.VerticalAxisToolStripMenuItem.Name = "VerticalAxisToolStripMenuItem"
        Me.VerticalAxisToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VerticalAxisToolStripMenuItem.Tag = "1"
        Me.VerticalAxisToolStripMenuItem.Text = "Vertical axis"
        '
        'HorizontalAxisToolStripMenuItem
        '
        Me.HorizontalAxisToolStripMenuItem.CheckOnClick = True
        Me.HorizontalAxisToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HorizontalAxisToolStripMenuItem.Name = "HorizontalAxisToolStripMenuItem"
        Me.HorizontalAxisToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HorizontalAxisToolStripMenuItem.Tag = "2"
        Me.HorizontalAxisToolStripMenuItem.Text = "Horizontal Axis"
        '
        'FadeToolStripMenuItem
        '
        Me.FadeToolStripMenuItem.CheckOnClick = True
        Me.FadeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FadeToolStripMenuItem.Name = "FadeToolStripMenuItem"
        Me.FadeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.FadeToolStripMenuItem.Tag = "3"
        Me.FadeToolStripMenuItem.Text = "Fade"
        '
        'SpinToolStripMenuItem
        '
        Me.SpinToolStripMenuItem.CheckOnClick = True
        Me.SpinToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SpinToolStripMenuItem.Name = "SpinToolStripMenuItem"
        Me.SpinToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SpinToolStripMenuItem.Tag = "4"
        Me.SpinToolStripMenuItem.Text = "Spin"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'IntervalToolStripComboBox
        '
        Me.IntervalToolStripComboBox.Items.AddRange(New Object() {"100 ms", "250 ms", "500 ms", "750 ms", "1000 ms", "2000 ms"})
        Me.IntervalToolStripComboBox.Name = "IntervalToolStripComboBox"
        Me.IntervalToolStripComboBox.Size = New System.Drawing.Size(121, 23)
        Me.IntervalToolStripComboBox.Text = "1000 ms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SaveThisDieFileDialog
        '
        Me.SaveThisDieFileDialog.DefaultExt = "bmp"
        Me.SaveThisDieFileDialog.Filter = "Bitmap|*.bmp|Png|*.png|Jpeg|*,jpg,*.jpeg|Gif|*.gif"
        Me.SaveThisDieFileDialog.Title = "Save die to file"
        '
        'DieConsoleControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tlpMain)
        Me.DoubleBuffered = True
        Me.Name = "DieConsoleControl"
        Me.Size = New System.Drawing.Size(305, 211)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpRollX.ResumeLayout(False)
        Me.tlpRollX.PerformLayout()
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
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
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalAxisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalAxisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents IntervalToolStripComboBox As ToolStripComboBox
    Friend WithEvents SaveThisDieFileDialog As SaveFileDialog
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigureAndSaveToolStripMenuItem As ToolStripMenuItem
End Class
