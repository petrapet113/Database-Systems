using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazeProjekat.Forme;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Forme
{
    public partial class NezeljeniEfektiLekForm : Form
    {
        LekBasic lek = new LekBasic();
        public NezeljeniEfektiLekForm()
        {
            InitializeComponent();
        }
        public NezeljeniEfektiLekForm(LekBasic l)
        {
            InitializeComponent();
            lek = l;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VrstaPakovanjaPravaForm forma = new VrstaPakovanjaPravaForm(lek.Id);
            forma.ShowDialog();
            //dodaj lek
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da unesete nezeljeni efekat leku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                NezeljeniEfektiBasic lekNovi = new NezeljeniEfektiBasic();
                lekNovi.Id.NeželjeniEfektiLeka = textBoxKontraindikacije.Text;
                Lek l = new Lek();
                l.Id = lek.Id;
                l.HemijskiNaziv = lek.HemijskiNaziv;
                l.KomercijalniNaziv = lek.KomercijalniNaziv;
                l.DozaDeca = lek.DozaDeca;
                l.DozaOdrasli = lek.DozaOdrasli;
                l.DozaTrudnice = l.DozaTrudnice;
                l.Cena = l.Cena;
                lekNovi.Id.LekImaNeželjeneEfekte = l;
                DTOManager.DodajNezeljeniEfakatLeku(lekNovi);



            }
            else
            {

            }

            this.Close();
        }
    }
}
