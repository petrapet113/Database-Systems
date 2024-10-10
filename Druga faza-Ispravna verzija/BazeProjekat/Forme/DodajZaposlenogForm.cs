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
    public partial class DodajZaposlenogForm : Form
    {
        ProdajnoMestoBasic ProdMesto;
        public DodajZaposlenogForm()
        {
            InitializeComponent();
           
        }
        public DodajZaposlenogForm(ProdajnoMestoBasic prodmesto)
        {
            InitializeComponent();
            ProdMesto = prodmesto;
        }

        private void ZaposleniForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajNovogRadnika_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog zaposlenog?";
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
                zaposleni.RadiUProdMesto = ProdMesto;

                DTOManager.DodajZaposlenog(zaposleni);

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
