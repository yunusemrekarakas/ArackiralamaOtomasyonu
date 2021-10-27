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

namespace arackiralama
{
    
    public partial class arackayit : Form
    {
        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
        public arackayit()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboseri.Items.Clear();
                if (combomarka.SelectedIndex==0)
                {
                    comboseri.Items.Add("Megan");
                    comboseri.Items.Add("Clio");
                    comboseri.Items.Add("Fluence");
                    comboseri.Items.Add("Symbol");
                    comboseri.Items.Add("Captur");
                    comboseri.Items.Add("Kadjar");
                    comboseri.Items.Add("Talisman");
                    comboseri.Items.Add("Koleos");
                    comboseri.Items.Add("Kangoo");
                }
                else if (combomarka.SelectedIndex==1)
                {
                    comboseri.Items.Add("Corsa");
                    comboseri.Items.Add("Astra");
                    comboseri.Items.Add("Insignia");
                    comboseri.Items.Add("Crossland");
                    comboseri.Items.Add("Mokko X");
                    comboseri.Items.Add("Crossland X");
                    comboseri.Items.Add("Grandlan X");
                    comboseri.Items.Add("Combo");
                }
                else if (combomarka.SelectedIndex==2)
                {
                    comboseri.Items.Add("A serisi"); comboseri.Items.Add("B serisi"); comboseri.Items.Add("C serisi");
                    comboseri.Items.Add("GLA Serisi"); comboseri.Items.Add("CLA serisi"); comboseri.Items.Add("CLS");
                    comboseri.Items.Add("GLB"); comboseri.Items.Add("SRC"); comboseri.Items.Add("E serisi");
                    comboseri.Items.Add("S serisi"); comboseri.Items.Add("GLC"); comboseri.Items.Add("GLE");
                }
                else if (combomarka.SelectedIndex == 3)
                {
                    comboseri.Items.Add("Bmw 2 serisi"); comboseri.Items.Add("Bmw 3 serisi"); comboseri.Items.Add("Bmw 4 serisi");
                    comboseri.Items.Add("Bmw 5 serisi"); comboseri.Items.Add("Bmw 6 serisi"); comboseri.Items.Add("Bmw 7 serisi");
                    comboseri.Items.Add("Bmw 8 serisi"); comboseri.Items.Add("Bmw X1"); comboseri.Items.Add("Bmw X2");
                    comboseri.Items.Add("Bmw X3"); comboseri.Items.Add("Bmw X5"); comboseri.Items.Add("BMW Z4");
                }
                else if (combomarka.SelectedIndex == 4)
                {
                    comboseri.Items.Add("Fiat 500"); comboseri.Items.Add("Panda Urban"); comboseri.Items.Add("Doblo");
                    comboseri.Items.Add("Fiorino"); comboseri.Items.Add("500L"); comboseri.Items.Add("Egea");

                }
                else if (combomarka.SelectedIndex == 5)
                {
                    comboseri.Items.Add("A4"); comboseri.Items.Add("A6"); comboseri.Items.Add("A8");
                    comboseri.Items.Add("Q2"); comboseri.Items.Add("Q3"); comboseri.Items.Add("Q5");
                    comboseri.Items.Add("Q5"); comboseri.Items.Add("Q6"); comboseri.Items.Add("Q7");
                    comboseri.Items.Add("A7"); comboseri.Items.Add("Q8");
                }

            }
            catch 
            {

               throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cumle = "INSERT INTO arac(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) VALUES(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand(cumle, baglanti);
            komut2.Parameters.AddWithValue("@plaka", textplaka.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@seri", comboseri.Text);
            komut2.Parameters.AddWithValue("@yil", textmodel.Text);
            komut2.Parameters.AddWithValue("@renk", textrenk.Text);
            komut2.Parameters.AddWithValue("@km", textkm.Text);
            komut2.Parameters.AddWithValue("@yakit", comboyakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti",int.Parse( textkira.Text));
            komut2.Parameters.AddWithValue("@durumu","BOŞ");
            komut2.Parameters.AddWithValue("@resim",pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kayıt edildi");
            comboseri.Items.Clear();
             foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";

        }

        private void arackayit_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
