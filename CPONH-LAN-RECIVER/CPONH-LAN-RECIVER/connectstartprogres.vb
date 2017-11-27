Public Class connectstartprogres
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Sub connectstartprogres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(ProgressBar1.Handle, 1040, 3, 0)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then Me.Hide()
    End Sub
End Class