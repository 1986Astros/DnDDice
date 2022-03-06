<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DieSaveDialog
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
        Me.OuterPanel = New System.Windows.Forms.Panel()
        Me.DieControl1 = New Dice.DieControl()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpProperties = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OuterPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tlpProperties.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'OuterPanel
        '
        Me.OuterPanel.AutoScroll = True
        Me.OuterPanel.Controls.Add(Me.DieControl1)
        Me.OuterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OuterPanel.Location = New System.Drawing.Point(0, 0)
        Me.OuterPanel.Name = "OuterPanel"
        Me.OuterPanel.Size = New System.Drawing.Size(256, 333)
        Me.OuterPanel.TabIndex = 0
        '
        'DieControl1
        '
        Me.DieControl1.Location = New System.Drawing.Point(0, 0)
        Me.DieControl1.Name = "DieControl1"
        Me.DieControl1.RollAnimationStyle = Dice.DieControl.RollAnimationStyles.None
        Me.DieControl1.Sides = 6
        Me.DieControl1.Size = New System.Drawing.Size(150, 150)
        Me.DieControl1.TabIndex = 0
        Me.DieControl1.Value = 6
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(3, 3)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(317, 292)
        Me.PropertyGrid1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OuterPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpProperties)
        Me.SplitContainer1.Size = New System.Drawing.Size(583, 333)
        Me.SplitContainer1.SplitterDistance = 256
        Me.SplitContainer1.TabIndex = 2
        '
        'tlpProperties
        '
        Me.tlpProperties.ColumnCount = 1
        Me.tlpProperties.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProperties.Controls.Add(Me.PropertyGrid1, 0, 0)
        Me.tlpProperties.Controls.Add(Me.tlpButtons, 0, 1)
        Me.tlpProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProperties.Location = New System.Drawing.Point(0, 0)
        Me.tlpProperties.Name = "tlpProperties"
        Me.tlpProperties.RowCount = 2
        Me.tlpProperties.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProperties.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProperties.Size = New System.Drawing.Size(323, 333)
        Me.tlpProperties.TabIndex = 2
        '
        'tlpButtons
        '
        Me.tlpButtons.AutoSize = True
        Me.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpButtons.ColumnCount = 2
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpButtons.Controls.Add(Me.btnSave, 0, 0)
        Me.tlpButtons.Controls.Add(Me.btnCancel, 1, 0)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(3, 301)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpButtons.Size = New System.Drawing.Size(317, 29)
        Me.tlpButtons.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(41, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save ..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(200, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bmp"
        Me.SaveFileDialog1.Filter = "Bitmap|*.bmp|Png|*.png|Jpeg|*,jpg,*.jpeg|Gif|*.gif"
        Me.SaveFileDialog1.Title = "Save die to file"
        '
        'DieSaveDialog
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(583, 333)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.MinimizeBox = False
        Me.Name = "DieSaveDialog"
        Me.Text = "Save custom die"
        Me.OuterPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tlpProperties.ResumeLayout(False)
        Me.tlpProperties.PerformLayout()
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OuterPanel As Panel
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tlpProperties As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DieControl1 As DieControl
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
