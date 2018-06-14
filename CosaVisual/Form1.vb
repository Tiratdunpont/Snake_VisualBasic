Public Class Form1
    Dim u As Boolean = False
    Dim dos As Boolean = False
    Public easy As Boolean = False
    Public medium As Boolean = False
    Public hard As Boolean = False
    Public easy2 As Boolean = False
    Public medium2 As Boolean = False
    Public hard2 As Boolean = False
    Public a1 As String
    Public a2 As String
    Public lal As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Label1.Text = "300 seconds"
        If Not TextBox1.Text.Equals("") Then
            Form2.Label5.Text = "User: " & TextBox1.Text
            If RadioButton1.Checked Then
                Me.Hide()
                Form2.Show()
                Form2.Timer2.Interval = 200
            ElseIf RadioButton2.Checked Then
                Me.Hide()
                Form2.Show()
                Form2.Timer2.Interval = 100
            ElseIf RadioButton3.Checked Then
                Me.Hide()
                Form2.Show()
                Form2.Timer2.Interval = 50
            Else
                MessageBox.Show("No has introduit dificultat")
            End If
        Else
            MessageBox.Show("No has introduit Nom")
        End If
        If CheckBox1.Checked Then
            Form2.Label3.Text = "Num1"
        Else
            Form2.Label3.Text = ""
        End If

        If CheckBox2.Checked Then
            Form2.Label4.Text = "Num2"
        Else
            Form2.Label4.Text = ""
        End If
    End Sub

    Private Sub VermellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VermellToolStripMenuItem.Click
        Me.BackColor = Color.Red
        Form2.BackColor = Color.Red
        Form3.BackColor = Color.Red
    End Sub

    Private Sub GrocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrocToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
        Form2.BackColor = Color.Yellow
        Form3.BackColor = Color.Yellow
    End Sub

    Private Sub BlauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlauToolStripMenuItem.Click
        Me.BackColor = Color.Blue
        Form2.BackColor = Color.Blue
        Form3.BackColor = Color.Blue
    End Sub

    Private Sub VerdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerdToolStripMenuItem.Click
        Me.BackColor = Color.Green
        Form2.BackColor = Color.Green
        Form3.BackColor = Color.Green
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Label1.Text = "300 seconds"
        If Not TextBox1.Text.Equals("") Then
            Form3.Label5.Text = "User: " & TextBox1.Text
            If RadioButton1.Checked Then
                Me.Hide()
                Form3.Show()
                Form3.Timer2.Interval = 200
            ElseIf RadioButton2.Checked Then
                Me.Hide()
                Form3.Show()
                Form3.Timer2.Interval = 100
            ElseIf RadioButton3.Checked Then
                Me.Hide()
                Form3.Show()
                Form3.Timer2.Interval = 50
            Else
                MessageBox.Show("No has introduit dificultat")
            End If
        Else
            MessageBox.Show("No has introduit Nom")
        End If
        If CheckBox1.Checked Then
            Form3.Label3.Text = "Num1"
        Else
            Form3.Label3.Text = ""
        End If

        If CheckBox2.Checked Then
            Form3.Label4.Text = "Num2"
        Else
            Form3.Label4.Text = ""
        End If
    End Sub
End Class
