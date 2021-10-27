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
    public partial class sozlesmeler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H5NTHC\\SQLEXPRESS;Initial Catalog=kiralamaoto;Integrated Security=True");
        public sozlesmeler()
        {
            InitializeComponent();
        }
        public void bosarac(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        void sozlesmelistelemesi()
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From sozlesme", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        public void tcarama(TextBox tcara,TextBox tc, TextBox adsoyad, TextBox tel, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                tel.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }
        public void aracaramalar(ComboBox aracgetir, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();

            }
            baglanti.Close();
        }
        public void uucrethesaplama(ComboBox kirasekli, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                if (kirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (kirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.85).ToString();
                if (kirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();
            }
            baglanti.Close();
        }
        private void bos(){

            string sorgu2 = "Select* From arac WHERE durumu='BOŞ'";
            bosarac(comboarac, sorgu2);
        }
        private void sozlesmeler_Load(object sender, EventArgs e)
        {
            bos();
            sozlesmelistelemesi();
        }
        private void txtttc_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboarac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "Select* From arac WHERE plaka like '" + comboarac.SelectedItem + "'";
           aracaramalar(comboarac,txtmarka, textserii,txtyil,txtrenk, sorgu2);

        }
        private void combokirasekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "Select* From arac WHERE plaka like '" + comboarac.SelectedItem + "'";
            uucrethesaplama(combokirasekli,txtkiraucret,sorgu2);
        }
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun= DateTime.Parse(dateTimePickerdon.Text) - DateTime.Parse(dateTimePickercik.Text);
            int gun2 = gun.Days;
            txtgun.Text = gun2.ToString();
            txttutar.Text = (gun2 * int.Parse(txtkiraucret.Text)).ToString();
        }
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            dateTimePickercik.Text = DateTime.Now.ToShortDateString();
            dateTimePickerdon.Text = DateTime.Now.ToShortDateString();
            combokirasekli.Text = "";
            txtkiraucret.Text = "";
            txttutar.Text = "";
            txtgun.Text = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sozlesmelistelemesi();
        }

        private void ekleme_Click(object sender, EventArgs e)
        {
            string cumle = "INSERT INTO sozlesme(tc,adsoyad,telefon,ehliyetnum,ehliyettarih,ehliyetyer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,cikistarih,donustarih) VALUES(@tc,@adsoyad,@telefon,@ehliyetnum,@ehliyettarih,@ehliyetyer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@cikistarih,@donustarih)";
            SqlCommand komut2 = new SqlCommand(cumle, baglanti);
            komut2.Parameters.AddWithValue("@tc", txtttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoy.Text);
            komut2.Parameters.AddWithValue("@telefon", txttel.Text);
            komut2.Parameters.AddWithValue("@ehliyetnum", textnoehliyet.Text);
            komut2.Parameters.AddWithValue("@ehliyettarih", txttarihehliyet.Text);
            komut2.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboarac.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@seri", textserii.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combokirasekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkiraucret.Text));
            komut2.Parameters.AddWithValue("@gun",int.Parse( txtgun.Text));
            komut2.Parameters.AddWithValue("@tutar",int.Parse( txttutar.Text));
            komut2.Parameters.AddWithValue("@cikistarih",dateTimePickercik.Text);
            komut2.Parameters.AddWithValue("@donustarih",dateTimePickerdon.Text);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            string cumle2= "UPDATE arac SET durumu='DOLU'  WHERE plaka='"+comboarac.Text+"'";
            SqlCommand komut3 = new SqlCommand(cumle2, baglanti);
            baglanti.Open();
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Kaydedildi.");
            comboarac.Items.Clear();
            bos();
            sozlesmelistelemesi();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            string cumle = "UPDATE sozlesme SET tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetnum=@ehliyetnum,ehliyettarih=@ehliyettarih,ehliyetyer=@ehliyetyer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,cikistarih=@cikistarih,donustarih=@donustarih WHERE plaka=@plaka";
            SqlCommand komut2 = new SqlCommand(cumle, baglanti);
            komut2.Parameters.AddWithValue("@tc", txtttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoy.Text);
            komut2.Parameters.AddWithValue("@telefon", txttel.Text);
            komut2.Parameters.AddWithValue("@ehliyetnum", textnoehliyet.Text);
            komut2.Parameters.AddWithValue("@ehliyettarih", txttarihehliyet.Text);
            komut2.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboarac.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@seri", textserii.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combokirasekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkiraucret.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtgun.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@cikistarih", dateTimePickercik.Text);
            komut2.Parameters.AddWithValue("@donustarih", dateTimePickerdon.Text);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.");
            comboarac.Items.Clear();
            bos();
            sozlesmelistelemesi();

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            txtttc.Text = satir.Cells[0].Value.ToString();
            txtadsoy.Text = satir.Cells[1].Value.ToString();
            txttel.Text = satir.Cells[2].Value.ToString();
            textnoehliyet.Text = satir.Cells[3].Value.ToString();
            txttarihehliyet.Text = satir.Cells[4].Value.ToString();
            txtehliyetyer.Text = satir.Cells[5].Value.ToString();
            comboarac.Text = satir.Cells[6].Value.ToString();
            txtmarka.Text = satir.Cells[7].Value.ToString();
            textserii.Text= satir.Cells[8].Value.ToString();
            txtyil.Text = satir.Cells[9].Value.ToString();
            txtrenk.Text = satir.Cells[10].Value.ToString();      
            combokirasekli.Text = satir.Cells[11].Value.ToString();
            txtkiraucret.Text = satir.Cells[12].Value.ToString();
            txtgun.Text = satir.Cells[13].Value.ToString();
            txttutar.Text = satir.Cells[14].Value.ToString();
            dateTimePickercik.Text = satir.Cells[15].Value.ToString();
            dateTimePickerdon.Text = satir.Cells[16].Value.ToString();
        }
        private void tcara_TextChanged(object sender, EventArgs e)
        {
            if (tcara.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "Select* From musteri WHERE tc like '" + tcara.Text + "'";
            tcarama(tcara, txtttc, txtadsoy, txttel, sorgu2);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["donustarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan fark = bugun - donus;
            int gunfarki = fark.Days;
            int ucretfarki;
            ucretfarki = gunfarki * ucret;
            txtalacakverecek.Text = ucretfarki.ToString();
        }
        private void buttonteslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtalacakverecek.Text)>=0 || int.Parse(txtalacakverecek.Text)<0)
            {
                DataGridViewRow satir = dataGridView2.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["cikistarih"].Value.ToString());
                TimeSpan gn = bugun - cikis;
                int _gun = gn.Days;
                int toplam = _gun * ucret;

           
                string cümle = "DELETE FROM sozlesme WHERE plaka='"+satir.Cells["plaka"].Value.ToString()+"' ";
                SqlCommand komut = new SqlCommand(cümle, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                string cümle2 = "UPDATE arac SET durumu='BOŞ' WHERE plaka='" + satir.Cells["plaka"].Value.ToString() + "' ";
                SqlCommand komut3 = new SqlCommand(cümle2, baglanti);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();
                string cumle3 = "INSERT INTO satislar(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,ilktarih,buguntarih,fiyat) VALUES(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@ilktarih,@buguntarih,@fiyat)";
                SqlCommand komut2 = new SqlCommand(cumle3, baglanti);
                komut2.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satir.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@tutar", toplam);
                komut2.Parameters.AddWithValue("@ilktarih", satir.Cells["cikistarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@buguntarih",DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);
                baglanti.Open();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç teslim edildi");
                comboarac.Items.Clear();
                bos();
                sozlesmelistelemesi();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                txtalacakverecek.Text = "";
            }
            else 
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
