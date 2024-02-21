namespace GörselProg1
{
    partial class Form1
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
            this.txtTC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.Label();
            this.txtSoy = new System.Windows.Forms.Label();
            this.txtDogum = new System.Windows.Forms.Label();
            this.txtDogumTarihi = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.AutoSize = true;
            this.txtTC.Location = new System.Drawing.Point(12, 9);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(38, 13);
            this.txtTC.TabIndex = 0;
            this.txtTC.Text = "TC No";
            this.txtTC.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Location = new System.Drawing.Point(12, 32);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(20, 13);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "Ad";
            // 
            // txtSoy
            // 
            this.txtSoy.AutoSize = true;
            this.txtSoy.Location = new System.Drawing.Point(12, 55);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(37, 13);
            this.txtSoy.TabIndex = 2;
            this.txtSoy.Text = "Soyad";
            // 
            // txtDogum
            // 
            this.txtDogum.AutoSize = true;
            this.txtDogum.Location = new System.Drawing.Point(12, 81);
            this.txtDogum.Name = "txtDogum";
            this.txtDogum.Size = new System.Drawing.Size(62, 13);
            this.txtDogum.TabIndex = 3;
            this.txtDogum.Text = "Dogum Yeri";
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.AutoSize = true;
            this.txtDogumTarihi.Location = new System.Drawing.Point(12, 110);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.txtDogumTarihi.TabIndex = 4;
            this.txtDogumTarihi.Text = "Dogum Tarihi";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.AutoSize = true;
            this.txtCinsiyet.Location = new System.Drawing.Point(12, 138);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.txtCinsiyet.TabIndex = 5;
            this.txtCinsiyet.Text = "Cinsiyet";
            // 
            // txtTCNO
            // 
            this.txtTCNO.Location = new System.Drawing.Point(92, 6);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(200, 20);
            this.txtTCNO.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(92, 58);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(92, 84);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(200, 20);
            this.txtDogumYeri.TabIndex = 9;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(92, 110);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtDogumTarihi.TabIndex = 10;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(92, 138);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 11;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Location = new System.Drawing.Point(196, 136);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(52, 17);
            this.rbKadın.TabIndex = 12;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(347, 165);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(75, 23);
            this.btnResimSec.TabIndex = 14;
            this.btnResimSec.Text = "Resim Sec";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(501, 71);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTCNO);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtDogum);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtTC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTC;
        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Label txtSoy;
        private System.Windows.Forms.Label txtDogum;
        private System.Windows.Forms.Label txtDogumTarihi;
        private System.Windows.Forms.Label txtCinsiyet;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnKaydet;
    }
}

