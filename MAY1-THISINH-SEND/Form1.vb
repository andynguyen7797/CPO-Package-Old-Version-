Option Explicit On
Imports System.IO
Imports System.Net.Sockets


Public Class Form1
    Dim Message As String
    Dim nStart As Integer
    Dim nLast As Integer
    Dim goigio As String
    Dim Client As TcpClient
    Dim giotangtoc As TcpListener
    Dim Clientgiotangtoc As TcpClient
    Dim giovcnv As TcpListener
    Dim Cliengiovcnv As TcpClient
    Dim stpw As Stopwatch = Stopwatch.StartNew
    Dim seconds As String
    Dim milis As String
    Dim ktragui As String
    Dim mode As Integer




    Public Sub ketnoi(cong As Integer, noidung As String)
        Try
            Client = New TcpClient(TextBox2.Text, cong)
            Dim Writer As New StreamWriter(Client.GetStream())
            Writer.Write("</> " & noidung & " <\>")
            Writer.Flush()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnClick() Handles Button1.Click
        ktragui = "1"
        TextBox4.Text = TextBox1.Text
        TextBox2.Enabled = False
        Labelnhangio.Text = (seconds & "." & milis)
        goigio = Labelnhangio.Text
        If mode = 1 Then
            ketnoi(8001, TextBox1.Text)
            ketnoi(7011, goigio)
            ketnoi(2301, goigio)
            ketnoi(7991, TextBox1.Text)
        End If
        If mode = 2 Then
            ketnoi(8002, TextBox1.Text)
            ketnoi(7012, goigio)
            ketnoi(2302, goigio)
            ketnoi(7992, TextBox1.Text)
        End If
        If mode = 3 Then
            ketnoi(8003, TextBox1.Text)
            ketnoi(7013, goigio)
            ketnoi(2303, goigio)
            ketnoi(7993, TextBox1.Text)
        End If
        If mode = 4 Then
            ketnoi(8004, TextBox1.Text)
            ketnoi(7014, goigio)
            ketnoi(2304, goigio)
            ketnoi(7994, TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ktragui = "1"
            TextBox4.Text = TextBox1.Text
            TextBox2.Enabled = False
            Labelnhangio.Text = (seconds & "." & milis)
            goigio = Labelnhangio.Text
            If mode = 1 Then
                ketnoi(8001, TextBox1.Text)
                ketnoi(7011, goigio)
                ketnoi(2301, goigio)
                ketnoi(7991, TextBox1.Text)
            End If
            If mode = 2 Then
                ketnoi(8002, TextBox1.Text)
                ketnoi(7012, goigio)
                ketnoi(2302, goigio)
                ketnoi(7992, TextBox1.Text)
            End If
            If mode = 3 Then
                ketnoi(8003, TextBox1.Text)
                ketnoi(7013, goigio)
                ketnoi(2303, goigio)
                ketnoi(7993, TextBox1.Text)
            End If
            If mode = 4 Then
                ketnoi(8004, TextBox1.Text)
                ketnoi(7014, goigio)
                ketnoi(2304, goigio)
                ketnoi(7994, TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If it1.Enabled = True Then
            MsgBox("CHƯA CHỌN MÁY LÀM SAO MÀ CHẠY ?, CHỌN LẠI !")
        Else

            If (TextBox5.Text = "cponh16") And (CheckBox2.Checked = True) And (TextBox2.Text <> "") Then
            Timerlogin.Stop()
            Panel4.Show()
            Panel5.Hide()
            MsgBox("ĐĂNG NHẬP THÀNH CÔNG !")
            If mode = 1 Then
                ketnoi(7001, TextBox3.Text)
            End If
            If mode = 2 Then
                ketnoi(7002, TextBox3.Text)
            End If
            If mode = 3 Then
                ketnoi(7003, TextBox3.Text)
            End If
            If mode = 4 Then
                ketnoi(7004, TextBox3.Text)
            End If
            Me.Text = "[CPONH]-" + TextBox3.Text()
        Else
            If (CheckBox2.Checked = False) Then
                MsgBox("THIẾU TÊN THÍ SINH !")
            Else

                If (TextBox2.Text = "") Then
                    MsgBox("THIẾU CẤU HÌNH IP !")


                End If
            End If


        End If


        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub _Load() Handles MyBase.Load
        Panel4.Hide()
        ktragui = "2"
        Timerlogin.Start()
        stpw.Reset()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Labelgio.Text = "0.0") Then
            If Message = 1 Then
                Label5.Font = New Font(Label5.Font, FontStyle.Regular)
                Label5.ForeColor = Color.Black()
                Label5.Text = "Vòng thi tăng tốc"
            Else
                Label5.Font = New Font(Label5.Font, FontStyle.Regular)
                Label5.ForeColor = Color.Black()
                Label5.Text = "Vòng thi vượt chướng ngại vật"
            End If
        End If

        If Labelgio.Text = "0.0" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

        If giotangtoc.Pending = True Then
            Message = ""
            Clientgiotangtoc = giotangtoc.AcceptTcpClient()
            Dim Reader As New StreamReader(Clientgiotangtoc.GetStream())

            While Reader.Peek > -1
                Message &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            If Message = 1 Then
                TextBox1.Text = ""
                ktragui = "0"
                stpw.Start()
                timerthoigian.Start()
                Label5.Text = "Vòng thi tăng tốc"
            End If

        End If
        '-------------------------------------
        If giovcnv.Pending = True Then

            Message = ""
            Cliengiovcnv = giovcnv.AcceptTcpClient()
            Dim Reader2 As New StreamReader(Cliengiovcnv.GetStream())

            While Reader2.Peek > -1
                Message &= Convert.ToChar(Reader2.Read()).ToString
            End While

            If Message.Contains("</>") Then
                nStart = InStr(Message, "</>") + 4
                nLast = InStr(Message, "<\>")
                Message = Mid(Message, nStart, nLast - nStart)
            End If
            If Message = 2 Then

                TextBox1.Text = ""
                ktragui = "0"
                stpw.Start()
                timerthoigian.Start()
                Label5.Text = "Vòng thi vượt chướng ngại vật"
            End If

        End If
    End Sub

    Private Sub timerthoigian_Tick(sender As Object, e As EventArgs) Handles timerthoigian.Tick

        seconds = stpw.Elapsed.Seconds.ToString()
        milis = stpw.Elapsed.Milliseconds.ToString()
        If Message = 1 Then
            If seconds = 30 Then
                stpw.Stop()
                stpw.Reset()

            End If
            '    If (seconds > 20) Then
            '        If (ktragui = 1) Then
            '            Label5.ForeColor = Color.Black()
            '            Label5.Font = New Font(Label5.Font, FontStyle.Regular)
            '            Label5.Text = "Vòng thi tăng tốc"
            '        Else
            '            Label5.ForeColor = Color.Red()
            '            Label5.Font = New Font(Label5.Font, FontStyle.Bold)
            '            Label5.Text = "Cố lên bạn ơi !!!"
            '        End If
            '    End If
        Else
            If seconds = 15 Then
                stpw.Stop()
                stpw.Reset()

                '    End If
                '    If (seconds > 9) Then
                '        If (ktragui = 1) Then
                '            Label5.ForeColor = Color.Black()
                '            Label5.Font = New Font(Label5.Font, FontStyle.Regular)
                '            Label5.Text = "Vòng thi vượt chướng ngại vật"
                '        Else
                '            Label5.ForeColor = Color.Red()
                '            Label5.Font = New Font(Label5.Font, FontStyle.Bold)
                '            Label5.Text = "Cố lên bạn ơi !!!"
                '        End If
            End If
        End If

        Labelgio.Text = seconds + "." + milis

    End Sub

    Private Sub Timerdem_Tick(sender As Object, e As EventArgs) Handles Timerdem.Tick


    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        MsgBox("pnnguyenA4withlove")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5.Hide()
        Button4.Hide()
        Me.Size = New Size(309, 395)
    End Sub

    Private Sub Timerlogin_Tick(sender As Object, e As EventArgs) Handles Timerlogin.Tick
        If TextBox3.Text = "" Then
            CheckBox2.Checked = False
        Else
            CheckBox2.Checked = True
        End If
        If TextBox5.Text = "cponh16" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Panel6.Show()
        If mode = 1 Then
            ketnoi(2301, Labelgio.Text)
        End If
        If mode = 2 Then
            ketnoi(2302, Labelgio.Text)
        End If
        If mode = 3 Then
            ketnoi(2303, Labelgio.Text)
        End If
        If mode = 4 Then
            ketnoi(2304, Labelgio.Text)
        End If
    End Sub






    Private Sub btnClick(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        'If (TextBox5.Text = "cponh15") And (CheckBox2.Checked = True) And (TextBox2.Text <> "") Then
        '    Timerlogin.Stop()
        '    Panel4.Hide()
        '    Panel5.Show()
        '    MsgBox("ĐĂNG NHẬP THÀNH CÔNG !")
        '    ketnoi(7001, TextBox3.Text)
        '    Me.Text = "[CPONH]-" + TextBox3.Text()
        'Else
        '    If (CheckBox2.Checked = False) Then
        '        MsgBox("THIẾU TÊN THÍ SINH !")
        '    Else

        '        If (TextBox2.Text = "") Then
        '            MsgBox("THIẾU CẤU HÌNH IP !")


        '        End If
        '    End If


        'End If

    End Sub

    Private Sub MÁY1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MÁY1ToolStripMenuItem.Click, Máy1ToolStripMenuItem1.Click
        MessageBox.Show("Máy này đã là máy 1, để thay đổi thiết lập - vui lòng khởi động lại toàn bộ gói phần mềm CPOMAIN 7", "Thiết lập thành công !")
        Me.Text = "Máy 1"
        mode = 1
        it1.Enabled = False
        'Dim giotangtoc As New TcpListener(8051)
        'Dim giovcnv As New TcpListener(5051)
        giotangtoc = New TcpListener(8051)
        giovcnv = New TcpListener(5051)
        giotangtoc.Start()
        giovcnv.Start()
        Timer1.Start()
        Timer2.Start()
        Timerdem.Start()
        stpw.Stop()
        stpw.Reset()
    End Sub

    Private Sub MÁY2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MÁY2ToolStripMenuItem.Click, Máy1ToolStripMenuItem2.Click
        MessageBox.Show("Máy này đã là máy 2, để thay đổi thiết lập - vui lòng khởi động lại toàn bộ gói phần mềm CPOMAIN 7", "Thiết lập thành công !")
        Me.Text = "Máy 2"
        mode = 2
        it1.Enabled = False
        giotangtoc = New TcpListener(8052)
        giovcnv = New TcpListener(5052)
        giotangtoc.Start()
        giovcnv.Start()
        Timer1.Start()
        Timer2.Start()
        Timerdem.Start()
        stpw.Stop()
        stpw.Reset()
    End Sub

    Private Sub MÁY3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MÁY3ToolStripMenuItem.Click, Máy1ToolStripMenuItem3.Click
        MessageBox.Show("Máy này đã là máy 3, để thay đổi thiết lập - vui lòng khởi động lại toàn bộ gói phần mềm CPOMAIN 7", "Thiết lập thành công !")
        Me.Text = "Máy 3"
        mode = 3
        it1.Enabled = False
        giotangtoc = New TcpListener(8053)
        giovcnv = New TcpListener(5053)
        giotangtoc.Start()
        giovcnv.Start()
        Timer1.Start()
        Timer2.Start()
        Timerdem.Start()
        stpw.Stop()
        stpw.Reset()
    End Sub

    Private Sub MÁY4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MÁY4ToolStripMenuItem.Click, Máy1ToolStripMenuItem4.Click
        MessageBox.Show("Máy này đã là máy 4, để thay đổi thiết lập - vui lòng khởi động lại toàn bộ gói phần mềm CPOMAIN 7", "Thiết lập thành công !")
        Me.Text = "Máy 4"
        mode = 4
        it1.Enabled = False
        giotangtoc = New TcpListener(8054)
        giovcnv = New TcpListener(5054)
        giotangtoc.Start()
        giovcnv.Start()
        Timer1.Start()
        Timer2.Start()
        Timerdem.Start()
        stpw.Stop()
        stpw.Reset()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        stpw.Stop()
        stpw.Reset()
    End Sub
End Class