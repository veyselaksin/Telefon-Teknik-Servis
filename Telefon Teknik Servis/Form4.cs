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
    public partial class Form4 : Form
    {
        public Form2 frm2;
        

        public Form4()
        {
            InitializeComponent();
            
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6MVFD8A\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (adbox.Text.Trim() == "" || tcbox.Text.Trim() == "" || sadibox.Text.Trim() == "" || ctelbox.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Ad-Soyad-TC-Cep Tel alaanlarını Doldurun....");
            }
            else
            {
                frm2.baglan.Open();
                frm2.kmt.Connection = frm2.baglan;
                frm2.kmt.CommandText ="Insert into musteri (TC,Ad,Soyad,Ceptel,Sabittel,İl,İlce,Adres) values (@tc,@ad,@soyad,@ctel,@stel,@il,@ilce,@adres)";
                frm2.kmt.Parameters.AddWithValue("@ad",adbox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@soyad", sadibox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@tc", tcbox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@ctel", ctelbox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@stel", stelbox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@il", shrbox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@ilce", ilcebox.Text.Trim());
                frm2.kmt.Parameters.AddWithValue("@adres", adrsbox.Text.Trim());
                frm2.kmt.ExecuteNonQuery();
                frm2.baglan.Close();
                MessageBox.Show("Kayıt oluşturuldu...");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update musteri set TC='" + tcbox.Text.Trim() + "',Ad='" + adbox.Text.Trim() + "',Soyad='" + sadibox.Text.Trim() + "',Ceptel='" + ctelbox.Text.Trim() + "',Sabittel='" + stelbox.Text.Trim() + "',İl='" + shrbox.Text.Trim() + "',İlce='" + ilcebox.Text.Trim() + "',Adres='" + adrsbox.Text.Trim() + "' where TC='" + tcbox.Text.Trim() + "'", baglan);
            komut.ExecuteNonQuery();
            frm2.musteriListele("Select *From musteri");
            baglan.Close();
        }

        public void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
