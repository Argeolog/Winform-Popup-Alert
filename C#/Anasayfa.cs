using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesaj_Alert
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        public void Alert_Goster(Form Controller, string Txt, bool AlertKapanmasiniBekle )
        {
            MesajAlertUser MesajAlert = new MesajAlertUser();
            MesajAlert.Set_Setting(Controller, Convert.ToInt32( Alert_Time_Out_Text.Value), Txt , Animasyon_Modu_Check.Checked);
            Controller.Controls.Add(MesajAlert);
            MesajAlert.BringToFront(); // Bunu Kontrol'ün içinde çağıramazdık. çünkü işlemiyor. Kulağı mecbur ters tuttuk. çünkü formun üstünde yıkıp yıkıp edebilirdi.

            while ((MesajAlert.AlertAcik && AlertKapanmasiniBekle))
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
            
        }

        private void Uygula_Buton_Click(object sender, EventArgs e)
        {
            Alert_Goster(this, Yazi_Text.Text, Alert_Kapanmasini_Bekle_Check.Checked);
            // Alert Kapandıktan sonra kod bir alt satıra geçsin isteniliyorsa, Alert Kapanmasını Bekle,true olmalıdır.
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
