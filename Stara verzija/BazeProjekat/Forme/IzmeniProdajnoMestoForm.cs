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
    public partial class IzmeniProdajnoMestoForm : Form
    {
        public IzmeniProdajnoMestoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IzmeniProdajnoMestoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene prodavnice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ProdajnoMestoBasic prod = new ProdajnoMestoBasic();
                prod.Id = Int32.Parse(textBoxId.Text);
                prod.Naziv = textBoxNaziv.Text;
                prod.Grad = textBoxGrad.Text;
                prod.Ulica = textBoxUlica.Text;
                prod.Broj = Int32.Parse(textBoxBroj.Text);


                DTOManager.AzurirajProdajnoMesto(prod);
                MessageBox.Show("Azuriranje prodajnog mesta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }

        }
    }
}
