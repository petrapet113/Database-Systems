using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  BazeProjekat.Entiteti;

namespace BazeProjekat.Forme
{
    public partial class KontraindikacijeLekForm : Form
    {
        LekBasic lek= new LekBasic();
        public KontraindikacijeLekForm()
        {
            InitializeComponent();
        }
        public KontraindikacijeLekForm(LekBasic l)
        {
            InitializeComponent();
            lek = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da unesete kontraindikaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                KontraindikacijeBasic lekNovi = new KontraindikacijeBasic();
                lekNovi.Id.KontraindikacijeLeka = textBoxKontraindikacije.Text;
                Lek l = new Lek();
                l.Id = lek.Id;
                l.HemijskiNaziv = lek.HemijskiNaziv;
                l.KomercijalniNaziv = lek.KomercijalniNaziv;
                l.DozaDeca = lek.DozaDeca;
                l.DozaOdrasli = lek.DozaOdrasli;
                l.DozaTrudnice = l.DozaTrudnice;
                l.Cena = l.Cena;
                lekNovi.Id.LekImaKontraindikacije = l;
                DTOManager.DodajKontraindikacijuLeku(lekNovi);

               

            }
            else
            {

            }

            this.Close();
            
        }

        private void KontraindikacijeLekForm_Load(object sender, EventArgs e)
        {

        }
    }
}
