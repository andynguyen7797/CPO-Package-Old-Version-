Public Class confirmexit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.keyanh2 = My.Settings.keyanh2 + 1
        If My.Settings.keyanh2 > 3 Then
            My.Settings.keyanh2 = 1
        End If
        CPONHMAIN.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class