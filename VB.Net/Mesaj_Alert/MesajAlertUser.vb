Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms


Public Class MesajAlertUser
    Dim Alert_CloseTimeOut As Integer
    Dim AlertForm_ As Form
    Dim TimerSay As Integer
    Dim YukariAnimasyonAktif As Boolean
    Dim FormHareketHalinde As Boolean
    Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        Me.Visible = False ' Bunu Yazdiğimizda Load Çalışmıyor. Yüzden Harici Fonksiyon Yazdık

    End Sub
    Public Sub Set_Setting(AlertForm As Form, AlertCloseTimeOut As Integer, MessageText As String, YukariAnimasyonYap As Boolean)
        YukariAnimasyonAktif = YukariAnimasyonYap
        Alert_CloseTimeOut = AlertCloseTimeOut
        Alert_Label.Text = MessageText
        AlertForm_ = AlertForm


        If YukariAnimasyonAktif = True Then
            Dim UserAlert As MesajAlertUser = CType(AlertForm_.Controls.OfType(Of UserControl)().FirstOrDefault(Function(UserControl) UserControl.Name = "MesajAlertUser"), MesajAlertUser)
            If UserAlert IsNot Nothing Then
                UserAlert.Animasyon_Timer.Stop()
                AlertForm_.Controls.Remove(UserAlert)
            End If
        End If


        AddHandler AlertForm.SizeChanged, AddressOf Size_Ayarla
        Size_Ayarla(Nothing, Nothing)
        Me.Visible = True

    End Sub


    Sub Size_Ayarla(sender As Object, e As EventArgs)
        Dim Yukseklik As Integer = Me.Height
        If YukariAnimasyonAktif = False Then Yukseklik = 0

        Me.Width = AlertForm_.Width
        Me.Location = New Point(AlertForm_.ClientRectangle.Location.X, (AlertForm_.ClientRectangle.Location.Y + AlertForm_.ClientRectangle.Height) - (Me.Height - Yukseklik))
    End Sub

    Private Sub Animasyon_Timer_Tick(sender As Object, e As EventArgs) Handles Animasyon_Timer.Tick
        TimerSay += 1
        FormHareketHalinde = True

        If YukariAnimasyonAktif = True Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)

            If TimerSay >= 58 Then
                TimerSay = 0
                Animasyon_Timer.Stop()
                Animasyon_Timer.Interval = Alert_CloseTimeOut
                Animasyon_Timer.Start()
                YukariAnimasyonAktif = False
                FormHareketHalinde = False
            End If
        Else
            Animasyon_Timer.Interval = 1
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
            If TimerSay >= 60 Then
                FormHareketHalinde = False
                Animasyon_Timer.Stop()
                Me.Visible = False
                AlertForm_.Controls.Remove(Me)
                Me.Dispose()
            End If
        End If





    End Sub

    Private Sub MesajAlertUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Animasyon_Timer.Interval = 1 ' Load a koyduk. kontroller eklendiğinde aktif olsun diye.
        If YukariAnimasyonAktif = False Then
            Animasyon_Timer.Interval = Alert_CloseTimeOut
        End If
        Animasyon_Timer.Enabled = True

    End Sub

    Private Sub Alert_Label_Click(sender As Object, e As EventArgs) Handles Alert_Label.Click

    End Sub
End Class
