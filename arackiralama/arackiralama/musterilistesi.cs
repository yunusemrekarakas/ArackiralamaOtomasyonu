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
    public partial class musterilistesi : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public musterilistesi()
        {
            InitializeComponent();
        

        }
        void musterilistele()
        {
         
            baglanti.Open();
            da = new SqlDataAdapter("Select *From musteri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void musterilistesi_Load(object sender, EventArgs e)
        {
            musterilistele();
        }

        private void textarama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("SELECT * FROM musteri WHERE tc like '%"+textarama.Text+"%'",baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView2.DataSource = tbl;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
           
            string cümle = "DELETE FROM musteri WHERE tc=@tc";
            komut = new SqlCommand(cümle, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.");
            musterilistele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string cümle = "UPDATE musteri SET adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email WHERE tc=@tc";
            komut = new SqlCommand(cümle, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@email", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.");
            musterilistele();

        }
    }
}
