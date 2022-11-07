using System;
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
    public partial class KitapEkle : Form
    {
        AnaEkran anaEkran;

        public KitapEkle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            foreach(string yazar in anaEkran.YazarlarDizisi)
            {
                comboBox1.Items.Add(yazar);
            }
        }
        ErrorProvider ErrorProvider = new ErrorProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) )
            {
                ErrorProvider.SetError(textBox1, "kitap ismini girin");
                ErrorProvider.SetError(textBox2, "yazar ismini girin"); 
            }
            else
            {
                Kitap kitap = new Kitap(textBox1.Text, textBox2.Text);

                if (!(anaEkran.YazarlarDizisi.IndexOf(textBox2.Text) >= 0))
                {
                    anaEkran.YazarlarDizisi.Add(textBox2.Text);
                }

                anaEkran.kitapEkle(kitap);
                anaEkran.Show();
                this.Close();
            }
        }

        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
