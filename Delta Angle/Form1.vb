Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1
    Dim startPoint1 As Point
    Dim endPoint1 As Point
    Dim startPoint2 As Point
    Dim endPoint2 As Point
    Dim angle1 As Double
    Dim angle2 As Double
    Private Enum DragMode
        Enabled
        Disabled
    End Enum
    Private dragArea1 As New Rectangle(400, 0, 800, 400) ' Action area 1 for mover
    Private dragArea2 As New Rectangle(400, 400, 800, 800) 'Action area 2 for mover    
    Private IsMoving1 As DragMode = DragMode.Disabled ' Set the Drag Mode
    Private IsMoving2 As DragMode = DragMode.Disabled ' Set the Drag Mode
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Beige
        TransparencyKey = BackColor
        TextBox1.ForeColor = Color.Red
        TextBox2.ForeColor = Color.Blue
        TextBox1.BackColor = TextBox1.BackColor
        TextBox2.BackColor = TextBox2.BackColor
        BtnDelete.Enabled = False
        ToolTip1.SetToolTip(MyBase.ActiveForm, "Drag around blue and red dots")
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ' activate the drag mode
        If dragArea1.Contains(e.Location) Then IsMoving1 = DragMode.Enabled
        If dragArea2.Contains(e.Location) Then IsMoving2 = DragMode.Enabled
    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        ' deactivate drag mode
        If IsMoving1 = DragMode.Enabled Then IsMoving1 = DragMode.Disabled
        If IsMoving2 = DragMode.Enabled Then IsMoving2 = DragMode.Disabled
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCopy1.Click
        LstBoxResults.Items.Add(TxtBoxResult1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCopy2.Click
        LstBoxResults.Items.Add(TxtBoxResult2.Text)
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim vector1 As Pen
        vector1 = New Pen(Color.Red, 3)
        Dim spot1 As Pen
        spot1 = New Pen(Color.Red, 3)
        Dim vector2 As Pen
        vector2 = New Pen(Color.Blue, 3)
        Dim spot2 As Pen
        spot2 = New Pen(Color.Blue, 3)
        Dim center1 As Point
        center1.X = 600
        center1.Y = 200
        Dim center2 As Point
        center2.X = 600
        center2.Y = 600
        If IsMoving1 = DragMode.Enabled Then
            Refresh()
            Dim differenceX1 As Short
            Dim differenceY1 As Short
            differenceX1 = center1.X - e.Location.X
            differenceY1 = center1.Y - e.Location.Y
            CreateGraphics.DrawLine(vector1, e.Location.X, e.Location.Y, differenceX1 + center1.X, differenceY1 + center1.Y)
            startPoint1.X = e.Location.X
            startPoint1.Y = e.Location.Y
            endPoint1.X = differenceX1 + center1.X
            endPoint1.Y = differenceY1 + center1.Y
            differenceY1 = differenceY1
            angle1 = Math.Atan(differenceY1 / differenceX1)
            angle1 = angle1 * 180.0 / Math.PI
            TextBox1.Text = Math.Round(angle1, 1)
        End If
        If IsMoving2 = DragMode.Enabled Then
            Refresh()
            Dim differenceX2 As Short
            Dim differenceY2 As Short
            startPoint2.X = e.Location.X
            startPoint2.Y = e.Location.Y
            differenceX2 = center2.X - e.Location.X
            differenceY2 = center2.Y - e.Location.Y
            CreateGraphics.DrawLine(vector2, e.Location.X, e.Location.Y, differenceX2 + center2.X, differenceY2 + center2.Y)
            startPoint2.X = e.Location.X
            startPoint2.Y = e.Location.Y
            endPoint2.X = differenceX2 + center2.X
            endPoint2.Y = differenceY2 + center2.Y
            differenceY2 = differenceY2
            angle2 = Math.Atan(differenceY2 / differenceX2)
            angle2 = angle2 * 180.0 / Math.PI
            TextBox2.Text = Math.Round(angle2, 1)
        End If

        If IsMoving1 = DragMode.Disabled And IsMoving2 = DragMode.Disabled Then
            Dim vektor1 As Pen
            vektor1 = New Pen(Color.Red, 3)
            Dim vektor2 As Pen
            vektor2 = New Pen(Color.Blue, 3)
            CreateGraphics.DrawLine(vektor1, startPoint1, endPoint1)
            CreateGraphics.DrawLine(vektor2, startPoint2, endPoint2)
            CreateGraphics.DrawRectangle(spot1, center1.X - 2, center1.Y - 2, 4, 4)
            CreateGraphics.DrawRectangle(spot2, center2.X - 2, center2.Y - 2, 4, 4)
            TxtBoxResult1.Text = Math.Abs(Math.Round(angle1 - angle2, 1))
            TxtBoxResult2.Text = Math.Abs(Math.Round(180 - Math.Abs(angle1 - angle2), 1))
        End If
    End Sub
    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstBoxResults.KeyDown
        'Press Control+C and selected values are copied to clipboard
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Dim copy_buffer As New System.Text.StringBuilder
            For Each item As Object In LstBoxResults.SelectedItems
                copy_buffer.AppendLine(item.ToString)
            Next
            If copy_buffer.Length > 0 Then
                Clipboard.SetText(copy_buffer.ToString)
            End If
        End If
    End Sub

    Private Sub ResultListChanged(sender As Object, e As EventArgs) Handles LstBoxResults.SelectedIndexChanged
        If LstBoxResults.SelectedItem = "" Then
            BtnDelete.Enabled = False
        Else
            BtnDelete.Enabled = True
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        LstBoxResults.Items.RemoveAt(LstBoxResults.SelectedIndex)
    End Sub
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

    End Sub
    Private Sub ListBox1Tooltip(sender As Object, e As EventArgs) Handles LstBoxResults.MouseHover
        ToolTip1.SetToolTip(LstBoxResults, "Use CTRL+C to copy selected values to clipboard")
    End Sub
End Class
