Public Class testfreemove
    Dim newpoint As System.Drawing.Point
    Dim x, y As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
      
        If e.Button = Windows.Forms.MouseButtons.Left Then

            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Label1.Location = newpoint
        End If
    End Sub
End Class