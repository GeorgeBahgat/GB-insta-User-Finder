Public Class Form1
    Function G(ByRef length As Integer) As String

        Randomize()

        Dim allowableChars As String

        allowableChars = "abcdefghijklmnopqrstuvwzxy12345678.9_"



        Dim i As Integer

        For i = 1 To length

            G = G & Mid$(allowableChars, Int(Rnd() * Len(allowableChars) + 1), 1)

        Next

    End Function



   


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        e1.Navigate("https://www.instagram.com/" + TextBox2.Text)

        Timer1.Stop()
        Timer2.Start()


    End Sub
    '
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = G(TextBox1.Text)
        Timer1.Start()
        Button2.Show()
        Button1.Hide()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox3.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If e1.Document.Body.InnerHtml.Contains("Sorry, this page isn't available.") Then
            Timer2.Stop()
            e1.Navigate("www.instagram.com")
            TextBox3.AppendText(TextBox2.Text + vbCrLf)
            TextBox2.Text = G(TextBox1.Text)
            Timer1.Start()
        Else
            TextBox2.Text = G(TextBox1.Text)
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
        Button2.Hide()
        Button1.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.facebook.com/Progwela")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCCZX5sZL964uXhruKKNZjkw")
    End Sub

    Private Sub Timer3_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Height += 2
        If Me.Height = 577 Then
            Timer3.Stop()
        End If
    End Sub
End Class
