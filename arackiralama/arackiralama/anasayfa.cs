using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arackiralama
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ekle = new Form1();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musterilistesi ekle1 = new musterilistesi();
            ekle1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arackayit arckayit = new arackayit();
            arckayit.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            araclistele liste = new araclistele();
            liste.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sozlesmeler gir = new sozlesmeler();
            gir.ShowDialog();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            satislarfrm satis = new satislarfrm();
            satis.ShowDialog();
        }
    }
}
