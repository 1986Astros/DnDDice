Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class DieSaveDialog
    Public Sub New()
        InitializeComponent()

        Properties = New DieSaveDialogProperties
        PropertyGrid1.SelectedObject = Properties
    End Sub

    Public Sub New(Source As DieControl)
        InitializeComponent()

        Properties = New DieSaveDialogProperties
        PropertyGrid1.SelectedObject = Properties

        ' Initialize the properties of this DieSaveDialogProperties by cloning the source.
        Dim pis As Reflection.PropertyInfo() = GetType(DieSaveDialogProperties).GetProperties
        Dim piSource As Reflection.PropertyInfo
        For Each piDestination As Reflection.PropertyInfo In pis
            ' todo: Check that the source and destination Types are the same.
            piSource = GetType(DieControl).GetProperty(piDestination.Name)
            piDestination.SetValue(Properties, piSource.GetValue(Source))
        Next
    End Sub

    ' Update the Properties of DieControl1 from the DieSaveDialogProperties.
    Private Sub Properties_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles Properties.PropertyChanged
        Dim piDestination = GetType(DieControl).GetProperty(e.PropertyName)
        If piDestination IsNot Nothing Then
            ' todo: Check that the source and destination Types are the same.
            Dim piSource As Reflection.PropertyInfo = GetType(DieSaveDialogProperties).GetProperty(e.PropertyName)
            piDestination.SetValue(DieControl1, piSource.GetValue(Properties))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            DieControl1.Save(SaveFileDialog1.FileName)
            Close()
        End If
    End Sub

    Public WithEvents Properties As DieSaveDialogProperties
End Class

Public Class DieSaveDialogProperties
    Implements INotifyPropertyChanged

#Region "Common Windows Properties"
    ' DieControl inherits these properties from UserControl
    <Category("Appearance")>
    Public Property BackColor As Color
        Get
            Return shhBackColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhBackColor.ToArgb Then
                shhBackColor = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhBackColor As Color
    <Category("Appearance")>
    Public Property Font As Font
        Get
            Return shhFont
        End Get
        Set(value As Font)
            If Not value.Equals(shhFont) Then
                shhFont = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhFont As Font
    <Category("Layout")>
    Public Property Size As Size
        Get
            Return shhSize
        End Get
        Set(value As Size)
            If Not value.Equals(shhSize) Then
                shhSize = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhSize As Size
#End Region

#Region "Die Properties"
    ' This is a relevant subset of the Properties of a DieControl
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
                Me.Value = Math.Max(Me.Value, value)
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhSides As Integer

    <Category("Die Appearance")>
    Public Property Value As Integer
        Get
            Return shhValue
        End Get
        Set(value As Integer)
            If value <> shhValue Then
                shhValue = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhValue As Integer

    <DefaultValue(GetType(Color), "White")> <Category("Die Appearance")>
    Public Property FaceColor As Color
        Get
            Return shhFaceColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhFaceColor.ToArgb Then
                shhFaceColor = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhFaceColor As Color

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property EdgeColor As Color
        Get
            Return shhEdgeColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhEdgeColor.ToArgb Then
                shhEdgeColor = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhEdgeColor As Color

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property EdgeWeight As Single
        Get
            Return shhEdgeWeight
        End Get
        Set(value As Single)
            If value <> shhEdgeWeight Then
                shhEdgeWeight = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhEdgeWeight As Single

    <DefaultValue(True)> <Category("Die Appearance")>
    Public Property DrawHiddenEdges As Boolean
        Get
            Return shhDrawHiddenEdges
        End Get
        Set(value As Boolean)
            If value <> shhDrawHiddenEdges Then
                shhDrawHiddenEdges = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhDrawHiddenEdges As Boolean

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property HiddenEdgeColor As Color
        Get
            Return shhHiddenEdgeColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhHiddenEdgeColor.ToArgb Then
                shhHiddenEdgeColor = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhHiddenEdgeColor As Color

    <DefaultValue(1.0!)> <Category("Die Appearance")>
    Public Property HiddenEdgeWeight As Single
        Get
            Return shhHiddenEdgeWeight
        End Get
        Set(value As Single)
            If value <> shhHiddenEdgeWeight Then
                shhHiddenEdgeWeight = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhHiddenEdgeWeight As Single

    <DefaultValue(GetType(Color), "Black")> <Category("Die Appearance")>
    Public Property ValueColor As Color
        Get
            Return shhValueColor
        End Get
        Set(value As Color)
            If value.ToArgb <> shhValueColor.ToArgb Then
                shhValueColor = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private shhValueColor As Color

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region
End Class