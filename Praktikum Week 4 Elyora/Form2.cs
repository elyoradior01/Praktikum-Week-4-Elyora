using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_4_Elyora
{
    public partial class FormKedua : Form
    {
        public FormKedua()
        {
            InitializeComponent();
        }

        public static int urutan = 0;

        private void txtBoxNamaku_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();    
            FormUtama forms = new FormUtama();
            forms.ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (urutan == 9)
            {
                MessageBox.Show("Sudah Data Terakhir");
                urutan--;
            }
            else
            {
                urutan++;

                txtBoxNamaku.Text = FormUtama.coba2[urutan, 0];
                txtBoxAlamatku.Text = FormUtama.coba2[urutan, 1];
                txtBoxTelpku.Text = FormUtama.coba2[urutan, 2];

            }
        }

        private void FormKedua_Load(object sender, EventArgs e)
        {
            txtBoxNamaku.Text = FormUtama.coba2[urutan, 0];
            txtBoxAlamatku.Text = FormUtama.coba2[urutan, 1];
            txtBoxTelpku.Text = FormUtama.coba2[urutan, 2];

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {

            if(urutan == 0)
            {
                MessageBox.Show("Data Sudah Data Pertama");
                urutan++;
            }
            else
            {
                urutan--;

                txtBoxNamaku.Text = FormUtama.coba2[urutan, 0];
                txtBoxAlamatku.Text = FormUtama.coba2[urutan, 1];
                txtBoxTelpku.Text = FormUtama.coba2[urutan, 2];

            }

        }

        
    }
}
