Imports System.ComponentModel

Public Class DieControl
    Public Sub New()
        InitializeComponent()

        MeasureFont()
        CreateValueRectangle()
    End Sub
    Private Sub DieControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialized = True
    End Sub
    Private Initialized As Boolean = False

    Private ValueRectangle As RectangleF    ' where to paint the current die value
    Private ValueInvalidationRectangle As RectangleF    ' what to invalidate - just the glyph
    Private ValueRenderingRectangle As Rectangle        ' location for TextRenderer.DrawText
    Private ValueFontAscent As Single
    Private ValueFontDescent As Single
    Private ReadOnly rnd As Random = New Random

    Private Sub CreateValueRectangle()
        Dim MeasureCharsStringFormat As StringFormat = New StringFormat()
        Dim Ranges As List(Of CharacterRange) = New List(Of CharacterRange)
        Dim LastStartPosition As Integer = 0
        For i As Integer = 1 To Sides
            Ranges.Add(New CharacterRange(LastStartPosition, i.ToString().Length))
            LastStartPosition += i.ToString().Length
        Next
        MeasureCharsStringFormat.SetMeasurableCharacterRanges(Ranges.ToArray)
        Using g As Graphics = CreateGraphics()
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

            ' Note: Since the text is render by TextRenderer, this will possibly miscalculate.
            Dim LargestRgn As Region = g.MeasureCharacterRanges(
                Enumerable.Range(1, Sides).Aggregate(Of String)("", Function(ag, s) ag & s),
                Me.Font,
                Screen.PrimaryScreen.Bounds,
                MeasureCharsStringFormat).
                OrderByDescending(Function(r) r.GetBounds(g).Width).First
            Select Case Sides
                Case 4
                    SetValueRect4(LargestRgn.GetBounds(g).Size)
                Case 6
                    SetValueRect6(LargestRgn.GetBounds(g).Size)
                Case 8
                    SetValueRect8(LargestRgn.GetBounds(g).Size)
                Case 10
                    SetValueRect10(LargestRgn.GetBounds(g).Size)
                Case 12
                    SetValueRect12(LargestRgn.GetBounds(g).Size)
                Case 20
                    SetValueRect20(LargestRgn.GetBounds(g).Size)
            End Select
        End Using
    End Sub
    Private Sub MeasureFont()
        Dim FontSize As Single = Font.Size
        Dim FontFamily As FontFamily = Font.FontFamily
        Dim FontStyle As FontStyle = Font.Style
        Dim FontEmHeight As Integer = FontFamily.GetEmHeight(FontStyle)
        ValueFontAscent = FontSize * FontFamily.GetCellAscent(FontStyle) / FontEmHeight
        ValueFontDescent = FontSize * FontFamily.GetCellDescent(FontStyle) / FontEmHeight
    End Sub

    <Category("Die Appearance")>
    Public Property Sides As Integer
        Get
            Return shhSides
        End Get
        Set(value As Integer)
            Select Case value
                Case 4, 6, 8, 10, 12, 20
                Case Else
                    Throw New ArgumentOutOfRangeException("Dice may be 4,6,8,10,12,20 sides.", CType(Nothing, Exception))
            End Select
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

    <Category("Die Appearance")>
    Public Property Value As Integer
        Get
            Return shhValue
        End Get
        Set(value As Integer)
            If value <> shhValue Then
                shhValue = value
                Invalidate(Rectangle.Round(ValueInvalidationRectangle))
            End If
        End Set
    End Property
    Private shhValue As Integer = 6

    <DefaultValue(GetType(Color), "White")> <Category("Die Appearance")>
    Public Property FaceColor As Color
        Get
            Return shhFaceColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhFaceColor.ToArgb Then
                shhFaceColor = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhFaceColor As Color = Color.White

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property EdgeColor As Color
        Get
            Return shhEdgeColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhEdgeColor.ToArgb Then
                shhEdgeColor = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhEdgeColor As Color = Color.Black

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property EdgeWeight As Single
        Get
            Return shhEdgeWeight
        End Get
        Set(value As Single)
            If value <> shhEdgeWeight Then
                shhEdgeWeight = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhEdgeWeight As Single = 1.0!

    <DefaultValue(True)> <Category("Die Appearance")>
    Public Property DrawHiddenEdges As Boolean
        Get
            Return shhDrawHiddenEdges
        End Get
        Set(value As Boolean)
            If value <> shhDrawHiddenEdges Then
                shhDrawHiddenEdges = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhDrawHiddenEdges As Boolean = True

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property HiddenEdgeColor As Color
        Get
            Return shhHiddenEdgeColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhHiddenEdgeColor.ToArgb Then
                shhHiddenEdgeColor = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhHiddenEdgeColor As Color = Color.Black

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property HiddenEdgeWeight As Single
        Get
            Return shhHiddenEdgeWeight
        End Get
        Set(value As Single)
            If value <> shhHiddenEdgeWeight Then
                shhHiddenEdgeWeight = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhHiddenEdgeWeight As Single = 1.0!

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property ValueColor As Color
        Get
            Return shhValueColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhValueColor.ToArgb Then
                shhValueColor = value
                Invalidate()
            End If
        End Set
    End Property
    Private shhValueColor As Color = Color.Black

    Public Sub Clear()
        If Value <> 0 Then
            Value = 0
            Invalidate()
        End If
    End Sub

    Public Function Roll() As Integer
        Value = rnd.Next(1, Sides + 1)
        Return Value
    End Function

    Private Function GetBoundingRectangle() As RectangleF
        Dim ShorterSide As Single = CSng(Math.Min(Height, Width))
        Return New RectangleF((CSng(Width) - ShorterSide) / 2.0! + 1.0!, (CSng(Height) - ShorterSide) / 2.0! + 1.0!, ShorterSide - 2.0!, ShorterSide - 2.0!)
    End Function

    Private Sub DieControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim BoundingRectangle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        Dim gs As Drawing2D.GraphicsState = e.Graphics.Save
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.High
        Select Case Sides
            Case 4
                Paint4Sides(e.Graphics)
            Case 6
                Paint6Sides(e.Graphics)
            Case 8
                Paint8Sides(e.Graphics)
            Case 10
                Paint10Sides(e.Graphics)
            Case 12
                Paint12Sides(e.Graphics)
            Case 20
                Paint20Sides(e.Graphics)
        End Select
        CreateValueRectangle()

        If Value <> 0 Then
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim tff As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoClipping Or TextFormatFlags.NoPadding Or TextFormatFlags.TextBoxControl
            TextRenderer.DrawText(e.Graphics, Value, Me.Font, ValueRenderingRectangle, ValueColor, tff)
        End If

        e.Graphics.Restore(gs)
    End Sub

    Private Sub Paint4Sides(g As Graphics)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()

        Dim yd As Single = GetHeightDelta4()

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            gp.AddLine(BoundingRectangle.Left, BoundingRectangle.Bottom - yd / 2.0!, BoundingRectangle.Right, BoundingRectangle.Bottom - yd / 2.0!)
            gp.AddLine(BoundingRectangle.Right, BoundingRectangle.Bottom - yd / 2.0!, BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Top + yd / 2.0!)
            gp.AddLine(BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Top + yd / 2.0!, BoundingRectangle.Left, BoundingRectangle.Bottom - yd / 2.0!)

            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
            Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
                g.DrawPath(EdgePen, gp)
            End Using

            If DrawHiddenEdges Then
                Dim DashSize As Single = 1.0!
                Dim DashFade As Single = 0.25!
                Dim Dashes As List(Of Single) = New List(Of Single)
                Do
                    Dashes.Add(1.0!)
                    Dashes.Add(DashSize)
                    DashSize += DashFade
                    DashFade += 0.25!
                Loop Until Dashes.Sum > BoundingRectangle.Width
                Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                    g.DrawLine(p, BoundingRectangle.Left, BoundingRectangle.Bottom - yd / 2.0!, BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Bottom - yd - yd / 2.0!)
                    g.DrawLine(p, BoundingRectangle.Right, BoundingRectangle.Bottom - yd / 2.0!, BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Bottom - yd - yd / 2.0!)
                    g.DrawLine(p, BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, yd / 2.0! + HiddenEdgeWeight, BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Bottom - yd - yd / 2.0!)
                End Using
            End If
        End Using
    End Sub
    Private Function GetHeightDelta4() As Single
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        Return BoundingRectangle.Width / 2.0! * Math.Sin(Math.PI * 30.0 / 180.0)  ' distance from bottom of lower edges
    End Function
    Private Sub SetValueRect4(LargestSize As SizeF)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        BoundingRectangle.Top + (GetHeightDelta4() + BoundingRectangle.Height - LargestSize.Height) / 2.0!,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    BoundingRectangle.Top + (GetHeightDelta4() + BoundingRectangle.Height - LargestSize.Height + InvalidationHeight) / 2.0!,
                                                    LargestSize.Width, LargestSize.Height - InvalidationHeight)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontAscent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub Paint6Sides(g As Graphics)
        Dim BoundingRectangle = GetBoundingRectangle()

        Dim radius As Single = GetRadius6()
        Dim TopFace(4) As PointF    ' top, left, bottom, right
        Dim LeftFace(3) As PointF   ' top left, bottom left, bottom right, top right
        Dim RightFace(3) As PointF  ' top right, bottom right, bottom left, top left
        Dim i As Integer

        TopFace(0) = New PointF(radius, BoundingRectangle.Top)
        TopFace(1) = New PointF(BoundingRectangle.Left, radius / 2)
        TopFace(2) = New PointF(radius, radius)
        TopFace(3) = New PointF(BoundingRectangle.Right, radius / 2)
        TopFace(4) = TopFace(0)

        LeftFace(0) = TopFace(1)
        LeftFace(1) = New PointF(LeftFace(0).X, LeftFace(0).Y + radius)
        LeftFace(2) = New PointF(radius, BoundingRectangle.Bottom)
        LeftFace(3) = TopFace(2)

        RightFace(0) = TopFace(3)
        RightFace(1) = New PointF(RightFace(0).X, RightFace(0).Y + radius)
        RightFace(2) = LeftFace(2)
        RightFace(3) = TopFace(2)

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            gp.AddLine(TopFace(0), TopFace(1))
            gp.AddLine(LeftFace(0), LeftFace(1))
            gp.AddLine(LeftFace(1), LeftFace(2))
            gp.AddLine(RightFace(2), RightFace(1))
            gp.AddLine(RightFace(1), RightFace(0))
            gp.AddLine(TopFace(3), TopFace(0))
            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
        End Using

        Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
            For i = 0 To 3
                g.DrawLine(EdgePen, TopFace(i), TopFace(i + 1))
            Next
            For i = 0 To 2
                g.DrawLine(EdgePen, LeftFace(i), LeftFace(i + 1))
            Next
            For i = 0 To 1
                g.DrawLine(EdgePen, RightFace(i), RightFace(i + 1))
            Next
        End Using

        If DrawHiddenEdges Then
            Dim RearVertex As Point = New Point(TopFace(0).X, TopFace(0).Y + LeftFace(2).Y - LeftFace(3).Y)
            Dim DashSize As Single = 1.0!
            Dim DashFade As Single = 0.25!
            Dim Dashes As List(Of Single) = New List(Of Single)
            Dim LengthOfEdge As Single = Math.Sqrt(radius ^ 2 + (RightFace(1).Y - RearVertex.Y) ^ 2)
            Do
                Dashes.Add(1.0!)
                Dashes.Add(DashSize)
                DashSize += DashFade
                DashFade += 0.25!
            Loop Until Dashes.Sum + (1.0! + DashSize) >= LengthOfEdge
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, LeftFace(1).X, LeftFace(1).Y, RearVertex.X, RearVertex.Y)
                g.DrawLine(p, RightFace(1).X, RightFace(1).Y, RearVertex.X, RearVertex.Y)
            End Using
            LengthOfEdge = RearVertex.Y - TopFace(0).Y
            While Dashes.Sum > LengthOfEdge AndAlso Dashes.Count >= 4
                Dashes.RemoveRange(0, 2)
            End While
            If Dashes.Count >= 6 Then
                Dashes.RemoveRange(0, Dashes.Count - 4)
            End If
            If Dashes.Count >= 4 Then
                Dashes.RemoveRange(2, Dashes.Count - 2)
            End If
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, TopFace(0).X, TopFace(0).Y, RearVertex.X, RearVertex.Y)
            End Using
        End If
    End Sub
    Private Function GetRadius6() As Single
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        Return BoundingRectangle.Height / 2.0!
    End Function
    Private Sub SetValueRect6(LargestSize As SizeF)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        BoundingRectangle.Top + (GetRadius6() - LargestSize.Height) / 2.0!,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    BoundingRectangle.Top + (GetRadius6() - LargestSize.Height + InvalidationHeight) / 2.0!,
                                                    LargestSize.Width, LargestSize.Height - InvalidationHeight)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontAscent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub Paint8Sides(g As Graphics)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()

        Dim FullWidth As Single = 7.0! * BoundingRectangle.Width / 8.0!
        Dim FullHeight As Single = BoundingRectangle.Height
        Dim TopEdge As Single = 3.0! * FullHeight / 11.0!
        Dim BottomEdge As Single = 8.0! * FullHeight / 11.0!
        Dim SideVertex As Single = BoundingRectangle.Width / 44.0!

        Dim TopFace(3) As PointF    ' top, left, right
        Dim LeftFace(3) As PointF   ' top left, bottom left, bottom middle
        Dim RightFace(3) As PointF  ' top right, bottom right, bottom middle
        Dim i As Integer

        BoundingRectangle.Inflate((FullWidth - BoundingRectangle.Width) / 2.0!, 0!)

        TopFace(0) = New PointF(BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Top)
        TopFace(1) = New PointF(BoundingRectangle.Left, TopEdge)
        TopFace(2) = New PointF(BoundingRectangle.Right, TopEdge)
        TopFace(3) = TopFace(0)
        LeftFace(0) = New PointF(BoundingRectangle.Left, TopEdge)
        LeftFace(1) = New PointF(BoundingRectangle.Left + SideVertex, BottomEdge)
        LeftFace(2) = New PointF(BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Bottom)
        LeftFace(3) = LeftFace(0)
        RightFace(0) = New PointF(BoundingRectangle.Right, TopEdge)
        RightFace(1) = New PointF(BoundingRectangle.Right - SideVertex, BottomEdge)
        RightFace(2) = New PointF(BoundingRectangle.Left + BoundingRectangle.Width / 2.0!, BoundingRectangle.Bottom)
        RightFace(3) = RightFace(0)

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            gp.AddLine(TopFace(0), TopFace(1))
            gp.AddLine(LeftFace(0), LeftFace(1))
            gp.AddLine(LeftFace(1), LeftFace(2))
            gp.AddLine(RightFace(2), RightFace(1))
            gp.AddLine(RightFace(1), RightFace(0))
            gp.AddLine(TopFace(3), TopFace(0))
            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
        End Using

        Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
            For i = 0 To 2
                g.DrawLine(EdgePen, TopFace(i), TopFace(i + 1))
                g.DrawLine(EdgePen, LeftFace(i), LeftFace(i + 1))
                g.DrawLine(EdgePen, RightFace(i), RightFace(i + 1))
            Next
        End Using

        If DrawHiddenEdges Then
            Dim Dashes As List(Of Single) = New List(Of Single)
            Dashes.Clear()
            Dashes.Add(1.0!)
            Dashes.Add(6.0!)
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, TopFace(0), LeftFace(1))
                g.DrawLine(p, TopFace(0), RightFace(1))
                g.DrawLine(p, LeftFace(1), RightFace(1))
            End Using
        End If
    End Sub
    Private Sub SetValueRect8(LargestSize As SizeF)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        BoundingRectangle.Top + (BoundingRectangle.Height - LargestSize.Height) / 2.0!,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    BoundingRectangle.Top + (BoundingRectangle.Height - LargestSize.Height + InvalidationHeight) / 2.0!,
                                                    LargestSize.Width, LargestSize.Height - InvalidationHeight)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontAscent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub Paint10Sides(g As Graphics)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()

        Dim radius As Single = GetRadius10()
        Dim radius2 As Single = 0.9! * BoundingRectangle.Width / 2.0!
        Dim MidPoint As PointF = GetMidPoint10()
        Dim TopHex(10) As PointF   ' top, upper left, lower left, lower right, upper right, top
        Dim i As Integer

        TopHex(0) = New PointF(MidPoint.X, BoundingRectangle.Top)
        TopHex(1) = New PointF(MidPoint.X - radius2 * Math.Cos(Math.PI * 54.0! / 180.0!) - 1.0!, MidPoint.Y - radius2 * Math.Sin(Math.PI * 54.0! / 180.0!))
        TopHex(2) = New PointF(BoundingRectangle.Left, MidPoint.Y - radius * Math.Sin(Math.PI * 18.0! / 180.0!))
        TopHex(3) = New PointF(MidPoint.X - radius2 * Math.Cos(Math.PI * 18.0! / 180.0!) - 1.0!, MidPoint.Y + radius2 * Math.Sin(Math.PI * 18.0! / 180.0!))
        TopHex(4) = New PointF(MidPoint.X - radius * Math.Cos(Math.PI * 54.0! / 180.0!), MidPoint.Y + radius * Math.Sin(Math.PI * 54.0! / 180.0!))
        TopHex(5) = New PointF(MidPoint.X, MidPoint.Y + radius2)
        TopHex(6) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 54.0! / 180.0!), TopHex(4).Y)
        TopHex(7) = New PointF(MidPoint.X + radius2 * Math.Cos(Math.PI * 18.0! / 180.0!), TopHex(3).Y)
        TopHex(8) = New PointF(MidPoint.X + radius * Math.Cos(Math.PI * 18.0! / 180.0!), TopHex(2).Y)
        TopHex(9) = New PointF(MidPoint.X + radius2 * Math.Cos(Math.PI * 54.0! / 180.0!), TopHex(1).Y)
        TopHex(10) = TopHex(0)

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            For i = 0 To 9
                gp.AddLine(TopHex(i), TopHex(i + 1))
            Next
            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
        End Using

        Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
            For i = 0 To 9
                g.DrawLine(EdgePen, TopHex(i), TopHex(i + 1))
            Next
            For i = 0 To 8 Step 2
                g.DrawLine(EdgePen, TopHex(i), MidPoint)
            Next
        End Using

        If DrawHiddenEdges Then
            Dim DashSize As Single = 2.0!
            Dim DashFade As Single = 0.5!
            Dim Dashes As List(Of Single) = New List(Of Single)
            Do
                Dashes.Add(1.0!)
                Dashes.Add(DashSize)
                DashSize += DashFade
                DashFade += 0.25!
            Loop Until Dashes.Sum >= radius2
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                For i = 1 To 9 Step 2
                    g.DrawLine(p, TopHex(i), MidPoint)
                Next
            End Using
        End If
    End Sub
    Private Function GetRadius10() As Single
        Return GetBoundingRectangle.Width / 2.0!
    End Function
    Private Function GetRadius_2_10() As Single
        Return 0.9! * GetBoundingRectangle.Width / 2.0!
    End Function
    Private Function GetMidPoint10() As PointF
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        Dim radius As Single = GetRadius10()
        Return New PointF(BoundingRectangle.Left + radius, BoundingRectangle.Top + radius)
    End Function
    Private Sub SetValueRect10(LargestSize As SizeF)
        LargestSize = New SizeF(LargestSize.Width + 1.0!, LargestSize.Height + 1.0!)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        Dim radius As Single = GetRadius10()
        Dim MidPoint As PointF = GetMidPoint10()
        Dim radius2 As Single = GetRadius_2_10()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        MidPoint.Y + radius2 - LargestSize.Height,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    MidPoint.Y + radius2 - LargestSize.Height,
                                                    LargestSize.Width, LargestSize.Height - InvalidationHeight)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontDescent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub Paint12Sides(g As Graphics)
        ' https://www.jamieyorkpress.com/wp-content/uploads/2018/05/Instructions-for-Drawing-a-Dodecahedron.pdf
        Dim SngRect As RectangleF = GetBoundingRectangle()

        Dim OuterPoints(10) As PointF
        Dim InnerPoints(4) As PointF
        Dim degrees As Single = 270.0!
        Dim OuterRadius As Single = SngRect.Width / 2.0!
        Dim InnerRadius As Single   ' length of a side is the radius of the inner circle
        Dim i As Integer

        For i = 0 To 9
            OuterPoints(i) = New PointF(OuterRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, OuterRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 36.0!
        Next
        OuterPoints(10) = OuterPoints(0)

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            For i = 0 To 9
                gp.AddLine(OuterPoints(i), OuterPoints(i + 1))
            Next
            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
        End Using

        Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
            For i = 0 To 9
                g.DrawLine(EdgePen, OuterPoints(i), OuterPoints(i + 1))
            Next

            InnerRadius = OuterPoints(3).Y - OuterPoints(2).Y
            degrees = 270.0!
            For i = 0 To 4
                InnerPoints(i) = New PointF(InnerRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, InnerRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
                degrees += 72.0!
            Next
            For i = 0 To 3
                g.DrawLine(EdgePen, InnerPoints(i), InnerPoints(i + 1))
                g.DrawLine(EdgePen, InnerPoints(i), OuterPoints(2 * i))
            Next
            g.DrawLine(EdgePen, InnerPoints(4), InnerPoints(0))
            g.DrawLine(EdgePen, InnerPoints(4), OuterPoints(8))
        End Using

        If DrawHiddenEdges Then
            Dim gs As Drawing2D.GraphicsState = g.Save
            Dim matrix As Drawing2D.Matrix = New Drawing2D.Matrix
            matrix.RotateAt(180.0!, New PointF(SngRect.Width / 2.0!, SngRect.Height / 2.0!))
            g.Transform = matrix
            Dim DashSize As Single = 0.2!
            Dim DashFade As Single = 0.1!
            Dim Dashes As List(Of Single) = New List(Of Single)
            Do
                Dashes.Add(0.75!)
                Dashes.Add(DashSize)
                DashSize += DashFade
                DashFade += 0.05!
            Loop Until Dashes.Sum > InnerRadius
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                For i = 0 To 3
                    g.DrawLine(p, OuterPoints(2 * i), InnerPoints(i))
                Next
                g.DrawLine(p, OuterPoints(8), InnerPoints(4))
            End Using
            If Dashes.Count >= 4 Then
                Dashes.RemoveRange(0, Dashes.Count - 2)
            End If
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                For i = 0 To 3
                    g.DrawLine(p, InnerPoints(i), InnerPoints(i + 1))
                Next
                g.DrawLine(p, InnerPoints(4), InnerPoints(0))
            End Using
            g.Restore(gs)
        End If
    End Sub
    Private Sub SetValueRect12(LargestSize As SizeF)
        LargestSize = New SizeF(LargestSize.Width + 1.0!, LargestSize.Height + 1.0!)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        BoundingRectangle.Top + (BoundingRectangle.Height - LargestSize.Height) / 2.0!,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    BoundingRectangle.Top + (BoundingRectangle.Width - LargestSize.Width) / 2.0! - ValueFontDescent,
                                                    LargestSize.Width, LargestSize.Height - InvalidationHeight)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontDescent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub Paint20Sides(g As Graphics)
        ' https://youtu.be/ithlX422Ubo
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()

        Dim OuterRadius As Single = BoundingRectangle.Height / 2
        Dim HexagonPoints(6) As PointF
        Dim degrees As Single = 270.0!
        Dim i As Integer

        For i = 0 To 5
            HexagonPoints(i) = New PointF(OuterRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, OuterRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
            degrees += 60.0!
        Next
        HexagonPoints(6) = HexagonPoints(0)

        Using gp As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
            For i = 0 To 5
                gp.AddLine(HexagonPoints(i), HexagonPoints(i + 1))
            Next
            Using FaceBrush As Brush = New SolidBrush(FaceColor)
                Using rgn As Region = New Region(gp)
                    g.FillRegion(FaceBrush, rgn)
                End Using
            End Using
        End Using

        Dim TrianglePoints(2) As PointF
        Using EdgePen As Pen = New Pen(EdgeColor, EdgeWeight)
            For i = 0 To 5
                g.DrawLine(EdgePen, HexagonPoints(i), HexagonPoints(i + 1))
            Next

            Dim MiddleRadius = 5.0! * OuterRadius / 8.0!
            degrees = 210.0!

            For i = 0 To 2
                TrianglePoints(i) = New PointF(MiddleRadius * Math.Cos(Math.PI * degrees / 180.0!) + OuterRadius, MiddleRadius * Math.Sin(Math.PI * degrees / 180.0!) + OuterRadius)
                degrees += 120.0!
            Next
            For i = 0 To 1
                g.DrawLine(EdgePen, TrianglePoints(i), TrianglePoints(i + 1))
            Next
            g.DrawLine(EdgePen, TrianglePoints(2), TrianglePoints(0))

            g.DrawLine(EdgePen, HexagonPoints(0), TrianglePoints(0))
            g.DrawLine(EdgePen, HexagonPoints(0), TrianglePoints(1))
            g.DrawLine(EdgePen, HexagonPoints(1), TrianglePoints(1))
            g.DrawLine(EdgePen, HexagonPoints(1), TrianglePoints(1))
            g.DrawLine(EdgePen, HexagonPoints(2), TrianglePoints(1))
            g.DrawLine(EdgePen, HexagonPoints(2), TrianglePoints(2))
            g.DrawLine(EdgePen, HexagonPoints(5), TrianglePoints(0))
            g.DrawLine(EdgePen, HexagonPoints(4), TrianglePoints(0))
            g.DrawLine(EdgePen, HexagonPoints(4), TrianglePoints(2))
            g.DrawLine(EdgePen, HexagonPoints(3), TrianglePoints(2))
        End Using

        If DrawHiddenEdges Then
            Dim gs As Drawing2D.GraphicsState = g.Save
            Dim matrix As Drawing2D.Matrix = New Drawing2D.Matrix
            matrix.RotateAt(180.0!, New PointF(BoundingRectangle.Width / 2.0!, BoundingRectangle.Height / 2.0!))
            g.Transform = matrix
            Dim DashSize As Single = 1.0!
            Dim DashFade As Single = 0.25!
            Dim Dashes As List(Of Single) = New List(Of Single)
            Do
                Dashes.Add(1.0!)
                Dashes.Add(DashSize)
                DashSize += DashFade
                DashFade += 0.25!
            Loop Until Dashes.Sum > BoundingRectangle.Width / 2.0!
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, HexagonPoints(0), TrianglePoints(0))
                g.DrawLine(p, HexagonPoints(0), TrianglePoints(1))
                g.DrawLine(p, HexagonPoints(2), TrianglePoints(1))
                g.DrawLine(p, HexagonPoints(2), TrianglePoints(2))
                g.DrawLine(p, HexagonPoints(4), TrianglePoints(0))
                g.DrawLine(p, HexagonPoints(4), TrianglePoints(2))
            End Using
            If Dashes.Count >= 4 Then
                Dashes.RemoveRange(0, Dashes.Count - 2)
            End If
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                For i = 0 To 1
                    g.DrawLine(p, TrianglePoints(i), TrianglePoints(i + 1))
                Next
                g.DrawLine(p, TrianglePoints(2), TrianglePoints(0))
            End Using
            DashSize = 0.5!
            DashFade = 0.25!
            Dashes.Clear()
            Do
                Dashes.Add(1.0!)
                Dashes.Add(DashSize)
                DashSize += DashFade
                DashFade += 0.5!
            Loop Until Dashes.Sum > BoundingRectangle.Width / 2.0!
            Using p As Pen = New Pen(HiddenEdgeColor, HiddenEdgeWeight) With {.DashStyle = Drawing2D.DashStyle.Custom, .DashPattern = Dashes.ToArray}
                g.DrawLine(p, HexagonPoints(1), TrianglePoints(1))
                g.DrawLine(p, HexagonPoints(5), TrianglePoints(0))
                g.DrawLine(p, HexagonPoints(3), TrianglePoints(2))
            End Using

            g.Restore(gs)
        End If
    End Sub
    Private Sub SetValueRect20(LargestSize As SizeF)
        LargestSize = New SizeF(LargestSize.Width + 1.0!, LargestSize.Height + 1.0!)
        Dim BoundingRectangle As RectangleF = GetBoundingRectangle()
        ValueRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                        BoundingRectangle.Top + (BoundingRectangle.Height - LargestSize.Height) / 2.0!,
                                        LargestSize.Width, LargestSize.Height)
        Dim InvalidationHeight As Single = ValueFontAscent + ValueFontDescent
        ValueInvalidationRectangle = New RectangleF(BoundingRectangle.Left + (BoundingRectangle.Width - LargestSize.Width) / 2.0!,
                                                    BoundingRectangle.Top + (BoundingRectangle.Width - LargestSize.Width) / 2.0! - ValueFontDescent,
                                                    LargestSize.Width, LargestSize.Height - ValueFontAscent)
        ValueRenderingRectangle = Rectangle.Round(New RectangleF(ValueInvalidationRectangle.Left,
                                                                 ValueInvalidationRectangle.Top - ValueFontDescent,
                                                                 ValueInvalidationRectangle.Width, LargestSize.Height))
    End Sub

    Private Sub DieControl_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged

    End Sub

    Private Sub DieControl_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub
End Class
