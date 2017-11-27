Option Explicit On
Imports System.IO
Imports System.Net.Sockets

Public Class Form1
    Dim cautraloi1 As New TcpListener(8001)
    Dim Client1 As TcpClient
    Dim tenthisinh1 As New TcpListener(7001)
    Dim Clientts1 As TcpClient
    Dim cautraloi2 As New TcpListener(8002)
    Dim Client2 As TcpClient
    Dim tenthisinh2 As New TcpListener(7002)
    Dim Clientts2 As TcpClient
    Dim cautraloi3 As New TcpListener(8003)
    Dim Client3 As TcpClient
    Dim tenthisinh3 As New TcpListener(7003)
    Dim Clientts3 As TcpClient
    Dim cautraloi4 As New TcpListener(8004)
    Dim Client4 As TcpClient
    Dim tenthisinh4 As New TcpListener(7004)
    Dim Clientts4 As TcpClient

    Private Sub _FormClosing() Handles Me.FormClosing
        cautraloi1.Stop()
        cautraloi2.Stop()
        cautraloi3.Stop()
        cautraloi4.Stop()
    End Sub

    Private Sub _Load() Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timerts1.Start()
        Timerts2.Start()
        Timerts3.Start()
        Timerts4.Start()
        cautraloi1.Start()
        cautraloi2.Start()
        cautraloi3.Start()
        cautraloi4.Start()
        tenthisinh1.Start()
        tenthisinh2.Start()
        tenthisinh3.Start()
        tenthisinh4.Start()
    End Sub

    Private Sub _Tick() Handles Timer1.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If cautraloi1.Pending = True Then
            Message = ""
            Client1 = cautraloi1.AcceptTcpClient()
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
            THOIGIAN1.Text = "[" + My.Computer.Clock.LocalTime.TimeOfDay.ToString() + "]"
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If cautraloi2.Pending = True Then
            Message = ""
            Client2 = cautraloi2.AcceptTcpClient()
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
            THOIGIAN2.Text = "[" + My.Computer.Clock.LocalTime.TimeOfDay.ToString() + "]"
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If cautraloi3.Pending = True Then
            Message = ""
            Client3 = cautraloi3.AcceptTcpClient()
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
            THOIGIAN3.Text = "[" + My.Computer.Clock.LocalTime.TimeOfDay.ToString() + "]"
        End If
    End Sub

    
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If cautraloi4.Pending = True Then
            Message = ""
            Client4 = cautraloi4.AcceptTcpClient()
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
            THOIGIAN4.Text = "[" + My.Computer.Clock.LocalTime.TimeOfDay.ToString() + "]"
        End If
    End Sub

    Private Sub Timerts1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts1.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If tenthisinh1.Pending = True Then
            Message = ""
            Clientts1 = tenthisinh1.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts1.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            Labelts1.Text = Message
        End If
    End Sub
    Private Sub Timerts2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts2.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If tenthisinh2.Pending = True Then
            Message = ""
            Clientts2 = tenthisinh2.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts2.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            Labelts2.Text = Message
        End If
    End Sub
    Private Sub Timerts3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts3.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If tenthisinh3.Pending = True Then
            Message = ""
            Clientts3 = tenthisinh3.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts3.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            Labelts3.Text = Message
        End If
    End Sub
    Private Sub Timerts4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts4.Tick
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer

        If tenthisinh4.Pending = True Then
            Message = ""
            Clientts4 = tenthisinh4.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientts4.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            Labelts4.Text = Message
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
