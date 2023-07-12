namespace Mesaj_Alert
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Uygula_Buton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Alert_Time_Out_Text = new System.Windows.Forms.NumericUpDown();
            this.Yazi_Text = new System.Windows.Forms.TextBox();
            this.Animasyon_Modu_Check = new System.Windows.Forms.CheckBox();
            this.Alert_Kapanmasini_Bekle_Check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Alert_Time_Out_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label3.Location = new System.Drawing.Point(626, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(161, 20);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Powered By Argeolog";
            // 
            // Uygula_Buton
            // 
            this.Uygula_Buton.Location = new System.Drawing.Point(11, 74);
            this.Uygula_Buton.Name = "Uygula_Buton";
            this.Uygula_Buton.Size = new System.Drawing.Size(243, 23);
            this.Uygula_Buton.TabIndex = 12;
            this.Uygula_Buton.Text = "Uygula";
            this.Uygula_Buton.UseVisualStyleBackColor = true;
            this.Uygula_Buton.Click += new System.EventHandler(this.Uygula_Buton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Yazı";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Gösterim Süresi";
            // 
            // Alert_Time_Out_Text
            // 
            this.Alert_Time_Out_Text.Location = new System.Drawing.Point(98, 12);
            this.Alert_Time_Out_Text.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Alert_Time_Out_Text.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Alert_Time_Out_Text.Name = "Alert_Time_Out_Text";
            this.Alert_Time_Out_Text.Size = new System.Drawing.Size(156, 20);
            this.Alert_Time_Out_Text.TabIndex = 9;
            this.Alert_Time_Out_Text.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Yazi_Text
            // 
            this.Yazi_Text.Location = new System.Drawing.Point(98, 38);
            this.Yazi_Text.Name = "Yazi_Text";
            this.Yazi_Text.Size = new System.Drawing.Size(156, 20);
            this.Yazi_Text.TabIndex = 8;
            this.Yazi_Text.Text = "Kayıt İşlemi Başarılı";
            // 
            // Animasyon_Modu_Check
            // 
            this.Animasyon_Modu_Check.AutoSize = true;
            this.Animasyon_Modu_Check.Checked = true;
            this.Animasyon_Modu_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animasyon_Modu_Check.Location = new System.Drawing.Point(260, 12);
            this.Animasyon_Modu_Check.Name = "Animasyon_Modu_Check";
            this.Animasyon_Modu_Check.Size = new System.Drawing.Size(187, 17);
            this.Animasyon_Modu_Check.TabIndex = 7;
            this.Animasyon_Modu_Check.Text = "İniş ve Kalkışta Animasyon Uygula";
            this.Animasyon_Modu_Check.UseVisualStyleBackColor = true;
            // 
            // Alert_Kapanmasini_Bekle_Check
            // 
            this.Alert_Kapanmasini_Bekle_Check.AutoSize = true;
            this.Alert_Kapanmasini_Bekle_Check.Checked = true;
            this.Alert_Kapanmasini_Bekle_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Alert_Kapanmasini_Bekle_Check.Location = new System.Drawing.Point(260, 37);
            this.Alert_Kapanmasini_Bekle_Check.Name = "Alert_Kapanmasini_Bekle_Check";
            this.Alert_Kapanmasini_Bekle_Check.Size = new System.Drawing.Size(163, 17);
            this.Alert_Kapanmasini_Bekle_Check.TabIndex = 14;
            this.Alert_Kapanmasini_Bekle_Check.Text = "Alert Kapanana  Kadar Bekle";
            this.Alert_Kapanmasini_Bekle_Check.UseVisualStyleBackColor = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alert_Kapanmasini_Bekle_Check);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Uygula_Buton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Alert_Time_Out_Text);
            this.Controls.Add(this.Yazi_Text);
            this.Controls.Add(this.Animasyon_Modu_Check);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Alert_Time_Out_Text)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Uygula_Buton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown Alert_Time_Out_Text;
        internal System.Windows.Forms.TextBox Yazi_Text;
        internal System.Windows.Forms.CheckBox Animasyon_Modu_Check;
        internal System.Windows.Forms.CheckBox Alert_Kapanmasini_Bekle_Check;
    }
}

