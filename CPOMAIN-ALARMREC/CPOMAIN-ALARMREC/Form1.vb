Imports System.Net.Sockets
Imports System.IO

Public Class Form1
    Dim tatchuong As Integer
    Dim tinhieuchuong1 As New TcpListener(2301)
    Dim Client1 As TcpClient
    Dim dapants1 As New TcpListener(7991)
    Dim Clientts1 As TcpClient
    '---------------------------
    Dim tinhieuchuong2 As New TcpListener(2302)
    Dim Client2 As TcpClient
    Dim dapants2 As New TcpListener(7992)
    Dim Clientts2 As TcpClient
    '----------------------------
    Dim tinhieuchuong3 As New TcpListener(2303)
    Dim Client3 As TcpClient
    Dim dapants3 As New TcpListener(7993)
    Dim Clientts3 As TcpClient
    '---------------------------
    Dim tinhieuchuong4 As New TcpListener(2304)
    Dim Client4 As TcpClient
    Dim dapants4 As New TcpListener(7994)
    Dim Clientts4 As TcpClient
    '----------------------------
    Dim chuong As String


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer
        Dim Message2 As String
        Dim nStart2 As Integer
        Dim nLast2 As Integer

        If tinhieuchuong1.Pending = True Then
            If tatchuong = 1 Then
            Else
                My.Computer.Audio.Play(chuong, AudioPlayMode.WaitToComplete)
            End If


            TextBox1.BackColor = Color.Red
            Message = ""
            Client1 = tinhieuchuong1.AcceptTcpClient()
            Dim Reader As New StreamReader(Client1.GetStream())
            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            TextBox1.Text = Message



        End If
        '------------------------
        If dapants1.Pending = True Then

            Message2 = ""
            Clientts1 = dapants1.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts1.GetStream())
            While Reader.Peek > -1
                Message2 &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message2.Contains("</>") Then
                nStart2 = InStr(Message2, "</>") + 4
                nLast2 = InStr(Message2, "<\>")
                Message2 = Mid(Message2, nStart2, nLast2 - nStart2)
            End If
            TextBox5.Text = Message2



        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer
        Dim Message2 As String
        Dim nStart2 As Integer
        Dim nLast2 As Integer

        If tinhieuchuong2.Pending = True Then

            If tatchuong = 1 Then
            Else
                My.Computer.Audio.Play(chuong, AudioPlayMode.WaitToComplete)
            End If

            TextBox2.BackColor = Color.Red

            Message = ""
            Client2 = tinhieuchuong2.AcceptTcpClient()
            Dim Reader As New StreamReader(Client2.GetStream())
            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If

            TextBox2.Text = Message

        End If
        '------------------------
        If dapants2.Pending = True Then

            Message2 = ""
            Clientts2 = dapants2.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts2.GetStream())
            While Reader.Peek > -1
                Message2 &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message2.Contains("</>") Then
                nStart2 = InStr(Message2, "</>") + 4
                nLast2 = InStr(Message2, "<\>")
                Message2 = Mid(Message2, nStart2, nLast2 - nStart2)
            End If
            TextBox6.Text = Message2
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer
        Dim Message2 As String
        Dim nStart2 As Integer
        Dim nLast2 As Integer

        If tinhieuchuong3.Pending = True Then

            If tatchuong = 1 Then
            Else
                My.Computer.Audio.Play(chuong, AudioPlayMode.WaitToComplete)
            End If

            TextBox3.BackColor = Color.Red

            Message = ""
            Client3 = tinhieuchuong3.AcceptTcpClient()
            Dim Reader As New StreamReader(Client3.GetStream())
            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If

            TextBox3.Text = Message

        End If

        If dapants3.Pending = True Then

            Message2 = ""
            Clientts3 = dapants3.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts3.GetStream())
            While Reader.Peek > -1
                Message2 &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message2.Contains("</>") Then
                nStart2 = InStr(Message2, "</>") + 4
                nLast2 = InStr(Message2, "<\>")
                Message2 = Mid(Message2, nStart2, nLast2 - nStart2)
            End If
            TextBox7.Text = Message2
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer
        Dim Message2 As String
        Dim nStart2 As Integer
        Dim nLast2 As Integer

        If tinhieuchuong4.Pending = True Then
            TextBox4.BackColor = Color.Red

            If tatchuong = 1 Then
            Else
                My.Computer.Audio.Play(chuong, AudioPlayMode.WaitToComplete)
            End If


            Message = ""
            Client4 = tinhieuchuong4.AcceptTcpClient()
            Dim Reader As New StreamReader(Client4.GetStream())
            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If

            TextBox4.Text = Message

        End If
        If dapants4.Pending = True Then

            Message2 = ""
            Clientts4 = dapants4.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts4.GetStream())
            While Reader.Peek > -1
                Message2 &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message2.Contains("</>") Then
                nStart2 = InStr(Message2, "</>") + 4
                nLast2 = InStr(Message2, "<\>")
                Message2 = Mid(Message2, nStart2, nLast2 - nStart2)
            End If
            TextBox8.Text = Message2
        End If

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tinhieuchuong1.Stop()
        tinhieuchuong2.Stop()
        tinhieuchuong3.Stop()
        tinhieuchuong4.Stop()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        dapants1.Stop()
        dapants2.Stop()
        dapants3.Stop()
        dapants4.Stop()
    End Sub
    Public Sub troll()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            chuong = OpenFileDialog1.FileName
            Dim check As String = System.IO.Path.GetExtension(chuong)
            If check = ".wav" Then
                Me.Show()
            Else
                MsgBox("cái file này mà là file chuông à ? :), chọn lại đi")
                troll()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        tinhieuchuong1.Start()
        tinhieuchuong2.Start()
        tinhieuchuong3.Start()
        tinhieuchuong4.Start()
        dapants1.Start()
        dapants2.Start()
        dapants3.Start()
        dapants4.Start()
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        MsgBox("chọn đường dẫn chuông chuông cái đã, chuyện chi rồi tính sau (:", MsgBoxStyle.Exclamation)
        troll()
    End Sub



    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        TextBox4.BackColor = Color.DarkGray
        TextBox3.BackColor = Color.DarkGray
        TextBox2.BackColor = Color.DarkGray
        TextBox1.BackColor = Color.DarkGray
        TextBox4.Text = "MÁY 4"
        TextBox3.Text = "MÁY 3"
        TextBox2.Text = "MÁY 2"
        TextBox1.Text = "MÁY 1"
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "TS1 has been copied !"
        If TextBox5.Text <> String.Empty Then
            Clipboard.SetText(TextBox5.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "TS2 has been copied !"
        If TextBox6.Text <> String.Empty Then
            Clipboard.SetText(TextBox6.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "TS3 has been copied !"
        If TextBox7.Text <> String.Empty Then
            Clipboard.SetText(TextBox7.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "TS4 has been copied !"
        If TextBox8.Text <> String.Empty Then
            Clipboard.SetText(TextBox8.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("2016-2017")
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Label2.Text = "Đã copy thời gian thí sinh 1 !"
        If TextBox1.Text <> String.Empty Then
            Clipboard.SetText(TextBox1.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Label2.Text = "Đã copy thời gian thí sinh 2 !"
        If TextBox2.Text <> String.Empty Then
            Clipboard.SetText(TextBox2.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Label2.Text = "Đã copy thời gian thí sinh 3 !"
        If TextBox3.Text <> String.Empty Then
            Clipboard.SetText(TextBox3.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Label2.Text = "Đã copy thời gian thí sinh 4 !"
        If TextBox4.Text <> String.Empty Then
            Clipboard.SetText(TextBox4.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub ChuôngTùyChỉnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChuôngTùyChỉnhToolStripMenuItem.Click
        troll()
    End Sub

    Private Sub ĐểChuôngMặcĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐểChuôngMặcĐịnhToolStripMenuItem.Click
        tatchuong = 1
        Me.Text = "[CPOMAIN PRO 7.0]-ALRec-CHUÔNG ĐÃ TẮT"
    End Sub

    Private Sub MởChuôngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MởChuôngToolStripMenuItem.Click
        tatchuong = 0
        Me.Text = "[CPOMAIN PRO 7.0]-ALRec-CHUÔNG ĐÃ MỞ"
    End Sub
End Class
