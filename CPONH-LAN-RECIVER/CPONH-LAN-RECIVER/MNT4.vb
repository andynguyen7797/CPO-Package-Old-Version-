Public Class MNT4

    Private Sub MNT4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Button2.Text = CPONHMAIN.TextBox3.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button2.BackColor = My.Settings.mautieudemnt
        Button1.BackColor = My.Settings.maunoidungmnt
        Button2.ForeColor = My.Settings.mautexttieude
        Button1.ForeColor = My.Settings.mautextnoidung
        If My.Settings.boldtieude = "true" Then
            Button2.Font = New Font(Button2.Font, FontStyle.Bold)
        Else
            Button2.Font = New Font(Button2.Font, FontStyle.Regular)
        End If
        If My.Settings.boldnoidung = "true" Then
            Button1.Font = New Font(Button1.Font, FontStyle.Bold)
        Else
            Button1.Font = New Font(Button1.Font, FontStyle.Regular)
        End If
    End Sub
End Class