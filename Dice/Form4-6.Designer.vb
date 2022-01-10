<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_6
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
        Me.tlp4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DieControl4 = New Dice.DieControl()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.chFirst4 = New System.Windows.Forms.ColumnHeader()
        Me.chResult4 = New System.Windows.Forms.ColumnHeader()
        Me.chCount4 = New System.Windows.Forms.ColumnHeader()
        Me.chPct4 = New System.Windows.Forms.ColumnHeader()
        Me.chEmpty4 = New System.Windows.Forms.ColumnHeader()
        Me.btnRoll4 = New System.Windows.Forms.Button()
        Me.btnRoll4x100 = New System.Windows.Forms.Button()
        Me.tlp6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DieControl6 = New Dice.DieControl()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.btnRoll6 = New System.Windows.Forms.Button()
        Me.btnRoll6x100 = New System.Windows.Forms.Button()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp4.SuspendLayout()
        Me.tlp6.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp4
        '
        Me.tlp4.AutoSize = True
        Me.tlp4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp4.ColumnCount = 2
        Me.tlp4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp4.Controls.Add(Me.DieControl4, 0, 0)
        Me.tlp4.Controls.Add(Me.ListView4, 1, 0)
        Me.tlp4.Controls.Add(Me.btnRoll4, 0, 1)
        Me.tlp4.Controls.Add(Me.btnRoll4x100, 1, 1)
        Me.tlp4.Location = New System.Drawing.Point(340, 3)
        Me.tlp4.Name = "tlp4"
        Me.tlp4.RowCount = 2
        Me.tlp4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp4.Size = New System.Drawing.Size(331, 215)
        Me.tlp4.TabIndex = 1
        '
        'DieControl4
        '
        Me.DieControl4.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieControl4.Location = New System.Drawing.Point(16, 17)
        Me.DieControl4.Margin = New System.Windows.Forms.Padding(16, 17, 16, 17)
        Me.DieControl4.Name = "DieControl4"
        Me.DieControl4.Sides = 4
        Me.DieControl4.Size = New System.Drawing.Size(150, 150)
        Me.DieControl4.TabIndex = 0
        Me.DieControl4.Value = 4
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFirst4, Me.chResult4, Me.chCount4, Me.chPct4, Me.chEmpty4})
        Me.ListView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(185, 3)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(143, 178)
        Me.ListView4.TabIndex = 1
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'chFirst4
        '
        Me.chFirst4.Text = ""
        Me.chFirst4.Width = 0
        '
        'chResult4
        '
        Me.chResult4.Text = "#"
        Me.chResult4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chResult4.Width = 25
        '
        'chCount4
        '
        Me.chCount4.Text = "Count"
        Me.chCount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chCount4.Width = 45
        '
        'chPct4
        '
        Me.chPct4.Text = "Pct"
        Me.chPct4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chPct4.Width = 45
        '
        'chEmpty4
        '
        Me.chEmpty4.Text = ""
        Me.chEmpty4.Width = 0
        '
        'btnRoll4
        '
        Me.btnRoll4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll4.AutoSize = True
        Me.btnRoll4.Location = New System.Drawing.Point(53, 187)
        Me.btnRoll4.Name = "btnRoll4"
        Me.btnRoll4.Size = New System.Drawing.Size(75, 25)
        Me.btnRoll4.TabIndex = 2
        Me.btnRoll4.Text = "Roll"
        Me.btnRoll4.UseVisualStyleBackColor = True
        '
        'btnRoll4x100
        '
        Me.btnRoll4x100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll4x100.AutoSize = True
        Me.btnRoll4x100.Location = New System.Drawing.Point(211, 187)
        Me.btnRoll4x100.Name = "btnRoll4x100"
        Me.btnRoll4x100.Size = New System.Drawing.Size(90, 25)
        Me.btnRoll4x100.TabIndex = 3
        Me.btnRoll4x100.Text = "Roll 100 times"
        Me.btnRoll4x100.UseVisualStyleBackColor = True
        '
        'tlp6
        '
        Me.tlp6.AutoSize = True
        Me.tlp6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp6.ColumnCount = 2
        Me.tlp6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp6.Controls.Add(Me.DieControl6, 0, 0)
        Me.tlp6.Controls.Add(Me.ListView6, 1, 0)
        Me.tlp6.Controls.Add(Me.btnRoll6, 0, 1)
        Me.tlp6.Controls.Add(Me.btnRoll6x100, 1, 1)
        Me.tlp6.Location = New System.Drawing.Point(3, 3)
        Me.tlp6.Name = "tlp6"
        Me.tlp6.RowCount = 2
        Me.tlp6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp6.Size = New System.Drawing.Size(331, 215)
        Me.tlp6.TabIndex = 0
        '
        'DieControl6
        '
        Me.DieControl6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieControl6.Location = New System.Drawing.Point(16, 17)
        Me.DieControl6.Margin = New System.Windows.Forms.Padding(16, 17, 16, 17)
        Me.DieControl6.Name = "DieControl6"
        Me.DieControl6.Sides = 6
        Me.DieControl6.Size = New System.Drawing.Size(150, 150)
        Me.DieControl6.TabIndex = 0
        Me.DieControl6.Value = 6
        '
        'ListView6
        '
        Me.ListView6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView6.FullRowSelect = True
        Me.ListView6.GridLines = True
        Me.ListView6.HideSelection = False
        Me.ListView6.Location = New System.Drawing.Point(185, 3)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(143, 178)
        Me.ListView6.TabIndex = 1
        Me.ListView6.UseCompatibleStateImageBehavior = False
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "#"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 25
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Count"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 45
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Pct"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 45
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = ""
        Me.ColumnHeader5.Width = 0
        '
        'btnRoll6
        '
        Me.btnRoll6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll6.AutoSize = True
        Me.btnRoll6.Location = New System.Drawing.Point(53, 187)
        Me.btnRoll6.Name = "btnRoll6"
        Me.btnRoll6.Size = New System.Drawing.Size(75, 25)
        Me.btnRoll6.TabIndex = 2
        Me.btnRoll6.Text = "Roll"
        Me.btnRoll6.UseVisualStyleBackColor = True
        '
        'btnRoll6x100
        '
        Me.btnRoll6x100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoll6x100.AutoSize = True
        Me.btnRoll6x100.Location = New System.Drawing.Point(211, 187)
        Me.btnRoll6x100.Name = "btnRoll6x100"
        Me.btnRoll6x100.Size = New System.Drawing.Size(90, 25)
        Me.btnRoll6x100.TabIndex = 3
        Me.btnRoll6x100.Text = "Roll 100 times"
        Me.btnRoll6x100.UseVisualStyleBackColor = True
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.tlp6, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlp4, 1, 0)
        Me.tlpMain.Location = New System.Drawing.Point(3, 3)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(674, 221)
        Me.tlpMain.TabIndex = 2
        '
        'Form4_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 230)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "Form4_6"
        Me.Text = "Roll 6-sided or 4-sided die"
        Me.tlp4.ResumeLayout(False)
        Me.tlp4.PerformLayout()
        Me.tlp6.ResumeLayout(False)
        Me.tlp6.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlp4 As TableLayoutPanel
    Friend WithEvents DieControl4 As DieControl
    Friend WithEvents ListView4 As ListView
    Friend WithEvents btnRoll4 As Button
    Friend WithEvents btnRoll4x100 As Button
    Friend WithEvents chResult4 As ColumnHeader
    Friend WithEvents chCount4 As ColumnHeader
    Friend WithEvents chPct4 As ColumnHeader
    Friend WithEvents chFirst4 As ColumnHeader
    Friend WithEvents chEmpty4 As ColumnHeader
    Friend WithEvents tlp6 As TableLayoutPanel
    Friend WithEvents DieControl6 As DieControl
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnRoll6 As Button
    Friend WithEvents btnRoll6x100 As Button
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
