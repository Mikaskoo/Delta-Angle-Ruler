Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1
    Dim alku1 As Point
    Dim loppu1 As Point
    Dim alku2 As Point
    Dim loppu2 As Point
    Dim kulma1 As Double
    Dim kulma2 As Double
    Dim tulokset As ArrayList
    Private Enum DragMode
        Enabled
        Disabled
    End Enum
    Private Siirtoalue1 As New Rectangle(400, 0, 800, 400) ' Action area 1 for mover
    Private Siirtoalue2 As New Rectangle(400, 400, 800, 800) 'Action area 2 for mover    
    Private IsMoving1 As DragMode = DragMode.Disabled ' Set the Drag Mode
    Private IsMoving2 As DragMode = DragMode.Disabled ' Set the Drag Mode
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Beige
        TransparencyKey = BackColor
        TextBox1.ForeColor = Color.Red
        TextBox2.ForeColor = Color.Blue
        TextBox1.BackColor = TextBox1.BackColor
        TextBox2.BackColor = TextBox2.BackColor
        BtnDelete.Enabled = False
        'Dim myGraphics As Graphics = Me.CreateGraphics
        'Dim NotificationText As String = New String("Drag here")
        'Dim NotificationPoint1 As Point = New Point(600, 200)
        'Dim NotificationFont As Font = New Font("Arial", 12)
        'Dim NotificationBrush1 As Brush = New Drawing.SolidBrush(Color.Red)
        'Dim NotificationBrush2 As Brush = New Drawing.SolidBrush(Color.Blue)
        'myGraphics.DrawString(NotificationText, NotificationFont, NotificationBrush1, 600, 200)
        'Dim NotificationBrush As Brush = New Drawing.SolidBrush(Color.Blue)
        'myGraphics.DrawString(NotificationText, NotificationFont, NotificationBrush2, 600, 600)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ' ACTIVATE DRAG MODE IF MOVER AREA IS CLICKED
        If Siirtoalue1.Contains(e.Location) Then IsMoving1 = DragMode.Enabled
        If Siirtoalue2.Contains(e.Location) Then IsMoving2 = DragMode.Enabled
    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        ' DISABLE DRAG MODE WHEN MOUSE BUTTON IS RELEASED
        If IsMoving1 = DragMode.Enabled Then IsMoving1 = DragMode.Disabled
        If IsMoving2 = DragMode.Enabled Then IsMoving2 = DragMode.Disabled
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCopy1.Click
        LstBoxResults.Items.Add(TxtBoxResult1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCopy2.Click
        LstBoxResults.Items.Add(TxtBoxResult2.Text)
    End Sub
    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove



        Dim vektori1 As Pen
        vektori1 = New Pen(Color.Red, 3)
        Dim spotti1 As Pen
        spotti1 = New Pen(Color.Red, 3)
        Dim vektori2 As Pen
        vektori2 = New Pen(Color.Blue, 3)
        Dim spotti2 As Pen
        spotti2 = New Pen(Color.Blue, 3)
        Dim keskipiste1 As Point
        keskipiste1.X = 600
        keskipiste1.Y = 200
        Dim keskipiste2 As Point
        keskipiste2.X = 600
        keskipiste2.Y = 600
        If IsMoving1 = DragMode.Enabled Then
            Console.WriteLine("painetaan 1")
            Refresh()
            Dim eroX1 As Short
            Dim eroY1 As Short

            eroX1 = keskipiste1.X - e.Location.X
            eroY1 = keskipiste1.Y - e.Location.Y
            CreateGraphics.DrawLine(vektori1, e.Location.X, e.Location.Y, eroX1 + keskipiste1.X, eroY1 + keskipiste1.Y)

            alku1.X = e.Location.X
            alku1.Y = e.Location.Y
            loppu1.X = eroX1 + keskipiste1.X
            loppu1.Y = eroY1 + keskipiste1.Y
            'Me.CreateGraphics.DrawRectangle(spotti1, keskipiste1.X - 2, keskipiste1.Y - 2, 4, 4)
            Console.WriteLine(e.Location)
            Console.WriteLine(keskipiste1)
            Console.WriteLine("deltax" & eroX1)
            Console.WriteLine("deltay" & eroY1)
            eroY1 = eroY1
            kulma1 = Math.Atan(eroY1 / eroX1)
            kulma1 = kulma1 * 180.0 / Math.PI
            Console.WriteLine(kulma1)
            TextBox1.Text = Math.Round(kulma1, 1)
            Console.WriteLine()
            Console.WriteLine(vektori1)
            Console.WriteLine(alku1)
            Console.WriteLine(loppu1)

        End If
        If IsMoving2 = DragMode.Enabled Then
            Console.WriteLine("painetaan 2")
            Refresh()

            Dim eroX2 As Short
            Dim eroY2 As Short





            alku2.X = e.Location.X
            alku2.Y = e.Location.Y
            eroX2 = keskipiste2.X - e.Location.X
            eroY2 = keskipiste2.Y - e.Location.Y
            CreateGraphics.DrawLine(vektori2, e.Location.X, e.Location.Y, eroX2 + keskipiste2.X, eroY2 + keskipiste2.Y)
            alku2.X = e.Location.X
            alku2.Y = e.Location.Y
            loppu2.X = eroX2 + keskipiste2.X
            loppu2.Y = eroY2 + keskipiste2.Y
            ' Me.CreateGraphics.DrawRectangle(spotti2, keskipiste2.X - 2, keskipiste2.Y - 2, 4, 4)
            Console.WriteLine(e.Location)
            Console.WriteLine(keskipiste2)
            Console.WriteLine("deltax" & eroX2)
            Console.WriteLine("deltay" & eroY2)
            eroY2 = eroY2
            kulma2 = Math.Atan(eroY2 / eroX2)
            kulma2 = kulma2 * 180.0 / Math.PI
            Console.WriteLine(kulma2)
            TextBox2.Text = Math.Round(kulma2, 1)
            Console.WriteLine()
            Console.WriteLine(vektori2)
            Console.WriteLine(alku2)
            Console.WriteLine(loppu2)
        End If

        If IsMoving1 = DragMode.Disabled And IsMoving2 = DragMode.Disabled Then
            Console.WriteLine("ei paineta")
            'Me.Refresh()
            'Console.Beep()
            Dim vektor1 As Pen
            vektor1 = New Pen(Color.Red, 3)

            Dim vektor2 As Pen
            vektor2 = New Pen(Color.Blue, 3)

            CreateGraphics.DrawLine(vektor1, alku1, loppu1)
            CreateGraphics.DrawLine(vektor2, alku2, loppu2)
            'Me.CreateGraphics.DrawLine(vektori1, alku1.X, alku1.Y, eroX1 + keskipiste1.X, eroY1 + keskipiste1.Y)
            'Me.CreateGraphics.DrawLine(vektori2, alku2.X, alku2.Y, eroX2 + keskipiste2.X, eroY2 + keskipiste2.Y)
            CreateGraphics.DrawRectangle(spotti1, keskipiste1.X - 2, keskipiste1.Y - 2, 4, 4)
            CreateGraphics.DrawRectangle(spotti2, keskipiste2.X - 2, keskipiste2.Y - 2, 4, 4)
            Console.WriteLine()
            Console.WriteLine(vektori1)
            Console.WriteLine(alku1)
            Console.WriteLine(loppu1)
            Console.WriteLine()
            Console.WriteLine(vektori2)
            Console.WriteLine(alku2)
            Console.WriteLine(loppu2)
            TxtBoxResult1.Text = Math.Abs(Math.Round(kulma1 - kulma2, 1))
            TxtBoxResult2.Text = Math.Abs(Math.Round(180 - Math.Abs(kulma1 - kulma2), 1))

            Dim rajaviivat As Pen
            rajaviivat = New Pen(Color.Black, 1)
            ''Me.CreateGraphics.DrawRectangle(rajaviivat, 500, 0, 300, 300)
            ''Me.CreateGraphics.DrawRectangle(rajaviivat, 500, 300, 300, 300)





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
End Class
