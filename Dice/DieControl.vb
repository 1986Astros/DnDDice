Public Class DieControl

    Public Property Sides As Integer
        Get
            Return shhSides
        End Get
        Set(value As Integer)
            If value <> shhSides Then
                shhSides = value
                If DesignMode Then
                    Me.Value = value
                Else
                    Me.Value = Math.Max(Me.Value, value)
                End If
                Invalidate()
            End If
        End Set
    End Property
    Private shhSides As Integer = 6

    Public Property Value As Integer
        Get
            Return shhValue
        End Get
        Set(value As Integer)
            If value <> shhValue Then
                shhValue = value
                Invalidate()    ' todo: invalidate only the number that was previously drawn
            End If
        End Set
    End Property
    Private shhValue As Integer = 6

    Public Sub Clear()
        If Value <> 0 Then
            Value = 0
            Invalidate()
        End If
    End Sub

    Public Function Roll() As Integer
        Value = rnd.Next(1, Sides + 1)
        Invalidate()

        Return Value
    End Function

    Private rnd As Random = New Random

    Private Sub DieControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private ValueStringFormat As StringFormat = New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
    Private Sub DieControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim ShortestSide As Integer = Math.Min(e.ClipRectangle.Width, e.ClipRectangle.Height)
        Dim BoundingRectangle As Rectangle = New Rectangle((e.ClipRectangle.Width - ShortestSide) \ 2, (e.ClipRectangle.Height - ShortestSide) \ 2, ShortestSide, ShortestSide)
        Dim NumberRectangle As RectangleF
        Dim ShadowTheNumber As Boolean

        Dim gs As Drawing2D.GraphicsState = e.Graphics.Save
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.High
        Select Case Sides
            Case 4
                NumberRectangle = Paint4Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = True
            Case 6
                NumberRectangle = Paint6Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = False
            Case 8
                NumberRectangle = Paint8Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = False
            Case 10
                NumberRectangle = Paint10Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = True
            Case 12
                NumberRectangle = Paint12Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = False
            Case 20
                NumberRectangle = Paint20Sides(e.Graphics, BoundingRectangle)
                ShadowTheNumber = False
        End Select

        If Value <> 0 Then
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If ShadowTheNumber Then
                ' todo: this can be done with GraphicsPath.DrawString, then offsetting the path repeatedly to create a region
                Using NumberBrush As Brush = New SolidBrush(Me.BackColor)
                    For x As Integer = -3 To 3
                        For y As Integer = -3 To 3
                            Dim nr As RectangleF = NumberRectangle
                            nr.Offset(x, y)
                            e.Graphics.DrawString(Value, Me.Font, NumberBrush, nr, ValueStringFormat)
                        Next
                    Next
                End Using
            End If
            e.Graphics.DrawString(Value, Me.Font, Brushes.Black, NumberRectangle, ValueStringFormat)
        End If

        e.Graphics.Restore(gs)
    End Sub

    Private Function Paint4Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)

        Dim yd As Single = SngRect.Width / 2.0! * Math.Sin(Math.PI * 30.0 / 180.0)  ' distance from bottom of lower edges

        ' outline
        g.DrawLine(Pens.Black, 0!, SngRect.Bottom - yd / 2.0!, SngRect.Right, SngRect.Bottom - yd / 2.0!)
        g.DrawLine(Pens.Black, 0!, SngRect.Bottom - yd / 2.0!, SngRect.Width / 2.0!, SngRect.Top + yd / 2.0!)
        g.DrawLine(Pens.Black, SngRect.Right, SngRect.Bottom - yd / 2.0!, SngRect.Width / 2.0!, SngRect.Top + yd / 2.0!)

        ' ghost lines
        Dim DashSize As Single = 1.0!
        Dim DashFade As Single = 0.25!
        Dim Dashes As List(Of Single) = New List(Of Single)
        Do
            Dashes.Add(1.0!)
            Dashes.Add(DashSize)
            DashSize += DashFade
            DashFade += 0.25!
        Loop Until Dashes.Sum > SngRect.Width
        Using p As Pen = New Pen(Color.Black) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray} '{1.0, 2.0}}
            g.DrawLine(p, 0!, SngRect.Bottom - yd / 2.0!, SngRect.Width / 2.0!, SngRect.Bottom - yd - yd / 2.0!)
            g.DrawLine(p, SngRect.Right, SngRect.Bottom - yd / 2.0!, SngRect.Width / 2.0!, SngRect.Bottom - yd - yd / 2.0!)
            g.DrawLine(p, SngRect.Width / 2.0!, yd / 2.0!, SngRect.Width / 2.0!, SngRect.Bottom - yd - yd / 2.0!)
        End Using

        Return New RectangleF(0!, SngRect.Top + yd, SngRect.Width, SngRect.Height - yd)
    End Function

    Private Function Paint6Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        Dim TopFace(3) As PointF    ' top, left, bottom, right
        Dim LeftFace(3) As PointF   ' top left, bottom left, bottom right, top right
        Dim RightFace(3) As PointF  ' top right, bottom right, bottom left, top left
        Dim i As Integer

        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)
        Dim radius As Single = SngRect.Height / 2

        TopFace(0) = New PointF(radius, SngRect.Top)
        TopFace(1) = New PointF(SngRect.Left, radius / 2)
        TopFace(2) = New PointF(radius, radius)
        TopFace(3) = New PointF(SngRect.Right, radius / 2)
        For i = 0 To 2
            g.DrawLine(Pens.Black, TopFace(i), TopFace(i + 1))
        Next
        g.DrawLine(Pens.Black, TopFace(3), TopFace(0))

        LeftFace(0) = TopFace(1)
        LeftFace(1) = New PointF(LeftFace(0).X, LeftFace(0).Y + radius)
        LeftFace(2) = New PointF(radius, SngRect.Bottom)
        LeftFace(3) = TopFace(2)
        For i = 0 To 2
            g.DrawLine(Pens.Black, LeftFace(i), LeftFace(i + 1))
        Next

        RightFace(0) = TopFace(3)
        RightFace(1) = New PointF(RightFace(0).X, RightFace(0).Y + radius)
        RightFace(2) = LeftFace(2)
        RightFace(3) = TopFace(2)
        For i = 0 To 1
            g.DrawLine(Pens.Black, RightFace(i), RightFace(i + 1))
        Next

        Return New RectangleF(0, 0, BoundingRectangle.Width, Math.Floor(radius))
    End Function

    Private Function Paint8Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)

        Dim QuarterHeight As Single = BoundingRectangle.Height / 4.0!
        Dim Middle As Integer = BoundingRectangle.Width / 2.0!

        ' front face
        g.DrawLine(Pens.Black, 0!, QuarterHeight, Middle, SngRect.Bottom)
        g.DrawLine(Pens.Black, Middle, SngRect.Bottom, SngRect.Right, QuarterHeight)
        g.DrawLine(Pens.Black, 0!, QuarterHeight, BoundingRectangle.Right, QuarterHeight)

        ' top face
        g.DrawLine(Pens.Black, 0!, QuarterHeight, Middle, 0!)
        g.DrawLine(Pens.Black, Middle, 0!, SngRect.Right, QuarterHeight)

        ' left face
        g.DrawLine(Pens.Black, 0!, QuarterHeight, 0!, SngRect.Bottom - QuarterHeight)
        g.DrawLine(Pens.Black, 0!, SngRect.Bottom - QuarterHeight, Middle, SngRect.Bottom)

        ' right face
        g.DrawLine(Pens.Black, SngRect.Right, QuarterHeight, SngRect.Right, SngRect.Bottom - QuarterHeight)
        g.DrawLine(Pens.Black, SngRect.Right, SngRect.Bottom - QuarterHeight, Middle, SngRect.Bottom)

        Return New RectangleF(0, QuarterHeight, SngRect.Width, SngRect.Height / 2.0!)
    End Function

    Private Function Paint10Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)

        Dim radius As Single = SngRect.Width / 2.0!
        Dim MidPoint As PointF = New PointF(SngRect.Left + radius, SngRect.Top + radius)
        Dim TopHex(5) As PointF   ' top, upper left, lower left, lower right, upper right, top
        Dim i As Integer

        TopHex(0) = New PointF(MidPoint.X, SngRect.Top)
        TopHex(1) = New PointF(SngRect.Left, MidPoint.Y - radius * Math.Sin(Math.PI * 18.0! / 180.0!))
        TopHex(2) = New PointF(MidPoint.X - radius * Math.Cos(Math.PI * 54.0! / 180.0!), MidPoint.Y + radius * Math.Sin(Math.PI * 54.0! / 180.0!))
        TopHex(3) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 54.0! / 180.0!), TopHex(2).Y)
        TopHex(4) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 18.0! / 180.0!), TopHex(1).Y)
        TopHex(5) = TopHex(0)

        radius = TopHex(2).Y - MidPoint.Y
        Dim CenteringOffset As Single = (SngRect.Height / 2.0! - radius) / 2.0!
        For i = 0 To 5
            TopHex(i).Y += CenteringOffset
        Next
        MidPoint.Y += CenteringOffset

        Dim UnderHex(4) As PointF

        UnderHex(0) = New PointF(MidPoint.X - radius * Math.Cos(Math.PI * 54.0! / 180.0!), MidPoint.Y - radius * Math.Sin(Math.PI * 54.0! / 180.0!))
        UnderHex(1) = New PointF(MidPoint.X - radius * Math.Cos(Math.PI * 18.0! / 180.0!), MidPoint.Y + radius * Math.Sin(Math.PI * 18.0! / 180.0!))
        UnderHex(2) = New PointF(MidPoint.X, MidPoint.Y + radius)
        UnderHex(3) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 18.0! / 180.0!), UnderHex(1).Y)
        UnderHex(4) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 54.0! / 180.0!), UnderHex(0).Y)

        Dim EdgePts(3) As PointF
        EdgePts(0) = TopHex(0)
        EdgePts(1) = New PointF(MidPoint.X - 1.0!, MidPoint.Y)
        EdgePts(2) = New PointF(MidPoint.X + 1.0!, MidPoint.Y)
        EdgePts(3) = EdgePts(0)
        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
            gp.AddPolygon(EdgePts)
            Using EdgeRegion As Region = New Region(gp)
                Using EdgeMatrix As Drawing2D.Matrix = New Drawing2D.Matrix
                    EdgeMatrix.RotateAt(-72.0!, MidPoint)

                    For i = 0 To 4
                        g.DrawLine(Pens.Black, TopHex(i), TopHex(i + 1))
                        g.FillRegion(Brushes.Black, EdgeRegion)
                        EdgeRegion.Transform(EdgeMatrix)
                    Next
                End Using
            End Using
        End Using

        Dim DashSize As Single = 2.0!
        Dim DashFade As Single = 0.5!
        Dim Dashes As List(Of Single) = New List(Of Single)
        Do
            Dashes.Add(1.0!)
            Dashes.Add(DashSize)
            DashSize += DashFade
            DashFade += 0.25!
        Loop Until Dashes.Sum > radius
        For i = 0 To 4
            Using p As Pen = New Pen(Color.Black) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, UnderHex(i), MidPoint)
            End Using
        Next

        Return RectangleF.FromLTRB(SngRect.Left, MidPoint.Y + (TopHex(2).Y - MidPoint.Y) / 3, SngRect.Right, TopHex(2).Y)
    End Function

    Private Function Paint12Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        ' https://www.jamieyorkpress.com/wp-content/uploads/2018/05/Instructions-for-Drawing-a-Dodecahedron.pdf

        Dim OuterPoints(9) As PointF
        Dim InnerPoints(4) As PointF
        Dim degrees As Single = 270.0!
        Dim i As Integer

        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)
        Dim OuterRadius As Single = SngRect.Width / 2.0!

        For i = 0 To 9
            OuterPoints(i) = New PointF(OuterRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, OuterRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 36.0!
        Next
        For i = 0 To 8
            g.DrawLine(Pens.Black, OuterPoints(i), OuterPoints(i + 1))
        Next
        g.DrawLine(Pens.Black, OuterPoints(9), OuterPoints(0))

        Dim InnerRadius = OuterPoints(3).Y - OuterPoints(2).Y   ' length of a side is the radius of the inner circle
        degrees = 270.0!
        For i = 0 To 4
            InnerPoints(i) = New PointF(InnerRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, InnerRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 72.0!
        Next
        For i = 0 To 3
            g.DrawLine(Pens.Black, InnerPoints(i), InnerPoints(i + 1))
            g.DrawLine(Pens.Black, InnerPoints(i), OuterPoints(2 * i))
        Next
        g.DrawLine(Pens.Black, InnerPoints(4), InnerPoints(0))
        g.DrawLine(Pens.Black, InnerPoints(4), OuterPoints(8))

        Return SngRect
    End Function

    Private Function Paint20Sides(g As Graphics, BoundingRectangle As Rectangle) As RectangleF
        ' https://youtu.be/ithlX422Ubo
        Dim HexagonPoints(5) As PointF
        Dim degrees As Single = 270.0!
        Dim i As Integer

        Dim SngRect As RectangleF = New RectangleF(CSng(BoundingRectangle.Left), CSng(BoundingRectangle.Top), CSng(BoundingRectangle.Width), CSng(BoundingRectangle.Height))
        SngRect.Inflate(-1.0!, -1.0!)
        Dim OuterRadius As Single = SngRect.Height / 2

        For i = 0 To 5
            HexagonPoints(i) = New PointF(OuterRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, OuterRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 60.0!
        Next
        For i = 0 To 4
            g.DrawLine(Pens.Black, HexagonPoints(i), HexagonPoints(i + 1))
        Next
        g.DrawLine(Pens.Black, HexagonPoints(5), HexagonPoints(0))

        Dim TrianglePoints(2) As PointF
        Dim MiddleRadius = 5.0! * OuterRadius / 8.0!
        degrees = 210.0!

        For i = 0 To 2
            TrianglePoints(i) = New PointF(MiddleRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, MiddleRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 120.0!
        Next
        For i = 0 To 1
            g.DrawLine(Pens.Black, TrianglePoints(i), TrianglePoints(i + 1))
        Next
        g.DrawLine(Pens.Black, TrianglePoints(2), TrianglePoints(0))

        g.DrawLine(Pens.Black, HexagonPoints(0), TrianglePoints(0))
        g.DrawLine(Pens.Black, HexagonPoints(0), TrianglePoints(1))
        g.DrawLine(Pens.Black, HexagonPoints(1), TrianglePoints(1))
        g.DrawLine(Pens.Black, HexagonPoints(1), TrianglePoints(1))
        g.DrawLine(Pens.Black, HexagonPoints(2), TrianglePoints(1))
        g.DrawLine(Pens.Black, HexagonPoints(2), TrianglePoints(2))
        g.DrawLine(Pens.Black, HexagonPoints(5), TrianglePoints(0))
        g.DrawLine(Pens.Black, HexagonPoints(4), TrianglePoints(0))
        g.DrawLine(Pens.Black, HexagonPoints(4), TrianglePoints(2))
        g.DrawLine(Pens.Black, HexagonPoints(3), TrianglePoints(2))

        Return New RectangleF(HexagonPoints(5).X, HexagonPoints(5).Y, HexagonPoints(1).X - HexagonPoints(5).X, HexagonPoints(4).Y - HexagonPoints(5).Y)
    End Function
End Class
