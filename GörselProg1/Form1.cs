using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;


namespace GörselProg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Application.StartupPath + "//Kisiler1.accdb"); 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "Insert into Kisi(TCNO,Ad,Soyad,DogumYeri,DogumTarihi,Cinsiyet,Resim)" +
                "values(@TCNO,@Ad,@Soyad,@DogumYeri,@DogumTarihi,@Cinsiyet,@Resim)";
            komut.Parameters.AddWithValue("@TCNO",txtTCNO.Text);
            komut.Parameters.AddWithValue("@Ad",txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad",txtSoyad.Text);
            komut.Parameters.AddWithValue("@DogumYeri",txtDogumYeri.Text);
            komut.Parameters.AddWithValue("@DogumTarihi",dtDogumTarihi.Value);
            komut.Parameters.AddWithValue("@Cinsiyet",rbKadın.Checked?"Kadın":"Erkek");
            if(pictureBox1.Image!= null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                komut.Parameters.AddWithValue("@Resim",ms.ToArray());


            }
            komut.Connection = baglanti;
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt yapıldı", "İşlem başarılı!");
            }
            else
                MessageBox.Show("Kayıt yapılamadı", "İşlem başarısız!!");
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Dosyaları|*.jpg|Png Dosyaları|*.png";
            ofd.ShowDialog();
            if (ofd.CheckFileExists)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
    }
}
