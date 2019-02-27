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
   
    public partial class Form2 : Form
    {
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;

        public Form2()
        {
            InitializeComponent();

            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();


            frm3.frm2 = this;
            frm4.frm2 = this;
            frm5.frm2 = this;
            frm6.frm2 = this;

        }
        public SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6MVFD8A\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True");
        public SqlCommand kmt = new SqlCommand();
        private void Form2_Load(object sender, EventArgs e)
        {
            goster("Select *From servis");
        }
        private void servis()
        {
            baglan.Open();
        }
        private void goster(string veriler)
        {
            
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select musteri.Ad,musteri.Soyad,musteri.TC,telefon.Marka,telefon.Model,telefon.Tutar from musteri inner join telefon on(musteri.Ad=telefon.TeslimAlan)", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        public void musteriListele(string musteriveri)
        {

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(musteriveri, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            frm3.dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        public void urunliste(string urunveri)
        {

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(urunveri, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            frm6.dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UrunButton_Click(object sender, EventArgs e)
        {
            frm6.ShowDialog();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            goster("Select *From servis");
        }

        private void Mstbutton_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
