<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DieControl6 = New Dice.DieControl()
        Me.btnRoll6 = New System.Windows.Forms.Button()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.chResult = New System.Windows.Forms.ColumnHeader()
        Me.chCount = New System.Windows.Forms.ColumnHeader()
        Me.chPct = New System.Windows.Forms.ColumnHeader()
        Me.chEmpty = New System.Windows.Forms.ColumnHeader()
        Me.btnRoll6x100 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'DieControl6
        '
        Me.DieControl6.Font = New System.Drawing.Font("Segoe UI", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DieControl6.Location = New System.Drawing.Point(12, 12)
        Me.DieControl6.Margin = New System.Windows.Forms.Padding(16, 17, 16, 17)
        Me.DieControl6.Name = "DieControl6"
        Me.DieControl6.Sides = 6
        Me.DieControl6.Size = New System.Drawing.Size(150, 150)
        Me.DieControl6.TabIndex = 0
        Me.DieControl6.Value = 4
        '
        'btnRoll6
        '
        Me.btnRoll6.Location = New System.Drawing.Point(51, 183)
        Me.btnRoll6.Name = "btnRoll6"
        Me.btnRoll6.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll6.TabIndex = 1
        Me.btnRoll6.Text = "Roll"
        Me.btnRoll6.UseVisualStyleBackColor = true
        '
        'ListView6
        '
        Me.ListView6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chResult, Me.chCount, Me.chPct, Me.chEmpty})
        Me.ListView6.FullRowSelect = true
        Me.ListView6.GridLines = true
        Me.ListView6.HideSelection = false
        Me.ListView6.Location = New System.Drawing.Point(181, 12)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(125, 150)
        Me.ListView6.TabIndex = 2
        Me.ListView6.UseCompatibleStateImageBehavior = false
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'chResult
        '
        Me.chResult.Text = "#"
        Me.chResult.Width = 25
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
        'chEmpty
        '
        Me.chEmpty.Text = ""
        Me.chEmpty.Width = 0
        '
        'btnRoll6x100
        '
        Me.btnRoll6x100.AutoSize = true
        Me.btnRoll6x100.Location = New System.Drawing.Point(197, 182)
        Me.btnRoll6x100.Name = "btnRoll6x100"
        Me.btnRoll6x100.Size = New System.Drawing.Size(90, 25)
        Me.btnRoll6x100.TabIndex = 3
        Me.btnRoll6x100.Text = "Roll 100 times"
        Me.btnRoll6x100.UseVisualStyleBackColor = true
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 223)
        Me.Controls.Add(Me.btnRoll6x100)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.btnRoll6)
        Me.Controls.Add(Me.DieControl6)
        Me.Name = "Form6"
        Me.Text = "6-sided die"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DieControl6 As DieControl
    Friend WithEvents btnRoll6 As Button
    Friend WithEvents ListView6 As ListView
    Friend WithEvents chResult As ColumnHeader
    Friend WithEvents chCount As ColumnHeader
    Friend WithEvents chPct As ColumnHeader
    Friend WithEvents chEmpty As ColumnHeader
    Friend WithEvents btnRoll6x100 As Button
End Class
