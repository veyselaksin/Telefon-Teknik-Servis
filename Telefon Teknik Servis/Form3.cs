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
    public partial class Form3 : Form
    {
        public Form2 frm2;
        public Form4 frm4;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.frm4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            frm2.musteriListele("Select *From musteri");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm2.frm4.tcbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm2.frm4.adbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm2.frm4.sadibox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm2.frm4.ctelbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm2.frm4.stelbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm2.frm4.shrbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm2.frm4.ilcebox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm2.frm4.adrsbox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm2.frm4.ShowDialog();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm2.musteriListele("Select *From musteri");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.baglan.Open();
            frm2.kmt.Connection = frm2.baglan;
            frm2.kmt.CommandText = "DELETE from musteri WHERE TC='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            frm2.kmt.ExecuteNonQuery();
            frm2.baglan.Close();
            MessageBox.Show("Kayıt Silindi.");
            frm2.musteriListele("Select *from musteri");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm2.baglan.Open();
            frm2.kmt.Connection = frm2.baglan;
            frm2.kmt.CommandText = "Select *From musteri where ad like '%" + searchbox.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(frm2.kmt);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            frm2.baglan.Close();
        }
    }
}
