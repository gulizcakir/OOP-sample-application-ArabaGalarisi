using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGalarisiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Galari galari = new Galari();
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            Araba araba = new Araba();
            araba.Marka = txtMarka.Text;
            araba.Model = txtModel.Text;
            araba.Renk = txtRenk.Text;

            galari.ArabaEkle(araba);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = galari.ArabaListele();
            dataGridView1.DataSource = galari.ArabaListesiVer();
           
        }
    }
}
