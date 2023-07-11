Public Class Anasayfa
	Sub Alert_Goster(ByVal Controller As Form, ByVal Txt As String)
		Dim MesajAlert As New MesajAlertUser
		MesajAlert.Set_Setting(Controller, Alert_Time_Out_Text.Value, Txt, Animasyon_Modu_Check.Checked)
		Controller.Controls.Add(MesajAlert)
		MesajAlert.BringToFront() ' Bunu Kontrol'ün içinde çağıramazdık. çünkü işlemiyor. Kulağı mecbur ters tuttuk. çünkü formun üstünde yıkıp yıkıp edebilirdi.

	End Sub

	Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Private Sub Uygula_Buton_Click(sender As Object, e As EventArgs) Handles Uygula_Buton.Click
		Alert_Goster(Me, Yazi_Text.Text)
	End Sub

End Class
