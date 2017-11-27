Public Class CPOSTG

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Lưu thành công !")
        My.Settings.ip1 = TextBoxipv4TS1.Text
        My.Settings.ip2 = TextBoxipv4TS2.Text
        My.Settings.ip3 = TextBoxipv4TS3.Text
        My.Settings.ip4 = TextBoxipv4TS4.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CPOSTG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxipv4TS1.Text = My.Settings.ip1
        TextBoxipv4TS2.Text = My.Settings.ip2
        TextBoxipv4TS3.Text = My.Settings.ip3
        TextBoxipv4TS4.Text = My.Settings.ip4
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.ico1 = "ok" Then
            icon_done_ts1.Show()
        Else
            icon_done_ts1.Hide()
            icon_qu_ts1.Show()
        End If
        If My.Settings.ico2 = "ok" Then
            icon_done_ts2.Show()
        Else
            icon_done_ts2.Hide()
            icon_qu_ts2.Show()
        End If
        If My.Settings.ico3 = "ok" Then
            icon_done_ts3.Show()
        Else
            icon_done_ts3.Hide()
            icon_qu_ts3.Show()
        End If
        If My.Settings.ico4 = "ok" Then
            icon_done_ts4.Show()
        Else
            icon_done_ts4.Hide()
            icon_qu_ts4.Show()
        End If

    End Sub
End Class