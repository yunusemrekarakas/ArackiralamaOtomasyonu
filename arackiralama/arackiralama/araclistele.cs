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
    public partial class araclistele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
        
        
        public araclistele()
        {
            InitializeComponent();
        }
        void araclistelemesi()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From arac", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textplaka.Text = satir.Cells["plaka"].Value.ToString();
            combomarka.Text = satir.Cells["marka"].Value.ToString();
            comboseri.Text = satir.Cells["seri"].Value.ToString();
            textmodel.Text = satir.Cells["yil"].Value.ToString();
            textrenk.Text = satir.Cells["renk"].Value.ToString();
            textkm.Text = satir.Cells["km"].Value.ToString();
            comboyakit.Text = satir.Cells["yakit"].Value.ToString();
            textkira.Text = satir.Cells["kiraucreti"].Value.ToString();
            pictureBox1.ImageLocation = satir.Cells["resim"].Value.ToString();

        }

        private void araclistele_Load(object sender, EventArgs e)
        {
             araclistelemesi();
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch
            {

                throw;
            }
        }

        private void ekleresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            string cumle = "UPDATE arac SET plaka=@plaka,marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih WHERE plaka=@plaka";
            SqlCommand komut2 = new SqlCommand(cumle, baglanti);
            komut2.Parameters.AddWithValue("@plaka", textplaka.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@seri", comboseri.Text);
            komut2.Parameters.AddWithValue("@yil", textmodel.Text);
            komut2.Parameters.AddWithValue("@renk", textrenk.Text);
            komut2.Parameters.AddWithValue("@km", textkm.Text);
            komut2.Parameters.AddWithValue("@yakit", comboyakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(textkira.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            comboseri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            araclistelemesi();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            string cümle = "DELETE FROM arac WHERE plaka=@plaka";
            SqlCommand  komut = new SqlCommand(cümle, baglanti);
            komut.Parameters.AddWithValue("@plaka", textplaka.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            araclistelemesi();
            MessageBox.Show("kayıt silindi");
            comboseri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";

        }

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboseri.Items.Clear();
                if (combomarka.SelectedIndex == 0)
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
                else if (combomarka.SelectedIndex == 1)
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
                else if (combomarka.SelectedIndex == 2)
                {
                    comboseri.Items.Add("A serisi"); comboseri.Items.Add("B serisi"); comboseri.Items.Add("C serisi");
                    comboseri.Items.Add("GLA Serisi"); comboseri.Items.Add("CLA serisi"); comboseri.Items.Add("CLS");
                    comboseri.Items.Add("GLB"); comboseri.Items.Add("SRC"); comboseri.Items.Add("E serisi");
                    comboseri.Items.Add("S serisi"); comboseri.Items.Add("GLC"); comboseri.Items.Add("GLE");
                }

            }
            catch
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex==0)
                {
                    araclistelemesi();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select *From arac WHERE durumu='DOLU'", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglanti.Close();

                }
                if (comboBox1.SelectedIndex == 2)
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select *From arac WHERE durumu='BOŞ'", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglanti.Close();
                }
            }
            catch
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
