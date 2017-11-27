Public Class layed
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.ten1x = My.Settings.ten1x + Val(TextBox1.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.ten1x = My.Settings.ten1x - Val(TextBox1.Text)
    End Sub

    Private Sub layed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Label1.Hide()
        Timer4.Stop()
    End Sub
   
    Private Sub layed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer4.Start()
        Form1.Label1.Show()
    End Sub

  

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        My.Settings.ten1y = My.Settings.ten1y - Val(TextBox1.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.ten1y = My.Settings.ten1y + Val(TextBox1.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.ten2y = My.Settings.ten2y - Val(TextBox1.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Settings.ten2y = My.Settings.ten2y + Val(TextBox1.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.ten2x = My.Settings.ten2x + Val(TextBox1.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Settings.ten2x = My.Settings.ten2x - Val(TextBox1.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        My.Settings.ten3y = My.Settings.ten3y - Val(TextBox1.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        My.Settings.ten3y = My.Settings.ten3y + Val(TextBox1.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        My.Settings.ten3x = My.Settings.ten3x - Val(TextBox1.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Settings.ten3x = My.Settings.ten3x + Val(TextBox1.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        My.Settings.ten4y = My.Settings.ten4y - Val(TextBox1.Text)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        My.Settings.ten4y = My.Settings.ten4y + Val(TextBox1.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        My.Settings.ten4x = My.Settings.ten4x + Val(TextBox1.Text)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        My.Settings.ten4x = My.Settings.ten4x - Val(TextBox1.Text)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Form1.TextBox1.Text = TextBox2.Text
        Form1.TextBox2.Text = TextBox2.Text
        Form1.TextBox3.Text = TextBox2.Text
        Form1.TextBox4.Text = TextBox2.Text
    End Sub
    '-----------------------------------------------------------------------------------------
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        My.Settings.time1y = My.Settings.time1y - Val(TextBox1.Text)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        My.Settings.time1y = My.Settings.time1y + Val(TextBox1.Text)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        My.Settings.time1x = My.Settings.time1x + Val(TextBox1.Text)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        My.Settings.time1x = My.Settings.time1x - Val(TextBox1.Text)
    End Sub
    '------------------------------------------------------------------------------------------
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        My.Settings.time2y = My.Settings.time2y - Val(TextBox1.Text)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        My.Settings.time2y = My.Settings.time2y + Val(TextBox1.Text)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        My.Settings.time2x = My.Settings.time2x + Val(TextBox1.Text)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        My.Settings.time2x = My.Settings.time2x - Val(TextBox1.Text)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        My.Settings.time3y = My.Settings.time3y - Val(TextBox1.Text)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        My.Settings.time3y = My.Settings.time3y + Val(TextBox1.Text)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        My.Settings.time3x = My.Settings.time3x + Val(TextBox1.Text)
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        My.Settings.time3x = My.Settings.time3x - Val(TextBox1.Text)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        My.Settings.time4y = My.Settings.time4y - Val(TextBox1.Text)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        My.Settings.time4y = My.Settings.time4y + Val(TextBox1.Text)
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        My.Settings.time4x = My.Settings.time4x + Val(TextBox1.Text)
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        My.Settings.time4x = My.Settings.time4x - Val(TextBox1.Text)
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        My.Settings.dapan1y = My.Settings.dapan1y - Val(TextBox1.Text)
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        My.Settings.dapan1y = My.Settings.dapan1y + Val(TextBox1.Text)
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        My.Settings.dapan1x = My.Settings.dapan1x + Val(TextBox1.Text)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        My.Settings.dapan1x = My.Settings.dapan1x - Val(TextBox1.Text)
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        My.Settings.dapan2y = My.Settings.dapan2y - Val(TextBox1.Text)
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        My.Settings.dapan2y = My.Settings.dapan2y + Val(TextBox1.Text)
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        My.Settings.dapan2x = My.Settings.dapan2x + Val(TextBox1.Text)
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        My.Settings.dapan2x = My.Settings.dapan2x - Val(TextBox1.Text)
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        My.Settings.dapan3y = My.Settings.dapan3y - Val(TextBox1.Text)
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        My.Settings.dapan3y = My.Settings.dapan3y + Val(TextBox1.Text)
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        My.Settings.dapan3x = My.Settings.dapan3x + Val(TextBox1.Text)
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        My.Settings.dapan3x = My.Settings.dapan3x - Val(TextBox1.Text)
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        My.Settings.dapan4y = My.Settings.dapan4y - Val(TextBox1.Text)
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        My.Settings.dapan4y = My.Settings.dapan4y + Val(TextBox1.Text)
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        My.Settings.dapan4x = My.Settings.dapan4x + Val(TextBox1.Text)
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        My.Settings.dapan4x = My.Settings.dapan4x - Val(TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class