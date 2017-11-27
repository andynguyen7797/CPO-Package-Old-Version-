Option Explicit On
Imports System.IO
Imports System.Net.Sockets

Public Class Form1

    '-----------------------GÁN BIẾN TỌA ĐỘ DI CHUYỂN WINFORM----------'
    Dim newpoint As System.Drawing.Point
    Dim x, y As Integer
    '-----------------------GÁN BIẾN THỜI GIAN, BỘ ĐẾM-----------------'
    '-----------------------GÁN BIẾN CHO HOẠT ĐỘNG SHOW/HIDE 1 LẦN-----'
    Dim GBCount As Integer = 0
    Dim GBCount1 As Integer = 0
    '------------------------------------------------------------------'

    Dim lapts1 As New TcpListener(7011)
    Dim Clientthoigian1 As TcpClient
    Dim lapts2 As New TcpListener(7012)
    Dim Clientthoigian2 As TcpClient
    Dim lapts3 As New TcpListener(7013)
    Dim Clientthoigian3 As TcpClient
    Dim lapts4 As New TcpListener(7014)
    Dim Clientthoigian4 As TcpClient
    '------------------------------------------------------------------'
    '--------------GÁN BIẾN CÂU TRẢ LỜI, TÊN THÍ SINH------------------'
    Dim Client As TcpClient
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
    '------------------------------------------------------------------'
    Dim statuscheck_1 As New TcpListener(4001)
    Dim Clientstatuscheck_1 As TcpClient
    Dim statuscheck_2 As New TcpListener(4002)
    Dim Clientstatuscheck_2 As TcpClient
    Dim statuscheck_3 As New TcpListener(4003)
    Dim Clientstatuscheck_3 As TcpClient
    Dim statuscheck_4 As New TcpListener(4004)
    Dim Clientstatuscheck_4 As TcpClient
    '-----------------GÁN BIẾN LIÊN QUAN ĐẾN ĐỒ HỌA--------------------'


    '------------------------------------------------------------------'





    Private Sub _FormClosing() Handles Me.FormClosing
        CPONHMAIN.Label17.Text = "MONITOR REMOTE"
        CPONHMAIN.Panel9.Visible = False

        My.Settings.ten1x = Me.Labelts1.Location.X
        My.Settings.ten1y = Me.Labelts1.Location.Y
        My.Settings.ten2x = Me.labelts2.Location.X
        My.Settings.ten2y = Me.labelts2.Location.Y
        My.Settings.ten3x = Me.Labelts3.Location.X
        My.Settings.ten3y = Me.Labelts3.Location.Y
        My.Settings.ten4x = Me.Labelts4.Location.X
        My.Settings.ten4y = Me.Labelts4.Location.Y
        My.Settings.time1x = Me.THOIGIAN1.Location.X
        My.Settings.time1y = Me.THOIGIAN1.Location.Y
        My.Settings.time2x = Me.THOIGIAN2.Location.X
        My.Settings.time2y = Me.THOIGIAN2.Location.Y
        My.Settings.time3x = Me.THOIGIAN3.Location.X
        My.Settings.time3y = Me.THOIGIAN3.Location.Y
        My.Settings.time4x = Me.THOIGIAN4.Location.X
        My.Settings.time4y = Me.THOIGIAN4.Location.Y
        My.Settings.dapan1x = Me.TextBox1.Location.X
        My.Settings.dapan1y = Me.TextBox1.Location.Y
        My.Settings.dapan2x = Me.TextBox2.Location.X
        My.Settings.dapan2y = Me.TextBox2.Location.Y
        My.Settings.dapan3x = Me.TextBox3.Location.X
        My.Settings.dapan3y = Me.TextBox3.Location.Y
        My.Settings.dapan4x = Me.TextBox4.Location.X
        My.Settings.dapan4y = Me.TextBox4.Location.Y
        My.Settings.anhnen = CPONHMAIN.TextBox2.Text
        CPONHMAIN.Button6.Text = "KHỞI ĐỘNG 4S1R"
        Timergiots1.Stop()
        Timergiots2.Stop()
        Timergiots3.Stop()
        Timergiots4.Stop()
        lapts1.Stop()
        lapts2.Stop()
        lapts3.Stop()
        lapts4.Stop()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timerts1.Stop()
        Timerts2.Stop()
        Timerts3.Stop()
        Timerts4.Stop()
        cautraloi1.Stop()
        cautraloi2.Stop()
        cautraloi3.Stop()
        cautraloi4.Stop()
        tenthisinh1.Stop()
        tenthisinh2.Stop()
        tenthisinh3.Stop()
        tenthisinh4.Stop()
        Timerstatus.Stop()
        statuscheck_1.Stop()
    End Sub

    Private Sub _Load() Handles MyBase.Load
        CPONHMAIN.Button6.Text = "4S1R"
        Label1.Hide()
        Timergiots1.Start()
        Timergiots2.Start()
        Timergiots3.Start()
        Timergiots4.Start()
        lapts1.Start()
        lapts2.Start()
        lapts3.Start()
        lapts4.Start()
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
        '---icon---
        '---
        Timerstatus.Start()
        statuscheck_1.Start()
        '---
        If My.Settings.chieungang > 1366 Then

        End If
        If My.Settings.thunho = "true" Then
            Button4.Location = New Point(15, -2)
            Panel4.Location = New Point(0, 18)
            Button3.Location = New Point(108, -1)
            Button2.Location = New Point(158, -1)
        Else

        End If
        Me.Size = New Size(My.Settings.chieungang, My.Settings.chieudoc)

        If System.IO.File.Exists(CPONHMAIN.TextBox2.Text) = True Then
            panel1.BackgroundImage = System.Drawing.Image.FromFile(CPONHMAIN.TextBox2.Text)
        Else
            MsgBox("Đường dẫn ảnh nền trong lần thiết lập trước đã thay đổi !, vui lòng chọn lại !")
            panel1.BackgroundImage = My.Resources.white
        End If

        Timersave.Start()
    End Sub

    Private Sub _Tick() Handles Timer1.Tick
        nhanthongtin(cautraloi1, Client1, TextBox1)
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        nhanthongtin(cautraloi2, Client2, TextBox2)
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        nhanthongtin(cautraloi3, Client3, TextBox3)
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        nhanthongtin(cautraloi4, Client4, TextBox4)
    End Sub

    Private Sub Timerts1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts1.Tick
        nhanthongtin(tenthisinh1, Clientts1, Labelts1)
        'Dim Message As String
        'Dim nStart As Integer
        'Dim nLast As Integer

        'If tenthisinh1.Pending = True Then
        '    My.Settings.ico1 = "ok"
        '    Message = ""
        '    Clientts1 = tenthisinh1.AcceptTcpClient()
        '    Dim Reader As New StreamReader(Clientts1.GetStream())

        '    While Reader.Peek > -1
        '        Message &= Convert.ToChar(Reader.Read()).ToString
        '    End While

        '    If Message.Contains("</>") Then
        '        nStart = InStr(Message, "</>") + 4
        '        nLast = InStr(Message, "<\>")
        '        Message = Mid(Message, nStart, nLast - nStart)
        '    End If
        '    Labelts1.Text = Message

        'End If
    End Sub
    Private Sub Timerts2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts2.Tick
        nhanthongtin(tenthisinh2, Clientts2, labelts2)
    End Sub
    Private Sub Timerts3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts3.Tick
        nhanthongtin(tenthisinh3, Clientts3, Labelts3)
    End Sub
    Private Sub Timerts4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerts4.Tick
        nhanthongtin(tenthisinh4, Clientts4, Labelts4)
    End Sub
    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub nhanthongtin(lapts As TcpListener, clientts As TcpClient, thoigian As Label)
        Dim Message As String
        Dim nStart As Integer
        Dim nLast As Integer
        If lapts.Pending = True Then
            Message = ""
            clientts = lapts.AcceptTcpClient()
            Dim Reader As New StreamReader(clientts.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While
            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            thoigian.Text = Message
        End If
    End Sub
    Private Sub Timergiots1_Tick(sender As Object, e As EventArgs) Handles Timergiots1.Tick
        nhanthongtin(lapts1, Clientthoigian1, THOIGIAN1)
    End Sub
    Private Sub Timergiots2_Tick(sender As Object, e As EventArgs) Handles Timergiots2.Tick
        nhanthongtin(lapts2, Clientthoigian2, THOIGIAN2)
    End Sub
    Private Sub Timergiots3_Tick(sender As Object, e As EventArgs) Handles Timergiots3.Tick
        nhanthongtin(lapts3, Clientthoigian3, THOIGIAN3)
    End Sub
    Private Sub Timergiots4_Tick(sender As Object, e As EventArgs) Handles Timergiots4.Tick
        nhanthongtin(lapts4, Clientthoigian4, THOIGIAN4)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        THOIGIAN1.Text = "00.000"
        THOIGIAN2.Text = "00.000"
        THOIGIAN3.Text = "00.000"
        THOIGIAN4.Text = "00.000"
        Timerprogress.Stop()

        '-----------------------------------------
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '---------------------------THU NHỎ KHI CLICK----------------------------'
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '-------------------------------------------------------------------------'
        Timerprogress.Start()
        If Label8.Text = "true" Then
            '---ĐÂY LÀ CHẾ ĐỘ VÒNG TĂNG TỐC
            '---máy 1
            Try
                Client = New TcpClient(My.Settings.ip1, 8051)
                Dim Writer1 As New StreamWriter(Client.GetStream())
                Writer1.Write("</> " & "1" & " <\>")
                Writer1.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 2
            Try
                Client = New TcpClient(My.Settings.ip2, 8052)
                Dim Writer2 As New StreamWriter(Client.GetStream())
                Writer2.Write("</> " & "1" & " <\>")
                Writer2.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 3
            Try
                Client = New TcpClient(My.Settings.ip3, 8053)
                Dim Writer3 As New StreamWriter(Client.GetStream())
                Writer3.Write("</> " & "1" & " <\>")
                Writer3.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 4
            Try
                Client = New TcpClient(My.Settings.ip4, 8054)
                Dim Writer4 As New StreamWriter(Client.GetStream())
                Writer4.Write("</> " & "1" & " <\>")
                Writer4.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else '------------------------------------------------------------------------------------------
            '---ĐÂY LÀ CHẾ ĐỘ VÒNG VƯỢT CHƯỚNG NGẠI VẬT
            '---máy 1
            Try
                Client = New TcpClient(My.Settings.ip1, 5051)
                Dim Writer11 As New StreamWriter(Client.GetStream())
                Writer11.Write("</> " & "2" & " <\>")
                Writer11.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 2
            Try
                Client = New TcpClient(My.Settings.ip2, 5052)
                Dim Writer22 As New StreamWriter(Client.GetStream())
                Writer22.Write("</> " & "2" & " <\>")
                Writer22.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 3
            Try
                Client = New TcpClient(My.Settings.ip3, 5053)
                Dim Writer33 As New StreamWriter(Client.GetStream())
                Writer33.Write("</> " & "2" & " <\>")
                Writer33.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---máy 4
            Try
                Client = New TcpClient(My.Settings.ip4, 5054)
                Dim Writer44 As New StreamWriter(Client.GetStream())
                Writer44.Write("</> " & "2" & " <\>")
                Writer44.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If GBCount = 0 Then
            'THU GỌN LẠI
            Panel4.Hide()
        ElseIf GBCount = 1 Then
            'THÊM
            Panel4.Show()
        End If
        GBCount = GBCount + 1
        If GBCount = 2 Then GBCount = 0
    End Sub

  

   

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.ForeColor = Color.Cyan
        Button7.ForeColor = Color.White
        Label8.Text = "true"
        THOIGIAN1.Show()
        THOIGIAN2.Show()
        THOIGIAN3.Show()
        THOIGIAN4.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.ForeColor = Color.Cyan
        Button6.ForeColor = Color.White
        Label8.Text = "false"
        THOIGIAN1.Hide()
        THOIGIAN2.Hide()
        THOIGIAN3.Hide()
        THOIGIAN4.Hide()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

 

  

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If GBCount1 = 0 Then
            Button4.Location = New Point(1182, -1)
            Panel4.Location = New Point(1169, 18)
            Me.Size = New Size(My.Settings.chieungang, My.Settings.chieudoc)
            Panel4.BackColor = Color.Indigo
            Button3.Location = New Point(1274, -1)
            Button2.Location = New Point(1321, -1)
        ElseIf GBCount1 = 1 Then
            Button4.Location = New Point(15, -2)
            Panel4.Location = New Point(0, 18)
            Me.Size = New Size(185, 70)
            Panel4.BackColor = Color.Indigo
            Button3.Location = New Point(108, -1)
            Button2.Location = New Point(158, -1)
        End If
        GBCount1 = GBCount1 + 1
        If GBCount1 = 2 Then GBCount1 = 0
    End Sub

    Private Sub Timersave_Tick(sender As Object, e As EventArgs) Handles Timersave.Tick
        Labelts1.Location = New Point(My.Settings.ten1x, My.Settings.ten1y)
        labelts2.Location = New Point(My.Settings.ten2x, My.Settings.ten2y)
        Labelts3.Location = New Point(My.Settings.ten3x, My.Settings.ten3y)
        Labelts4.Location = New Point(My.Settings.ten4x, My.Settings.ten4y)
        THOIGIAN1.Location = New Point(My.Settings.time1x, My.Settings.time1y)
        THOIGIAN2.Location = New Point(My.Settings.time2x, My.Settings.time2y)
        THOIGIAN3.Location = New Point(My.Settings.time3x, My.Settings.time3y)
        THOIGIAN4.Location = New Point(My.Settings.time4x, My.Settings.time4y)
        TextBox1.Location = New Point(My.Settings.dapan1x, My.Settings.dapan1y)
        TextBox2.Location = New Point(My.Settings.dapan2x, My.Settings.dapan2y)
        TextBox3.Location = New Point(My.Settings.dapan3x, My.Settings.dapan3y)
        TextBox4.Location = New Point(My.Settings.dapan4x, My.Settings.dapan4y)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub _Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
