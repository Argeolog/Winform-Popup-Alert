namespace Mesaj_Alert
{
    partial class MesajAlertUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Animasyon_Timer = new System.Windows.Forms.Timer(this.components);
            this.Alert_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Animasyon_Timer
            // 
            this.Animasyon_Timer.Interval = 1000;
            this.Animasyon_Timer.Tick += new System.EventHandler(this.Animasyon_Timer_Tick);
            // 
            // Alert_Label
            // 
            this.Alert_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Alert_Label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Alert_Label.ForeColor = System.Drawing.Color.White;
            this.Alert_Label.Location = new System.Drawing.Point(5, 13);
            this.Alert_Label.Name = "Alert_Label";
            this.Alert_Label.Size = new System.Drawing.Size(457, 33);
            this.Alert_Label.TabIndex = 1096;
            this.Alert_Label.Text = "---";
            this.Alert_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alert_Label.Click += new System.EventHandler(this.Alert_Label_Click);
            // 
            // MesajAlertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.Alert_Label);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "MesajAlertUser";
            this.Size = new System.Drawing.Size(467, 58);
            this.Load += new System.EventHandler(this.MesajAlertUser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer Animasyon_Timer;
        internal System.Windows.Forms.Label Alert_Label;
    }
}
