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

    public partial class Form6 : Form
    {
        public Form2 frm2;

        public Form6()
        {
            InitializeComponent();
        }


        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6MVFD8A\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True");
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            frm2.urunliste("Select *From telefon");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm2.urunliste("Select *From telefon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.baglan.Open();
            frm2.kmt.Connection = frm2.baglan;
            frm2.kmt.CommandText = "DELETE from telefon WHERE SeriNo='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            frm2.kmt.ExecuteNonQuery();
            frm2.baglan.Close();
            MessageBox.Show("Kayıt Silindi.");
            frm2.musteriListele("Select *from telefon");

        }
        
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm2.frm5.serinobox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm2.frm5.markabox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm2.frm5.modelbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm2.frm5.modelbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm2.frm5.talanbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm2.frm5.arizabox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm2.frm5.aboutbox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm2.frm5.tutarbox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm2.frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm2.baglan.Open();
            frm2.kmt.Connection = frm2.baglan;
            frm2.kmt.CommandText = "Select *From telefon where SeriNo like '%" + searchbox.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(frm2.kmt);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            frm2.baglan.Close();
        }
    }
}
