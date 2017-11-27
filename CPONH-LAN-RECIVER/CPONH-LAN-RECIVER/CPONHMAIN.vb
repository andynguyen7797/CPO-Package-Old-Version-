Imports System.IO
Public Class CPONHMAIN
    Dim antitheft As Integer = 5
    Dim newpoint As System.Drawing.Point
    Dim GBCount As Integer = 0
    Dim GBCount1 As Integer = 0
    Dim x, y As Integer
    Public CS_DROPSHADOW As Int32 = &H20000

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams

        Get

            Dim parameters As CreateParams = MyBase.CreateParams

            parameters.ClassStyle += CS_DROPSHADOW

            Return parameters

        End Get

    End Property
    Public Sub SaveFromResources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub
    Private Sub CPONHMAIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.anhnen = TextBox2.Text
      
    End Sub
    Private Sub CPONHMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load





       
      

      
            Panel9.Visible = False
            Panel10.Visible = False
            If My.Settings.boldtieude = "true" Then
                tittlecheck.Checked = True
            Else
                tittlecheck.Checked = False
            End If
            If My.Settings.boldnoidung = "true" Then
                maincheck.Checked = True
            Else
                maincheck.Checked = False
            End If
            'If My.Settings.anti = "1" Then
            '    Panel8.BringToFront()
            'Else
            '    Panel8.SendToBack()

            'End If
            Button22.Text = "Còn lại " + antitheft.ToString + " lần nhập mật khẩu !"
            If File.Exists("DATA\help.docx") Then
            Else
                Directory.CreateDirectory("DATA")
                SaveFromResources("DATA\help.docx", My.Resources.HELP)
            End If
            Label1.Text = "CPOMAIN PRO " + My.Application.Info.Version.ToString()
            TextBox2.Text = My.Settings.anhnen
            Button3.BackgroundImage = My.Resources.ic_format_indent_increase_white_24dp_1x
            Timersave.Start()
            Panel3.Location = New Point(6, 29)
            TBX1.Text = My.Settings.chieungang
            TBX2.Text = My.Settings.chieudoc
            TextBoxipv4TS1.Text = My.Settings.ip1
            TextBoxipv4TS2.Text = My.Settings.ip2
            TextBoxipv4TS3.Text = My.Settings.ip3
            TextBoxipv4TS4.Text = My.Settings.ip4
    End Sub

    Private Sub CPONHMAIN_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub CPONHMAIN_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        confirmexit.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If GBCount = 0 Then
            Button3.BackgroundImage = My.Resources.ic_format_indent_increase_white_24dp_1x
            Label189.Text = "TỔNG QUAN"
            Panel3.Location = New Point(6, 29)
        ElseIf GBCount = 1 Then
            'THÊM
            Label189.Text = "THIẾT LẬP"
            Panel3.Location = New Point(300, 29)
            Button3.BackgroundImage = My.Resources.ic_format_indent_decrease_white_24dp_1x
        End If
        GBCount = GBCount + 1
        If GBCount = 2 Then GBCount = 0
        'If GBCount = 0 Then
        '    Button3.BackgroundImage = My.Resources.ic_format_indent_increase_white_24dp_1x
        '    Label189.Text = "TỔNG QUAN"
        '    Panel3.Location = New Point(6, 29)
        '    Timer1.Stop()
        '    Timer2.Start()
        'ElseIf GBCount = 1 Then
        '    'THÊM
        '    Timer1.Start()
        '    Timer2.Stop()
        '    Label189.Text = "THIẾT LẬP"
        '    Panel3.Location = New Point(220, 29)
        '    Button3.BackgroundImage = My.Resources.ic_format_indent_decrease_white_24dp_1x
        'End If
        'GBCount = GBCount + 1
        'If GBCount = 2 Then GBCount = 0
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel10.Visible = True
        Label17.Text = "       REC MODE      "
        Panel9.Visible = True
        Form1.Show()
        Button20.Text = "MÁY REC"

        If Button6.Text = "4S1R" Then
            MsgBox("[4S1R REC] Đã đang chạy !")
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(15)
        Panel3.Location = New Point(ProgressBar1.Value, 29)
        If ProgressBar1.Value = 220 Then Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(-15)
        Panel3.Location = New Point(ProgressBar1.Value, 29)
        If ProgressBar1.Value = 6 Then Timer2.Stop()
    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text = "" Then
            Button22.Text = "Vui lòng điền mật khẩu !"
        Else
            If TextBox1.Text = "cponh16" Then
                Panel7.Hide()
            Else
                TextBox1.Text = ""
                antitheft = antitheft - 1
                Button22.Text = "Còn lại " + antitheft.ToString + " lần nhập mật khẩu !"
                If antitheft = 0 Then
                    My.Settings.anti = 1
                    Panel8.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub Timersave_Tick(sender As Object, e As EventArgs) Handles Timersave.Tick
        If tittlecheck.Checked = True Then
            My.Settings.boldtieude = "true"
        Else
            My.Settings.boldtieude = "asdasd"
        End If
        If maincheck.Checked = True Then
            My.Settings.boldnoidung = "true"
        Else
            My.Settings.boldnoidung = "werwer"
        End If

        Button4.FlatAppearance.BorderColor = My.Settings.mautieudemnt
        Button8.FlatAppearance.BorderColor = My.Settings.maunoidungmnt
        Button24.FlatAppearance.BorderColor = My.Settings.mautexttieude
        Button25.FlatAppearance.BorderColor = My.Settings.mautextnoidung
        My.Settings.chieungang = TBX1.Text
        My.Settings.chieudoc = TBX2.Text
        'If CheckBox1.Checked Then
        '    My.Settings.thunho = "true"
        '    TBX1.Text = "185"
        '    TBX2.Text = "70"
        '    TBX1.Enabled = False
        '    TBX2.Enabled = False
        'Else
        '    My.Settings.thunho = "false"
        '    TBX1.Enabled = True
        '    TBX2.Enabled = True
        'End If
        'If CheckBox2.Checked Then
        '    My.Settings.phongto = "true"
        'Else
        '    My.Settings.phongto = "false"
        'End If
        'If My.Settings.thunho = "true" Then
        '    CheckBox2.Checked = False
        'End If
        'If My.Settings.phongto = "true" Then
        '    CheckBox1.Checked = False
        'End If
        '--------------------------------------------IP SAVE----------------------------------'
        My.Settings.ip1 = TextBoxipv4TS1.Text
        My.Settings.ip2 = TextBoxipv4TS2.Text
        My.Settings.ip3 = TextBoxipv4TS3.Text
        My.Settings.ip4 = TextBoxipv4TS4.Text
        '---------------------------------------------BACKROUND SAVE---------------------------'
        My.Settings.anhnen = TextBox2.Text
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Form1.Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint, Panel9.Paint

    End Sub

  
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MNT1.Show()
        Button20.Text = "MÁY ĐIỀU KHIỂN MNT"
    End Sub


    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If TextBox3.Text = "HỌ TÊN" Then
            TextBox3.Text = ""
        End If
    End Sub

  

    

   

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        layed.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("ĐÃ HOÀN THIỆN VÀO THÁNG 1 NĂM 2016", "(c) NGUYỄN VĂN PHÚ NHÀN")
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs)
        MNT2.Show()
        Button20.Text = "MÁY ĐIỀU KHIỂN MNT 2"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        MNT3.Show()
        Button20.Text = "MÁY ĐIỀU KHIỂN MNT 3"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        MNT4.Show()
        Button20.Text = "MÁY ĐIỀU KHIỂN MNT 4"
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Label189.Text = "MÀU NỀN TIÊU ĐỀ MNT"

    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Label189.Text = "MÀU NỀN ĐÁP ÁN MNT"

    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Label189.Text = "TỔNG QUAN"

    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Label189.Text = "TỔNG QUAN"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.mautieudemnt = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ColorDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.maunoidungmnt = ColorDialog2.Color
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel7.Show()
        TextBox1.Text = ""
        TextBox1.Focus()
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
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If File.Exists("DATA\help.docx") Then
            Process.Start("DATA\help.docx")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MessageBox.Show("Đã đưa tất cả về mặc định !", "CPOMAIN")
        My.Settings.maunoidungmnt = Color.Crimson
        My.Settings.mautieudemnt = Color.Crimson
        My.Settings.mautextnoidung = Color.Black
        My.Settings.mautexttieude = Color.Black
        TBX1.Text = "1354"
        TBX2.Text = "721"
        TextBox2.Text = "mặc định"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox7.Text = "pnpro2951" Then
            Panel8.SendToBack()
            MsgBox("Welcome Developer ! :D")
            antitheft = 5
            Button22.Text = "Còn lại 5 lần nhập mật khẩu !"
            TextBox7.Text = ""
            My.Settings.ktrabq = 0
        Else
            TextBox7.Text = ""
        End If
    End Sub

    Private Sub Button24_MouseHover(sender As Object, e As EventArgs) Handles Button24.MouseHover
        Label189.Text = "MÀU TIÊU ĐỀ"

    End Sub

    Private Sub Button24_MouseLeave(sender As Object, e As EventArgs) Handles Button24.MouseLeave
        Label189.Text = "TỔNG QUAN"

    End Sub

    Private Sub Button25_MouseHover(sender As Object, e As EventArgs) Handles Button25.MouseHover
        Label189.Text = "MÀU ĐÁP ÁN"

    End Sub

    Private Sub Button25_MouseLeave(sender As Object, e As EventArgs) Handles Button25.MouseLeave
        Label189.Text = "TỔNG QUAN"

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If ColorDialog3.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.mautexttieude = ColorDialog3.Color
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If ColorDialog4.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.mautextnoidung = ColorDialog4.Color
        End If
    End Sub


    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Label189.Text = "THOÁT KHỎI CHƯƠNG TRÌNH"
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Label189.Text = "TỔNG QUAN"
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Label189.Text = "THU NHỎ"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Label189.Text = "TỔNG QUAN"
    End Sub

    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        Label189.Text = "MỞ TỆP TRỢ GIÚP"
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Label189.Text = "TỔNG QUAN"
    End Sub

   
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If TextBox16.Text = "cponh15" Then
            Panel10.Visible = False
            Form1.Label1.Show()
        Else
            TextBox16.Text = ""
            TextBox16.Focus()
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel10.Visible = True
        TextBox16.Text = ""
        TextBox16.Focus()
        Form1.Label1.Hide()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Form1.THOIGIAN1.Text = txttimeedit1.Text
        Form1.TextBox1.Text = txtdapan1.Text
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Form1.THOIGIAN2.Text = txttimeedit2.Text
        Form1.TextBox2.Text = txtdapan2.Text
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Form1.THOIGIAN3.Text = txttimeedit3.Text
        Form1.TextBox3.Text = txtdapan3.Text
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Form1.THOIGIAN4.Text = txttimeedit4.Text
        Form1.TextBox4.Text = txtdapan4.Text
    End Sub

    Private Sub TXTBXDIEM1_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTBXDIEM1.KeyDown
        If e.KeyCode = Keys.Enter Then
            MNT1.Button2.Text = TextBox3.Text
            MNT1.Button1.Text = TXTBXDIEM1.Text
            TextBox4.Focus()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MNT1.Button2.Text = TextBox3.Text
        MNT1.Button1.Text = TXTBXDIEM1.Text
    End Sub

    Private Sub TXTBXDIEM1_TextChanged(sender As Object, e As EventArgs) Handles TXTBXDIEM1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

   
    

    

  

    Private Sub Label15_MouseWheel(sender As Object, e As MouseEventArgs) Handles Label15.MouseWheel
        turn.Show()
    End Sub

  

    Private Sub Label20_MouseWheel(sender As Object, e As MouseEventArgs) Handles Label20.MouseWheel
        Form3.Show()
    End Sub

    Private Sub Label189_Click(sender As Object, e As EventArgs) Handles Label189.Click

    End Sub
End Class