<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anasayfa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Animasyon_Modu_Check = New System.Windows.Forms.CheckBox()
        Me.Yazi_Text = New System.Windows.Forms.TextBox()
        Me.Alert_Time_Out_Text = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Uygula_Buton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Alert_Kapanmasini_Bekle_Check = New System.Windows.Forms.CheckBox()
        CType(Me.Alert_Time_Out_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Animasyon_Modu_Check
        '
        Me.Animasyon_Modu_Check.AutoSize = True
        Me.Animasyon_Modu_Check.Checked = True
        Me.Animasyon_Modu_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Animasyon_Modu_Check.Location = New System.Drawing.Point(261, 18)
        Me.Animasyon_Modu_Check.Name = "Animasyon_Modu_Check"
        Me.Animasyon_Modu_Check.Size = New System.Drawing.Size(187, 17)
        Me.Animasyon_Modu_Check.TabIndex = 0
        Me.Animasyon_Modu_Check.Text = "İniş ve Kalkışta Animasyon Uygula"
        Me.Animasyon_Modu_Check.UseVisualStyleBackColor = True
        '
        'Yazi_Text
        '
        Me.Yazi_Text.Location = New System.Drawing.Point(99, 44)
        Me.Yazi_Text.Name = "Yazi_Text"
        Me.Yazi_Text.Size = New System.Drawing.Size(156, 20)
        Me.Yazi_Text.TabIndex = 1
        Me.Yazi_Text.Text = "Kayıt İşlemi Başarılı"
        '
        'Alert_Time_Out_Text
        '
        Me.Alert_Time_Out_Text.Location = New System.Drawing.Point(99, 18)
        Me.Alert_Time_Out_Text.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Alert_Time_Out_Text.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Alert_Time_Out_Text.Name = "Alert_Time_Out_Text"
        Me.Alert_Time_Out_Text.Size = New System.Drawing.Size(156, 20)
        Me.Alert_Time_Out_Text.TabIndex = 2
        Me.Alert_Time_Out_Text.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gösterim Süresi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Yazı"
        '
        'Uygula_Buton
        '
        Me.Uygula_Buton.Location = New System.Drawing.Point(12, 80)
        Me.Uygula_Buton.Name = "Uygula_Buton"
        Me.Uygula_Buton.Size = New System.Drawing.Size(243, 23)
        Me.Uygula_Buton.TabIndex = 5
        Me.Uygula_Buton.Text = "Uygula"
        Me.Uygula_Buton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(627, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Powered By Argeolog"
        '
        'Alert_Kapanmasini_Bekle_Check
        '
        Me.Alert_Kapanmasini_Bekle_Check.AutoSize = True
        Me.Alert_Kapanmasini_Bekle_Check.Checked = True
        Me.Alert_Kapanmasini_Bekle_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Alert_Kapanmasini_Bekle_Check.Location = New System.Drawing.Point(261, 41)
        Me.Alert_Kapanmasini_Bekle_Check.Name = "Alert_Kapanmasini_Bekle_Check"
        Me.Alert_Kapanmasini_Bekle_Check.Size = New System.Drawing.Size(163, 17)
        Me.Alert_Kapanmasini_Bekle_Check.TabIndex = 7
        Me.Alert_Kapanmasini_Bekle_Check.Text = "Alert Kapanana  Kadar Bekle"
        Me.Alert_Kapanmasini_Bekle_Check.UseVisualStyleBackColor = True
        '
        'Anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Alert_Kapanmasini_Bekle_Check)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Uygula_Buton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Alert_Time_Out_Text)
        Me.Controls.Add(Me.Yazi_Text)
        Me.Controls.Add(Me.Animasyon_Modu_Check)
        Me.Name = "Anasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anasayfa"
        CType(Me.Alert_Time_Out_Text, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Animasyon_Modu_Check As CheckBox
    Friend WithEvents Yazi_Text As TextBox
    Friend WithEvents Alert_Time_Out_Text As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Uygula_Buton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Alert_Kapanmasini_Bekle_Check As CheckBox
End Class
