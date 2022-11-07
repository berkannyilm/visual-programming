using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public ArrayList YazarlarDizisi=new ArrayList();    
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
            this.Hide();
        }

        public void kitapEkle(Kitap kitap)
        {
            listBox1.Items.Add(kitap);
        }

        public void kitapDuzenle(Kitap kitap)
        {
            listBox1.Items[listBox1.SelectedIndex] = kitap;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlgili kitabı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kitap kitap = (Kitap) listBox1.Items[listBox1.SelectedIndex];
            KitapDuzenle kitapDuzenle = new KitapDuzenle(this, kitap);
            kitapDuzenle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YazarEkle CagrilanYazarEkleFormu = new YazarEkle(this);
            CagrilanYazarEkleFormu.Show();
            this.Hide();
        }
    }
}
