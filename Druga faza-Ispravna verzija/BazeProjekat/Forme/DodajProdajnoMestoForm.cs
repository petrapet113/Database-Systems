using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeProjekat.Forme
{
    public partial class DodajProdajnoMestoForm : Form
    {
        public DodajProdajnoMestoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo prodajno mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ProdajnoMestoBasic prodMesto = new ProdajnoMestoBasic();
                prodMesto.Naziv = textBoxNaziv.Text;
                prodMesto.Ulica = textBoxUlica.Text;
                prodMesto.Broj = Int32.Parse(textBoxBroj.Text);
                prodMesto.Grad = textBoxGrad.Text;


                DTOManager.DodajProdajnoMesto(prodMesto);
                MessageBox.Show("Uspesno ste dodali novo prodajno mesto!");
                this.Close();
            }
            else
            {

            }
        }

        private void DodajProdajnoMestoForm_Load(object sender, EventArgs e)
        {
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
