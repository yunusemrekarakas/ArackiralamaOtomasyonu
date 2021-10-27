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
    public partial class satislarfrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
        public satislarfrm()
        {
            InitializeComponent();
        }
        void sozlesmelistelemesi()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From satislar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public void satishesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satislar",baglanti);
            lbl.Text = "Toplam Tutar "+komut.ExecuteScalar()+"TL";
            baglanti.Close();

            
        
        }
        private void satislarfrm_Load(object sender, EventArgs e)
        {
            sozlesmelistelemesi();
            satishesapla(label1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
