Imports System.ComponentModel

Public Class DieConsoleControl
    <Category("Die Appearance")>
    Public Property Sides As Integer
        Get
            Return DieControl1.Sides
        End Get
        Set(value As Integer)
            DieControl1.Sides = value
            DieControl1.Value = value
        End Set
    End Property
    <Category("Die Appearance")>
    Public Property Value As Integer
        Get
            Return DieControl1.Value
        End Get
        Set(value As Integer)
            DieControl1.Value = value
        End Set
    End Property
    <Category("Die Appearance")>
    Public Property DieSize As Size
        Get
            Return DieControl1.Size
        End Get
        Set(value As Size)
            If Not value.Equals(DieSize) Then
                DieControl1.Size = value
                lvCounts.Size = New Size(lvCounts.Width, DieControl1.Height)
            End If
        End Set
    End Property
    <Category("Die Appearance")>
    Public Property DieFont As Font
        Get
            Return DieControl1.Font
        End Get
        Set(value As Font)
            DieControl1.Font = value
        End Set
    End Property

    <DefaultValue(GetType(Color), "White")> <Category("Die Appearance")>
    Public Property FaceColor As Color
        Get
            Return DieControl1.FaceColor
        End Get
        Set(value As Color)
            DieControl1.FaceColor = value
        End Set
    End Property

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property EdgeColor As Color
        Get
            Return DieControl1.EdgeColor
        End Get
        Set(value As Color)
            DieControl1.EdgeColor = value
        End Set
    End Property

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property EdgeWeight As Single
        Get
            Return DieControl1.EdgeWeight
        End Get
        Set(value As Single)
            DieControl1.EdgeWeight = value
        End Set
    End Property
    <DefaultValue(True)> <Category("Die Appearance")>
    Public Property DrawHiddenEdges As Boolean
        Get
            Return DieControl1.DrawHiddenEdges
        End Get
        Set(value As Boolean)
            DieControl1.DrawHiddenEdges = value
        End Set
    End Property

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property HiddenEdgeColor As Color
        Get
            Return DieControl1.HiddenEdgeColor
        End Get
        Set(value As Color)
            DieControl1.HiddenEdgeColor = value
        End Set
    End Property

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property HiddenEdgeWeight As Single
        Get
            Return DieControl1.HiddenEdgeWeight
        End Get
        Set(value As Single)
            DieControl1.HiddenEdgeWeight = value
        End Set
    End Property

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property ValueColor As Color
        Get
            Return DieControl1.ValueColor
        End Get
        Set(value As Color)
            DieControl1.ValueColor = value
        End Set
    End Property

    Private Rolls As List(Of Integer) = New List(Of Integer)

    Private Sub DieConsoleControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvCounts.SuspendLayout()
        lvCounts.BeginUpdate()

        For i As Integer = 1 To Sides
            With lvCounts.Items.Add("")
                .SubItems.Add(i)
                .SubItems.Add(0)
                .SubItems.Add("NaN")
            End With
            Rolls.Add(0)
        Next
        lvCounts.EndUpdate()

        chRoll.Width = -2
        lvCounts.PerformLayout()
        Dim Width As Integer = SystemInformation.VerticalScrollBarWidth
        For Each ch As ColumnHeader In lvCounts.Columns
            Width += ch.Width + 1
        Next
        lvCounts.Size = New Size(Width, DieControl1.Height)
        lvCounts.ResumeLayout()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim Result As Integer = DieControl1.Roll()
        Rolls(Result - 1) += 1
        lvCounts.Items(Result - 1).SubItems(chCount.Index).Text = Rolls(Result - 1)
        For i As Integer = 0 To Sides - 1
            lvCounts.Items(i).SubItems(chPct.Index).Text = (100.0 * CSng(Rolls(i)) / Rolls.Sum()).ToString("N2")
        Next
    End Sub

    Private Sub btnRollx_Click(sender As Object, e As EventArgs) Handles btnRollx.Click
        For i As Integer = 1 To nudRollCount.Value
            Rolls(DieControl1.Roll - 1) += 1
        Next
        For i As Integer = 0 To Sides - 1
            lvCounts.Items(i).SubItems(chCount.Index).Text = Rolls(i).ToString("N0")
            lvCounts.Items(i).SubItems(chPct.Index).Text = (100.0 * CSng(Rolls(i)) / Rolls.Sum()).ToString("N2")
        Next
    End Sub
End Class
