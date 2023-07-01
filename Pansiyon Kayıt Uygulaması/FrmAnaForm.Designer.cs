
namespace Pansiyon_Kayıt_Uygulaması
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnYeniMusteri = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.BtnGelirGider = new System.Windows.Forms.Button();
            this.BtnStoklar = new System.Windows.Forms.Button();
            this.BtnMusteriMesajlari = new System.Windows.Forms.Button();
            this.BtnRadyoDinle = new System.Windows.Forms.Button();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Yellow;
            this.BtnAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(6, 44);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(144, 107);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnYeniMusteri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniMusteri.Location = new System.Drawing.Point(189, 44);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(144, 107);
            this.BtnYeniMusteri.TabIndex = 1;
            this.BtnYeniMusteri.Text = "Yeni Müşteri";
            this.BtnYeniMusteri.UseVisualStyleBackColor = false;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdalar.Location = new System.Drawing.Point(381, 44);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(144, 107);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = false;
            this.BtnOdalar.Click += new System.EventHandler(this.BtnOdalar_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.Red;
            this.BtnMusteriler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.Location = new System.Drawing.Point(6, 221);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(144, 107);
            this.BtnMusteriler.TabIndex = 3;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnGelirGider
            // 
            this.BtnGelirGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnGelirGider.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGelirGider.Location = new System.Drawing.Point(189, 221);
            this.BtnGelirGider.Name = "BtnGelirGider";
            this.BtnGelirGider.Size = new System.Drawing.Size(144, 107);
            this.BtnGelirGider.TabIndex = 4;
            this.BtnGelirGider.Text = "Gelir-Gider Formu";
            this.BtnGelirGider.UseVisualStyleBackColor = false;
            this.BtnGelirGider.Click += new System.EventHandler(this.BtnGelirGider_Click);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.BackColor = System.Drawing.Color.Lime;
            this.BtnStoklar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStoklar.Location = new System.Drawing.Point(381, 221);
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.Size = new System.Drawing.Size(144, 107);
            this.BtnStoklar.TabIndex = 5;
            this.BtnStoklar.Text = "Stoklar";
            this.BtnStoklar.UseVisualStyleBackColor = false;
            this.BtnStoklar.Click += new System.EventHandler(this.BtnStoklar_Click);
            // 
            // BtnMusteriMesajlari
            // 
            this.BtnMusteriMesajlari.BackColor = System.Drawing.Color.Blue;
            this.BtnMusteriMesajlari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriMesajlari.Location = new System.Drawing.Point(6, 410);
            this.BtnMusteriMesajlari.Name = "BtnMusteriMesajlari";
            this.BtnMusteriMesajlari.Size = new System.Drawing.Size(144, 107);
            this.BtnMusteriMesajlari.TabIndex = 6;
            this.BtnMusteriMesajlari.Text = "Müşteri Mesajları";
            this.BtnMusteriMesajlari.UseVisualStyleBackColor = false;
            // 
            // BtnRadyoDinle
            // 
            this.BtnRadyoDinle.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnRadyoDinle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRadyoDinle.Location = new System.Drawing.Point(189, 410);
            this.BtnRadyoDinle.Name = "BtnRadyoDinle";
            this.BtnRadyoDinle.Size = new System.Drawing.Size(144, 107);
            this.BtnRadyoDinle.TabIndex = 7;
            this.BtnRadyoDinle.Text = "Radyo Dinle";
            this.BtnRadyoDinle.UseVisualStyleBackColor = false;
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnHakkimizda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHakkimizda.Location = new System.Drawing.Point(381, 410);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(144, 107);
            this.BtnHakkimizda.TabIndex = 8;
            this.BtnHakkimizda.Text = "Hakkımızda";
            this.BtnHakkimizda.UseVisualStyleBackColor = false;
            this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(741, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(830, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(571, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 107);
            this.button1.TabIndex = 13;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(571, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 107);
            this.button2.TabIndex = 12;
            this.button2.Text = "Gazeteler";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(571, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 107);
            this.button3.TabIndex = 11;
            this.button3.Text = "Hava Durumu";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1026, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHakkimizda);
            this.Controls.Add(this.BtnRadyoDinle);
            this.Controls.Add(this.BtnMusteriMesajlari);
            this.Controls.Add(this.BtnStoklar);
            this.Controls.Add(this.BtnGelirGider);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnYeniMusteri);
            this.Controls.Add(this.BtnAdminGiris);
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnYeniMusteri;
        private System.Windows.Forms.Button BtnOdalar;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button BtnGelirGider;
        private System.Windows.Forms.Button BtnStoklar;
        private System.Windows.Forms.Button BtnMusteriMesajlari;
        private System.Windows.Forms.Button BtnRadyoDinle;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}