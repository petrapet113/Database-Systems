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
    public partial class IzmeniZaposlenogForm : Form
    {
        ProdajnoMestoBasic prod;
        public IzmeniZaposlenogForm()
        {
            InitializeComponent();
        }
        public IzmeniZaposlenogForm(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            prod = p;
        }

        private void IzmeniZaposlenogForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajNovogRadnika_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da izmenite zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ZaposleniBasic zaposleni = new ZaposleniBasic();

                
                zaposleni.JMBG = Int64.Parse(textBoxJMBG.Text);
                zaposleni.Ime = textBoxIme.Text;
                zaposleni.Prezime = textBoxPrezime.Text;
                zaposleni.DatumRođenja = dateTimePickerDatumRodjenja.Value;
                zaposleni.Ulica = textBoxUlica.Text;
                zaposleni.Broj = Int32.Parse(textBoxBroj.Text);
                zaposleni.Grad = textBoxGrad.Text;
                string mesto = textBoxProdMesto.Text;
                

                DTOManager.AzurirajZaposlenog(zaposleni, mesto);

                MessageBox.Show("Uspesno ste dodali novog zaposlenog!");
                this.Close();
            }
            else
            {

            }

            this.Close();

        }
    }
}
