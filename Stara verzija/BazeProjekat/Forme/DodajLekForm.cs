using BazeProjekat.Entiteti;
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
    public partial class DodajLekForm : Form
    {
        public DodajLekForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi lek?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                LekBasic lek = new LekBasic();



                lek.KomercijalniNaziv = textBoxKomercijalniNaziv.Text;
                lek.HemijskiNaziv = textBoxHemijskiNaziv.Text;
                lek.DozaDeca = Int32.Parse(textBoxDozaDeca.Text);
                lek.DozaOdrasli = Int32.Parse(textBoxDozaOdrasli.Text);
                lek.DozaTrudnice = Int32.Parse(textBoxDozaTrudnice.Text);
                lek.Cena = Int32.Parse(textBoxCena.Text);
                string proizvodjac= textBoxProizvodjac.Text;
                Proizvođač pr = DTOManager.VratiProizvodjaca(proizvodjac);
                lek.ProizvodiLek = pr;
                PrimarnaGrupa p = DTOManager.VratiPrimarnuGrupu(textBoxPrimarnaGrupa.Text);

                lek.JePrimarnaGrupa = p;
                DTOManager.DodajLek(lek);

     
                

            }
            else
            {

            }

            this.Close();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUlica_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodajProdavnicu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHemijskiNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajLekForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
