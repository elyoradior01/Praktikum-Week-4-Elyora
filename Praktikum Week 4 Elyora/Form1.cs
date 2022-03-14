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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        public DataTable coba = new DataTable();
        public static string[,] coba2 = new string[10,3];

        public static int urutan = 0; 

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if(urutan > 9)
            {
                MessageBox.Show("Data telah penuh!");
            }
            else
            {
               
                coba2[urutan, 0] = txtBoxNamah.Text;
                coba2[urutan, 1] = txtBoxAlamath.Text;
                coba2[urutan, 2] = txtBoxTelph.Text;
                urutan++;

            }
    
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonLihat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKedua form = new FormKedua();
            form.ShowDialog();
            
        }

        private void txtBoxTelph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTelph_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}