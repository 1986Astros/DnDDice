<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DieControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'AnimationTimer
        '
        '
        'DieControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.DoubleBuffered = True
        Me.Name = "DieControl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AnimationTimer As Timer
End Class
