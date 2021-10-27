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
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteri(tc,adsoyad,telefon,adres,email) VALUES(@tc,@adsoyad,@telefon,@adres,@email)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc",textBox1.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@email", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muşteri Kaydedildi.");
            musterigetir();
        }
        void musterigetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From musteri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musterigetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
