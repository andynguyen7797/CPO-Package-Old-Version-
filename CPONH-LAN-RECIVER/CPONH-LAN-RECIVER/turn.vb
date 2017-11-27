Public Class turn

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "jppro29" Then
            My.Settings.ktrabq = 0
            Me.Close()
            MsgBox("restart program to see result !")
        End If
    End Sub


    Private Sub turn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class