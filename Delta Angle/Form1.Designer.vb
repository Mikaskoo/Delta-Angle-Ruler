<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TxtBoxResult1 = New TextBox()
        Label4 = New Label()
        TxtBoxResult2 = New TextBox()
        BtnCopy1 = New Button()
        BtnCopy2 = New Button()
        LstBoxResults = New ListBox()
        BtnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(159), CByte(159), CByte(159))
        Label1.Location = New Point(18, 22)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 0
        Label1.Text = "Angle 1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(160, 19)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(63, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(159), CByte(159), CByte(159))
        Label2.Location = New Point(18, 52)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 0
        Label2.Text = "Angle 2"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(160, 50)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(63, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(159), CByte(159), CByte(159))
        Label3.Location = New Point(18, 84)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 0
        Label3.Text = "Difference 1"
        ' 
        ' TxtBoxResult1
        ' 
        TxtBoxResult1.Location = New Point(160, 81)
        TxtBoxResult1.Margin = New Padding(2)
        TxtBoxResult1.Name = "TxtBoxResult1"
        TxtBoxResult1.ReadOnly = True
        TxtBoxResult1.Size = New Size(63, 27)
        TxtBoxResult1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(159), CByte(159), CByte(159))
        Label4.Location = New Point(18, 115)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 0
        Label4.Text = "Difference 2"
        ' 
        ' TxtBoxResult2
        ' 
        TxtBoxResult2.Location = New Point(160, 112)
        TxtBoxResult2.Margin = New Padding(2)
        TxtBoxResult2.Name = "TxtBoxResult2"
        TxtBoxResult2.ReadOnly = True
        TxtBoxResult2.Size = New Size(63, 27)
        TxtBoxResult2.TabIndex = 1
        ' 
        ' BtnCopy1
        ' 
        BtnCopy1.BackgroundImageLayout = ImageLayout.None
        BtnCopy1.Location = New Point(274, 81)
        BtnCopy1.Margin = New Padding(2)
        BtnCopy1.Name = "BtnCopy1"
        BtnCopy1.Size = New Size(71, 27)
        BtnCopy1.TabIndex = 2
        BtnCopy1.Text = "Copy"
        BtnCopy1.UseVisualStyleBackColor = True
        ' 
        ' BtnCopy2
        ' 
        BtnCopy2.Location = New Point(274, 112)
        BtnCopy2.Margin = New Padding(2)
        BtnCopy2.Name = "BtnCopy2"
        BtnCopy2.Size = New Size(71, 27)
        BtnCopy2.TabIndex = 2
        BtnCopy2.Text = "Copy"
        BtnCopy2.UseVisualStyleBackColor = True
        ' 
        ' LstBoxResults
        ' 
        LstBoxResults.FormattingEnabled = True
        LstBoxResults.Location = New Point(160, 142)
        LstBoxResults.Margin = New Padding(2)
        LstBoxResults.Name = "LstBoxResults"
        LstBoxResults.SelectionMode = SelectionMode.MultiSimple
        LstBoxResults.Size = New Size(63, 604)
        LstBoxResults.TabIndex = 3
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(274, 719)
        BtnDelete.Margin = New Padding(2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(71, 27)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackgroundImage = My.Resources.Resources._800x800
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1008, 1008)
        Controls.Add(LstBoxResults)
        Controls.Add(BtnDelete)
        Controls.Add(BtnCopy2)
        Controls.Add(BtnCopy1)
        Controls.Add(TxtBoxResult2)
        Controls.Add(Label4)
        Controls.Add(TxtBoxResult1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Delta Angle Ruler"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxResult1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxResult2 As TextBox
    Friend WithEvents BtnCopy1 As Button
    Friend WithEvents BtnCopy2 As Button
    Friend WithEvents LstBoxResults As ListBox
    Friend WithEvents BtnDelete As Button

End Class
