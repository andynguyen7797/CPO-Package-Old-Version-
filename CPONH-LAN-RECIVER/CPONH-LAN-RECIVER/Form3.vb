Public Class Form3
    Public CS_DROPSHADOW As Int32 = &H20000

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams

        Get

            Dim parameters As CreateParams = MyBase.CreateParams

            parameters.ClassStyle += CS_DROPSHADOW

            Return parameters

        End Get

    End Property
    Dim bienluu As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles hopanh.Click

    End Sub


    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles hopanh.MouseDoubleClick
        Me.Hide()
    End Sub

  

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hopanh.BackgroundImage = My.Resources.anh1

        'If My.Settings.ddd = "2" Then
        '    
        'End If

        'If My.Settings.ddd = "3" Then
        '    hopanh.BackgroundImage = My.Resources.anh2
        'End If

        'If My.Settings.ddd = "4" Then
        '    hopanh.BackgroundImage = My.Resources.anh3
        'End If


    End Sub
End Class