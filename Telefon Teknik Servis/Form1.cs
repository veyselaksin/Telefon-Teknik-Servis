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
    
    public partial class Form1 : Form
        
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6MVFD8A\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            
                
                    baglan.Open();
                    string giris = "Select *From giris where users=@kadi AND password=@sifre";
                    SqlParameter pmr1 = new SqlParameter("kadi", textBox1.Text.Trim());
                    SqlParameter pmr2 = new SqlParameter("sifre", textBox2.Text.Trim());
                    SqlCommand komut = new SqlCommand(giris, baglan);
                    komut.Parameters.Add(pmr1);
                    komut.Parameters.Add(pmr2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                this.Hide();
                    }
            else {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
            baglan.Close();

           

        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
