﻿using System;
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
    public partial class MesajAlertUser : UserControl
    {
       

        int Alert_CloseTimeOut;
        Form AlertForm_;
        int TimerSay;
        bool YukariAnimasyonAktif;
       public  bool FormHareketHalinde;

        public MesajAlertUser()
        {
            InitializeComponent();
            this.Visible = false; // Bunu Yazdiğimizda Load Çalışmıyor. Yüzden Harici Fonksiyon Yazdık
        }

        private void Animasyon_Timer_Tick(object sender, EventArgs e)
        {
            TimerSay += 1;
            FormHareketHalinde = true;

            if (YukariAnimasyonAktif == true)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 1);

                if (TimerSay >= 58)
                {
                    TimerSay = 0;
                    Animasyon_Timer.Stop();
                    Animasyon_Timer.Interval = Alert_CloseTimeOut;
                    Animasyon_Timer.Start();
                    YukariAnimasyonAktif = false;
                    FormHareketHalinde = false;
                }
            }
            else
            {
                Animasyon_Timer.Interval = 1;
                this.Location = new Point(this.Location.X, this.Location.Y + 1);
                if (TimerSay >= 60)
                {
                    FormHareketHalinde = false;
                    Animasyon_Timer.Stop();
                    this.Visible = false;
                    AlertForm_.Controls.Remove(this);
                    this.Dispose();
                }
            }
        }

        public void Size_Ayarla(object sender, EventArgs e)
        {
            int Yukseklik = this.Height;
            if (YukariAnimasyonAktif == false)
                Yukseklik = 0;

            this.Width = AlertForm_.Width;
            this.Location = new Point(AlertForm_.ClientRectangle.Location.X, (AlertForm_.ClientRectangle.Location.Y + AlertForm_.ClientRectangle.Height) - (this.Height - Yukseklik));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        public void Set_Setting(Form AlertForm, int AlertCloseTimeOut, string MessageText, bool YukariAnimasyonYap)
        {
            YukariAnimasyonAktif = YukariAnimasyonYap;
            Alert_CloseTimeOut = AlertCloseTimeOut;
            Alert_Label.Text = MessageText;
            AlertForm_ = AlertForm;


            if (YukariAnimasyonAktif == true)
            {
                MesajAlertUser UserAlert = (MesajAlertUser)AlertForm_.Controls.OfType<UserControl>().FirstOrDefault(UserControl => UserControl.Name == "MesajAlertUser");
                if (UserAlert != null)
                {
                    UserAlert.Animasyon_Timer.Stop();
                    AlertForm_.Controls.Remove(UserAlert);
                }
            }

            AlertForm.SizeChanged += new System.EventHandler(this.Size_Ayarla);
            Size_Ayarla(null, null);
            this.Visible = true;
        }



        private void MesajAlertUser_Load(object sender, EventArgs e)
        {
            
            
            Animasyon_Timer.Interval = 1; // Load a koyduk. kontroller eklendiğinde aktif olsun diye.
            if (YukariAnimasyonAktif == false)
                Animasyon_Timer.Interval = Alert_CloseTimeOut;
            Animasyon_Timer.Enabled = true;
        }

   
    }
}
