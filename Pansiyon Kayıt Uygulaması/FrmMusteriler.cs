using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LalePansiyon;Integrated Security=True");

        //erişim belirleyici = kod parçacığını birden çok yerde kullanacaksak bunu kullanırız
        private void verilergoster()
        {
            listView1.Items.Clear(); //her defasında listedeki ögeleri temizle
            baglanti.Open(); //önce kapalı olan bağlantıyı aç
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti); //sql komutu yaz(MüsteriEkle tablosundan verileri çek), bağlantıyla ilişkilendirdik
            SqlDataReader oku = komut.ExecuteReader(); //gelen parametreleri okur

            //oku komutu çalıştığı müddetçe
            while (oku.Read()) 
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString(); //kökdüğüm
                ekle.SubItems.Add(oku["Adi"].ToString()); //çocukları
                ekle.SubItems.Add(oku["Soyadi"].ToString()); //çocukları
                ekle.SubItems.Add(oku["Cinsiyet"].ToString()); //çocukları
                ekle.SubItems.Add(oku["Telefon"].ToString()); //çocukları
                ekle.SubItems.Add(oku["Mail"].ToString()); //çocukları
                ekle.SubItems.Add(oku["TC"].ToString()); //çocukları
                ekle.SubItems.Add(oku["OdaNo"].ToString()); //çocukları
                ekle.SubItems.Add(oku["Ucret"].ToString()); //çocukları
                ekle.SubItems.Add(oku["GirisTarihi"].ToString()); //çocukları
                ekle.SubItems.Add(oku["CikisTarihi"].ToString()); //çocukları

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi = '" + TxtAdi.Text + "' , Soyadi = '" + TxtSoyadi.Text + "' , Cinsiyet = '" + comboBox1.Text + "' , Telefon = '" + MskTxtTelefon.Text + "' , Mail = '" + TxtMail.Text + "' , TC = '" + TxtKimlikNo.Text + "' , OdaNo = '" + TxtOdaNo.Text + "' , Ucret = '" + TxtUcret.Text + "' , GirisTarihi = '" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', CikisTarihi = '" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid = " + id + "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + textBox1.Text + "%'", baglanti); 
            SqlDataReader oku = komut.ExecuteReader(); 

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString()); 
                ekle.SubItems.Add(oku["Soyadi"].ToString()); 
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString()); 
                ekle.SubItems.Add(oku["Mail"].ToString()); 
                ekle.SubItems.Add(oku["TC"].ToString()); 
                ekle.SubItems.Add(oku["OdaNo"].ToString()); 
                ekle.SubItems.Add(oku["Ucret"].ToString()); 
                ekle.SubItems.Add(oku["GirisTarihi"].ToString()); 
                ekle.SubItems.Add(oku["CikisTarihi"].ToString()); 

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LalePansiyon;Integrated Security=True
