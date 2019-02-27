using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telefon_Teknik_Servis
{
    public partial class Form5 : Form
    {
        public Form2 frm2;
        public Form6 frm6;

        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6MVFD8A\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (serinobox.Text.Trim() == "" || markabox.Text.Trim() == "" || modelbox.Text.Trim() == "" || atarihbox.Text.Trim() == "" || talanbox.Text.Trim() == "" || arizabox.Text.Trim() == "" || aboutbox.Text.Trim() == "" || tutarbox.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun...");
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into telefon (SeriNo,Marka,Model,AlimTarihi,TeslimAlan,Ariza,Aciklama,Tutar) values (@seri,@marka,@model,@tarih,@teslim,@ariza,@aciklama,@tutar)", baglan);
                komut.Parameters.AddWithValue("@seri", serinobox.Text);
                komut.Parameters.AddWithValue("@marka", markabox.Text);
                komut.Parameters.AddWithValue("@model", modelbox.Text);
                komut.Parameters.AddWithValue("@tarih", atarihbox.Value.Date);
                komut.Parameters.AddWithValue("@teslim", talanbox.Text);
                komut.Parameters.AddWithValue("@ariza", arizabox.Text);
                komut.Parameters.AddWithValue("@aciklama", aboutbox.Text);
                komut.Parameters.AddWithValue("@tutar", tutarbox.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update telefon set SeriNo='" + serinobox.Text + "',Marka='" + markabox.Text + "',Model='" + modelbox + "',AlimTarihi='" + atarihbox.Value.Date+ "',TeslimAlan='" + talanbox.Text + "',Ariza='" + arizabox.Text + "',Aciklama='" + aboutbox.Text + "',Tutar='" + tutarbox.Text + "' where SeriNo='" + serinobox.Text+ "'", baglan);
            komut.ExecuteNonQuery();
            frm2.urunliste("Select *From telefon");
            baglan.Close();
        }
    }
}
