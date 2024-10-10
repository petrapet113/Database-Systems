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
    public partial class IzmeniLekForm : Form
    {
        public IzmeniLekForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene leka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                LekBasic lek = new LekBasic();

                lek.Id= Int32.Parse(textBox1.Text);

                lek.KomercijalniNaziv = textBoxKomercijalniNaziv.Text;
                lek.HemijskiNaziv = textBoxHemijskiNaziv.Text;
                lek.DozaDeca = Int32.Parse(textBoxDozaDeca.Text);
                lek.DozaOdrasli = Int32.Parse(textBoxDozaOdrasli.Text);
                lek.DozaTrudnice = Int32.Parse(textBoxDozaTrudnice.Text);
                lek.Cena = Int32.Parse(textBoxCena.Text);
                
                PrimarnaGrupa p = DTOManager.VratiPrimarnuGrupu(textBoxPrimarnaGrupa.Text);

                lek.JePrimarnaGrupa = p;
                DTOManager.AzurirajLek(lek);
                MessageBox.Show("Azuriranje leka je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void IzmeniLekForm_Load(object sender, EventArgs e)
        {

        }
    }
}
