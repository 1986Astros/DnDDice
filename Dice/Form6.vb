Public Class Form6

    Private Rolls6 As List(Of Integer) = New List(Of Integer)

    Private Sub btnRoll6_Click(sender As Object, e As EventArgs) Handles btnRoll6.Click
        Dim Result As Integer = DieControl6.Roll()
        Rolls6(Result - 1) += 1
        ListView6.Items(Result - 1).SubItems(1).Text = Rolls6(Result - 1)
        For i As Integer = 0 To 5
            ListView6.Items(i).SubItems(2).Text = (100.0 * CSng(Rolls6(i)) / Rolls6.Sum()).ToString("N2")
        Next
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 6
            With ListView6.Items.Add(i)
                .SubItems.Add(0)
                .SubItems.Add("NaN")
            End With
            Rolls6.Add(0)
        Next
    End Sub

    Private Sub btnRoll6x100_Click(sender As Object, e As EventArgs) Handles btnRoll6x100.Click
        For i As Integer = 1 To 100
            btnRoll6.PerformClick()
        Next
    End Sub
End Class
