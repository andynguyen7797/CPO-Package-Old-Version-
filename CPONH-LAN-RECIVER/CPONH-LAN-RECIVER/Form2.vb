Public Class Form2
    Public CS_DROPSHADOW As Int32 = &H20000
    Dim newpoint As System.Drawing.Point
    Dim x, y As Integer
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams

        Get

            Dim parameters As CreateParams = MyBase.CreateParams

            parameters.ClassStyle += CS_DROPSHADOW

            Return parameters

        End Get

    End Property
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Email: vunguyenduc.it@gmail.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
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
            Me.Location = newpoint
        End If
    End Sub
End Class