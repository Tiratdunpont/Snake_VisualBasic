
Public Class Form2
    Dim dirpast As Integer
    Dim Temps As Integer = 300
    Dim img(13, 17) As PictureBox
    Dim c As Integer = 0
    Dim directiona As Integer
    Dim random As New Random
    Dim mSnake As Integer = 1
    Dim posx As Integer = 9
    Dim posy As Integer = 7
    Dim aposx As Integer
    Dim aposy As Integer
    Public score As Integer = 0
    Dim t As Integer
    Dim k
    Dim Primer As Boolean = True
    Dim final As Boolean = False
    Dim n As Integer
    Dim PosSnakey As New List(Of Integer)
    Dim PosSnakex As New List(Of Integer)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Temps > 0 Then
            Temps -= 1
            If (Temps > 1) Then
                Label1.Text = Temps & " seconds"
            Else
                Label1.Text = Temps & " second"
            End If
        ElseIf (final = False) Then
            final = True
            Timer1.Stop()
            MessageBox.Show("Game Over")
            Form1.Label2.Text = "Score: " & score
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Form2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' Sets Handled to true to prevent other controls from 
        ' receiving the key if an arrow key was pressed
        Dim bHandled As Boolean = False
        Select Case e.KeyCode
            Case Keys.Right
                dirpast = directiona
                directiona = 2
                e.Handled = True
            Case Keys.Left
                dirpast = directiona
                directiona = 4
                e.Handled = True
            Case Keys.Up
                dirpast = directiona
                directiona = 1
                e.Handled = True
            Case Keys.Down
                dirpast = directiona
                directiona = 3
                e.Handled = True
        End Select
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Primer Then
            PosSnakey.Add(posy)
            PosSnakex.Add(posx)
            Primer = False
        End If
        If (directiona = 1 And dirpast <> 3) Then
            If (posx > 0) Then
                If (img(posy, posx - 1).BackColor = Color.Black) Then
                    posx -= 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                ElseIf (img(posy, posx - 1).BackColor = Color.Red) Then
                    score += 100
                    mSnake += 1
                    posx -= 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                    aleatori()
                    img(t, k).BackColor = Color.Red
                ElseIf (img(posy, posx - 1).BackColor = Color.Green And final = False) Then
                    final = True
                    Timer1.Stop()
                    MessageBox.Show("Game Over")
                    Form1.Label2.Text = "Score: " & score
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf (final = False) Then
                final = True
                Timer1.Stop()
                MessageBox.Show("Game Over")
                Form1.Label2.Text = "Score: " & score
                Form1.Show()
                Me.Close()
            End If
        ElseIf (directiona = 2 And dirpast <> 4) Then
            If (posy < 13) Then
                If (img(posy + 1, posx).BackColor = Color.Black) Then
                    posy += 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                ElseIf (img(posy + 1, posx).BackColor = Color.Red) Then
                    score += 100
                    mSnake += 1
                    posy += 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                    aleatori()
                    img(t, k).BackColor = Color.Red
                ElseIf (img(posy + 1, posx).BackColor = Color.Green And final = False) Then
                    final = True
                    Timer1.Stop()
                    MessageBox.Show("Game Over")
                    Form1.Label2.Text = "Score: " & score
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf (final = False) Then
                final = True
                Timer1.Stop()
                MessageBox.Show("Game Over")
                Form1.Label2.Text = "Score: " & score
                Form1.Show()
                Me.Close()
            End If
        ElseIf (directiona = 3 And dirpast <> 1) Then
            If (posx < 17) Then
                If (img(posy, posx + 1).BackColor = Color.Black) Then
                    posx += 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                ElseIf (img(posy, posx + 1).BackColor = Color.Red) Then
                    score += 100
                    mSnake += 1
                    posx += 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                    aleatori()
                    img(t, k).BackColor = Color.Red
                ElseIf (img(posy, posx + 1).BackColor = Color.Green And final = False) Then
                    final = True
                    Timer1.Stop()
                    MessageBox.Show("Game Over")
                    Form1.Label2.Text = "Score: " & score
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf (final = False) Then
                final = True
                Timer1.Stop()
                MessageBox.Show("Game Over")
                Form1.Label2.Text = "Score: " & score
                Form1.Show()
                Me.Close()
            End If
        ElseIf (directiona = 4 And dirpast <> 2) Then
            If (posy > 0) Then
                If (img(posy - 1, posx).BackColor = Color.Black) Then
                    posy -= 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                ElseIf (img(posy - 1, posx).BackColor = Color.Red) Then
                    score += 100
                    mSnake += 1
                    posy -= 1
                    PosSnakey.Add(posy)
                    PosSnakex.Add(posx)
                    ferSnake()
                    aleatori()
                    img(t, k).BackColor = Color.Red
                ElseIf (img(posy - 1, posx).BackColor = Color.Green And final = False) Then
                    final = True
                    Timer1.Stop()
                    MessageBox.Show("Game Over")
                    Form1.Label2.Text = "Score: " & score
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf (final = False) Then
                final = True
                Timer1.Stop()
                MessageBox.Show("Game Over")
                Form1.Label2.Text = "Score: " & score
                Form1.Show()
                Me.Close()
            End If
        End If
        Label2.Text = "Score: " & score
    End Sub
    Private Sub aleatori()
        Dim correcte As Boolean = False
        While (correcte = False)
            t = random.Next(0, 13)
            k = random.Next(0, 17)
            Dim a = PosSnakey.Count - mSnake - 1
            correcte = True
            For i As Integer = a - 1 To PosSnakex.Count - 1
                If (t = PosSnakey(i) And k = PosSnakex(i)) Then
                    correcte = False
                End If
            Next
            If (directiona = 1 And t = PosSnakex(PosSnakex.Count - 1) And k = PosSnakey(PosSnakex.Count - 1) + 1) Then
                correcte = False
            ElseIf (directiona = 2 And t = PosSnakex(PosSnakex.Count - 1) + 1 And k = PosSnakey(PosSnakex.Count - 1)) Then
                correcte = False
            ElseIf (directiona = 3 And t = PosSnakex(PosSnakex.Count - 1) - 1 And k = PosSnakey(PosSnakex.Count - 1)) Then
                correcte = False
            ElseIf (directiona = 4 And t = PosSnakex(PosSnakex.Count - 1) And k = PosSnakey(PosSnakex.Count - 1) - 1) Then
                correcte = False
            End If
        End While
    End Sub
    Private Sub ferSnake()
        Dim a = PosSnakey.Count - mSnake
        For i As Integer = a - 1 To PosSnakey.Count - 1
            If (i = a - 1 And Not (img(PosSnakey(i), PosSnakex(i)).BackColor = Color.Red)) Then
                img(PosSnakey(i), PosSnakex(i)).BackColor = Color.Black
            ElseIf (i >= a) Then
                img(PosSnakey(i), PosSnakex(i)).BackColor = Color.Green
            End If
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form1.a1
        Label4.Text = Form1.a2
        For i As Integer = 0 To 13
            For j As Integer = 0 To 17
                img(i, j) = New PictureBox()
                img(i, j).Name = "PictureBox" + Str(c)
                If i = 7 And j = 9 Then
                    img(i, j).BackColor = Color.Green
                Else
                    img(i, j).BackColor = Color.Black
                End If
                img(i, j).Location = New Point(30 + 50 * i, 30 + 30 * j)
                img(i, j).Size = New Size(40, 20)
                img(i, j).Visible = True
                c += 1
                Me.Controls.Add(img(i, j))
            Next
        Next
        Dim correcte As Boolean = False
        While (correcte = False)
            t = random.Next(0, 13)
            k = random.Next(0, 17)
            If (t = 7 And k = 9) Then
                correcte = False
            Else
                correcte = True
            End If
        End While
        img(t, k).BackColor = Color.Red
    End Sub
    Private Sub Form2_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If score > 999 Then
            If Form1.RadioButton1.Checked And Form1.easy = False Then
                Form1.easy = True
                Form1.ProgressBar1.PerformStep()
            ElseIf Form1.RadioButton2.Checked And Form1.medium = False Then
                Form1.medium = True
                Form1.ProgressBar1.PerformStep()
            ElseIf Form1.RadioButton3.Checked And Form1.hard = False Then
                Form1.hard = True
                Form1.ProgressBar1.PerformStep()
            End If
        End If
        Form1.Show()
    End Sub
End Class