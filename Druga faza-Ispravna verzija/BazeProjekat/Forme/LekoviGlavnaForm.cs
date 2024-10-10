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
    public partial class LekoviGlavnaForm : Form
    {
        public LekoviGlavnaForm()
        {
            InitializeComponent();
        }
        public void popuniPodatke()
        {
            listViewLekovi.Items.Clear();
            List<LekPregled> podaci = DTOManager.VratiSveLekove();

            foreach (LekPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    z.Id.ToString(),z.KomercijalniNaziv,z.HemijskiNaziv,z.Cena.ToString(),z.DozaDeca.ToString(),z.DozaOdrasli.ToString(),z.DozaTrudnice.ToString(),z.proizvodjac
                });
                listViewLekovi.Items.Add(item);
            }
            listViewLekovi.Refresh();

        }

        private void LekoviForm_Load(object sender, EventArgs e)
        {
            popuniPodatke();

        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            DodajLekForm forma = new DodajLekForm();
            forma.ShowDialog();
        }

        private void listViewLekovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewLekovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lek kome zelite da dodate kontraindikacije!");
                return;
            }

            int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
            LekBasic p = DTOManager.VratiLek(idLeka);

            KontraindikacijeLekForm forma = new KontraindikacijeLekForm(p);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewLekovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lek kome zelite da dodate nezeljene efekte!");
                return;
            }

            int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
            LekBasic p = DTOManager.VratiLek(idLeka);

            NezeljeniEfektiLekForm forma = new NezeljeniEfektiLekForm(p);
            forma.ShowDialog();

        }

        private void button1Izmeni_Click(object sender, EventArgs e)
        {
            IzmeniLekForm forma = new IzmeniLekForm();
            forma.ShowDialog();
            


        }

        private void button1Obriši_Click(object sender, EventArgs e)
        {
            if (listViewLekovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lek koji zelite da obrisete!");
                return;
            }

            int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
            DTOManager.ObrisiLek(idLeka);
            MessageBox.Show("Uspesno ste obrisali lek!");
            popuniPodatke();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewLekovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lek kome zelite da pridruzite bolest!");
                return;
            }

            int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
            LekBasic l = DTOManager.VratiLek(idLeka);
            BolestiForm forma = new BolestiForm(l);
            forma.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listViewLekovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lek kome zelite da dodate vrstu pakovanja!");
                return;
            }

            int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
           // LekBasic p = DTOManager.VratiLek(idLeka);
            VrstaPakovanjaPravaForm forma = new VrstaPakovanjaPravaForm(idLeka);
            forma.ShowDialog();
        }
    }
}
