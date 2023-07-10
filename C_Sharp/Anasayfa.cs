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


        public void Alert_Goster(Form Controller, string Txt)
        {
            MesajAlertUser MesajAlert = new MesajAlertUser();
            MesajAlert.Set_Setting(Controller, Convert.ToInt32( Alert_Time_Out_Text.Value), Txt , Animasyon_Modu_Check.Checked);
            this.Controls.Add(MesajAlert);
            MesajAlert.BringToFront(); // Bunu Kontrol'ün içinde çağıramazdık. çünkü işlemiyor. Kulağı mecbur ters tuttuk. çünkü formun üstünde yıkıp yıkıp edebilirdi.
        }

        private void Uygula_Buton_Click(object sender, EventArgs e)
        {
            Alert_Goster(this, Yazi_Text.Text);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
